/*
 * Created By Mateo Pidal
 * On 13/08/2018
 * Time: 10:30 a.m.
 */
using System;
using Program;
using Program.Classes;
using Program.StaticClasses;
using MySql.Data.MySqlClient;

namespace Program.Sessions {
  public static class Session {
    public static User Login(string uname, string pass) {
      
      var conn = DBConn.GetDBConnection();
      conn.Open();
      
      try {
        MySqlCommand cmd = new MySqlCommand(string.Format("select * from `users` where `uname` = @uname and `pass` = @pass"), conn);
        cmd.Parameters.Add("@uname", MySqlDbType.String).Value = uname;
        cmd.Parameters.Add("@pass", MySqlDbType.String).Value = pass;
        
        using (var reader = cmd.ExecuteReader()) {
          if (reader.HasRows) {
            reader.Read();
            if (reader.GetString("uname") == uname && reader.GetString("pass") == pass) {
              return new User(){name = uname, id = reader.GetInt32("id"), permissions = reader.GetString("permissions")};
            } else {
              return new User(){name = "//err", id = -1};
            }
          } else {
            return new User(){name = "//err", id = -1};
          }
        }
      } catch (Exception) {
        
        throw;
      }
    }
  }
}
