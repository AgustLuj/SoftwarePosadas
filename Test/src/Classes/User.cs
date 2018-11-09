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
    /*
     * Permission String:
     * E C R (Binary)
     *
     * 0 == 0 0 0 Nothing
     * 1 == 0 0 1 Read
     * 3 == 0 1 1 Read/Create
     * 5 == 1 0 1 Read/Edit
     * 7 == 1 1 1 Read/Create/Edit
     * 
     * 1 == 0 0 1 Read
     * 2 == 0 1 0 Create
     * 4 == 1 0 0 Edit
     * 
     * Order:
     * 
     * "Online Guests" "All Guests" "History" "Admin Area"
     * 
     * 3310 == Normal Operator
     * 5550 == "FIX_ME GUY"
     * 7710 == Supervisor
     * 7773 == Normal Admin
     * 7777 == SuperUser
     */
    
    public override string ToString() {
		return string.Format("[User Id: {0}, Name: {1}, Permissions: {2}]", id, name, permissions);
    }

  }
}
