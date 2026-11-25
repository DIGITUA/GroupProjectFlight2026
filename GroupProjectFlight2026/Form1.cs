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
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Jobs jobs = new Jobs();
            jobs.Show();
        }

        private void btnAddCust_Click(object sender, EventArgs e)
        {
            AddCust addCust = new AddCust();
            addCust.Show();
        }

        private void btnAddZip_Click(object sender, EventArgs e)
        {
            AddZip addZip = new AddZip();
            addZip.Show();
        }

        private void btnAddAirplane_Click(object sender, EventArgs e)
        {
            AddAirplane airplaneForm = new AddAirplane();
            airplaneForm.Show();
        }

        private void btnAddAirport_Click(object sender, EventArgs e)
        {
            AddAirport airportForm = new AddAirport();
            airportForm.Show();
        }

        private void btnEmpRegion_Click(object sender, EventArgs e)
        {
            EmpRegion empRegion = new EmpRegion();
            empRegion.Show();
        }
    }
}
