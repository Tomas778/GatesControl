namespace GatesControl
{
    partial class Form1
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
            this.WriteDB = new System.Windows.Forms.Button();
            this.DeleteDB = new System.Windows.Forms.Button();
            this.SimulateEvents = new System.Windows.Forms.Button();
            this.dataView = new System.Windows.Forms.DataGridView();
            this.ReportWorkHours = new System.Windows.Forms.Button();
            this.WorkHoursField = new System.Windows.Forms.TextBox();
            this.SelectorWorkerForWorkHours = new System.Windows.Forms.ComboBox();
            this.SelectWorkerForDBsimulation = new System.Windows.Forms.ComboBox();
            this.SelectGatesForDBsimulation = new System.Windows.Forms.ComboBox();
            this.dateTimePickerStart = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePickerStartTime = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerEndTime = new System.Windows.Forms.DateTimePicker();
            this.ListByTime = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataView)).BeginInit();
            this.SuspendLayout();
            // 
            // WriteDB
            // 
            this.WriteDB.Location = new System.Drawing.Point(12, 12);
            this.WriteDB.Name = "WriteDB";
            this.WriteDB.Size = new System.Drawing.Size(75, 23);
            this.WriteDB.TabIndex = 0;
            this.WriteDB.Text = "Write DB";
            this.WriteDB.UseVisualStyleBackColor = true;
            this.WriteDB.Click += new System.EventHandler(this.WriteDB_Click);
            // 
            // DeleteDB
            // 
            this.DeleteDB.Location = new System.Drawing.Point(13, 39);
            this.DeleteDB.Name = "DeleteDB";
            this.DeleteDB.Size = new System.Drawing.Size(75, 23);
            this.DeleteDB.TabIndex = 1;
            this.DeleteDB.Text = "Delete DB";
            this.DeleteDB.UseVisualStyleBackColor = true;
            this.DeleteDB.Click += new System.EventHandler(this.DeleteDB_Click);
            // 
            // SimulateEvents
            // 
            this.SimulateEvents.Location = new System.Drawing.Point(123, 12);
            this.SimulateEvents.Name = "SimulateEvents";
            this.SimulateEvents.Size = new System.Drawing.Size(122, 23);
            this.SimulateEvents.TabIndex = 2;
            this.SimulateEvents.Text = "Simulate Events";
            this.SimulateEvents.UseVisualStyleBackColor = true;
            this.SimulateEvents.Click += new System.EventHandler(this.SimulateEvents_Click);
            // 
            // dataView
            // 
            this.dataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataView.Location = new System.Drawing.Point(13, 199);
            this.dataView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataView.Name = "dataView";
            this.dataView.RowTemplate.Height = 24;
            this.dataView.Size = new System.Drawing.Size(892, 581);
            this.dataView.TabIndex = 3;
            this.dataView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataView_CellContentClick);
            // 
            // ReportWorkHours
            // 
            this.ReportWorkHours.Location = new System.Drawing.Point(285, 12);
            this.ReportWorkHours.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ReportWorkHours.Name = "ReportWorkHours";
            this.ReportWorkHours.Size = new System.Drawing.Size(122, 23);
            this.ReportWorkHours.TabIndex = 4;
            this.ReportWorkHours.Text = "Report Work Hours";
            this.ReportWorkHours.UseVisualStyleBackColor = true;
            this.ReportWorkHours.Click += new System.EventHandler(this.ReportWorkHours_Click);
            // 
            // WorkHoursField
            // 
            this.WorkHoursField.Location = new System.Drawing.Point(285, 41);
            this.WorkHoursField.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.WorkHoursField.Name = "WorkHoursField";
            this.WorkHoursField.Size = new System.Drawing.Size(123, 20);
            this.WorkHoursField.TabIndex = 5;
            this.WorkHoursField.Text = "??:??:??";
            // 
            // SelectorWorkerForWorkHours
            // 
            this.SelectorWorkerForWorkHours.FormattingEnabled = true;
            this.SelectorWorkerForWorkHours.Items.AddRange(new object[] {
            "Jonas Benaitis",
            "Saulius Prusaitis",
            "Sigis Sigitas",
            "Bronius Kentas",
            "Juozas Semas",
            "Dalius Kentauras",
            "Titas Galvanauskas",
            "Nemantas Mantas",
            "Tilvikas Lizdeika",
            "Zigmas Benamis"});
            this.SelectorWorkerForWorkHours.Location = new System.Drawing.Point(285, 66);
            this.SelectorWorkerForWorkHours.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SelectorWorkerForWorkHours.Name = "SelectorWorkerForWorkHours";
            this.SelectorWorkerForWorkHours.Size = new System.Drawing.Size(255, 21);
            this.SelectorWorkerForWorkHours.TabIndex = 6;
            this.SelectorWorkerForWorkHours.Text = "Select Worker for Report";
            this.SelectorWorkerForWorkHours.SelectedIndexChanged += new System.EventHandler(this.SelectorWorker_SelectedIndexChanged);
            // 
            // SelectWorkerForDBsimulation
            // 
            this.SelectWorkerForDBsimulation.FormattingEnabled = true;
            this.SelectWorkerForDBsimulation.Items.AddRange(new object[] {
            "Jonas Benaitis",
            "Saulius Prusaitis",
            "Sigis Sigitas",
            "Bronius Kentas",
            "Juozas Semas",
            "Dalius Kentauras",
            "Titas Galvanauskas",
            "Nemantas Mantas",
            "Tilvikas Lizdeika",
            "Zigmas Benamis"});
            this.SelectWorkerForDBsimulation.Location = new System.Drawing.Point(123, 41);
            this.SelectWorkerForDBsimulation.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SelectWorkerForDBsimulation.Name = "SelectWorkerForDBsimulation";
            this.SelectWorkerForDBsimulation.Size = new System.Drawing.Size(123, 21);
            this.SelectWorkerForDBsimulation.TabIndex = 7;
            this.SelectWorkerForDBsimulation.Text = "Select Worker";
            this.SelectWorkerForDBsimulation.SelectedIndexChanged += new System.EventHandler(this.SelectWorkerForDBsimulation_SelectedIndexChanged);
            // 
            // SelectGatesForDBsimulation
            // 
            this.SelectGatesForDBsimulation.FormattingEnabled = true;
            this.SelectGatesForDBsimulation.Items.AddRange(new object[] {
            "Main Entrance",
            "Stuff Only",
            "Smoking Area",
            "Lunch Area"});
            this.SelectGatesForDBsimulation.Location = new System.Drawing.Point(123, 66);
            this.SelectGatesForDBsimulation.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SelectGatesForDBsimulation.Name = "SelectGatesForDBsimulation";
            this.SelectGatesForDBsimulation.Size = new System.Drawing.Size(123, 21);
            this.SelectGatesForDBsimulation.TabIndex = 8;
            this.SelectGatesForDBsimulation.Text = "Select Gates";
            this.SelectGatesForDBsimulation.SelectedIndexChanged += new System.EventHandler(this.SelectGatesForDBsimulation_SelectedIndexChanged);
            // 
            // dateTimePickerStart
            // 
            this.dateTimePickerStart.CustomFormat = "yyyy/MM/dd hh:mm:ss";
            this.dateTimePickerStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerStart.Location = new System.Drawing.Point(285, 110);
            this.dateTimePickerStart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePickerStart.MaxDate = new System.DateTime(2023, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerStart.MinDate = new System.DateTime(2022, 12, 1, 0, 0, 0, 0);
            this.dateTimePickerStart.Name = "dateTimePickerStart";
            this.dateTimePickerStart.Size = new System.Drawing.Size(123, 20);
            this.dateTimePickerStart.TabIndex = 9;
            this.dateTimePickerStart.Value = new System.DateTime(2022, 12, 1, 0, 0, 0, 0);
            this.dateTimePickerStart.ValueChanged += new System.EventHandler(this.dateTimePickerStart_ValueChanged);
            // 
            // dateTimePickerEnd
            // 
            this.dateTimePickerEnd.CustomFormat = "yyyy/MM/dd hh:mm:ss";
            this.dateTimePickerEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerEnd.Location = new System.Drawing.Point(285, 150);
            this.dateTimePickerEnd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePickerEnd.Name = "dateTimePickerEnd";
            this.dateTimePickerEnd.Size = new System.Drawing.Size(123, 20);
            this.dateTimePickerEnd.TabIndex = 10;
            this.dateTimePickerEnd.Value = new System.DateTime(2022, 12, 5, 19, 52, 0, 0);
            this.dateTimePickerEnd.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(178, 112);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Start Date and Time:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(184, 153);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Start Date and End:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // dateTimePickerStartTime
            // 
            this.dateTimePickerStartTime.CustomFormat = "";
            this.dateTimePickerStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerStartTime.Location = new System.Drawing.Point(418, 110);
            this.dateTimePickerStartTime.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePickerStartTime.MaxDate = new System.DateTime(2023, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerStartTime.MinDate = new System.DateTime(2022, 12, 1, 0, 0, 0, 0);
            this.dateTimePickerStartTime.Name = "dateTimePickerStartTime";
            this.dateTimePickerStartTime.Size = new System.Drawing.Size(84, 20);
            this.dateTimePickerStartTime.TabIndex = 13;
            this.dateTimePickerStartTime.Value = new System.DateTime(2022, 12, 14, 0, 0, 0, 0);
            this.dateTimePickerStartTime.ValueChanged += new System.EventHandler(this.dateTimePickerStartTime_ValueChanged);
            // 
            // dateTimePickerEndTime
            // 
            this.dateTimePickerEndTime.CustomFormat = "";
            this.dateTimePickerEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerEndTime.Location = new System.Drawing.Point(418, 150);
            this.dateTimePickerEndTime.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePickerEndTime.MaxDate = new System.DateTime(2023, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerEndTime.MinDate = new System.DateTime(2022, 12, 1, 0, 0, 0, 0);
            this.dateTimePickerEndTime.Name = "dateTimePickerEndTime";
            this.dateTimePickerEndTime.Size = new System.Drawing.Size(84, 20);
            this.dateTimePickerEndTime.TabIndex = 14;
            this.dateTimePickerEndTime.Value = new System.DateTime(2022, 12, 14, 0, 0, 0, 0);
            this.dateTimePickerEndTime.ValueChanged += new System.EventHandler(this.dateTimePickerEndTime_ValueChanged);
            // 
            // ListByTime
            // 
            this.ListByTime.Location = new System.Drawing.Point(418, 12);
            this.ListByTime.Margin = new System.Windows.Forms.Padding(2);
            this.ListByTime.Name = "ListByTime";
            this.ListByTime.Size = new System.Drawing.Size(122, 23);
            this.ListByTime.TabIndex = 15;
            this.ListByTime.Text = "List By Trigger Time";
            this.ListByTime.UseVisualStyleBackColor = true;
            this.ListByTime.Click += new System.EventHandler(this.ListByTime_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 791);
            this.Controls.Add(this.ListByTime);
            this.Controls.Add(this.dateTimePickerEndTime);
            this.Controls.Add(this.dateTimePickerStartTime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePickerEnd);
            this.Controls.Add(this.dateTimePickerStart);
            this.Controls.Add(this.SelectGatesForDBsimulation);
            this.Controls.Add(this.SelectWorkerForDBsimulation);
            this.Controls.Add(this.SelectorWorkerForWorkHours);
            this.Controls.Add(this.WorkHoursField);
            this.Controls.Add(this.ReportWorkHours);
            this.Controls.Add(this.dataView);
            this.Controls.Add(this.SimulateEvents);
            this.Controls.Add(this.DeleteDB);
            this.Controls.Add(this.WriteDB);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button WriteDB;
        private System.Windows.Forms.Button DeleteDB;
        private System.Windows.Forms.Button SimulateEvents;
        private System.Windows.Forms.DataGridView dataView;
        private System.Windows.Forms.Button ReportWorkHours;
        private System.Windows.Forms.TextBox WorkHoursField;
        private System.Windows.Forms.ComboBox SelectorWorkerForWorkHours;
        private System.Windows.Forms.ComboBox SelectWorkerForDBsimulation;
        private System.Windows.Forms.ComboBox SelectGatesForDBsimulation;
        private System.Windows.Forms.DateTimePicker dateTimePickerStart;
        private System.Windows.Forms.DateTimePicker dateTimePickerEnd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePickerStartTime;
        private System.Windows.Forms.DateTimePicker dateTimePickerEndTime;
        private System.Windows.Forms.Button ListByTime;
    }
}

