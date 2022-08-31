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
    public partial class frmCultivos : Form
    {
        //creating two global lists, we will use them to prevent repetitions of the ids
        List<String> cultivos = new List<String>();
        List<int> codigos = new List<int>();

        //transforming the data file into string, returns a list so we access it with [i]. Use it then!!
        List<string> lines = System.IO.File.ReadLines("./cultivos.txt").ToList();
        public frmCultivos()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            int codigo;
            string nombre, msg;
            codigo = Convert.ToInt32(nudCodigo.Text);
            nombre = txtNombre.Text;
            //checking that codigo and nombre are not null
            if (codigo != 0 && nombre != "")
            {
                msg = nombre + " " + codigo;
                cultivos.Add(nombre);
                codigos.Add(codigo);
                int count = 0; //the codigo must be only once in the list
                bool codigoIsRepeated = false; //flag to check if codigo is repeated
                using (StreamWriter sw = File.AppendText("./cultivos.txt"))
                {
                    for (int i = 0; i < codigos.Count; i++)
                    {
                        if (codigo == codigos[i]) //if it is in the list, we sum +1
                        {
                            count++;
                        }
                    }
                    //if it is more than once in the list, codigo is repeated will be true
                    if (count > 1) { codigoIsRepeated = true; }

                    //if it is not repeated, we execute show it in the file
                    if (codigoIsRepeated == false)
                    {
                        sw.WriteLine(msg);
                        MessageBox.Show("Added data");
                        nudCodigo.Text = "0";
                        txtNombre.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Id repeated!");
                    }
                }
            }
            else
            {
                MessageBox.Show("Complete the data, please!");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            File.WriteAllText("./cultivos.txt", "");
            MessageBox.Show("Data erased");
        }
    }
}
