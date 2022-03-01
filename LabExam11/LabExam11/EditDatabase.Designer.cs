namespace LabExam11
{
    partial class EditDatabase
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
            this.EditDataGridView2 = new System.Windows.Forms.DataGridView();
            this.GetEmployees = new System.Windows.Forms.Button();
            this.GetEmpTextBox = new System.Windows.Forms.TextBox();
            this.GetEmployeeJob = new System.Windows.Forms.Button();
            this.GetEmpComboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.GetDepartmentsCount = new System.Windows.Forms.Button();
            this.CityComboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.EditDataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // EditDataGridView2
            // 
            this.EditDataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EditDataGridView2.Location = new System.Drawing.Point(114, 375);
            this.EditDataGridView2.Name = "EditDataGridView2";
            this.EditDataGridView2.ReadOnly = true;
            this.EditDataGridView2.RowTemplate.Height = 24;
            this.EditDataGridView2.Size = new System.Drawing.Size(643, 117);
            this.EditDataGridView2.TabIndex = 1;
            // 
            // GetEmployees
            // 
            this.GetEmployees.Location = new System.Drawing.Point(12, 32);
            this.GetEmployees.Name = "GetEmployees";
            this.GetEmployees.Size = new System.Drawing.Size(120, 23);
            this.GetEmployees.TabIndex = 2;
            this.GetEmployees.Text = "Get Employees";
            this.GetEmployees.UseVisualStyleBackColor = true;
            this.GetEmployees.Click += new System.EventHandler(this.GetEmployees_Click);
            // 
            // GetEmpTextBox
            // 
            this.GetEmpTextBox.Location = new System.Drawing.Point(172, 32);
            this.GetEmpTextBox.Name = "GetEmpTextBox";
            this.GetEmpTextBox.Size = new System.Drawing.Size(100, 22);
            this.GetEmpTextBox.TabIndex = 3;
            // 
            // GetEmployeeJob
            // 
            this.GetEmployeeJob.Location = new System.Drawing.Point(12, 92);
            this.GetEmployeeJob.Name = "GetEmployeeJob";
            this.GetEmployeeJob.Size = new System.Drawing.Size(150, 23);
            this.GetEmployeeJob.TabIndex = 4;
            this.GetEmployeeJob.Text = "Get Employee Job";
            this.GetEmployeeJob.UseVisualStyleBackColor = true;
            this.GetEmployeeJob.Click += new System.EventHandler(this.GetEmployeeJob_Click);
            // 
            // GetEmpComboBox1
            // 
            this.GetEmpComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GetEmpComboBox1.FormattingEnabled = true;
            this.GetEmpComboBox1.Location = new System.Drawing.Point(184, 92);
            this.GetEmpComboBox1.Name = "GetEmpComboBox1";
            this.GetEmpComboBox1.Size = new System.Drawing.Size(121, 24);
            this.GetEmpComboBox1.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 161);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(196, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Get Departments With City";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // GetDepartmentsCount
            // 
            this.GetDepartmentsCount.Location = new System.Drawing.Point(12, 229);
            this.GetDepartmentsCount.Name = "GetDepartmentsCount";
            this.GetDepartmentsCount.Size = new System.Drawing.Size(260, 23);
            this.GetDepartmentsCount.TabIndex = 8;
            this.GetDepartmentsCount.Text = "Get Departments Employees Count";
            this.GetDepartmentsCount.UseVisualStyleBackColor = true;
            this.GetDepartmentsCount.Click += new System.EventHandler(this.GetDepartmentsCount_Click);
            // 
            // CityComboBox1
            // 
            this.CityComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CityComboBox1.FormattingEnabled = true;
            this.CityComboBox1.Location = new System.Drawing.Point(250, 160);
            this.CityComboBox1.Name = "CityComboBox1";
            this.CityComboBox1.Size = new System.Drawing.Size(121, 24);
            this.CityComboBox1.TabIndex = 9;
            // 
            // EditDatabase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 518);
            this.Controls.Add(this.CityComboBox1);
            this.Controls.Add(this.GetDepartmentsCount);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.GetEmpComboBox1);
            this.Controls.Add(this.GetEmployeeJob);
            this.Controls.Add(this.GetEmpTextBox);
            this.Controls.Add(this.GetEmployees);
            this.Controls.Add(this.EditDataGridView2);
            this.Name = "EditDatabase";
            this.Text = "EditDatabase";
            this.Load += new System.EventHandler(this.EditDatabase_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EditDataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView EditDataGridView2;
        private System.Windows.Forms.Button GetEmployees;
        private System.Windows.Forms.TextBox GetEmpTextBox;
        private System.Windows.Forms.Button GetEmployeeJob;
        private System.Windows.Forms.ComboBox GetEmpComboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button GetDepartmentsCount;
        private System.Windows.Forms.ComboBox CityComboBox1;
    }
}