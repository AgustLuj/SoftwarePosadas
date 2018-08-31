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
		public FormAddPatient()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void MaterialFlatButton1Click(object sender, EventArgs e)
		{
			nombre = text_nombre.Text;
			apellido = text_apellido.Text;
			StaticForms.formAddGuestHome.addButton1(2);
			StaticForms.formAddGuestHome.ChangeBtn(nombre,apellido);
			this.Close();
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
			this.Location = StaticForms.formAddGuestHome.Location;			
		}
	}
}
