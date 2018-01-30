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
    public partial class Form2 : Form
    {
        private LiveRegType _registro;
        private LiveRegService _servicio;
        private Timer _timerFechaHora;

        public Form2()
        {
            InitializeComponent();
            lblFechaActual.Text = DateTime.Now.ToString();
            _registro = new LiveRegType();
            _registro.FechaRegistro = DateTime.Now;
            _servicio = new LiveRegService();
            _servicio.AbrirArchivoLiveReg();
            LiveRegType ultimoIngreso = _servicio.ListaLiveReg.Last();
            if (ultimoIngreso.FechaRegistro.DayOfYear == DateTime.Now.DayOfYear)
            {
                btnMarcarEntrada.Enabled = false;
            }

            comboBox1.SelectedItem = "Semanal";
            _timerFechaHora = new Timer { Interval = 1000 };
            _timerFechaHora.Tick += new EventHandler(OnTimerTick);
            _timerFechaHora.Start();
        }
        private void OnTimerTick(Object sender, EventArgs e)
        {
            lblFechaActual.Text = DateTime.Now.ToString();
        }

        private void ReiniciarCampos()
        {
            btnDescanso.Enabled = false;
            btnMarcarSalida.Enabled = false;
            label1.Text = "--:--:--";
            label2.Text = "--:--:--";
            label3.Text = "--:--:--";
            label4.Text = "--:--:--";
            tbxTotalDescanso.Text = "";
            tbxHorarioAproxSalida.Text = "";
        }

        private void btnMarcarEntrada_Click(object sender, EventArgs e)
        {
            ReiniciarCampos();
            DateTime fechaHora = DateTime.Now;
            _registro.HoraEntrada = new TimeSpan(fechaHora.Hour, fechaHora.Minute, fechaHora.Second);
            label1.Text = _registro.HoraEntrada.ToString(@"hh\:mm\:ss");
            // tbxHorarioAproxSalida.Text = GetHorarioSalidaAproximado();
            btnMarcarEntrada.Enabled = false;
            btnDescanso.Enabled = true;
            btnMarcarSalida.Enabled = true;

            RefrescarDatos();
        }

        private void RefrescarDatos()
        {
            TimeSpan horasACompensar = new TimeSpan();
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show(this, "Debe seleccionar un tipo de cálculo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                String tipoCalculo = comboBox1.SelectedItem.ToString();
                if (tipoCalculo == "Mensual")
                {
                    horasACompensar = _servicio.CalcularHorasACompensar(LiveRegService.CALCULO_MENSUAL);
                }
                else
                {
                    horasACompensar = _servicio.CalcularHorasACompensar(LiveRegService.CALCULO_SEMANAL);
                }
            }
            lblHorascompensar.Text = horasACompensar.ToString();
            TimeSpan salidaComp = _servicio.CalcularHorarioSalidaCompensado(horasACompensar, _registro.HoraEntrada);
            lblHorarioSalidaComp.Text = salidaComp.ToString();
        }

        private String GetHorarioSalidaAproximado()
        {
            String resultado = (
                _registro.HoraEntrada + 
                _registro.TiempoDescansoAcumulado + 
                new TimeSpan(8, 0, 0)).ToString(@"hh\:mm\:ss");
            return resultado;
        }

        

        private void btnMarcarSalida_Click(object sender, EventArgs e)
        {
            DateTime fechaHora = DateTime.Now;
            _registro.HoraSalida = new TimeSpan(fechaHora.Hour, fechaHora.Minute, fechaHora.Second);
            label4.Text = _registro.HoraSalida.ToString(@"hh\:mm\:ss");
            _servicio.ListaLiveReg.Add(_registro);

            // Comprueba si el último registro es de la fecha de hoy,
            // en este caso no deja ingresar otro registro. La idea es que los registros
            // sean de dias diferentes.
            if (_servicio.ListaLiveReg.Last().FechaRegistro.DayOfYear >= DateTime.Now.DayOfYear)
            {
                btnMarcarEntrada.Enabled = false;
            }
            btnDescanso.Enabled = false;
            btnMarcarSalida.Enabled = false;

            RefrescarDatos();
        }

        private void btnDescanso_Click(object sender, EventArgs e)
        {
            if (_registro.HoraInicioUltimoDescanso == new TimeSpan(0, 0, 0))
            {
                DateTime fechaHora = DateTime.Now;
                _registro.HoraInicioUltimoDescanso = new TimeSpan(fechaHora.Hour, fechaHora.Minute, fechaHora.Second);
                // _registro.TiempoDescansoAcumulado = new TimeSpan(0, 0, 0);
                label2.Text = _registro.HoraInicioUltimoDescanso.ToString(@"hh\:mm\:ss");
            }
            else
            {
                if (_registro.HoraFinUltimoDescanso == new TimeSpan(0, 0, 0))
                {
                    DateTime fechaHora = DateTime.Now;
                    _registro.HoraFinUltimoDescanso = new TimeSpan(fechaHora.Hour, fechaHora.Minute, fechaHora.Second);
                    _registro.TiempoDescansoAcumulado += (_registro.HoraFinUltimoDescanso - _registro.HoraInicioUltimoDescanso);
                    label3.Text = _registro.HoraFinUltimoDescanso.ToString(@"hh\:mm\:ss");
                    tbxTotalDescanso.Text = _registro.TiempoDescansoAcumulado.ToString(@"hh\:mm\:ss");
                    tbxHorarioAproxSalida.Text = GetHorarioSalidaAproximado();
                    btnDescanso.Text = "Reiniciar";
                }
                else
                {
                    // este es el caso de que se haya registrado el inicio y fin de descanso pero
                    // se quiera empezar otro descanso.
                    // 1) Poner los labels en --:--:--
                    // 2) Poner los campos HoraFinUltimoDescanso y HoraInicioUltimoDescanso en un Timespan 0.
                    label2.Text = "--:--:--";
                    label3.Text = "--:--:--";
                    _registro.HoraInicioUltimoDescanso = new TimeSpan(0, 0, 0);
                    _registro.HoraFinUltimoDescanso = new TimeSpan(0, 0, 0);
                    btnDescanso.Text = "Inicio/fin últ. descanso";
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefrescarDatos();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_registro.HoraSalida == new TimeSpan(0, 0, 0))
            {
                //MessageBox.Show(this, "El registro actual está sin terminar \nTodos los datos de esta sesión no se guardarán", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (_registro.HoraEntrada != new TimeSpan(0, 0, 0))
                {
                    DateTime fechaHora = DateTime.Now;
                    _registro.HoraSalida = new TimeSpan(fechaHora.Hour, fechaHora.Minute, fechaHora.Second);
                    label4.Text = _registro.HoraSalida.ToString(@"hh\:mm\:ss");
                    _servicio.ListaLiveReg.Add(_registro);
                    _servicio.GuardarArchivoLiveReg();
                }
            }
            else
            {
                _servicio.GuardarArchivoLiveReg();
            }
            _timerFechaHora.Stop(); 
        }
    }
}
