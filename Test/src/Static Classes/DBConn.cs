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
    
    public static List<Guest> getGuests() {
      var conn = GetDBConnection();
      var guests = new List<Guest>();
      
      try {
        conn.Open();
        
        var cmd = new MySqlCommand("Select * from huespedes, hospedados" +
                                   "  where huespedes.id = hospedados.idhus", conn);
        
        using (var reader = cmd.ExecuteReader()) {
          while (reader.Read()) {
            guests.Add(new Guest(reader.GetString("nficha"), reader.GetString("nombre"),
                                 reader.GetString("apellido"), reader.GetInt32("nhabit"),
                                 reader.GetString("nlocker"), reader.GetString("nombre_internado"),
                                 reader.GetString("apellido_internado"), reader.GetString("procedencia"),
                                 reader.GetString("servicio")));
          }
        }
      } catch (Exception) {
        
        throw;
      }
    
      return guests;
    }
    
    public static bool insertGuest(Guest g){
      var conn = GetDBConnection();
      
      try {
        conn.Open();
        
        MySqlCommand cmd = new MySqlCommand("Insert into huespedes(id, nficha, nombre, apellido, `paciente`, `nombre_internado`, `apellido_internado`, `nhabit`, `nlocker`, `ingreso`, `egreso`, `ncamhos`, `tel`, `Totalhospedados`, `procedencia`, `servicio`) values " +
                                            "(0, @ficha, @nombre, @apellido, @paciente," +
                                            "@inombre, @iapellido, @habit, @locker, @ingreso," +
                                            "@egreso, @ncama, @tel, @th, @proc, @servicio)");
        
        cmd.Parameters.Add("@ficha", MySqlDbType.Text).Value = g.ficha;
        cmd.Parameters.Add("@nombre", MySqlDbType.Text).Value = g.paciente.name;
        cmd.Parameters.Add("@apellido", MySqlDbType.Text).Value = g.paciente.surname;
        cmd.Parameters.Add("@paciente", MySqlDbType.Text).Value = "";
        cmd.Parameters.Add("@inombre", MySqlDbType.Text).Value = g.internado.name;
        cmd.Parameters.Add("@iapellido", MySqlDbType.Text).Value = g.internado.surname;
        cmd.Parameters.Add("@habit", MySqlDbType.Int32).Value = g.hab;
        cmd.Parameters.Add("@locker", MySqlDbType.Text).Value = g.locker;
        cmd.Parameters.Add("@ingreso", MySqlDbType.DateTime).Value = g.ingreso;
        cmd.Parameters.Add("@egreso", MySqlDbType.DateTime).Value = g.egreso;
        cmd.Parameters.Add("@ncama", MySqlDbType.Int32).Value = 0;
        cmd.Parameters.Add("@tel", MySqlDbType.Int32).Value = g.telefono;
        cmd.Parameters.Add("@th", MySqlDbType.Text).Value = 0;
        cmd.Parameters.Add("@proc", MySqlDbType.Text).Value = g.procedencia;
        cmd.Parameters.Add("@servicio", MySqlDbType.Text).Value = g.servicio;
        
        Console.WriteLine(cmd.ExecuteNonQuery());
        
        return true;
        
      } catch (Exception) {
        return false;
      }
    }
  }
}
