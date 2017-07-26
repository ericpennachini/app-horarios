using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace appHorarios
{
    public class Estadisticas
    {
        public Estadisticas() { }

        public static TimeSpan CalcularPromedio(List<Registro> regs, Promedios p)
        {
            int t = (int)p;
            TimeSpan resultado = new TimeSpan();
            List<TimeSpan> acumulador = new List<TimeSpan>();
            double prom;
            long promL;
            switch (t)
            {
                case 0:
                    acumulador.Clear();
                    foreach (Registro r in regs)
                    {
                        acumulador.Add(r.HoraEntrada);
                    }
                    prom = acumulador.Average(ts => ts.Ticks);
                    promL = Convert.ToInt64(prom);
                    resultado = new TimeSpan(promL);
                    break;
                case 1:
                    acumulador.Clear();
                    foreach (Registro r in regs)
                    {
                        acumulador.Add(r.HoraSalida);
                    }
                    prom = acumulador.Average(ts => ts.Ticks);
                    promL = Convert.ToInt64(prom);
                    resultado = new TimeSpan(promL);
                    break;
            }

            return resultado;
        }

    }

    public enum Promedios
    {
        HorasTrabajadas,
        HorasTrabajadasConDescanso,
        TiempoDeDescanso,
        HorarioDeEntrada,
        HorarioDeSalida
    }
}
