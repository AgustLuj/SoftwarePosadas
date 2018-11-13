/*
 * Created by SharpDevelop.
 * User: lujan
 * Date: 4/9/2018
 * Time: 08:52
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Program.Forms
{
	/// <summary>
	/// Description of FormHistory.
	/// </summary>
	public partial class FormHistory : Form
	{
		public FormHistory()
		{
			InitializeComponent();
			materialLabel2.Text += Classes.History.send(1,"la tabla Huéspedes");
		}
	}
}
