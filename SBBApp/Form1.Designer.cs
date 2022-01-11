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
            this.tbxMainSearchFrom = new System.Windows.Forms.TextBox();
            this.tbxMainSearchTo = new System.Windows.Forms.TextBox();
            this.Von = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbxMainOutput = new System.Windows.Forms.ListBox();
            this.dgvMainOutput = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMainOutput)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMainSearch
            // 
            this.btnMainSearch.Location = new System.Drawing.Point(266, 45);
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
            this.btnMainSearchChange.Location = new System.Drawing.Point(266, 101);
            this.btnMainSearchChange.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnMainSearchChange.Name = "btnMainSearchChange";
            this.btnMainSearchChange.Size = new System.Drawing.Size(86, 32);
            this.btnMainSearchChange.TabIndex = 1;
            this.btnMainSearchChange.Text = "Tauschen";
            this.btnMainSearchChange.UseVisualStyleBackColor = true;
            this.btnMainSearchChange.Click += new System.EventHandler(this.btnMainSearchChange_Click);
            // 
            // tbxMainSearchFrom
            // 
            this.tbxMainSearchFrom.Location = new System.Drawing.Point(129, 45);
            this.tbxMainSearchFrom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxMainSearchFrom.Name = "tbxMainSearchFrom";
            this.tbxMainSearchFrom.Size = new System.Drawing.Size(114, 27);
            this.tbxMainSearchFrom.TabIndex = 2;
            // 
            // tbxMainSearchTo
            // 
            this.tbxMainSearchTo.Location = new System.Drawing.Point(129, 101);
            this.tbxMainSearchTo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxMainSearchTo.Name = "tbxMainSearchTo";
            this.tbxMainSearchTo.Size = new System.Drawing.Size(114, 27);
            this.tbxMainSearchTo.TabIndex = 3;
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
            this.label1.Location = new System.Drawing.Point(46, 108);
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
            this.lbxMainOutput.Size = new System.Drawing.Size(306, 280);
            this.lbxMainOutput.TabIndex = 6;
            // 
            // dgvMainOutput
            // 
            this.dgvMainOutput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMainOutput.Location = new System.Drawing.Point(459, 164);
            this.dgvMainOutput.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvMainOutput.Name = "dgvMainOutput";
            this.dgvMainOutput.RowHeadersWidth = 51;
            this.dgvMainOutput.RowTemplate.Height = 25;
            this.dgvMainOutput.Size = new System.Drawing.Size(303, 285);
            this.dgvMainOutput.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.dgvMainOutput);
            this.Controls.Add(this.lbxMainOutput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Von);
            this.Controls.Add(this.tbxMainSearchTo);
            this.Controls.Add(this.tbxMainSearchFrom);
            this.Controls.Add(this.btnMainSearchChange);
            this.Controls.Add(this.btnMainSearch);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMainOutput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnMainSearch;
        private Button btnMainSearchChange;
        private TextBox tbxMainSearchFrom;
        private TextBox tbxMainSearchTo;
        private Label Von;
        private Label label1;
        private ListBox lbxMainOutput;
        private DataGridView dgvMainOutput;
    }
}