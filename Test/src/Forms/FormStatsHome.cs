using System;
using System.Drawing;
using System.Windows.Forms;
using Transitions;

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
		    showPeriodFilter(false);
		  }
	}
		
	void Radio_personalizadoCheckedChanged(object sender, EventArgs e)
	{
	    if(radio_personalizado.Checked){
	      showCustomFilter(true);
	      showPeriodFilter(false);
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
	
	void showPeriodFilter(bool show){
		
		label_from.Visible = show;
		label_to.Visible = show;
		
		field_from.Visible = show;
		field_to.Visible = show;
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
    
    void Button_originClick(object sender, EventArgs e)
    {
    	
    }
    
    void Combo_añoSelectedIndexChanged(object sender, EventArgs e)
    {
    	
    }
    
    void MaterialRadioButton1CheckedChanged(object sender, EventArgs e)
    {
    	if(materialRadioButton1.Checked){
    		showCustomFilter(false);
    		showPeriodFilter(true);
    	}
    }
    
    void MaterialLabel3Click(object sender, EventArgs e)
    {
    	
    }
    
    void MaterialRadioButton2CheckedChanged(object sender, EventArgs e)
    {
    	
    }
    
    void MaterialFlatButton2Click(object sender, EventArgs e)
    {
    	Random rnd = new Random();
    	int[] values = new int[30];
    	
		for(int i = 0;i < values.Length;i++){
			values[i] = rnd.Next(50);
		}
    	if(radio_origin.Checked && radio_quantity.Checked){
    		if(radio_quantity.Checked){
    			FormStatsQuantity f = new FormStatsQuantity(values);
					f.TopLevel = false;
					(this.Parent as Panel).Controls.Add(f);
					f.Parent = this;
					f.Show();
					f.Top = - f.Height;
					//f.BringToFront();
				
				var t = new Transition(new TransitionType_Deceleration(500));
					t.add(f, "Top", 0);
					t.run();	
    			
    		}
    	}
    }
  }
}
