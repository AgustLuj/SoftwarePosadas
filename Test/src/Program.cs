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
      
<<<<<<< HEAD
      var f = new Load();
      //StaticForms.MF.Show();
      f.Show();
=======
      #if DEBUG
        StaticForms.MF.Show();
      #else
        var f = new Load();
        f.Show();
      #endif
>>>>>>> 1e7bda8d72a0770e1095430235279be8ff5a66f0
      
      Application.Run();
    }
		
  }
}
