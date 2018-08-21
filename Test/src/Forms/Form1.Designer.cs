/*
 * Created By 42476232
 * On 16/08/2018
 * Time: 10:43 a.m.
 */
namespace Program.Forms
{
  partial class Form1
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
      this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
      this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
      this.SuspendLayout();
      // 
      // materialLabel1
      // 
      this.materialLabel1.Depth = 0;
      this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
      this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.materialLabel1.Location = new System.Drawing.Point(57, 27);
      this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
      this.materialLabel1.Name = "materialLabel1";
      this.materialLabel1.Size = new System.Drawing.Size(165, 23);
      this.materialLabel1.TabIndex = 0;
      this.materialLabel1.Text = "Test form inside form";
      // 
      // materialFlatButton1
      // 
      this.materialFlatButton1.AutoSize = true;
      this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      this.materialFlatButton1.Depth = 0;
      this.materialFlatButton1.Icon = null;
      this.materialFlatButton1.Location = new System.Drawing.Point(111, 56);
      this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
      this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
      this.materialFlatButton1.Name = "materialFlatButton1";
      this.materialFlatButton1.Primary = false;
      this.materialFlatButton1.Size = new System.Drawing.Size(59, 36);
      this.materialFlatButton1.TabIndex = 1;
      this.materialFlatButton1.Text = "Click";
      this.materialFlatButton1.UseVisualStyleBackColor = true;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
      this.ClientSize = new System.Drawing.Size(271, 104);
      this.Controls.Add(this.materialFlatButton1);
      this.Controls.Add(this.materialLabel1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Name = "Form1";
      this.Text = "Form1";
      this.ResumeLayout(false);
      this.PerformLayout();
    }
    private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
    private MaterialSkin.Controls.MaterialLabel materialLabel1;
  }
}
