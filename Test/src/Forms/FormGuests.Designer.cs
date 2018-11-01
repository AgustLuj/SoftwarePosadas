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
    	this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
    	this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
    	this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
    	this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
    	this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
    	this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
    	this.txt_ficha = new MaterialSkin.Controls.MaterialSingleLineTextField();
    	this.txt_hname = new MaterialSkin.Controls.MaterialSingleLineTextField();
    	this.txt_hsurname = new MaterialSkin.Controls.MaterialSingleLineTextField();
    	this.txt_nhab = new MaterialSkin.Controls.MaterialSingleLineTextField();
    	this.txt_nlock = new MaterialSkin.Controls.MaterialSingleLineTextField();
    	this.txt_pname = new MaterialSkin.Controls.MaterialSingleLineTextField();
    	this.txt_psurname = new MaterialSkin.Controls.MaterialSingleLineTextField();
    	this.txt_proc = new MaterialSkin.Controls.MaterialSingleLineTextField();
    	this.SuspendLayout();
    	// 
    	// panel1
    	// 
    	this.panel1.AutoScroll = true;
    	this.panel1.BackColor = System.Drawing.Color.White;
    	this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
    	this.panel1.Location = new System.Drawing.Point(0, 79);
    	this.panel1.Name = "panel1";
    	this.panel1.Size = new System.Drawing.Size(741, 439);
    	this.panel1.TabIndex = 0;
    	/*this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1Paint);*/
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
    	// txt_ficha
    	// 
    	this.txt_ficha.Depth = 0;
    	this.txt_ficha.Hint = "N";
    	this.txt_ficha.Location = new System.Drawing.Point(12, 50);
    	this.txt_ficha.MaxLength = 32;
    	this.txt_ficha.MouseState = MaterialSkin.MouseState.HOVER;
    	this.txt_ficha.Name = "txt_ficha";
    	this.txt_ficha.PasswordChar = '\0';
    	this.txt_ficha.SelectedText = "";
    	this.txt_ficha.SelectionLength = 0;
    	this.txt_ficha.SelectionStart = 0;
    	this.txt_ficha.Size = new System.Drawing.Size(47, 23);
    	this.txt_ficha.TabIndex = 9;
    	this.txt_ficha.TabStop = false;
    	this.txt_ficha.UseSystemPasswordChar = false;
    	this.txt_ficha.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Text_Changed);
    	// 
    	// txt_hname
    	// 
    	this.txt_hname.Depth = 0;
    	this.txt_hname.Hint = "Nombre";
    	this.txt_hname.Location = new System.Drawing.Point(65, 50);
    	this.txt_hname.MaxLength = 32767;
    	this.txt_hname.MouseState = MaterialSkin.MouseState.HOVER;
    	this.txt_hname.Name = "txt_hname";
    	this.txt_hname.PasswordChar = '\0';
    	this.txt_hname.SelectedText = "";
    	this.txt_hname.SelectionLength = 0;
    	this.txt_hname.SelectionStart = 0;
    	this.txt_hname.Size = new System.Drawing.Size(84, 23);
    	this.txt_hname.TabIndex = 10;
    	this.txt_hname.TabStop = false;
    	this.txt_hname.UseSystemPasswordChar = false;
    	this.txt_hname.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Text_Changed);
    	// 
    	// txt_hsurname
    	// 
    	this.txt_hsurname.Depth = 0;
    	this.txt_hsurname.Hint = "Apellido";
    	this.txt_hsurname.Location = new System.Drawing.Point(165, 50);
    	this.txt_hsurname.MaxLength = 32767;
    	this.txt_hsurname.MouseState = MaterialSkin.MouseState.HOVER;
    	this.txt_hsurname.Name = "txt_hsurname";
    	this.txt_hsurname.PasswordChar = '\0';
    	this.txt_hsurname.SelectedText = "";
    	this.txt_hsurname.SelectionLength = 0;
    	this.txt_hsurname.SelectionStart = 0;
    	this.txt_hsurname.Size = new System.Drawing.Size(84, 23);
    	this.txt_hsurname.TabIndex = 11;
    	this.txt_hsurname.TabStop = false;
    	this.txt_hsurname.UseSystemPasswordChar = false;
    	this.txt_hsurname.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Text_Changed);
    	// 
    	// txt_nhab
    	// 
    	this.txt_nhab.Depth = 0;
    	this.txt_nhab.Hint = "N";
    	this.txt_nhab.Location = new System.Drawing.Point(255, 50);
    	this.txt_nhab.MaxLength = 32767;
    	this.txt_nhab.MouseState = MaterialSkin.MouseState.HOVER;
    	this.txt_nhab.Name = "txt_nhab";
    	this.txt_nhab.PasswordChar = '\0';
    	this.txt_nhab.SelectedText = "";
    	this.txt_nhab.SelectionLength = 0;
    	this.txt_nhab.SelectionStart = 0;
    	this.txt_nhab.Size = new System.Drawing.Size(86, 23);
    	this.txt_nhab.TabIndex = 12;
    	this.txt_nhab.TabStop = false;
    	this.txt_nhab.UseSystemPasswordChar = false;
    	this.txt_nhab.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Text_Changed);
    	// 
    	// txt_nlock
    	// 
    	this.txt_nlock.Depth = 0;
    	this.txt_nlock.Hint = "N";
    	this.txt_nlock.Location = new System.Drawing.Point(347, 50);
    	this.txt_nlock.MaxLength = 32767;
    	this.txt_nlock.MouseState = MaterialSkin.MouseState.HOVER;
    	this.txt_nlock.Name = "txt_nlock";
    	this.txt_nlock.PasswordChar = '\0';
    	this.txt_nlock.SelectedText = "";
    	this.txt_nlock.SelectionLength = 0;
    	this.txt_nlock.SelectionStart = 0;
    	this.txt_nlock.Size = new System.Drawing.Size(58, 23);
    	this.txt_nlock.TabIndex = 13;
    	this.txt_nlock.TabStop = false;
    	this.txt_nlock.UseSystemPasswordChar = false;
    	this.txt_nlock.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Text_Changed);
    	// 
    	// txt_pname
    	// 
    	this.txt_pname.Depth = 0;
    	this.txt_pname.Hint = "Nombre";
    	this.txt_pname.Location = new System.Drawing.Point(411, 50);
    	this.txt_pname.MaxLength = 32767;
    	this.txt_pname.MouseState = MaterialSkin.MouseState.HOVER;
    	this.txt_pname.Name = "txt_pname";
    	this.txt_pname.PasswordChar = '\0';
    	this.txt_pname.SelectedText = "";
    	this.txt_pname.SelectionLength = 0;
    	this.txt_pname.SelectionStart = 0;
    	this.txt_pname.Size = new System.Drawing.Size(101, 23);
    	this.txt_pname.TabIndex = 14;
    	this.txt_pname.TabStop = false;
    	this.txt_pname.UseSystemPasswordChar = false;
    	this.txt_pname.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Text_Changed);
    	// 
    	// txt_psurname
    	// 
    	this.txt_psurname.Depth = 0;
    	this.txt_psurname.Hint = "Apellido";
    	this.txt_psurname.Location = new System.Drawing.Point(518, 50);
    	this.txt_psurname.MaxLength = 32767;
    	this.txt_psurname.MouseState = MaterialSkin.MouseState.HOVER;
    	this.txt_psurname.Name = "txt_psurname";
    	this.txt_psurname.PasswordChar = '\0';
    	this.txt_psurname.SelectedText = "";
    	this.txt_psurname.SelectionLength = 0;
    	this.txt_psurname.SelectionStart = 0;
    	this.txt_psurname.Size = new System.Drawing.Size(99, 23);
    	this.txt_psurname.TabIndex = 15;
    	this.txt_psurname.TabStop = false;
    	this.txt_psurname.UseSystemPasswordChar = false;
    	this.txt_psurname.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Text_Changed);
    	// 
    	// txt_proc
    	// 
    	this.txt_proc.Depth = 0;
    	this.txt_proc.Hint = "Procedencia";
    	this.txt_proc.Location = new System.Drawing.Point(623, 50);
    	this.txt_proc.MaxLength = 32767;
    	this.txt_proc.MouseState = MaterialSkin.MouseState.HOVER;
    	this.txt_proc.Name = "txt_proc";
    	this.txt_proc.PasswordChar = '\0';
    	this.txt_proc.SelectedText = "";
    	this.txt_proc.SelectionLength = 0;
    	this.txt_proc.SelectionStart = 0;
    	this.txt_proc.Size = new System.Drawing.Size(100, 23);
    	this.txt_proc.TabIndex = 16;
    	this.txt_proc.TabStop = false;
    	this.txt_proc.UseSystemPasswordChar = false;
    	this.txt_proc.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Text_Changed);
    	// 
    	// FormGuests
    	// 
    	this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
    	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
    	this.BackColor = System.Drawing.Color.White;
    	this.ClientSize = new System.Drawing.Size(741, 518);
    	this.Controls.Add(this.txt_proc);
    	this.Controls.Add(this.txt_psurname);
    	this.Controls.Add(this.txt_pname);
    	this.Controls.Add(this.txt_nlock);
    	this.Controls.Add(this.txt_nhab);
    	this.Controls.Add(this.txt_hsurname);
    	this.Controls.Add(this.txt_hname);
    	this.Controls.Add(this.txt_ficha);
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
    	this.Load += new System.EventHandler(this.OnLoad);
    	this.ResumeLayout(false);
    }
    private MaterialSkin.Controls.MaterialSingleLineTextField txt_proc;
    private MaterialSkin.Controls.MaterialSingleLineTextField txt_psurname;
    private MaterialSkin.Controls.MaterialSingleLineTextField txt_pname;
    private MaterialSkin.Controls.MaterialSingleLineTextField txt_nlock;
    private MaterialSkin.Controls.MaterialSingleLineTextField txt_nhab;
    private MaterialSkin.Controls.MaterialSingleLineTextField txt_hsurname;
    private MaterialSkin.Controls.MaterialSingleLineTextField txt_hname;
    private MaterialSkin.Controls.MaterialSingleLineTextField txt_ficha;
    private MaterialSkin.Controls.MaterialLabel materialLabel8;
    private MaterialSkin.Controls.MaterialLabel materialLabel6;
    private MaterialSkin.Controls.MaterialLabel materialLabel5;
    private MaterialSkin.Controls.MaterialLabel materialLabel4;
    private MaterialSkin.Controls.MaterialLabel materialLabel2;
    private MaterialSkin.Controls.MaterialLabel materialLabel1;
    private System.Windows.Forms.Panel panel1;
  }
}
