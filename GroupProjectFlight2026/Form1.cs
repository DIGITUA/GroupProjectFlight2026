using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroupProjectFlight2026
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ShowEmp employeeForm = new ShowEmp();
            employeeForm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Jobs jobs = new Jobs();
            jobs.Show();
            this.Hide();
        }

        private void btnAddCust_Click(object sender, EventArgs e)
        {
            AddCust addCust = new AddCust();
            addCust.Show();
            this.Hide();
        }
    }
}
