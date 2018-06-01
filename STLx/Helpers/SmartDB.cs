using System.Configuration;
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
            accessConnection = new OleDbConnection(ConfigurationManager.AppSettings["OleDBConn"]);
        }
    }
}