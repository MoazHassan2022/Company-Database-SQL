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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShowDatabase form1 = new ShowDatabase();
            form1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EditDatabase form2 = new EditDatabase();
            form2.Show();
        }
    }
}
