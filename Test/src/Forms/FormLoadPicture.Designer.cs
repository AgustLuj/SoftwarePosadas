/*
 * Created by SharpDevelop.
 * User: lujan
 * Date: 20/9/2018
 * Time: 08:55
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Program.Forms
{
	partial class FormLoadPicture
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLoadPicture));
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.materialFlatButton2 = new MaterialSkin.Controls.MaterialFlatButton();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.ImageLocation = "";
			this.pictureBox1.Location = new System.Drawing.Point(211, 61);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(500, 400);
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label1.ForeColor = System.Drawing.Color.Black;
			this.label1.Location = new System.Drawing.Point(392, 199);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 100);
			this.label1.TabIndex = 2;
			this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Label1MouseDown);
			// 
			// materialFlatButton1
			// 
			this.materialFlatButton1.AutoSize = true;
			this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.materialFlatButton1.Depth = 0;
			this.materialFlatButton1.Icon = null;
			this.materialFlatButton1.Location = new System.Drawing.Point(32, 61);
			this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
			this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialFlatButton1.Name = "materialFlatButton1";
			this.materialFlatButton1.Primary = false;
			this.materialFlatButton1.selected = false;
			this.materialFlatButton1.Size = new System.Drawing.Size(130, 36);
			this.materialFlatButton1.TabIndex = 3;
			this.materialFlatButton1.Text = "Cargar imagen";
			this.materialFlatButton1.UseVisualStyleBackColor = true;
			this.materialFlatButton1.Click += new System.EventHandler(this.MaterialFlatButton1Click);
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// materialFlatButton2
			// 
			this.materialFlatButton2.AutoSize = true;
			this.materialFlatButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.materialFlatButton2.Depth = 0;
			this.materialFlatButton2.Icon = null;
			this.materialFlatButton2.Location = new System.Drawing.Point(32, 131);
			this.materialFlatButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
			this.materialFlatButton2.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialFlatButton2.Name = "materialFlatButton2";
			this.materialFlatButton2.Primary = false;
			this.materialFlatButton2.selected = false;
			this.materialFlatButton2.Size = new System.Drawing.Size(90, 36);
			this.materialFlatButton2.TabIndex = 4;
			this.materialFlatButton2.Text = "RECORTAR";
			this.materialFlatButton2.UseVisualStyleBackColor = true;
			this.materialFlatButton2.Click += new System.EventHandler(this.MaterialFlatButton2Click);
			// 
			// pictureBox2
			// 
			this.pictureBox2.Location = new System.Drawing.Point(36, 238);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(100, 100);
			this.pictureBox2.TabIndex = 5;
			this.pictureBox2.TabStop = false;
			// 
			// FormLoadPicture
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(741, 518);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.materialFlatButton2);
			this.Controls.Add(this.materialFlatButton1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pictureBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FormLoadPicture";
			this.Text = "FormLoadPicture";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.PictureBox pictureBox2;
		private MaterialSkin.Controls.MaterialFlatButton materialFlatButton2;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}
