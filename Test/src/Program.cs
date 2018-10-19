/*
 * Created by SharpDevelop.
 * User: Alumnos
 * Date: 09/08/2018
 * Time: 14:23
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using Program.Forms;
using System.Windows.Forms;

namespace Program.Forms {
  /// <summary>
  /// Class with program entry point.
  /// </summary>
  internal sealed class Program {
    /// <summary>
    /// Program entry point.
    /// </summary>
    [STAThread]
    private static void Main(string[] args) {
      
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(true);
      
      StaticForms.MF = new MainForm();
      
      //var f = new MainForm();
      StaticForms.MF.Show();
      
      Application.Run();
    }
		
  }
}
