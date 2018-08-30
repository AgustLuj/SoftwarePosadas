/*
 * Created By 42476232
 * On 24/08/2018
 * Time: 09:59 a.m.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

using MaterialSkin;
using MaterialSkin.Controls;

using Program.Sessions;
using Program.Extensions;
using Program.StaticClasses;

using Transitions;

namespace Program.Forms
{
  public partial class Login : MaterialForm
  {
    
    MainForm ms;
    
    bool err = false;
    bool closing = false;
    bool logging = false;
    
    public Login()
    {
      InitializeComponent();
      
      ms = new MainForm();
        ms.Show();
        ms.Visible = false;
        ms.Location = new Point((Screen.PrimaryScreen.Bounds.Width >> 1) - (ms.Width >> 1), Screen.PrimaryScreen.Bounds.Height);
      
    }
    
    void LoginClick(object sender, EventArgs e)
    {
      logging = true;
      
      if(Session.Login(txt_uname.Text, txt_pass.Text)){
        
        Transition t = new Transition(new TransitionType_Deceleration(150));
          t.add(this, "Top", this.Top + 40);
          t.TransitionCompletedEvent += (a, b) => {
            Transition tt = new Transition(new TransitionType_EaseInEaseOut(550));
            tt.add(this, "Top", -Height);
            tt.run();
          };
          
          t.run();

        timer1.Enabled = true;
      } else {
      	
      	logging = false;
        lbl_err.ForeColor = Color.FromArgb(0xB00020);
        
        if(!err){
          Transition mt = new Transition(new TransitionType_EaseInEaseOut(400));
            mt.add(this, "Height", 348);
            mt.add(lbl_err, "Top", 284);
            mt.TransitionCompletedEvent += (x, y) => err = true;
            mt.run();
        } else {
          Transition mt = new Transition(new TransitionType_Bounce(400));
            mt.add(lbl_err, "Top", 264);
            mt.TransitionCompletedEvent += (x, y) => lbl_err.Top = 284;
            mt.run();
        }
      }
    }
    
    void Changed(object sender, EventArgs e)
    {
      txt_uname.Text = (sender as ToolStripMenuItem).Text;
    }
    
    void LoginFormClosed(object sender, FormClosedEventArgs e)
    {
      if (!Application.OpenForms.areVisible())
       Application.Exit();
    }
    
    void Timer1Tick(object sender, EventArgs e)
    {
      
      Transition t = new Transition(new TransitionType_CriticalDamping(700));
        t.add(ms, "Top", (Screen.PrimaryScreen.Bounds.Height >> 1) - (ms.Height >> 1));
        t.run();
      
      ms.Visible = true;
      ms.LoadPermissions();
            
      this.Close();
    }
    
    void LoginFormClosing(object sender, FormClosingEventArgs e)
    {	
    	if(!closing && !logging){
    		
    		e.Cancel = true;
    		
			var t = new Transition(new TransitionType_Acceleration(600));
				t.add(this, "Top", Screen.PrimaryScreen.Bounds.Height);
				t.TransitionCompletedEvent += (_, __) => this.Close();
				t.run();
				
			closing = true;
		}
    }
  }
}
