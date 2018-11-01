using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;

using AForge.Video;
using AForge.Video.DirectShow;

using Transitions;

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
	        
	    lbl_croparea.Parent = pic_bigphoto;
			Cursor.Current = Cursors.Default;
		} 
				
		
		[DllImport("user32.dll",EntryPoint = "ReleaseCapture")]
		private extern static void ReleaseCapture();
		[DllImport("user32.dll",EntryPoint = "SendMessage")]
		private extern static void SendMessage(System.IntPtr hwnd,int wMsg, int wParam, int lParam);
		
		void Label1MouseDown(object sender, MouseEventArgs e)
		{
			ReleaseCapture();
			SendMessage(lbl_croparea.Handle,0x112,0xf012,0);
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
		       		pic_photo.Visible=true;
    					btn_crop.Visible=true;
    					btn_loadpic.Visible=false;
			        btn_takepic.Visible=false;
    					tbr_zoom.Visible=true;
    					pic_photo.Visible=true;
    					lbl_zoom.Visible = true;
    					lbl_croparea.Visible = true;
		       	
		          string text = File.ReadAllText(file);
		          size = text.Length;
		          
		          Bitmap bmp = new Bitmap(file);
		          Bitmap bmp2 = new Bitmap(bmp);
		          
		          UInt32[] rgb = new UInt32[100*100];
		          
		          for(int x = 0;x < 100;x++){
		          	for(int y = 0; y < 100;y++){
		          		
		          		rgb[y * 100 + x] = Classes.Photo.RGBtoUint(bmp.GetPixel(x,y).R,bmp.GetPixel(x,y).G,bmp.GetPixel(x,y).B);
		          	}
		          }
		          
		         /* String numb = Classes.Photo.Send(rgb);
		          String ret = Classes.Photo.getToServerNumb(numb);
		          
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
		          }*/
		          
		          for(int x = 0;x < 100;x++){
		          	for(int y = 0; y < 100;y++){		
		          		//bmp2.SetPixel(x,y,Color.FromArgb((int)(rgb2[y * 100 + x])));
		          		bmp2.SetPixel(x,y,Color.FromArgb((int)(rgb[y * 100 + x])));
		          	}
		          }
		          
		          pic_bigphoto.Image = bmp;
		          
		          //hay que hacer el zoom de la foto original acá 
		       }
		       catch (IOException){}	
		}
	}
		
		void MaterialFlatButton2Click(object sender, EventArgs e)
		{
			Bitmap picture = new Bitmap(pic_bigphoto.Image, 500, 400);
			Bitmap crop = new Bitmap(100,100);
			
			for(int x = 0;x < 100;x++){
				for(int y = 0;y < 100;y++){
					
					int xpix = (int) (lbl_croparea.Location.X + x * zoom);
					int ypix = (int) (lbl_croparea.Location.Y + y * zoom);
					
					if(xpix >= 0 && ypix >= 0 && xpix < 500 && ypix < 400){
						crop.SetPixel(x,y,picture.GetPixel(xpix,ypix));
					}else{
						crop.SetPixel(x,y,Color.White);
					}
				}
			}
			
			pic_photo.Image = crop;
		}
		
		void Button1Click(object sender, EventArgs e)
		{
				
				
		}
		public void CargarDispositivos(FilterInfoCollection Dispositivos){
			
			for (int i = 0; i < Dispositivos.Count; i++){
				
				cmb_devices.Items.Add(Dispositivos[i].Name.ToString());	
				cmb_devices.Text = cmb_devices.Items[0].ToString();
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
				pic_bigphoto.Image = CameraImage;
				
		} 
		
		void Label1MouseMove(object sender, MouseEventArgs e)
		{	
			
			int size = (int) (zoom * 100);
			
			if(lbl_croparea.Location.X < 0){
				lbl_croparea.SetBounds(0,lbl_croparea.Location.Y,size,size);
			}
			
			if(lbl_croparea.Location.Y < 0){
				lbl_croparea.SetBounds(lbl_croparea.Location.X,0,size,size);
			}
			
			if(lbl_croparea.Location.X + size > 499){
				lbl_croparea.SetBounds(500 - size,lbl_croparea.Location.Y,size,size);
			}
			
			if(lbl_croparea.Location.Y + size > 399){
				lbl_croparea.SetBounds(lbl_croparea.Location.X,400 - size,size,size);
			}
		}
		
		void TrackBar1Scroll(object sender, EventArgs e)
		{
			zoom = 1 + (tbr_zoom.Value) / 20f;
			lbl_croparea.Size = new Size(new Point((int) (zoom * 100),(int) (zoom * 100)));
		}
		void Button2Click(object sender, System.EventArgs e)
		{
		  if(FuenteDeVideo == null){
		    BuscarDispositivos();
		    
		    FuenteDeVideo = new VideoCaptureDevice(DispositivosDeVideo[cmb_devices.SelectedIndex].MonikerString);			
					FuenteDeVideo.NewFrame += new NewFrameEventHandler(video_NuevoFrame);
					FuenteDeVideo.Start();
					
					pic_photo.Visible=true;
					btn_crop.Visible=true;
					
					cmb_devices.Text = DispositivosDeVideo[cmb_devices.SelectedIndex].Name.ToString();
		  } else {
		    FuenteDeVideo.Start();
		  }
		  
			cmb_devices.Visible=true;
			btn_loadpic.Visible=false;
			btn_takepic.Visible=false;
			tbr_zoom.Visible=true;
			lbl_croparea.Visible = true;
		  lbl_devices.Visible = true;
		  lbl_zoom.Visible = true;
		}
		
		void ComboBox1SelectedIndexChanged(object sender, EventArgs e)
		{
      if (ExistenDispositivos){
					
//					FuenteDeVideo = new VideoCaptureDevice(DispositivosDeVideo[cmb_devices.SelectedIndex].MonikerString);			
//					FuenteDeVideo.NewFrame += new NewFrameEventHandler(video_NuevoFrame);
//					FuenteDeVideo.Start();
//					
//					pic_photo.Visible=true;
//					btn_crop.Visible=true;
//					
//					cmb_devices.Text = DispositivosDeVideo[cmb_devices.SelectedIndex].Name.ToString();
		    
			}else{
				if(FuenteDeVideo.IsRunning){
		      
					TerminarFuenteDeVideo();
					cmb_devices.Enabled=true;
					
					cmb_devices.Visible=false;
					btn_loadpic.Visible=true;
					btn_takepic.Visible=true;
					tbr_zoom.Visible=false;
					pic_photo.Visible=false;
					btn_crop.Visible=false;
				}		  
		  }
	 }
		
		void FormLoadPictureLoad(object sender, EventArgs e)
		{
		    lbl_croparea.Visible = false;
		    lbl_devices.Visible = false;
		    lbl_zoom.Visible = false;
		}
		
		
		
		void Pic_bigphotoClick(object sender, EventArgs e)
		{
		  
		}
		
		void Btn_opbackClick(object sender, EventArgs e)
		{  
		  if(pic_photo.Visible) {
		     
  			cmb_devices.Visible=false;
  			btn_loadpic.Visible=true;
  			btn_takepic.Visible=true;
  			btn_crop.Visible = false;
  			tbr_zoom.Visible=false;
  			lbl_croparea.Visible = false;
  		  	lbl_devices.Visible = false;
  		  	lbl_zoom.Visible = false;
  		  	pic_photo.Visible = false;
  		  
  		  TerminarFuenteDeVideo();
  		  pic_bigphoto.Image = null;
		  } else {
  		  
  		  var t = new Transition(new TransitionType_Acceleration(500));
  				t.add(this, "Top", -this.Height);
  				t.TransitionCompletedEvent += (_, __) => this.Close();
  				t.run();
		  }
		}
		

		
		void Pic_photoClick(object sender, EventArgs e)
		{
		  
		}
		
		void Btn_savepicClick(object sender, EventArgs e)
		{
			/*pic_photo.Image.Save("C:/Users/RamiroPC/Desktop");*/
		}
	}
}