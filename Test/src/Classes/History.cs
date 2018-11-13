﻿/*
 * Created by SharpDevelop.
 * User: lujan
 * Date: 9/11/2018
 * Time: 10:05
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Program.Classes
{
	/// <summary>
	/// Description of History.
	/// </summary>
	public class History
	{
		public History()
		{
			
		}
		
		public static string send(int code,string str){
			
			string action = "-";
			
			switch(code){
				case 1:
					action = "AÑADIÓ";
					break;
				case 2:
					action = "MODIFICÓ";
					break;
				case 3:
					action = "ANULÓ";
					break;
				default:
					action = ""+code;
					break;
			}
			
			return "["+DateTime.Now+"]: "+Sessions.Session.user.name+" "+action+" "+str+ " \n";
		}
	}
}
