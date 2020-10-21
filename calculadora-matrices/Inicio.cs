using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora_matrices
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            lblOper.Text = "+";
        }

        private void btnRes_Click(object sender, EventArgs e)
        {
            lblOper.Text = "-";
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            lblOper.Text = "x";
        }

        private void btnEscal_Click(object sender, EventArgs e)
        {
            lblOper.Text = "x";
        }
    }
}
