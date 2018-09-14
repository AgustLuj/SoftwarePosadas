/*
 * Created by SharpDevelop.
 * User: lujan
 * Date: 31/8/2018
 * Time: 10:46
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace Program.Forms
{
	/// <summary>
	/// Description of FormSearchGuest.
	/// </summary>
	public partial class FormSearchGuest : Form
	{
		public FormSearchGuest()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void MaterialFlatButton1Click(object sender, EventArgs e)
		{	
			
			int size = -1;
		    DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.
		    
		    if (result == DialogResult.OK) // Test result.
		    {
		       string file = openFileDialog1.FileName;
		       
		       try
		       {
		          string text = File.ReadAllText(file);
		          size = text.Length;
		          
		          Bitmap bmp = new Bitmap(file);
		          
		          UInt32[] rgb = new UInt32[100*100];
		          
		          for(int x = 0;x < 100;x++){
		          	for(int y = 0; y < 100;y++){
		          		
		          		rgb[y * 100 + x] = RGBtoUint(bmp.GetPixel(x,y).R,bmp.GetPixel(x,y).G,bmp.GetPixel(x,y).B);
		          	}
		          }
		          
		          for(int x = 0;x < 100;x++){
		          	for(int y = 0; y < 100;y++){		
		          			
		          		bmp.SetPixel(x,y,Color.FromArgb((int)(rgb[y * 100 + x])));
		          	}
		          }
		          
		          send(rgb);
		          
		          pictureBox1.Image = bmp;
		       }
		       catch (IOException){}
		    }
		}
		
		void MaterialFlatButton2Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
		
		UInt32 RGBtoUint(int r,int g,int b){
			
			return (UInt32) ((r << 16) | (g << 8) | b);
		}
		
		string send(UInt32[] rgb){
			
			int size = rgb.Length;
			int size2 = rgb.Length / 2;
			
			string json = "{";
			
			for(int i = 0;i < size2;i++){
				
				if(i != size2-1){
					json += "\""+ i +"\":"+ rgb[i] +",";
				}else {
					json += "\""+ i +"\":"+ rgb[i];
				}
			}
			
			json += "}";
			
			Classes.Class1.TestPOSTWebRequest(json);
			
			json = "{";
			
			for(int i =  size2;i < size;i++){
				
				if(i != size-1){
					json += "\""+ i +"\":"+ rgb[i] +",";
				}else {
					json += "\""+ i +"\":"+ rgb[i];
				}
			}
			
			json += "}";
			
			Classes.Class1.TestPOSTWebRequest(json);
			
			return json;				
		}
	
	}
}
