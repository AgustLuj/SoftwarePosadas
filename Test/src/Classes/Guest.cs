/*
 * Created By 42476232
 * On 06/09/2018
 * Time: 11:06 a.m.
 */
using System;

namespace Program.Classes
{
  /// <summary>
  /// Description of Guest.
  /// </summary>
  public class Guest
  {
    
	public int hab;
	
	public Person paciente, internado;
	
	public string ficha, locker, procedencia, servicio, telefono;
	
	public DateTime ingreso, egreso;
	
	public Guest(string ficha, string nh, string ah,
	             int hab, string locker, string ni,
	             string ai, string proc, string serv, DateTime ing) {
	  this.ficha = ficha;
	  this.paciente = new Person(){name = nh, surname = ah};
	  this.hab = hab;
	  this.locker = locker;
	  this.internado = new Person{name = ni, surname = ai};
	  this.procedencia = proc;
	  this.servicio = serv;
	  this.ingreso = ing;
	}
    
	public override string ToString()
	{
		return string.Format("[Guest Hab={0}, Paciente={1}, Internado={2}, Ficha={3}, Locker={4}, Procedencia={5}, Servicio={6}]", hab, paciente, internado, ficha, locker, procedencia, servicio);
	}
  }
}
