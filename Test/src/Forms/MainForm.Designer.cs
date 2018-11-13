/*
 * Created by SharpDevelop.
 * User: Alumnos
 * Date: 09/08/2018
 * Time: 14:23
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Program.Forms {
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
    	this.components = new System.ComponentModel.Container();
    	this.btn_left_guests = new MaterialSkin.Controls.MaterialFlatButton();
    	this.panel2 = new System.Windows.Forms.Panel();
    	this.btn_left_history = new MaterialSkin.Controls.MaterialFlatButton();
    	this.btn_left_stats = new MaterialSkin.Controls.MaterialFlatButton();
    	this.btn_left_admin = new MaterialSkin.Controls.MaterialFlatButton();
    	this.btn_left_security = new MaterialSkin.Controls.MaterialFlatButton();
    	this.materialFlatButton2 = new MaterialSkin.Controls.MaterialFlatButton();
    	this.panel3 = new System.Windows.Forms.Panel();
    	this.btn_addG = new MaterialSkin.Controls.MaterialFlatButton();
    	this.materialRaisedButtonws1 = new MaterialSkin.Controls.MaterialRaisedButtonws();
    	this.timer1 = new System.Windows.Forms.Timer(this.components);
    	this.btn_refresh = new MaterialSkin.Controls.MaterialFlatButton();
    	this.panel2.SuspendLayout();
    	this.SuspendLayout();
    	// 
    	// btn_left_guests
    	// 
    	this.btn_left_guests.AutoSize = true;
    	this.btn_left_guests.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
    	this.btn_left_guests.Depth = 0;
    	this.btn_left_guests.ForeColor = System.Drawing.SystemColors.ControlText;
    	this.btn_left_guests.Icon = global::SP.Resources.Images.account_multiple;
    	this.btn_left_guests.Location = new System.Drawing.Point(3, 42);
    	this.btn_left_guests.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
    	this.btn_left_guests.MouseState = MaterialSkin.MouseState.HOVER;
    	this.btn_left_guests.Name = "btn_left_guests";
    	this.btn_left_guests.Primary = true;
    	this.btn_left_guests.selected = true;
    	this.btn_left_guests.Size = new System.Drawing.Size(142, 36);
    	this.btn_left_guests.TabIndex = 8;
    	this.btn_left_guests.Text = "Huespedes        ";
    	this.btn_left_guests.UseVisualStyleBackColor = true;
    	this.btn_left_guests.Click += new System.EventHandler(this.LeftBarClick);
    	// 
    	// panel2
    	// 
    	this.panel2.Controls.Add(this.btn_left_history);
    	this.panel2.Controls.Add(this.btn_left_stats);
    	this.panel2.Controls.Add(this.btn_left_admin);
    	this.panel2.Controls.Add(this.btn_left_security);
    	this.panel2.Controls.Add(this.materialFlatButton2);
    	this.panel2.Controls.Add(this.btn_left_guests);
    	this.panel2.Location = new System.Drawing.Point(0, 64);
    	this.panel2.Name = "panel2";
    	this.panel2.Size = new System.Drawing.Size(42, 537);
    	this.panel2.TabIndex = 9;
    	this.panel2.Tag = "w = 42 -> 185";
    	// 
    	// btn_left_history
    	// 
    	this.btn_left_history.AutoSize = true;
    	this.btn_left_history.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
    	this.btn_left_history.Depth = 0;
    	this.btn_left_history.ForeColor = System.Drawing.SystemColors.ControlText;
    	this.btn_left_history.Icon = global::SP.Resources.Images.history;
    	this.btn_left_history.Location = new System.Drawing.Point(3, 150);
    	this.btn_left_history.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
    	this.btn_left_history.MouseState = MaterialSkin.MouseState.HOVER;
    	this.btn_left_history.Name = "btn_left_history";
    	this.btn_left_history.Primary = true;
    	this.btn_left_history.selected = false;
    	this.btn_left_history.Size = new System.Drawing.Size(142, 36);
    	this.btn_left_history.TabIndex = 13;
    	this.btn_left_history.Text = "Historial           ";
    	this.btn_left_history.UseVisualStyleBackColor = true;
    	this.btn_left_history.Click += new System.EventHandler(this.LeftBarClick);
    	// 
    	// btn_left_stats
    	// 
    	this.btn_left_stats.AutoSize = true;
    	this.btn_left_stats.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
    	this.btn_left_stats.Depth = 0;
    	this.btn_left_stats.ForeColor = System.Drawing.SystemColors.ControlText;
    	this.btn_left_stats.Icon = global::SP.Resources.Images.icons8_bar_chart_24;
    	this.btn_left_stats.Location = new System.Drawing.Point(3, 114);
    	this.btn_left_stats.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
    	this.btn_left_stats.MouseState = MaterialSkin.MouseState.HOVER;
    	this.btn_left_stats.Name = "btn_left_stats";
    	this.btn_left_stats.Primary = true;
    	this.btn_left_stats.selected = false;
    	this.btn_left_stats.Size = new System.Drawing.Size(142, 36);
    	this.btn_left_stats.TabIndex = 12;
    	this.btn_left_stats.Text = "Estadísticas";
    	this.btn_left_stats.UseVisualStyleBackColor = true;
    	this.btn_left_stats.Click += new System.EventHandler(this.LeftBarClick);
    	// 
    	// btn_left_admin
    	// 
    	this.btn_left_admin.AutoSize = true;
    	this.btn_left_admin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
    	this.btn_left_admin.Depth = 0;
    	this.btn_left_admin.ForeColor = System.Drawing.SystemColors.ControlText;
    	this.btn_left_admin.Icon = global::SP.Resources.Images.key;
    	this.btn_left_admin.Location = new System.Drawing.Point(3, 186);
    	this.btn_left_admin.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
    	this.btn_left_admin.MouseState = MaterialSkin.MouseState.HOVER;
    	this.btn_left_admin.Name = "btn_left_admin";
    	this.btn_left_admin.Primary = true;
    	this.btn_left_admin.selected = false;
    	this.btn_left_admin.Size = new System.Drawing.Size(142, 36);
    	this.btn_left_admin.TabIndex = 11;
    	this.btn_left_admin.Text = "Administrar  ";
    	this.btn_left_admin.UseVisualStyleBackColor = true;
    	this.btn_left_admin.Visible = false;
    	this.btn_left_admin.Click += new System.EventHandler(this.LeftBarClick);
    	// 
    	// btn_left_security
    	// 
    	this.btn_left_security.AutoSize = true;
    	this.btn_left_security.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
    	this.btn_left_security.Depth = 0;
    	this.btn_left_security.ForeColor = System.Drawing.SystemColors.ControlText;
    	this.btn_left_security.Icon = global::SP.Resources.Images._lock;
    	this.btn_left_security.Location = new System.Drawing.Point(3, 78);
    	this.btn_left_security.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
    	this.btn_left_security.MouseState = MaterialSkin.MouseState.HOVER;
    	this.btn_left_security.Name = "btn_left_security";
    	this.btn_left_security.Primary = true;
    	this.btn_left_security.selected = false;
    	this.btn_left_security.Size = new System.Drawing.Size(142, 36);
    	this.btn_left_security.TabIndex = 10;
    	this.btn_left_security.Text = "Seguridad          ";
    	this.btn_left_security.UseVisualStyleBackColor = true;
    	this.btn_left_security.Click += new System.EventHandler(this.LeftBarClick);
    	// 
    	// materialFlatButton2
    	// 
    	this.materialFlatButton2.AutoSize = true;
    	this.materialFlatButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
    	this.materialFlatButton2.Depth = 0;
    	this.materialFlatButton2.Icon = global::SP.Resources.Images.menu_button_1_;
    	this.materialFlatButton2.Location = new System.Drawing.Point(1, 6);
    	this.materialFlatButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
    	this.materialFlatButton2.MouseState = MaterialSkin.MouseState.HOVER;
    	this.materialFlatButton2.Name = "materialFlatButton2";
    	this.materialFlatButton2.Primary = false;
    	this.materialFlatButton2.selected = false;
    	this.materialFlatButton2.Size = new System.Drawing.Size(44, 36);
    	this.materialFlatButton2.TabIndex = 9;
    	this.materialFlatButton2.UseVisualStyleBackColor = true;
    	this.materialFlatButton2.Click += new System.EventHandler(this.MaterialFlatButton2Click);
    	// 
    	// panel3
    	// 
    	this.panel3.Location = new System.Drawing.Point(47, 70);
    	this.panel3.Name = "panel3";
    	this.panel3.Size = new System.Drawing.Size(741, 518);
    	this.panel3.TabIndex = 10;
    	// 
    	// btn_addG
    	// 
    	this.btn_addG.AutoSize = true;
    	this.btn_addG.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
    	this.btn_addG.Depth = 0;
    	this.btn_addG.Icon = global::SP.Resources.Images.account_plus;
    	this.btn_addG.Location = new System.Drawing.Point(704, 28);
    	this.btn_addG.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
    	this.btn_addG.MouseState = MaterialSkin.MouseState.HOVER;
    	this.btn_addG.Name = "btn_addG";
    	this.btn_addG.Primary = false;
    	this.btn_addG.selected = false;
    	this.btn_addG.Size = new System.Drawing.Size(44, 36);
    	this.btn_addG.TabIndex = 12;
    	this.btn_addG.Tag = "64/28";
    	this.btn_addG.UseVisualStyleBackColor = true;
    	this.btn_addG.Click += new System.EventHandler(this.Btn_addGClick);
    	// 
    	// materialRaisedButtonws1
    	// 
    	this.materialRaisedButtonws1.AutoSize = true;
    	this.materialRaisedButtonws1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
    	this.materialRaisedButtonws1.Depth = 0;
    	this.materialRaisedButtonws1.Icon = global::SP.Resources.Images.account_circle;
    	this.materialRaisedButtonws1.Location = new System.Drawing.Point(744, 28);
    	this.materialRaisedButtonws1.MouseState = MaterialSkin.MouseState.HOVER;
    	this.materialRaisedButtonws1.Name = "materialRaisedButtonws1";
    	this.materialRaisedButtonws1.Primary = true;
    	this.materialRaisedButtonws1.Size = new System.Drawing.Size(44, 36);
    	this.materialRaisedButtonws1.TabIndex = 13;
    	this.materialRaisedButtonws1.UseVisualStyleBackColor = true;
    	// 
    	// timer1
    	// 
    	this.timer1.Enabled = true;
    	this.timer1.Interval = 5;
    	this.timer1.Tick += new System.EventHandler(this.Timer1Tick);
    	// 
    	// btn_refresh
    	// 
    	this.btn_refresh.AutoSize = true;
    	this.btn_refresh.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
    	this.btn_refresh.Depth = 0;
    	this.btn_refresh.Icon = null;
    	this.btn_refresh.Location = new System.Drawing.Point(625, 28);
    	this.btn_refresh.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
    	this.btn_refresh.MouseState = MaterialSkin.MouseState.HOVER;
    	this.btn_refresh.Name = "btn_refresh";
    	this.btn_refresh.Primary = false;
    	this.btn_refresh.selected = false;
    	this.btn_refresh.Size = new System.Drawing.Size(79, 36);
    	this.btn_refresh.TabIndex = 14;
    	this.btn_refresh.Text = "refresh";
    	this.btn_refresh.UseVisualStyleBackColor = true;
    	this.btn_refresh.Click += new System.EventHandler(this.Btn_refreshClick);
    	// 
    	// MainForm
    	// 
    	this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
    	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
    	this.ClientSize = new System.Drawing.Size(800, 600);
    	this.Controls.Add(this.materialRaisedButtonws1);
    	this.Controls.Add(this.panel2);
    	this.Controls.Add(this.panel3);
    	this.Controls.Add(this.btn_addG);
    	this.Controls.Add(this.btn_refresh);
    	this.Location = new System.Drawing.Point(600, 500);
    	this.Name = "MainForm";
    	this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
    	this.Text = "Main Screen";
    	this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainFormFormClosing);
    	this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainFormFormClosed);
    	this.Load += new System.EventHandler(this.Form_Load);
    	this.panel2.ResumeLayout(false);
    	this.panel2.PerformLayout();
    	this.ResumeLayout(false);
    	this.PerformLayout();
    }
    private MaterialSkin.Controls.MaterialFlatButton btn_refresh;
    private MaterialSkin.Controls.MaterialFlatButton btn_left_history;
    private MaterialSkin.Controls.MaterialFlatButton btn_left_stats;
    private MaterialSkin.Controls.MaterialFlatButton btn_left_admin;
    private System.Windows.Forms.Timer timer1;
    private MaterialSkin.Controls.MaterialFlatButton btn_left_security;
    private MaterialSkin.Controls.MaterialRaisedButtonws materialRaisedButtonws1;
    private MaterialSkin.Controls.MaterialFlatButton btn_addG;
    public System.Windows.Forms.Panel panel3;
    private MaterialSkin.Controls.MaterialFlatButton materialFlatButton2;
    private System.Windows.Forms.Panel panel2;
    private MaterialSkin.Controls.MaterialFlatButton btn_left_guests;
    
  }
}
