using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

using Transitions;

using Program.Classes;
using Program.StaticClasses;
/*

	Formulario de ingreso de paciente	

*/

namespace Program.Forms
{
	public partial class FormAddPatient : Form
	{
		public string nombre =" ";
		public string apellido =" ";
		public string name ="button_paciente";
		
		private List<Patient> Patients; 
		
		public FormAddPatient(string n)
		{
			InitializeComponent();
			name = n;//recibe el nombre del boton donde se abrio y se declara un variable local
		}
		
		public FormAddPatient(ref List<Patient> pats)
		{
			InitializeComponent();
		
		  Patients = pats;
		}
		
		void MaterialFlatButton1Click(object sender, EventArgs e)
		{
			if(text_nombre.Text != "" && text_apellido.Text != "" && combo_servicio.SelectedIndex != -1 ){
				StaticForms.FAG.addButton1(2);//llama a la funcion addbutton del formulario principal de FormAddGuestHome y le pasa el parametro 2 para deintificar que es de guest
				StaticForms.FAG.ChangeBtn(name, text_nombre.Text, text_apellido.Text);//llama a la funcion changeBTN para que cambiarle el nombre al boton
				this.Close();//se cierra el formulario
			}else{
				label_error.ForeColor = Color.FromArgb(0xB00020);
				label_error.Text="Porfavor complete las casillas, N° de camas no es obligatorio";
			}
		}
		
		void MaterialFlatButton2Click(object sender, EventArgs e)
		{
			// Transcición de cierre de formulario
			var t = new Transition(new TransitionType_Acceleration(500));
				t.add(this, "Top", -this.Height);
				t.TransitionCompletedEvent += (_, __) => this.Close();
				t.run();
		}
		
		void FormAddPatientLoad(object sender, EventArgs e)
		{
			this.Location = StaticForms.FAG.Location;		
		}
	}
}
