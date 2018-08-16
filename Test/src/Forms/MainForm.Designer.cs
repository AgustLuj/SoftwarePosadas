/*
 * Created by SharpDevelop.
 * User: Alumnos
 * Date: 09/08/2018
 * Time: 14:23
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Program {
  partial class MainForm {
    /// <summary>
    /// Designer variable used to keep track of non-visual components.
    /// </summary>
    private System.ComponentModel.IContainer components = null;
		
    /// <summary>
    /// Disposes resources used by the form.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
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
    private void InitializeComponent() {
      this.label1 = new MaterialSkin.Controls.MaterialLabel();
      this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
      this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
      this.uname = new MaterialSkin.Controls.MaterialSingleLineTextField();
      this.pass = new MaterialSkin.Controls.MaterialSingleLineTextField();
      this.login = new MaterialSkin.Controls.MaterialRaisedButton();
      this.panel1 = new System.Windows.Forms.Panel();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.BackColor = System.Drawing.Color.Transparent;
      this.label1.Depth = 0;
      this.label1.Font = new System.Drawing.Font("Roboto", 11F);
      this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.label1.Location = new System.Drawing.Point(84, 75);
      this.label1.MouseState = MaterialSkin.MouseState.HOVER;
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(107, 204);
      this.label1.TabIndex = 0;
      this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // materialLabel1
      // 
      this.materialLabel1.BackColor = System.Drawing.Color.Transparent;
      this.materialLabel1.Depth = 0;
      this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
      this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.materialLabel1.Location = new System.Drawing.Point(12, 75);
      this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
      this.materialLabel1.Name = "materialLabel1";
      this.materialLabel1.Size = new System.Drawing.Size(100, 23);
      this.materialLabel1.TabIndex = 1;
      this.materialLabel1.Text = "Username:";
      // 
      // materialLabel2
      // 
      this.materialLabel2.BackColor = System.Drawing.Color.Transparent;
      this.materialLabel2.Depth = 0;
      this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
      this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.materialLabel2.Location = new System.Drawing.Point(12, 104);
      this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
      this.materialLabel2.Name = "materialLabel2";
      this.materialLabel2.Size = new System.Drawing.Size(100, 23);
      this.materialLabel2.TabIndex = 2;
      this.materialLabel2.Text = "Password:";
      // 
      // uname
      // 
      this.uname.Depth = 0;
      this.uname.Hint = "";
      this.uname.Location = new System.Drawing.Point(116, 75);
      this.uname.MaxLength = 32767;
      this.uname.MouseState = MaterialSkin.MouseState.HOVER;
      this.uname.Name = "uname";
      this.uname.PasswordChar = '\0';
      this.uname.SelectedText = "";
      this.uname.SelectionLength = 0;
      this.uname.SelectionStart = 0;
      this.uname.Size = new System.Drawing.Size(75, 23);
      this.uname.TabIndex = 3;
      this.uname.TabStop = false;
      this.uname.UseSystemPasswordChar = false;
      this.uname.KeyUp += new System.Windows.Forms.KeyEventHandler(this.PassKeyUp);
      // 
      // pass
      // 
      this.pass.Depth = 0;
      this.pass.Hint = "";
      this.pass.Location = new System.Drawing.Point(116, 104);
      this.pass.MaxLength = 32767;
      this.pass.MouseState = MaterialSkin.MouseState.HOVER;
      this.pass.Name = "pass";
      this.pass.PasswordChar = '\0';
      this.pass.SelectedText = "";
      this.pass.SelectionLength = 0;
      this.pass.SelectionStart = 0;
      this.pass.Size = new System.Drawing.Size(75, 23);
      this.pass.TabIndex = 4;
      this.pass.TabStop = false;
      this.pass.UseSystemPasswordChar = true;
      this.pass.KeyUp += new System.Windows.Forms.KeyEventHandler(this.PassKeyUp);
      // 
      // login
      // 
      this.login.AutoSize = true;
      this.login.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      this.login.Depth = 0;
      this.login.Icon = null;
      this.login.Location = new System.Drawing.Point(116, 240);
      this.login.MouseState = MaterialSkin.MouseState.HOVER;
      this.login.Name = "login";
      this.login.Primary = true;
      this.login.Size = new System.Drawing.Size(61, 36);
      this.login.TabIndex = 6;
      this.login.Text = "LogIn";
      this.login.UseVisualStyleBackColor = true;
      this.login.Click += new System.EventHandler(this.OnClick);
      // 
      // panel1
      // 
      this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
      this.panel1.Location = new System.Drawing.Point(12, 133);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(260, 100);
      this.panel1.TabIndex = 7;
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(284, 288);
      this.Controls.Add(this.login);
      this.Controls.Add(this.pass);
      this.Controls.Add(this.uname);
      this.Controls.Add(this.materialLabel2);
      this.Controls.Add(this.materialLabel1);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.panel1);
      this.Name = "MainForm";
      this.Text = "Login";
      this.Load += new System.EventHandler(this.Form_Load);
      this.ResumeLayout(false);
      this.PerformLayout();
    }
    private System.Windows.Forms.Panel panel1;
    private MaterialSkin.Controls.MaterialRaisedButton login;
    private MaterialSkin.Controls.MaterialSingleLineTextField pass;
    private MaterialSkin.Controls.MaterialSingleLineTextField uname;
    private MaterialSkin.Controls.MaterialLabel materialLabel2;
    private MaterialSkin.Controls.MaterialLabel materialLabel1;
    private MaterialSkin.Controls.MaterialLabel label1;
    
  }
}
