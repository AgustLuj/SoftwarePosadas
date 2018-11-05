/*
 * Created by SharpDevelop.
 * User: lujan
 * Date: 27/8/2018
 * Time: 08:48
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

using Transitions;

using Program.StaticClasses;

namespace Program.Forms
{
	/// <summary>
	/// Description of FormAddPatient.
	/// </summary>
	public partial class FormAddPatient : Form
	{
		public string nombre =" ";
		public string apellido =" ";
		public string name =" ";
		public FormAddPatient(string name)
		{
			InitializeComponent();
			this.name=name;
		}
		
		void MaterialFlatButton1Click(object sender, EventArgs e)
		{
			if(text_nombre.Text != "" && text_apellido.Text != "" && combo_servicio.SelectedIndex != -1 ){
				StaticForms.FAG.addButton1(2);
				StaticForms.FAG.ChangeBtn(name,text_nombre.Text,text_apellido.Text);
				this.Close();	
			}else{
				label_error.ForeColor = Color.FromArgb(0xB00020);
				label_error.Text="Porfavor complete las casillas, N° de camas no es obligatorio";
			}
		}
		
		void MaterialFlatButton2Click(object sender, EventArgs e)
		{
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
