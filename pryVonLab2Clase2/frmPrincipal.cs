using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryVonLab2Clase2
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void localidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLocalidades frmNew = new frmLocalidades();
            frmNew.Show();
        }

        private void cultivosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCultivos frmNew = new frmCultivos();
            frmNew.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void produccionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmProduccion frmNew = new frmProduccion();
            frmNew.Show();
        }

        private void produccionPorLocalidadYCultivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmConsulta frmNew = new frmConsulta();
            frmNew.Show();
        }

        private void consulta2PRUEBAToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void consultasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Have a good one!");
            this.Hide();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
