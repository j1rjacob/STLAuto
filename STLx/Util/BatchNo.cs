using System.Configuration;
using System.Data.OleDb;

namespace STLx.Util
{
    public class BatchNo
    {
        private OleDbConnection _oleDbConnection;

        public BatchNo()
        {
            _oleDbConnection = new OleDbConnection(ConfigurationManager.ConnectionStrings["OleDBConn"].ConnectionString);

        }

        public int GetBatchNo()
        {
            string command = "SELECT * FROM Employee WHERE";
            var cmd = new OleDbCommand(command, _oleDbConnection);
            var reader = cmd.ExecuteReader();
            int batchNo = 0;
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    //StudentID = int.Parse(reader[0].ToString());
                    //    is StudentID
                    //    StudentName = reader["StudentName"].ToString();
                    //name
                }
            }
            reader.Close();
            _oleDbConnection.Close();
            return batchNo;
        }
    }
}
