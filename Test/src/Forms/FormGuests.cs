using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using MaterialSkin.Controls;
using Program.Classes;
using Program.StaticClasses;


///////PIDAAAAAAL COMENTA EL CODIGO
namespace Program.Forms
{
  public partial class FormGuests : Form
  {
    
      public static int nbig = 1;
    
    class guestControl {
      
      public MaterialLabel ficha,hsurname, hname, hab, locker, pname, psurname, proc;
      private Guest _g;
      private bool _big;
      
      public guestControl(Guest g, int c) {
        
        _g = g;

        _big = (g.ficha.Length > 5) || g.paciente.name.Length > 20;
        
        int top = nbig * 15 + c * 25;
        int h = (_big) ? 33 : 18;

        ficha = new MaterialLabel(){Top = top, Left = 12, Text = g.ficha, Width = 50, Height = h};
        hsurname = new MaterialLabel(){Top = top, Left = 65, Text = g.paciente.surname, Width = 84, Height = h};
        hname =  new MaterialLabel(){Top = top, Left = 165, Text = g.paciente.name, Width = 84, Height = h};
        hab =  new MaterialLabel(){Top = top, Left = 255, Text = g.hab.ToString(), Width = 86, Height = h};
        locker =  new MaterialLabel(){Top = top, Left = 347, Text = g.locker, Width = 58, Height = h};
        pname = new MaterialLabel(){Top = top, Left = 518, Text = g.internado.name, Width = 99, Height = h};
        psurname = new MaterialLabel(){Top = top, Left = 411, Text = g.internado.surname, Width = 101, Height = h};
        proc =  new MaterialLabel(){Top = top, Left = 623, Text = g.procedencia, Width = 100, Height = h};
        
        nbig += (_big) ? 1 : 0;
        
        ficha.SendToBack();
      }
      
      public void UpdateTop(int c){
        
        int top = nbig * 15 + c * 25;
        
        ficha.Top = top;
        hsurname.Top = top;
        hname.Top = top;
        hab.Top = top;
        locker.Top = top;
        pname.Top = top;
        psurname.Top = top;
        proc.Top = top;
        
        nbig += (_big) ? 1 : 0;
      }
      
      public List<Control> getControls(){
        List<Control> l = new List<Control>();
        
        l.AddRange(new []{ficha,hsurname, hname,
                     hab, locker,
                    pname, psurname, proc});
        
        return l;
      }
    }
    
    List<guestControl> guestControls;
    
    public FormGuests()
    {
      InitializeComponent();
      guestControls = new List<FormGuests.guestControl>();
    }
    
    public void updateGuests(){
      
      panel1.Controls.Clear();
      guestControls.Clear();
      
      DBConn.getGuests().ForEach(x => guestControls.Add(new guestControl(x, guestControls.Count)));
      
      nbig = 1;
      
      guestControls.ForEach(x => {
                              panel1.Controls.Add(x.ficha);
                              panel1.Controls.Add(x.hsurname);
                              panel1.Controls.Add(x.hname);                             
                              panel1.Controls.Add(x.hab);
                              panel1.Controls.Add(x.locker);
                              panel1.Controls.Add(x.pname);
                              panel1.Controls.Add(x.psurname);
                              panel1.Controls.Add(x.proc);
                            });
    }
    
    void OnLoad(object sender, EventArgs e)
    {
      updateGuests();
    }
    
    void Text_Changed(object sender, KeyEventArgs e)
    {
      int a = 0;
      
      guestControls.ForEach(x => {if(x.ficha.Text.ToLower().StartsWith(txt_ficha.Text.ToLower()) &&
                                                    x.hsurname.Text.ToLower().StartsWith(txt_hsurname.Text.ToLower()) &&
                                                    x.hname.Text.ToLower().StartsWith(txt_hname.Text.ToLower()) &&
                                                    x.hab.Text.StartsWith(txt_nhab.Text) &&
                                                    x.locker.Text.ToLower().StartsWith(txt_nlock.Text.ToLower()) &&
                                                    x.pname.Text.ToLower().StartsWith(txt_pname.Text.ToLower()) &&
                                                    x.psurname.Text.ToLower().StartsWith(txt_psurname.Text.ToLower()) &&
                                                    x.proc.Text.ToLower().StartsWith(txt_proc.Text.ToLower())){
                                x.getControls().ForEach(y => y.Visible = true);
                                x.UpdateTop(a++);
                              } else {
                                x.getControls().ForEach(y => y.Visible = false);
                              }});
      
      nbig = 1;    
    }   
  }
}
