/*
 * Created by SharpDevelop.
 * User: RamiroPC
 * Date: 18/10/2018
 * Time: 08:45
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Program.Forms
{
	partial class FormStats
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStats));
			this.pic = new System.Windows.Forms.PictureBox();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.pictureBox4 = new System.Windows.Forms.PictureBox();
			this.pictureBox5 = new System.Windows.Forms.PictureBox();
			this.pictureBox6 = new System.Windows.Forms.PictureBox();
			this.pictureBox7 = new System.Windows.Forms.PictureBox();
			this.pictureBox8 = new System.Windows.Forms.PictureBox();
			this.pictureBox9 = new System.Windows.Forms.PictureBox();
			this.pictureBox10 = new System.Windows.Forms.PictureBox();
			this.pictureBox11 = new System.Windows.Forms.PictureBox();
			this.pictureBox12 = new System.Windows.Forms.PictureBox();
			this.pictureBox13 = new System.Windows.Forms.PictureBox();
			this.pictureBox14 = new System.Windows.Forms.PictureBox();
			this.pictureBox15 = new System.Windows.Forms.PictureBox();
			this.pictureBox16 = new System.Windows.Forms.PictureBox();
			this.pictureBox18 = new System.Windows.Forms.PictureBox();
			this.pictureBox19 = new System.Windows.Forms.PictureBox();
			this.pictureBox20 = new System.Windows.Forms.PictureBox();
			this.pictureBox21 = new System.Windows.Forms.PictureBox();
			this.pictureBox22 = new System.Windows.Forms.PictureBox();
			this.pictureBox23 = new System.Windows.Forms.PictureBox();
			this.pictureBox24 = new System.Windows.Forms.PictureBox();
			this.pictureBox17 = new System.Windows.Forms.PictureBox();
			this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
			this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
			this.materialRadioButton1 = new MaterialSkin.Controls.MaterialRadioButton();
			this.materialRadioButton2 = new MaterialSkin.Controls.MaterialRadioButton();
			this.materialRadioButton4 = new MaterialSkin.Controls.MaterialRadioButton();
			this.combo_año = new System.Windows.Forms.ComboBox();
			this.combo_mes = new System.Windows.Forms.ComboBox();
			this.materialCheckBox1 = new MaterialSkin.Controls.MaterialCheckBox();
			this.materialCheckBox2 = new MaterialSkin.Controls.MaterialCheckBox();
			this.materialCheckBox3 = new MaterialSkin.Controls.MaterialCheckBox();
			this.combo_dia = new System.Windows.Forms.ComboBox();
			((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox18)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox19)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox20)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox21)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox22)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox23)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox24)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).BeginInit();
			this.SuspendLayout();
			// 
			// pic
			// 
			this.pic.Location = new System.Drawing.Point(43, 54);
			this.pic.Name = "pic";
			this.pic.Size = new System.Drawing.Size(622, 130);
			this.pic.TabIndex = 0;
			this.pic.TabStop = false;
			// 
			// timer1
			// 
			this.timer1.Interval = 1;
			this.timer1.Tick += new System.EventHandler(this.Timer1Tick);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(43, 182);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(24, 150);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(70, 183);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(24, 150);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox2.TabIndex = 2;
			this.pictureBox2.TabStop = false;
			// 
			// pictureBox3
			// 
			this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
			this.pictureBox3.Location = new System.Drawing.Point(121, 187);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(24, 150);
			this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox3.TabIndex = 4;
			this.pictureBox3.TabStop = false;
			// 
			// pictureBox4
			// 
			this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
			this.pictureBox4.Location = new System.Drawing.Point(97, 179);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new System.Drawing.Size(24, 150);
			this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox4.TabIndex = 3;
			this.pictureBox4.TabStop = false;
			// 
			// pictureBox5
			// 
			this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
			this.pictureBox5.Location = new System.Drawing.Point(224, 180);
			this.pictureBox5.Name = "pictureBox5";
			this.pictureBox5.Size = new System.Drawing.Size(24, 150);
			this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox5.TabIndex = 8;
			this.pictureBox5.TabStop = false;
			// 
			// pictureBox6
			// 
			this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
			this.pictureBox6.Location = new System.Drawing.Point(200, 183);
			this.pictureBox6.Name = "pictureBox6";
			this.pictureBox6.Size = new System.Drawing.Size(24, 150);
			this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox6.TabIndex = 7;
			this.pictureBox6.TabStop = false;
			// 
			// pictureBox7
			// 
			this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
			this.pictureBox7.Location = new System.Drawing.Point(174, 183);
			this.pictureBox7.Name = "pictureBox7";
			this.pictureBox7.Size = new System.Drawing.Size(24, 150);
			this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox7.TabIndex = 6;
			this.pictureBox7.TabStop = false;
			// 
			// pictureBox8
			// 
			this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
			this.pictureBox8.Location = new System.Drawing.Point(146, 186);
			this.pictureBox8.Name = "pictureBox8";
			this.pictureBox8.Size = new System.Drawing.Size(24, 150);
			this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox8.TabIndex = 5;
			this.pictureBox8.TabStop = false;
			// 
			// pictureBox9
			// 
			this.pictureBox9.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox9.Image")));
			this.pictureBox9.Location = new System.Drawing.Point(436, 179);
			this.pictureBox9.Name = "pictureBox9";
			this.pictureBox9.Size = new System.Drawing.Size(24, 150);
			this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox9.TabIndex = 16;
			this.pictureBox9.TabStop = false;
			// 
			// pictureBox10
			// 
			this.pictureBox10.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox10.Image")));
			this.pictureBox10.Location = new System.Drawing.Point(408, 184);
			this.pictureBox10.Name = "pictureBox10";
			this.pictureBox10.Size = new System.Drawing.Size(24, 150);
			this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox10.TabIndex = 15;
			this.pictureBox10.TabStop = false;
			// 
			// pictureBox11
			// 
			this.pictureBox11.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox11.Image")));
			this.pictureBox11.Location = new System.Drawing.Point(385, 181);
			this.pictureBox11.Name = "pictureBox11";
			this.pictureBox11.Size = new System.Drawing.Size(24, 150);
			this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox11.TabIndex = 14;
			this.pictureBox11.TabStop = false;
			// 
			// pictureBox12
			// 
			this.pictureBox12.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox12.Image")));
			this.pictureBox12.Location = new System.Drawing.Point(357, 180);
			this.pictureBox12.Name = "pictureBox12";
			this.pictureBox12.Size = new System.Drawing.Size(24, 150);
			this.pictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox12.TabIndex = 13;
			this.pictureBox12.TabStop = false;
			// 
			// pictureBox13
			// 
			this.pictureBox13.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox13.Image")));
			this.pictureBox13.Location = new System.Drawing.Point(330, 182);
			this.pictureBox13.Name = "pictureBox13";
			this.pictureBox13.Size = new System.Drawing.Size(24, 150);
			this.pictureBox13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox13.TabIndex = 12;
			this.pictureBox13.TabStop = false;
			// 
			// pictureBox14
			// 
			this.pictureBox14.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox14.Image")));
			this.pictureBox14.Location = new System.Drawing.Point(305, 184);
			this.pictureBox14.Name = "pictureBox14";
			this.pictureBox14.Size = new System.Drawing.Size(24, 150);
			this.pictureBox14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox14.TabIndex = 11;
			this.pictureBox14.TabStop = false;
			// 
			// pictureBox15
			// 
			this.pictureBox15.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox15.Image")));
			this.pictureBox15.Location = new System.Drawing.Point(278, 181);
			this.pictureBox15.Name = "pictureBox15";
			this.pictureBox15.Size = new System.Drawing.Size(24, 150);
			this.pictureBox15.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox15.TabIndex = 10;
			this.pictureBox15.TabStop = false;
			// 
			// pictureBox16
			// 
			this.pictureBox16.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox16.Image")));
			this.pictureBox16.Location = new System.Drawing.Point(251, 183);
			this.pictureBox16.Name = "pictureBox16";
			this.pictureBox16.Size = new System.Drawing.Size(24, 150);
			this.pictureBox16.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox16.TabIndex = 9;
			this.pictureBox16.TabStop = false;
			// 
			// pictureBox18
			// 
			this.pictureBox18.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox18.Image")));
			this.pictureBox18.Location = new System.Drawing.Point(618, 185);
			this.pictureBox18.Name = "pictureBox18";
			this.pictureBox18.Size = new System.Drawing.Size(24, 150);
			this.pictureBox18.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox18.TabIndex = 23;
			this.pictureBox18.TabStop = false;
			// 
			// pictureBox19
			// 
			this.pictureBox19.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox19.Image")));
			this.pictureBox19.Location = new System.Drawing.Point(591, 181);
			this.pictureBox19.Name = "pictureBox19";
			this.pictureBox19.Size = new System.Drawing.Size(24, 150);
			this.pictureBox19.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox19.TabIndex = 22;
			this.pictureBox19.TabStop = false;
			// 
			// pictureBox20
			// 
			this.pictureBox20.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox20.Image")));
			this.pictureBox20.Location = new System.Drawing.Point(565, 187);
			this.pictureBox20.Name = "pictureBox20";
			this.pictureBox20.Size = new System.Drawing.Size(24, 150);
			this.pictureBox20.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox20.TabIndex = 21;
			this.pictureBox20.TabStop = false;
			// 
			// pictureBox21
			// 
			this.pictureBox21.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox21.Image")));
			this.pictureBox21.Location = new System.Drawing.Point(538, 182);
			this.pictureBox21.Name = "pictureBox21";
			this.pictureBox21.Size = new System.Drawing.Size(24, 150);
			this.pictureBox21.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox21.TabIndex = 20;
			this.pictureBox21.TabStop = false;
			// 
			// pictureBox22
			// 
			this.pictureBox22.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox22.Image")));
			this.pictureBox22.Location = new System.Drawing.Point(514, 182);
			this.pictureBox22.Name = "pictureBox22";
			this.pictureBox22.Size = new System.Drawing.Size(24, 150);
			this.pictureBox22.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox22.TabIndex = 19;
			this.pictureBox22.TabStop = false;
			// 
			// pictureBox23
			// 
			this.pictureBox23.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox23.Image")));
			this.pictureBox23.Location = new System.Drawing.Point(487, 184);
			this.pictureBox23.Name = "pictureBox23";
			this.pictureBox23.Size = new System.Drawing.Size(24, 150);
			this.pictureBox23.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox23.TabIndex = 18;
			this.pictureBox23.TabStop = false;
			// 
			// pictureBox24
			// 
			this.pictureBox24.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox24.Image")));
			this.pictureBox24.Location = new System.Drawing.Point(460, 189);
			this.pictureBox24.Name = "pictureBox24";
			this.pictureBox24.Size = new System.Drawing.Size(24, 150);
			this.pictureBox24.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox24.TabIndex = 17;
			this.pictureBox24.TabStop = false;
			// 
			// pictureBox17
			// 
			this.pictureBox17.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox17.Image")));
			this.pictureBox17.Location = new System.Drawing.Point(642, 192);
			this.pictureBox17.Name = "pictureBox17";
			this.pictureBox17.Size = new System.Drawing.Size(24, 150);
			this.pictureBox17.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox17.TabIndex = 24;
			this.pictureBox17.TabStop = false;
			// 
			// materialLabel1
			// 
			this.materialLabel1.Depth = 0;
			this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
			this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.materialLabel1.Location = new System.Drawing.Point(39, 18);
			this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialLabel1.Name = "materialLabel1";
			this.materialLabel1.Size = new System.Drawing.Size(323, 23);
			this.materialLabel1.TabIndex = 25;
			this.materialLabel1.Text = "Cantidad de Huéspedes según procedencia\r\n";
			// 
			// materialLabel2
			// 
			this.materialLabel2.Depth = 0;
			this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
			this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.materialLabel2.Location = new System.Drawing.Point(42, 313);
			this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialLabel2.Name = "materialLabel2";
			this.materialLabel2.Size = new System.Drawing.Size(126, 23);
			this.materialLabel2.TabIndex = 26;
			this.materialLabel2.Text = "Criterio de filtro";
			// 
			// materialRadioButton1
			// 
			this.materialRadioButton1.Depth = 0;
			this.materialRadioButton1.Font = new System.Drawing.Font("Roboto", 10F);
			this.materialRadioButton1.Location = new System.Drawing.Point(43, 337);
			this.materialRadioButton1.Margin = new System.Windows.Forms.Padding(0);
			this.materialRadioButton1.MouseLocation = new System.Drawing.Point(-1, -1);
			this.materialRadioButton1.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialRadioButton1.Name = "materialRadioButton1";
			this.materialRadioButton1.Ripple = true;
			this.materialRadioButton1.Size = new System.Drawing.Size(184, 30);
			this.materialRadioButton1.TabIndex = 27;
			this.materialRadioButton1.TabStop = true;
			this.materialRadioButton1.Text = "Histórico";
			this.materialRadioButton1.UseVisualStyleBackColor = true;
			// 
			// materialRadioButton2
			// 
			this.materialRadioButton2.Depth = 0;
			this.materialRadioButton2.Font = new System.Drawing.Font("Roboto", 10F);
			this.materialRadioButton2.Location = new System.Drawing.Point(43, 364);
			this.materialRadioButton2.Margin = new System.Windows.Forms.Padding(0);
			this.materialRadioButton2.MouseLocation = new System.Drawing.Point(-1, -1);
			this.materialRadioButton2.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialRadioButton2.Name = "materialRadioButton2";
			this.materialRadioButton2.Ripple = true;
			this.materialRadioButton2.Size = new System.Drawing.Size(184, 30);
			this.materialRadioButton2.TabIndex = 28;
			this.materialRadioButton2.TabStop = true;
			this.materialRadioButton2.Text = "Personalizado";
			this.materialRadioButton2.UseVisualStyleBackColor = true;
			// 
			// materialRadioButton4
			// 
			this.materialRadioButton4.Depth = 0;
			this.materialRadioButton4.Font = new System.Drawing.Font("Roboto", 10F);
			this.materialRadioButton4.Location = new System.Drawing.Point(43, 393);
			this.materialRadioButton4.Margin = new System.Windows.Forms.Padding(0);
			this.materialRadioButton4.MouseLocation = new System.Drawing.Point(-1, -1);
			this.materialRadioButton4.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialRadioButton4.Name = "materialRadioButton4";
			this.materialRadioButton4.Ripple = true;
			this.materialRadioButton4.Size = new System.Drawing.Size(184, 30);
			this.materialRadioButton4.TabIndex = 30;
			this.materialRadioButton4.TabStop = true;
			this.materialRadioButton4.Text = "Período";
			this.materialRadioButton4.UseVisualStyleBackColor = true;
			// 
			// combo_año
			// 
			this.combo_año.FormattingEnabled = true;
			this.combo_año.Location = new System.Drawing.Point(278, 370);
			this.combo_año.Name = "combo_año";
			this.combo_año.Size = new System.Drawing.Size(121, 21);
			this.combo_año.TabIndex = 31;
			// 
			// combo_mes
			// 
			this.combo_mes.FormattingEnabled = true;
			this.combo_mes.Items.AddRange(new object[] {
									"Enero",
									"Febrero",
									"Marzo",
									"Abril",
									"Mayo",
									"Junio",
									"Julio",
									"Agosto",
									"Septiembre",
									"Octubre",
									"Noviembre",
									"Diciembre"});
			this.combo_mes.Location = new System.Drawing.Point(278, 398);
			this.combo_mes.Name = "combo_mes";
			this.combo_mes.Size = new System.Drawing.Size(121, 21);
			this.combo_mes.TabIndex = 32;
			// 
			// materialCheckBox1
			// 
			this.materialCheckBox1.Depth = 0;
			this.materialCheckBox1.Font = new System.Drawing.Font("Roboto", 10F);
			this.materialCheckBox1.Location = new System.Drawing.Point(215, 369);
			this.materialCheckBox1.Margin = new System.Windows.Forms.Padding(0);
			this.materialCheckBox1.MouseLocation = new System.Drawing.Point(-1, -1);
			this.materialCheckBox1.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialCheckBox1.Name = "materialCheckBox1";
			this.materialCheckBox1.Ripple = true;
			this.materialCheckBox1.Size = new System.Drawing.Size(60, 24);
			this.materialCheckBox1.TabIndex = 33;
			this.materialCheckBox1.Text = "Año";
			this.materialCheckBox1.UseVisualStyleBackColor = true;
			// 
			// materialCheckBox2
			// 
			this.materialCheckBox2.Depth = 0;
			this.materialCheckBox2.Font = new System.Drawing.Font("Roboto", 10F);
			this.materialCheckBox2.Location = new System.Drawing.Point(215, 397);
			this.materialCheckBox2.Margin = new System.Windows.Forms.Padding(0);
			this.materialCheckBox2.MouseLocation = new System.Drawing.Point(-1, -1);
			this.materialCheckBox2.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialCheckBox2.Name = "materialCheckBox2";
			this.materialCheckBox2.Ripple = true;
			this.materialCheckBox2.Size = new System.Drawing.Size(60, 24);
			this.materialCheckBox2.TabIndex = 34;
			this.materialCheckBox2.Text = "Mes";
			this.materialCheckBox2.UseVisualStyleBackColor = true;
			// 
			// materialCheckBox3
			// 
			this.materialCheckBox3.Depth = 0;
			this.materialCheckBox3.Font = new System.Drawing.Font("Roboto", 10F);
			this.materialCheckBox3.Location = new System.Drawing.Point(215, 425);
			this.materialCheckBox3.Margin = new System.Windows.Forms.Padding(0);
			this.materialCheckBox3.MouseLocation = new System.Drawing.Point(-1, -1);
			this.materialCheckBox3.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialCheckBox3.Name = "materialCheckBox3";
			this.materialCheckBox3.Ripple = true;
			this.materialCheckBox3.Size = new System.Drawing.Size(60, 24);
			this.materialCheckBox3.TabIndex = 36;
			this.materialCheckBox3.Text = "Dia";
			this.materialCheckBox3.UseVisualStyleBackColor = true;
			// 
			// combo_dia
			// 
			this.combo_dia.FormattingEnabled = true;
			this.combo_dia.Location = new System.Drawing.Point(278, 426);
			this.combo_dia.Name = "combo_dia";
			this.combo_dia.Size = new System.Drawing.Size(121, 21);
			this.combo_dia.TabIndex = 35;
			// 
			// FormStats
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(725, 479);
			this.Controls.Add(this.materialCheckBox3);
			this.Controls.Add(this.combo_dia);
			this.Controls.Add(this.materialCheckBox2);
			this.Controls.Add(this.materialCheckBox1);
			this.Controls.Add(this.combo_mes);
			this.Controls.Add(this.combo_año);
			this.Controls.Add(this.materialRadioButton4);
			this.Controls.Add(this.materialRadioButton2);
			this.Controls.Add(this.materialRadioButton1);
			this.Controls.Add(this.materialLabel2);
			this.Controls.Add(this.materialLabel1);
			this.Controls.Add(this.pic);
			this.Controls.Add(this.pictureBox17);
			this.Controls.Add(this.pictureBox18);
			this.Controls.Add(this.pictureBox19);
			this.Controls.Add(this.pictureBox20);
			this.Controls.Add(this.pictureBox21);
			this.Controls.Add(this.pictureBox22);
			this.Controls.Add(this.pictureBox23);
			this.Controls.Add(this.pictureBox24);
			this.Controls.Add(this.pictureBox9);
			this.Controls.Add(this.pictureBox10);
			this.Controls.Add(this.pictureBox11);
			this.Controls.Add(this.pictureBox12);
			this.Controls.Add(this.pictureBox13);
			this.Controls.Add(this.pictureBox14);
			this.Controls.Add(this.pictureBox15);
			this.Controls.Add(this.pictureBox16);
			this.Controls.Add(this.pictureBox5);
			this.Controls.Add(this.pictureBox6);
			this.Controls.Add(this.pictureBox7);
			this.Controls.Add(this.pictureBox8);
			this.Controls.Add(this.pictureBox3);
			this.Controls.Add(this.pictureBox4);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.pictureBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FormStats";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.FormStatsLoad);
			((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox18)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox19)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox20)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox21)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox22)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox23)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox24)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.ComboBox combo_dia;
		private MaterialSkin.Controls.MaterialCheckBox materialCheckBox3;
		private MaterialSkin.Controls.MaterialCheckBox materialCheckBox2;
		private MaterialSkin.Controls.MaterialCheckBox materialCheckBox1;
		private System.Windows.Forms.ComboBox combo_mes;
		private System.Windows.Forms.ComboBox combo_año;
		private MaterialSkin.Controls.MaterialRadioButton materialRadioButton4;
		private MaterialSkin.Controls.MaterialRadioButton materialRadioButton2;
		private MaterialSkin.Controls.MaterialRadioButton materialRadioButton1;
		private MaterialSkin.Controls.MaterialLabel materialLabel2;
		private MaterialSkin.Controls.MaterialLabel materialLabel1;
		private System.Windows.Forms.PictureBox pictureBox17;
		private System.Windows.Forms.PictureBox pictureBox24;
		private System.Windows.Forms.PictureBox pictureBox23;
		private System.Windows.Forms.PictureBox pictureBox22;
		private System.Windows.Forms.PictureBox pictureBox21;
		private System.Windows.Forms.PictureBox pictureBox20;
		private System.Windows.Forms.PictureBox pictureBox19;
		private System.Windows.Forms.PictureBox pictureBox18;
		private System.Windows.Forms.PictureBox pictureBox16;
		private System.Windows.Forms.PictureBox pictureBox15;
		private System.Windows.Forms.PictureBox pictureBox14;
		private System.Windows.Forms.PictureBox pictureBox13;
		private System.Windows.Forms.PictureBox pictureBox12;
		private System.Windows.Forms.PictureBox pictureBox11;
		private System.Windows.Forms.PictureBox pictureBox10;
		private System.Windows.Forms.PictureBox pictureBox9;
		private System.Windows.Forms.PictureBox pictureBox8;
		private System.Windows.Forms.PictureBox pictureBox7;
		private System.Windows.Forms.PictureBox pictureBox6;
		private System.Windows.Forms.PictureBox pictureBox5;
		private System.Windows.Forms.PictureBox pictureBox4;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.PictureBox pic;
	}
}
