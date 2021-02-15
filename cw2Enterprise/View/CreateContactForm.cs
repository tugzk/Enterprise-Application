using System;
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
    public partial class CreateContactForm : Form
    {
        private ContactModel cm;
        XmlDocument xmlDoc = new XmlDocument();

        internal ContactModel Cm
        {
            get { return cm; }
            set { cm = value; }
        }

        public CreateContactForm()
        {
            InitializeComponent();

            //XML path where contacts are saved
            xmlDoc.Load("C:\\Users\\Tugrul\\OneDrive\\Desktop\\Enterpirse Application Development\\cw2Enterprise\\cw2Enterprise\\XML\\contactDetails.xml");

            var nodes = xmlDoc.SelectNodes("/array/Name/PhoneNumber");
        }

        //Forces user to enter numbers for phone number
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBoxPhoneNumber.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                textBoxPhoneNumber.Text = textBoxPhoneNumber.Text.Remove(textBoxPhoneNumber.Text.Length - 1);
            }
        }

        //Create Contact button click
        private void buttonCreateContact_Click(object sender, EventArgs e)
        {
            //Checks textboxes are not empty before submitting form
            if (textBoxName.Text == "" || textBoxEmail.Text == "" || textBoxPhoneNumber.Text == "")
            {
                this.labelStatus2.Text = "You must complete all details";
            }
            else
            {
                //xmlDoc.load method will load the file specified into the application
                //And File path will be passed as string
                xmlDoc.Load("C:\\Users\\Tugrul\\OneDrive\\Desktop\\Enterpirse Application Development\\cw2Enterprise\\cw2Enterprise\\XML\\contactDetails.xml");

                //Contacts XML is created
                XmlNode y = xmlDoc.CreateElement("Contacts");

                // The text inside the XML file are called Node
                XmlNode Name = xmlDoc.CreateElement("Name");
                Name.InnerText = textBoxName.Text;
                y.AppendChild(Name);

                XmlNode Email = xmlDoc.CreateElement("Email");
                Email.InnerText = textBoxEmail.Text;
                y.AppendChild(Email);

                XmlNode PhoneNumber = xmlDoc.CreateElement("phoneNumber");
                PhoneNumber.InnerText = textBoxPhoneNumber.Text;
                y.AppendChild(PhoneNumber);

                xmlDoc.DocumentElement.AppendChild(y);

                //pathway
                xmlDoc.Save("C:\\Users\\Tugrul\\OneDrive\\Desktop\\Enterpirse Application Development\\cw2Enterprise\\cw2Enterprise\\XML\\contactDetails.xml");

                DataSet dataset = new DataSet();
                dataset.ReadXml(@"C:\\Users\\Tugrul\\OneDrive\\Desktop\\Enterpirse Application Development\\cw2Enterprise\\cw2Enterprise\\XML\\contactDetails.xml");

                this.Controls.Add(dataGridView1);
                dataGridView1.DataSource = dataset.Tables[0];

                MessageBox.Show("You have added an contact");

                //Clear Text box after submit
                textBoxName.Text = "";
                textBoxPhoneNumber.Text = "";
                textBoxEmail.Text = "";
            }
        }

        //View Contact button
        private void buttonView_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet dataSet = new DataSet();
                dataSet.ReadXml(@"C:\\Users\\Tugrul\\OneDrive\\Desktop\\Enterpirse Application Development\\cw2Enterprise\\cw2Enterprise\\XML\\contactDetails.xml");
                dataGridView1.DataSource = dataSet.Tables[0];
            }
            catch (System.IndexOutOfRangeException)
            {
                MessageBox.Show("Data grid is empty");
            }
            
        }

        //Close Window button
        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }

        //Contact Delete button
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            //Deletes from datagrid but does not update XML
            foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.RemoveAt(item.Index);
            }
            xmlDoc.Save(@"C:\\Users\\Tugrul\\OneDrive\\Desktop\\Enterpirse Application Development\\cw2Enterprise\\cw2Enterprise\\XML\\contactDetails.xml");
        }
    }
}
