using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabExam11
{
    public partial class ShowDatabase : Form
    {
        Controller controllerObj;
        public ShowDatabase()
        {
            InitializeComponent();
        }

        private void ShowDataBase_Load(object sender, EventArgs e)
        {
            controllerObj = new Controller(); // if you want to initialize comboBox data, intitialize it here
        }
        private void closeButton_Click(object sender, EventArgs e)
        {
            controllerObj.TerminateConnection();
            this.Close();
        }

        private void ShowCountries_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.SelectAll("countries");
            ShowDataGridView1.DataSource = dt;
            ShowDataGridView1.Refresh();
        }

        private void ShowDepartments_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.SelectAll("departments");
            ShowDataGridView1.DataSource = dt;
            ShowDataGridView1.Refresh();
        }

        private void ShowDependants_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.SelectAll("dependents");
            ShowDataGridView1.DataSource = dt;
            ShowDataGridView1.Refresh();
        }

        private void ShowEmpl_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.SelectAll("employees");
            ShowDataGridView1.DataSource = dt;
            ShowDataGridView1.Refresh();
        }

        private void ShowJops_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.SelectAll("jobs");
            ShowDataGridView1.DataSource = dt;
            ShowDataGridView1.Refresh();
        }

        private void ShowLocations_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.SelectAll("locations");
            ShowDataGridView1.DataSource = dt;
            ShowDataGridView1.Refresh();
        }

        private void ShowRegions_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.SelectAll("regions");
            ShowDataGridView1.DataSource = dt;
            ShowDataGridView1.Refresh();
        }


    }
}
