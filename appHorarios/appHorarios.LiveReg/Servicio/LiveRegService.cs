using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using appHorarios.LiveReg.Modelo;

namespace appHorarios.LiveReg.Servicio
{
    public class LiveRegService
    {
        #region Campos y propiedades
        private List<LiveRegType> _listaLiveReg;
        public List<LiveRegType> ListaLiveReg
        {
            get { return _listaLiveReg; }
            set { _listaLiveReg = value; }
        }

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
        }

        public void AgregarLiveReg(LiveRegType reg)
        {
            // agregar a archivo
        }

        public TimeSpan CalcularHorasACompensar(String tipo)
        {
            return new TimeSpan();
        }

        public TimeSpan CalcularTiempoDescansoCompensado(String tipo)
        {
            return new TimeSpan();
        }


    }
}
