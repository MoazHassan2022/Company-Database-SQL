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
    public partial class EditDatabase : Form
    {
        Controller controllerObj;
        public EditDatabase()
        {
            InitializeComponent();
        }

        private void EditDatabase_Load(object sender, EventArgs e)
        {
            controllerObj = new Controller(); // if you want to initialize comboBox data, intitialize it here
            DataTable EmpIDs = controllerObj.SelectAllEmployeesID();
            for (int i = 0; i < EmpIDs.Rows.Count; i++)
            {
                GetEmpComboBox1.Items.Add(EmpIDs.Rows[i]["employee_id"]);
            }
            DataTable citiesD = controllerObj.SelectAllCities();
            for (int i = 0; i < citiesD.Rows.Count; i++)
            {
                CityComboBox1.Items.Add(citiesD.Rows[i]["city"]);
            }

        }
        private void closeButton_Click(object sender, EventArgs e)
        {
            controllerObj.TerminateConnection();
            this.Close();
        }

        private void GetEmployees_Click(object sender, EventArgs e)
        {
            float salary = 0;
            if (GetEmpTextBox.Text != "")
            {

                if (float.TryParse(GetEmpTextBox.Text, out salary))
                {
                    DataTable dt = controllerObj.SelectAllEmployees(salary);
                    EditDataGridView2.DataSource = dt;
                    EditDataGridView2.Refresh();
                }
                else
                {
                    MessageBox.Show("Incorrect input, Please enter number in salary");
                }
            }
            else
            {
                MessageBox.Show("Incorrect input, Please don't enter empty strings");
            }
        }

        private void GetEmployeeJob_Click(object sender, EventArgs e)
        {
            string id = GetEmpComboBox1.SelectedItem.ToString();
            DataTable dt = controllerObj.SelectAllEmployeesJobs(id);
            EditDataGridView2.DataSource = dt;
            EditDataGridView2.Refresh();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            string city = CityComboBox1.SelectedItem.ToString();
            DataTable dt = controllerObj.SelectAllDep(city);
            EditDataGridView2.DataSource = dt;
            EditDataGridView2.Refresh();

        }

        private void GetDepartmentsCount_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.SelectDepCount();
            EditDataGridView2.DataSource = dt;
            EditDataGridView2.Refresh();
        }

    }
}
