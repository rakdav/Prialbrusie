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
    public partial class FormZakaz : Form
    {
        public FormZakaz()
        {
            InitializeComponent();
            using (ModelDB db = new ModelDB())
            {
                var clients=db.Client.Select(p=>p.Firstname).ToList();
                foreach (var item in clients)
                {
                    comboBoxClient.Items.Add(item);
                }
                var statuses = db.Status.ToList();
                foreach (var item in statuses)
                {
                    comboBoxStatus.Items.Add(item);
                }
                var zakazes=db.Zakaz.ToList();
                dataGridViewZakaz.DataSource=zakazes;
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            using (ModelDB db = new ModelDB())
            {
                int max = db.Zakaz.Max(p => p.id);
                textBoxNumber.Text = max.ToString();
            }
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {

        }
    }
}
