/*
 * Created by SharpDevelop.
 * User: lujan
 * Date: 4/9/2018
 * Time: 08:35
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Program.Forms
{
	partial class FormAddUser
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
		  this.label_nombre = new MaterialSkin.Controls.MaterialLabel();
		  this.text_apellido = new MaterialSkin.Controls.MaterialSingleLineTextField();
		  this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
		  this.check_operadores = new MaterialSkin.Controls.MaterialCheckBox();
		  this.check_social = new MaterialSkin.Controls.MaterialCheckBox();
		  this.check_seguridad = new MaterialSkin.Controls.MaterialCheckBox();
		  this.check_mantenimiento = new MaterialSkin.Controls.MaterialCheckBox();
		  this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
		  this.text_usuario = new MaterialSkin.Controls.MaterialSingleLineTextField();
		  this.text_nombre = new MaterialSkin.Controls.MaterialSingleLineTextField();
		  this.Button_añadir = new MaterialSkin.Controls.MaterialFlatButton();
		  this.radio_leerOp = new MaterialSkin.Controls.MaterialRadioButton();
		  this.radio_leerEscOp = new MaterialSkin.Controls.MaterialRadioButton();
		  this.radio_leerSeg = new MaterialSkin.Controls.MaterialRadioButton();
		  this.radio_leerEscSeg = new MaterialSkin.Controls.MaterialRadioButton();
		  this.panel1 = new System.Windows.Forms.Panel();
		  this.radio_leerSo = new MaterialSkin.Controls.MaterialRadioButton();
		  this.radio_leerEscSo = new MaterialSkin.Controls.MaterialRadioButton();
		  this.panel2 = new System.Windows.Forms.Panel();
		  this.radio_leerMan = new MaterialSkin.Controls.MaterialRadioButton();
		  this.radio_leerEscMan = new MaterialSkin.Controls.MaterialRadioButton();
		  this.panel3 = new System.Windows.Forms.Panel();
		  this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
		  this.radio_admin = new MaterialSkin.Controls.MaterialRadioButton();
		  this.radio_operador = new MaterialSkin.Controls.MaterialRadioButton();
		  this.panel4 = new System.Windows.Forms.Panel();
		  this.radio_invitado = new MaterialSkin.Controls.MaterialRadioButton();
		  this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
		  this.panel1.SuspendLayout();
		  this.panel2.SuspendLayout();
		  this.panel3.SuspendLayout();
		  this.panel4.SuspendLayout();
		  this.SuspendLayout();
		  // 
		  // label_nombre
		  // 
		  this.label_nombre.Depth = 0;
		  this.label_nombre.Font = new System.Drawing.Font("Roboto", 11F);
		  this.label_nombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
		  this.label_nombre.Location = new System.Drawing.Point(52, 115);
		  this.label_nombre.MouseState = MaterialSkin.MouseState.HOVER;
		  this.label_nombre.Name = "label_nombre";
		  this.label_nombre.Size = new System.Drawing.Size(215, 23);
		  this.label_nombre.TabIndex = 4;
		  this.label_nombre.Text = "Nombre";
		  // 
		  // text_apellido
		  // 
		  this.text_apellido.BackColor = System.Drawing.SystemColors.Control;
		  this.text_apellido.Depth = 0;
		  this.text_apellido.Hint = "Ingrese el apellido";
		  this.text_apellido.Location = new System.Drawing.Point(57, 208);
		  this.text_apellido.MaxLength = 32767;
		  this.text_apellido.MouseState = MaterialSkin.MouseState.HOVER;
		  this.text_apellido.Name = "text_apellido";
		  this.text_apellido.PasswordChar = '\0';
		  this.text_apellido.SelectedText = "";
		  this.text_apellido.SelectionLength = 0;
		  this.text_apellido.SelectionStart = 0;
		  this.text_apellido.Size = new System.Drawing.Size(198, 23);
		  this.text_apellido.TabIndex = 2;
		  this.text_apellido.TabStop = false;
		  this.text_apellido.UseSystemPasswordChar = false;
		  this.text_apellido.TextChanged += new System.EventHandler(this.Text_apellidoTextChanged);
		  // 
		  // materialLabel1
		  // 
		  this.materialLabel1.Depth = 0;
		  this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
		  this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
		  this.materialLabel1.Location = new System.Drawing.Point(52, 182);
		  this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
		  this.materialLabel1.Name = "materialLabel1";
		  this.materialLabel1.Size = new System.Drawing.Size(215, 23);
		  this.materialLabel1.TabIndex = 6;
		  this.materialLabel1.Text = "Apellido";
		  // 
		  // check_operadores
		  // 
		  this.check_operadores.Depth = 0;
		  this.check_operadores.Font = new System.Drawing.Font("Roboto", 10F);
		  this.check_operadores.Location = new System.Drawing.Point(57, 282);
		  this.check_operadores.Margin = new System.Windows.Forms.Padding(0);
		  this.check_operadores.MouseLocation = new System.Drawing.Point(-1, -1);
		  this.check_operadores.MouseState = MaterialSkin.MouseState.HOVER;
		  this.check_operadores.Name = "check_operadores";
		  this.check_operadores.Ripple = true;
		  this.check_operadores.Size = new System.Drawing.Size(104, 24);
		  this.check_operadores.TabIndex = 3;
		  this.check_operadores.Text = "Operadores";
		  this.check_operadores.UseVisualStyleBackColor = true;
		  this.check_operadores.CheckedChanged += new System.EventHandler(this.MaterialCheckBox1CheckedChanged);
		  // 
		  // check_social
		  // 
		  this.check_social.Depth = 0;
		  this.check_social.Font = new System.Drawing.Font("Roboto", 10F);
		  this.check_social.Location = new System.Drawing.Point(57, 354);
		  this.check_social.Margin = new System.Windows.Forms.Padding(0);
		  this.check_social.MouseLocation = new System.Drawing.Point(-1, -1);
		  this.check_social.MouseState = MaterialSkin.MouseState.HOVER;
		  this.check_social.Name = "check_social";
		  this.check_social.Ripple = true;
		  this.check_social.Size = new System.Drawing.Size(104, 24);
		  this.check_social.TabIndex = 9;
		  this.check_social.Text = "Social";
		  this.check_social.UseVisualStyleBackColor = true;
		  this.check_social.CheckedChanged += new System.EventHandler(this.Check_socialCheckedChanged);
		  // 
		  // check_seguridad
		  // 
		  this.check_seguridad.Depth = 0;
		  this.check_seguridad.Font = new System.Drawing.Font("Roboto", 10F);
		  this.check_seguridad.Location = new System.Drawing.Point(57, 317);
		  this.check_seguridad.Margin = new System.Windows.Forms.Padding(0);
		  this.check_seguridad.MouseLocation = new System.Drawing.Point(-1, -1);
		  this.check_seguridad.MouseState = MaterialSkin.MouseState.HOVER;
		  this.check_seguridad.Name = "check_seguridad";
		  this.check_seguridad.Ripple = true;
		  this.check_seguridad.Size = new System.Drawing.Size(104, 24);
		  this.check_seguridad.TabIndex = 10;
		  this.check_seguridad.Text = "Seguridad";
		  this.check_seguridad.UseVisualStyleBackColor = true;
		  this.check_seguridad.CheckedChanged += new System.EventHandler(this.Check_seguridadCheckedChanged);
		  // 
		  // check_mantenimiento
		  // 
		  this.check_mantenimiento.Depth = 0;
		  this.check_mantenimiento.Font = new System.Drawing.Font("Roboto", 10F);
		  this.check_mantenimiento.Location = new System.Drawing.Point(54, 388);
		  this.check_mantenimiento.Margin = new System.Windows.Forms.Padding(0);
		  this.check_mantenimiento.MouseLocation = new System.Drawing.Point(-1, -1);
		  this.check_mantenimiento.MouseState = MaterialSkin.MouseState.HOVER;
		  this.check_mantenimiento.Name = "check_mantenimiento";
		  this.check_mantenimiento.Ripple = true;
		  this.check_mantenimiento.Size = new System.Drawing.Size(135, 24);
		  this.check_mantenimiento.TabIndex = 11;
		  this.check_mantenimiento.Text = "Mantenimiento";
		  this.check_mantenimiento.UseVisualStyleBackColor = true;
		  this.check_mantenimiento.CheckedChanged += new System.EventHandler(this.Check_mantenimientoCheckedChanged);
		  // 
		  // materialLabel2
		  // 
		  this.materialLabel2.Depth = 0;
		  this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
		  this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
		  this.materialLabel2.Location = new System.Drawing.Point(488, 115);
		  this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
		  this.materialLabel2.Name = "materialLabel2";
		  this.materialLabel2.Size = new System.Drawing.Size(215, 23);
		  this.materialLabel2.TabIndex = 12;
		  this.materialLabel2.Text = "Nombre de Usuario:";
		  // 
		  // text_usuario
		  // 
		  this.text_usuario.BackColor = System.Drawing.SystemColors.Control;
		  this.text_usuario.Depth = 0;
		  this.text_usuario.Enabled = false;
		  this.text_usuario.Hint = "Nombre_Apellido";
		  this.text_usuario.Location = new System.Drawing.Point(493, 144);
		  this.text_usuario.MaxLength = 32767;
		  this.text_usuario.MouseState = MaterialSkin.MouseState.HOVER;
		  this.text_usuario.Name = "text_usuario";
		  this.text_usuario.PasswordChar = '\0';
		  this.text_usuario.SelectedText = "";
		  this.text_usuario.SelectionLength = 0;
		  this.text_usuario.SelectionStart = 0;
		  this.text_usuario.Size = new System.Drawing.Size(198, 23);
		  this.text_usuario.TabIndex = 13;
		  this.text_usuario.TabStop = false;
		  this.text_usuario.UseSystemPasswordChar = false;
		  // 
		  // text_nombre
		  // 
		  this.text_nombre.BackColor = System.Drawing.SystemColors.Control;
		  this.text_nombre.Depth = 0;
		  this.text_nombre.Hint = "Ingrese el nombre";
		  this.text_nombre.Location = new System.Drawing.Point(57, 144);
		  this.text_nombre.MaxLength = 32767;
		  this.text_nombre.MouseState = MaterialSkin.MouseState.HOVER;
		  this.text_nombre.Name = "text_nombre";
		  this.text_nombre.PasswordChar = '\0';
		  this.text_nombre.SelectedText = "";
		  this.text_nombre.SelectionLength = 0;
		  this.text_nombre.SelectionStart = 0;
		  this.text_nombre.Size = new System.Drawing.Size(198, 23);
		  this.text_nombre.TabIndex = 1;
		  this.text_nombre.TabStop = false;
		  this.text_nombre.UseSystemPasswordChar = false;
		  this.text_nombre.TextChanged += new System.EventHandler(this.Text_nombreTextChanged);
		  // 
		  // Button_añadir
		  // 
		  this.Button_añadir.AutoSize = true;
		  this.Button_añadir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
		  this.Button_añadir.Depth = 0;
		  this.Button_añadir.Icon = null;
		  this.Button_añadir.Location = new System.Drawing.Point(613, 457);
		  this.Button_añadir.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
		  this.Button_añadir.MouseState = MaterialSkin.MouseState.HOVER;
		  this.Button_añadir.Name = "Button_añadir";
		  this.Button_añadir.Primary = false;
		  this.Button_añadir.selected = false;
		  this.Button_añadir.Size = new System.Drawing.Size(73, 36);
		  this.Button_añadir.TabIndex = 23;
		  this.Button_añadir.Text = "Cerrar";
		  this.Button_añadir.UseVisualStyleBackColor = true;
		  this.Button_añadir.Click += new System.EventHandler(this.MaterialFlatButton1Click);
		  // 
		  // radio_leerOp
		  // 
		  this.radio_leerOp.Depth = 0;
		  this.radio_leerOp.Font = new System.Drawing.Font("Roboto", 10F);
		  this.radio_leerOp.Location = new System.Drawing.Point(207, 282);
		  this.radio_leerOp.Margin = new System.Windows.Forms.Padding(0);
		  this.radio_leerOp.MouseLocation = new System.Drawing.Point(-1, -1);
		  this.radio_leerOp.MouseState = MaterialSkin.MouseState.HOVER;
		  this.radio_leerOp.Name = "radio_leerOp";
		  this.radio_leerOp.Ripple = true;
		  this.radio_leerOp.Size = new System.Drawing.Size(104, 24);
		  this.radio_leerOp.TabIndex = 15;
		  this.radio_leerOp.TabStop = true;
		  this.radio_leerOp.Text = "Leer";
		  this.radio_leerOp.UseVisualStyleBackColor = true;
		  // 
		  // radio_leerEscOp
		  // 
		  this.radio_leerEscOp.Depth = 0;
		  this.radio_leerEscOp.Font = new System.Drawing.Font("Roboto", 10F);
		  this.radio_leerEscOp.Location = new System.Drawing.Point(278, 281);
		  this.radio_leerEscOp.Margin = new System.Windows.Forms.Padding(0);
		  this.radio_leerEscOp.MouseLocation = new System.Drawing.Point(-1, -1);
		  this.radio_leerEscOp.MouseState = MaterialSkin.MouseState.HOVER;
		  this.radio_leerEscOp.Name = "radio_leerEscOp";
		  this.radio_leerEscOp.Ripple = true;
		  this.radio_leerEscOp.Size = new System.Drawing.Size(114, 24);
		  this.radio_leerEscOp.TabIndex = 16;
		  this.radio_leerEscOp.TabStop = true;
		  this.radio_leerEscOp.Text = "Leer/Escribir";
		  this.radio_leerEscOp.UseVisualStyleBackColor = true;
		  this.radio_leerEscOp.CheckedChanged += new System.EventHandler(this.MaterialRadioButton2CheckedChanged);
		  // 
		  // radio_leerSeg
		  // 
		  this.radio_leerSeg.Depth = 0;
		  this.radio_leerSeg.Font = new System.Drawing.Font("Roboto", 10F);
		  this.radio_leerSeg.Location = new System.Drawing.Point(15, 0);
		  this.radio_leerSeg.Margin = new System.Windows.Forms.Padding(0);
		  this.radio_leerSeg.MouseLocation = new System.Drawing.Point(-1, -1);
		  this.radio_leerSeg.MouseState = MaterialSkin.MouseState.HOVER;
		  this.radio_leerSeg.Name = "radio_leerSeg";
		  this.radio_leerSeg.Ripple = true;
		  this.radio_leerSeg.Size = new System.Drawing.Size(104, 24);
		  this.radio_leerSeg.TabIndex = 24;
		  this.radio_leerSeg.TabStop = true;
		  this.radio_leerSeg.Text = "Leer";
		  this.radio_leerSeg.UseVisualStyleBackColor = true;
		  // 
		  // radio_leerEscSeg
		  // 
		  this.radio_leerEscSeg.Depth = 0;
		  this.radio_leerEscSeg.Font = new System.Drawing.Font("Roboto", 10F);
		  this.radio_leerEscSeg.Location = new System.Drawing.Point(88, 0);
		  this.radio_leerEscSeg.Margin = new System.Windows.Forms.Padding(0);
		  this.radio_leerEscSeg.MouseLocation = new System.Drawing.Point(-1, -1);
		  this.radio_leerEscSeg.MouseState = MaterialSkin.MouseState.HOVER;
		  this.radio_leerEscSeg.Name = "radio_leerEscSeg";
		  this.radio_leerEscSeg.Ripple = true;
		  this.radio_leerEscSeg.Size = new System.Drawing.Size(104, 24);
		  this.radio_leerEscSeg.TabIndex = 25;
		  this.radio_leerEscSeg.TabStop = true;
		  this.radio_leerEscSeg.Text = "Leer/Escribir";
		  this.radio_leerEscSeg.UseVisualStyleBackColor = true;
		  // 
		  // panel1
		  // 
		  this.panel1.Controls.Add(this.radio_leerEscSeg);
		  this.panel1.Controls.Add(this.radio_leerSeg);
		  this.panel1.Location = new System.Drawing.Point(192, 317);
		  this.panel1.Name = "panel1";
		  this.panel1.Size = new System.Drawing.Size(200, 24);
		  this.panel1.TabIndex = 27;
		  // 
		  // radio_leerSo
		  // 
		  this.radio_leerSo.Depth = 0;
		  this.radio_leerSo.Font = new System.Drawing.Font("Roboto", 10F);
		  this.radio_leerSo.Location = new System.Drawing.Point(0, 10);
		  this.radio_leerSo.Margin = new System.Windows.Forms.Padding(0);
		  this.radio_leerSo.MouseLocation = new System.Drawing.Point(-1, -1);
		  this.radio_leerSo.MouseState = MaterialSkin.MouseState.HOVER;
		  this.radio_leerSo.Name = "radio_leerSo";
		  this.radio_leerSo.Ripple = true;
		  this.radio_leerSo.Size = new System.Drawing.Size(104, 24);
		  this.radio_leerSo.TabIndex = 19;
		  this.radio_leerSo.TabStop = true;
		  this.radio_leerSo.Text = "Leer";
		  this.radio_leerSo.UseVisualStyleBackColor = true;
		  // 
		  // radio_leerEscSo
		  // 
		  this.radio_leerEscSo.Depth = 0;
		  this.radio_leerEscSo.Font = new System.Drawing.Font("Roboto", 10F);
		  this.radio_leerEscSo.Location = new System.Drawing.Point(71, 8);
		  this.radio_leerEscSo.Margin = new System.Windows.Forms.Padding(0);
		  this.radio_leerEscSo.MouseLocation = new System.Drawing.Point(-1, -1);
		  this.radio_leerEscSo.MouseState = MaterialSkin.MouseState.HOVER;
		  this.radio_leerEscSo.Name = "radio_leerEscSo";
		  this.radio_leerEscSo.Ripple = true;
		  this.radio_leerEscSo.Size = new System.Drawing.Size(114, 24);
		  this.radio_leerEscSo.TabIndex = 20;
		  this.radio_leerEscSo.TabStop = true;
		  this.radio_leerEscSo.Text = "Leer/Escribir";
		  this.radio_leerEscSo.UseVisualStyleBackColor = true;
		  // 
		  // panel2
		  // 
		  this.panel2.Controls.Add(this.radio_leerEscSo);
		  this.panel2.Controls.Add(this.radio_leerSo);
		  this.panel2.Location = new System.Drawing.Point(207, 344);
		  this.panel2.Name = "panel2";
		  this.panel2.Size = new System.Drawing.Size(200, 31);
		  this.panel2.TabIndex = 28;
		  // 
		  // radio_leerMan
		  // 
		  this.radio_leerMan.Depth = 0;
		  this.radio_leerMan.Font = new System.Drawing.Font("Roboto", 10F);
		  this.radio_leerMan.Location = new System.Drawing.Point(0, 0);
		  this.radio_leerMan.Margin = new System.Windows.Forms.Padding(0);
		  this.radio_leerMan.MouseLocation = new System.Drawing.Point(-1, -1);
		  this.radio_leerMan.MouseState = MaterialSkin.MouseState.HOVER;
		  this.radio_leerMan.Name = "radio_leerMan";
		  this.radio_leerMan.Ripple = true;
		  this.radio_leerMan.Size = new System.Drawing.Size(104, 24);
		  this.radio_leerMan.TabIndex = 21;
		  this.radio_leerMan.TabStop = true;
		  this.radio_leerMan.Text = "Leer";
		  this.radio_leerMan.UseVisualStyleBackColor = true;
		  // 
		  // radio_leerEscMan
		  // 
		  this.radio_leerEscMan.Depth = 0;
		  this.radio_leerEscMan.Font = new System.Drawing.Font("Roboto", 10F);
		  this.radio_leerEscMan.Location = new System.Drawing.Point(71, 0);
		  this.radio_leerEscMan.Margin = new System.Windows.Forms.Padding(0);
		  this.radio_leerEscMan.MouseLocation = new System.Drawing.Point(-1, -1);
		  this.radio_leerEscMan.MouseState = MaterialSkin.MouseState.HOVER;
		  this.radio_leerEscMan.Name = "radio_leerEscMan";
		  this.radio_leerEscMan.Ripple = true;
		  this.radio_leerEscMan.Size = new System.Drawing.Size(114, 24);
		  this.radio_leerEscMan.TabIndex = 22;
		  this.radio_leerEscMan.TabStop = true;
		  this.radio_leerEscMan.Text = "Leer/Escribir";
		  this.radio_leerEscMan.UseVisualStyleBackColor = true;
		  // 
		  // panel3
		  // 
		  this.panel3.Controls.Add(this.radio_leerEscMan);
		  this.panel3.Controls.Add(this.radio_leerMan);
		  this.panel3.Location = new System.Drawing.Point(207, 388);
		  this.panel3.Name = "panel3";
		  this.panel3.Size = new System.Drawing.Size(200, 28);
		  this.panel3.TabIndex = 29;
		  // 
		  // materialFlatButton1
		  // 
		  this.materialFlatButton1.AutoSize = true;
		  this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
		  this.materialFlatButton1.Depth = 0;
		  this.materialFlatButton1.Icon = null;
		  this.materialFlatButton1.Location = new System.Drawing.Point(526, 457);
		  this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
		  this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
		  this.materialFlatButton1.Name = "materialFlatButton1";
		  this.materialFlatButton1.Primary = false;
		  this.materialFlatButton1.selected = false;
		  this.materialFlatButton1.Size = new System.Drawing.Size(70, 36);
		  this.materialFlatButton1.TabIndex = 30;
		  this.materialFlatButton1.Text = "Añadir";
		  this.materialFlatButton1.UseVisualStyleBackColor = true;
		  // 
		  // radio_admin
		  // 
		  this.radio_admin.Depth = 0;
		  this.radio_admin.Font = new System.Drawing.Font("Roboto", 10F);
		  this.radio_admin.Location = new System.Drawing.Point(0, 0);
		  this.radio_admin.Margin = new System.Windows.Forms.Padding(0);
		  this.radio_admin.MouseLocation = new System.Drawing.Point(-1, -1);
		  this.radio_admin.MouseState = MaterialSkin.MouseState.HOVER;
		  this.radio_admin.Name = "radio_admin";
		  this.radio_admin.Ripple = true;
		  this.radio_admin.Size = new System.Drawing.Size(157, 24);
		  this.radio_admin.TabIndex = 31;
		  this.radio_admin.TabStop = true;
		  this.radio_admin.Text = "Administrador";
		  this.radio_admin.UseVisualStyleBackColor = true;
		  this.radio_admin.CheckedChanged += new System.EventHandler(this.Radio_adminCheckedChanged);
		  // 
		  // radio_operador
		  // 
		  this.radio_operador.Depth = 0;
		  this.radio_operador.Font = new System.Drawing.Font("Roboto", 10F);
		  this.radio_operador.Location = new System.Drawing.Point(157, 0);
		  this.radio_operador.Margin = new System.Windows.Forms.Padding(0);
		  this.radio_operador.MouseLocation = new System.Drawing.Point(-1, -1);
		  this.radio_operador.MouseState = MaterialSkin.MouseState.HOVER;
		  this.radio_operador.Name = "radio_operador";
		  this.radio_operador.Ripple = true;
		  this.radio_operador.Size = new System.Drawing.Size(157, 24);
		  this.radio_operador.TabIndex = 33;
		  this.radio_operador.TabStop = true;
		  this.radio_operador.Text = "Operador";
		  this.radio_operador.UseVisualStyleBackColor = true;
		  this.radio_operador.CheckedChanged += new System.EventHandler(this.Radio_operadorCheckedChanged);
		  // 
		  // panel4
		  // 
		  this.panel4.Controls.Add(this.radio_invitado);
		  this.panel4.Controls.Add(this.radio_admin);
		  this.panel4.Controls.Add(this.radio_operador);
		  this.panel4.Location = new System.Drawing.Point(149, 52);
		  this.panel4.Name = "panel4";
		  this.panel4.Size = new System.Drawing.Size(422, 26);
		  this.panel4.TabIndex = 34;
		  // 
		  // radio_invitado
		  // 
		  this.radio_invitado.Depth = 0;
		  this.radio_invitado.Font = new System.Drawing.Font("Roboto", 10F);
		  this.radio_invitado.Location = new System.Drawing.Point(314, 0);
		  this.radio_invitado.Margin = new System.Windows.Forms.Padding(0);
		  this.radio_invitado.MouseLocation = new System.Drawing.Point(-1, -1);
		  this.radio_invitado.MouseState = MaterialSkin.MouseState.HOVER;
		  this.radio_invitado.Name = "radio_invitado";
		  this.radio_invitado.Ripple = true;
		  this.radio_invitado.Size = new System.Drawing.Size(94, 24);
		  this.radio_invitado.TabIndex = 34;
		  this.radio_invitado.TabStop = true;
		  this.radio_invitado.Text = "Invitado";
		  this.radio_invitado.UseVisualStyleBackColor = true;
		  this.radio_invitado.CheckedChanged += new System.EventHandler(this.Radio_invitadoCheckedChanged);
		  // 
		  // materialLabel3
		  // 
		  this.materialLabel3.Depth = 0;
		  this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
		  this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
		  this.materialLabel3.Location = new System.Drawing.Point(149, 23);
		  this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
		  this.materialLabel3.Name = "materialLabel3";
		  this.materialLabel3.Size = new System.Drawing.Size(215, 23);
		  this.materialLabel3.TabIndex = 35;
		  this.materialLabel3.Text = "Tipo de usuario";
		  // 
		  // FormAddUser
		  // 
		  this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
		  this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		  this.BackColor = System.Drawing.Color.White;
		  this.ClientSize = new System.Drawing.Size(741, 518);
		  this.Controls.Add(this.materialLabel3);
		  this.Controls.Add(this.panel4);
		  this.Controls.Add(this.materialFlatButton1);
		  this.Controls.Add(this.panel3);
		  this.Controls.Add(this.panel2);
		  this.Controls.Add(this.panel1);
		  this.Controls.Add(this.Button_añadir);
		  this.Controls.Add(this.radio_leerEscOp);
		  this.Controls.Add(this.radio_leerOp);
		  this.Controls.Add(this.text_nombre);
		  this.Controls.Add(this.text_usuario);
		  this.Controls.Add(this.materialLabel2);
		  this.Controls.Add(this.check_mantenimiento);
		  this.Controls.Add(this.check_seguridad);
		  this.Controls.Add(this.check_social);
		  this.Controls.Add(this.check_operadores);
		  this.Controls.Add(this.text_apellido);
		  this.Controls.Add(this.materialLabel1);
		  this.Controls.Add(this.label_nombre);
		  this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		  this.Name = "FormAddUser";
		  this.Text = "Form1";
		  this.Load += new System.EventHandler(this.Form1Load);
		  this.panel1.ResumeLayout(false);
		  this.panel2.ResumeLayout(false);
		  this.panel3.ResumeLayout(false);
		  this.panel4.ResumeLayout(false);
		  this.ResumeLayout(false);
		  this.PerformLayout();
		}
		private MaterialSkin.Controls.MaterialLabel materialLabel3;
		private MaterialSkin.Controls.MaterialRadioButton radio_invitado;
		private System.Windows.Forms.Panel panel4;
		private MaterialSkin.Controls.MaterialRadioButton radio_operador;
		private MaterialSkin.Controls.MaterialRadioButton radio_admin;
		private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel1;
		private MaterialSkin.Controls.MaterialFlatButton Button_añadir;
		private MaterialSkin.Controls.MaterialRadioButton radio_leerMan;
		private MaterialSkin.Controls.MaterialRadioButton radio_leerEscMan;
		private MaterialSkin.Controls.MaterialRadioButton radio_leerSo;
		private MaterialSkin.Controls.MaterialRadioButton radio_leerEscSo;
		private MaterialSkin.Controls.MaterialRadioButton radio_leerSeg;
		private MaterialSkin.Controls.MaterialRadioButton radio_leerEscSeg;
		private MaterialSkin.Controls.MaterialRadioButton radio_leerEscOp;
		private MaterialSkin.Controls.MaterialRadioButton radio_leerOp;
		private MaterialSkin.Controls.MaterialSingleLineTextField text_usuario;
		private MaterialSkin.Controls.MaterialLabel materialLabel2;
		private MaterialSkin.Controls.MaterialCheckBox check_mantenimiento;
		private MaterialSkin.Controls.MaterialCheckBox check_seguridad;
		private MaterialSkin.Controls.MaterialCheckBox check_social;
		private MaterialSkin.Controls.MaterialCheckBox check_operadores;
		private MaterialSkin.Controls.MaterialLabel materialLabel1;
		private MaterialSkin.Controls.MaterialSingleLineTextField text_apellido;
		private MaterialSkin.Controls.MaterialLabel label_nombre;
		private MaterialSkin.Controls.MaterialSingleLineTextField text_nombre;
		
	}
}
