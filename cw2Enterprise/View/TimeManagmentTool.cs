using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cw2Enterprise
{
    public partial class timemanagmentTool : Form
    {
        //Properties
        CreateContactForm ccf;
        createEventForm cef;
        MonthlyView mv;

        public timemanagmentTool()
        {
            InitializeComponent();

            //Creates buttons on runtime
            DynamicButtonCreateEvent();
            DynamicButtonCreateContact();
            DynamicButtonMonthlyView();
        }

        //Dynamic Buttons

        //Create Event Button
        private void DynamicButtonCreateEvent()
        {
            // Create a Button object 
            Button CreateEventButton = new Button();

            // Set Button properties
            this.AutoSize = true;
            CreateEventButton.Height = 62;
            CreateEventButton.Width = 264;
            CreateEventButton.BackColor = Color.DarkBlue;
            CreateEventButton.ForeColor = Color.White;
            CreateEventButton.Location = new Point(12, 400);
            CreateEventButton.Text = "Create Event";
            CreateEventButton.Name = "Create Event";
            CreateEventButton.Font = new Font("Microsoft Sans Serif", 8);

            // Add a Button Click Event handler
            CreateEventButton.Click += new EventHandler(DynamicButtonCreateEvent_Click);
            //Adds button to form
            Controls.Add(CreateEventButton);
        }

        private void DynamicButtonCreateEvent_Click(object sender, EventArgs e)
        {
            //Create new instance of createEventForm
            cef = new createEventForm();

            //Activate it
            cef.Activate();

            //Show as a model box
            cef.ShowDialog();
        }

        //Create Contact Button
        private void DynamicButtonCreateContact()
        {
            // Create a Button object 
            Button CreateContactButton = new Button();

            // Set Button properties
            this.AutoSize = true;
            CreateContactButton.Height = 62;
            CreateContactButton.Width = 264;
            CreateContactButton.BackColor = Color.DarkBlue;
            CreateContactButton.ForeColor = Color.White;
            CreateContactButton.Location = new Point(392, 400);
            CreateContactButton.Text = "Create Contact";
            CreateContactButton.Name = "Create Contact";
            CreateContactButton.Font = new Font("Microsoft Sans Serif", 8);

            // Add a Button Click Event handler
            CreateContactButton.Click += new EventHandler(DynamicButtonCreateContact_Click);
            //Adds button to form
            Controls.Add(CreateContactButton);
        }

        private void DynamicButtonCreateContact_Click(object sender, EventArgs e)
        {
            //Create new instance of createEventForm
            ccf = new CreateContactForm();

            //Activate it
            ccf.Activate();

            //Show as a model box
            ccf.ShowDialog();
        }

        //Monthly View Button
        private void DynamicButtonMonthlyView()
        {
            // Create a Button object 
            Button MonthlyViewButton = new Button();

            // Set Button properties
            this.AutoSize = true;
            MonthlyViewButton.Height = 62;
            MonthlyViewButton.Width = 264;
            MonthlyViewButton.BackColor = Color.DarkBlue;
            MonthlyViewButton.ForeColor = Color.White;
            MonthlyViewButton.Location = new Point(773, 400);
            MonthlyViewButton.Text = "Monthly View";
            MonthlyViewButton.Name = "Monthly View";
            MonthlyViewButton.Font = new Font("Microsoft Sans Serif", 8);

            // Add a Button Click Event handler
            MonthlyViewButton.Click += new EventHandler(DynamicButtonMonthlyView_Click);
            
            //Adds button to form
            Controls.Add(MonthlyViewButton);
        }

        private void DynamicButtonMonthlyView_Click(object sender, EventArgs e)
        {
            //Create new instance of createEventForm
            mv = new MonthlyView();

            //Activate it
            mv.Activate();

            //Show as a model box
            mv.ShowDialog();
        }

        private void timemanagmentTool_Load(object sender, EventArgs e)
        {
            this.AutoSize = true;
        }
    }
}
