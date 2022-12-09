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
                var zakazes = from zakaz in db.Zakaz
                              select new
                              {
                                  Kode=zakaz.Kode,
                                  DateStart=zakaz.DateStart,
                                  TimeStart=zakaz.TimeStart,
                                  Client=db.Client.Where(p=>p.id==zakaz.id_client).FirstOrDefault().Firstname,
                                  Status=db.Status.Where(p=>p.id==zakaz.id_status).FirstOrDefault().name,
                                  DateFinish=zakaz.DateFinish
                              };
                dataGridViewZakaz.DataSource=zakazes.ToList();
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
