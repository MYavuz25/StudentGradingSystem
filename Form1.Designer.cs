namespace Transkript
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textCoursecode = new System.Windows.Forms.TextBox();
            this.textCourseName = new System.Windows.Forms.TextBox();
            this.textECTS = new System.Windows.Forms.TextBox();
            this.Text_Clear = new System.Windows.Forms.Button();
            this.Details = new System.Windows.Forms.Button();
            this.textTerm = new System.Windows.Forms.ComboBox();
            this.CGPA = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textCGPA = new System.Windows.Forms.TextBox();
            this.textLatterGrade = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(42, 222);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(586, 169);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(449, 39);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 26);
            this.button1.TabIndex = 7;
            this.button1.Text = "Load";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(449, 68);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(85, 26);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(449, 100);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(85, 26);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Malgun Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(83, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Term";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Malgun Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(35, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "CourseCode";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Malgun Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(29, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "CourseName";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Malgun Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(35, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "ECTSCredits";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Malgun Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(36, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "LetterGrade";
            // 
            // textCoursecode
            // 
            this.textCoursecode.Location = new System.Drawing.Point(148, 71);
            this.textCoursecode.Name = "textCoursecode";
            this.textCoursecode.Size = new System.Drawing.Size(154, 23);
            this.textCoursecode.TabIndex = 2;
            // 
            // textCourseName
            // 
            this.textCourseName.Location = new System.Drawing.Point(148, 100);
            this.textCourseName.Name = "textCourseName";
            this.textCourseName.Size = new System.Drawing.Size(154, 23);
            this.textCourseName.TabIndex = 3;
            // 
            // textECTS
            // 
            this.textECTS.Location = new System.Drawing.Point(148, 129);
            this.textECTS.Name = "textECTS";
            this.textECTS.Size = new System.Drawing.Size(154, 23);
            this.textECTS.TabIndex = 4;
            // 
            // Text_Clear
            // 
            this.Text_Clear.Location = new System.Drawing.Point(148, 193);
            this.Text_Clear.Name = "Text_Clear";
            this.Text_Clear.Size = new System.Drawing.Size(154, 23);
            this.Text_Clear.TabIndex = 6;
            this.Text_Clear.Text = "TextBox Clear";
            this.Text_Clear.UseVisualStyleBackColor = true;
            this.Text_Clear.Click += new System.EventHandler(this.Text_Clear_Click);
            // 
            // Details
            // 
            this.Details.Location = new System.Drawing.Point(449, 164);
            this.Details.Name = "Details";
            this.Details.Size = new System.Drawing.Size(85, 26);
            this.Details.TabIndex = 11;
            this.Details.Text = "Details";
            this.Details.UseVisualStyleBackColor = true;
            this.Details.Click += new System.EventHandler(this.button2_Click_2);
            // 
            // textTerm
            // 
            this.textTerm.FormattingEnabled = true;
            this.textTerm.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.textTerm.Location = new System.Drawing.Point(148, 42);
            this.textTerm.Name = "textTerm";
            this.textTerm.Size = new System.Drawing.Size(154, 23);
            this.textTerm.TabIndex = 1;
            this.textTerm.Text = "1";
            // 
            // CGPA
            // 
            this.CGPA.Location = new System.Drawing.Point(449, 132);
            this.CGPA.Name = "CGPA";
            this.CGPA.Size = new System.Drawing.Size(85, 26);
            this.CGPA.TabIndex = 10;
            this.CGPA.Text = "CGPA";
            this.CGPA.UseVisualStyleBackColor = true;
            this.CGPA.Click += new System.EventHandler(this.CGPA_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Malgun Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(340, 417);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "CGPA";
            // 
            // textCGPA
            // 
            this.textCGPA.Location = new System.Drawing.Point(408, 414);
            this.textCGPA.Name = "textCGPA";
            this.textCGPA.ReadOnly = true;
            this.textCGPA.Size = new System.Drawing.Size(220, 23);
            this.textCGPA.TabIndex = 12;
            // 
            // textLatterGrade
            // 
            this.textLatterGrade.FormattingEnabled = true;
            this.textLatterGrade.Items.AddRange(new object[] {
            "AA",
            "BA",
            "BB",
            "CB",
            "CC",
            "DC",
            "DD",
            "FD",
            "FF"});
            this.textLatterGrade.Location = new System.Drawing.Point(148, 164);
            this.textLatterGrade.Name = "textLatterGrade";
            this.textLatterGrade.Size = new System.Drawing.Size(154, 23);
            this.textLatterGrade.TabIndex = 13;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(449, 196);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_3);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(788, 519);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textLatterGrade);
            this.Controls.Add(this.textCGPA);
            this.Controls.Add(this.CGPA);
            this.Controls.Add(this.textTerm);
            this.Controls.Add(this.Details);
            this.Controls.Add(this.Text_Clear);
            this.Controls.Add(this.textECTS);
            this.Controls.Add(this.textCourseName);
            this.Controls.Add(this.textCoursecode);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textCoursecode;
        private System.Windows.Forms.TextBox textCourseName;
        private System.Windows.Forms.TextBox textECTS;
        private System.Windows.Forms.Button Text_Clear;
        private System.Windows.Forms.Button Details;
        private System.Windows.Forms.ComboBox textTerm;
        private System.Windows.Forms.Button CGPA;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textCGPA;
        private System.Windows.Forms.ComboBox textLatterGrade;
        private System.Windows.Forms.Button button2;
    }
}
