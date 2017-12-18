using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using appHorarios.LiveReg.Modelo;
using System.Globalization;

namespace appHorarios.LiveReg.Servicio
{
    public class LiveRegService
    {
        #region Campos y propiedades
        private List<LiveRegType> _listaLiveReg;
        private ArchivoRegistro _archivoRegistros;
        private String _periodoCalculo;
        public String PeriodoCalculo
        {
            get { return _periodoCalculo; }
            set { _periodoCalculo = value; }
        }

        public static String CALCULO_MENSUAL = "M";
        public static String CALCULO_SEMANAL = "S";
        #endregion

        public LiveRegService()
        {
            _listaLiveReg = new List<LiveRegType>();
            _archivoRegistros = new ArchivoRegistro();
        }

        public void GuardarArchivoLiveReg(LiveRegType reg)
        {
            // agregar a archivo los livereg
            // Adicionalmente, hay que convertir los LiveReg a Registro
            List<Registro> regs = new List<Registro>();
            foreach (LiveRegType lrt in _listaLiveReg)
            {
                regs.Add(new Registro
                {
                    Fecha = lrt.FechaRegistro,
                    HoraEntrada = lrt.HoraEntrada,
                    HoraSalida = lrt.HoraSalida,
                    Observaciones = "",
                    TiempoDescanso = lrt.TiempoDescansoAcumulado,
                    DescansoValido = true
                });
            }
            _archivoRegistros.ListaRegistros.AddRange(regs);
            _archivoRegistros.EscribirArchivo(null, true);
        }

        public TimeSpan CalcularHorasACompensar(String tipo)
        {
            TimeSpan horasCompensar = new TimeSpan(0, 0, 0);
            switch (tipo)
            {
                case "M":
                    var datos1 = from lr in _listaLiveReg
                                where lr.FechaRegistro.Month == DateTime.Now.Month
                                select lr;
                    List<LiveRegType> listaFiltrada1 = new List<LiveRegType>(datos1);
                    
                    foreach (LiveRegType lvr in listaFiltrada1)
                    {
                        horasCompensar += (new TimeSpan(9, 0, 0)) - (lvr.HoraSalida - lvr.HoraEntrada - lvr.TiempoDescansoAcumulado); // + pausa acumulada
                    }

                    break;
                case "S":
                    Calendar c = (new DateTimeFormatInfo()).Calendar;
                    var datos2 = from lr in _listaLiveReg
                                //where lr.FechaRegistro == DateTime.Now.Month
                                where c.GetWeekOfYear(lr.FechaRegistro, CalendarWeekRule.FirstFullWeek, DayOfWeek.Sunday)
                                    == c.GetWeekOfYear(DateTime.Now, CalendarWeekRule.FirstFullWeek, DayOfWeek.Sunday)
                                select lr;
                    List<LiveRegType> listaFiltrada2 = new List<LiveRegType>(datos2);
                    
                    foreach (LiveRegType lvr in listaFiltrada2)
                    {
                        horasCompensar += (new TimeSpan(9, 0, 0)) - (lvr.HoraSalida - lvr.HoraEntrada - lvr.TiempoDescansoAcumulado); // + pausa acumulada
                    }
                    break;
            }
            return horasCompensar;
        }

        public TimeSpan CalcularTiempoDescansoCompensado(String tipo)
        {
            return new TimeSpan();
        }


    }
}
