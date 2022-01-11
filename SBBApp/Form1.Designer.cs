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
            this.lbxException = new System.Windows.Forms.ListBox();
            this.lbxMainTravelTime = new System.Windows.Forms.ListBox();
            this.lbxMainTravelDate = new System.Windows.Forms.ListBox();
            this.tbxMainSearchFrom = new System.Windows.Forms.ComboBox();
            this.tbxMainSearchTo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxMainTimetable = new System.Windows.Forms.ComboBox();
            this.btnMainTimetableSearch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMainSearch
            // 
            this.btnMainSearch.Location = new System.Drawing.Point(349, 45);
            this.btnMainSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnMainSearch.Name = "btnMainSearch";
            this.btnMainSearch.Size = new System.Drawing.Size(86, 31);
            this.btnMainSearch.TabIndex = 0;
            this.btnMainSearch.Text = "Suchen";
            this.btnMainSearch.UseVisualStyleBackColor = true;
            this.btnMainSearch.Click += new System.EventHandler(this.btnMainSearch_Click);
            // 
            // btnMainSearchChange
            // 
            this.btnMainSearchChange.Location = new System.Drawing.Point(349, 98);
            this.btnMainSearchChange.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnMainSearchChange.Name = "btnMainSearchChange";
            this.btnMainSearchChange.Size = new System.Drawing.Size(86, 32);
            this.btnMainSearchChange.TabIndex = 1;
            this.btnMainSearchChange.Text = "Tauschen";
            this.btnMainSearchChange.UseVisualStyleBackColor = true;
            this.btnMainSearchChange.Click += new System.EventHandler(this.btnMainSearchChange_Click);
            // 
            // Von
            // 
            this.Von.AutoSize = true;
            this.Von.Location = new System.Drawing.Point(46, 49);
            this.Von.Name = "Von";
            this.Von.Size = new System.Drawing.Size(37, 20);
            this.Von.TabIndex = 4;
            this.Von.Text = "Von:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nach:";
            // 
            // lbxMainOutput
            // 
            this.lbxMainOutput.BackColor = System.Drawing.SystemColors.Control;
            this.lbxMainOutput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbxMainOutput.FormattingEnabled = true;
            this.lbxMainOutput.ItemHeight = 20;
            this.lbxMainOutput.Location = new System.Drawing.Point(46, 164);
            this.lbxMainOutput.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lbxMainOutput.Name = "lbxMainOutput";
            this.lbxMainOutput.Size = new System.Drawing.Size(207, 420);
            this.lbxMainOutput.TabIndex = 6;
            // 
            // lbxMainOutputTime
            // 
            this.lbxMainOutputTime.BackColor = System.Drawing.SystemColors.Control;
            this.lbxMainOutputTime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbxMainOutputTime.FormattingEnabled = true;
            this.lbxMainOutputTime.ItemHeight = 20;
            this.lbxMainOutputTime.Location = new System.Drawing.Point(259, 164);
            this.lbxMainOutputTime.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lbxMainOutputTime.Name = "lbxMainOutputTime";
            this.lbxMainOutputTime.Size = new System.Drawing.Size(142, 420);
            this.lbxMainOutputTime.TabIndex = 7;
            // 
            // lbxException
            // 
            this.lbxException.BackColor = System.Drawing.SystemColors.Control;
            this.lbxException.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbxException.FormattingEnabled = true;
            this.lbxException.ItemHeight = 20;
            this.lbxException.Location = new System.Drawing.Point(46, 13);
            this.lbxException.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lbxException.Name = "lbxException";
            this.lbxException.Size = new System.Drawing.Size(323, 20);
            this.lbxException.TabIndex = 8;
            // 
            // lbxMainTravelTime
            // 
            this.lbxMainTravelTime.BackColor = System.Drawing.SystemColors.Control;
            this.lbxMainTravelTime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbxMainTravelTime.FormattingEnabled = true;
            this.lbxMainTravelTime.ItemHeight = 20;
            this.lbxMainTravelTime.Location = new System.Drawing.Point(407, 164);
            this.lbxMainTravelTime.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lbxMainTravelTime.Name = "lbxMainTravelTime";
            this.lbxMainTravelTime.Size = new System.Drawing.Size(226, 420);
            this.lbxMainTravelTime.TabIndex = 9;
            // 
            // lbxMainTravelDate
            // 
            this.lbxMainTravelDate.BackColor = System.Drawing.SystemColors.Control;
            this.lbxMainTravelDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbxMainTravelDate.FormattingEnabled = true;
            this.lbxMainTravelDate.ItemHeight = 20;
            this.lbxMainTravelDate.Location = new System.Drawing.Point(750, 164);
            this.lbxMainTravelDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lbxMainTravelDate.Name = "lbxMainTravelDate";
            this.lbxMainTravelDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbxMainTravelDate.Size = new System.Drawing.Size(152, 420);
            this.lbxMainTravelDate.TabIndex = 10;
            // 
            // tbxMainSearchFrom
            // 
            this.tbxMainSearchFrom.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.tbxMainSearchFrom.FormattingEnabled = true;
            this.tbxMainSearchFrom.Location = new System.Drawing.Point(98, 49);
            this.tbxMainSearchFrom.Name = "tbxMainSearchFrom";
            this.tbxMainSearchFrom.Size = new System.Drawing.Size(223, 28);
            this.tbxMainSearchFrom.TabIndex = 11;
            this.tbxMainSearchFrom.DropDown += new System.EventHandler(this.DropDownFrom);
            // 
            // tbxMainSearchTo
            // 
            this.tbxMainSearchTo.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.tbxMainSearchTo.FormattingEnabled = true;
            this.tbxMainSearchTo.Location = new System.Drawing.Point(98, 98);
            this.tbxMainSearchTo.Name = "tbxMainSearchTo";
            this.tbxMainSearchTo.Size = new System.Drawing.Size(223, 28);
            this.tbxMainSearchTo.TabIndex = 12;
            this.tbxMainSearchTo.DropDown += new System.EventHandler(this.DropDownTo);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(457, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Stations Fahrplan:";
            // 
            // tbxMainTimetable
            // 
            this.tbxMainTimetable.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.tbxMainTimetable.FormattingEnabled = true;
            this.tbxMainTimetable.Location = new System.Drawing.Point(588, 49);
            this.tbxMainTimetable.Name = "tbxMainTimetable";
            this.tbxMainTimetable.Size = new System.Drawing.Size(186, 28);
            this.tbxMainTimetable.TabIndex = 14;
            this.tbxMainTimetable.DropDown += new System.EventHandler(this.DropDownTimetable);
            // 
            // btnMainTimetableSearch
            // 
            this.btnMainTimetableSearch.Location = new System.Drawing.Point(793, 45);
            this.btnMainTimetableSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnMainTimetableSearch.Name = "btnMainTimetableSearch";
            this.btnMainTimetableSearch.Size = new System.Drawing.Size(86, 32);
            this.btnMainTimetableSearch.TabIndex = 15;
            this.btnMainTimetableSearch.Text = "Suchen";
            this.btnMainTimetableSearch.UseVisualStyleBackColor = true;
            this.btnMainTimetableSearch.Click += new System.EventHandler(this.btnMainTimetableSearch_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.btnMainTimetableSearch);
            this.Controls.Add(this.tbxMainTimetable);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxMainSearchTo);
            this.Controls.Add(this.tbxMainSearchFrom);
            this.Controls.Add(this.lbxMainTravelDate);
            this.Controls.Add(this.lbxMainTravelTime);
            this.Controls.Add(this.lbxException);
            this.Controls.Add(this.lbxMainOutputTime);
            this.Controls.Add(this.lbxMainOutput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Von);
            this.Controls.Add(this.btnMainSearchChange);
            this.Controls.Add(this.btnMainSearch);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
        private ListBox lbxException;
        private ListBox lbxMainTravelTime;
        private ListBox lbxMainTravelDate;
        private ComboBox tbxMainSearchFrom;
        private ComboBox tbxMainSearchTo;
        private Label label2;
        private ComboBox tbxMainTimetable;
        private Button btnMainTimetableSearch;
    }
}