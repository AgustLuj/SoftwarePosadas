using System;
using System.Drawing;
using System.Windows.Forms;
using Transitions;

using Program.StaticClasses;

namespace Program.Forms
{

  public partial class FormStatsHome : Form
  {
    public FormStatsHome()
    {
      InitializeComponent();
    }
    
    void filterChanged(object sender, EventArgs e){
      showCustomFilter(rad_filter_personalized.Checked);
      showPeriodFilter(rad_filter_period.Checked);
      
      for (int i = 2016; i < DateTime.Now.Year + 1; i++) {
        cmb_year.Items.Add(i);
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
    
    void MaterialFlatButton2Click(object sender, EventArgs e)
    {
    	int[] values = new int[getNDays(cmb_month.SelectedIndex + 1)];
    	var guests = DBConn.getTotalGuests("where ingreso > '2018-09-30' and ingreso < '2018-11-1'");
    	
  		for(int i = 0;i < values.Length;i++){
  			var s = (i + 1).ToString() + "/10/2018";
		  values[i] = guests.FindAll(x => x.ingreso.Date == DateTime.Parse(s)).Count;
  		}
    	
    	if(radio_quantity.Checked){
    	  FormStatsQuantity f = new FormStatsQuantity(values, cmb_month.SelectedIndex + 1, int.Parse(cmb_year.Text));
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
    
    void Cmb_monthSelectedIndexChanged(object sender, EventArgs e)
    {
      Console.WriteLine(getNDays(cmb_month.SelectedIndex + 1));
    }
    
    int getNDays(int month){
      switch (month) {
        case 1:
          return 31;
        case 2:
          return (int.Parse(cmb_year.Text) % 4 == 0) ? 29 : 28;
        case 3:
          return 31;
        case 4:
          return 30;
        case 5:
          return 31;
        case 6:
          return 30;
        case 7:
          return 31;
        case 8:
          return 31;
        case 9:
          return 30;
        case 10:
          return 31;
        case 11:
          return 30;
        case 12:
          return 31;
      }
      return -1;
    }
    
    void Cmb_yearSelectedIndexChanged(object sender, EventArgs e)
    {
      cmb_month.Enabled = true;
    }
  }
}
