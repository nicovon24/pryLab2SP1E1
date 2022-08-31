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
        //global arrays, we will use them to prevent repetitions of the ids
        List<String> localidades = new List<String>();
        List<int> ids = new List<int>();

        //transforming the data file into string, returns a list so we access it with [i]. Use it then!!
        List<string> lines = System.IO.File.ReadLines("./localidades.txt").ToList(); 
        public frmLocalidades()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            int id;
            string nombre, msg;
            id = Convert.ToInt32(nudID.Text);
            nombre = txtNombre.Text;
            if (id != 0 && nombre != "")
            {
                msg = nombre + "," + id;
                localidades.Add(msg);
                ids.Add(id);
                int count = 0; //the id must be only once in the list
                bool idIsRepeated = false; //flag to check if id is repeated
                using (StreamWriter sw = File.AppendText("./localidades.txt"))
                {
                    for(int i = 0; i < ids.Count; i++)
                    {
                        if ( id == ids[i] ) //if it is in the list, we sum +1
                        {
                            count++;
                        }
                    } 
                    //if it is more than once in the list, id is repeated will be true
                    if (count > 1) { idIsRepeated = true; }

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
