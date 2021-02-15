namespace cw2Enterprise
{
    partial class createEventForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxEventName = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBoxReoccuring = new System.Windows.Forms.ComboBox();
            this.textBoxContactDetails = new System.Windows.Forms.TextBox();
            this.richTextBoxNotes = new System.Windows.Forms.RichTextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1Submit = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxLocation = new System.Windows.Forms.TextBox();
            this.labelStatus = new System.Windows.Forms.Label();
            this.comboBoxEventType = new System.Windows.Forms.ComboBox();
            this.labelEventType = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Event Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Event Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 406);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Reoccuring?";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 611);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Contact Details";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 703);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Notes";
            // 
            // textBoxEventName
            // 
            this.textBoxEventName.Location = new System.Drawing.Point(220, 134);
            this.textBoxEventName.Name = "textBoxEventName";
            this.textBoxEventName.Size = new System.Drawing.Size(264, 26);
            this.textBoxEventName.TabIndex = 5;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(220, 223);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(264, 26);
            this.dateTimePicker1.TabIndex = 6;
            this.dateTimePicker1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.datetime_MouseDown);
            // 
            // comboBoxReoccuring
            // 
            this.comboBoxReoccuring.FormattingEnabled = true;
            this.comboBoxReoccuring.Items.AddRange(new object[] {
            "Weekly",
            "Monthly",
            "Yearly",
            "One-Off Event"});
            this.comboBoxReoccuring.Location = new System.Drawing.Point(220, 406);
            this.comboBoxReoccuring.Name = "comboBoxReoccuring";
            this.comboBoxReoccuring.Size = new System.Drawing.Size(264, 28);
            this.comboBoxReoccuring.TabIndex = 7;
            // 
            // textBoxContactDetails
            // 
            this.textBoxContactDetails.Location = new System.Drawing.Point(220, 611);
            this.textBoxContactDetails.Name = "textBoxContactDetails";
            this.textBoxContactDetails.Size = new System.Drawing.Size(264, 26);
            this.textBoxContactDetails.TabIndex = 8;
            // 
            // richTextBoxNotes
            // 
            this.richTextBoxNotes.Location = new System.Drawing.Point(220, 700);
            this.richTextBoxNotes.Name = "richTextBoxNotes";
            this.richTextBoxNotes.Size = new System.Drawing.Size(264, 94);
            this.richTextBoxNotes.TabIndex = 9;
            this.richTextBoxNotes.Text = "";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(595, 106);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1148, 749);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button1Submit
            // 
            this.button1Submit.Location = new System.Drawing.Point(22, 887);
            this.button1Submit.Name = "button1Submit";
            this.button1Submit.Size = new System.Drawing.Size(126, 30);
            this.button1Submit.TabIndex = 11;
            this.button1Submit.Text = "Submit";
            this.button1Submit.UseVisualStyleBackColor = true;
            this.button1Submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1489, 887);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(135, 30);
            this.button2.TabIndex = 12;
            this.button2.Text = "Close Window";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.close_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(573, 887);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(127, 30);
            this.button3.TabIndex = 13;
            this.button3.Text = "View Event";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.view_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1067, 887);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(138, 30);
            this.button4.TabIndex = 14;
            this.button4.Text = "Delete Event";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.delete_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 317);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Location";
            // 
            // textBoxLocation
            // 
            this.textBoxLocation.Location = new System.Drawing.Point(220, 311);
            this.textBoxLocation.Name = "textBoxLocation";
            this.textBoxLocation.Size = new System.Drawing.Size(264, 26);
            this.textBoxLocation.TabIndex = 16;
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(216, 887);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(21, 20);
            this.labelStatus.TabIndex = 17;
            this.labelStatus.Text = "...";
            // 
            // comboBoxEventType
            // 
            this.comboBoxEventType.FormattingEnabled = true;
            this.comboBoxEventType.Items.AddRange(new object[] {
            "Appointment",
            "Task"});
            this.comboBoxEventType.Location = new System.Drawing.Point(220, 508);
            this.comboBoxEventType.Name = "comboBoxEventType";
            this.comboBoxEventType.Size = new System.Drawing.Size(264, 28);
            this.comboBoxEventType.TabIndex = 18;
            // 
            // labelEventType
            // 
            this.labelEventType.AutoSize = true;
            this.labelEventType.Location = new System.Drawing.Point(30, 511);
            this.labelEventType.Name = "labelEventType";
            this.labelEventType.Size = new System.Drawing.Size(156, 20);
            this.labelEventType.TabIndex = 19;
            this.labelEventType.Text = "Task or Appointment";
            // 
            // createEventForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(1698, 1003);
            this.Controls.Add(this.labelEventType);
            this.Controls.Add(this.comboBoxEventType);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.textBoxLocation);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1Submit);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.richTextBoxNotes);
            this.Controls.Add(this.textBoxContactDetails);
            this.Controls.Add(this.comboBoxReoccuring);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBoxEventName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "createEventForm";
            this.Text = "createEventForm";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxEventName;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBoxReoccuring;
        private System.Windows.Forms.TextBox textBoxContactDetails;
        private System.Windows.Forms.RichTextBox richTextBoxNotes;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1Submit;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxLocation;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.ComboBox comboBoxEventType;
        private System.Windows.Forms.Label labelEventType;
    }
}