/*
 * Created by SharpDevelop.
 * User: lujan
 * Date: 4/9/2018
 * Time: 08:35
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Program.Forms
{
	/// <summary>
	/// Description of Form1.
	/// </summary>
	public partial class FormAddUser : Form
	{
		public FormAddUser()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Form1Load(object sender, EventArgs e)
		{
			
		}
		
		
		void Text_nombreTextChanged(object sender, EventArgs e)
		{
			text_usuario.Text=text_nombre.Text;
		}
		
		void Text_apellidoTextChanged(object sender, EventArgs e)
		{
			text_usuario.Text=text_nombre.Text+"_"+text_apellido.Text;
		}
		
		void MaterialRadioButton2CheckedChanged(object sender, EventArgs e)
		{
			
		}
		
		void MaterialCheckBox1CheckedChanged(object sender, EventArgs e)
		{
			if(check_operadores.Checked == false){
				
				radio_leerOp.Checked=false;
				radio_leerEscOp.Checked=false;
				
			}else{
				radio_leerOp.Checked=true;
			}
		}
		
		void MaterialFlatButton1Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
		
		void Check_seguridadCheckedChanged(object sender, EventArgs e)
		{
			if(check_seguridad.Checked == false){
				
				radio_leerSeg.Checked=false;
				radio_leerEscSeg.Checked=false;
				
			}else{
				radio_leerSeg.Checked=true;
			}			
		}
		
		void Check_socialCheckedChanged(object sender, EventArgs e)
		{
			if(check_social.Checked == false){
				
				radio_leerSo.Checked=false;
				radio_leerEscSo.Checked=false;
				
			}else{
				radio_leerSo.Checked=true;
			}			
		}
		
		void Check_mantenimientoCheckedChanged(object sender, EventArgs e)
		{
			if(check_mantenimiento.Checked == false){
				
				radio_leerMan.Checked=false;
				radio_leerEscMan.Checked=false;
				
			}else{
				radio_leerMan.Checked=true;
			}			
		}
		
		void Radio_adminCheckedChanged(object sender, EventArgs e)
		{
			show(true);
			selectall(true);
		}
		
		void Radio_operadorCheckedChanged(object sender, EventArgs e)
		{
			show(true);
			selectall(false);
		}
		
		
		void Radio_invitadoCheckedChanged(object sender, EventArgs e)
		{
			show(false);
		}
		void show(bool t){
			
			check_operadores.Visible = t;
			check_seguridad.Visible = t;
			check_social.Visible = t;
			check_mantenimiento.Visible = t;
			radio_leerEscMan.Visible=t;
			radio_leerEscSo.Visible=t;
			radio_leerEscSeg.Visible=t;
			radio_leerEscOp.Visible=t;
			radio_leerMan.Visible=t;
			radio_leerSo.Visible=t;
			radio_leerSeg.Visible=t;
			radio_leerOp.Visible=t;		
		}
		void selectall(bool t){
			
			check_operadores.Checked = t;
			check_seguridad.Checked = t;
			check_social.Checked = t;
			check_mantenimiento.Checked = t;
			radio_leerEscMan.Checked=t;
			radio_leerEscSo.Checked=t;
			radio_leerEscSeg.Checked=t;
			radio_leerEscOp.Checked=t;
			radio_leerMan.Checked=false;
			radio_leerSo.Checked=false;
			radio_leerSeg.Checked=false;
			radio_leerOp.Checked=false;
		}
	}
}
