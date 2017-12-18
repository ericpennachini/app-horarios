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
        private LiveRegService _servicio;

        public Form1()
        {
            InitializeComponent();
            lblFechaActual.Text = DateTime.Now.ToString();
            _registro = new LiveRegType();
            _registro.FechaRegistro = DateTime.Now;
            _servicio = new LiveRegService();
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
        }

        private void btnMarcarEntrada_Click(object sender, EventArgs e)
        {
            ReiniciarCampos();
            DateTime fechaHora = DateTime.Now;
            _registro.HoraEntrada = new TimeSpan(fechaHora.Hour, fechaHora.Minute, fechaHora.Second);
            label1.Text = _registro.HoraEntrada.ToString(@"hh\:mm\:ss");
            btnDescanso.Enabled = true;
            btnMarcarSalida.Enabled = true;
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
            lblHorascompensar.Text = horasACompensar.ToString(@"hh\:mm\:ss");
        }

        private void btnMarcarSalida_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this, "Registro guardado");
            DateTime fechaHora = DateTime.Now;
            _registro.HoraSalida = new TimeSpan(fechaHora.Hour, fechaHora.Minute, fechaHora.Second);
            label4.Text = _registro.HoraSalida.ToString(@"hh\:mm\:ss");
            // Cerrar el registro
            // 1) Agregar a la lista; 2) Reiniciar campos; 3) Refrescar datos
            _servicio.ListaLiveReg.Add(_registro);
            btnDescanso.Enabled = false;
            btnMarcarSalida.Enabled = false;
            btnMarcarEntrada.Enabled = false;
            label2.Text = "--:--:--";
            label3.Text = "--:--:--";

            // actualizar datos
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
    }
}
