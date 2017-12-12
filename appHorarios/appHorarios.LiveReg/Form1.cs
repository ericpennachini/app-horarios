using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using appHorarios.LiveReg.Modelo;
using appHorarios.LiveReg.Servicio;

namespace appHorarios.LiveReg
{
    public partial class Form1 : Form
    {
        private LiveRegType _registro;

        public Form1()
        {
            InitializeComponent();
            lblFechaActual.Text = DateTime.Now.ToString();
            _registro = new LiveRegType();
            _registro.FechaRegistro = DateTime.Now;
        }

        private void btnMarcarEntrada_Click(object sender, EventArgs e)
        {
            DateTime fechaHora = DateTime.Now;
            _registro.HoraEntrada = new TimeSpan(fechaHora.Hour, fechaHora.Minute, fechaHora.Second);
            label1.Text = _registro.HoraEntrada.ToString(@"hh\:mm\:ss");
        }

        private void btnMarcarSalida_Click(object sender, EventArgs e)
        {
            DateTime fechaHora = DateTime.Now;
            _registro.HoraSalida = new TimeSpan(fechaHora.Hour, fechaHora.Minute, fechaHora.Second);
            label4.Text = _registro.HoraSalida.ToString(@"hh\:mm\:ss");
        }

        private void btnDescanso_Click(object sender, EventArgs e)
        {
            if (_registro.HoraInicioDescanso == null && _registro.HoraFinDescanso == null)
            {
                DateTime fechaHora = DateTime.Now;
                _registro.HoraInicioDescanso = new TimeSpan(fechaHora.Hour, fechaHora.Minute, fechaHora.Second);
                _registro.TiempoDescansoAcumulado = new TimeSpan(0, 0, 0);
                label2.Text = _registro.HoraSalida.ToString(@"hh\:mm\:ss");
            }
            if (_registro.HoraFinDescanso == null)
            {

            }
        }
    }
}
