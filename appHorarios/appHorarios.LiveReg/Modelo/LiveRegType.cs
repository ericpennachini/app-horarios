using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace appHorarios.LiveReg.Modelo
{
    public class LiveRegType
    {
        public DateTime FechaRegistro { get; set; }
        public TimeSpan HoraEntrada { get; set; }
        public TimeSpan HoraInicioDescanso { get; set; }
        public TimeSpan HoraFinDescanso { get; set; }
        public TimeSpan TiempoDescansoAcumulado { get; set; }
        public TimeSpan PausaDescansoAcumulada { get; set; }
        public TimeSpan HoraSalida { get; set; }

        public LiveRegType()
        {
            HoraEntrada = new TimeSpan(0, 0, 0);
            HoraInicioDescanso = new TimeSpan(0, 0, 0);
            HoraFinDescanso = new TimeSpan(0, 0, 0);
            TiempoDescansoAcumulado = new TimeSpan(0, 0, 0);
            PausaDescansoAcumulada = new TimeSpan(0, 0, 0);
            HoraSalida = new TimeSpan(0, 0, 0);
        }
    }
}
