using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace appHorarios
{
    public class Registro
    {
        public DateTime Fecha { get; set; }
        public TimeSpan HoraEntrada { get; set; }
        public TimeSpan HoraSalida { get; set; }
        public TimeSpan TiempoDescanso { get; set; }
        public Boolean DescansoValido { get; set; }
        public String Observaciones { get; set; }

        public Registro()
        {
            Fecha = DateTime.Now;
            TiempoDescanso = new TimeSpan(1, 0, 0);
            DescansoValido = true;
        }

        public override bool Equals(object obj)
        {
            Registro r = (Registro)obj;
            if (Fecha == r.Fecha)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
