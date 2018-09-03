/*
 * Created by SharpDevelop.
 * User: lujan
 * Date: 27/8/2018
 * Time: 08:48
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Program.Forms
{
	partial class FormAddPatient
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
		  this.text_nombre = new MaterialSkin.Controls.MaterialSingleLineTextField();
		  this.label_apellido = new MaterialSkin.Controls.MaterialLabel();
		  this.text_apellido = new MaterialSkin.Controls.MaterialSingleLineTextField();
		  this.label_servicio = new MaterialSkin.Controls.MaterialLabel();
		  this.combo_servicio = new System.Windows.Forms.ComboBox();
		  this.label_numeroCama = new MaterialSkin.Controls.MaterialLabel();
		  this.text_numeroCama = new MaterialSkin.Controls.MaterialSingleLineTextField();
		  this.materialFlatButton2 = new MaterialSkin.Controls.MaterialFlatButton();
		  this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
		  this.label_error = new MaterialSkin.Controls.MaterialLabel();
		  this.SuspendLayout();
		  // 
		  // label_nombre
		  // 
		  this.label_nombre.Depth = 0;
		  this.label_nombre.Font = new System.Drawing.Font("Roboto", 11F);
		  this.label_nombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
		  this.label_nombre.Location = new System.Drawing.Point(260, 88);
		  this.label_nombre.MouseState = MaterialSkin.MouseState.HOVER;
		  this.label_nombre.Name = "label_nombre";
		  this.label_nombre.Size = new System.Drawing.Size(215, 23);
		  this.label_nombre.TabIndex = 0;
		  this.label_nombre.Text = "Nombre";
		  // 
		  // text_nombre
		  // 
		  this.text_nombre.BackColor = System.Drawing.SystemColors.Control;
		  this.text_nombre.Depth = 0;
		  this.text_nombre.Hint = "Ingrese el nombre";
		  this.text_nombre.Location = new System.Drawing.Point(265, 114);
		  this.text_nombre.MaxLength = 32767;
		  this.text_nombre.MouseState = MaterialSkin.MouseState.HOVER;
		  this.text_nombre.Name = "text_nombre";
		  this.text_nombre.PasswordChar = '\0';
		  this.text_nombre.SelectedText = "";
		  this.text_nombre.SelectionLength = 0;
		  this.text_nombre.SelectionStart = 0;
		  this.text_nombre.Size = new System.Drawing.Size(198, 23);
		  this.text_nombre.TabIndex = 3;
		  this.text_nombre.TabStop = false;
		  this.text_nombre.UseSystemPasswordChar = false;
		  // 
		  // label_apellido
		  // 
		  this.label_apellido.Depth = 0;
		  this.label_apellido.Font = new System.Drawing.Font("Roboto", 11F);
		  this.label_apellido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
		  this.label_apellido.Location = new System.Drawing.Point(260, 163);
		  this.label_apellido.MouseState = MaterialSkin.MouseState.HOVER;
		  this.label_apellido.Name = "label_apellido";
		  this.label_apellido.Size = new System.Drawing.Size(100, 23);
		  this.label_apellido.TabIndex = 6;
		  this.label_apellido.Text = "Apellido";
		  // 
		  // text_apellido
		  // 
		  this.text_apellido.BackColor = System.Drawing.SystemColors.Control;
		  this.text_apellido.Depth = 0;
		  this.text_apellido.Hint = "Ingrese el apellido";
		  this.text_apellido.Location = new System.Drawing.Point(265, 191);
		  this.text_apellido.MaxLength = 32767;
		  this.text_apellido.MouseState = MaterialSkin.MouseState.HOVER;
		  this.text_apellido.Name = "text_apellido";
		  this.text_apellido.PasswordChar = '\0';
		  this.text_apellido.SelectedText = "";
		  this.text_apellido.SelectionLength = 0;
		  this.text_apellido.SelectionStart = 0;
		  this.text_apellido.Size = new System.Drawing.Size(198, 23);
		  this.text_apellido.TabIndex = 5;
		  this.text_apellido.TabStop = false;
		  this.text_apellido.UseSystemPasswordChar = false;
		  // 
		  // label_servicio
		  // 
		  this.label_servicio.Depth = 0;
		  this.label_servicio.Font = new System.Drawing.Font("Roboto", 11F);
		  this.label_servicio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
		  this.label_servicio.Location = new System.Drawing.Point(260, 251);
		  this.label_servicio.MouseState = MaterialSkin.MouseState.HOVER;
		  this.label_servicio.Name = "label_servicio";
		  this.label_servicio.Size = new System.Drawing.Size(178, 23);
		  this.label_servicio.TabIndex = 24;
		  this.label_servicio.Text = "Servicio Proveniente";
		  // 
		  // combo_servicio
		  // 
		  this.combo_servicio.Font = new System.Drawing.Font("Roboto", 11F);
		  this.combo_servicio.ForeColor = this.label_servicio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));;
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
		  this.combo_servicio.Location = new System.Drawing.Point(265, 288);
		  this.combo_servicio.Name = "combo_servicio";
		  this.combo_servicio.Size = new System.Drawing.Size(201, 26);
		  this.combo_servicio.Sorted = true;
		  this.combo_servicio.TabIndex = 23;
		  // 
		  // label_numeroCama
		  // 
		  this.label_numeroCama.Depth = 0;
		  this.label_numeroCama.Font = new System.Drawing.Font("Roboto", 11F);
		  this.label_numeroCama.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
		  this.label_numeroCama.Location = new System.Drawing.Point(260, 322);
		  this.label_numeroCama.MouseState = MaterialSkin.MouseState.HOVER;
		  this.label_numeroCama.Name = "label_numeroCama";
		  this.label_numeroCama.Size = new System.Drawing.Size(176, 23);
		  this.label_numeroCama.TabIndex = 26;
		  this.label_numeroCama.Text = "Número de Cama";
		  // 
		  // text_numeroCama
		  // 
		  this.text_numeroCama.BackColor = System.Drawing.SystemColors.Control;
		  this.text_numeroCama.Depth = 0;
		  this.text_numeroCama.Hint = "N°";
		  this.text_numeroCama.Location = new System.Drawing.Point(265, 359);
		  this.text_numeroCama.MaxLength = 32767;
		  this.text_numeroCama.MouseState = MaterialSkin.MouseState.HOVER;
		  this.text_numeroCama.Name = "text_numeroCama";
		  this.text_numeroCama.PasswordChar = '\0';
		  this.text_numeroCama.SelectedText = "";
		  this.text_numeroCama.SelectionLength = 0;
		  this.text_numeroCama.SelectionStart = 0;
		  this.text_numeroCama.Size = new System.Drawing.Size(201, 23);
		  this.text_numeroCama.TabIndex = 25;
		  this.text_numeroCama.TabStop = false;
		  this.text_numeroCama.UseSystemPasswordChar = false;
		  // 
		  // materialFlatButton2
		  // 
		  this.materialFlatButton2.AutoSize = true;
		  this.materialFlatButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
		  this.materialFlatButton2.Depth = 0;
		  this.materialFlatButton2.Icon = null;
		  this.materialFlatButton2.Location = new System.Drawing.Point(655, 467);
		  this.materialFlatButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
		  this.materialFlatButton2.MouseState = MaterialSkin.MouseState.HOVER;
		  this.materialFlatButton2.Name = "materialFlatButton2";
		  this.materialFlatButton2.Primary = false;
		  this.materialFlatButton2.selected = false;
		  this.materialFlatButton2.Size = new System.Drawing.Size(73, 36);
		  this.materialFlatButton2.TabIndex = 34;
		  this.materialFlatButton2.Text = "CERRAR";
		  this.materialFlatButton2.UseVisualStyleBackColor = true;
		  this.materialFlatButton2.Click += new System.EventHandler(this.MaterialFlatButton2Click);
		  // 
		  // materialFlatButton1
		  // 
		  this.materialFlatButton1.AutoSize = true;
		  this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
		  this.materialFlatButton1.Depth = 0;
		  this.materialFlatButton1.Icon = null;
		  this.materialFlatButton1.Location = new System.Drawing.Point(577, 467);
		  this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
		  this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
		  this.materialFlatButton1.Name = "materialFlatButton1";
		  this.materialFlatButton1.Primary = false;
		  this.materialFlatButton1.selected = false;
		  this.materialFlatButton1.Size = new System.Drawing.Size(70, 36);
		  this.materialFlatButton1.TabIndex = 33;
		  this.materialFlatButton1.Text = "Añadir";
		  this.materialFlatButton1.UseVisualStyleBackColor = true;
		  this.materialFlatButton1.Click += new System.EventHandler(this.MaterialFlatButton1Click);
		  // 
		  // label_error
		  // 
		  this.label_error.Depth = 0;
		  this.label_error.Font = new System.Drawing.Font("Roboto", 11F);
		  this.label_error.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
		  this.label_error.Location = new System.Drawing.Point(149, 397);
		  this.label_error.MouseState = MaterialSkin.MouseState.HOVER;
		  this.label_error.Name = "label_error";
		  this.label_error.Size = new System.Drawing.Size(481, 23);
		  this.label_error.TabIndex = 35;
		  // 
		  // FormAddPatient
		  // 
		  this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
		  this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		  this.BackColor = System.Drawing.Color.White;
		  this.ClientSize = new System.Drawing.Size(741, 518);
		  this.Controls.Add(this.label_error);
		  this.Controls.Add(this.materialFlatButton2);
		  this.Controls.Add(this.materialFlatButton1);
		  this.Controls.Add(this.label_numeroCama);
		  this.Controls.Add(this.text_numeroCama);
		  this.Controls.Add(this.label_servicio);
		  this.Controls.Add(this.combo_servicio);
		  this.Controls.Add(this.label_apellido);
		  this.Controls.Add(this.text_apellido);
		  this.Controls.Add(this.text_nombre);
		  this.Controls.Add(this.label_nombre);
		  this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		  this.Name = "FormAddPatient";
		  this.Text = "FormAddPatient";
		  this.Load += new System.EventHandler(this.FormAddPatientLoad);
		  this.ResumeLayout(false);
		  this.PerformLayout();
		}
		private MaterialSkin.Controls.MaterialLabel label_error;
		private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
		private MaterialSkin.Controls.MaterialFlatButton materialFlatButton2;
		private MaterialSkin.Controls.MaterialSingleLineTextField text_numeroCama;
		private MaterialSkin.Controls.MaterialLabel label_numeroCama;
		private System.Windows.Forms.ComboBox combo_servicio;
		private MaterialSkin.Controls.MaterialLabel label_servicio;
		private MaterialSkin.Controls.MaterialSingleLineTextField text_apellido;
		private MaterialSkin.Controls.MaterialLabel label_apellido;
		private MaterialSkin.Controls.MaterialSingleLineTextField text_nombre;
		private MaterialSkin.Controls.MaterialLabel label_nombre;
	}
}
