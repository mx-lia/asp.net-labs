using lab_7c.ServiceReference;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_7c
{
    public partial class Form1 : Form
    {
        ServiceClient client = new ServiceClient();

        private void GetRecords()
        {
            BindingList<Record> bindingList = new BindingList<Record>(client.GetAll());
            var source = new BindingSource(bindingList, null);
            records.DataSource = source;
        }

        public Form1()
        {
            InitializeComponent();
            GetRecords();
        }

        private void insert_Click(object sender, EventArgs e)
        {
            client.Add(name.Text, phone.Text);
            GetRecords();
        }

        private void update_Click(object sender, EventArgs e)
        {
            client.Update(long.Parse(recordID.Text), name.Text, phone.Text);
            GetRecords();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            client.Delete(long.Parse(recordID.Text));
            GetRecords();
        }
    }
}
