using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace appHorarios
{
    public class Registro
    {
        public DateTime Fecha { get; set; }
        public DateTime HoraEntrada { get; set; }
        public DateTime HoraSalida { get; set; }
        public TimeSpan TiempoDescanso { get; set; }
        public String Observaciones { get; set; }

        public Registro()
        {
            Fecha = DateTime.Now;
            TiempoDescanso = new TimeSpan(1, 0, 0);
        }

        public override bool Equals(object obj)
        {
            Registro r = (Registro)obj;
            if (this.Fecha == r.Fecha)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
