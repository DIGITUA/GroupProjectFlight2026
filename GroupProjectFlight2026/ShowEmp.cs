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
using System.Data.OleDb;

namespace GroupProjectFlight2026
{
    public partial class ShowEmp : Form
    {
        private BindingSource bindingSource1 = new BindingSource();
        private iDB2DataAdapter dataAdapter = new iDB2DataAdapter();
        DataTable table;
        public ShowEmp()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void ShowEmp_Load(object sender, EventArgs e)
        {
            string connectionString = "DataSource=deathstar.gtc.edu";
            string sql = "SELECT * FROM CLUBMEMBER";
        }
    }
}
