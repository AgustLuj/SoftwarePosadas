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
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.button4 = new MaterialSkin.Controls.MaterialFlatButton();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.materialToolStripMenuItem1 = new MaterialSkin.Controls.MaterialToolStripMenuItem();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.button12 = new MaterialSkin.Controls.MaterialFlatButton();
			this.trackBar1 = new System.Windows.Forms.TrackBar();
			this.button3 = new MaterialSkin.Controls.MaterialFlatButton();
			this.button1 = new MaterialSkin.Controls.MaterialFlatButton();
			this.button2 = new MaterialSkin.Controls.MaterialFlatButton();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
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
			this.label1.Location = new System.Drawing.Point(396, 238);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 100);
			this.label1.TabIndex = 2;
			this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Label1MouseDown);
			this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Label1MouseMove);
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// button4
			// 
			this.button4.AutoSize = true;
			this.button4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.button4.Depth = 0;
			this.button4.Icon = null;
			this.button4.Location = new System.Drawing.Point(56, 381);
			this.button4.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
			this.button4.MouseState = MaterialSkin.MouseState.HOVER;
			this.button4.Name = "button4";
			this.button4.Primary = false;
			this.button4.selected = false;
			this.button4.Size = new System.Drawing.Size(90, 36);
			this.button4.TabIndex = 4;
			this.button4.Text = "RECORTAR";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Visible = false;
			this.button4.Click += new System.EventHandler(this.MaterialFlatButton2Click);
			// 
			// pictureBox2
			// 
			this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBox2.Location = new System.Drawing.Point(46, 272);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(100, 100);
			this.pictureBox2.TabIndex = 5;
			this.pictureBox2.TabStop = false;
			this.pictureBox2.Visible = false;
			// 
			// materialToolStripMenuItem1
			// 
			this.materialToolStripMenuItem1.AutoSize = false;
			this.materialToolStripMenuItem1.Name = "materialToolStripMenuItem1";
			this.materialToolStripMenuItem1.Size = new System.Drawing.Size(120, 30);
			this.materialToolStripMenuItem1.Text = "materialToolStripMenuItem1";
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(36, 131);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(126, 21);
			this.comboBox1.TabIndex = 6;
			this.comboBox1.Visible = false;
			// 
			// button12
			// 
			this.button12.Depth = 0;
			this.button12.Icon = null;
			this.button12.Location = new System.Drawing.Point(0, 0);
			this.button12.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
			this.button12.MouseState = MaterialSkin.MouseState.HOVER;
			this.button12.Name = "button12";
			this.button12.Primary = false;
			this.button12.selected = false;
			this.button12.Size = new System.Drawing.Size(75, 23);
			this.button12.TabIndex = 9;
			// 
			// trackBar1
			// 
			this.trackBar1.Location = new System.Drawing.Point(36, 181);
			this.trackBar1.Maximum = 50;
			this.trackBar1.Name = "trackBar1";
			this.trackBar1.Size = new System.Drawing.Size(126, 45);
			this.trackBar1.TabIndex = 8;
			this.trackBar1.Visible = false;
			// 
			// button3
			// 
			this.button3.AutoSize = true;
			this.button3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.button3.Depth = 0;
			this.button3.Icon = null;
			this.button3.Location = new System.Drawing.Point(32, 61);
			this.button3.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
			this.button3.MouseState = MaterialSkin.MouseState.HOVER;
			this.button3.Name = "button3";
			this.button3.Primary = false;
			this.button3.selected = false;
			this.button3.Size = new System.Drawing.Size(130, 36);
			this.button3.TabIndex = 3;
			this.button3.Text = "Cargar imagen";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.MaterialFlatButton1Click);
			// 
			// button1
			// 
			this.button1.AutoSize = true;
			this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.button1.Depth = 0;
			this.button1.Icon = null;
			this.button1.Location = new System.Drawing.Point(67, 227);
			this.button1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
			this.button1.MouseState = MaterialSkin.MouseState.HOVER;
			this.button1.Name = "button1";
			this.button1.Primary = false;
			this.button1.selected = false;
			this.button1.Size = new System.Drawing.Size(69, 36);
			this.button1.TabIndex = 7;
			this.button1.Text = "Iniciar";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Visible = false;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// button2
			// 
			this.button2.Depth = 0;
			this.button2.Icon = null;
			this.button2.Location = new System.Drawing.Point(36, 99);
			this.button2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
			this.button2.MouseState = MaterialSkin.MouseState.HOVER;
			this.button2.Name = "button2";
			this.button2.Primary = false;
			this.button2.selected = false;
			this.button2.Size = new System.Drawing.Size(93, 23);
			this.button2.TabIndex = 10;
			this.button2.Text = "Sacar foto";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// FormLoadPicture
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(741, 518);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.trackBar1);
			this.Controls.Add(this.button12);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pictureBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "FormLoadPicture";
			this.Text = "FormLoadPicture";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private MaterialSkin.Controls.MaterialFlatButton button2;
		private MaterialSkin.Controls.MaterialFlatButton button1;
		private System.Windows.Forms.TrackBar trackBar1;
		private MaterialSkin.Controls.MaterialFlatButton button12;
		private System.Windows.Forms.ComboBox comboBox1;
		private MaterialSkin.Controls.MaterialToolStripMenuItem materialToolStripMenuItem1;
		public System.Windows.Forms.PictureBox pictureBox2;
		private MaterialSkin.Controls.MaterialFlatButton button4;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private MaterialSkin.Controls.MaterialFlatButton button3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}
