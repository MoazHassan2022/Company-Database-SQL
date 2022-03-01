using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace LabExam11
{
    class Controller
    {
        DBManager dbMan;

        public Controller()
        {
            dbMan = new DBManager();
        }
        public void TerminateConnection()
        {
            dbMan.CloseConnection();
        }
        public DataTable SelectAll(string table)
        {
            string query = "SELECT * FROM " + table;
            return dbMan.ExecuteReader(query);
        }
        public DataTable SelectAllEmployees(float Salary)
        {
            string query = "SELECT employee_id, first_name, last_name, salary FROM employees WHERE salary > "+Salary + ";";
            return dbMan.ExecuteReader(query);
        }
        public DataTable SelectAllEmployeesJobs(string id)
        {
            string query = "SELECT first_name, salary, job_title, min_salary, max_salary FROM employees as e, jobs as j WHERE e.job_id = j.job_id AND employee_id =  " + id + ";";
            return dbMan.ExecuteReader(query);
        }
        public DataTable SelectAllEmployeesID()
        {
            string query = "SELECT employee_id FROM employees";
            return dbMan.ExecuteReader(query);
        }
        public DataTable SelectAllDep(string city)
        {
            string query = "SELECT department_id, department_name, d.location_id FROM departments as d, locations as l WHERE d.location_id = l.location_id AND l.city = '" + city + "';";
            return dbMan.ExecuteReader(query);
        }
        public DataTable SelectDepCount()
        {
            string query = "SELECT d.department_id, COUNT(*) as Count_of_Employees FROM employees as e, departments as d WHERE d.department_id = e.department_id GROUP BY d.department_id";
            return dbMan.ExecuteReader(query);
        }
        public DataTable SelectAllCities()
        {
            string query = "SELECT city FROM locations";
            return dbMan.ExecuteReader(query);
        }

    }
}
