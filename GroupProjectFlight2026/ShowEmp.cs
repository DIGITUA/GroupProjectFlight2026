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
            Form1 jobs = new Form1();
            jobs.Show();
        }

        private void ShowEmp_Load(object sender, EventArgs e)
        {
            dataGridView1.ReadOnly = false;
            dataGridView1.AllowUserToAddRows = true;
            dataGridView1.AllowUserToDeleteRows = true;
            // Update the database with the user's changes.
            //dataAdapter.Update(table);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connectionString = "DataSource=deathstar.gtc.edu";
            string sql = "SELECT EMPNO, FIRSTNAME, LASTNAME FROM EMPPF";

            try
            {
                iDB2Connection conn = new iDB2Connection(connectionString);
                dataAdapter = new iDB2DataAdapter(sql, conn);

                // 1. Define the UPDATE command manually
                // Also allows updating EMPNO itself if you change it in the grid
                dataAdapter.UpdateCommand = new iDB2Command(
                    "UPDATE EMPPF SET EMPNO = @EMPNO, FIRSTNAME = @FIRSTNAME, LASTNAME = @LASTNAME WHERE EMPNO = @OLD_EMPNO", conn);
                dataAdapter.UpdateCommand.Parameters.Add("@EMPNO", iDB2DbType.iDB2Integer, 0, "EMPNO");
                dataAdapter.UpdateCommand.Parameters.Add("@FIRSTNAME", iDB2DbType.iDB2Char, 12, "FIRSTNAME");
                dataAdapter.UpdateCommand.Parameters.Add("@LASTNAME", iDB2DbType.iDB2Char, 16, "LASTNAME");

                // Map the WHERE clause parameter to the Original value of EMPNO
                iDB2Parameter oldIdParam = dataAdapter.UpdateCommand.Parameters.Add("@OLD_EMPNO", iDB2DbType.iDB2Integer, 0, "EMPNO");
                oldIdParam.SourceVersion = DataRowVersion.Original;

                // 2. Define the INSERT command manually
                dataAdapter.InsertCommand = new iDB2Command(
                    "INSERT INTO EMPPF (EMPNO, FIRSTNAME, LASTNAME) VALUES (@EMPNO, @FIRSTNAME, @LASTNAME)", conn);
                dataAdapter.InsertCommand.Parameters.Add("@EMPNO", iDB2DbType.iDB2Integer, 0, "EMPNO");
                dataAdapter.InsertCommand.Parameters.Add("@FIRSTNAME", iDB2DbType.iDB2Char, 12, "FIRSTNAME");
                dataAdapter.InsertCommand.Parameters.Add("@LASTNAME", iDB2DbType.iDB2Char, 16, "LASTNAME");

                // 3. Define the DELETE command manually
                dataAdapter.DeleteCommand = new iDB2Command(
                    "DELETE FROM EMPPF WHERE EMPNO = @OLD_EMPNO", conn);
                iDB2Parameter delIdParam = dataAdapter.DeleteCommand.Parameters.Add("@OLD_EMPNO", iDB2DbType.iDB2Integer, 0, "EMPNO");
                delIdParam.SourceVersion = DataRowVersion.Original;

                // Fill the table
                dataGridView1.DataSource = bindingSource1;
                table = new DataTable();
                dataAdapter.Fill(table);
                bindingSource1.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string connectionString = "DataSource=deathstar.gtc.edu";
            string sql = "SELECT * FROM JOBTYPE";

            try
            {
                dataGridView1.DataSource = bindingSource1;

                // Create a new data adapter based on the specified query.
                dataAdapter = new iDB2DataAdapter(sql, connectionString);
                iDB2CommandBuilder commandBuilder = new iDB2CommandBuilder(dataAdapter);
                table = new DataTable();

                dataAdapter.Fill(table);
                bindingSource1.DataSource = table;

            }
            catch (Exception ex)
            {
                //textBox1.Text = ex.Message;
                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Commit any pending edits in the currently active cell
                this.Validate();
                bindingSource1.EndEdit();

                // 2. Push the changes from the DataTable back to the DB2 database
                if (table != null)
                {
                    int rowsAffected = dataAdapter.Update(table);
                    MessageBox.Show($"{rowsAffected} row(s) successfully saved.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving data: " + ex.Message);
            }
        }
    }
}
