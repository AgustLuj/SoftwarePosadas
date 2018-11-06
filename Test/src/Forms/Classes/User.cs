/*
 * Created By Mateo Pidal
 * On 13/08/2018
 * Time: 10:33 a.m.
 */
using System;

namespace Program.Classes {
  public class User {
    
    public int id;
    public string name;
    public string permissions;
    
    public override string ToString() {
		return string.Format("[User Id: {0}, Name: {1}, Permissions: {2}]", id, name, permissions);
	  }

  }
}
