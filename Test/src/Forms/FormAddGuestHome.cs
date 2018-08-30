/*
 * Created by SharpDevelop.
 * User: lujan
 * Date: 27/8/2018
 * Time: 09:01
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

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
			lista=new List<MaterialSkin.Controls.MaterialFlatButton>();
			lista.Add(button_huesped);
			lista.Add(button_paciente);

		}
		
		void Button_huespedClick(object sender, EventArgs e)
		{
			var fa = sender as MaterialSkin.Controls.MaterialFlatButton;
			name = fa.Name;
			FormAddGuest f = new FormAddGuest();
			f.ShowDialog();
			f.Location = this.Location;
						
		}
		
		void MaterialFlatButton1Click(object sender, EventArgs e)
		{
			var fa = sender as MaterialSkin.Controls.MaterialFlatButton;
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
			if(type ==1){
				if(count_btn1 < 10){
					createButton("+ añadir huesped ",button_huesped.Location.X,button_huesped.Location.Y + 40 * count_btn1);
				}	
			}else{
				if(count_btn2 < 10){
					createButton("+ añadir Paciente ",button_paciente.Location.X,button_paciente.Location.Y + 40 * count_btn2);
				}	
			}
		}
		
	 	void createButton(String str,int x,int y){
			
			MaterialSkin.Controls.MaterialFlatButton btn = new MaterialSkin.Controls.MaterialFlatButton();
			
			btn.AutoSize = true;
			btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			btn.Depth = 0;
			btn.Icon = null;
			btn.Location = new System.Drawing.Point(x,y);
			btn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
			btn.MouseState = MaterialSkin.MouseState.HOVER;
			if(str == "+ añadir huesped "){
				btn.Name = "btn" + count_btn1;
			}else{
				btn.Name = "btnP" + count_btn1;
			}
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
		public void ChangeBtn(string a,string b){
			Console.WriteLine(name);
			var xa = lista.Find(x => x.Name == name );
			xa.Text="+ "+a+" "+b;
			xa.Enabled=false;
		}
		
		void MaterialFlatButton2Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
		
	}
}
