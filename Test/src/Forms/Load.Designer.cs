/*
 * Created By 42476232
 * On 17/08/2018
 * Time: 11:18 a.m.
 */
namespace Program.Forms
{
  partial class Load
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
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Load));
      this.timer1 = new System.Windows.Forms.Timer(this.components);
      this.timer2 = new System.Windows.Forms.Timer(this.components);
      this.progressSpinner1 = new CNSpinner.ProgressSpinner();
      this.SuspendLayout();
      // 
      // timer1
      // 
      this.timer1.Enabled = true;
      this.timer1.Interval = 2000;
      this.timer1.Tick += new System.EventHandler(this.Timer1Tick);
      // 
      // timer2
      // 
      this.timer2.Enabled = true;
      this.timer2.Interval = 1000;
      this.timer2.Tick += new System.EventHandler(this.Timer2Tick);
      // 
      // progressSpinner1
      // 
      this.progressSpinner1.LoadGIFImage = ((System.Drawing.Image)(resources.GetObject("progressSpinner1.LoadGIFImage")));
      this.progressSpinner1.Location = new System.Drawing.Point(73, 63);
      this.progressSpinner1.Name = "progressSpinner1";
      this.progressSpinner1.Size = new System.Drawing.Size(128, 128);
      this.progressSpinner1.TabIndex = 0;
      // 
      // Load
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
      this.ClientSize = new System.Drawing.Size(284, 262);
      this.Controls.Add(this.progressSpinner1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Name = "Load";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Load";
      this.ResumeLayout(false);
    }
    private System.Windows.Forms.Timer timer2;
    private System.Windows.Forms.Timer timer1;
    private CNSpinner.ProgressSpinner progressSpinner1;
  }
}
