using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace appHorarios.LiveReg.Modelo
{
    public class LiveReg
    {
        public DateTime FechaRegistro { get; set; }
        public TimeSpan HoraEntrada { get; set; }
        public TimeSpan HoraInicioDescanso { get; set; }
        public TimeSpan HoraFinDescanso { get; set; }
        public TimeSpan HoraSalida { get; set; }
    }
}
