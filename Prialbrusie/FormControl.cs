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
        private bool stop;

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
            if (user.id_role == 3) buttonHistory.Visible = true;
            if(user.id_role==1||user.id_role==2) buttonZakaz.Visible = true;
        }

        private void buttonHistory_Click(object sender, EventArgs e)
        {
            FormHistory formHistory= new FormHistory();
            formHistory.ShowDialog();
        }

        private void buttonZakaz_Click(object sender, EventArgs e)
        {
            FormZakaz form=new FormZakaz();
            form.ShowDialog();
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
            if(hours==0&&minutes==1)
            {
                label1.Text="Через 15 минут сеанс будет завершен.";
            }
            if (hours == 0 && minutes == 2)
            {
                stop = true;
                this.Close();
            }
            labelTimer.Text = "Таймер:"+String.Format("{0:d2}:{1:d2}:{2:d2}",hours,minutes,seconds);
        }
        public bool getStop()
        {
            return stop;
        }
    }
}
