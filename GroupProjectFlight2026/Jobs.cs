using IBM.Data.DB2.iSeries;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using IBM.Data.DB2.iSeries;

namespace GroupProjectFlight2026
{
    public partial class Jobs : Form
    {
        private BindingSource bindingSource = new BindingSource();
        private iDB2DataAdapter dataAdapter;
        DataTable table;
        public Jobs()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 jobs = new Form1();
            jobs.Show();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string connectionString = "DataSource=deathstar.gtc.edu";
            string sql = @"
            SELECT E.FIRSTNAME, E.LASTNAME 
            FROM EMPPF E 
            INNER JOIN STAFFSCHED S ON E.EMPNO = S.EMPNO 
            WHERE S.FLIGHTNO = @FLIGHTNO";

            try
            {
                iDB2Connection conn = new iDB2Connection(connectionString);

                // Create the SelectCommand and attach the parameter
                iDB2Command selectCmd = new iDB2Command(sql, conn);
                selectCmd.Parameters.Add("@FLIGHTNO", iDB2DbType.iDB2Char, 10).Value = txtFlightNo.Trim().ToUpper();

                dataAdapter = new iDB2DataAdapter(selectCmd);

                // Fill the table and bind to the DataGridView
                table = new DataTable();
                dataAdapter.Fill(table);

                bindingSource.DataSource = table;
                dataGridView1.DataSource = bindingSource;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtErrorMsg_TextChanged(object sender, EventArgs e)
        {
            string txtFlightNo = txtErrorMsg.Text;
        }
    }
}
