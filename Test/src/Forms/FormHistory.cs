using System;
using System.Drawing;
using System.Windows.Forms;
//no completadoo
namespace Program.Forms
{
	public partial class FormHistory : Form
	{
		public FormHistory()
		{
			InitializeComponent();
			materialLabel2.Text += Classes.History.send(1,"la tabla Huéspedes");
		}
	}
}
