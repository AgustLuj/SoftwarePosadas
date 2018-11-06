using System;
using System.Collections.Generic;
using System.Net;
using System.Web;
using System.IO;

namespace Program.Classes
{
	public static class Photo
	{
		public static string SendToServer(string json){
			
	      var httpWebRequest = (HttpWebRequest)WebRequest.Create("http://localhost:8080/");
	      
	      httpWebRequest.ContentType = "application/json";
	      httpWebRequest.Method = "POST";
	      
	      using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream())){
	      	
	         string json2 = "{\"user\":"+json+"}";
	         
	         streamWriter.Write(json2);
	         streamWriter.Flush();
	         streamWriter.Close();
	      }
	      var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
	      
	      using (var streamReader = new StreamReader(httpResponse.GetResponseStream())){
	      		return streamReader.ReadToEnd();
	      		//Console.WriteLine (result);
   			}		
		}

		public static String GetFromServer()
		{
		    HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://localhost:8080/app");
		    request.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;
		
		    using(HttpWebResponse response = (HttpWebResponse)request.GetResponse())
		    using(Stream stream = response.GetResponseStream())
		    using(StreamReader reader = new StreamReader(stream))
		    {
		    	return reader.ReadToEnd();
		    }
		}		
		public static String GetFromServerNumber()
		{
		    HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://localhost:8080/numb");
		    request.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;
		
		    using(HttpWebResponse response = (HttpWebResponse)request.GetResponse())
		    using(Stream stream = response.GetResponseStream())
		    using(StreamReader reader = new StreamReader(stream))
		    {
		    	return reader.ReadToEnd();
		    }
		}
		public static string getToServerNumb(string name){
			
	      var httpWebRequest = (HttpWebRequest)WebRequest.Create("http://localhost:8080/numb");
	      
	      httpWebRequest.ContentType = "application/json";
	      httpWebRequest.Method = "POST";
	      
	      using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream())){
	      	
	         string json2 = "{\"foto\":"+name+"}";
	         
	         streamWriter.Write(json2);
	         streamWriter.Flush();
	         streamWriter.Close();
	      }
	      var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
	      
	      using (var streamReader = new StreamReader(httpResponse.GetResponseStream())){
	      		return streamReader.ReadToEnd();
	      		//Console.WriteLine (result);
   			}		
		}
		
		public static string Send(UInt32[] rgb){
			
			int size = rgb.Length;
			int size2 = rgb.Length / 2;
			
			string json = "{\"a\":[";
			
			for(int i = 0;i < size;i++){
					
				if(i == size - 1){
					json += rgb[i];
				}else{
					json += rgb[i] +",";
				}
			}
			
			json += "]}";
		
			return SendToServer(json);
		}
		
		public static UInt32 RGBtoUint(int r,int g,int b){
			return (UInt32) ((r << 16) | (g << 8) | b);
		}
		public static String Get(){
			return GetFromServer();
		}
	}
}
