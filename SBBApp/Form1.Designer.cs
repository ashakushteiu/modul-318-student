namespace EasyTravel
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnMainSearch = new System.Windows.Forms.Button();
            this.btnMainSearchChange = new System.Windows.Forms.Button();
            this.Von = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbxMainOutput = new System.Windows.Forms.ListBox();
            this.lbxMainOutputTime = new System.Windows.Forms.ListBox();
            this.lbxMainTravelTime = new System.Windows.Forms.ListBox();
            this.lbxMainTravelDate = new System.Windows.Forms.ListBox();
            this.tbxMainSearchFrom = new System.Windows.Forms.ComboBox();
            this.tbxMainSearchTo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxMainTimetable = new System.Windows.Forms.ComboBox();
            this.btnMainTimetableSearch = new System.Windows.Forms.Button();
            this.lbxMainStationBoard = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnMainSearch
            // 
            this.btnMainSearch.Location = new System.Drawing.Point(305, 34);
            this.btnMainSearch.Name = "btnMainSearch";
            this.btnMainSearch.Size = new System.Drawing.Size(75, 23);
            this.btnMainSearch.TabIndex = 0;
            this.btnMainSearch.Text = "Suchen";
            this.btnMainSearch.UseVisualStyleBackColor = true;
            this.btnMainSearch.Click += new System.EventHandler(this.btnMainSearch_Click);
            // 
            // btnMainSearchChange
            // 
            this.btnMainSearchChange.Location = new System.Drawing.Point(305, 74);
            this.btnMainSearchChange.Name = "btnMainSearchChange";
            this.btnMainSearchChange.Size = new System.Drawing.Size(75, 24);
            this.btnMainSearchChange.TabIndex = 1;
            this.btnMainSearchChange.Text = "Tauschen";
            this.btnMainSearchChange.UseVisualStyleBackColor = true;
            this.btnMainSearchChange.Click += new System.EventHandler(this.btnMainSearchChange_Click);
            // 
            // Von
            // 
            this.Von.AutoSize = true;
            this.Von.Location = new System.Drawing.Point(40, 37);
            this.Von.Name = "Von";
            this.Von.Size = new System.Drawing.Size(30, 15);
            this.Von.TabIndex = 4;
            this.Von.Text = "Von:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nach:";
            // 
            // lbxMainOutput
            // 
            this.lbxMainOutput.BackColor = System.Drawing.SystemColors.Control;
            this.lbxMainOutput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbxMainOutput.FormattingEnabled = true;
            this.lbxMainOutput.ItemHeight = 15;
            this.lbxMainOutput.Location = new System.Drawing.Point(40, 123);
            this.lbxMainOutput.Name = "lbxMainOutput";
            this.lbxMainOutput.Size = new System.Drawing.Size(181, 315);
            this.lbxMainOutput.TabIndex = 6;
            // 
            // lbxMainOutputTime
            // 
            this.lbxMainOutputTime.BackColor = System.Drawing.SystemColors.Control;
            this.lbxMainOutputTime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbxMainOutputTime.FormattingEnabled = true;
            this.lbxMainOutputTime.ItemHeight = 15;
            this.lbxMainOutputTime.Location = new System.Drawing.Point(227, 123);
            this.lbxMainOutputTime.Name = "lbxMainOutputTime";
            this.lbxMainOutputTime.Size = new System.Drawing.Size(138, 315);
            this.lbxMainOutputTime.TabIndex = 7;
            // 
            // lbxMainTravelTime
            // 
            this.lbxMainTravelTime.BackColor = System.Drawing.SystemColors.Control;
            this.lbxMainTravelTime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbxMainTravelTime.FormattingEnabled = true;
            this.lbxMainTravelTime.ItemHeight = 15;
            this.lbxMainTravelTime.Location = new System.Drawing.Point(371, 123);
            this.lbxMainTravelTime.Name = "lbxMainTravelTime";
            this.lbxMainTravelTime.Size = new System.Drawing.Size(198, 315);
            this.lbxMainTravelTime.TabIndex = 9;
            // 
            // lbxMainTravelDate
            // 
            this.lbxMainTravelDate.BackColor = System.Drawing.SystemColors.Control;
            this.lbxMainTravelDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbxMainTravelDate.FormattingEnabled = true;
            this.lbxMainTravelDate.ItemHeight = 15;
            this.lbxMainTravelDate.Location = new System.Drawing.Point(656, 123);
            this.lbxMainTravelDate.Name = "lbxMainTravelDate";
            this.lbxMainTravelDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbxMainTravelDate.Size = new System.Drawing.Size(133, 315);
            this.lbxMainTravelDate.TabIndex = 10;
            // 
            // tbxMainSearchFrom
            // 
            this.tbxMainSearchFrom.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.tbxMainSearchFrom.FormattingEnabled = true;
            this.tbxMainSearchFrom.Location = new System.Drawing.Point(86, 37);
            this.tbxMainSearchFrom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxMainSearchFrom.Name = "tbxMainSearchFrom";
            this.tbxMainSearchFrom.Size = new System.Drawing.Size(196, 23);
            this.tbxMainSearchFrom.TabIndex = 11;
            this.tbxMainSearchFrom.DropDown += new System.EventHandler(this.DropDownFrom);
            this.tbxMainSearchFrom.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TbxMainSearchKeyPress);
            // 
            // tbxMainSearchTo
            // 
            this.tbxMainSearchTo.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.tbxMainSearchTo.FormattingEnabled = true;
            this.tbxMainSearchTo.Location = new System.Drawing.Point(86, 74);
            this.tbxMainSearchTo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxMainSearchTo.Name = "tbxMainSearchTo";
            this.tbxMainSearchTo.Size = new System.Drawing.Size(196, 23);
            this.tbxMainSearchTo.TabIndex = 12;
            this.tbxMainSearchTo.DropDown += new System.EventHandler(this.DropDownTo);
            this.tbxMainSearchTo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TbxMainSearchKeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(400, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "Stations Fahrplan:";
            // 
            // tbxMainTimetable
            // 
            this.tbxMainTimetable.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.tbxMainTimetable.FormattingEnabled = true;
            this.tbxMainTimetable.Location = new System.Drawing.Point(514, 37);
            this.tbxMainTimetable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxMainTimetable.Name = "tbxMainTimetable";
            this.tbxMainTimetable.Size = new System.Drawing.Size(163, 23);
            this.tbxMainTimetable.TabIndex = 14;
            this.tbxMainTimetable.DropDown += new System.EventHandler(this.DropDownTimetable);
            this.tbxMainTimetable.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TbxMainTimetableKeyPress);
            // 
            // btnMainTimetableSearch
            // 
            this.btnMainTimetableSearch.Location = new System.Drawing.Point(694, 34);
            this.btnMainTimetableSearch.Name = "btnMainTimetableSearch";
            this.btnMainTimetableSearch.Size = new System.Drawing.Size(75, 24);
            this.btnMainTimetableSearch.TabIndex = 15;
            this.btnMainTimetableSearch.Text = "Suchen";
            this.btnMainTimetableSearch.UseVisualStyleBackColor = true;
            this.btnMainTimetableSearch.Click += new System.EventHandler(this.btnMainTimetableSearch_Click);
            // 
            // lbxMainStationBoard
            // 
            this.lbxMainStationBoard.BackColor = System.Drawing.SystemColors.Control;
            this.lbxMainStationBoard.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbxMainStationBoard.FormattingEnabled = true;
            this.lbxMainStationBoard.ItemHeight = 15;
            this.lbxMainStationBoard.Location = new System.Drawing.Point(40, 123);
            this.lbxMainStationBoard.Name = "lbxMainStationBoard";
            this.lbxMainStationBoard.Size = new System.Drawing.Size(748, 285);
            this.lbxMainStationBoard.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMainTimetableSearch);
            this.Controls.Add(this.tbxMainTimetable);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxMainSearchTo);
            this.Controls.Add(this.tbxMainSearchFrom);
            this.Controls.Add(this.lbxMainTravelDate);
            this.Controls.Add(this.lbxMainTravelTime);
            this.Controls.Add(this.lbxMainOutputTime);
            this.Controls.Add(this.lbxMainOutput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Von);
            this.Controls.Add(this.btnMainSearchChange);
            this.Controls.Add(this.btnMainSearch);
            this.Controls.Add(this.lbxMainStationBoard);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnMainSearch;
        private Button btnMainSearchChange;
        private Label Von;
        private Label label1;
        private ListBox lbxMainOutput;
        private ListBox lbxMainOutputTime;
        private ListBox lbxMainTravelTime;
        private ListBox lbxMainTravelDate;
        private ComboBox tbxMainSearchFrom;
        private ComboBox tbxMainSearchTo;
        private Label label2;
        private ComboBox tbxMainTimetable;
        private Button btnMainTimetableSearch;
        private ListBox lbxMainStationBoard;
    }
}