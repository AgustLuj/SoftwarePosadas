using System;
using System.Drawing;
using System.Windows.Forms;

namespace Program.Forms
{

  public partial class FormStatsHome : Form
  {
    public FormStatsHome()
    {
      
      InitializeComponent();
      
   
    }
    
    void FormStatsHomeLoad(object sender, EventArgs e)
    {
    	
    }
    
    void Radio_historicoCheckedChanged(object sender, EventArgs e)
	{
		  if(radio_historico.Checked){
		    showCustomFilter(false);
		  }
	}
		
	void Radio_personalizadoCheckedChanged(object sender, EventArgs e)
	{
	    if(radio_personalizado.Checked){
	      showCustomFilter(true);
		  }
	}
	
	void showCustomFilter(bool show){
	    
      check_año.Visible = show;
	    combo_año.Visible = show;
	    
	    check_mes.Visible = show;
	    combo_mes.Visible = show;
	    
	    check_dia.Visible = show;
	    combo_dia.Visible = show;
	}
	
	void Check_añoCheckedChanged(object sender, EventArgs e)
	{
      if(check_año.Checked){
        combo_año.Enabled = true;
		  }else{
        combo_año.Enabled = false;
      }
	}
	
	void Check_mesCheckedChanged(object sender, EventArgs e)
	{
	  if(check_mes.Checked){
	    combo_mes.Enabled = true;  
	  }else{
	    combo_mes.Enabled = false;
	  }
	}
	
	void Check_diaCheckedChanged(object sender, EventArgs e)
	{
	  if(check_dia.Checked){
	    combo_dia.Enabled = true;
	  }else{
	    combo_dia.Enabled = false;
	  }
	}
  }
}
