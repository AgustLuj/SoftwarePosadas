using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using AForge.Video;
using AForge.Video.DirectShow;
using System.IO;

namespace Program.Forms
{
	public partial class FormLoadPicture : Form
	{
		private bool ExistenDispositivos = false;
		private FilterInfoCollection DispositivosDeVideo;
		private VideoCaptureDevice FuenteDeVideo = null;
		public String file;
		
		public float zoom = 1;
		
		public FormLoadPicture()
		{
			InitializeComponent();
	        
	        label1.Parent = pictureBox1;
			BuscarDispositivos();
			
			Cursor.Current = Cursors.Default;
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
					
					int xpix = (int) (label1.Location.X + x * zoom);
					int ypix = (int) (label1.Location.Y + y * zoom);
					
					if(xpix >= 0 && ypix >= 0 && xpix < 500 && ypix < 400){
						crop.SetPixel(x,y,picture.GetPixel(xpix,ypix));
					}else{
						crop.SetPixel(x,y,Color.White);
					}
				}
			}
			
			pictureBox2.Image = crop;
		}
		int a = 0;
		
		void Button1Click(object sender, EventArgs e)
		{
			if (button1.Text == "Iniciar"){
				
				if (ExistenDispositivos){
					
					FuenteDeVideo = new VideoCaptureDevice(DispositivosDeVideo[comboBox1.SelectedIndex].MonikerString);			
					FuenteDeVideo.NewFrame += new NewFrameEventHandler(video_NuevoFrame);
					FuenteDeVideo.Start();
					
					button1.Text = "Detener";
					
					comboBox1.Enabled = false;
					comboBox1.Text = DispositivosDeVideo[comboBox1.SelectedIndex].Name.ToString();
				}else{	
			 		MessageBox.Show("Error: No se encuentra dispositivo.");
				}
			}else{
				if(FuenteDeVideo.IsRunning){
					TerminarFuenteDeVideo();
					button1.Text = "Iniciar";
					comboBox1.Enabled=true;
				}
			}
		}
		public void CargarDispositivos(FilterInfoCollection Dispositivos){
			
			for (int i = 0; i < Dispositivos.Count; i++){
				
				comboBox1.Items.Add(Dispositivos[i].Name.ToString());	
				comboBox1.Text = comboBox1.Items[0].ToString();
			} 

		}
		public void BuscarDispositivos(){

			DispositivosDeVideo = new FilterInfoCollection(FilterCategory.VideoInputDevice);

			if (DispositivosDeVideo.Count == 0){
				ExistenDispositivos = false;	
			}else{

				ExistenDispositivos = true;

				CargarDispositivos(DispositivosDeVideo);
			}

		} 
		public void TerminarFuenteDeVideo(){
			
			if (!(FuenteDeVideo == null)){
					if (FuenteDeVideo.IsRunning){
						FuenteDeVideo.SignalToStop();
						FuenteDeVideo =	null;
					}
			}
		}
		private void video_NuevoFrame(object sender, NewFrameEventArgs eventArgs){
			
				Bitmap CameraImage = (Bitmap)eventArgs.Frame.Clone();		
				pictureBox1.Image = CameraImage;
				
		} 
		
		void Label1MouseMove(object sender, MouseEventArgs e)
		{	
			
			int size = (int) (zoom * 100);
			
			if(label1.Location.X < 0){
				label1.SetBounds(0,label1.Location.Y,size,size);
			}
			
			if(label1.Location.Y < 0){
				label1.SetBounds(label1.Location.X,0,size,size);
			}
			
			if(label1.Location.X + size > 499){
				label1.SetBounds(500 - size,label1.Location.Y,size,size);
			}
			
			if(label1.Location.Y + size > 399){
				label1.SetBounds(label1.Location.X,400 - size,size,size);
			}
			
		}
		
		void TrackBar1Scroll(object sender, EventArgs e)
		{
			zoom = 1 + (trackBar1.Value) / 10f;
				
			label1.Size = new Size(new Point((int) (zoom * 100),(int) (zoom * 100)));
		}
	}
	}
