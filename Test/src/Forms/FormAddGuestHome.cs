using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using Program.Classes;
using MaterialSkin.Controls;
using Transitions;
/*
  
Formulario principal de ingreso de huésped y paciente	

*/

namespace Program.Forms
{
	public partial class FormAddGuestHome : Form
	{	
		public String name = " ";
		public String names = " ";
		public int count_btn1 = 1;
		public int count_btn2 = 1;
		
		private List<MaterialSkin.Controls.MaterialFlatButton> lista;
		
		private List<Guest> Guests = new List<Guest>();
		
		public FormAddGuestHome()
		{
			InitializeComponent();
			
			lista = new List<MaterialSkin.Controls.MaterialFlatButton>();
				lista.Add(button_huesped);
				lista.Add(button_paciente);
		}
		
		public void addGuest(Guest g){
		  Guests.Add(g);
		}
		
		void Button_huespedClick(object sender, EventArgs e)
		{
			var fa = sender as MaterialFlatButton; // se localiza el nombre del botón
				names = fa.Name;
			// Se crea formulario para añadir huésped 	
			FormAddGuest f = new FormAddGuest(names); // el argumento que se envía es el nombre del botón
				f.TopLevel = false;
				(this.Parent as Panel).Controls.Add(f);
				f.Parent = this;
				f.Show();
				f.Top = - f.Height;
				f.BringToFront();
			// transición de creación de formulario
			var t = new Transition(new TransitionType_Deceleration(500));
				t.add(f, "Top", 0);
				t.run();
		}
		
		void Button_pacienteClick(object sender, EventArgs e)
		{
			var fa = sender as MaterialFlatButton; // se localiza el nombre del botón
				name = fa.Name;
			// Se crea formulario para añadir el paciente 
			FormAddPatient f = new FormAddPatient(name); // el argumento que se envía es el nombre del botón
				f.TopLevel = false;
				(this.Parent as Panel).Controls.Add(f);
				f.Parent = this;
				f.Show();
				f.Top = -f.Height;
				f.BringToFront();
			// transición de creación de formulario
			var t = new Transition(new TransitionType_Deceleration(500));
				t.add(f, "Top", 0);
				t.run();
		}
		
		public void addButton1(int type){
			
			//Console.WriteLine("" + count_btn1 + " " + count_btn2);
			//comprueba el valor que recibe de la función
			if(type == 1){
				//comprueba que no haya más de 10 botones
				if(count_btn1 < 10){
					// Se llama a la función createButton para crear un nuevo botón con su Text y su posición
					createButton("+ Añadir Huesped", button_huesped.Location.X, button_huesped.Location.Y + 40 * count_btn1);
				}	
			}else{
				//comprueba que no haya más de 10 botones
				if(count_btn2 < 10){
					// Se llama a la función createButton para crear un nuevo botón con su Text y su posición
					createButton("+ Añadir Paciente", button_paciente.Location.X, button_paciente.Location.Y + 40 * count_btn2);
				}	
			}
		}
		
	 	void createButton(String str, int x, int y){
		// Creación del botón y sus respectivos TODO: RESPECTIVOS QUE??? LUJIIII!	
			var btn = new MaterialFlatButton();
				btn.AutoSize = true;
				btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
				btn.Depth = 0;
				btn.Location = new System.Drawing.Point(x,y);
				btn.Name = (str == "+ Añadir Huesped") ? "btn" + count_btn1 : "btnP" + count_btn2; // Terniario para definir el nombre del botón
				btn.Primary = false;
				btn.Size = new System.Drawing.Size(145, 36);
				btn.Text = str;
				btn.Visible=true;
				btn.Click += (str == "+ Añadir Huesped") ? new System.EventHandler(this.Button_huespedClick) : new System.EventHandler(this.Button_pacienteClick); // ternario para definir a que función llamar

			this.Controls.Add(btn); // se agrega el botón a los controles del formulario
			lista.Add(btn);	
		
			if(str.Equals("+ Añadir Huesped")){ // If para comprobar que el str sea igual al argumento
				count_btn1++;	// contador huésped 
			}else{
				count_btn2++; // contador paciente
			}
		}
		
		public void ChangeBtn(string names,string a, string b){
			// for para encontrar el botón con el nombre recibido
			for(int j = 0;j<this.Controls.Count;j++){
				if(names == this.Controls[j].Name){
				// se cambia el texto del botón y se deshabilita				
					this.Controls[j].Text=" + " + a + " " + b;
					this.Controls[j].Enabled = false;
				}
			}

		}
		
		void MaterialFlatButton2Click(object sender, EventArgs e)
		{// transición que cierra el formulario principal
			var t = new Transition(new TransitionType_Acceleration(500));
				t.add(this, "Top", -this.Height);
				t.TransitionCompletedEvent += (_, __) => (Parent as Panel).Controls.Remove(this);
				t.run();
		}
		
		void insertGuest(){
		  
//		  DBConn.insertGuest(new Guest(txt_ficha.Text, text_nombre.Text, text_apellido.Text, int.Parse(text_habitacion.Text), text_locker.Text, "", "", combo_pais.Text, combo_servicio.Text){telefono = txt_phone.Text, internado = new Classes.Person(){name = "", surname = ""}, ingreso = DateTime.ParseExact(txt_date.Text, "dd-MM-yyyy", null)});
//			StaticForms.FAG.addButton1(1);		
//		  	StaticForms.FAG.ChangeBtn(name,text_nombre.Text,text_apellido.Text);
//			var t = new Transition(new TransitionType_Acceleration(500));
//				t.add(this, "Top", -this.Height);
//				t.TransitionCompletedEvent += (_, __) => this.Close();
//				t.run();
		}
	}
}
