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
        public FormAutorization()
        {
            InitializeComponent();
        }

        private void checkBoxShow_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShow.Checked) textBoxPassword.UseSystemPasswordChar = false;
            else textBoxPassword.UseSystemPasswordChar = true;  
        }

        private async void buttonEnter_Click(object sender, EventArgs e)
        {
            using (ModelDB DB=new ModelDB())
            {
                User user= await DB.User.Where(p=>p.login.Equals(textBoxLogin.Text)&&p.password.Equals(textBoxPassword.Text)).FirstOrDefaultAsync();
                if (user != null)
                {
                    FormControl formControl = new FormControl(user);
                    this.Hide();
                    formControl.ShowDialog();
                    user.LastEnter= DateTime.Now;
                    DB.Entry(user).State = EntityState.Modified;
                    DB.SaveChanges();
                    if(formControl.DialogResult==DialogResult.OK)
                    {
                        this.Show();
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
