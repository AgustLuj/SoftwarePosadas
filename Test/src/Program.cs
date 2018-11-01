using System;
using Program.Forms;
using System.Windows.Forms;

namespace Program.Forms {

  internal sealed class Program {
 
    [STAThread]
    private static void Main(string[] args) {
      
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(true);
      
      //StaticForms.MF = new MainForm();
      
      var f = new Load();
      //StaticForms.MF.Show();
      f.Show();
      
      Application.Run();
    }
		
  }
}
