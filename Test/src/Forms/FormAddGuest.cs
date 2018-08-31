using System;
using System.Drawing;
using System.Windows.Forms;

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
				
				text_fecha.Enabled = true;
				text_fecha.Text = "";
				
			}else{
				
				text_fecha.Enabled = false;
				text_fecha.Text = "23/06/2017";
			}
		}
		
		void FormAddGuestLoad(object sender, EventArgs e)
		{
			this.Location = StaticForms.formAddGuestHome.Location;
			text_fecha.Text = "23/06/2017";
			
			combo_provincia.Visible = false;
			materialLabel9.Visible = false;
			text_localidad.Visible = false;
			label_servicio.Visible = false;
			combo_servicio.Visible = false;
			combo_localidad.Visible = false;
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
						
						if(combo_localidad.SelectedIndex != -1 && combo_provincia.SelectedIndex != -1){
							
							nombre = text_nombre.Text;
							apellido = text_apellido.Text;
							Ayuda.formAddGuestHome.addButton1(1);
							Ayuda.formAddGuestHome.ChangeBtn(nombre,apellido);
							this.Close();			
							
						}else{
							label_error.ForeColor = Color.FromArgb(0xB00020);
							label_error.Text="Porfavor complete las casillas";
						}	
						
					}else if(text_localidad.Text != "" && text_provincia.Text != ""){
						
						nombre = text_nombre.Text;
						apellido = text_apellido.Text;
						Ayuda.formAddGuestHome.addButton1(1);
						Ayuda.formAddGuestHome.ChangeBtn(nombre,apellido);
						this.Close();
						
					}else{
						
						label_error.ForeColor = Color.FromArgb(0xB00020);
						label_error.Text="Porfavor complete las casillas";
					} 
				}else{
					
					label_error.ForeColor = Color.FromArgb(0xB00020);
					label_error.Text="Porfavor complete las casillas";
				}
			}else{
				
				label_error.ForeColor = Color.FromArgb(0xB00020);
				label_error.Text="Porfavor complete las casillas";
			}
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
	}
}
