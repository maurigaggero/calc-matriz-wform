using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.CodeAnalysis;
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

        public void CtorMatriz()
        {
            int Ay = Convert.ToInt32(txtColumA.Text);
            int Ax = Convert.ToInt32(txtFilasA.Text);
            int By = Convert.ToInt32(txtColumB.Text);
            int Bx = Convert.ToInt32(txtFilasB.Text);

            dgvMA.ColumnCount = Ay;
            dgvMA.RowCount = Ax;

            dgvMB.ColumnCount = By;
            dgvMB.RowCount = Bx;

            dgvMR.ColumnCount = Ay;
            dgvMR.RowCount = Ax;
        }

        public void Operacion(string operacion)
        {
            if (operacion == "suma" || operacion == "resta")
            {
                if (dgvMA.Columns.Count == dgvMB.Columns.Count &&
                    dgvMA.Rows.Count == dgvMB.Rows.Count) //las matrices deben tener el mismo orden
                {
                    int i, j;
                    int fila, columna;

                    fila = dgvMA.Rows.Count;
                    columna = dgvMA.Columns.Count;

                    for (i = 0; i < fila; i++)
                    {
                        for (j = 0; j < columna; j++)
                        {
                            if (operacion == "suma")
                                dgvMR.Rows[i].Cells[j].Value = Convert.ToDouble(dgvMA.Rows[i].Cells[j].Value) +
                                    Convert.ToDouble(dgvMB.Rows[i].Cells[j].Value);
                            if (operacion == "resta")
                                dgvMR.Rows[i].Cells[j].Value = Convert.ToDouble(dgvMA.Rows[i].Cells[j].Value) -
                                    Convert.ToDouble(dgvMB.Rows[i].Cells[j].Value);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("A y B tienen distinto orden");
                }
            }
            if (operacion == "multiplicacion")
            {
                if (dgvMA.Columns.Count == dgvMB.Rows.Count) //se debe tener misma cantidad de 
                                                             //columnas de  A que filas de B
                {
                    dgvMR.ColumnCount = dgvMB.Columns.Count;
                    dgvMR.RowCount = dgvMA.Rows.Count;

                    int i, j;
                    int filaA, columnaA, columnaB;

                    filaA = Convert.ToInt32(txtFilasA.Text);
                    columnaA = Convert.ToInt32(txtColumA.Text);
                    columnaB = Convert.ToInt32(txtColumB.Text);

                    for (i = 0; i < filaA; i++)//recorre fila matriz resultado
                    {
                        for (j = 0; j < columnaB; j++)//recorre columna de matriz resultado
                        {
                            dgvMR.Rows[i].Cells[j].Value = 0;
                            for (int k = 0; k < columnaA; k++)
                            {
                                dgvMR.Rows[i].Cells[j].Value = Convert.ToDouble(dgvMR.Rows[i].Cells[j].Value)
                                    + Convert.ToDouble(dgvMA.Rows[i].Cells[k].Value)
                                    * Convert.ToDouble(dgvMB.Rows[k].Cells[j].Value);
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("La cantidad de columnas de A no coincide con la cantidad de filas de B");
                }
            }
            if (operacion == "escalar")
            {
                dgvMB.Columns.Clear(); //limpia la matrizB que no se usará en este caso

                try
                {
                    int i, j;
                    int fila, columna;
                    double p = Convert.ToDouble(txtEscal.Text);

                    fila = dgvMA.Rows.Count;
                    columna = dgvMA.Columns.Count;

                    for (i = 0; i < fila; i++)
                    {
                        for (j = 0; j < columna; j++)
                        {
                            dgvMR.Rows[i].Cells[j].Value = 
                                Convert.ToDouble(dgvMA.Rows[i].Cells[j].Value) * p;
                        }
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Ingrese algun valor correcto en el campo escalar");
                }
            }
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            lblOper.Text = "+";
            Operacion("suma");
        }

        private void btnRes_Click(object sender, EventArgs e)
        {
            lblOper.Text = "-";
            Operacion("resta");
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            lblOper.Text = "x";
            Operacion("multiplicacion");
        }

        private void btnEscal_Click(object sender, EventArgs e)
        {
            lblOper.Text = "x";
            Operacion("escalar");
        }

        private void btnConfirTam_Click(object sender, EventArgs e)
        {
            try
            {
                CtorMatriz();
            }
            catch (Exception)
            {
                MessageBox.Show("Defina un tamaño para ambas matrices");
            }            
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtEscal.Clear();
            dgvMA.Columns.Clear();
            dgvMB.Columns.Clear();
            dgvMR.Columns.Clear();
        }
    }
}
