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
            frmLocalidades frmNew = new frmLocalidades();
            frmNew.Show();
        }

        private void cultivosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCultivos frmNew = new frmCultivos();
            frmNew.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void produccionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProduccion frmNew = new frmProduccion();
            frmNew.Show();
        }

        private void produccionPorLocalidadYCultivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsulta frmNew = new frmConsulta();
            frmNew.Show();
        }
    }
}
