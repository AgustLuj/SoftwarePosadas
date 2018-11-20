using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using Transitions;

//PIDAAAAAAL COMENTA EL CODIGO
namespace Program.Forms
{
	public partial class FormStatsOrigin : Form
	{	
		public int[] values = new int[24];
		public float max_value = 0;
		
		public List<MaterialSkin.Controls.MaterialLabel> texts = new List<MaterialSkin.Controls.MaterialLabel>();
		
		public Classes.Image bitmap;
		public float timer = 0f;
		
		public FormStatsOrigin(int[] val)
		{
			values = val;
			
		  	for(var i = 0;i < 24;i++){createText("120",300,300);}
		  
			InitializeComponent();
			
			bitmap = new Classes.Image(pic.Width,pic.Height);
			
			//loading of values
			
			Random rnd = new Random();
			
			for(var i = 0;i < values.Length;i++){
			  values[i] = rnd.Next(50);
			}
			
			//get max value
			
			for(int i = 0;i < values.Length;i++){
			  if(values[i] > max_value){
			    max_value = values[i];
			  }
			}
			
			//drawing of graphs
		  
			int w = 26;
			
			if(max_value > 0){
			  
	  			bitmap.clear();
	  					
	  			for(int i = 0;i < 24;i++){
	  			  
	  			  float v = (float)(values[i] / max_value);
	  			  
	  			  if(v < 0.162f && v != 0f){v = 0.162f;}
	  			  
	  			  bitmap.graph(w * i,150,v,22,130,0);
	  			  
	  			  int offx = 0;
	  			  
	  			  texts[i].Text = ""+values[i];
	  			  
	  			  if(values[i] < 10){offx = 4;}
	  			  
	  			  texts[i].Location = new System.Drawing.Point(pic.Location.X + offx + w * i,(int) (pic.Location.Y + 125 - ((float) (values[i] / max_value) * 130)));
	  			  
	  			  if(texts[i].Location.Y > pic.Location.Y + 130 - 25){
	  			   texts[i].Location = new System.Drawing.Point(pic.Location.X + offx + w * i,pic.Location.Y + 130 - 25);
	  			  }
  				}
  			
  				pic.Image = bitmap.getBitmap();
			}
		}
		
		void FormStatsLoad(object sender, EventArgs e)
		{	
			
		}
		
		void createText(string str,int x,int y){
		  
		  var text = new MaterialSkin.Controls.MaterialLabel();
		  
		  text.Name = "t"+x+y;
		  text.AutoSize = true;
		  text.Text = str;
		  text.Location = new System.Drawing.Point(x,y);
		  
		  this.Controls.Add(text);
		  texts.Add(text);
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
