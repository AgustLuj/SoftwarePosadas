using System;
using System.Drawing;
using System.Windows.Forms;

namespace Program.Forms
{
	public partial class FormAddGuest : Form
	{
		public FormAddGuest()
		{
			InitializeComponent();
		}
		
		void MaterialFlatButton1Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		
		void MaterialCheckBox2CheckedChanged(object sender, EventArgs e)
		{
			if(materialCheckBox2.Checked == false){
				materialSingleLineTextField7.Enabled=true;
				materialSingleLineTextField7.Text = "";
			}else{
				materialSingleLineTextField7.Enabled=false;
				materialSingleLineTextField7.Text = "23/06/2017";
			}
		}
		
		void FormAddGuestLoad(object sender, EventArgs e)
		{
			materialSingleLineTextField7.Text = "23/06/2017";
		}
	}
}
