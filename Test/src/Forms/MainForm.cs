﻿using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

using MySql.Data.MySqlClient;

using MaterialSkin;
using MaterialSkin.Controls;
using MaterialSkin.Animations;

using Transitions;

using Program;
using Program.Classes;
using Program.Sessions;
using Program.Extensions;
using Program.StaticClasses;

namespace Program.Forms {
  public partial class MainForm : MaterialForm {
    
    bool displayed = false;
    bool closing = false;
    
    List<MaterialFlatButton> leftbtns = new List<MaterialFlatButton>();
    
    public MainForm() {
      InitializeComponent();
      
      var SkinManager = MaterialSkinManager.Instance;
      SkinManager.AddFormToManage(this);
      SkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
      //SkinManager.ColorScheme = new ColorScheme((Primary)0xed9936, (Primary)0xd58930, Primary.Brown600, Accent.Blue400, TextShade.BLACK);
    
      leftbtns.AddRange(new []{btn_left_guests, btn_left_security, btn_left_stats, btn_history});
    }
    
    public void LoadPermissions(){
      if (Session.user.permissions == "all") {
        btn_left_admin.Visible = true;
        leftbtns.Add(btn_left_admin);
      }
    }
    
    public void Form_Load(object sender, EventArgs e) {
      //var month = new Month() {general = new General() {huespedes = new List<Huesped> { new Huesped() {Nombre = "Mateo", DNI = 42149747, Ficha = 1 } } } };
      //var month = JsonConvert.DeserializeObject<Month>(DBConn.GetJSON(2018, "enero"));

      //month.general.huespedes.Add(new Huesped() {Nombre = "Velcic", Ficha = 2, DNI = 34849790 });
      //DBConn.UpdateJson(2000, "enero", JsonConvert.SerializeObject(month));

      //label1.Text = (month.IsNull()) ? "No values" : month.general.huespedes.First().Nombre;
      
      //label1.Text = ;
      
      var f = new FormGuests();
	      f.TopLevel = false;
	      panel3.Controls.Add(f);
	      panel3.Tag = f;
	      f.Parent = panel3;
	      f.Show();
    }
    
    void MainFormFormClosing(object sender, FormClosingEventArgs e)
    {
		if(!closing){
    		
    		e.Cancel = true;
    		
			var t = new Transition(new TransitionType_Acceleration(600));
				t.add(this, "Top", Screen.PrimaryScreen.Bounds.Height);
				t.TransitionCompletedEvent += (_, __) => this.Close();
				t.run();
				
			closing = true;
		}
    }
    
    void MainFormFormClosed(object sender, FormClosedEventArgs e)
    {
      Application.Exit();
    }
    
    void MaterialFlatButton2Click(object sender, EventArgs e)
    {
      Transition t = new Transition(new TransitionType_Deceleration(600));
      t.add(panel2, "Width", (displayed) ? 42 : 185);
      t.run();
      displayed = !displayed;
    }
    
    void MaterialRaisedButton1Click(object sender, EventArgs e)
    {
    	var b = sender as Button;
    	b.FlatStyle = FlatStyle.Flat;
    	b.FlatAppearance.BorderSize = 0;
    	b.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
    	b.ForeColor = Color.Transparent;
    }
    
    void LeftBarClick(object sender, EventArgs e)
    {
      var s = sender as MaterialFlatButton;
      
      var t = new Transition(new TransitionType_Deceleration(500));
      t.add(btn_addG, "Top", (s.Name == "btn_left_guests") ? 28 : 64);
      t.run();
    	    	
    	leftbtns.FindAll(x => x != s).ForEach(x => x.selected = false);
    	s.selected = true;
    	
    }
    
    void Timer1Tick(object sender, EventArgs e)
    {
      leftbtns.ForEach(x => x.Refresh());
    }
    
    void Btn_addGClick(object sender, EventArgs e)
    {
      if(!panel3.Controls.containsType(typeof(FormAddGuest))){
      
        var t = new FormAddGuest();
  	      t.TopLevel = false;
  	      panel3.Controls.Add(t);
  	      panel3.Tag = t;
  	      t.Parent = panel3;
  	      t.Show();
  	      t.Top = -t.Height;
  	      t.BringToFront();
  	      
  	    var tr = new Transition(new TransitionType_Deceleration(500));
  	      tr.add(t, "Top", 0);
  	      tr.run();
      }
    }
  }
}
