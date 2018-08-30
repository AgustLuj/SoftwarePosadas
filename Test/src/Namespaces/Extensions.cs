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
    
    
    public static Cursor ActuallyLoadCursor(String path) {
      return new Cursor(LoadCursorFromFile(path));
    }
    [System.Runtime.InteropServices.DllImport("user32.dll")]
    private static extern IntPtr LoadCursorFromFile(string fileName);
    [System.Runtime.InteropServices.DllImport("user32.dll")]
    public static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wp, IntPtr lp);
    }
  }
 
