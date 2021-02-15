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
using System.Xml;

namespace cw2Enterprise
{
    public partial class MonthlyView : Form
    {
        XmlDocument xmlDoc = new XmlDocument();
        public DataSet ds { get; set; }
        public DataView dv { get; set; }

        public MonthlyView()
        {
            InitializeComponent();
            ds = new DataSet();
            dv = new DataView();
        }
        
        private void MonthlyView_Load(object sender, EventArgs e)
        {
            string path = "C:\\Users\\Tugrul\\OneDrive\\Desktop\\Enterpirse Application Development\\cw2Enterprise\\cw2Enterprise\\XML\\eventDetails.xml";
            ds.ReadXml(path);
            dv.Table = ds.Tables[0];
            dataGridView1.DataSource = dv;
        }

        //Display all events
        private void display_Click(object sender, EventArgs e)
        {
            DataSet dataset = new DataSet();
            dataset.ReadXml(@"C:\\Users\\Tugrul\\OneDrive\\Desktop\\Enterpirse Application Development\\cw2Enterprise\\cw2Enterprise\\XML\\eventDetails.xml");

            this.Controls.Add(dataGridView1);
            dataGridView1.DataSource = dataset.Tables[0];

        }

        private void buttonDisplayEventForMonth_Click(object sender, EventArgs e)
        {
            dv.RowFilter = "Date like '%" + textBox1.Text + "%'";
            dataGridView1.DataSource = dv;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }
    }
}
