using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using MySql.Data.MySqlClient;

using MaterialSkin;
using MaterialSkin.Controls;

using Program;
using Program.Classes;
using Program.Sessions;
using Program.Extensions;
using Program.StaticClasses;

namespace Program {
  public partial class MainForm : MaterialForm {
    public MainForm() {
      InitializeComponent();
      
      var SkinManager = MaterialSkinManager.Instance;
      SkinManager.AddFormToManage(this);
      SkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
      //SkinManager.ColorScheme = new ColorScheme((Primary)0xed9936, (Primary)0xd58930, Primary.Brown600, Accent.Blue400, TextShade.BLACK);
    }
    
    public void Form_Load(object sender, EventArgs e) {
      Console.WriteLine("Getting conn");
      //var month = new Month() {general = new General() {huespedes = new List<Huesped> { new Huesped() {Nombre = "Mateo", DNI = 42149747, Ficha = 1 } } } };
      var month = JsonConvert.DeserializeObject<Month>(DBConn.GetJSON(2018, "enero"));

      //month.general.huespedes.Add(new Huesped() {Nombre = "Velcic", Ficha = 2, DNI = 34849790 });
      //DBConn.UpdateJson(2000, "enero", JsonConvert.SerializeObject(month));

      label1.Text = (month.IsNull()) ? "No values" : month.general.huespedes.First().Nombre;
      
      //label1.Text = ;
    }
    
    public void OnClick(object sender, EventArgs e) {
      label1.Text = Session.Login(uname.Text, pass.Text).ToString();
    }
    
    public void PassKeyUp(object sender, System.Windows.Forms.KeyEventArgs e) {
      if (e.KeyCode == Keys.Return) {
        label1.Text = Session.Login(uname.Text, pass.Text).ToString();
      }
    }
  }
}
