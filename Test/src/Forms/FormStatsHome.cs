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
    
    void filterChanged(object sender, EventArgs e){
      showCustomFilter(rad_filter_personalized.Checked);
      showPeriodFilter(rad_filter_period.Checked);
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
      combo_año.Enabled = check_año.Checked;
  	}
	
  	void Check_mesCheckedChanged(object sender, EventArgs e)
  	{
      combo_mes.Enabled = check_mes.Checked;
  	}
	
  	void Check_diaCheckedChanged(object sender, EventArgs e)
  	{
      combo_dia.Enabled = check_dia.Checked;
  	}
    
    void Button_originClick(object sender, EventArgs e)
    {
    	
    }
    
    void Combo_añoSelectedIndexChanged(object sender, EventArgs e)
    {
    	
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
    	
    	if(radio_quantity.Checked){
    			FormStatsQuantity f = new FormStatsQuantity(values);
					f.TopLevel = false;
					(this.Parent as Panel).Controls.Add(f);
					f.Parent = this;
					f.Show();
					f.Top = - f.Height;
					f.BringToFront();
				
				var t = new Transition(new TransitionType_Deceleration(500));
					t.add(f, "Top", 0);
					t.run();	
    			
    	}else if(radio_origin.Checked){
    		FormStatsOrigin f = new FormStatsOrigin(values);
					f.TopLevel = false;
					(this.Parent as Panel).Controls.Add(f);
					f.Parent = this;
					f.Show();
					f.Top = - f.Height;
					f.BringToFront();
				
				var t = new Transition(new TransitionType_Deceleration(500));
					t.add(f, "Top", 0);
					t.run();
    	}
    }
  }
}
