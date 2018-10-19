/*
 * Created by Mateo Pidal.
 * Date: 13/8/2018
 * Time: 1:51 a. m.
 */
using System;
using System.Collections.Generic;
using System.Windows.Forms;

using Program.Classes;

namespace Program.Extensions {
  /// <summary>
  /// Basic extensions
  /// </summary>
	public static class Extensions {
		public static T First<T>(this List<T> l) {
			return l[0];
		}
    
		public static T Last<T>(this List<T> l) {
			return l[l.Count - 1];
		}
    
		public static bool IsNull<T>(this List<T> l) {
			return (l == null) ? true : false;
		}
    
		public static bool IsNull(this Month m) {
			return (m.general == null);
		}
    
		public static bool areVisible(this FormCollection fc) {
			for (int i = 0; i < fc.Count; i++) {
				if (fc[i].Visible) {
					return true;
				}
			}
  			return false;
		}
    
    public static bool containsType(this Control.ControlCollection cs, Type T){
      foreach (var c in cs) {
        if(c.GetType() == T) {
          return true;
        }
      }
      return false;
    }
    
    public static void forEach(this Control.ControlCollection cs, Action<Control> a){
      foreach (Control c in cs) {
        a(c);
      }
    }
	}
}

