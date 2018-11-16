using System;
using System.Linq;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using Transitions;
using Program.StaticClasses;

//PIDAAAAAAL COMENTA EL CODIGO
namespace Program.Forms
{

  public partial class FormStatsQuantity : Form
  {
  	public int[] values = new int[30];
  	public float max_value = 0f;
  	
    public Classes.Image bitmap;
    public List<Label> texts = new List<Label>();
    public List<MaterialSkin.Controls.MaterialLabel> texts2 = new List<MaterialSkin.Controls.MaterialLabel>();
    
    public FormStatsQuantity(int[] val)
    {
    	values = val;
    	
		for(int i = 0;i < values.Length;i++){
    		createText((i+1)+"/10",4 + i * 40,205);
		}
    	
    	for(var i = 0;i < values.Length;i++){createText2("120",300,300);}
    	
		InitializeComponent();
		
		for(int i = 0;i < texts.Count;i++){
			
			panel1.Controls.Add(texts[i]);
			panel1.Controls.Add(texts2[i]);
			
			texts[i].BringToFront();
			texts2[i].BringToFront();
		}
		
		bitmap = new Classes.Image(pic.Width,pic.Height);
		
		//loading of values		
		var guests = DBConn.getTotalGuests("where ingreso > '2018-09-30' and ingreso < '2018-11-1'")/*from g in DBConn.getGuests()
		  where g.ingreso > DateTime.Parse("30/9/2018") && g.ingreso < DateTime.Parse("1/11/2018")
		  select g*/;
		
		guests.ForEach(x => Console.WriteLine(x.ingreso.ToShortDateString()));
		
		for(int i = 0;i < values.Length;i++){
		  var s = (i + 1).ToString() + "/10/2018";
		  values[i] = guests.FindAll(x => x.ingreso.Date == DateTime.Parse(s)).Count;
		}
		
		//get of max value
		
		for(int i = 0;i < values.Length;i++){
			if(values[i] > max_value){
				max_value = values[i];
			}
		}
		
		for(int i = 0;i < values.Length;i++){
			
		  bitmap.graph(i * 40,200,values[i]/((max_value == 0) ? 1 : max_value),36,170,0);
			
			int offx = 5;
			if(values[i] < 10){offx = 10;}
			
			texts2[i].Location = new System.Drawing.Point(pic.Location.X + offx + 40 * i,(int) (pic.Location.Y + 175 - ((float) (values[i] / ((max_value == 0) ? 1 : max_value)) * 170)));
			texts2[i].Text = "" + values[i];
		}
		
		pic.Image = bitmap.getBitmap();
    }
  
  
    public void createText(string str,int x,int y){
		
		var text = new Label();
		  
		text.Name = "t"+x+y;
		text.AutoSize = true;
		text.Text = str;
		text.Location = new System.Drawing.Point(x,y);
		
		texts.Add(text);
	}
	
	public void createText2(string str,int x,int y){
		
		var text = new MaterialSkin.Controls.MaterialLabel();
		  
		text.Name = "t"+x+y;
		text.AutoSize = true;
		text.Text = str;
		text.Location = new System.Drawing.Point(x,y);
		
		texts2.Add(text);
	}
    
    void MaterialFlatButton1Click(object sender, EventArgs e)
    {
    	var t = new Transition(new TransitionType_Acceleration(500));
				t.add(this, "Top", -this.Height);
				t.TransitionCompletedEvent += (_, __) => this.Close();
				t.run();
    }
}
}
