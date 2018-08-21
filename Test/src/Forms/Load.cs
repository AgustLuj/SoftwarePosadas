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
    MainForm f;
    
    public Load()
    {
      //
      // The InitializeComponent() call is required for Windows Forms designer support.
      //
      InitializeComponent();
      
      //this.BackColor = Color.LimeGreen;
      this.TransparencyKey = Color.FromKnownColor(KnownColor.Control);
      f = new MainForm();
      f.Show();
      f.Visible = false;
      f.Location = new Point((Screen.PrimaryScreen.Bounds.Width >> 1) - (f.Width >> 1), Screen.PrimaryScreen.Bounds.Height);
      //
      // TODO: Add constructor code after the InitializeComponent() call.
      //
    }
    
    void Timer1Tick(object sender, EventArgs e)
    {
      timer1.Enabled = false;
      Transition t = new Transition(new TransitionType_CriticalDamping(1200));
      t.add(f, "Top", (Screen.PrimaryScreen.Bounds.Height >> 1) - (f.Height >> 1));
      f.Visible = true;
      t.run();
      this.Close();
    }
    
    void Timer2Tick(object sender, EventArgs e)
    {
      timer2.Enabled = false;
      
      Transition t = new Transition(new TransitionType_Acceleration(1100));
      t.add(this, "Top", -400);
      
      t.run();
    }
  }
}
