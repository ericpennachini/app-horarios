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

        public ArchivoRegistro() { }

        public void AbrirArchivo()
        {
            string[] lineas = null;
            try
            {
                lineas = File.ReadAllLines("archivoReg.txt");
                for (int i = 0; i < lineas.Length; i++)
                {
                    string[] campos = lineas[i].Split(new char[';'], StringSplitOptions.None);
                    ListaRegistros.Add(new Registro
                    {
                        Fecha = DateTime.Parse(campos[0]),
                        HoraEntrada = DateTime.Parse(campos[1]),
                        HoraSalida = DateTime.Parse(campos[2]),
                        TiempoDescanso = TimeSpan.Parse(campos[3]),
                        Observaciones = campos[4]
                    });
                }
            }
            catch (FileNotFoundException fnfEx)
            {
                MessageBox.Show(fnfEx.Message + "\n\n"
                    + "Se iniciará el listado vacío. Si el archivo se encuentra en otro lugar, ubiquelo donde está la aplicación y vuelva a iniciarla",
                    "Error de archivo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void EscribirArchivo()
        {
            foreach(Registro r in ListaRegistros) 
            {
                String linea = r.Fecha.ToShortDateString();
            }
        }
        
    }
}
