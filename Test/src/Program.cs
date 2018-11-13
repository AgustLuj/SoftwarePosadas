using System;
using Program.Forms;
using System.Windows.Forms;

namespace Program.Forms {

  internal sealed class Program {
 
    [STAThread]
    private static void Main(string[] args) {
      
    Application.EnableVisualStyles();
    
    StaticForms.MF = new MainForm();
    
    StaticForms.FSH = new FormStatsHome();
      StaticForms.FSH.TopLevel = false;
    
    StaticForms.FAG = new FormAddGuestHome();
      StaticForms.FAG.TopLevel = false;
    
    StaticForms.FG = new FormGuests();
      StaticForms.FG.TopLevel = false;
      
    #if DEBUG
      StaticForms.MF.Show();
      //new Load().Show();
    #else
      var f = new FormHistory();
      f.Show();
    #endif
    
    Application.Run();
    }
		
  }
}
