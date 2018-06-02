using System;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace STLx
{
    public partial class Form1 : Form
    {
        private OleDbConnectionStringBuilder sb;
        private OleDbConnection conn;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn = new OleDbConnection(ConfigurationManager.ConnectionStrings["OleDBConn"].ConnectionString);

            DataTable table = new DataTable();
            if (!String.IsNullOrEmpty(conn.ConnectionString))
            {
                table = FillTable("SELECT * FROM Employee");
            }

            dataGridView1.DataSource = table;
        }

        private DataTable FillTable(String sql)
        {
            DataTable table = new DataTable();
            using (OleDbDataAdapter da = new OleDbDataAdapter(sql, conn))
            {
                da.Fill(table);
            }
            return table;
        }
    }
}
