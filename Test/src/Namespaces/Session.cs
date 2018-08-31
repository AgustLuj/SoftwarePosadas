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
    
    public static User user;
    
    public static bool Login(string uname, string pass) {
      
      var conn = DBConn.GetDBConnection();
      conn.Open();
      
      try {
        MySqlCommand cmd = new MySqlCommand(string.Format("select * from `users` where `uname` = @uname"), conn);
        cmd.Parameters.Add("@uname", MySqlDbType.String).Value = uname;
        
        using (var reader = cmd.ExecuteReader()) {
          if (reader.HasRows) {
            reader.Read();
            if (reader.GetString("uname") == uname && reader.GetString("pass") == pass) {
              user = new User(){name = uname, id = reader.GetInt32("id"), permissions = reader.GetString("permissions")};
              return true;
            } else {
              user = new User(){name = "//err", id = -1};
              return false;
            }
          } else {
            user = new User(){name = "//err", id = -1};
            return false;
          }
        }
      } catch (Exception) {
        
        throw;
      }
    }
  }
}
