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
            StreamReader srLocations = new StreamReader("./localidades.txt");
            StreamReader srCultivos = new StreamReader("./cultivos.txt");
            
            char separador = Convert.ToChar(","); //split only supports char data

            while (!srLocations.EndOfStream) {
                string[] arrLocations = srLocations.ReadLine().Split(separador);
                cbLocalidades.Items.Add(arrLocations[0]); //adding to the combo box only the location names from the location file
            }
            while (!srCultivos.EndOfStream)
            {
                string[] arrCultivos = srCultivos.ReadLine().Split(separador);
                cbCultivos.Items.Add(arrCultivos[0]); //adding only the names of the cultivos
            }
            srLocations.Close(); //ALWAYS REMEMBER TO CLOSE THE FILES!!!    
            srCultivos.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //stream readers
            StreamReader srProduccion = new StreamReader("./produccion.txt");

            //variables
            DateTime varDate = dateDate.Value.Date;
            string localidad = cbLocalidades.Text;
            string cultivo = cbCultivos.Text;
            int toneladas = Convert.ToInt32(nudToneladas.Text);
            bool flag = false; //we check if we have data for the location in the 'x' cultivo, if we already have, we will not add it
            char separador = Convert.ToChar(",");

            //flags
            while (!srProduccion.EndOfStream)
            {
                string[] arrProduccion = srProduccion.ReadLine().Split(separador);
                //we can not add the cultivo from the locations twice or more times
                if (localidad == arrProduccion[0] && cultivo == arrProduccion[1]) { 
                    flag = true; 
                }
            }

            srProduccion.Close();

            //program
            if (localidad != "" && cultivo != "" && toneladas != 0)
            {
                if (flag==false) {
                    string msg = localidad + "," + cultivo + "," + toneladas + "," + varDate;
                    using (StreamWriter sw = File.AppendText("./produccion.txt"))
                    {
                        sw.WriteLine(msg);
                    }
                    MessageBox.Show("Added data");
                }
                else
                {
                    MessageBox.Show("Can not add this data, it is already the location and cultivo data in the file.");
                }
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
