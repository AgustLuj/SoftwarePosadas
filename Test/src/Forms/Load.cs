/*
 * Created By 42476232
 * On 17/08/2018
 * Time: 11:18 a.m.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

using Transitions;

namespace Program.Forms
{
  /// <summary>
  /// Description of Load.
  /// </summary>
  public partial class Load : Form
  {
    Form f;
    
    public Load()
    {
      InitializeComponent();
      
      TransparencyKey = BackColor = Color.White;
      
      f = new Login();
      f.Show();
      f.Visible = false;
      f.Location = new Point((Screen.PrimaryScreen.Bounds.Width >> 1) - (f.Width >> 1), Screen.PrimaryScreen.Bounds.Height);
    }
    
    void Timer1Tick(object sender, EventArgs e)
    {
      timer1.Enabled = false;
      
      Transition t = new Transition(new TransitionType_CriticalDamping(800));
        t.add(f, "Top", (Screen.PrimaryScreen.Bounds.Height >> 1) - (f.Height >> 1));
        f.Visible = true;
        t.run();
        
      this.Close();
    }
    
    void Timer2Tick(object sender, EventArgs e)
    {
      timer2.Enabled = false;
      timer1.Enabled = true;
      
      Transition t = new Transition(new TransitionType_Acceleration(700));
      t.add(this, "Top", -Height);
      
      t.run();
    }
  }
}
