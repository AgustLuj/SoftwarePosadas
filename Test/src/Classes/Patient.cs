/*
 * Created By 42476232
 * On 20/11/2018
 * Time: 09:29 a.m.
 */
using System;

namespace Program.Classes
{
  /// <summary>
  /// Definicion de un Paciente
  /// <param name="name">Nombre del Paciente</param>
  /// <param name="surname">Apellido del Paciente</param>
  /// <param name="proc">Procedencia del Paciente (Servicio)</param>
  /// <param name="bed">Numero de Cama</param>
  /// </summary>
  public class Patient : Person
  {
    
    public string proc;
    public int bed;
    
    public Patient()
    {
    }
  }
}
