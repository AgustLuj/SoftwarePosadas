using System;
using System.Collections.Generic;
using System.Net;
using System.Web;
using System.Net;
using System.IO;
namespace Program.Classes
{
	/// <summary>
	/// Description of Class1.
	/// </summary>
	public static class Class1
	{
		public static void TestPOSTWebRequest(string json){
			
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
	      		var result = streamReader.ReadToEnd();
	      		Console.WriteLine (result);
   			}		
		}	
	}
}
