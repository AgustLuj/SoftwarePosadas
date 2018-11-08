/*
 * Created By 42476232
 * On 30/10/2018
 * Time: 10:53 a.m.
 */
namespace Program.Forms
{
  partial class FormStatsQuantity
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
    	this.pic = new System.Windows.Forms.PictureBox();
    	this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
    	this.panel1 = new System.Windows.Forms.Panel();
    	this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
    	((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
    	this.panel1.SuspendLayout();
    	this.SuspendLayout();
    	// 
    	// pic
    	// 
    	this.pic.Location = new System.Drawing.Point(0, 0);
    	this.pic.Name = "pic";
    	this.pic.Size = new System.Drawing.Size(1500, 200);
    	this.pic.TabIndex = 0;
    	this.pic.TabStop = false;
    	// 
    	// materialLabel1
    	// 
    	this.materialLabel1.Depth = 0;
    	this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
    	this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
    	this.materialLabel1.Location = new System.Drawing.Point(12, 35);
    	this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
    	this.materialLabel1.Name = "materialLabel1";
    	this.materialLabel1.Size = new System.Drawing.Size(323, 23);
    	this.materialLabel1.TabIndex = 26;
    	this.materialLabel1.Text = "Cantidad de Huéspedes que ingresaron\r\n";
    	// 
    	// panel1
    	// 
    	this.panel1.AutoScroll = true;
    	this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
    	this.panel1.Controls.Add(this.pic);
    	this.panel1.Location = new System.Drawing.Point(12, 67);
    	this.panel1.Name = "panel1";
    	this.panel1.Size = new System.Drawing.Size(685, 245);
    	this.panel1.TabIndex = 27;
    	// 
    	// materialFlatButton1
    	// 
    	this.materialFlatButton1.AutoSize = true;
    	this.materialFlatButton1.Depth = 0;
    	this.materialFlatButton1.Icon = null;
    	this.materialFlatButton1.Location = new System.Drawing.Point(585, 388);
    	this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
    	this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
    	this.materialFlatButton1.Name = "materialFlatButton1";
    	this.materialFlatButton1.Primary = false;
    	this.materialFlatButton1.selected = false;
    	this.materialFlatButton1.Size = new System.Drawing.Size(75, 36);
    	this.materialFlatButton1.TabIndex = 28;
    	this.materialFlatButton1.Text = "Cerrar";
    	this.materialFlatButton1.UseVisualStyleBackColor = true;
    	this.materialFlatButton1.Click += new System.EventHandler(this.MaterialFlatButton1Click);
    	// 
    	// FormStatsQuantity
    	// 
    	this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
    	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
    	this.BackColor = System.Drawing.Color.White;
    	this.ClientSize = new System.Drawing.Size(741, 518);
    	this.Controls.Add(this.materialFlatButton1);
    	this.Controls.Add(this.materialLabel1);
    	this.Controls.Add(this.panel1);
    	this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
    	this.Name = "FormStatsQuantity";
    	this.Text = "FormStatsQuantity";
    	this.Load += new System.EventHandler(this.FormStatsQuantityLoad);
    	((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
    	this.panel1.ResumeLayout(false);
    	this.ResumeLayout(false);
    	this.PerformLayout();
    }
    private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
    private System.Windows.Forms.Panel panel1;
    private MaterialSkin.Controls.MaterialLabel materialLabel1;
    private System.Windows.Forms.PictureBox pic;
  }
}
