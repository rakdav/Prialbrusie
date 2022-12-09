using Prialbrusie.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prialbrusie
{
    public partial class FormAutorization : Form
    {
        private int hours, minutes, seconds;
        private string text = String.Empty;
        private int count=0;
        private bool stop=false;
        public FormAutorization()
        {
            InitializeComponent();
            pictureBoxCapture.Visible = false;
            textBoxCapcha.Visible = false;
            buttonGen.Visible = false;
        }

        private void checkBoxShow_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShow.Checked) textBoxPassword.UseSystemPasswordChar = false;
            else textBoxPassword.UseSystemPasswordChar = true;  
        }

        private async void buttonEnter_Click(object sender, EventArgs e)
        {
            count++;
            using (ModelDB DB=new ModelDB())
            {
                User user= await DB.User.Where(p=>p.login.Equals(textBoxLogin.Text)&&p.password.Equals(textBoxPassword.Text)).FirstOrDefaultAsync();
                switch(count)
                {
                    case 1: if (user != null) ShowWindow(user,DB); break;
                    case 2:
                        if (user != null)
                        {
                            ShowWindow(user, DB);
                        }
                        else
                        {
                            MessageBox.Show("Пользователя или пароля не существует");
                        };
                        break;
                    case 3:
                        if (user != null)
                        {
                            ShowWindow(user, DB);
                        }
                        else
                        {
                            MessageBox.Show("Пользователя или пароля не существует");
                            pictureBoxCapture.Visible = true;
                            textBoxCapcha.Visible = true;
                            buttonGen.Visible = true;
                            pictureBoxCapture.Image = this.CreateImage(pictureBoxCapture.Width,
                                pictureBoxCapture.Height);
                        };
                        break;
                    default:
                        if (user != null&&text.Equals(textBoxCapcha.Text))
                        {
                            ShowWindow(user, DB);
                        }
                        else 
                        {
                            stop = true;
                            buttonEnter.Enabled = false;
                            timerStop.Enabled = true;
                            buttonEnter.BackColor = Color.Red;
                        }
                        break;
                }
            }
        }
        private void ShowWindow(User user,ModelDB DB)
        {
            count = 0;
            FormControl formControl = new FormControl(user);
            this.Hide();
            formControl.ShowDialog();
            user.LastEnter = DateTime.Now;
            DB.Entry(user).State = EntityState.Modified;
            DB.SaveChanges();
            if (formControl.DialogResult == DialogResult.OK)
            {
                this.Show();
                if (formControl.getStop())
                {
                    buttonEnter.Enabled = false;
                    timerStop.Enabled = true;
                    buttonEnter.BackColor = Color.Red;
                }
            }
        }
        private void buttonGen_Click(object sender, EventArgs e)
        {
            pictureBoxCapture.Image = this.CreateImage(pictureBoxCapture.Width,
                            pictureBoxCapture.Height);
        }

        private void timerStop_Tick(object sender, EventArgs e)
        {
            seconds++;
            if (seconds == 60)
            {
                minutes++;
                seconds = 0;
            }
            if (minutes == 1)
            {
                buttonEnter.Enabled = true;
                timerStop.Enabled = false;
                buttonEnter.BackColor = Color.Green;
            }
            if(stop&&seconds==10)
            {
                buttonEnter.Enabled = true;
                timerStop.Enabled = false;
                buttonEnter.BackColor = Color.Green;
                stop = false;
            }
        }
        private Bitmap CreateImage(int width,int height)
        {
            Random random = new Random();
            Bitmap result = new Bitmap(width,height);
            int Xpos = random.Next(0, width - 20);
            int Ypos = random.Next(0, height - 10);
            Brush[] colors =
            {
                Brushes.Black,
                Brushes.Red,
                Brushes.RoyalBlue,
                Brushes.Green
            };
            Graphics g = Graphics.FromImage((Image)result);
            g.Clear(Color.Gray);
            text = String.Empty;
            string ALF = "0123456789QWERTYUIOPASDFGHJKLZXCVBNM";
            for (int i = 0; i < 3; i++) text += ALF[random.Next(ALF.Length)];
            g.DrawString(text,new Font("Comic Sans MS", 20), 
                colors[random.Next(colors.Length)],new PointF(Xpos,Ypos));
            g.DrawLine(Pens.Black, new Point(0, 0), new Point(width - 1, height - 1));
            g.DrawLine(Pens.Black,new Point(0,height-1),new Point(width-1,0));
            for(int i=0;i<width;i++)
            {
                for (int j = 0; j < height; j++)
                {
                    if (random.Next() % 20 == 0)
                        result.SetPixel(i,j,Color.White);
                }
            }
            return result;
        }
    }
}
