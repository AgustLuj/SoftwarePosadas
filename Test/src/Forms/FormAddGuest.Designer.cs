﻿/*
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
			this.picture = new System.Windows.Forms.PictureBox();
			this.label_nombre = new MaterialSkin.Controls.MaterialLabel();
			this.text_nombre = new MaterialSkin.Controls.MaterialSingleLineTextField();
			this.text_apellido = new MaterialSkin.Controls.MaterialSingleLineTextField();
			this.label_apellido = new MaterialSkin.Controls.MaterialLabel();
			this.check_paciente = new MaterialSkin.Controls.MaterialCheckBox();
			this.label_habitacion = new MaterialSkin.Controls.MaterialLabel();
			this.text_habitacion = new MaterialSkin.Controls.MaterialSingleLineTextField();
			this.label_locker = new MaterialSkin.Controls.MaterialLabel();
			this.text_locker = new MaterialSkin.Controls.MaterialSingleLineTextField();
			this.label_ingreso = new MaterialSkin.Controls.MaterialLabel();
			this.text_fecha = new MaterialSkin.Controls.MaterialSingleLineTextField();
			this.check_hoy = new MaterialSkin.Controls.MaterialCheckBox();
			this.combo_servicio = new System.Windows.Forms.ComboBox();
			this.label_servicio = new MaterialSkin.Controls.MaterialLabel();
			this.label_pais = new MaterialSkin.Controls.MaterialLabel();
			this.label_provincia = new MaterialSkin.Controls.MaterialLabel();
			this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
			this.text_localidad = new MaterialSkin.Controls.MaterialSingleLineTextField();
			this.combo_pais = new System.Windows.Forms.ComboBox();
			this.combo_provincia = new System.Windows.Forms.ComboBox();
			this.text_provincia = new MaterialSkin.Controls.MaterialSingleLineTextField();
			this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
			this.materialFlatButton2 = new MaterialSkin.Controls.MaterialFlatButton();
			this.combo_localidad = new System.Windows.Forms.ComboBox();
			this.label_error = new MaterialSkin.Controls.MaterialLabel();
			this.materialFlatButton3 = new MaterialSkin.Controls.MaterialFlatButton();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
			this.SuspendLayout();
			// 
			// picture
			// 
			this.picture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.picture.Location = new System.Drawing.Point(506, 27);
			this.picture.Name = "picture";
			this.picture.Size = new System.Drawing.Size(210, 210);
			this.picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.picture.TabIndex = 0;
			this.picture.TabStop = false;
			// 
			// label_nombre
			// 
			this.label_nombre.Depth = 0;
			this.label_nombre.Font = new System.Drawing.Font("Roboto", 11F);
			this.label_nombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.label_nombre.Location = new System.Drawing.Point(25, 27);
			this.label_nombre.MouseState = MaterialSkin.MouseState.HOVER;
			this.label_nombre.Name = "label_nombre";
			this.label_nombre.Size = new System.Drawing.Size(100, 23);
			this.label_nombre.TabIndex = 1;
			this.label_nombre.Text = "Nombre";
			// 
			// text_nombre
			// 
			this.text_nombre.BackColor = System.Drawing.SystemColors.Control;
			this.text_nombre.Depth = 0;
			this.text_nombre.Hint = "Ingrese el nombre";
			this.text_nombre.Location = new System.Drawing.Point(30, 53);
			this.text_nombre.MaxLength = 32767;
			this.text_nombre.MouseState = MaterialSkin.MouseState.HOVER;
			this.text_nombre.Name = "text_nombre";
			this.text_nombre.PasswordChar = '\0';
			this.text_nombre.SelectedText = "";
			this.text_nombre.SelectionLength = 0;
			this.text_nombre.SelectionStart = 0;
			this.text_nombre.Size = new System.Drawing.Size(198, 23);
			this.text_nombre.TabIndex = 2;
			this.text_nombre.TabStop = false;
			this.text_nombre.UseSystemPasswordChar = false;
			// 
			// text_apellido
			// 
			this.text_apellido.BackColor = System.Drawing.SystemColors.Control;
			this.text_apellido.Depth = 0;
			this.text_apellido.Hint = "Ingrese el apellido";
			this.text_apellido.Location = new System.Drawing.Point(30, 126);
			this.text_apellido.MaxLength = 32767;
			this.text_apellido.MouseState = MaterialSkin.MouseState.HOVER;
			this.text_apellido.Name = "text_apellido";
			this.text_apellido.PasswordChar = '\0';
			this.text_apellido.SelectedText = "";
			this.text_apellido.SelectionLength = 0;
			this.text_apellido.SelectionStart = 0;
			this.text_apellido.Size = new System.Drawing.Size(198, 23);
			this.text_apellido.TabIndex = 3;
			this.text_apellido.TabStop = false;
			this.text_apellido.UseSystemPasswordChar = false;
			// 
			// label_apellido
			// 
			this.label_apellido.Depth = 0;
			this.label_apellido.Font = new System.Drawing.Font("Roboto", 11F);
			this.label_apellido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.label_apellido.Location = new System.Drawing.Point(25, 98);
			this.label_apellido.MouseState = MaterialSkin.MouseState.HOVER;
			this.label_apellido.Name = "label_apellido";
			this.label_apellido.Size = new System.Drawing.Size(100, 23);
			this.label_apellido.TabIndex = 4;
			this.label_apellido.Text = "Apellido";
			// 
			// check_paciente
			// 
			this.check_paciente.Depth = 0;
			this.check_paciente.Font = new System.Drawing.Font("Roboto", 10F);
			this.check_paciente.Location = new System.Drawing.Point(507, 296);
			this.check_paciente.Margin = new System.Windows.Forms.Padding(0);
			this.check_paciente.MouseLocation = new System.Drawing.Point(-1, -1);
			this.check_paciente.MouseState = MaterialSkin.MouseState.HOVER;
			this.check_paciente.Name = "check_paciente";
			this.check_paciente.Ripple = true;
			this.check_paciente.Size = new System.Drawing.Size(178, 24);
			this.check_paciente.TabIndex = 10;
			this.check_paciente.Text = "Paciente del Hospital";
			this.check_paciente.UseVisualStyleBackColor = true;
			this.check_paciente.CheckedChanged += new System.EventHandler(this.Check_pacienteCheckedChanged);
			// 
			// label_habitacion
			// 
			this.label_habitacion.Depth = 0;
			this.label_habitacion.Font = new System.Drawing.Font("Roboto", 11F);
			this.label_habitacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.label_habitacion.Location = new System.Drawing.Point(278, 27);
			this.label_habitacion.MouseState = MaterialSkin.MouseState.HOVER;
			this.label_habitacion.Name = "label_habitacion";
			this.label_habitacion.Size = new System.Drawing.Size(109, 23);
			this.label_habitacion.TabIndex = 12;
			this.label_habitacion.Text = "Habitación";
			// 
			// text_habitacion
			// 
			this.text_habitacion.BackColor = System.Drawing.SystemColors.Control;
			this.text_habitacion.Depth = 0;
			this.text_habitacion.Hint = "";
			this.text_habitacion.Location = new System.Drawing.Point(283, 53);
			this.text_habitacion.MaxLength = 32767;
			this.text_habitacion.MouseState = MaterialSkin.MouseState.HOVER;
			this.text_habitacion.Name = "text_habitacion";
			this.text_habitacion.PasswordChar = '\0';
			this.text_habitacion.SelectedText = "";
			this.text_habitacion.SelectionLength = 0;
			this.text_habitacion.SelectionStart = 0;
			this.text_habitacion.Size = new System.Drawing.Size(132, 23);
			this.text_habitacion.TabIndex = 11;
			this.text_habitacion.TabStop = false;
			this.text_habitacion.UseSystemPasswordChar = false;
			// 
			// label_locker
			// 
			this.label_locker.Depth = 0;
			this.label_locker.Font = new System.Drawing.Font("Roboto", 11F);
			this.label_locker.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.label_locker.Location = new System.Drawing.Point(278, 98);
			this.label_locker.MouseState = MaterialSkin.MouseState.HOVER;
			this.label_locker.Name = "label_locker";
			this.label_locker.Size = new System.Drawing.Size(109, 23);
			this.label_locker.TabIndex = 14;
			this.label_locker.Text = "Locker";
			// 
			// text_locker
			// 
			this.text_locker.BackColor = System.Drawing.SystemColors.Control;
			this.text_locker.Depth = 0;
			this.text_locker.Hint = "";
			this.text_locker.Location = new System.Drawing.Point(283, 125);
			this.text_locker.MaxLength = 32767;
			this.text_locker.MouseState = MaterialSkin.MouseState.HOVER;
			this.text_locker.Name = "text_locker";
			this.text_locker.PasswordChar = '\0';
			this.text_locker.SelectedText = "";
			this.text_locker.SelectionLength = 0;
			this.text_locker.SelectionStart = 0;
			this.text_locker.Size = new System.Drawing.Size(132, 23);
			this.text_locker.TabIndex = 13;
			this.text_locker.TabStop = false;
			this.text_locker.UseSystemPasswordChar = false;
			// 
			// label_ingreso
			// 
			this.label_ingreso.Depth = 0;
			this.label_ingreso.Font = new System.Drawing.Font("Roboto", 11F);
			this.label_ingreso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.label_ingreso.Location = new System.Drawing.Point(278, 167);
			this.label_ingreso.MouseState = MaterialSkin.MouseState.HOVER;
			this.label_ingreso.Name = "label_ingreso";
			this.label_ingreso.Size = new System.Drawing.Size(159, 23);
			this.label_ingreso.TabIndex = 16;
			this.label_ingreso.Text = "Fecha de Ingreso";
			// 
			// text_fecha
			// 
			this.text_fecha.BackColor = System.Drawing.SystemColors.Control;
			this.text_fecha.Depth = 0;
			this.text_fecha.Enabled = false;
			this.text_fecha.Hint = "dd/mm/aaaa";
			this.text_fecha.Location = new System.Drawing.Point(283, 197);
			this.text_fecha.MaxLength = 32767;
			this.text_fecha.MouseState = MaterialSkin.MouseState.HOVER;
			this.text_fecha.Name = "text_fecha";
			this.text_fecha.PasswordChar = '\0';
			this.text_fecha.SelectedText = "";
			this.text_fecha.SelectionLength = 0;
			this.text_fecha.SelectionStart = 0;
			this.text_fecha.Size = new System.Drawing.Size(132, 23);
			this.text_fecha.TabIndex = 15;
			this.text_fecha.TabStop = false;
			this.text_fecha.UseSystemPasswordChar = false;
			// 
			// check_hoy
			// 
			this.check_hoy.Checked = true;
			this.check_hoy.CheckState = System.Windows.Forms.CheckState.Checked;
			this.check_hoy.Depth = 0;
			this.check_hoy.Font = new System.Drawing.Font("Roboto", 10F);
			this.check_hoy.Location = new System.Drawing.Point(424, 196);
			this.check_hoy.Margin = new System.Windows.Forms.Padding(0);
			this.check_hoy.MouseLocation = new System.Drawing.Point(-1, -1);
			this.check_hoy.MouseState = MaterialSkin.MouseState.HOVER;
			this.check_hoy.Name = "check_hoy";
			this.check_hoy.Ripple = true;
			this.check_hoy.Size = new System.Drawing.Size(63, 24);
			this.check_hoy.TabIndex = 17;
			this.check_hoy.Text = "Hoy";
			this.check_hoy.UseVisualStyleBackColor = true;
			this.check_hoy.CheckedChanged += new System.EventHandler(this.MaterialCheckBox2CheckedChanged);
			// 
			// combo_servicio
			// 
			this.combo_servicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
			this.combo_servicio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.combo_servicio.FormattingEnabled = true;
			this.combo_servicio.Items.AddRange(new object[] {
									"Cardiologia Adulto",
									"Cardiologia Infantil",
									"Centro de Atencion Inmediata",
									"Cirugia General",
									"Cirugia Infantil",
									"Clinica Medica",
									"Clinica Medica Pediátrica",
									"Cronicos",
									"Endocrinologia",
									"Gastroenterologia",
									"Gastrologia Infantil",
									"Guardia Adultos",
									"Guardia Pediatría",
									"Hematologia",
									"Incompletas",
									"Nefrologia Infantil",
									"Neonatologia",
									"Neumonología",
									"Neurofuncional",
									"Neurologia",
									"Obstetricia",
									"Oficina de Comunicación a Distancia",
									"Oncologia",
									"Otorrinonaringologia",
									"Pediatria",
									"Terapia Adultos",
									"Terapia Intermedia Pediátrica",
									"Traumatología",
									"Unidad Coronaria Adultos",
									"Unidad Terapia Intensiva Pediatrica",
									"Urologia"});
			this.combo_servicio.Location = new System.Drawing.Point(510, 369);
			this.combo_servicio.Name = "combo_servicio";
			this.combo_servicio.Size = new System.Drawing.Size(206, 26);
			this.combo_servicio.Sorted = true;
			this.combo_servicio.TabIndex = 20;
			this.combo_servicio.SelectedIndexChanged += new System.EventHandler(this.Combo_servicioSelectedIndexChanged);
			// 
			// label_servicio
			// 
			this.label_servicio.Depth = 0;
			this.label_servicio.Font = new System.Drawing.Font("Roboto", 11F);
			this.label_servicio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.label_servicio.Location = new System.Drawing.Point(506, 339);
			this.label_servicio.MouseState = MaterialSkin.MouseState.HOVER;
			this.label_servicio.Name = "label_servicio";
			this.label_servicio.Size = new System.Drawing.Size(178, 23);
			this.label_servicio.TabIndex = 21;
			this.label_servicio.Text = "Servicio Proveniente";
			// 
			// label_pais
			// 
			this.label_pais.Depth = 0;
			this.label_pais.Font = new System.Drawing.Font("Roboto", 11F);
			this.label_pais.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.label_pais.Location = new System.Drawing.Point(25, 160);
			this.label_pais.MouseState = MaterialSkin.MouseState.HOVER;
			this.label_pais.Name = "label_pais";
			this.label_pais.Size = new System.Drawing.Size(100, 23);
			this.label_pais.TabIndex = 23;
			this.label_pais.Text = "País";
			// 
			// label_provincia
			// 
			this.label_provincia.Depth = 0;
			this.label_provincia.Font = new System.Drawing.Font("Roboto", 11F);
			this.label_provincia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.label_provincia.Location = new System.Drawing.Point(25, 226);
			this.label_provincia.MouseState = MaterialSkin.MouseState.HOVER;
			this.label_provincia.Name = "label_provincia";
			this.label_provincia.Size = new System.Drawing.Size(100, 23);
			this.label_provincia.TabIndex = 25;
			this.label_provincia.Text = "Provincia";
			// 
			// materialLabel9
			// 
			this.materialLabel9.Depth = 0;
			this.materialLabel9.Font = new System.Drawing.Font("Roboto", 11F);
			this.materialLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.materialLabel9.Location = new System.Drawing.Point(25, 291);
			this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialLabel9.Name = "materialLabel9";
			this.materialLabel9.Size = new System.Drawing.Size(100, 23);
			this.materialLabel9.TabIndex = 27;
			this.materialLabel9.Text = "Localidad";
			// 
			// text_localidad
			// 
			this.text_localidad.BackColor = System.Drawing.SystemColors.Control;
			this.text_localidad.Depth = 0;
			this.text_localidad.Hint = "Ingrese la Localidad";
			this.text_localidad.Location = new System.Drawing.Point(30, 321);
			this.text_localidad.MaxLength = 32767;
			this.text_localidad.MouseState = MaterialSkin.MouseState.HOVER;
			this.text_localidad.Name = "text_localidad";
			this.text_localidad.PasswordChar = '\0';
			this.text_localidad.SelectedText = "";
			this.text_localidad.SelectionLength = 0;
			this.text_localidad.SelectionStart = 0;
			this.text_localidad.Size = new System.Drawing.Size(198, 23);
			this.text_localidad.TabIndex = 26;
			this.text_localidad.TabStop = false;
			this.text_localidad.UseSystemPasswordChar = false;
			// 
			// combo_pais
			// 
			this.combo_pais.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
			this.combo_pais.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.combo_pais.FormattingEnabled = true;
			this.combo_pais.Items.AddRange(new object[] {
									"Argentina",
									"Bolivia",
									"Brasil",
									"Chile",
									"Colombia",
									"Ecuador",
									"México",
									"Paraguay",
									"Perú",
									"Uruguay",
									"Venezula"});
			this.combo_pais.Location = new System.Drawing.Point(30, 191);
			this.combo_pais.Name = "combo_pais";
			this.combo_pais.Size = new System.Drawing.Size(198, 26);
			this.combo_pais.Sorted = true;
			this.combo_pais.TabIndex = 28;
			this.combo_pais.SelectedIndexChanged += new System.EventHandler(this.ComboBox2SelectedIndexChanged);
			// 
			// combo_provincia
			// 
			this.combo_provincia.FormattingEnabled = true;
			this.combo_provincia.Items.AddRange(new object[] {
									"Buenos Aires",
									"Catamarca",
									"Chaco",
									"Chubut",
									"Córdoba",
									"Corrientes",
									"Entre Rios",
									"Formosa",
									"Jujuy",
									"La Pampa",
									"La Rioja",
									"Mendoza",
									"Misiones",
									"Neuquén",
									"Rio Negro",
									"Salta",
									"San Juan",
									"San Luis",
									"Santa Cruz",
									"Santa Fe",
									"Santiago del Estero",
									"Tierra del Fuego",
									"Tucumán"});
			this.combo_provincia.Location = new System.Drawing.Point(30, 254);
			this.combo_provincia.Name = "combo_provincia";
			this.combo_provincia.Size = new System.Drawing.Size(201, 21);
			this.combo_provincia.Sorted = true;
			this.combo_provincia.TabIndex = 29;
			this.combo_provincia.SelectedIndexChanged += new System.EventHandler(this.ComboBox3SelectedIndexChanged);
			// 
			// text_provincia
			// 
			this.text_provincia.BackColor = System.Drawing.SystemColors.Control;
			this.text_provincia.Depth = 0;
			this.text_provincia.Hint = "Ingrese la provincia";
			this.text_provincia.Location = new System.Drawing.Point(30, 254);
			this.text_provincia.MaxLength = 32767;
			this.text_provincia.MouseState = MaterialSkin.MouseState.HOVER;
			this.text_provincia.Name = "text_provincia";
			this.text_provincia.PasswordChar = '\0';
			this.text_provincia.SelectedText = "";
			this.text_provincia.SelectionLength = 0;
			this.text_provincia.SelectionStart = 0;
			this.text_provincia.Size = new System.Drawing.Size(201, 23);
			this.text_provincia.TabIndex = 30;
			this.text_provincia.TabStop = false;
			this.text_provincia.UseSystemPasswordChar = false;
			// 
			// materialFlatButton1
			// 
			this.materialFlatButton1.AutoSize = true;
			this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.materialFlatButton1.Depth = 0;
			this.materialFlatButton1.Icon = null;
			this.materialFlatButton1.Location = new System.Drawing.Point(565, 458);
			this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
			this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialFlatButton1.Name = "materialFlatButton1";
			this.materialFlatButton1.Primary = false;
			this.materialFlatButton1.selected = false;
			this.materialFlatButton1.Size = new System.Drawing.Size(70, 36);
			this.materialFlatButton1.TabIndex = 31;
			this.materialFlatButton1.Text = "Añadir";
			this.materialFlatButton1.UseVisualStyleBackColor = true;
			this.materialFlatButton1.Click += new System.EventHandler(this.MaterialFlatButton1Click);
			// 
			// materialFlatButton2
			// 
			this.materialFlatButton2.AutoSize = true;
			this.materialFlatButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.materialFlatButton2.Depth = 0;
			this.materialFlatButton2.Icon = null;
			this.materialFlatButton2.Location = new System.Drawing.Point(643, 458);
			this.materialFlatButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
			this.materialFlatButton2.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialFlatButton2.Name = "materialFlatButton2";
			this.materialFlatButton2.Primary = false;
			this.materialFlatButton2.selected = false;
			this.materialFlatButton2.Size = new System.Drawing.Size(73, 36);
			this.materialFlatButton2.TabIndex = 32;
			this.materialFlatButton2.Text = "CERRAR";
			this.materialFlatButton2.UseVisualStyleBackColor = true;
			this.materialFlatButton2.Click += new System.EventHandler(this.MaterialFlatButton2Click);
			// 
			// combo_localidad
			// 
			this.combo_localidad.FormattingEnabled = true;
			this.combo_localidad.Items.AddRange(new object[] {
									"9 de Julio",
									"Adrogué",
									"Agustin Ferrari",
									"Alberti",
									"Arrecifes",
									"Avellaneda",
									"Azul",
									"Bahia Blanca",
									"Banfield",
									"Bella Vista",
									"Berazategui",
									"Bragado",
									"Campana",
									"Cañuelas",
									"Capilla del Señor",
									"Carmen de Areco",
									"Carmen de Patagones",
									"Caseros",
									"Castelar",
									"Chacabuco",
									"Chivilcoy",
									"Ciudad Evita ",
									"Ciudadela",
									"Coronel Suarez",
									"Derqui",
									"El Dorado",
									"El Palomar",
									"Escobar",
									"Esteban Echeverria",
									"Ezeiza",
									"Florencio Varela",
									"Francisco Alvarez",
									"General Rodriguez",
									"Gonzalez Catán",
									"Guernica",
									"Haedo",
									"Hurlingham",
									"Isidro Casanova",
									"Ituzaingó",
									"José C. Paz",
									"Jose Leon Suarez",
									"Junín",
									"La Ferrere",
									"La Matanza",
									"La Plata",
									"La Reja",
									"La Tablada",
									"Lanús",
									"Las Heras",
									"Libertad",
									"Lincoln",
									"Lobos",
									"Loma Hermosa",
									"Lomas de Zamora",
									"Los Toldos",
									"Luján",
									"Lynch",
									"Macos Paz",
									"Malvinas Argentinas",
									"Mar del Plata",
									"Mar del Tuyu",
									"Martínez",
									"Mercedes ",
									"Merlo",
									"Monte Grande",
									"Moreno",
									"Morón",
									"Munro",
									"Navarro",
									"Necochea",
									"Norberto de la Riestra",
									"Olavarria",
									"Pablo Podesta",
									"Pacheco",
									"Pacheco",
									"Paso del Rey",
									"Pergamino",
									"Pilar",
									"Pinamar",
									"Pontevedra",
									"Quilmes",
									"Rafael Castillo",
									"Ramallo ",
									"Ramos Mejía",
									"Saladillo",
									"San Andres de Giles",
									"San Antonio de Areco",
									"San Antonio de Padua",
									"San Fernando",
									"San Isidro",
									"San Justo",
									"San Martín",
									"San Miguel",
									"San Nicolás",
									"San Pedro",
									"Santos Lugares",
									"Suipacha",
									"Tandil",
									"Temperley",
									"Tigre",
									"Trenque Lauquen",
									"Tres de Febrero",
									"Vicente Lopez",
									"Villa Delina",
									"Villa Luzuriaga",
									"Villa Marteli",
									"Villa Sarmiento",
									"Villa Tesei",
									"Virrey del Pino",
									"Willian Morris",
									"Zarate"});
			this.combo_localidad.Location = new System.Drawing.Point(30, 321);
			this.combo_localidad.Name = "combo_localidad";
			this.combo_localidad.Size = new System.Drawing.Size(198, 21);
			this.combo_localidad.Sorted = true;
			this.combo_localidad.TabIndex = 33;
			// 
			// label_error
			// 
			this.label_error.Depth = 0;
			this.label_error.Font = new System.Drawing.Font("Roboto", 11F);
			this.label_error.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.label_error.Location = new System.Drawing.Point(204, 458);
			this.label_error.MouseState = MaterialSkin.MouseState.HOVER;
			this.label_error.Name = "label_error";
			this.label_error.Size = new System.Drawing.Size(354, 23);
			this.label_error.TabIndex = 34;
			// 
			// materialFlatButton3
			// 
			this.materialFlatButton3.AutoSize = true;
			this.materialFlatButton3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.materialFlatButton3.Depth = 0;
			this.materialFlatButton3.Icon = null;
			this.materialFlatButton3.Location = new System.Drawing.Point(508, 243);
			this.materialFlatButton3.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
			this.materialFlatButton3.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialFlatButton3.Name = "materialFlatButton3";
			this.materialFlatButton3.Primary = false;
			this.materialFlatButton3.selected = false;
			this.materialFlatButton3.Size = new System.Drawing.Size(30, 36);
			this.materialFlatButton3.TabIndex = 35;
			this.materialFlatButton3.Text = "x";
			this.materialFlatButton3.UseVisualStyleBackColor = true;
			this.materialFlatButton3.Click += new System.EventHandler(this.MaterialFlatButton3Click);
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// FormAddGuest
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(741, 518);
			this.Controls.Add(this.materialFlatButton3);
			this.Controls.Add(this.label_error);
			this.Controls.Add(this.combo_localidad);
			this.Controls.Add(this.materialFlatButton2);
			this.Controls.Add(this.materialFlatButton1);
			this.Controls.Add(this.text_provincia);
			this.Controls.Add(this.combo_provincia);
			this.Controls.Add(this.combo_pais);
			this.Controls.Add(this.materialLabel9);
			this.Controls.Add(this.text_localidad);
			this.Controls.Add(this.label_provincia);
			this.Controls.Add(this.label_pais);
			this.Controls.Add(this.label_servicio);
			this.Controls.Add(this.combo_servicio);
			this.Controls.Add(this.check_hoy);
			this.Controls.Add(this.label_ingreso);
			this.Controls.Add(this.text_fecha);
			this.Controls.Add(this.label_locker);
			this.Controls.Add(this.text_locker);
			this.Controls.Add(this.label_habitacion);
			this.Controls.Add(this.text_habitacion);
			this.Controls.Add(this.check_paciente);
			this.Controls.Add(this.label_apellido);
			this.Controls.Add(this.text_apellido);
			this.Controls.Add(this.text_nombre);
			this.Controls.Add(this.label_nombre);
			this.Controls.Add(this.picture);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FormAddGuest";
			this.Text = "FormAddGuest";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormAddGuestFormClosed);
			this.Load += new System.EventHandler(this.FormAddGuestLoad);
			((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private MaterialSkin.Controls.MaterialFlatButton materialFlatButton3;
		private MaterialSkin.Controls.MaterialLabel label_error;
		private System.Windows.Forms.ComboBox combo_localidad;
		private MaterialSkin.Controls.MaterialFlatButton materialFlatButton2;
		private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
		private MaterialSkin.Controls.MaterialSingleLineTextField text_provincia;
		private System.Windows.Forms.ComboBox combo_provincia;
		private System.Windows.Forms.ComboBox combo_pais;
		private MaterialSkin.Controls.MaterialSingleLineTextField text_localidad;
		private MaterialSkin.Controls.MaterialLabel materialLabel9;
		private MaterialSkin.Controls.MaterialLabel label_provincia;
		private MaterialSkin.Controls.MaterialLabel label_pais;
		private MaterialSkin.Controls.MaterialLabel label_servicio;
		private System.Windows.Forms.ComboBox combo_servicio;
		private MaterialSkin.Controls.MaterialCheckBox check_hoy;
		private MaterialSkin.Controls.MaterialSingleLineTextField text_fecha;
		private MaterialSkin.Controls.MaterialLabel label_ingreso;
		private MaterialSkin.Controls.MaterialSingleLineTextField text_locker;
		private MaterialSkin.Controls.MaterialLabel label_locker;
		private MaterialSkin.Controls.MaterialSingleLineTextField text_habitacion;
		private MaterialSkin.Controls.MaterialLabel label_habitacion;
		private MaterialSkin.Controls.MaterialCheckBox check_paciente;
		private MaterialSkin.Controls.MaterialLabel label_apellido;
		private MaterialSkin.Controls.MaterialSingleLineTextField text_apellido;
		private MaterialSkin.Controls.MaterialSingleLineTextField text_nombre;
		private MaterialSkin.Controls.MaterialLabel label_nombre;
		private System.Windows.Forms.PictureBox picture;

	}
}
