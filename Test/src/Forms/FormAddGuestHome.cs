/* Created by Lujan. Refactorized by Mateo Pidal
 * User: lujan
 * Date: 27/8/2018
 * Time: 09:01
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

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
				//(this.Parent as Panel).Controls.Add(f);
				f.Parent = this;
				f.Show();
				f.Top = - f.Height;
				f.BringToFront();
			
			var t = new Transition(new TransitionType_Deceleration(500));
				t.add(f, "Top", 0);
				t.run();

			//f.Location = this.Location;		
		}
		
		void MaterialFlatButton1Click(object sender, EventArgs e)
		{
			var fa = sender as MaterialFlatButton;
				name = fa.Name;
			
			FormAddPatient f = new FormAddPatient();
				f.ShowDialog();
				f.Location = this.Location;
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
			
			var btn = new MaterialFlatButton();	
				btn.AutoSize = true;
				btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
				btn.Depth = 0;
				btn.Icon = null;
				btn.Location = new System.Drawing.Point(x,y);
				btn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
				btn.MouseState = MaterialSkin.MouseState.HOVER;
				btn.Name = (str == "+ añadir huesped ") ? "btn" : "btnP" + count_btn1;
				btn.Primary = false;
				btn.Size = new System.Drawing.Size(145, 36);
				btn.TabIndex = 1;
				btn.Text = str;
				btn.UseVisualStyleBackColor = true;
			
			if(str == "+ añadir huesped "){
				btn.Click += new System.EventHandler(this.Button_huespedClick);
			}else{
				btn.Click += new System.EventHandler(this.MaterialFlatButton1Click);
			}
			
			this.Controls.Add(btn);
			lista.Add(btn);
			
			if(str == "+ añadir huesped "){
				count_btn1++;	
			}else{
				count_btn2++;
			}
		}
		public void ChangeBtn(string a, string b){
			var xa = lista.Find(x => x.Name == name );
				xa.Text = " + " + a + " " + b;
				xa.Enabled = false;
		}
		
		void MaterialFlatButton2Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
	}
}
