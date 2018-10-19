/*
 * Created By 42476232
 * On 24/08/2018
 * Time: 09:59 a.m.
 */
namespace Program.Forms
{
  partial class Login
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
      this.timer1 = new System.Windows.Forms.Timer(this.components);
      this.materialToolStripMenuItem1 = new MaterialSkin.Controls.MaterialToolStripMenuItem();
      this.materialToolStripMenuItem2 = new MaterialSkin.Controls.MaterialToolStripMenuItem();
      this.lbl_err = new MaterialSkin.Controls.MaterialLabel();
      this.panel1 = new System.Windows.Forms.Panel();
      this.btn_login = new MaterialSkin.Controls.MaterialRaisedButton();
      this.lbl_pass = new MaterialSkin.Controls.MaterialLabel();
      this.txt_pass = new MaterialSkin.Controls.MaterialSingleLineTextField();
      this.lbl_uname = new MaterialSkin.Controls.MaterialLabel();
      this.txt_uname = new MaterialSkin.Controls.MaterialSingleLineTextField();
      this.panel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // timer1
      // 
      this.timer1.Interval = 650;
      this.timer1.Tick += new System.EventHandler(this.Timer1Tick);
      // 
      // materialToolStripMenuItem1
      // 
      this.materialToolStripMenuItem1.AutoSize = false;
      this.materialToolStripMenuItem1.Name = "materialToolStripMenuItem1";
      this.materialToolStripMenuItem1.Size = new System.Drawing.Size(120, 30);
      this.materialToolStripMenuItem1.Text = "materialToolStripMenuItem1";
      // 
      // materialToolStripMenuItem2
      // 
      this.materialToolStripMenuItem2.AutoSize = false;
      this.materialToolStripMenuItem2.Name = "materialToolStripMenuItem2";
      this.materialToolStripMenuItem2.Size = new System.Drawing.Size(120, 30);
      this.materialToolStripMenuItem2.Text = "materialToolStripMenuItem2";
      // 
      // lbl_err
      // 
      this.lbl_err.BackColor = System.Drawing.Color.Transparent;
      this.lbl_err.Depth = 0;
      this.lbl_err.Font = new System.Drawing.Font("Roboto", 11F);
      this.lbl_err.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.lbl_err.Location = new System.Drawing.Point(53, 300);
      this.lbl_err.MouseState = MaterialSkin.MouseState.HOVER;
      this.lbl_err.Name = "lbl_err";
      this.lbl_err.Size = new System.Drawing.Size(192, 39);
      this.lbl_err.TabIndex = 5;
      this.lbl_err.Tag = "284/349";
      this.lbl_err.Text = "El usuario o contraseña ingresado es incorrecto";
      this.lbl_err.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.lbl_err);
      this.panel1.Controls.Add(this.btn_login);
      this.panel1.Controls.Add(this.lbl_pass);
      this.panel1.Controls.Add(this.txt_pass);
      this.panel1.Controls.Add(this.lbl_uname);
      this.panel1.Controls.Add(this.txt_uname);
      this.panel1.Location = new System.Drawing.Point(1, 63);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(298, 348);
      this.panel1.TabIndex = 6;
      // 
      // btn_login
      // 
      this.btn_login.AutoSize = true;
      this.btn_login.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      this.btn_login.Depth = 0;
      this.btn_login.Icon = null;
      this.btn_login.Location = new System.Drawing.Point(117, 175);
      this.btn_login.MouseState = MaterialSkin.MouseState.HOVER;
      this.btn_login.Name = "btn_login";
      this.btn_login.Primary = true;
      this.btn_login.Size = new System.Drawing.Size(61, 36);
      this.btn_login.TabIndex = 9;
      this.btn_login.Text = "LOGIN";
      this.btn_login.UseVisualStyleBackColor = true;
      this.btn_login.Click += new System.EventHandler(this.LoginClick);
      // 
      // lbl_pass
      // 
      this.lbl_pass.BackColor = System.Drawing.Color.Transparent;
      this.lbl_pass.Depth = 0;
      this.lbl_pass.Font = new System.Drawing.Font("Roboto", 11F);
      this.lbl_pass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.lbl_pass.Location = new System.Drawing.Point(88, 92);
      this.lbl_pass.MouseState = MaterialSkin.MouseState.HOVER;
      this.lbl_pass.Name = "lbl_pass";
      this.lbl_pass.Size = new System.Drawing.Size(100, 23);
      this.lbl_pass.TabIndex = 8;
      this.lbl_pass.Text = "Contraseña";
      // 
      // txt_pass
      // 
      this.txt_pass.BackColor = System.Drawing.SystemColors.ButtonFace;
      this.txt_pass.Depth = 0;
      this.txt_pass.Hint = "Contraseña";
      this.txt_pass.Location = new System.Drawing.Point(89, 121);
      this.txt_pass.MaxLength = 32767;
      this.txt_pass.MouseState = MaterialSkin.MouseState.HOVER;
      this.txt_pass.Name = "txt_pass";
      this.txt_pass.PasswordChar = '\0';
      this.txt_pass.SelectedText = "";
      this.txt_pass.SelectionLength = 0;
      this.txt_pass.SelectionStart = 0;
      this.txt_pass.Size = new System.Drawing.Size(122, 23);
      this.txt_pass.TabIndex = 7;
      this.txt_pass.TabStop = false;
      this.txt_pass.UseSystemPasswordChar = true;
      this.txt_pass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_KeyPress);
      // 
      // lbl_uname
      // 
      this.lbl_uname.BackColor = System.Drawing.Color.Transparent;
      this.lbl_uname.Depth = 0;
      this.lbl_uname.Font = new System.Drawing.Font("Roboto", 11F);
      this.lbl_uname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.lbl_uname.Location = new System.Drawing.Point(87, 25);
      this.lbl_uname.MouseState = MaterialSkin.MouseState.HOVER;
      this.lbl_uname.Name = "lbl_uname";
      this.lbl_uname.Size = new System.Drawing.Size(100, 23);
      this.lbl_uname.TabIndex = 6;
      this.lbl_uname.Text = "Usuario";
      // 
      // txt_uname
      // 
      this.txt_uname.BackColor = System.Drawing.SystemColors.ButtonFace;
      this.txt_uname.Cursor = System.Windows.Forms.Cursors.Hand;
      this.txt_uname.Depth = 0;
      this.txt_uname.Hint = "Usuario";
      this.txt_uname.Location = new System.Drawing.Point(88, 54);
      this.txt_uname.MaxLength = 32767;
      this.txt_uname.MouseState = MaterialSkin.MouseState.HOVER;
      this.txt_uname.Name = "txt_uname";
      this.txt_uname.PasswordChar = '\0';
      this.txt_uname.SelectedText = "";
      this.txt_uname.SelectionLength = 0;
      this.txt_uname.SelectionStart = 0;
      this.txt_uname.Size = new System.Drawing.Size(122, 23);
      this.txt_uname.TabIndex = 5;
      this.txt_uname.TabStop = false;
      this.txt_uname.UseSystemPasswordChar = false;
      this.txt_uname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_KeyPress);
      // 
      // Login
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(300, 300);
      this.Controls.Add(this.panel1);
      this.Icon = global::SP.Resources.Images.home_account;
      this.Name = "Login";
      this.Tag = "300/348";
      this.Text = "Login";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoginFormClosing);
      this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LoginFormClosed);
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.ResumeLayout(false);
    }
    private System.Windows.Forms.Panel panel1;
    private MaterialSkin.Controls.MaterialLabel lbl_err;
    private MaterialSkin.Controls.MaterialToolStripMenuItem materialToolStripMenuItem2;
    private MaterialSkin.Controls.MaterialToolStripMenuItem materialToolStripMenuItem1;
    private System.Windows.Forms.Timer timer1;
    private MaterialSkin.Controls.MaterialRaisedButton btn_login;
    private MaterialSkin.Controls.MaterialSingleLineTextField txt_pass;
    private MaterialSkin.Controls.MaterialLabel lbl_pass;
    private MaterialSkin.Controls.MaterialLabel lbl_uname;
    private MaterialSkin.Controls.MaterialSingleLineTextField txt_uname;
  }
}
