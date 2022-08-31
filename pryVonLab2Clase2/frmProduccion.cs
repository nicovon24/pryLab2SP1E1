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
            while (!locationsReader.EndOfStream) {  
                cbLocalidades.Items.Add(locationsReader.ReadLine());
            }
            while (!cultivosReader.EndOfStream)
            {
                cbCultivos.Items.Add(cultivosReader.ReadLine());
            }
            locationsReader.Close();
            cultivosReader.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string msg = "";
            /* ADD THE DATA!!! */
            string localidad = cbLocalidades.Text;
            string cultivo = cbCultivos.Text;
            int toneladas = Convert.ToInt32(nudToneladas.Text);
            if(localidad!="" && cultivo!="" && toneladas != 0)
            {
                msg = localidad + ". " + cultivo + ". " + toneladas;
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
