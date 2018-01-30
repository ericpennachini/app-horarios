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
        public TimeSpan HoraInicioUltimoDescanso { get; set; }
        public TimeSpan HoraFinUltimoDescanso { get; set; }
        public TimeSpan TiempoDescansoAcumulado { get; set; }
        public TimeSpan HoraSalida { get; set; }

        public LiveRegType()
        {
            HoraEntrada = new TimeSpan(0, 0, 0);
            HoraInicioUltimoDescanso = new TimeSpan(0, 0, 0);
            HoraFinUltimoDescanso = new TimeSpan(0, 0, 0);
            TiempoDescansoAcumulado = new TimeSpan(0, 0, 0);
            HoraSalida = new TimeSpan(0, 0, 0);
        }
    }
}
