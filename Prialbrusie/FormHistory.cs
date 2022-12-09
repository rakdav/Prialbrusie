using Prialbrusie.Model;
using System;
using System.Collections;
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
    public partial class FormHistory : Form
    {
        private bool sort;
        public FormHistory()
        {
            InitializeComponent();
            using (ModelDB db = new ModelDB())
            {
                var query = from history in db.User
                            select new
                            {
                                Логин = history.login,
                                ПоследнийВход = history.LastEnter,
                                ПопыткаВхода = db.Type.Where(p => p.id == history.type).FirstOrDefault().name
                            };
                dataGridViewHistory.DataSource = query.ToList();
                var listLogin= db.User.ToList().Distinct();
                foreach (var item in listLogin)
                {
                    comboBoxLogin.Items.Add(item.login);
                }
            }
        }

        private void dataGridViewHistory_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            sort = !sort;
            if (sort)
            {
                using (ModelDB db = new ModelDB())
                {
                    var query = from history in db.User
                                orderby history.login
                                select new
                                {
                                    Логин = history.login,
                                    ПоследнийВход = history.LastEnter,
                                    ПопыткаВхода = db.Type.Where(p => p.id == history.type).FirstOrDefault().name
                                };
                    dataGridViewHistory.DataSource = query.ToList();
                }
            }
            else
            {
                using (ModelDB db = new ModelDB())
                {
                    var query = from history in db.User
                                orderby history.login descending
                                select new
                                {
                                    Логин = history.login,
                                    ПоследнийВход = history.LastEnter,
                                    ПопыткаВхода = db.Type.Where(p => p.id == history.type).FirstOrDefault().name
                                };
                    dataGridViewHistory.DataSource = query.ToList();
                }
            }
        }

        private void comboBoxLogin_SelectedIndexChanged(object sender, EventArgs e)
        {
            string login=comboBoxLogin.SelectedItem.ToString();
            if (login.Length != 0)
            {
                using (ModelDB db = new ModelDB())
                {
                    var query = from history in db.User
                                where history.login.Equals(login)
                                select new
                                {
                                    Логин = history.login,
                                    ПоследнийВход = history.LastEnter,
                                    ПопыткаВхода = db.Type.Where(p => p.id == history.type).FirstOrDefault().name
                                };
                    dataGridViewHistory.DataSource = query.ToList();
                }
            }
        }

        private void comboBoxLogin_TextChanged(object sender, EventArgs e)
        {
            string login = comboBoxLogin.Text;
            if (login.Length == 0)
            {
                using (ModelDB db = new ModelDB())
                {
                    var query = from history in db.User
                                select new
                                {
                                    Логин = history.login,
                                    ПоследнийВход = history.LastEnter,
                                    ПопыткаВхода = db.Type.Where(p => p.id == history.type).FirstOrDefault().name
                                };
                    dataGridViewHistory.DataSource = query.ToList();
                }
            }
        }
    }
}
