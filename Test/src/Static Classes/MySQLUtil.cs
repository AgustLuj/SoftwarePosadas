using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Program.StaticClasses {
  static class MySQLUtil {
    public static MySqlConnection GetDBConnection(string host, int port, string database, string username, string password) {
      // Connection String.
      String connString = "Server=" + host + ";Database=" + database
                                + ";port=" + port + ";User Id=" + username + ";password=" + password + ";SslMode=none";

      MySqlConnection conn = new MySqlConnection(connString);

      return conn;
    }
  }
}
