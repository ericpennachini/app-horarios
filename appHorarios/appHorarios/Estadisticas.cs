using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace appHorarios
{
    public class Estadisticas
    {
        public Estadisticas() { }

        public static TimeSpan CalcularPromedio(List<Registro> regs, ModoCalculo p)
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
                        if (r.DescansoValido == true)
                        {
                            acumulador.Add((r.HoraSalida - r.HoraEntrada) - r.TiempoDescanso);
                        }
                    }
                    prom = acumulador.Average(ts => ts.Ticks);
                    promL = Convert.ToInt64(prom);
                    resultado = new TimeSpan(promL);
                    break;
                case 1:
                    acumulador.Clear();
                    foreach (Registro r in regs)
                    {
                        acumulador.Add(r.HoraSalida - r.HoraEntrada);
                    }
                    prom = acumulador.Average(ts => ts.Ticks);
                    promL = Convert.ToInt64(prom);
                    resultado = new TimeSpan(promL);
                    break;
                case 2:
                    acumulador.Clear();
                    foreach (Registro r in regs)
                    {
                        if (r.DescansoValido == true)
                        {
                            acumulador.Add(r.TiempoDescanso);
                        }
                    }
                    prom = acumulador.Average(ts => ts.Ticks);
                    promL = Convert.ToInt64(prom);
                    resultado = new TimeSpan(promL);
                    break;
                case 3:
                    acumulador.Clear();
                    foreach (Registro r in regs)
                    {
                        acumulador.Add(r.HoraEntrada);
                    }
                    prom = acumulador.Average(ts => ts.Ticks);
                    promL = Convert.ToInt64(prom);
                    resultado = new TimeSpan(promL);
                    break;
                case 4:
                    acumulador.Clear();
                    foreach (Registro r in regs)
                    {
                        acumulador.Add(r.HoraSalida);
                    }
                    prom = acumulador.Average(ts => ts.Ticks);
                    promL = Convert.ToInt64(prom);
                    resultado = new TimeSpan(promL);
                    break;
                case 5:
                    acumulador.Clear();
                    foreach (Registro r in regs)
                    {
                        if (r.IdaBicicleta.ToString() != "00:00:00")
                        {
                            acumulador.Add(r.IdaBicicleta);
                        }
                    }
                    prom = (acumulador.Count > 0 ? acumulador.Average(ts => ts.Ticks) : 0);
                    promL = Convert.ToInt64(prom);
                    resultado = new TimeSpan(promL);
                    break;
                case 6:
                    acumulador.Clear();
                    foreach (Registro r in regs)
                    {
                        if (r.VueltaBicicleta.ToString() != "00:00:00")
                        {
                            acumulador.Add(r.VueltaBicicleta);
                        }
                    }
                    prom = (acumulador.Count > 0 ? acumulador.Average(ts => ts.Ticks) : 0);
                    promL = Convert.ToInt64(prom);
                    resultado = new TimeSpan(promL);
                    break;
                case 7:
                    break;
                case 8:
                    break;
                case 9: 
                    break;
                case 10:
                    break;
            }

            return resultado;
        }

    }

    public enum ModoCalculo
    {
        HorasTrabajadas,
        HorasTrabajadasConDescanso,
        TiempoDeDescanso,
        HorarioDeEntrada,
        HorarioDeSalida,
        TiempoIdaBicicleta,
        TiempoVueltaBicicleta,
        MenorEntrada,
        MayorEntrada,
        MenorSalida,
        MayorSalida
    }
}
