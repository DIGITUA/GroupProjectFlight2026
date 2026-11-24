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
    public partial class AddZip : Form
    {
        private BindingSource bindingSource = new BindingSource();
        private iDB2DataAdapter adapter;
        DataTable table;

        public AddZip()
        {
            InitializeComponent();
        }

        private void AddZip_Load(object sender, EventArgs e)
        {
            string conString = "DataSource=deathstar.gtc.edu";
            string sql = "SELECT * FROM ZIPPF";
            try
            {
                dataGridView1.DataSource = bindingSource;

                adapter = new iDB2DataAdapter(sql, conString);
                iDB2CommandBuilder commandBuilder = new iDB2CommandBuilder(adapter);
                table = new DataTable();

                adapter.Fill(table);
                bindingSource.DataSource = table;
            }
            catch (Exception ex)
            {
                txtErrorMsg.Text = ex.Message;
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            adapter.Update(table);
        }
    }
}
