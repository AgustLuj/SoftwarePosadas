/*
 * Created by Mateo Pidal.
 * Date: 13/8/2018
 * Time: 1:51 a. m.
 */
using System;
using Program.Classes;
using System.Collections.Generic;

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
  }
}
