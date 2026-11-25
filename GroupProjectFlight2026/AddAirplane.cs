using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IBM.Data.DB2.iSeries;

namespace GroupProjectFlight2026
{
    public partial class AddAirplane : Form
    {
        private BindingSource bindingSource = new BindingSource();
        private iDB2DataAdapter adapter;
        private iDB2CommandBuilder commandBuilder;
        private DataTable table;
        public AddAirplane()
        {
            InitializeComponent();
        }

        private void AddAirplane_Load(object sender, EventArgs e)
        {
            string conString = "DataSource=deathstar.gtc.edu";
            string sql = "SELECT * FROM FLIGHT2026.AIRPLANE";

            try
            {
                //connect to the binding source
                dataGridView1.DataSource = bindingSource;
                //Gets airplane record from IBM
                adapter = new iDB2DataAdapter(sql, conString);
                //For adding and updating
                commandBuilder = new iDB2CommandBuilder(adapter);
                //Hold records
                table = new DataTable();
                //Load records
                adapter.Fill(table);
                //Display
                bindingSource.DataSource = table;
            }
            catch (Exception ex)
            {
                //errors
                txtErrorMsg.Text = ex.Message;
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.EndEdit();
                bindingSource.EndEdit();
                //Save changes
                adapter.Update(table);
                //Show 
                MessageBox.Show("Airplane Changes Complete!!");
            }
            catch (Exception ex)
            {
                //error
                MessageBox.Show("Error:" + ex.Message);
            }
        }
    }
}
