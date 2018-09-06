/*
 * Created By 42476232
 * On 04/09/2018
 * Time: 10:11 a.m.
 */
namespace Program.Forms
{
  partial class FormGuests
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
      this.panel1 = new System.Windows.Forms.Panel();
      this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
      this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
      this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
      this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
      this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
      this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
      this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
      this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
      this.materialSingleLineTextField1 = new MaterialSkin.Controls.MaterialSingleLineTextField();
      this.materialSingleLineTextField2 = new MaterialSkin.Controls.MaterialSingleLineTextField();
      this.materialSingleLineTextField3 = new MaterialSkin.Controls.MaterialSingleLineTextField();
      this.materialSingleLineTextField4 = new MaterialSkin.Controls.MaterialSingleLineTextField();
      this.materialSingleLineTextField5 = new MaterialSkin.Controls.MaterialSingleLineTextField();
      this.materialSingleLineTextField6 = new MaterialSkin.Controls.MaterialSingleLineTextField();
      this.materialSingleLineTextField7 = new MaterialSkin.Controls.MaterialSingleLineTextField();
      this.materialSingleLineTextField8 = new MaterialSkin.Controls.MaterialSingleLineTextField();
      this.panel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // panel1
      // 
      this.panel1.AutoScroll = true;
      this.panel1.BackColor = System.Drawing.Color.White;
      this.panel1.Controls.Add(this.materialLabel3);
      this.panel1.Controls.Add(this.materialFlatButton1);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.panel1.Location = new System.Drawing.Point(0, 79);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(741, 439);
      this.panel1.TabIndex = 0;
      // 
      // materialLabel3
      // 
      this.materialLabel3.Depth = 0;
      this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
      this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.materialLabel3.Location = new System.Drawing.Point(29, 14);
      this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
      this.materialLabel3.Name = "materialLabel3";
      this.materialLabel3.Size = new System.Drawing.Size(199, 23);
      this.materialLabel3.TabIndex = 1;
      this.materialLabel3.Text = "materialLabel3";
      this.materialLabel3.Click += new System.EventHandler(this.MaterialLabel3Click);
      this.materialLabel3.MouseEnter += new System.EventHandler(this.MaterialLabel3MouseEnter);
      // 
      // materialFlatButton1
      // 
      this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      this.materialFlatButton1.Depth = 0;
      this.materialFlatButton1.Icon = null;
      this.materialFlatButton1.Location = new System.Drawing.Point(2, 6);
      this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
      this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
      this.materialFlatButton1.Name = "materialFlatButton1";
      this.materialFlatButton1.Primary = false;
      this.materialFlatButton1.selected = false;
      this.materialFlatButton1.Size = new System.Drawing.Size(735, 36);
      this.materialFlatButton1.TabIndex = 0;
      this.materialFlatButton1.Text = "materialFlatButton1";
      this.materialFlatButton1.UseVisualStyleBackColor = true;
      this.materialFlatButton1.Click += new System.EventHandler(this.MaterialFlatButton1Click);
      this.materialFlatButton1.MouseEnter += new System.EventHandler(this.MaterialFlatButton1MouseEnter);
      // 
      // materialLabel1
      // 
      this.materialLabel1.Depth = 0;
      this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
      this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.materialLabel1.Location = new System.Drawing.Point(12, 7);
      this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
      this.materialLabel1.Name = "materialLabel1";
      this.materialLabel1.Size = new System.Drawing.Size(47, 23);
      this.materialLabel1.TabIndex = 1;
      this.materialLabel1.Text = "Ficha";
      // 
      // materialLabel2
      // 
      this.materialLabel2.Depth = 0;
      this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
      this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.materialLabel2.Location = new System.Drawing.Point(65, 7);
      this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
      this.materialLabel2.Name = "materialLabel2";
      this.materialLabel2.Size = new System.Drawing.Size(184, 23);
      this.materialLabel2.TabIndex = 2;
      this.materialLabel2.Text = "Huesped";
      // 
      // materialLabel4
      // 
      this.materialLabel4.Depth = 0;
      this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
      this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.materialLabel4.Location = new System.Drawing.Point(255, 7);
      this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
      this.materialLabel4.Name = "materialLabel4";
      this.materialLabel4.Size = new System.Drawing.Size(86, 23);
      this.materialLabel4.TabIndex = 4;
      this.materialLabel4.Text = "Habitacion";
      // 
      // materialLabel5
      // 
      this.materialLabel5.Depth = 0;
      this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
      this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.materialLabel5.Location = new System.Drawing.Point(347, 7);
      this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
      this.materialLabel5.Name = "materialLabel5";
      this.materialLabel5.Size = new System.Drawing.Size(58, 23);
      this.materialLabel5.TabIndex = 5;
      this.materialLabel5.Text = "Locker";
      // 
      // materialLabel6
      // 
      this.materialLabel6.Depth = 0;
      this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
      this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.materialLabel6.Location = new System.Drawing.Point(411, 7);
      this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
      this.materialLabel6.Name = "materialLabel6";
      this.materialLabel6.Size = new System.Drawing.Size(206, 23);
      this.materialLabel6.TabIndex = 6;
      this.materialLabel6.Text = "Paciente";
      // 
      // materialLabel8
      // 
      this.materialLabel8.Depth = 0;
      this.materialLabel8.Font = new System.Drawing.Font("Roboto", 11F);
      this.materialLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.materialLabel8.Location = new System.Drawing.Point(623, 7);
      this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
      this.materialLabel8.Name = "materialLabel8";
      this.materialLabel8.Size = new System.Drawing.Size(100, 23);
      this.materialLabel8.TabIndex = 8;
      this.materialLabel8.Text = "Procedencia";
      // 
      // materialSingleLineTextField1
      // 
      this.materialSingleLineTextField1.Depth = 0;
      this.materialSingleLineTextField1.Hint = "N";
      this.materialSingleLineTextField1.Location = new System.Drawing.Point(12, 50);
      this.materialSingleLineTextField1.MaxLength = 32;
      this.materialSingleLineTextField1.MouseState = MaterialSkin.MouseState.HOVER;
      this.materialSingleLineTextField1.Name = "materialSingleLineTextField1";
      this.materialSingleLineTextField1.PasswordChar = '\0';
      this.materialSingleLineTextField1.SelectedText = "";
      this.materialSingleLineTextField1.SelectionLength = 0;
      this.materialSingleLineTextField1.SelectionStart = 0;
      this.materialSingleLineTextField1.Size = new System.Drawing.Size(47, 23);
      this.materialSingleLineTextField1.TabIndex = 9;
      this.materialSingleLineTextField1.TabStop = false;
      this.materialSingleLineTextField1.UseSystemPasswordChar = false;
      // 
      // materialSingleLineTextField2
      // 
      this.materialSingleLineTextField2.Depth = 0;
      this.materialSingleLineTextField2.Hint = "Nombre";
      this.materialSingleLineTextField2.Location = new System.Drawing.Point(65, 50);
      this.materialSingleLineTextField2.MaxLength = 32767;
      this.materialSingleLineTextField2.MouseState = MaterialSkin.MouseState.HOVER;
      this.materialSingleLineTextField2.Name = "materialSingleLineTextField2";
      this.materialSingleLineTextField2.PasswordChar = '\0';
      this.materialSingleLineTextField2.SelectedText = "";
      this.materialSingleLineTextField2.SelectionLength = 0;
      this.materialSingleLineTextField2.SelectionStart = 0;
      this.materialSingleLineTextField2.Size = new System.Drawing.Size(84, 23);
      this.materialSingleLineTextField2.TabIndex = 10;
      this.materialSingleLineTextField2.TabStop = false;
      this.materialSingleLineTextField2.UseSystemPasswordChar = false;
      // 
      // materialSingleLineTextField3
      // 
      this.materialSingleLineTextField3.Depth = 0;
      this.materialSingleLineTextField3.Hint = "Apellido";
      this.materialSingleLineTextField3.Location = new System.Drawing.Point(165, 50);
      this.materialSingleLineTextField3.MaxLength = 32767;
      this.materialSingleLineTextField3.MouseState = MaterialSkin.MouseState.HOVER;
      this.materialSingleLineTextField3.Name = "materialSingleLineTextField3";
      this.materialSingleLineTextField3.PasswordChar = '\0';
      this.materialSingleLineTextField3.SelectedText = "";
      this.materialSingleLineTextField3.SelectionLength = 0;
      this.materialSingleLineTextField3.SelectionStart = 0;
      this.materialSingleLineTextField3.Size = new System.Drawing.Size(84, 23);
      this.materialSingleLineTextField3.TabIndex = 11;
      this.materialSingleLineTextField3.TabStop = false;
      this.materialSingleLineTextField3.UseSystemPasswordChar = false;
      // 
      // materialSingleLineTextField4
      // 
      this.materialSingleLineTextField4.Depth = 0;
      this.materialSingleLineTextField4.Hint = "N";
      this.materialSingleLineTextField4.Location = new System.Drawing.Point(255, 50);
      this.materialSingleLineTextField4.MaxLength = 32767;
      this.materialSingleLineTextField4.MouseState = MaterialSkin.MouseState.HOVER;
      this.materialSingleLineTextField4.Name = "materialSingleLineTextField4";
      this.materialSingleLineTextField4.PasswordChar = '\0';
      this.materialSingleLineTextField4.SelectedText = "";
      this.materialSingleLineTextField4.SelectionLength = 0;
      this.materialSingleLineTextField4.SelectionStart = 0;
      this.materialSingleLineTextField4.Size = new System.Drawing.Size(86, 23);
      this.materialSingleLineTextField4.TabIndex = 12;
      this.materialSingleLineTextField4.TabStop = false;
      this.materialSingleLineTextField4.UseSystemPasswordChar = false;
      // 
      // materialSingleLineTextField5
      // 
      this.materialSingleLineTextField5.Depth = 0;
      this.materialSingleLineTextField5.Hint = "N";
      this.materialSingleLineTextField5.Location = new System.Drawing.Point(347, 50);
      this.materialSingleLineTextField5.MaxLength = 32767;
      this.materialSingleLineTextField5.MouseState = MaterialSkin.MouseState.HOVER;
      this.materialSingleLineTextField5.Name = "materialSingleLineTextField5";
      this.materialSingleLineTextField5.PasswordChar = '\0';
      this.materialSingleLineTextField5.SelectedText = "";
      this.materialSingleLineTextField5.SelectionLength = 0;
      this.materialSingleLineTextField5.SelectionStart = 0;
      this.materialSingleLineTextField5.Size = new System.Drawing.Size(58, 23);
      this.materialSingleLineTextField5.TabIndex = 13;
      this.materialSingleLineTextField5.TabStop = false;
      this.materialSingleLineTextField5.UseSystemPasswordChar = false;
      // 
      // materialSingleLineTextField6
      // 
      this.materialSingleLineTextField6.Depth = 0;
      this.materialSingleLineTextField6.Hint = "Nombre";
      this.materialSingleLineTextField6.Location = new System.Drawing.Point(411, 50);
      this.materialSingleLineTextField6.MaxLength = 32767;
      this.materialSingleLineTextField6.MouseState = MaterialSkin.MouseState.HOVER;
      this.materialSingleLineTextField6.Name = "materialSingleLineTextField6";
      this.materialSingleLineTextField6.PasswordChar = '\0';
      this.materialSingleLineTextField6.SelectedText = "";
      this.materialSingleLineTextField6.SelectionLength = 0;
      this.materialSingleLineTextField6.SelectionStart = 0;
      this.materialSingleLineTextField6.Size = new System.Drawing.Size(101, 23);
      this.materialSingleLineTextField6.TabIndex = 14;
      this.materialSingleLineTextField6.TabStop = false;
      this.materialSingleLineTextField6.UseSystemPasswordChar = false;
      // 
      // materialSingleLineTextField7
      // 
      this.materialSingleLineTextField7.Depth = 0;
      this.materialSingleLineTextField7.Hint = "Apellido";
      this.materialSingleLineTextField7.Location = new System.Drawing.Point(518, 50);
      this.materialSingleLineTextField7.MaxLength = 32767;
      this.materialSingleLineTextField7.MouseState = MaterialSkin.MouseState.HOVER;
      this.materialSingleLineTextField7.Name = "materialSingleLineTextField7";
      this.materialSingleLineTextField7.PasswordChar = '\0';
      this.materialSingleLineTextField7.SelectedText = "";
      this.materialSingleLineTextField7.SelectionLength = 0;
      this.materialSingleLineTextField7.SelectionStart = 0;
      this.materialSingleLineTextField7.Size = new System.Drawing.Size(99, 23);
      this.materialSingleLineTextField7.TabIndex = 15;
      this.materialSingleLineTextField7.TabStop = false;
      this.materialSingleLineTextField7.UseSystemPasswordChar = false;
      // 
      // materialSingleLineTextField8
      // 
      this.materialSingleLineTextField8.Depth = 0;
      this.materialSingleLineTextField8.Hint = "Procedencia";
      this.materialSingleLineTextField8.Location = new System.Drawing.Point(623, 50);
      this.materialSingleLineTextField8.MaxLength = 32767;
      this.materialSingleLineTextField8.MouseState = MaterialSkin.MouseState.HOVER;
      this.materialSingleLineTextField8.Name = "materialSingleLineTextField8";
      this.materialSingleLineTextField8.PasswordChar = '\0';
      this.materialSingleLineTextField8.SelectedText = "";
      this.materialSingleLineTextField8.SelectionLength = 0;
      this.materialSingleLineTextField8.SelectionStart = 0;
      this.materialSingleLineTextField8.Size = new System.Drawing.Size(100, 23);
      this.materialSingleLineTextField8.TabIndex = 16;
      this.materialSingleLineTextField8.TabStop = false;
      this.materialSingleLineTextField8.UseSystemPasswordChar = false;
      // 
      // FormGuests
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(741, 518);
      this.Controls.Add(this.materialSingleLineTextField8);
      this.Controls.Add(this.materialSingleLineTextField7);
      this.Controls.Add(this.materialSingleLineTextField6);
      this.Controls.Add(this.materialSingleLineTextField5);
      this.Controls.Add(this.materialSingleLineTextField4);
      this.Controls.Add(this.materialSingleLineTextField3);
      this.Controls.Add(this.materialSingleLineTextField2);
      this.Controls.Add(this.materialSingleLineTextField1);
      this.Controls.Add(this.materialLabel8);
      this.Controls.Add(this.materialLabel6);
      this.Controls.Add(this.materialLabel5);
      this.Controls.Add(this.materialLabel4);
      this.Controls.Add(this.materialLabel2);
      this.Controls.Add(this.materialLabel1);
      this.Controls.Add(this.panel1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Name = "FormGuests";
      this.Text = "FormGuests";
      this.panel1.ResumeLayout(false);
      this.ResumeLayout(false);
    }
    private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField8;
    private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField7;
    private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField6;
    private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField5;
    private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField4;
    private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField3;
    private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField2;
    private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField1;
    private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
    private MaterialSkin.Controls.MaterialLabel materialLabel3;
    private MaterialSkin.Controls.MaterialLabel materialLabel8;
    private MaterialSkin.Controls.MaterialLabel materialLabel6;
    private MaterialSkin.Controls.MaterialLabel materialLabel5;
    private MaterialSkin.Controls.MaterialLabel materialLabel4;
    private MaterialSkin.Controls.MaterialLabel materialLabel2;
    private MaterialSkin.Controls.MaterialLabel materialLabel1;
    private System.Windows.Forms.Panel panel1;
  }
}
