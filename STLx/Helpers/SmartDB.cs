using System.Data.OleDb;

namespace TMF.Core
{
    public class SmartDB
    {
        private OleDbConnection accessConnection;

        public OleDbConnection AccessConnection
        {
            get { return accessConnection; }
            set { accessConnection = value; }
        }


        public SmartDB()
        {
            this.sqlConn = new SqlConnection(SqlHelper.MyConnectionString);
        }

        public SmartDB(string server, string database, string uid, string pwd)
        {
            this.sqlConn = new SqlConnection();
            this.sqlConn.ConnectionString = string.Format("Data Source={0};Initial Catalog={1};Persist Security Info=True;User ID={2};Password={3};Connect Timeout=6000; pooling=True; Max Pool Size=200", new object[]
            {
                server,
                database,
                uid,
                pwd
            });
        }
    }
}