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
            bool flag = false;
            StreamWriter swCult = new StreamWriter("./cultivos.txt", true);
            swCult.Close();
            //checking that codigo and nombre are not null
            if (codigo != 0 && nombre != "")
            {
                msg = nombre + "," + codigo;
                char separador = Convert.ToChar(",");
                StreamReader srCultivos = new StreamReader("./cultivos.txt");
                while (!srCultivos.EndOfStream)
                {
                    string[] arrCultivos = srCultivos.ReadLine().Split(separador);
                    int codigoArr = Convert.ToInt32(arrCultivos[1]);
                    if (codigo==codigoArr)
                    {
                        flag = true;
                        MessageBox.Show("ID repeated.");
                    }
                }
                srCultivos.Close();
                using (StreamWriter sw = File.AppendText("./cultivos.txt"))
                {
                  
                    //if it is not repeated, we execute show it in the file
                    if (flag == false)
                    {
                        sw.WriteLine(msg);
                        MessageBox.Show("Added data");
                        nudCodigo.Text = "0";
                        txtNombre.Text = "";
                        nudCodigo.Focus();

                    }
                    else
                    {
                        MessageBox.Show("Id repeated!");
                    }
                    sw.Close();
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

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmPrincipal newFrm = new frmPrincipal();
            newFrm.Show();
        }
    }
}
