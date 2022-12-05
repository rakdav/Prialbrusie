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
        public FormControl(User user)
        {
            InitializeComponent();
            var myAssembly = Assembly.GetExecutingAssembly();
            pictureBoxUser.Image = Image.FromFile(user.Firstname + ".jpeg");
            labelFirstName.Text = user.Firstname;
            labelName.Text = user.Surname;
            using (ModelDB db = new ModelDB())
            {
                labelRole.Text = db.Role.Where(p => p.Id == user.id_role).FirstOrDefault().name;
            }
            timer1.Interval = 1000;
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
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
            labelTimer.Text = "Таймер:"+String.Format("{0:HH}:{1:mm}:{2:ss}",hours,minutes,seconds);
        }
    }
}
