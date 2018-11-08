/* Created by Lujan. Refactorized by Mateo Pidal
 * User: lujan
 * Date: 27/8/2018
 * Time: 09:01
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

using Program.Classes;

using MaterialSkin.Controls;

using Transitions;

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
		
		void Button_huespedClick(object sender, EventArgs e)
		{
			var fa = sender as MaterialFlatButton;
				names = fa.Name;
				
			FormAddGuest f = new FormAddGuest(names);
				f.TopLevel = false;
				(this.Parent as Panel).Controls.Add(f);
				f.Parent = this;
				f.Show();
				f.Top = - f.Height;
				f.BringToFront();
			
			var t = new Transition(new TransitionType_Deceleration(500));
				t.add(f, "Top", 0);
				t.run();

			//f.Location = this.Location;		
		}
		
		void Button_pacienteClick(object sender, EventArgs e)
		{
			var fa = sender as MaterialFlatButton;
				name = fa.Name;
			FormAddPatient f = new FormAddPatient(name);
				f.TopLevel = false;
				(this.Parent as Panel).Controls.Add(f);
				f.Parent = this;
				f.Show();
				f.Top = - f.Height;
				f.BringToFront();
			
			var t = new Transition(new TransitionType_Deceleration(500));
				t.add(f, "Top", 0);
				t.run();
				
				//f.Location = this.Location;
		}
		
		void FormAddGuestHomeFormClosed(object sender, FormClosedEventArgs e)
		{
			if (Application.OpenForms.Count == 0) {
				Application.Exit();
			}
		}
		
		public void addButton1(int type){
			if(type == 1){
				if(count_btn1 < 10){
					createButton("+ añadir Huesped", button_huesped.Location.X, button_huesped.Location.Y + 40 * count_btn1);
				}	
			}else{
				if(count_btn2 < 10){
					createButton("+ añadir Paciente", button_paciente.Location.X, button_paciente.Location.Y + 40 * count_btn2);
				}	
			}
		}
		
	 	void createButton(String str, int x, int y){
			
			var btn = new MaterialFlatButton();
				btn.AutoSize = true;
				btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
				btn.Depth = 0;
				btn.Location = new System.Drawing.Point(x,y);
				btn.Name = (str == "+ añadir Huesped") ? "btn"+ count_btn1 : "btnP" + count_btn2;
				btn.Primary = false;
				btn.Size = new System.Drawing.Size(145, 36);
				btn.Text = str;
				btn.Visible=true;
				btn.Click += (str == "+ añadir Huesped") ? new System.EventHandler(this.Button_huespedClick) : new System.EventHandler(this.Button_pacienteClick);
			
			this.Controls.Add(btn);
			lista.Add(btn);
			
			if(str == "+ Añadir huesped"){
				count_btn1++;	
			}else{
				count_btn2++;
			}
		}
		
		public void ChangeBtn(string names,string a, string b){
			Console.WriteLine(names);
			for(int j = 0;j<this.Controls.Count;j++){
				if(names == this.Controls[j].Name){
					this.Controls[j].Text=" + " + a + " " + b;
					this.Controls[j].Enabled = false;
				}
			}

		}
		
		void MaterialFlatButton2Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
		
		void MaterialFlatButton1Click(object sender, EventArgs e)
		{

		}
		
		void FormAddGuestHomeLoad(object sender, EventArgs e)
		{
			
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
