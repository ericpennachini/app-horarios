using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using appHorarios.LiveReg.Modelo;

namespace appHorarios.LiveReg.Servicio
{
    public class LiveRegService
    {
        #region Campos 
        private LiveRegType _registroLiveReg;
        public LiveRegType RegistroLiveReg
        {
            get { return _registroLiveReg; }
            set { _registroLiveReg = value; }
        }
        #endregion


    }
}
