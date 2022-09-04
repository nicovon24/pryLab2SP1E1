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
    public partial class frmConsulta2 : Form
    {
        int columnHeaders = 0; //each time we have a no repeated cultivo, will store the data there
        int rowsHeaders = 0;
        bool cultivoIsRepeated = false; //we do not want to repeat the cultivos
        bool cityIsRepeated = false;
        public frmConsulta2()
        {
            InitializeComponent(); 
            StreamReader srProduccion = new StreamReader("./produccion.txt");
            List<string> cultivos = new List<string>(); //will store the cultivos which are not repeated
            List<string> cities = new List<string>();
            char separador = Convert.ToChar(",");
            while (!srProduccion.EndOfStream)
            {
                //getting the data from the production file
                string[] arrProduccion = srProduccion.ReadLine().Split(separador);
                string city = arrProduccion[0];
                string cultivo = arrProduccion[1];
                string produccion = arrProduccion[2];
                //--headers of the columns (cultivos names not repeated)--
                //cultivos
                //adding the Ccultivos to the headers
                for (int i = 0; i < cultivos.Count; i++)
                {
                    if (cultivo == cultivos[i])
                    {
                        cultivoIsRepeated = true;
                    }
                }
                //we do not want to have more than 6 cultivos column and we do not want repeated cultivos
                if (cultivoIsRepeated == false && columnHeaders<6)
                {
                    cultivos.Add(cultivo);
                    grdQuery.Columns[columnHeaders].HeaderText = cultivo; //adding the cultivo's header to the element
                    columnHeaders++;
                }

                //cities
                //adding the cities to the rows headers
                for (int i = 0; i < cities.Count; i++)
                {
                    if (city == cities[i])
                    {
                        cityIsRepeated = true;
                    }
                }
                //we do not want to have more than 6 cities rows and we do not want repeated cities
                if (cityIsRepeated == false)
                {
                    cities.Add(city);
                    grdQuery.Rows.Add(city); //adding the cultivo's header to the element
                    rowsHeaders++;
                }

            }
            srProduccion.Close();
        }

        private void grdQuery_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
