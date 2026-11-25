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
    public partial class EmpRegion : Form
    {
        private iDB2Connection conn;
        private iDB2DataAdapter adapter;
        DataSet dataSet;

        public EmpRegion()
        {
            InitializeComponent();
        }

        private void EmpRegion_Load(object sender, EventArgs e)
        {
            try
            {
                conn = new iDB2Connection("DataSource=deathstar.gtc.edu");
                string sql = "SELECT RegionID, RegionName FROM Region";
                adapter = new iDB2DataAdapter(sql, conn);

                DataTable table = new DataTable();
                adapter.Fill(table);

                comboBox1.DisplayMember = "RegionName";
                comboBox1.ValueMember = "RegionID";
                comboBox1.DataSource = table;

                conn.Close();
            }
            catch(Exception ex)
            {
                lstDisplay.Items.Add(ex.Message);
            }
        }

        private void btnEmpInRegion_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new iDB2Connection("DataSource=deathstar.gtc.edu");

                string region = comboBox1.SelectedValue.ToString();

                string sql = "SELECT LastName, Firstname FROM EmpPf WHERE RegionID = '" + region + "'";
                adapter = new iDB2DataAdapter(sql, conn);

                dataSet = new DataSet();
                adapter.Fill(dataSet);

                lstDisplay.Items.Clear();
                foreach (DataRow row in dataSet.Tables[0].Rows)
                    lstDisplay.Items.Add(row[0].ToString().Trim() + ", " + row[1].ToString().Trim());

                conn.Close();
            }
            catch(Exception ex)
            {
                lstDisplay.Items.Add(ex.Message);
            }
        }
    }
}
