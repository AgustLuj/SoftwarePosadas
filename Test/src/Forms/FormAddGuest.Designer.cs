/*
 * Created by SharpDevelop.
 * User: lujan
 * Date: 21/8/2018
 * Time: 10:40
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Program.Forms
{
	partial class FormAddGuest
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
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
			this.materialSingleLineTextField1 = new MaterialSkin.Controls.MaterialSingleLineTextField();
			this.materialSingleLineTextField2 = new MaterialSkin.Controls.MaterialSingleLineTextField();
			this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
			this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
			this.materialSingleLineTextField3 = new MaterialSkin.Controls.MaterialSingleLineTextField();
			this.materialSingleLineTextField4 = new MaterialSkin.Controls.MaterialSingleLineTextField();
			this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
			this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
			this.materialCheckBox1 = new MaterialSkin.Controls.MaterialCheckBox();
			this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
			this.materialSingleLineTextField5 = new MaterialSkin.Controls.MaterialSingleLineTextField();
			this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
			this.materialSingleLineTextField6 = new MaterialSkin.Controls.MaterialSingleLineTextField();
			this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
			this.materialSingleLineTextField7 = new MaterialSkin.Controls.MaterialSingleLineTextField();
			this.materialCheckBox2 = new MaterialSkin.Controls.MaterialCheckBox();
			this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
			this.materialSingleLineTextField8 = new MaterialSkin.Controls.MaterialSingleLineTextField();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(544, 27);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(170, 170);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// materialLabel1
			// 
			this.materialLabel1.Depth = 0;
			this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
			this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.materialLabel1.Location = new System.Drawing.Point(25, 27);
			this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialLabel1.Name = "materialLabel1";
			this.materialLabel1.Size = new System.Drawing.Size(100, 23);
			this.materialLabel1.TabIndex = 1;
			this.materialLabel1.Text = "Nombre";
			// 
			// materialSingleLineTextField1
			// 
			this.materialSingleLineTextField1.BackColor = System.Drawing.SystemColors.Control;
			this.materialSingleLineTextField1.Depth = 0;
			this.materialSingleLineTextField1.Hint = "Ingrese el nombre";
			this.materialSingleLineTextField1.Location = new System.Drawing.Point(25, 53);
			this.materialSingleLineTextField1.MaxLength = 32767;
			this.materialSingleLineTextField1.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialSingleLineTextField1.Name = "materialSingleLineTextField1";
			this.materialSingleLineTextField1.PasswordChar = '\0';
			this.materialSingleLineTextField1.SelectedText = "";
			this.materialSingleLineTextField1.SelectionLength = 0;
			this.materialSingleLineTextField1.SelectionStart = 0;
			this.materialSingleLineTextField1.Size = new System.Drawing.Size(198, 23);
			this.materialSingleLineTextField1.TabIndex = 2;
			this.materialSingleLineTextField1.TabStop = false;
			this.materialSingleLineTextField1.UseSystemPasswordChar = false;
			// 
			// materialSingleLineTextField2
			// 
			this.materialSingleLineTextField2.BackColor = System.Drawing.SystemColors.Control;
			this.materialSingleLineTextField2.Depth = 0;
			this.materialSingleLineTextField2.Hint = "Ingrese el apellido";
			this.materialSingleLineTextField2.Location = new System.Drawing.Point(25, 126);
			this.materialSingleLineTextField2.MaxLength = 32767;
			this.materialSingleLineTextField2.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialSingleLineTextField2.Name = "materialSingleLineTextField2";
			this.materialSingleLineTextField2.PasswordChar = '\0';
			this.materialSingleLineTextField2.SelectedText = "";
			this.materialSingleLineTextField2.SelectionLength = 0;
			this.materialSingleLineTextField2.SelectionStart = 0;
			this.materialSingleLineTextField2.Size = new System.Drawing.Size(198, 23);
			this.materialSingleLineTextField2.TabIndex = 3;
			this.materialSingleLineTextField2.TabStop = false;
			this.materialSingleLineTextField2.UseSystemPasswordChar = false;
			// 
			// materialLabel2
			// 
			this.materialLabel2.Depth = 0;
			this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
			this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.materialLabel2.Location = new System.Drawing.Point(25, 98);
			this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialLabel2.Name = "materialLabel2";
			this.materialLabel2.Size = new System.Drawing.Size(100, 23);
			this.materialLabel2.TabIndex = 4;
			this.materialLabel2.Text = "Apellido";
			// 
			// materialLabel3
			// 
			this.materialLabel3.Depth = 0;
			this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
			this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.materialLabel3.Location = new System.Drawing.Point(281, 98);
			this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialLabel3.Name = "materialLabel3";
			this.materialLabel3.Size = new System.Drawing.Size(178, 23);
			this.materialLabel3.TabIndex = 8;
			this.materialLabel3.Text = "Apellido del Paciente";
			// 
			// materialSingleLineTextField3
			// 
			this.materialSingleLineTextField3.BackColor = System.Drawing.SystemColors.Control;
			this.materialSingleLineTextField3.Depth = 0;
			this.materialSingleLineTextField3.Hint = "Ingrese el apellido";
			this.materialSingleLineTextField3.Location = new System.Drawing.Point(284, 126);
			this.materialSingleLineTextField3.MaxLength = 32767;
			this.materialSingleLineTextField3.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialSingleLineTextField3.Name = "materialSingleLineTextField3";
			this.materialSingleLineTextField3.PasswordChar = '\0';
			this.materialSingleLineTextField3.SelectedText = "";
			this.materialSingleLineTextField3.SelectionLength = 0;
			this.materialSingleLineTextField3.SelectionStart = 0;
			this.materialSingleLineTextField3.Size = new System.Drawing.Size(198, 23);
			this.materialSingleLineTextField3.TabIndex = 7;
			this.materialSingleLineTextField3.TabStop = false;
			this.materialSingleLineTextField3.UseSystemPasswordChar = false;
			// 
			// materialSingleLineTextField4
			// 
			this.materialSingleLineTextField4.BackColor = System.Drawing.SystemColors.Control;
			this.materialSingleLineTextField4.Depth = 0;
			this.materialSingleLineTextField4.Hint = "Ingrese el nombre";
			this.materialSingleLineTextField4.Location = new System.Drawing.Point(284, 53);
			this.materialSingleLineTextField4.MaxLength = 32767;
			this.materialSingleLineTextField4.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialSingleLineTextField4.Name = "materialSingleLineTextField4";
			this.materialSingleLineTextField4.PasswordChar = '\0';
			this.materialSingleLineTextField4.SelectedText = "";
			this.materialSingleLineTextField4.SelectionLength = 0;
			this.materialSingleLineTextField4.SelectionStart = 0;
			this.materialSingleLineTextField4.Size = new System.Drawing.Size(198, 23);
			this.materialSingleLineTextField4.TabIndex = 6;
			this.materialSingleLineTextField4.TabStop = false;
			this.materialSingleLineTextField4.UseSystemPasswordChar = false;
			// 
			// materialLabel4
			// 
			this.materialLabel4.Depth = 0;
			this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
			this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.materialLabel4.Location = new System.Drawing.Point(281, 27);
			this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialLabel4.Name = "materialLabel4";
			this.materialLabel4.Size = new System.Drawing.Size(178, 23);
			this.materialLabel4.TabIndex = 5;
			this.materialLabel4.Text = "Nombre del Paciente";
			// 
			// materialFlatButton1
			// 
			this.materialFlatButton1.AutoSize = true;
			this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.materialFlatButton1.Depth = 0;
			this.materialFlatButton1.Icon = null;
			this.materialFlatButton1.Location = new System.Drawing.Point(615, 444);
			this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
			this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialFlatButton1.Name = "materialFlatButton1";
			this.materialFlatButton1.Primary = false;
			this.materialFlatButton1.Size = new System.Drawing.Size(73, 36);
			this.materialFlatButton1.TabIndex = 9;
			this.materialFlatButton1.Text = "cerrar";
			this.materialFlatButton1.UseVisualStyleBackColor = true;
			this.materialFlatButton1.Click += new System.EventHandler(this.MaterialFlatButton1Click);
			// 
			// materialCheckBox1
			// 
			this.materialCheckBox1.Depth = 0;
			this.materialCheckBox1.Font = new System.Drawing.Font("Roboto", 10F);
			this.materialCheckBox1.Location = new System.Drawing.Point(282, 173);
			this.materialCheckBox1.Margin = new System.Windows.Forms.Padding(0);
			this.materialCheckBox1.MouseLocation = new System.Drawing.Point(-1, -1);
			this.materialCheckBox1.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialCheckBox1.Name = "materialCheckBox1";
			this.materialCheckBox1.Ripple = true;
			this.materialCheckBox1.Size = new System.Drawing.Size(213, 24);
			this.materialCheckBox1.TabIndex = 10;
			this.materialCheckBox1.Text = "Reside en Casa Posadas";
			this.materialCheckBox1.UseVisualStyleBackColor = true;
			// 
			// materialLabel5
			// 
			this.materialLabel5.Depth = 0;
			this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
			this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.materialLabel5.Location = new System.Drawing.Point(25, 185);
			this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialLabel5.Name = "materialLabel5";
			this.materialLabel5.Size = new System.Drawing.Size(100, 23);
			this.materialLabel5.TabIndex = 12;
			this.materialLabel5.Text = "Habitación";
			// 
			// materialSingleLineTextField5
			// 
			this.materialSingleLineTextField5.BackColor = System.Drawing.SystemColors.Control;
			this.materialSingleLineTextField5.Depth = 0;
			this.materialSingleLineTextField5.Hint = "";
			this.materialSingleLineTextField5.Location = new System.Drawing.Point(25, 211);
			this.materialSingleLineTextField5.MaxLength = 32767;
			this.materialSingleLineTextField5.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialSingleLineTextField5.Name = "materialSingleLineTextField5";
			this.materialSingleLineTextField5.PasswordChar = '\0';
			this.materialSingleLineTextField5.SelectedText = "";
			this.materialSingleLineTextField5.SelectionLength = 0;
			this.materialSingleLineTextField5.SelectionStart = 0;
			this.materialSingleLineTextField5.Size = new System.Drawing.Size(123, 23);
			this.materialSingleLineTextField5.TabIndex = 11;
			this.materialSingleLineTextField5.TabStop = false;
			this.materialSingleLineTextField5.UseSystemPasswordChar = false;
			// 
			// materialLabel6
			// 
			this.materialLabel6.Depth = 0;
			this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
			this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.materialLabel6.Location = new System.Drawing.Point(25, 256);
			this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialLabel6.Name = "materialLabel6";
			this.materialLabel6.Size = new System.Drawing.Size(100, 23);
			this.materialLabel6.TabIndex = 14;
			this.materialLabel6.Text = "Locker";
			// 
			// materialSingleLineTextField6
			// 
			this.materialSingleLineTextField6.BackColor = System.Drawing.SystemColors.Control;
			this.materialSingleLineTextField6.Depth = 0;
			this.materialSingleLineTextField6.Hint = "";
			this.materialSingleLineTextField6.Location = new System.Drawing.Point(25, 283);
			this.materialSingleLineTextField6.MaxLength = 32767;
			this.materialSingleLineTextField6.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialSingleLineTextField6.Name = "materialSingleLineTextField6";
			this.materialSingleLineTextField6.PasswordChar = '\0';
			this.materialSingleLineTextField6.SelectedText = "";
			this.materialSingleLineTextField6.SelectionLength = 0;
			this.materialSingleLineTextField6.SelectionStart = 0;
			this.materialSingleLineTextField6.Size = new System.Drawing.Size(123, 23);
			this.materialSingleLineTextField6.TabIndex = 13;
			this.materialSingleLineTextField6.TabStop = false;
			this.materialSingleLineTextField6.UseSystemPasswordChar = false;
			// 
			// materialLabel7
			// 
			this.materialLabel7.Depth = 0;
			this.materialLabel7.Font = new System.Drawing.Font("Roboto", 11F);
			this.materialLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.materialLabel7.Location = new System.Drawing.Point(25, 325);
			this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialLabel7.Name = "materialLabel7";
			this.materialLabel7.Size = new System.Drawing.Size(150, 23);
			this.materialLabel7.TabIndex = 16;
			this.materialLabel7.Text = "Fecha de Ingreso";
			// 
			// materialSingleLineTextField7
			// 
			this.materialSingleLineTextField7.BackColor = System.Drawing.SystemColors.Control;
			this.materialSingleLineTextField7.Depth = 0;
			this.materialSingleLineTextField7.Enabled = false;
			this.materialSingleLineTextField7.Hint = "dd/mm/aaaa";
			this.materialSingleLineTextField7.Location = new System.Drawing.Point(25, 351);
			this.materialSingleLineTextField7.MaxLength = 32767;
			this.materialSingleLineTextField7.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialSingleLineTextField7.Name = "materialSingleLineTextField7";
			this.materialSingleLineTextField7.PasswordChar = '\0';
			this.materialSingleLineTextField7.SelectedText = "";
			this.materialSingleLineTextField7.SelectionLength = 0;
			this.materialSingleLineTextField7.SelectionStart = 0;
			this.materialSingleLineTextField7.Size = new System.Drawing.Size(123, 23);
			this.materialSingleLineTextField7.TabIndex = 15;
			this.materialSingleLineTextField7.TabStop = false;
			this.materialSingleLineTextField7.UseSystemPasswordChar = false;
			// 
			// materialCheckBox2
			// 
			this.materialCheckBox2.Checked = true;
			this.materialCheckBox2.CheckState = System.Windows.Forms.CheckState.Checked;
			this.materialCheckBox2.Depth = 0;
			this.materialCheckBox2.Font = new System.Drawing.Font("Roboto", 10F);
			this.materialCheckBox2.Location = new System.Drawing.Point(164, 351);
			this.materialCheckBox2.Margin = new System.Windows.Forms.Padding(0);
			this.materialCheckBox2.MouseLocation = new System.Drawing.Point(-1, -1);
			this.materialCheckBox2.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialCheckBox2.Name = "materialCheckBox2";
			this.materialCheckBox2.Ripple = true;
			this.materialCheckBox2.Size = new System.Drawing.Size(213, 24);
			this.materialCheckBox2.TabIndex = 17;
			this.materialCheckBox2.Text = "Hoy";
			this.materialCheckBox2.UseVisualStyleBackColor = true;
			this.materialCheckBox2.CheckedChanged += new System.EventHandler(this.MaterialCheckBox2CheckedChanged);
			// 
			// materialLabel8
			// 
			this.materialLabel8.Depth = 0;
			this.materialLabel8.Font = new System.Drawing.Font("Roboto", 11F);
			this.materialLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.materialLabel8.Location = new System.Drawing.Point(284, 218);
			this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialLabel8.Name = "materialLabel8";
			this.materialLabel8.Size = new System.Drawing.Size(178, 23);
			this.materialLabel8.TabIndex = 19;
			this.materialLabel8.Text = "Cama del Hospital";
			// 
			// materialSingleLineTextField8
			// 
			this.materialSingleLineTextField8.BackColor = System.Drawing.SystemColors.Control;
			this.materialSingleLineTextField8.Depth = 0;
			this.materialSingleLineTextField8.Hint = "Número de cama";
			this.materialSingleLineTextField8.Location = new System.Drawing.Point(287, 246);
			this.materialSingleLineTextField8.MaxLength = 32767;
			this.materialSingleLineTextField8.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialSingleLineTextField8.Name = "materialSingleLineTextField8";
			this.materialSingleLineTextField8.PasswordChar = '\0';
			this.materialSingleLineTextField8.SelectedText = "";
			this.materialSingleLineTextField8.SelectionLength = 0;
			this.materialSingleLineTextField8.SelectionStart = 0;
			this.materialSingleLineTextField8.Size = new System.Drawing.Size(198, 23);
			this.materialSingleLineTextField8.TabIndex = 18;
			this.materialSingleLineTextField8.TabStop = false;
			this.materialSingleLineTextField8.UseSystemPasswordChar = false;
			// 
			// FormAddGuest
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(741, 518);
			this.Controls.Add(this.materialLabel8);
			this.Controls.Add(this.materialSingleLineTextField8);
			this.Controls.Add(this.materialCheckBox2);
			this.Controls.Add(this.materialLabel7);
			this.Controls.Add(this.materialSingleLineTextField7);
			this.Controls.Add(this.materialLabel6);
			this.Controls.Add(this.materialSingleLineTextField6);
			this.Controls.Add(this.materialLabel5);
			this.Controls.Add(this.materialSingleLineTextField5);
			this.Controls.Add(this.materialCheckBox1);
			this.Controls.Add(this.materialFlatButton1);
			this.Controls.Add(this.materialLabel3);
			this.Controls.Add(this.materialSingleLineTextField3);
			this.Controls.Add(this.materialSingleLineTextField4);
			this.Controls.Add(this.materialLabel4);
			this.Controls.Add(this.materialLabel2);
			this.Controls.Add(this.materialSingleLineTextField2);
			this.Controls.Add(this.materialSingleLineTextField1);
			this.Controls.Add(this.materialLabel1);
			this.Controls.Add(this.pictureBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FormAddGuest";
			this.Text = "FormAddGuest";
			this.Load += new System.EventHandler(this.FormAddGuestLoad);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField8;
		private MaterialSkin.Controls.MaterialLabel materialLabel8;
		private MaterialSkin.Controls.MaterialCheckBox materialCheckBox2;
		private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField7;
		private MaterialSkin.Controls.MaterialLabel materialLabel7;
		private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField6;
		private MaterialSkin.Controls.MaterialLabel materialLabel6;
		private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField5;
		private MaterialSkin.Controls.MaterialLabel materialLabel5;
		private MaterialSkin.Controls.MaterialCheckBox materialCheckBox1;
		private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
		private MaterialSkin.Controls.MaterialLabel materialLabel4;
		private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField4;
		private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField3;
		private MaterialSkin.Controls.MaterialLabel materialLabel3;
		private MaterialSkin.Controls.MaterialLabel materialLabel2;
		private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField2;
		private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField1;
		private MaterialSkin.Controls.MaterialLabel materialLabel1;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}
