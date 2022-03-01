namespace LabExam11
{
    partial class ShowDatabase
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
            this.ShowCountries = new System.Windows.Forms.Button();
            this.ShowDataGridView1 = new System.Windows.Forms.DataGridView();
            this.ShowDepartments = new System.Windows.Forms.Button();
            this.ShowDependants = new System.Windows.Forms.Button();
            this.ShowEmpl = new System.Windows.Forms.Button();
            this.ShowJops = new System.Windows.Forms.Button();
            this.ShowLocations = new System.Windows.Forms.Button();
            this.ShowRegions = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ShowDataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ShowCountries
            // 
            this.ShowCountries.Location = new System.Drawing.Point(33, 336);
            this.ShowCountries.Name = "ShowCountries";
            this.ShowCountries.Size = new System.Drawing.Size(120, 23);
            this.ShowCountries.TabIndex = 0;
            this.ShowCountries.Text = "Show Countries";
            this.ShowCountries.UseVisualStyleBackColor = true;
            this.ShowCountries.Click += new System.EventHandler(this.ShowCountries_Click);
            // 
            // ShowDataGridView1
            // 
            this.ShowDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ShowDataGridView1.Location = new System.Drawing.Point(91, 33);
            this.ShowDataGridView1.Name = "ShowDataGridView1";
            this.ShowDataGridView1.ReadOnly = true;
            this.ShowDataGridView1.RowTemplate.Height = 24;
            this.ShowDataGridView1.Size = new System.Drawing.Size(591, 209);
            this.ShowDataGridView1.TabIndex = 1;
            // 
            // ShowDepartments
            // 
            this.ShowDepartments.Location = new System.Drawing.Point(159, 336);
            this.ShowDepartments.Name = "ShowDepartments";
            this.ShowDepartments.Size = new System.Drawing.Size(149, 23);
            this.ShowDepartments.TabIndex = 2;
            this.ShowDepartments.Text = "Show Departments";
            this.ShowDepartments.UseVisualStyleBackColor = true;
            this.ShowDepartments.Click += new System.EventHandler(this.ShowDepartments_Click);
            // 
            // ShowDependants
            // 
            this.ShowDependants.Location = new System.Drawing.Point(314, 336);
            this.ShowDependants.Name = "ShowDependants";
            this.ShowDependants.Size = new System.Drawing.Size(150, 23);
            this.ShowDependants.TabIndex = 3;
            this.ShowDependants.Text = "Show Dependants";
            this.ShowDependants.UseVisualStyleBackColor = true;
            this.ShowDependants.Click += new System.EventHandler(this.ShowDependants_Click);
            // 
            // ShowEmpl
            // 
            this.ShowEmpl.Location = new System.Drawing.Point(470, 336);
            this.ShowEmpl.Name = "ShowEmpl";
            this.ShowEmpl.Size = new System.Drawing.Size(140, 23);
            this.ShowEmpl.TabIndex = 4;
            this.ShowEmpl.Text = "Show Employees";
            this.ShowEmpl.UseVisualStyleBackColor = true;
            this.ShowEmpl.Click += new System.EventHandler(this.ShowEmpl_Click);
            // 
            // ShowJops
            // 
            this.ShowJops.Location = new System.Drawing.Point(33, 401);
            this.ShowJops.Name = "ShowJops";
            this.ShowJops.Size = new System.Drawing.Size(120, 23);
            this.ShowJops.TabIndex = 5;
            this.ShowJops.Text = "Show Jobs";
            this.ShowJops.UseVisualStyleBackColor = true;
            this.ShowJops.Click += new System.EventHandler(this.ShowJops_Click);
            // 
            // ShowLocations
            // 
            this.ShowLocations.Location = new System.Drawing.Point(171, 401);
            this.ShowLocations.Name = "ShowLocations";
            this.ShowLocations.Size = new System.Drawing.Size(137, 23);
            this.ShowLocations.TabIndex = 6;
            this.ShowLocations.Text = "Show Locations";
            this.ShowLocations.UseVisualStyleBackColor = true;
            this.ShowLocations.Click += new System.EventHandler(this.ShowLocations_Click);
            // 
            // ShowRegions
            // 
            this.ShowRegions.Location = new System.Drawing.Point(314, 401);
            this.ShowRegions.Name = "ShowRegions";
            this.ShowRegions.Size = new System.Drawing.Size(137, 23);
            this.ShowRegions.TabIndex = 7;
            this.ShowRegions.Text = "Show Regions";
            this.ShowRegions.UseVisualStyleBackColor = true;
            this.ShowRegions.Click += new System.EventHandler(this.ShowRegions_Click);
            // 
            // ShowDatabase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 542);
            this.Controls.Add(this.ShowRegions);
            this.Controls.Add(this.ShowLocations);
            this.Controls.Add(this.ShowJops);
            this.Controls.Add(this.ShowEmpl);
            this.Controls.Add(this.ShowDependants);
            this.Controls.Add(this.ShowDepartments);
            this.Controls.Add(this.ShowDataGridView1);
            this.Controls.Add(this.ShowCountries);
            this.Name = "ShowDatabase";
            this.Text = "ShowDatabase";
            this.Load += new System.EventHandler(this.ShowDataBase_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ShowDataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button ShowCountries;
        private System.Windows.Forms.DataGridView ShowDataGridView1;
        private System.Windows.Forms.Button ShowDepartments;
        private System.Windows.Forms.Button ShowDependants;
        private System.Windows.Forms.Button ShowEmpl;
        private System.Windows.Forms.Button ShowJops;
        private System.Windows.Forms.Button ShowLocations;
        private System.Windows.Forms.Button ShowRegions;
    }
}