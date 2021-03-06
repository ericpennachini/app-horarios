﻿using System;
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

            InicializarComboMeses();
        }

        private void InicializarComboMeses()
        {
            List<string> mesesDisponibles = new List<string>();
            int mes = 0;
            foreach (Registro r in _archivoReg.ListaRegistros)
            {
                if (mes != r.Fecha.Month)
                {
                    mes = r.Fecha.Month;
                    comboBoxMeses.Items.Add(ArchivoRegistro.MESES[mes]);
                }
            }
        }

        private void ReinicializarVentana()
        {
            _nuevoRegEnCurso = false;
            dtpFechaRegistro.Enabled = false;
            dtpHoraEntrada.Enabled = false;
            dtpHoraSalida.Enabled = false;
            textBoxComentarios.Enabled = false;
            buttonCancelar.Enabled = false;
            buttonGuardar.Enabled = false;
            dtpFechaRegistro.Value = DateTime.Now;
            dtpHoraEntrada.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 0, 0, 0);
            dtpHoraSalida.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 0, 0, 0);
            dtpTiempoDescanso.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 0, 0, 0);
            dtpIdaBicicleta.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 0, 0, 0);
            dtpVueltaBicicleta.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 0, 0, 0);
            textBoxDetalleBicicleta.Text = "";
            dtpTiempoDescanso.Enabled = false;
            textBoxComentarios.Text = "";
            checkBox1.Checked = false;
            checkBox1.Enabled = false;
            checkBox2.Enabled = false;
            groupBox4.Enabled = false;
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
            checkBox1.Enabled = true;
            checkBox2.Enabled = true;
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
            regInsertar.DescansoValido = !(checkBox1.Checked);
            regInsertar.Observaciones = textBoxComentarios.Text;
            regInsertar.IdaBicicleta = TimeSpan.Parse(dtpIdaBicicleta.Text);
            regInsertar.VueltaBicicleta = TimeSpan.Parse(dtpVueltaBicicleta.Text);
            regInsertar.DetalleBicicleta = textBoxDetalleBicicleta.Text;
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
            toolStripProgressBar1.Value = 0;
            toolStripProgressBar1.Visible = false;
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
                            groupBox5.Visible = false;
                        }
                    }
                    break;
                case 2:
                    if (_nuevoRegEnCurso == true)
                    {
                        labelAlerta.Visible = true;
                        _timerAlerta.Tick += new EventHandler(OnTimerTick);
                        _timerAlerta.Start();
                        tabControl1.SelectedIndex = 0;
                    }
                    break;
            }
        }

        private void OnTimerTick(Object sender, EventArgs e)
        {
            labelAlerta.Visible = false;
            _timerAlerta.Stop();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            _archivoReg.EscribirArchivo(null, true);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool verTotales = radioButton1.Checked;
            bool verMensual = radioButton2.Checked;
            bool verAcumulado = radioButton3.Checked;
            List<Registro> listaEnviar = new List<Registro>();
            int mesCombo = 0;
            if (comboBoxMeses.SelectedItem != null)
            {
                mesCombo = ArchivoRegistro.MESES.FirstOrDefault(x => x.Value == comboBoxMeses.SelectedItem.ToString()).Key; 
            }

            if (verTotales)
            {
                listaEnviar.AddRange(_archivoReg.ListaRegistros);
            }
            if (verMensual)
            {
                listaEnviar.AddRange(_archivoReg.ListaRegistros.FindAll(r => r.Fecha.Month == mesCombo));
            }
            if (verAcumulado)
            {
                listaEnviar.AddRange(_archivoReg.ListaRegistros.FindAll(r => r.Fecha.Month >= mesCombo));
            }


            if (listaEnviar.Count > 0)
            {
                TimeSpan mostrarHorasTrabAvg = Estadisticas.CalcularPromedio(listaEnviar, ModoCalculo.HorasTrabajadas);
                labelAvgHoras1.Text = mostrarHorasTrabAvg.ToString(@"hh\:mm\:ss");
                TimeSpan mostrarHoraTrabDescAvg = Estadisticas.CalcularPromedio(listaEnviar, ModoCalculo.HorasTrabajadasConDescanso);
                labelAvgHoras2.Text = mostrarHoraTrabDescAvg.ToString(@"hh\:mm\:ss");
                TimeSpan mostrarTiempoDescAvg = Estadisticas.CalcularPromedio(listaEnviar, ModoCalculo.TiempoDeDescanso);
                labelAvgDescanso.Text = mostrarTiempoDescAvg.ToString(@"hh\:mm\:ss");
                TimeSpan mostrarHoraEntradaAvg = Estadisticas.CalcularPromedio(listaEnviar, ModoCalculo.HorarioDeEntrada);
                labelAvgHoraEntrada.Text = mostrarHoraEntradaAvg.ToString(@"hh\:mm\:ss");
                TimeSpan mostrarHoraSalidaAvg = Estadisticas.CalcularPromedio(listaEnviar, ModoCalculo.HorarioDeSalida);
                labelAvgHoraSalida.Text = mostrarHoraSalidaAvg.ToString(@"hh\:mm\:ss");
                TimeSpan mostrarIdaBicicletaAvg = Estadisticas.CalcularPromedio(listaEnviar, ModoCalculo.TiempoIdaBicicleta);
                labelAvgIdaBicicleta.Text = mostrarIdaBicicletaAvg.ToString(@"hh\:mm\:ss");
                TimeSpan mostrarVueltaBicicletaAvg = Estadisticas.CalcularPromedio(listaEnviar, ModoCalculo.TiempoVueltaBicicleta);
                labelAvgVueltaBicicleta.Text = mostrarVueltaBicicletaAvg.ToString(@"hh\:mm\:ss");
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
                if (mostrar.IdaBicicleta.ToString() == "00:00:00" &&
                    mostrar.VueltaBicicleta.ToString() == "00:00:00" &&
                    mostrar.DetalleBicicleta == "")
                {
                    groupBox5.Visible = false;
                }
                else
                {
                    groupBox5.Visible = true;
                    tbIdaBicicleta.Text = mostrar.IdaBicicleta.ToString();
                    tbVueltaBicicleta.Text = mostrar.VueltaBicicleta.ToString();
                    tbDetalleBicicleta.Text = mostrar.DetalleBicicleta;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            _archivoReg.EscribirArchivo(toolStripProgressBar1, false);
        }

        /// <summary>
        /// Formatea el color del label de promedios que se le pasa por parámetro
        /// dependiendo del timespan objetivo y si al ser menor el valor que el objetivo
        /// ponerlo en rojo o verde dependiendo del valor del parametro booleano.
        /// </summary>
        /// <param name="labelFormatear">Label al que se quiere formatear el color</param>
        /// <param name="tsObjetivo">TimeSpan con el tiempo que se usa para comparar</param>
        /// <param name="menorEsRojo">Indica si al ser menor que el objetivo el label se pondrá en rojo o no.</param>
        private void FormatearLabel(Label labelFormatear, TimeSpan tsObjetivo, Boolean menorEsRojo)
        {
            if (labelFormatear.Text != "--:--:--")
            {
                TimeSpan tGet = TimeSpan.Parse(labelFormatear.Text);
                if (tGet < tsObjetivo)
                {
                    labelFormatear.ForeColor = (menorEsRojo ? Color.DarkRed : Color.DarkGreen);
                }
                else
                {
                    labelFormatear.ForeColor = (menorEsRojo ? Color.DarkGreen : Color.DarkRed);
                } 
            }
            else
            {
                labelFormatear.ForeColor = Color.Gray;
            }
        }

        private void labelAvgHoras1_TextChanged(object sender, EventArgs e)
        {
            FormatearLabel(labelAvgHoras1, new TimeSpan(8, 0, 0), true);
        }

        private void labelAvgHoras2_TextChanged(object sender, EventArgs e)
        {
            FormatearLabel(labelAvgHoras2, new TimeSpan(9, 0, 0), true);
        }

        private void labelAvgDescanso_TextChanged(object sender, EventArgs e)
        {
            FormatearLabel(labelAvgDescanso, new TimeSpan(1, 1, 0), false);
        }

        private void labelAvgHoraEntrada_TextChanged(object sender, EventArgs e)
        {
            FormatearLabel(labelAvgHoraEntrada, new TimeSpan(8, 5, 0), false);
        }

        private void labelAvgHoraSalida_TextChanged(object sender, EventArgs e)
        {
            FormatearLabel(labelAvgHoraSalida, new TimeSpan(17, 0, 0), true);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                dtpTiempoDescanso.Enabled = false;
            }
            else
            {
                dtpTiempoDescanso.Enabled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            labelAvgHoras1.Text = "--:--:--";
            labelAvgHoras2.Text = "--:--:--";
            labelAvgDescanso.Text = "--:--:--";
            labelAvgHoraEntrada.Text = "--:--:--";
            labelAvgHoraSalida.Text = "--:--:--";
            labelAvgIdaBicicleta.Text = "--:--:--";
            labelAvgVueltaBicicleta.Text = "--:--:--";
            radioButton1.Checked = true;
            comboBoxMeses.SelectedIndex = -1;
            comboBoxMeses.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                comboBoxMeses.Enabled = false;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                comboBoxMeses.Enabled = true;
                comboBoxMeses.SelectedIndex = 0;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true)
            {
                comboBoxMeses.Enabled = true;
                comboBoxMeses.SelectedIndex = 0;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                groupBox4.Enabled = true;
            }
            else
            {
                groupBox4.Enabled = false;
            }
        }

        private void btnNuevoHabilitar_MouseEnter(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = Resource1.msgBtnNuevoHabilitar;
        }

        private void btnNuevoHabilitar_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = "";
        }

        private void dtpFechaRegistro_MouseEnter(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = Resource1.msgFechaRegistro;
        }

        private void dtpFechaRegistro_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = "";
        }

        private void dtpHoraEntrada_MouseEnter(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = Resource1.msgHorarioEntrada;
        }

        private void dtpHoraEntrada_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = "";
        }

        private void dtpHoraSalida_MouseEnter(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = Resource1.msgHoraSalida;
        }

        private void dtpHoraSalida_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = "";
        }

        private void dtpTiempoDescanso_MouseEnter(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = Resource1.msgTiempoDescanso;
        }

        private void dtpTiempoDescanso_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = "";
        }

        private void checkBox1_MouseEnter(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = Resource1.msgCheckInvalidarDescanso;
        }

        private void checkBox1_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = "";
        }

        private void textBoxComentarios_MouseEnter(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = Resource1.msgObservaciones;
        }

        private void textBoxComentarios_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = "";
        }

        private void checkBox2_MouseEnter(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = Resource1.msgCheckBoxHabBicicleta;
        }

        private void checkBox2_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = "";
        }

        private void dtpIdaBicicleta_MouseEnter(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = Resource1.msgIdaBicicleta;
        }

        private void dtpIdaBicicleta_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = "";
        }

        private void dtpVueltaBicicleta_MouseEnter(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = Resource1.msgVueltaBicicleta;
        }

        private void dtpVueltaBicicleta_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = "";
        }

        private void textBoxDetalleBicicleta_MouseEnter(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = Resource1.msgDetalleBicicleta;
        }

        private void textBoxDetalleBicicleta_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = "";
        }

        private void buttonGuardar_MouseEnter(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = Resource1.msgBtnGuardar;
        }

        private void buttonGuardar_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = "";
        }

        private void buttonCancelar_MouseEnter(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = Resource1.msgBtnCancelar;
        }

        private void buttonCancelar_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = "";
        }

        private void listView1_MouseEnter(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = Resource1.msgListViewRegistros;
        }

        private void listView1_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = "";
        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = Resource1.msgBtnGuardarTodo;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = "";
        }

        private void radioButton1_MouseEnter(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = Resource1.msgEstadTotales;
        }

        private void radioButton1_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = "";
        }

        private void radioButton2_MouseEnter(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = Resource1.msgEstadMensual;
        }

        private void radioButton2_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = "";
        }

        private void radioButton3_MouseEnter(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = Resource1.msgEstadAcumulado;
        }

        private void radioButton3_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = "";
        }

        private void comboBoxMeses_MouseEnter(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = Resource1.msgComboMeses;
        }

        private void comboBoxMeses_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = "";
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = Resource1.msgBtnActualizar;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = "";
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = Resource1.msgBtnReiniciar;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = "";
        }
    }
}
