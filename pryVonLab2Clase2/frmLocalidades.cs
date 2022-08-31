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
    public partial class frmLocalidades : Form
    {
        public frmLocalidades()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string nombre, msg;
            int id;
            nombre = txtNombre.Text;
            id = Convert.ToInt32(nudID.Text);
            bool idIsRepeated = false; //flag to check if id is repeated
            StreamReader srLocalidades = new StreamReader("./localidades.txt");
            if (id != 0 && nombre != "")
            {
                msg = nombre + "," + id;
                char separador = Convert.ToChar(",");
                while (!srLocalidades.EndOfStream)
                {
                    string[] arrLocalidades = srLocalidades.ReadLine().Split(separador);
                    int idArr = Convert.ToInt32(arrLocalidades[1]);
                    if (id == idArr) { 
                        idIsRepeated = true;
                        MessageBox.Show("ID repeated.");
                    }
                }
                srLocalidades.Close();
                using (StreamWriter sw = File.AppendText("./localidades.txt"))
                {
                    //if it is not repeated, we execute show it in the file
                    if (idIsRepeated == false){
                        sw.WriteLine(msg);
                        MessageBox.Show("Added data");
                        nudID.Text = "0";
                        txtNombre.Text = "";
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
            File.WriteAllText("./localidades.txt", "");
            MessageBox.Show("Data erased");
        }
    }
}
