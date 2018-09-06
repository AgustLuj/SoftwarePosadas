/*
 * Created By 42476232
 * On 06/09/2018
 * Time: 09:15 a.m.
 */
namespace Program.Classes
{
  partial class Guest
  {
    /// <summary>
    /// Designer variable used to keep track of non-visual components.
    /// </summary>
    private System.ComponentModel.IContainer components = null;
    
    /// <summary>
    /// Disposes resources used by the form.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing) {
        if (components != null) {
          components.Dispose();
        }
      }
      base.Dispose(disposing);
    }
    
    /// <summary>
    /// This method is required for Windows Forms designer support.
    /// Do not change the method contents inside the source code editor. The Forms designer might
    /// not be able to load this method if it was changed manually.
    /// </summary>
    private void InitializeComponent()
    {
      // 
      // Guest
      // 
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Text = "Guest";
      this.Name = "Guest";
    }
  }
}
