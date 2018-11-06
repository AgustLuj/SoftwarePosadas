using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program.Classes {
  public class Month {
    public General general;
  }

  public class General {
    public List<Huesped> huespedes;
  }

  public class Huesped {
    public int Ficha;
    public string Nombre;
    public int DNI;
  }
}
