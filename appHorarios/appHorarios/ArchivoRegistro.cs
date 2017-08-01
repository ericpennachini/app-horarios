using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace appHorarios
{
    public class ArchivoRegistro
    {
        public List<Registro> ListaRegistros { get; set; }
        public FileStream objArchivo { get; set; }

        public ArchivoRegistro()
        {
            ListaRegistros = new List<Registro>();
        }

        public void AbrirArchivo()
        {
            string[] lineas = null;
            try
            {
                lineas = File.ReadAllLines("archivoReg.txt");
                for (int i = 0; i < lineas.Length; i++)
                {
                    string[] campos = lineas[i].Split(new char[] { ';' });
                    ListaRegistros.Add(new Registro
                    {
                        Fecha = DateTime.Parse(campos[0]),
                        HoraEntrada = TimeSpan.Parse(campos[1]),
                        HoraSalida = TimeSpan.Parse(campos[2]),
                        TiempoDescanso = TimeSpan.Parse(campos[3]),
                        DescansoValido = Boolean.Parse(campos[4]),
                        Observaciones = campos[5]
                    });
                }
            }
            catch (FileNotFoundException fnfEx)
            {
                MessageBox.Show(fnfEx.Message + "\n\n"
                    + "Se creará el archivo vacío. Si éste se encuentra en otro lugar, ubiquelo donde está la aplicación y vuelva a iniciarla",
                    "Error de archivo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                File.Create("archivoReg.txt");
            }
        }

        public void EscribirArchivo(ToolStripProgressBar barra, Boolean salir)
        {
            if (barra != null)
            {
                barra.Visible = true;
                barra.Minimum = 0;
                barra.Maximum = ListaRegistros.Count; 
            }
            using (StreamWriter archivo = new StreamWriter("archivoReg.txt"))
            {
                foreach (Registro r in ListaRegistros)
                {
                    String linea = r.Fecha.ToShortDateString()
                        + ";" + r.HoraEntrada.ToString()
                        + ";" + r.HoraSalida.ToString()
                        + ";" + r.TiempoDescanso.ToString()
                        + ";" + r.DescansoValido.ToString()
                        + ";" + r.Observaciones;
                    archivo.WriteLine(linea);
                    if (barra != null)
                    {
                        barra.Value += 1;
                        if (barra.Value == ListaRegistros.Count)
                        {
                            if (!salir)
                            {
                                MessageBox.Show("Cambios guardados");
                            }
                        }
                    }
                }
            }
        }
        
    }
}
