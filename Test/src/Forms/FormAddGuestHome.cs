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
				name = fa.Name;
			
			FormAddGuest f = new FormAddGuest();
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
					createButton("+ añadir huesped ", button_huesped.Location.X, button_huesped.Location.Y + 40 * count_btn1);
				}	
			}else{
				if(count_btn2 < 10){
					createButton("+ añadir Paciente ", button_paciente.Location.X, button_paciente.Location.Y + 40 * count_btn2);
				}	
			}
		}
		
	 	void createButton(String str, int x, int y){
		  
		  Console.WriteLine(String.Format("str: {0}, x: {1}, y: {2}", str, x, y));
			
			var btn = new MaterialFlatButton();
				btn.AutoSize = true;
				btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
				btn.Depth = 0;
				btn.Location = new System.Drawing.Point(x,y);
				btn.Name = (str == "+ añadir huesped ") ? "btn"+ count_btn1 : "btnP" + count_btn2;
				btn.Primary = false;
				btn.Size = new System.Drawing.Size(145, 36);
				btn.Text = str;
			
			if(str == "+ Añadir huesped "){
				btn.Click += new System.EventHandler(this.Button_huespedClick);
			}else{
				btn.Click += new System.EventHandler(this.MaterialFlatButton1Click);
			}
			this.Controls.Add(btn);
			btn.BringToFront();
			
			lista.Add(btn);
			
			if(str == "+ Añadir huesped "){
				count_btn1++;	
			}else{
				count_btn2++;
			}
		  Console.WriteLine("yep");
		}
		
		public void ChangeBtn(string names,string a, string b){
			/*for(int j = 0;j<this.Controls.Count;j++){
				if(names == this.Controls[j].Name){
					this.Controls[j].Text=" + " + a + " " + b;
					this.Controls[j].Enabled = false;
				}
			}*/

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
		
		void MaterialRaisedButton1Click(object sender, EventArgs e)
		{
		  addButton1(2);
		}
	}
}
