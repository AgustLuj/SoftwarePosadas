using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;

namespace Program.Forms
{
	public partial class FormLoadPicture : Form
	{
		
		public String file;
		
		public FormLoadPicture()
		{
			InitializeComponent();
	        
	        label1.Parent = pictureBox1;
			
		} 
				
		
		[DllImport("user32.dll",EntryPoint = "ReleaseCapture")]
		private extern static void ReleaseCapture();
		[DllImport("user32.dll",EntryPoint = "SendMessage")]
		private extern static void SendMessage(System.IntPtr hwnd,int wMsg, int wParam, int lParam);
		
		void Label1MouseDown(object sender, MouseEventArgs e)
		{
			ReleaseCapture();
			SendMessage(label1.Handle,0x112,0xf012,0);
			
			
		}
		
		void MaterialFlatButton1Click(object sender, EventArgs e)
		{
			int size = -1;
		    DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.
		    
		    if (result == DialogResult.OK) // Test result.
		    {
		       file = openFileDialog1.FileName;
		       
		       try
		       {
		          string text = File.ReadAllText(file);
		          size = text.Length;
		          
		          Bitmap bmp = new Bitmap(file);
		          UInt32[] rgb = new UInt32[100*100];
		          
		          for(int x = 0;x < 100;x++){
		          	for(int y = 0; y < 100;y++){
		          		
		          		rgb[y * 100 + x] = Classes.Photo.RGBtoUint(bmp.GetPixel(x,y).R,bmp.GetPixel(x,y).G,bmp.GetPixel(x,y).B);
		          	}
		          }
		          
		          Classes.Photo.Send(rgb);
		          String ret = Classes.Photo.Get();
		          
		          Bitmap bmp2 = new Bitmap(file);
		          UInt32[] rgb2 = new UInt32[100*100];
		          
		          int f = 0;
		          String n = "";
		          
		          for(int i = 0;i < ret.Length;i++){
		          	
		          	String c = ret.Substring(i,1);
		          	
		          	if(c == "," || c == "]"){
		          		
		          		rgb2[f] = (UInt32) (int.Parse(n));
		          		
		          		n = "";
		          		f++;
		          		
		          	}else if(c != "["){
		          		n += c;
		          	}
		          }
		          
		          for(int x = 0;x < 100;x++){
		          	for(int y = 0; y < 100;y++){		
		          			
		          		bmp2.SetPixel(x,y,Color.FromArgb((int)(rgb2[y * 100 + x])));
		          	}
		          }
		          
		          pictureBox1.Image = bmp2;
		       }
		       catch (IOException){}	
		}
	}
		
		void MaterialFlatButton2Click(object sender, EventArgs e)
		{
			Bitmap picture = new Bitmap(file);
			Bitmap crop = new Bitmap(100,100);
			
			for(int x = 0;x < 100;x++){
				for(int y = 0;y < 100;y++){
					
					crop.SetPixel(x,y,picture.GetPixel(x + label1.Location.X,y + label1.Location.Y));
				}
			}
			
			pictureBox2.Image = crop;
		}
}
}
