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
		  this.pic_photo = new System.Windows.Forms.PictureBox();
		  this.lbl_croparea = new System.Windows.Forms.Label();
		  this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
		  this.btn_crop = new MaterialSkin.Controls.MaterialFlatButton();
		  this.materialToolStripMenuItem1 = new MaterialSkin.Controls.MaterialToolStripMenuItem();
		  this.cmb_devices = new System.Windows.Forms.ComboBox();
		  this.button12 = new MaterialSkin.Controls.MaterialFlatButton();
		  this.tbr_zoom = new System.Windows.Forms.TrackBar();
		  this.btn_loadpic = new MaterialSkin.Controls.MaterialFlatButton();
		  this.btn_takepic = new MaterialSkin.Controls.MaterialFlatButton();
		  this.lbl_zoom = new MaterialSkin.Controls.MaterialLabel();
		  this.lbl_devices = new MaterialSkin.Controls.MaterialLabel();
		  this.pic_bigphoto = new System.Windows.Forms.PictureBox();
		  this.btn_ok = new MaterialSkin.Controls.MaterialFlatButton();
		  this.btn_opback = new MaterialSkin.Controls.MaterialFlatButton();
		  ((System.ComponentModel.ISupportInitialize)(this.pic_photo)).BeginInit();
		  ((System.ComponentModel.ISupportInitialize)(this.tbr_zoom)).BeginInit();
		  ((System.ComponentModel.ISupportInitialize)(this.pic_bigphoto)).BeginInit();
		  this.SuspendLayout();
		  // 
		  // pic_photo
		  // 
		  this.pic_photo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		  this.pic_photo.Location = new System.Drawing.Point(40, 319);
		  this.pic_photo.Name = "pic_photo";
		  this.pic_photo.Size = new System.Drawing.Size(100, 100);
		  this.pic_photo.TabIndex = 5;
		  this.pic_photo.TabStop = false;
		  this.pic_photo.Visible = false;
		  this.pic_photo.Click += new System.EventHandler(this.Pic_photoClick);
		  // 
		  // lbl_croparea
		  // 
		  this.lbl_croparea.BackColor = System.Drawing.Color.Transparent;
		  this.lbl_croparea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		  this.lbl_croparea.ForeColor = System.Drawing.Color.Black;
		  this.lbl_croparea.Location = new System.Drawing.Point(331, 209);
		  this.lbl_croparea.Name = "lbl_croparea";
		  this.lbl_croparea.Size = new System.Drawing.Size(100, 100);
		  this.lbl_croparea.TabIndex = 2;
		  this.lbl_croparea.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Label1MouseDown);
		  this.lbl_croparea.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Label1MouseMove);
		  // 
		  // openFileDialog1
		  // 
		  this.openFileDialog1.FileName = "openFileDialog1";
		  // 
		  // btn_crop
		  // 
		  this.btn_crop.AutoSize = true;
		  this.btn_crop.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
		  this.btn_crop.Depth = 0;
		  this.btn_crop.Icon = null;
		  this.btn_crop.Location = new System.Drawing.Point(50, 428);
		  this.btn_crop.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
		  this.btn_crop.MouseState = MaterialSkin.MouseState.HOVER;
		  this.btn_crop.Name = "btn_crop";
		  this.btn_crop.Primary = false;
		  this.btn_crop.selected = false;
		  this.btn_crop.Size = new System.Drawing.Size(90, 36);
		  this.btn_crop.TabIndex = 4;
		  this.btn_crop.Text = "RECORTAR";
		  this.btn_crop.UseVisualStyleBackColor = true;
		  this.btn_crop.Visible = false;
		  this.btn_crop.Click += new System.EventHandler(this.MaterialFlatButton2Click);
		  // 
		  // materialToolStripMenuItem1
		  // 
		  this.materialToolStripMenuItem1.AutoSize = false;
		  this.materialToolStripMenuItem1.Name = "materialToolStripMenuItem1";
		  this.materialToolStripMenuItem1.Size = new System.Drawing.Size(120, 30);
		  this.materialToolStripMenuItem1.Text = "materialToolStripMenuItem1";
		  // 
		  // cmb_devices
		  // 
		  this.cmb_devices.FormattingEnabled = true;
		  this.cmb_devices.Location = new System.Drawing.Point(40, 203);
		  this.cmb_devices.Name = "cmb_devices";
		  this.cmb_devices.Size = new System.Drawing.Size(149, 21);
		  this.cmb_devices.TabIndex = 6;
		  this.cmb_devices.Visible = false;
		  this.cmb_devices.SelectedIndexChanged += new System.EventHandler(this.ComboBox1SelectedIndexChanged);
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
		  // tbr_zoom
		  // 
		  this.tbr_zoom.Location = new System.Drawing.Point(32, 268);
		  this.tbr_zoom.Maximum = 50;
		  this.tbr_zoom.Name = "tbr_zoom";
		  this.tbr_zoom.Size = new System.Drawing.Size(157, 45);
		  this.tbr_zoom.TabIndex = 8;
		  this.tbr_zoom.Visible = false;
		  this.tbr_zoom.Scroll += new System.EventHandler(this.TrackBar1Scroll);
		  // 
		  // btn_loadpic
		  // 
		  this.btn_loadpic.AutoSize = true;
		  this.btn_loadpic.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
		  this.btn_loadpic.Depth = 0;
		  this.btn_loadpic.Icon = null;
		  this.btn_loadpic.Location = new System.Drawing.Point(36, 61);
		  this.btn_loadpic.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
		  this.btn_loadpic.MouseState = MaterialSkin.MouseState.HOVER;
		  this.btn_loadpic.Name = "btn_loadpic";
		  this.btn_loadpic.Primary = false;
		  this.btn_loadpic.selected = false;
		  this.btn_loadpic.Size = new System.Drawing.Size(130, 36);
		  this.btn_loadpic.TabIndex = 3;
		  this.btn_loadpic.Text = "Cargar imagen";
		  this.btn_loadpic.UseVisualStyleBackColor = true;
		  this.btn_loadpic.Click += new System.EventHandler(this.MaterialFlatButton1Click);
		  // 
		  // btn_takepic
		  // 
		  this.btn_takepic.Depth = 0;
		  this.btn_takepic.Icon = null;
		  this.btn_takepic.Location = new System.Drawing.Point(36, 100);
		  this.btn_takepic.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
		  this.btn_takepic.MouseState = MaterialSkin.MouseState.HOVER;
		  this.btn_takepic.Name = "btn_takepic";
		  this.btn_takepic.Primary = false;
		  this.btn_takepic.selected = false;
		  this.btn_takepic.Size = new System.Drawing.Size(130, 35);
		  this.btn_takepic.TabIndex = 10;
		  this.btn_takepic.Text = "Tomar Foto";
		  this.btn_takepic.UseVisualStyleBackColor = true;
		  this.btn_takepic.Click += new System.EventHandler(this.Button2Click);
		  // 
		  // lbl_zoom
		  // 
		  this.lbl_zoom.Depth = 0;
		  this.lbl_zoom.Font = new System.Drawing.Font("Roboto", 11F);
		  this.lbl_zoom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
		  this.lbl_zoom.Location = new System.Drawing.Point(36, 242);
		  this.lbl_zoom.MouseState = MaterialSkin.MouseState.HOVER;
		  this.lbl_zoom.Name = "lbl_zoom";
		  this.lbl_zoom.Size = new System.Drawing.Size(136, 23);
		  this.lbl_zoom.TabIndex = 11;
		  this.lbl_zoom.Text = "Tamaño del Marco";
		  // 
		  // lbl_devices
		  // 
		  this.lbl_devices.Depth = 0;
		  this.lbl_devices.Font = new System.Drawing.Font("Roboto", 11F);
		  this.lbl_devices.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
		  this.lbl_devices.Location = new System.Drawing.Point(36, 170);
		  this.lbl_devices.MouseState = MaterialSkin.MouseState.HOVER;
		  this.lbl_devices.Name = "lbl_devices";
		  this.lbl_devices.Size = new System.Drawing.Size(153, 23);
		  this.lbl_devices.TabIndex = 12;
		  this.lbl_devices.Text = "Dispositivo de Video";
		  // 
		  // pic_bigphoto
		  // 
		  this.pic_bigphoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		  this.pic_bigphoto.Location = new System.Drawing.Point(219, 61);
		  this.pic_bigphoto.Name = "pic_bigphoto";
		  this.pic_bigphoto.Size = new System.Drawing.Size(500, 400);
		  this.pic_bigphoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
		  this.pic_bigphoto.TabIndex = 13;
		  this.pic_bigphoto.TabStop = false;
		  this.pic_bigphoto.Click += new System.EventHandler(this.Pic_bigphotoClick);
		  // 
		  // btn_ok
		  // 
		  this.btn_ok.AutoSize = true;
		  this.btn_ok.Depth = 0;
		  this.btn_ok.Icon = null;
		  this.btn_ok.Location = new System.Drawing.Point(617, 473);
		  this.btn_ok.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
		  this.btn_ok.MouseState = MaterialSkin.MouseState.HOVER;
		  this.btn_ok.Name = "btn_ok";
		  this.btn_ok.Primary = false;
		  this.btn_ok.selected = false;
		  this.btn_ok.Size = new System.Drawing.Size(82, 36);
		  this.btn_ok.TabIndex = 14;
		  this.btn_ok.Text = "Aceptar";
		  this.btn_ok.UseVisualStyleBackColor = true;
		  // 
		  // btn_opback
		  // 
		  this.btn_opback.Depth = 0;
		  this.btn_opback.Icon = null;
		  this.btn_opback.Location = new System.Drawing.Point(515, 480);
		  this.btn_opback.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
		  this.btn_opback.MouseState = MaterialSkin.MouseState.HOVER;
		  this.btn_opback.Name = "btn_opback";
		  this.btn_opback.Primary = false;
		  this.btn_opback.selected = false;
		  this.btn_opback.Size = new System.Drawing.Size(75, 23);
		  this.btn_opback.TabIndex = 16;
		  this.btn_opback.Text = "Volver";
		  this.btn_opback.UseVisualStyleBackColor = true;
		  this.btn_opback.Click += new System.EventHandler(this.Btn_opbackClick);
		  // 
		  // FormLoadPicture
		  // 
		  this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
		  this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		  this.BackColor = System.Drawing.Color.White;
		  this.ClientSize = new System.Drawing.Size(741, 518);
		  this.Controls.Add(this.btn_opback);
		  this.Controls.Add(this.btn_ok);
		  this.Controls.Add(this.lbl_croparea);
		  this.Controls.Add(this.lbl_devices);
		  this.Controls.Add(this.lbl_zoom);
		  this.Controls.Add(this.btn_takepic);
		  this.Controls.Add(this.tbr_zoom);
		  this.Controls.Add(this.button12);
		  this.Controls.Add(this.cmb_devices);
		  this.Controls.Add(this.pic_photo);
		  this.Controls.Add(this.btn_crop);
		  this.Controls.Add(this.btn_loadpic);
		  this.Controls.Add(this.pic_bigphoto);
		  this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		  this.Name = "FormLoadPicture";
		  this.Text = "FormLoadPicture";
		  this.Load += new System.EventHandler(this.FormLoadPictureLoad);
		  ((System.ComponentModel.ISupportInitialize)(this.pic_photo)).EndInit();
		  ((System.ComponentModel.ISupportInitialize)(this.tbr_zoom)).EndInit();
		  ((System.ComponentModel.ISupportInitialize)(this.pic_bigphoto)).EndInit();
		  this.ResumeLayout(false);
		  this.PerformLayout();
		}
		private MaterialSkin.Controls.MaterialFlatButton btn_opback;
		private MaterialSkin.Controls.MaterialFlatButton btn_ok;
		private System.Windows.Forms.PictureBox pic_bigphoto;
		private MaterialSkin.Controls.MaterialLabel lbl_devices;
		private MaterialSkin.Controls.MaterialLabel lbl_zoom;
		private MaterialSkin.Controls.MaterialFlatButton btn_takepic;
		private System.Windows.Forms.TrackBar tbr_zoom;
		private MaterialSkin.Controls.MaterialFlatButton button12;
		private System.Windows.Forms.ComboBox cmb_devices;
		private MaterialSkin.Controls.MaterialToolStripMenuItem materialToolStripMenuItem1;
		public System.Windows.Forms.PictureBox pic_photo;
		private MaterialSkin.Controls.MaterialFlatButton btn_crop;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private MaterialSkin.Controls.MaterialFlatButton btn_loadpic;
		private System.Windows.Forms.Label lbl_croparea;
	}
}
