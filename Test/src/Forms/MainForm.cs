using System;
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
      if ((Session.user.permissions[3] & 7) == 7) {
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
      
	      panel3.Controls.Add(StaticForms.FG);
	      panel3.Tag = StaticForms.FG;
	      StaticForms.FG.Parent = panel3;
	      StaticForms.FG.Show();
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
    	
      var senderIndex = leftbtns.FindIndex(x => x == s);
      
      var selectedIndex = leftbtns.FindIndex(x => x.selected);
      
      if(!s.selected) {
        int a = 0;
        panel3.Controls.forEach(x => {
                                  var tt = new Transition(new TransitionType_Deceleration(500 + a++ * 100));
                                    tt.add(x, "Top", (senderIndex < selectedIndex) ? 518 : -x.Height);

                                    //Console.WriteLine(String.Format("{0}, {1}", a, panel3.Controls.Count));
                                      tt.TransitionCompletedEvent += (_, __) => x.Tag = "ready";
                                    tt.run();
                                });
        
        var t = new Transition(new TransitionType_Deceleration(500 + a * 100));
        
        switch (s.Name) {
          case "btn_left_guests":
            panel3.Controls.Add(StaticForms.FG);
            StaticForms.FG.Top = -StaticForms.FG.Height;
            StaticForms.FG.Show();
            
            t.add(StaticForms.FG, "Top", 0);
              
            t.run();
            break;
          case "btn_left_admin":
            var f = new FormAddUser();
            f.TopLevel = false;
            
            panel3.Controls.Add(f);
            
            f.Top = 518;
            f.Show();
            
            t.add(f, "Top", 0);
            t.run();
            
            break;
          case "btn_left_stats":
         
	  	      panel3.Controls.Add(StaticForms.FSH);
	  	      StaticForms.FSH.Parent = panel3;
  	      	StaticForms.FSH.Show();
	  	      StaticForms.FSH.Top = (senderIndex < selectedIndex) ? -StaticForms.FSH.Height : 518;
	  	      
            t.add(StaticForms.FSH, "Top", 0);
            t.run();
            break;
        }
        
        var t3 = new Transition(new TransitionType_Acceleration(500));
          t3.add(btn_addG, "Top", (s.Name == "btn_left_guests") ? 28 : 64);
          t3.add(btn_refresh, "Top", (s.Name == "btn_left_guests") ? 28 : 64);
          t3.run();
        
        leftbtns[selectedIndex].selected = false;
    	  s.selected = true;
    	  
    	  //Console.WriteLine(t3);
      }
    }
    
    void Timer1Tick(object sender, EventArgs e)
    {
      leftbtns.ForEach(x => x.Refresh());
      
      var c = panel3.Controls.Count;
      for (int i = 0; i < c; i++) {
        #pragma warning disable 252
        if (panel3.Controls[i].Tag == "ready" && (panel3.Controls[i].Top == 518 || panel3.Controls[i].Top == -panel3.Controls[i].Height)) {
          #pragma warning restore 252
          panel3.Controls[i].Tag = "";
          panel3.Controls.RemoveAt(i--);
          c--;
        }
      }
    }
    
    
    void Btn_addGClick(object sender, EventArgs e)
	{
	    if(!panel3.Controls.containsType(typeof(FormAddGuestHome))){
          
        StaticForms.FAG = new FormAddGuestHome();
          StaticForms.FAG.TopLevel = false;
  	      panel3.Tag = StaticForms.FAG;
  	      StaticForms.FAG.Parent = panel3;
  	      panel3.Controls.Add(StaticForms.FAG);
	      	StaticForms.FAG.Show();
  	      StaticForms.FAG.Top = -StaticForms.FAG.Height;
  	      StaticForms.FAG.BringToFront();
	  	      
	  	    var tr = new Transition(new TransitionType_Deceleration(500));
	  	      tr.add(StaticForms.FAG, "Top", 0);
  	      		tr.run();
      	}
    }
    
    void Btn_refreshClick(object sender, EventArgs e)
    {
      (panel3.Controls[0] as FormGuests).updateGuests();
    }
  }
}
