using System;
using System.Drawing;
using System.Windows.Forms;

namespace Program.Forms
{
	public partial class FormStats : Form
	{	
		public float[] values = new float[24];
		public float[] aux_values = new float[24];
		
		public Classes.Image bitmap;
		public float timer = 0f;
		
		public FormStats()
		{
		
			InitializeComponent();
			
		}
		
		void FormStatsLoad(object sender, EventArgs e)
		{	
			
			bitmap = new Classes.Image(pic.Width,pic.Height);
			
			//loading of values
			Random rnd = new Random();
			
			for(var i = 0;i < values.Length;i++){
				values[i] = 0.1f + rnd.Next(24) / 24f;
				aux_values[i] = 0f;
			}
			
			timer1.Start();
		}
		
		void Timer1Tick(object sender, EventArgs e)
		{	
			
			bool flag = false;
			
			for(var i = 0;i < values.Length;i++){
				
				if(aux_values[i] < values[i]){
					aux_values[i] += 0.15f;
					flag = true;
				}else{
					aux_values[i] = values[i];
				}
			}
			
			if(flag){
			
				//drawing of graphs
				
				bitmap.clear();
						
				for(int i = 0;i < 24;i++){
					bitmap.graph(26 * i,150,aux_values[i],22,130,0);
				}
				
				pic.Image = bitmap.getBitmap();
			}
		}

	
	}
}
