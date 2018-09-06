using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using Program.Classes;

namespace Program.StaticClasses {
  static class DBConn {
    public static MySqlConnection GetDBConnection() {
      const string host = "127.0.0.1";
      const int port = 3306;
      const string database = "test";
      const string username = "root";
      const string password = "usbw";

      return MySQLUtil.GetDBConnection(host, port, database, username, password);
    }
    
    #region JSON Related
    public static string GetJSON(int year, string month) {
      var conn = GetDBConnection();

      try {
        conn.Open();
        
        MySqlCommand cmd = new MySqlCommand(string.Format("SELECT `ano`, `{0}` FROM `anos` WHERE `ano` = {1}", month, year), conn);

        using (var reader = cmd.ExecuteReader()) {
          if (reader.HasRows) {
            reader.Read();
            return reader.GetString(month);
          } else {
            InsertJson(year, month, JsonConvert.SerializeObject(new Month()));
            return JsonConvert.SerializeObject(new Month());
          }
        }
      } catch {

        throw;
      }
    }

    public static int InsertJson(int year, string month, string JSON) {
      
      var conn = GetDBConnection();
            
      try {
        conn.Open();
        
        MySqlCommand cmd = new MySqlCommand(string.Format("insert into `anos` (`ano`, {0}) values (@ano, @json)", month), conn);
        cmd.Parameters.Add("@ano", MySqlDbType.Int32).Value = year;
        cmd.Parameters.Add("@json", MySqlDbType.Text).Value = JSON;
        
        return cmd.ExecuteNonQuery();
      } catch (Exception) {
        
        throw;
      }

    }

    public static int UpdateJson(int year, string month, string JSON) {

      var conn = GetDBConnection();

      try {
        conn.Open();
        
        MySqlCommand cmd = new MySqlCommand(string.Format("update `anos` set `{0}` = @json", month), conn);
        cmd.Parameters.Add("@json", MySqlDbType.Text).Value = JSON;

        return cmd.ExecuteNonQuery();
      } catch (Exception) {
        return 0;
        throw;
      }
    }
    #endregion
    
    /*public static List<Guest> getGuests() {
      
    }*/
  }
}
