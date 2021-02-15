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
    public partial class createEventForm : Form
    {
        private EventModel em;
        DataSet dataset = new DataSet();
        XmlDocument xmlDoc = new XmlDocument();

        internal EventModel Em
        {
            get { return em; }
            set { em = value; }
        }

        public createEventForm()
        {
            InitializeComponent();
  
            //XML path where the events are stored
            xmlDoc.Load("C:\\Users\\Tugrul\\OneDrive\\Desktop\\Enterpirse Application Development\\cw2Enterprise\\cw2Enterprise\\XML\\eventDetails.xml");

            var nodes = xmlDoc.SelectNodes("/array/Events/EventName");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.AutoGenerateColumns = true;
        }

        //Create Event Button
        private void submit_Click(object sender, EventArgs e)
        {
            //Checks if textboxes are empty
            if (textBoxEventName.Text == "" || dateTimePicker1.Text == "" || textBoxLocation.Text == "" || comboBoxReoccuring.Text == "" || textBoxContactDetails.Text == "" || comboBoxEventType.Text == "")
            {
                this.labelStatus.Text = "You must complete all details";
            }
            else
            { 
                //And File path will be passed as string

                //eventDetails XML is created
                XmlNode x = xmlDoc.CreateElement("Events");

                // The text inside the XML file are called Nodes
                XmlNode Name = xmlDoc.CreateElement("EventName");
                Name.InnerText = textBoxEventName.Text;
                x.AppendChild(Name);

                XmlNode _DateTime = xmlDoc.CreateElement("Date");
                _DateTime.InnerText = dateTimePicker1.Text;
                x.AppendChild(_DateTime);

                XmlNode Location = xmlDoc.CreateElement("Location");
                Location.InnerText = textBoxLocation.Text;
                x.AppendChild(Location);

                XmlNode Reoccurence = xmlDoc.CreateElement("Reoccurence");
                Reoccurence.InnerText = comboBoxReoccuring.Text;
                x.AppendChild(Reoccurence);

                XmlNode EventType = xmlDoc.CreateElement("Event_Type");
                EventType.InnerText = comboBoxEventType.Text;
                x.AppendChild(EventType);

                XmlNode Contact = xmlDoc.CreateElement("Contact_Details");
                Contact.InnerText = textBoxContactDetails.Text;
                x.AppendChild(Contact);

                XmlNode Notes = xmlDoc.CreateElement("Notes");
                Notes.InnerText = richTextBoxNotes.Text;
                x.AppendChild(Notes);

                xmlDoc.DocumentElement.AppendChild(x);
                
                //Saves to XML and reads the xml to show on datagrid
                xmlDoc.Save("C:\\Users\\Tugrul\\OneDrive\\Desktop\\Enterpirse Application Development\\cw2Enterprise\\cw2Enterprise\\XML\\eventDetails.xml");
                dataset.ReadXml(@"C:\\Users\\Tugrul\\OneDrive\\Desktop\\Enterpirse Application Development\\cw2Enterprise\\cw2Enterprise\\XML\\eventDetails.xml");
                
                //Adds event to datagrid on form
                this.Controls.Add(dataGridView1);
                dataGridView1.DataSource = dataset.Tables[0];

                MessageBox.Show("You have added an event");

                //Clear text boxes after submit
                textBoxEventName.Text = "";
                textBoxLocation.Text = "";
                comboBoxReoccuring.Text = "";
                comboBoxEventType.Text = "";
                textBoxContactDetails.Text = "";
                richTextBoxNotes.Text = "";
            }
        }

        //DateTime picker format
        private void datetime_MouseDown(object sender, MouseEventArgs e)
        {
            dateTimePicker1.CustomFormat = "dd/MM/yyyy\t HH:mm";
        }

        //Close Window button
        private void close_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }

        //View Event Button
        private void view_Click(object sender, EventArgs e)
        {
            try
            {
                //Reads XML and updates datagrid
                DataSet dataset = new DataSet();
                dataset.ReadXml(@"C:\\Users\\Tugrul\\OneDrive\\Desktop\\Enterpirse Application Development\\cw2Enterprise\\cw2Enterprise\\XML\\eventDetails.xml");

                this.Controls.Add(dataGridView1);
                dataGridView1.DataSource = dataset.Tables[0];
            }
            catch (System.IndexOutOfRangeException)
            {
                MessageBox.Show("Data grid is empty");
            }
           
        }

        //Delete button
        private void delete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.RemoveAt(item.Index);
            }
            xmlDoc.Save(@"C:\\Users\\Tugrul\\OneDrive\\Desktop\\Enterpirse Application Development\\cw2Enterprise\\cw2Enterprise\\XML\\eventDetails.xml");
        }
    }
}
