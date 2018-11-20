/*
 * Created by SharpDevelop.
 * User: Mateo Pidal
 * Date: 19/11/2018
 * Time: 11:03 p. m.
 */
using System;

namespace Program.Classes
{
	/// <summary>
	/// Definición básica de una persona.
	/// <param name="name">Nombre de la Persona</param>
	/// <param name="surname">Apellido de la Persona</param>
	/// </summary>
	public class Person {
	    public string name;
	    public string surname;
	    
	    public override string ToString()
	  	{
	    	return string.Format("[Person Name={0}, Surname={1}]", name, surname);
	  	}
  	}
}
