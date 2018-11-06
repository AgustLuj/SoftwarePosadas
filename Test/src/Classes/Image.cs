using System;
using System.Drawing;

namespace Program.Classes
{

	public class Image
	{
		int width,height;
		public Bitmap bitmap;
		
		public Image(int width,int height)
		{	
			this.width = width;
			this.height = height;
			
			bitmap = new Bitmap(width,height);
		}
		
		public Bitmap getBitmap(){
			return bitmap;
		}
		
		public void plot(int x,int y,int r,int g,int b){
			
			if(x >= 0 && x < width && y >= 0 && y < height){

				if(r > 255){r = 255;}
				if(g > 255){g = 255;}
				if(b > 255){b = 255;}
				
				bitmap.SetPixel(x,y,Color.FromArgb(255,r,g,b));
			}
		}
		
		public void clear(){
			
			for(int i = 0;i < width;i++){
				for(int j = 0;j < height;j++){
					plot(i,j,255,255,255);
				}
			}
		}
		
		public void rect(int x,int y,int w,int h,int r,int g,int b,Boolean gradient){
			
			for(int i = 0;i < w;i++){
				for(int j = 0;j < h;j++){
					
					if(!gradient){
						plot(x + i,y + j,r,g,b);
					}else{
						plot(x + i,y + j,r + i + x/3,g+j,b+i);
					}
				}
			}
		}
		
		public void graph(int x,int y,float value,int width,int height,int mode){
			
			if(mode == 0){ //MODE VERTICAL
				rect(x,y - (int)(value * height),width,(int)(value * height),20,10,100,true);
			}else if(mode == 1){ //MODE HORIZONTAL
				rect(x,y,(int)(value * width),height,20,10,100,true);
			}
		}

	}
}
