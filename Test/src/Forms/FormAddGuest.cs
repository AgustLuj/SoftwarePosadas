using System;
using System.IO;
using System.Linq;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using System.Collections.Generic;

using Transitions;

using Program.Forms;
using Program.Classes;
using Program.Extensions;
using Program.StaticClasses;

namespace Program.Forms
{
	public partial class FormAddGuest : Form
	{
		public string nombre = "";
		public string apellido = "";
		public string name =" ";
		public FormAddGuest(string name)
		{
			InitializeComponent();
			combo_pais.Items.AddRange(GetAllCountries());
			this.name=name;
			//sadboys sadboys
			
			txt_ficha.Text = "1001C";
			text_nombre.Text = "Mateo";
		 text_apellido.Text = "Pidal";
		  combo_pais.Text = "Argentina";
		  combo_provincia.Text = "Buenos Aires";
		  txt_phone.Text = "+54 (911) 3108-6234";
		  text_habitacion.Text = "12";
		  text_locker.Text = "12C";
		  
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
		  txt_date.Enabled = !check_hoy.Checked;
		  
			if(!check_hoy.Checked){
				txt_date.Text = "";
				txt_date.Focus();
			}else{
				txt_date.Text = DateTime.Today.ToString("dd-MM-yyyy");
			}
		}
		
		void FormAddGuestLoad(object sender, EventArgs e)
		{
		  btn_addphoto.BigFont();
			txt_date.Text = DateTime.Today.ToString("dd-MM-yyyy");
			
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
		
		void btn_addClick(object sender, EventArgs e)
		{
		  var panel3 = Parent as Panel;
		  //var FAG = panel3.Controls[0] as FormGuests;
		  insertGuest();

		}
		void insertGuest()
		{
			StaticForms.FAG.addButton1(1);
			StaticForms.FAG.ChangeBtn(name, text_nombre.Text, text_apellido.Text);	
			this.Close();
		}
		void showErrorLabel(){
			label_error.ForeColor = Color.FromArgb(0xB00020);
			label_error.Text="Por favor complete las casillas";
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
		
		public string[] GetAllCountries(){
		  
      Dictionary<string, string> objDic = new Dictionary<string, string>();

      foreach (CultureInfo ObjCultureInfo in CultureInfo.GetCultures(CultureTypes.SpecificCultures))
      {
        RegionInfo objRegionInfo = new RegionInfo(ObjCultureInfo.Name);
        if (!objDic.ContainsKey(objRegionInfo.EnglishName))
        {
          objDic.Add(objRegionInfo.EnglishName, objRegionInfo.TwoLetterISORegionName.ToLower());
        }
      }

      var obj = objDic.OrderBy(p => p.Key);
      var y = obj.Select(t => t.Key);
		  return y.ToArray();
	   }
		
		void Txt_phoneGotFocus(object sender, EventArgs e)
		{
		  txt_phone.SelectionStart = 10;
		}
		
		void Chk_odate_undefCheckedChanged(object sender, EventArgs e)
		{
      var s = sender as MaterialSkin.Controls.MaterialCheckBox;

      txt_odate.Enabled = !s.Checked;
      lbl_odate.Enabled = !s.Checked;
      
      txt_odate.Text = (s.Checked) ? "01-01-0001" : "";
      
      if(!s.Checked)
        txt_odate.Focus();
		}

		void PictureClick(object sender, EventArgs e){
		
        
		}
		  
		void btn_pic(object sender, EventArgs e)
		{
      		  
		}
		
		void Btn_addphotoClick(object sender, EventArgs e)
		{
		  if(!StaticForms.MF.panel3.Controls.containsType(typeof(FormLoadPicture))){
      
          var t = new FormLoadPicture();
    	      t.TopLevel = false;
    	      StaticForms.MF.panel3.Controls.Add(t);
    	      StaticForms.MF.panel3.Tag = t;
    	      t.Parent = StaticForms.MF.panel3;
    	      t.Show();
    	      t.Top = -t.Height;
    	      t.BringToFront();
  	      
  	      var tr = new Transition(new TransitionType_Deceleration(500));
    	      tr.add(t, "Top", 0);
    	      tr.run();
		  }
		}
		}
}


