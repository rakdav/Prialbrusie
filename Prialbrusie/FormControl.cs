using Prialbrusie.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prialbrusie
{
    public partial class FormControl : Form
    {
        private int hours, minutes, seconds;

        private void FormControl_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        public FormControl(User user)
        {
            InitializeComponent();
            var myAssembly = Assembly.GetExecutingAssembly();
            pictureBoxUser.Image = Image.FromFile(user.Firstname + ".jpeg");
            labelFirstName.Text ="Фамилия:"+user.Firstname;
            labelName.Text ="Имя:"+user.Surname;
            using (ModelDB db = new ModelDB())
            {
                labelRole.Text ="Должность:"+db.Role.Where(p => p.Id == user.id_role).FirstOrDefault().name;
            }
            timer1.Interval = 1000;
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            seconds++;
            if(seconds==60)
            {
                minutes++;
                seconds = 0;
            }
            if(minutes==60)
            {
                hours++;
                minutes = 0;
            }
            if(hours==0&minutes==5)
            {
                MessageBox.Show("Через 15 минут сеанс будет завершен.",
                    "Сообщение", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            if (hours == 0 & minutes == 10)
            {
                Application.Exit();
            }
            labelTimer.Text = "Таймер:"+String.Format("{0:d2}:{1:d2}:{2:d2}",hours,minutes,seconds);
        }
    }
}
