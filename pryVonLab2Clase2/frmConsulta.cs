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
    public partial class frmConsulta : Form
    {
        List<List<string>> multidimListData = new List<List<string>>();
        public frmConsulta()
        {
            InitializeComponent();
                StreamReader srProduccion2 = new StreamReader("./produccion.txt", true);
                char separador = Convert.ToChar(",");
                while (!srProduccion2.EndOfStream)
                {
                    //getting the data from the production file
                    string[] arrProduccion = srProduccion2.ReadLine().Split(separador);
                    string city = arrProduccion[0];
                    string cultivo = arrProduccion[1];
                    string produccion = arrProduccion[2];

                    //defining another list which will inside the multidimListData
                    List<string> Data = new List<string>();

                    //the production file values will go inside the multidimListData
                    Data.Add(city);
                    Data.Add(cultivo);
                    Data.Add(produccion);
                    multidimListData.Add(Data);
                }
                srProduccion2.Close();
                for (int fila = 0; fila < multidimListData.Count; fila++)
                {
                    grdQuery.Rows.Add(
                        multidimListData[fila][0],
                        multidimListData[fila][1],
                        multidimListData[fila][2]
                    );
                }
            
        }

        private void grdQuery_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmPrincipal newFrm = new frmPrincipal();
            newFrm.Show();
        }
    }
}


//StreamReader srProduccion = new StreamReader("./produccion.txt");
//char separador = Convert.ToChar(",");
//while (!srProduccion.EndOfStream)
//{
//    //getting the data from the production file
//    string[] arrProduccion = srProduccion.ReadLine().Split(separador);
//    string city = arrProduccion[0];
//    string cultivo = arrProduccion[1];
//    string produccion = arrProduccion[2];

//    //defining another list which will inside the multidimListData
//    List<string> Data = new List<string>();

//    //the production file values will go inside the multidimListData
//    Data.Add(city);
//    Data.Add(cultivo);
//    Data.Add(produccion);
//    multidimListData.Add(Data);
//}
//srProduccion.Close();
//for (int fila = 0; fila < multidimListData.Count; fila++)
//{
//    grdQuery.Rows.Add(
//        multidimListData[fila][0],
//        multidimListData[fila][1],
//        multidimListData[fila][2]
//    );
//}