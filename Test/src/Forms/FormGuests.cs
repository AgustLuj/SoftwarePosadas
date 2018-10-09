/*
 * Created By 42476232
 * On 04/09/2018
 * Time: 10:11 a.m.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

using MaterialSkin.Controls;

using Program.Classes;
using Program.StaticClasses;

namespace Program.Forms
{
  public partial class FormGuests : Form
  {
    class guestControl {
      public MaterialLabel ficha, hname, hsurname, hab, locker, pname, psurname, proc;
      
      public guestControl(Guest g, int c) {
        ficha = new MaterialLabel(){Top = 10 + c * 25, Left = 12, Text = g.ficha, Width = 50};
        hname = new MaterialLabel(){Top = 10 + c * 25, Left = 65, Text = g.paciente.name, Width = 84};
        hsurname =  new MaterialLabel(){Top = 10 + c * 25, Left = 165, Text = g.paciente.surname, Width = 84};
        hab =  new MaterialLabel(){Top = 10 + c * 25, Left = 255, Text = g.hab.ToString(), Width = 86};
        locker =  new MaterialLabel(){Top = 10 + c * 25, Left = 347, Text = g.locker, Width = 58};
        pname =  new MaterialLabel(){Top = 10 + c * 25, Left = 411, Text = g.internado.name, Width = 101};
        psurname = new MaterialLabel(){Top = 10 + c * 25, Left = 518, Text = g.internado.surname, Width = 99};
        proc =  new MaterialLabel(){Top = 10 + c * 25, Left = 623, Text = g.procedencia, Width = 100};
      }
      
      public void UpdateTop(int c){
        ficha.Top = 10 + c * 25;
        hname.Top = 10 + c * 25;
        hsurname.Top = 10 + c * 25;
        hab.Top = 10 + c * 25;
        locker.Top = 10 + c * 25;
        pname.Top = 10 + c * 25;
        psurname.Top = 10 + c * 25;
        proc.Top = 10 + c * 25;
      }
      
      public List<Control> getControls(){
        List<Control> l = new List<Control>();
        
        l.AddRange(new []{ficha, hname,
                    hsurname, hab, locker,
                    pname, psurname, proc});
        
        return l;
      }
    }
    
    List<guestControl> guestControls;
    List<guestControl> visibleGuestControls;
    
    public FormGuests()
    {
      InitializeComponent();
      guestControls = new List<FormGuests.guestControl>();
    }
    
    public void updateGuests(){
      panel1.Controls.Clear();
      guestControls.Clear();
      DBConn.getGuests().ForEach(x => guestControls.Add(new guestControl(x, guestControls.Count)));
      guestControls.ForEach(x => {
                              panel1.Controls.Add(x.ficha);
                              panel1.Controls.Add(x.hname);
                              panel1.Controls.Add(x.hsurname);
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
                                                    x.hname.Text.ToLower().StartsWith(txt_hname.Text.ToLower()) &&
                                                    x.hsurname.Text.ToLower().StartsWith(txt_hsurname.Text.ToLower()) &&
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
      
        
      
      
      /*panel1.Controls.Clear();
      
      visibleGuestControls = guestControls.FindAll(x => 
                                                   (x.ficha.Text.ToLower().StartsWith(txt_ficha.Text.ToLower()) &&
                                                    x.hname.Text.ToLower().StartsWith(txt_hname.Text.ToLower()) &&
                                                    x.hsurname.Text.ToLower().StartsWith(txt_hsurname.Text.ToLower()) &&
                                                    x.hab.Text.StartsWith(txt_nhab.Text) &&
                                                    x.locker.Text.ToLower().StartsWith(txt_nlock.Text.ToLower()) &&
                                                    x.pname.Text.ToLower().StartsWith(txt_pname.Text.ToLower()) &&
                                                    x.psurname.Text.ToLower().StartsWith(txt_psurname.Text.ToLower()) &&
                                                    x.proc.Text.ToLower().StartsWith(txt_proc.Text.ToLower())));
      
        visibleGuestControls.ForEach(x => x.UpdateTop(visibleGuestControls.IndexOf(x)));
        visibleGuestControls.ForEach(x => {
                                panel1.Controls.Add(x.ficha);
                                panel1.Controls.Add(x.hname);
                                panel1.Controls.Add(x.hsurname);
                                panel1.Controls.Add(x.hab);
                                panel1.Controls.Add(x.locker);
                                panel1.Controls.Add(x.pname);
                                panel1.Controls.Add(x.psurname);
                                panel1.Controls.Add(x.proc);
                              });*/
    
    }   
  }
}
