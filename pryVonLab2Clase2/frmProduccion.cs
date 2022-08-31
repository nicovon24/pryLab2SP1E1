using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace pryVonLab2Clase2
{
    public partial class frmProduccion : Form
    {
        public frmProduccion()
        {
            InitializeComponent();
        }

        private void frmProduccion_Load(object sender, EventArgs e)
        {
            StreamReader locationsReader = new StreamReader("./localidades.txt");
            StreamReader cultivosReader = new StreamReader("./cultivos.txt");
            
            char separador = Convert.ToChar(",");

            while (!locationsReader.EndOfStream) {
                string[] location = locationsReader.ReadLine().Split(separador);
                cbLocalidades.Items.Add(location[0]);
            }
            while (!cultivosReader.EndOfStream)
            {
                string[] cultivos = cultivosReader.ReadLine().Split(separador);
                cbCultivos.Items.Add(cultivos[0]);
            }
            locationsReader.Close();
            cultivosReader.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string msg = "";
            /* ADD THE DATA!!! */
            DateTime varDate = dateDate.Value.Date;
            string localidad = cbLocalidades.Text;
            string cultivo = cbCultivos.Text;
            int toneladas = Convert.ToInt32(nudToneladas.Text);
            if(localidad!="" && cultivo!="" && toneladas != 0)
            {
                msg = "Localidad: " + localidad + " | " + "Cultivo: " + cultivo + " | " + "Toneladas: " + toneladas + " | Fecha " + varDate;
                using (StreamWriter sw = File.AppendText("./produccion.txt"))
                {
                    sw.WriteLine(msg);
                }
                MessageBox.Show("Added data");
            }
            else { MessageBox.Show("Complete the data, please!"); }
        }

        private void cbLocalidades_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbCultivos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            File.WriteAllText("./produccion.txt", "");
            MessageBox.Show("Data erased");
        }
    }
}
