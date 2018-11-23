/*
 * Created by SharpDevelop.
 * User: lujan
 * Date: 31/8/2018
 * Time: 10:46
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Program.Forms
{
	partial class FormSearchGuest
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
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.text_apellido = new MaterialSkin.Controls.MaterialSingleLineTextField();
			this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
			this.materialFlatButton2 = new MaterialSkin.Controls.MaterialFlatButton();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[] {
									"N° ficha",
									"DNI",
									""});
			this.comboBox1.Location = new System.Drawing.Point(81, 103);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(148, 21);
			this.comboBox1.TabIndex = 1;
			// 
			// text_apellido
			// 
			this.text_apellido.BackColor = System.Drawing.SystemColors.Control;
			this.text_apellido.Depth = 0;
			this.text_apellido.Hint = "Ingrese el apellido";
			this.text_apellido.Location = new System.Drawing.Point(250, 103);
			this.text_apellido.MaxLength = 32767;
			this.text_apellido.MouseState = MaterialSkin.MouseState.HOVER;
			this.text_apellido.Name = "text_apellido";
			this.text_apellido.PasswordChar = '\0';
			this.text_apellido.SelectedText = "";
			this.text_apellido.SelectionLength = 0;
			this.text_apellido.SelectionStart = 0;
			this.text_apellido.Size = new System.Drawing.Size(198, 23);
			this.text_apellido.TabIndex = 4;
			this.text_apellido.TabStop = false;
			this.text_apellido.UseSystemPasswordChar = false;
			// 
			// materialFlatButton1
			// 
			this.materialFlatButton1.AutoSize = true;
			this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.materialFlatButton1.Depth = 0;
			this.materialFlatButton1.Icon = null;
			this.materialFlatButton1.Location = new System.Drawing.Point(455, 94);
			this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
			this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialFlatButton1.Name = "materialFlatButton1";
			this.materialFlatButton1.Primary = false;
			this.materialFlatButton1.selected = false;
			this.materialFlatButton1.Size = new System.Drawing.Size(181, 36);
			this.materialFlatButton1.TabIndex = 5;
			this.materialFlatButton1.Text = "materialFlatButton1";
			this.materialFlatButton1.UseVisualStyleBackColor = true;
			this.materialFlatButton1.Click += new System.EventHandler(this.MaterialFlatButton1Click);
			// 
			// materialFlatButton2
			// 
			this.materialFlatButton2.AutoSize = true;
			this.materialFlatButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.materialFlatButton2.Depth = 0;
			this.materialFlatButton2.Icon = null;
			this.materialFlatButton2.Location = new System.Drawing.Point(203, 366);
			this.materialFlatButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
			this.materialFlatButton2.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialFlatButton2.Name = "materialFlatButton2";
			this.materialFlatButton2.Primary = false;
			this.materialFlatButton2.selected = false;
			this.materialFlatButton2.Size = new System.Drawing.Size(73, 36);
			this.materialFlatButton2.TabIndex = 6;
			this.materialFlatButton2.Text = "CERRAR";
			this.materialFlatButton2.UseVisualStyleBackColor = true;
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(81, 182);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(254, 150);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 7;
			this.pictureBox1.TabStop = false;
			// 
			// FormSearchGuest
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(741, 518);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.materialFlatButton2);
			this.Controls.Add(this.materialFlatButton1);
			this.Controls.Add(this.text_apellido);
			this.Controls.Add(this.comboBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FormSearchGuest";
			this.Text = "FormSearchGuest";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private MaterialSkin.Controls.MaterialFlatButton materialFlatButton2;
		private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
		private MaterialSkin.Controls.MaterialSingleLineTextField text_apellido;
		private System.Windows.Forms.ComboBox comboBox1;
	}
}
