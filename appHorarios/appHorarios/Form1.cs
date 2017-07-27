using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace appHorarios
{
    public partial class Form1 : Form
    {
        private ArchivoRegistro _archivoReg;
        private Boolean _nuevoRegEnCurso;
        private Timer _timerAlerta;

        public Form1()
        {
            InitializeComponent();
            _archivoReg = new ArchivoRegistro();
            _archivoReg.AbrirArchivo();
            _nuevoRegEnCurso = false;
            _timerAlerta = new Timer() { Interval = 1500 };
            listView1.View = View.List;
        }

        private void ReinicializarVentana()
        {
            _nuevoRegEnCurso = false;
            dtpFechaRegistro.Enabled = false;
            dtpHoraEntrada.Enabled = false;
            dtpTiempoDescanso.Enabled = false;
            dtpHoraSalida.Enabled = false;
            textBoxComentarios.Enabled = false;
            buttonCancelar.Enabled = false;
            buttonGuardar.Enabled = false;
            dtpFechaRegistro.Value = DateTime.Now;
            dtpHoraEntrada.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 0, 0, 0);
            dtpHoraSalida.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 0, 0, 0);
            dtpTiempoDescanso.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 0, 0, 0);
            textBoxComentarios.Text = "";
        }

        private void btnNuevoHabilitar_MouseEnter(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Habilta los campos para agregar un nuevo registro";
        }

        private void btnNuevoHabilitar_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";
        }

        private void btnNuevoHabilitar_Click(object sender, EventArgs e)
        {
            _nuevoRegEnCurso = true;
            dtpFechaRegistro.Enabled = true;
            dtpHoraEntrada.Enabled = true;
            dtpTiempoDescanso.Enabled = true;
            dtpHoraSalida.Enabled = true;
            textBoxComentarios.Enabled = true;
            buttonCancelar.Enabled = true;
            buttonGuardar.Enabled = true;
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            ReinicializarVentana();
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            Registro regInsertar = new Registro();
            regInsertar.Fecha = DateTime.Parse(dtpFechaRegistro.Text);
            regInsertar.HoraEntrada = TimeSpan.Parse(dtpHoraEntrada.Text);
            regInsertar.HoraSalida = TimeSpan.Parse(dtpHoraSalida.Text);
            regInsertar.TiempoDescanso = TimeSpan.Parse(dtpTiempoDescanso.Text);
            regInsertar.Observaciones = textBoxComentarios.Text;
            if (!_archivoReg.ListaRegistros.Contains(regInsertar))
            {
                _archivoReg.ListaRegistros.Add(regInsertar);
                MessageBox.Show("Registro de horario agregado");
                ReinicializarVentana();
            }
            else
            {
                MessageBox.Show("Registro ya existe. Verifique la fecha.", "Validación",       
                    MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {     
            switch (tabControl1.SelectedIndex)
            {
                case 0:
                    break;
                case 1:
                    if (_nuevoRegEnCurso == true)
                    {
                        labelAlerta.Visible = true;
                        _timerAlerta.Tick += new EventHandler(OnTimerTick);
                        _timerAlerta.Start();
                        tabControl1.SelectedIndex = 0;
                    }
                    else
                    {
                        listView1.Items.Clear();
                        foreach (Registro r in _archivoReg.ListaRegistros)
                        {
                            listView1.Items.Add(r.Fecha.ToShortDateString());
                        }
                    }
                    break;
                case 2:
                    break;
            }
        }

        private void OnTimerTick(Object sender, EventArgs e)
        {
            labelAlerta.Visible = false;
            _timerAlerta.Stop();
        }

        private void listView1_Click(object sender, EventArgs e)
        {
            //var selected = listView1.SelectedItems[0];
            //DateTime f = DateTime.Parse(selected.Text);
            //var obtenido = from r in _archivoReg.ListaRegistros
            //               where r.Fecha == f
            //               select r;
            //Registro mostrar = obtenido.ElementAt(0);
            //tbHoraEntradaDetalle.Text = mostrar.HoraEntrada.ToString();
            //tbHoraSalidaDetalle.Text = mostrar.HoraSalida.ToString();
            //tbTiempoDescDetalle.Text = mostrar.TiempoDescanso.ToString();
            //tbHorasTrabajadasDetalle.Text = ((mostrar.HoraSalida - mostrar.HoraEntrada) - mostrar.TiempoDescanso).ToString();
            //tbHorasTrabajadasDescDetalle.Text = (mostrar.HoraSalida - mostrar.HoraEntrada).ToString();
            //tbObservacionesDetalle.Text = mostrar.Observaciones;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            _archivoReg.EscribirArchivo();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (_archivoReg.ListaRegistros.Count > 0)
            {
                TimeSpan mostrarHorasTrabAvg = Estadisticas.CalcularPromedio(_archivoReg.ListaRegistros, Promedios.HorasTrabajadas);
                labelAvgHoras1.Text = mostrarHorasTrabAvg.ToString();
                TimeSpan mostrarHoraTrabDescAvg = Estadisticas.CalcularPromedio(_archivoReg.ListaRegistros, Promedios.HorasTrabajadasConDescanso);
                labelAvgHoras2.Text = mostrarHoraTrabDescAvg.ToString();
                TimeSpan mostrarTiempoDescAvg = Estadisticas.CalcularPromedio(_archivoReg.ListaRegistros, Promedios.TiempoDeDescanso);
                labelAvgDescanso.Text = mostrarTiempoDescAvg.ToString();
                TimeSpan mostrarHoraEntradaAvg = Estadisticas.CalcularPromedio(_archivoReg.ListaRegistros, Promedios.HorarioDeEntrada);
                labelAvgHoraEntrada.Text = mostrarHoraEntradaAvg.ToString();
            }
            else
            {
                MessageBox.Show("No hay registros para calcular aún.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void listView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                var selected = listView1.SelectedItems[0];
                DateTime f = DateTime.Parse(selected.Text);
                var obtenido = from r in _archivoReg.ListaRegistros
                               where r.Fecha == f
                               select r;
                Registro mostrar = obtenido.ElementAt(0);
                tbHoraEntradaDetalle.Text = mostrar.HoraEntrada.ToString();
                tbHoraSalidaDetalle.Text = mostrar.HoraSalida.ToString();
                tbTiempoDescDetalle.Text = mostrar.TiempoDescanso.ToString();
                tbHorasTrabajadasDetalle.Text = ((mostrar.HoraSalida - mostrar.HoraEntrada) - mostrar.TiempoDescanso).ToString();
                tbHorasTrabajadasDescDetalle.Text = (mostrar.HoraSalida - mostrar.HoraEntrada).ToString();
                tbObservacionesDetalle.Text = mostrar.Observaciones;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            _archivoReg.EscribirArchivo();
        }
    }
}
