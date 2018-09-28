using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

using Transitions;

using Program.StaticClasses;

namespace Program.Forms
{
	public partial class FormAddGuest : Form
	{
		public string nombre = " ";
		public string apellido = " ";
		public FormAddGuest()
		{
			InitializeComponent();
		}
		
		void button_cerrarClick(object sender, EventArgs e)
		{
			Application.Exit();
		}
		void button_añadirClick(object sender, EventArgs e)
		{
			Application.Exit();
		}

		
		void MaterialCheckBox2CheckedChanged(object sender, EventArgs e)
		{
			if(check_hoy.Checked == false){
				
				txt_date.Enabled = true;
				txt_date.Text = "";
				
				txt_date.Focus();
				
			}else{
				
				txt_date.Enabled = false;
				txt_date.Text = DateTime.Today.ToString("yyyy-MM-dd");
			}
		}
		
		void FormAddGuestLoad(object sender, EventArgs e)
		{
			
			txt_date.Text = DateTime.Today.ToString("yyyy-MM-dd");
			
			combo_provincia.Visible = false;
			materialLabel9.Visible = false;
			text_localidad.Visible = false;
			label_servicio.Visible = false;
			combo_servicio.Visible = false;
			combo_localidad.Visible = false;
			
			Console.WriteLine(txt_date.Text);
			Console.WriteLine(DateTime.Parse("17-09-2018").ToString("yyyy-MM-dd"));
		}
		
		void ComboBox3SelectedIndexChanged(object sender, EventArgs e)
		{
			if(combo_provincia.Text == "Buenos Aires"){
				
				text_localidad.Visible = false;
				combo_localidad.Visible = true;
				
			}else{
				
				text_localidad.Visible = true;
				combo_localidad.Visible = false;
			}
		}
		
		void ComboBox2SelectedIndexChanged(object sender, EventArgs e)
		{
			if(combo_pais.Text == "Argentina"){
				
				combo_provincia.Visible=true;
				materialLabel9.Visible=true;
				text_localidad.Visible=true;
				text_provincia.Visible=false;
				combo_localidad.Visible=true;
			}else{
				
				combo_provincia.Visible=false;
				materialLabel9.Visible=true;
				text_localidad.Visible=true;
				text_provincia.Visible=true;
				combo_localidad.Visible=false;
			}
		}

		void Check_pacienteCheckedChanged(object sender, EventArgs e)
		{
			if(check_paciente.Checked == false){
				label_servicio.Visible=false;
				combo_servicio.Visible=false;
				combo_servicio.Enabled=false;
				
			}else{
				
				label_servicio.Visible=true;
				combo_servicio.Visible=true;
				combo_servicio.Enabled=true;
			}
		}
		
		void MaterialFlatButton1Click(object sender, EventArgs e)
		{
			if(text_apellido.Text != "" && text_nombre.Text != "" && text_habitacion.Text != "" && text_locker.Text != ""){
				if(combo_pais.SelectedIndex != -1){
					if(combo_pais.SelectedText != "Argentina"){
						if(combo_provincia.SelectedText != "Buenos Aires"){
							if(combo_localidad.SelectedIndex != -1 && combo_provincia.SelectedIndex != -1){
								insertGuest();
								
							}else{
								showErrorLabel();
							}	
						}else if(text_localidad.Text != "" && text_provincia.Text != ""){
								insertGuest();
						}
					}else{
						if(text_localidad.Text != "" && text_provincia.Text != ""){
							insertGuest();
						}else{
							showErrorLabel();
						}
					} 
				}else{
					showErrorLabel();
				}
			}else{
				showErrorLabel();
			}
			insertGuest();
		}
		void insertGuest(){
			//nombre = text_nombre.Text; 
			//TODO: INSERT INTO `huespedes`(`id`, `nficha`, `nombre`, `apellido`, `paciente`, `nombre_internado`, `apellido_internado`, `nhabit`, `nlocker`, `ingreso`, `egreso`, `ncamhos`, `tel`, `Totalhospedados`, `procedencia`, `servicio`) VALUES (0,"001C", "LOl","Lel","1","a","a","6","6c","2018-09-17",NULL,0,5491131086234,5,"SJ","OSDE")
			
			
			//apellido = text_apellido.Text;
			//StaticForms.formAddGuestHome.addButton1(1);
			//StaticForms.formAddGuestHome.ChangeBtn(nombre,apellido);
			
			this.Close();			
		}
		void showErrorLabel(){
			label_error.ForeColor = Color.FromArgb(0xB00020);
			label_error.Text="Porfavor complete las casillas";
		}
		void MaterialFlatButton2Click(object sender, EventArgs e)
		{
			var t = new Transition(new TransitionType_Acceleration(500));
				t.add(this, "Top", -this.Height);
				t.TransitionCompletedEvent += (_, __) => this.Close();
				t.run();
		}
		
		void Combo_servicioSelectedIndexChanged(object sender, EventArgs e)
		{
		
		}
		
		void FormAddGuestFormClosed(object sender, FormClosedEventArgs e)
		{
			if (Application.OpenForms.Count == 0) {
				Application.Exit();
			}
		}
		
		void MaterialFlatButton3Click(object sender, EventArgs e)
		{
					
		}
	}
}

