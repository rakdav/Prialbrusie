using Prialbrusie.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prialbrusie
{
    public partial class FormAutorization : Form
    {
        public FormAutorization()
        {
            InitializeComponent();
        }

        private void checkBoxShow_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShow.Checked) textBoxPassword.UseSystemPasswordChar = false;
            else textBoxPassword.UseSystemPasswordChar = true;  
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            using (ModelDB DB=new ModelDB())
            {
                User user=DB.User.Where(p=>p.login.Equals(textBoxLogin.Text)&&p.password.Equals(textBoxPassword.Text)).FirstOrDefault();
                if (user != null)
                {
                    if(user.id_role==1)
                    {

                    }
                    else if(user.id_role==2)
                    {

                    }
                    else
                    {

                    }
                }
                else
                {
                    MessageBox.Show("Пользователя или пароля не существует");
                }
            }
        }
    }
}
