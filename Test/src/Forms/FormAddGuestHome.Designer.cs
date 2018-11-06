/*
 * Created by SharpDevelop.
 * User: lujan
 * Date: 27/8/2018
 * Time: 09:01
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Program.Forms
{
	partial class FormAddGuestHome
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
			this.label_ficha = new MaterialSkin.Controls.MaterialLabel();
			this.button_huesped = new MaterialSkin.Controls.MaterialFlatButton();
			this.button_paciente = new MaterialSkin.Controls.MaterialFlatButton();
			this.materialToolStripMenuItem1 = new MaterialSkin.Controls.MaterialToolStripMenuItem();
			this.materialToolStripMenuItem2 = new MaterialSkin.Controls.MaterialToolStripMenuItem();
			this.materialToolStripMenuItem3 = new MaterialSkin.Controls.MaterialToolStripMenuItem();
			this.materialFlatButton2 = new MaterialSkin.Controls.MaterialFlatButton();
			this.SuspendLayout();
			// 
			// label_ficha
			// 
			this.label_ficha.Depth = 0;
			this.label_ficha.Font = new System.Drawing.Font("Roboto", 11F);
			this.label_ficha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.label_ficha.Location = new System.Drawing.Point(39, 34);
			this.label_ficha.MouseState = MaterialSkin.MouseState.HOVER;
			this.label_ficha.Name = "label_ficha";
			this.label_ficha.Size = new System.Drawing.Size(215, 32);
			this.label_ficha.TabIndex = 0;
			this.label_ficha.Text = "Ficha N° ";
			// 
			// button_huesped
			// 
			this.button_huesped.AutoSize = true;
			this.button_huesped.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.button_huesped.Depth = 0;
			this.button_huesped.Icon = null;
			this.button_huesped.Location = new System.Drawing.Point(74, 86);
			this.button_huesped.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
			this.button_huesped.MouseState = MaterialSkin.MouseState.HOVER;
			this.button_huesped.Name = "button_huesped";
			this.button_huesped.Primary = false;
			this.button_huesped.selected = false;
			this.button_huesped.Size = new System.Drawing.Size(145, 36);
			this.button_huesped.TabIndex = 1;
			this.button_huesped.Text = "+ Añadir Huesped";
			this.button_huesped.UseVisualStyleBackColor = true;
			this.button_huesped.Click += new System.EventHandler(this.Button_huespedClick);
			// 
			// button_paciente
			// 
			this.button_paciente.AutoSize = true;
			this.button_paciente.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.button_paciente.Depth = 0;
			this.button_paciente.Icon = null;
			this.button_paciente.Location = new System.Drawing.Point(375, 86);
			this.button_paciente.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
			this.button_paciente.MouseState = MaterialSkin.MouseState.HOVER;
			this.button_paciente.Name = "button_paciente";
			this.button_paciente.Primary = false;
			this.button_paciente.selected = false;
			this.button_paciente.Size = new System.Drawing.Size(149, 36);
			this.button_paciente.TabIndex = 2;
			this.button_paciente.Text = "+ Añadir Paciente";
			this.button_paciente.UseVisualStyleBackColor = true;
			this.button_paciente.Click += new System.EventHandler(this.Button_pacienteClick);
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
			// materialToolStripMenuItem3
			// 
			this.materialToolStripMenuItem3.AutoSize = false;
			this.materialToolStripMenuItem3.Name = "materialToolStripMenuItem3";
			this.materialToolStripMenuItem3.Size = new System.Drawing.Size(120, 30);
			this.materialToolStripMenuItem3.Text = "materialToolStripMenuItem3";
			// 
			// materialFlatButton2
			// 
			this.materialFlatButton2.AutoSize = true;
			this.materialFlatButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.materialFlatButton2.Depth = 0;
			this.materialFlatButton2.Icon = null;
			this.materialFlatButton2.Location = new System.Drawing.Point(513, 441);
			this.materialFlatButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
			this.materialFlatButton2.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialFlatButton2.Name = "materialFlatButton2";
			this.materialFlatButton2.Primary = false;
			this.materialFlatButton2.selected = false;
			this.materialFlatButton2.Size = new System.Drawing.Size(73, 36);
			this.materialFlatButton2.TabIndex = 3;
			this.materialFlatButton2.Text = "cerrar";
			this.materialFlatButton2.UseVisualStyleBackColor = true;
			this.materialFlatButton2.Click += new System.EventHandler(this.MaterialFlatButton2Click);
			// 
			// FormAddGuestHome
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(741, 518);
			this.Controls.Add(this.materialFlatButton2);
			this.Controls.Add(this.button_paciente);
			this.Controls.Add(this.button_huesped);
			this.Controls.Add(this.label_ficha);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FormAddGuestHome";
			this.Text = "FormAddGuestHome";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormAddGuestHomeFormClosed);
			this.Load += new System.EventHandler(this.FormAddGuestHomeLoad);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private MaterialSkin.Controls.MaterialFlatButton materialFlatButton2;
		private MaterialSkin.Controls.MaterialToolStripMenuItem materialToolStripMenuItem3;
		private MaterialSkin.Controls.MaterialToolStripMenuItem materialToolStripMenuItem2;
		private MaterialSkin.Controls.MaterialToolStripMenuItem materialToolStripMenuItem1;
		private MaterialSkin.Controls.MaterialFlatButton button_paciente;
		private MaterialSkin.Controls.MaterialFlatButton button_huesped;
		private MaterialSkin.Controls.MaterialLabel label_ficha;
		
	}
}
