namespace ADO.net_Sample
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmpID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEmpName = new System.Windows.Forms.TextBox();
            this.Emp_Age = new System.Windows.Forms.Label();
            this.txtEmpAge = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmpSal = new System.Windows.Forms.TextBox();
            this.btngetDetails = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblEmpDOB = new System.Windows.Forms.Label();
            this.txtEmpDOB = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(85, 80);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(722, 282);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(354, 438);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 41);
            this.button1.TabIndex = 1;
            this.button1.Text = "Add Data";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(967, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Emp_Id";
            // 
            // txtEmpID
            // 
            this.txtEmpID.Location = new System.Drawing.Point(1108, 146);
            this.txtEmpID.Name = "txtEmpID";
            this.txtEmpID.Size = new System.Drawing.Size(223, 26);
            this.txtEmpID.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(967, 253);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Emp_Name";
            // 
            // txtEmpName
            // 
            this.txtEmpName.Location = new System.Drawing.Point(1108, 253);
            this.txtEmpName.Name = "txtEmpName";
            this.txtEmpName.Size = new System.Drawing.Size(223, 26);
            this.txtEmpName.TabIndex = 5;
            // 
            // Emp_Age
            // 
            this.Emp_Age.AutoSize = true;
            this.Emp_Age.Location = new System.Drawing.Point(967, 326);
            this.Emp_Age.Name = "Emp_Age";
            this.Emp_Age.Size = new System.Drawing.Size(80, 20);
            this.Emp_Age.TabIndex = 6;
            this.Emp_Age.Text = "Emp_Age";
            // 
            // txtEmpAge
            // 
            this.txtEmpAge.Location = new System.Drawing.Point(1108, 320);
            this.txtEmpAge.Name = "txtEmpAge";
            this.txtEmpAge.Size = new System.Drawing.Size(223, 26);
            this.txtEmpAge.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(967, 406);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Emp_Salary";
           
            // 
            // txtEmpSal
            // 
            this.txtEmpSal.Location = new System.Drawing.Point(1108, 400);
            this.txtEmpSal.Name = "txtEmpSal";
            this.txtEmpSal.Size = new System.Drawing.Size(223, 26);
            this.txtEmpSal.TabIndex = 9;
            // 
            // btngetDetails
            // 
            this.btngetDetails.Location = new System.Drawing.Point(557, 438);
            this.btngetDetails.Name = "btngetDetails";
            this.btngetDetails.Size = new System.Drawing.Size(112, 41);
            this.btngetDetails.TabIndex = 10;
            this.btngetDetails.Text = "GetDetails";
            this.btngetDetails.UseVisualStyleBackColor = true;
            this.btngetDetails.Click += new System.EventHandler(this.btngetDetails_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(85, 539);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(108, 35);
            this.btnInsert.TabIndex = 11;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(354, 539);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(112, 35);
            this.btnUpdate.TabIndex = 12;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(557, 539);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(107, 35);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(85, 438);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(108, 41);
            this.btnSearch.TabIndex = 14;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblEmpDOB
            // 
            this.lblEmpDOB.AutoSize = true;
            this.lblEmpDOB.Location = new System.Drawing.Point(974, 486);
            this.lblEmpDOB.Name = "lblEmpDOB";
            this.lblEmpDOB.Size = new System.Drawing.Size(86, 20);
            this.lblEmpDOB.TabIndex = 15;
            this.lblEmpDOB.Text = "Emp_DOB";
            // 
            // txtEmpDOB
            // 
            this.txtEmpDOB.Location = new System.Drawing.Point(1108, 479);
            this.txtEmpDOB.Name = "txtEmpDOB";
            this.txtEmpDOB.Size = new System.Drawing.Size(223, 26);
            this.txtEmpDOB.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1626, 620);
            this.Controls.Add(this.txtEmpDOB);
            this.Controls.Add(this.lblEmpDOB);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btngetDetails);
            this.Controls.Add(this.txtEmpSal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEmpAge);
            this.Controls.Add(this.Emp_Age);
            this.Controls.Add(this.txtEmpName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEmpID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEmpID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEmpName;
        private System.Windows.Forms.Label Emp_Age;
        private System.Windows.Forms.TextBox txtEmpAge;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEmpSal;
        private System.Windows.Forms.Button btngetDetails;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblEmpDOB;
        private System.Windows.Forms.TextBox txtEmpDOB;
    }
}

