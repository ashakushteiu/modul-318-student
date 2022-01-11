namespace SBBApp
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
            this.btnMain = new System.Windows.Forms.Button();
            this.tbxMainSearch = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Von = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbxMainOutput = new System.Windows.Forms.ListBox();
            this.dgvMainOutput = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMainOutput)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMainSearch
            // 
            this.btnMainSearch.Location = new System.Drawing.Point(233, 34);
            this.btnMainSearch.Name = "btnMainSearch";
            this.btnMainSearch.Size = new System.Drawing.Size(75, 23);
            this.btnMainSearch.TabIndex = 0;
            this.btnMainSearch.Text = "Suchen";
            this.btnMainSearch.UseVisualStyleBackColor = true;
            this.btnMainSearch.Click += new System.EventHandler(this.btnMainSearch_Click);
            // 
            // btnMain
            // 
            this.btnMain.Location = new System.Drawing.Point(233, 76);
            this.btnMain.Name = "btnMain";
            this.btnMain.Size = new System.Drawing.Size(75, 24);
            this.btnMain.TabIndex = 1;
            this.btnMain.Text = "button2";
            this.btnMain.UseVisualStyleBackColor = true;
            // 
            // tbxMainSearch
            // 
            this.tbxMainSearch.Location = new System.Drawing.Point(113, 34);
            this.tbxMainSearch.Name = "tbxMainSearch";
            this.tbxMainSearch.Size = new System.Drawing.Size(100, 23);
            this.tbxMainSearch.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(113, 76);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 23);
            this.textBox2.TabIndex = 3;
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
            this.label1.Location = new System.Drawing.Point(40, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nach:";
            // 
            // lbxMainOutput
            // 
            this.lbxMainOutput.FormattingEnabled = true;
            this.lbxMainOutput.ItemHeight = 15;
            this.lbxMainOutput.Location = new System.Drawing.Point(40, 123);
            this.lbxMainOutput.Name = "lbxMainOutput";
            this.lbxMainOutput.Size = new System.Drawing.Size(268, 214);
            this.lbxMainOutput.TabIndex = 6;
            // 
            // dgvMainOutput
            // 
            this.dgvMainOutput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMainOutput.Location = new System.Drawing.Point(402, 123);
            this.dgvMainOutput.Name = "dgvMainOutput";
            this.dgvMainOutput.RowTemplate.Height = 25;
            this.dgvMainOutput.Size = new System.Drawing.Size(265, 214);
            this.dgvMainOutput.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvMainOutput);
            this.Controls.Add(this.lbxMainOutput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Von);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.tbxMainSearch);
            this.Controls.Add(this.btnMain);
            this.Controls.Add(this.btnMainSearch);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMainOutput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnMainSearch;
        private Button btnMain;
        private TextBox tbxMainSearch;
        private TextBox textBox2;
        private Label Von;
        private Label label1;
        private ListBox lbxMainOutput;
        private DataGridView dgvMainOutput;
    }
}