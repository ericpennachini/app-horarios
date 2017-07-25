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
        private ArchivoRegistro archivoReg;

        public Form1()
        {
            InitializeComponent();
            archivoReg = new ArchivoRegistro();
            archivoReg.AbrirArchivo();
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
            dtpFechaRegistro.Enabled = true;
            textBoxHoraEntrada.Enabled = true;
            textBoxDescanso.Enabled = true;
            textBoxHoraSalida.Enabled = true;
            buttonCancelar.Enabled = true;
            buttonGuardar.Enabled = true;
            //DateTime d = DateTime.Now;
            //MessageBox.Show(d.ToShortDateString());
            //MessageBox.Show(d.ToShortTimeString());
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            dtpFechaRegistro.Enabled = false;
            textBoxHoraEntrada.Enabled = false;
            textBoxDescanso.Enabled = false;
            textBoxHoraSalida.Enabled = false;
            buttonCancelar.Enabled = false;
            buttonGuardar.Enabled = false;
        }
    }
}
