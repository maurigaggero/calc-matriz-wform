namespace calculadora_matrices
{
    partial class Inicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnConfirTam = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFilasA = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtColumA = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.gb = new System.Windows.Forms.GroupBox();
            this.dgvMA = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvMB = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvMR = new System.Windows.Forms.DataGridView();
            this.btnSum = new System.Windows.Forms.Button();
            this.btnRes = new System.Windows.Forms.Button();
            this.btnEscal = new System.Windows.Forms.Button();
            this.btnMulti = new System.Windows.Forms.Button();
            this.txtEscal = new System.Windows.Forms.TextBox();
            this.lblOper = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtColumB = new System.Windows.Forms.TextBox();
            this.txtFilasB = new System.Windows.Forms.TextBox();
            this.gb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMA)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMB)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMR)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConfirTam
            // 
            this.btnConfirTam.Location = new System.Drawing.Point(212, 139);
            this.btnConfirTam.Name = "btnConfirTam";
            this.btnConfirTam.Size = new System.Drawing.Size(75, 48);
            this.btnConfirTam.TabIndex = 0;
            this.btnConfirTam.Text = "Confirmar Tamaño";
            this.btnConfirTam.UseVisualStyleBackColor = true;
            this.btnConfirTam.Click += new System.EventHandler(this.btnConfirTam_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 38.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(105)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(136, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(640, 63);
            this.label1.TabIndex = 1;
            this.label1.Text = "CALCULADORA DE MATRICES";
            // 
            // txtFilasA
            // 
            this.txtFilasA.Location = new System.Drawing.Point(46, 139);
            this.txtFilasA.Name = "txtFilasA";
            this.txtFilasA.Size = new System.Drawing.Size(100, 20);
            this.txtFilasA.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(18, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "TAMAÑO:";
            // 
            // txtColumA
            // 
            this.txtColumA.Location = new System.Drawing.Point(46, 184);
            this.txtColumA.Name = "txtColumA";
            this.txtColumA.Size = new System.Drawing.Size(100, 20);
            this.txtColumA.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(46, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Cantidad de Filas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(46, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Cantidad de Columnas";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(105)))), ((int)(((byte)(224)))));
            this.label5.Location = new System.Drawing.Point(99, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 26);
            this.label5.TabIndex = 7;
            this.label5.Text = "MATRIZ A";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(105)))), ((int)(((byte)(224)))));
            this.label6.Location = new System.Drawing.Point(409, 248);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 26);
            this.label6.TabIndex = 8;
            this.label6.Text = "MATRIZ B";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(105)))), ((int)(((byte)(224)))));
            this.label7.Location = new System.Drawing.Point(703, 248);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(206, 26);
            this.label7.TabIndex = 9;
            this.label7.Text = "MATRIZ RESULTANTE";
            // 
            // gb
            // 
            this.gb.Controls.Add(this.dgvMA);
            this.gb.Location = new System.Drawing.Point(49, 274);
            this.gb.Name = "gb";
            this.gb.Size = new System.Drawing.Size(220, 150);
            this.gb.TabIndex = 10;
            this.gb.TabStop = false;
            // 
            // dgvMA
            // 
            this.dgvMA.AllowUserToAddRows = false;
            this.dgvMA.AllowUserToDeleteRows = false;
            this.dgvMA.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMA.ColumnHeadersVisible = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMA.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMA.Location = new System.Drawing.Point(0, 13);
            this.dgvMA.Name = "dgvMA";
            this.dgvMA.RowHeadersVisible = false;
            this.dgvMA.Size = new System.Drawing.Size(220, 131);
            this.dgvMA.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvMB);
            this.groupBox1.Location = new System.Drawing.Point(348, 274);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(220, 150);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // dgvMB
            // 
            this.dgvMB.AllowUserToAddRows = false;
            this.dgvMB.AllowUserToDeleteRows = false;
            this.dgvMB.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMB.ColumnHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMB.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMB.Location = new System.Drawing.Point(0, 13);
            this.dgvMB.Name = "dgvMB";
            this.dgvMB.RowHeadersVisible = false;
            this.dgvMB.Size = new System.Drawing.Size(220, 131);
            this.dgvMB.TabIndex = 12;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvMR);
            this.groupBox2.Location = new System.Drawing.Point(697, 274);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(220, 150);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            // 
            // dgvMR
            // 
            this.dgvMR.AllowUserToAddRows = false;
            this.dgvMR.AllowUserToDeleteRows = false;
            this.dgvMR.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMR.ColumnHeadersVisible = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMR.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvMR.Location = new System.Drawing.Point(0, 13);
            this.dgvMR.Name = "dgvMR";
            this.dgvMR.RowHeadersVisible = false;
            this.dgvMR.Size = new System.Drawing.Size(220, 131);
            this.dgvMR.TabIndex = 12;
            // 
            // btnSum
            // 
            this.btnSum.Location = new System.Drawing.Point(689, 120);
            this.btnSum.Name = "btnSum";
            this.btnSum.Size = new System.Drawing.Size(75, 23);
            this.btnSum.TabIndex = 12;
            this.btnSum.Text = "Suma";
            this.btnSum.UseVisualStyleBackColor = true;
            this.btnSum.Click += new System.EventHandler(this.btnSum_Click);
            // 
            // btnRes
            // 
            this.btnRes.Location = new System.Drawing.Point(785, 120);
            this.btnRes.Name = "btnRes";
            this.btnRes.Size = new System.Drawing.Size(75, 23);
            this.btnRes.TabIndex = 13;
            this.btnRes.Text = "Resta";
            this.btnRes.UseVisualStyleBackColor = true;
            this.btnRes.Click += new System.EventHandler(this.btnRes_Click);
            // 
            // btnEscal
            // 
            this.btnEscal.Location = new System.Drawing.Point(785, 159);
            this.btnEscal.Name = "btnEscal";
            this.btnEscal.Size = new System.Drawing.Size(75, 23);
            this.btnEscal.TabIndex = 14;
            this.btnEscal.Text = "Escalar:";
            this.btnEscal.UseVisualStyleBackColor = true;
            this.btnEscal.Click += new System.EventHandler(this.btnEscal_Click);
            // 
            // btnMulti
            // 
            this.btnMulti.Location = new System.Drawing.Point(689, 159);
            this.btnMulti.Name = "btnMulti";
            this.btnMulti.Size = new System.Drawing.Size(75, 23);
            this.btnMulti.TabIndex = 15;
            this.btnMulti.Text = "Multiplicar";
            this.btnMulti.UseVisualStyleBackColor = true;
            this.btnMulti.Click += new System.EventHandler(this.btnMulti_Click);
            // 
            // txtEscal
            // 
            this.txtEscal.Location = new System.Drawing.Point(785, 189);
            this.txtEscal.Name = "txtEscal";
            this.txtEscal.Size = new System.Drawing.Size(75, 20);
            this.txtEscal.TabIndex = 16;
            // 
            // lblOper
            // 
            this.lblOper.AutoSize = true;
            this.lblOper.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOper.ForeColor = System.Drawing.Color.White;
            this.lblOper.Location = new System.Drawing.Point(298, 337);
            this.lblOper.Name = "lblOper";
            this.lblOper.Size = new System.Drawing.Size(0, 25);
            this.lblOper.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(627, 337);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 25);
            this.label8.TabIndex = 18;
            this.label8.Text = "=";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(612, 83);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(164, 24);
            this.label9.TabIndex = 19;
            this.label9.Text = "OPERACIONES:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(367, 169);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(144, 16);
            this.label10.TabIndex = 23;
            this.label10.Text = "Cantidad de Columnas";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(367, 127);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(113, 16);
            this.label11.TabIndex = 22;
            this.label11.Text = "Cantidad de Filas";
            // 
            // txtColumB
            // 
            this.txtColumB.Location = new System.Drawing.Point(367, 188);
            this.txtColumB.Name = "txtColumB";
            this.txtColumB.Size = new System.Drawing.Size(100, 20);
            this.txtColumB.TabIndex = 21;
            // 
            // txtFilasB
            // 
            this.txtFilasB.Location = new System.Drawing.Point(367, 143);
            this.txtFilasB.Name = "txtFilasB";
            this.txtFilasB.Size = new System.Drawing.Size(100, 20);
            this.txtFilasB.TabIndex = 20;
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(939, 471);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtColumB);
            this.Controls.Add(this.txtFilasB);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblOper);
            this.Controls.Add(this.txtEscal);
            this.Controls.Add(this.btnMulti);
            this.Controls.Add(this.btnEscal);
            this.Controls.Add(this.btnRes);
            this.Controls.Add(this.btnSum);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gb);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtColumA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFilasA);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnConfirTam);
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            this.gb.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMA)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMB)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConfirTam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFilasA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtColumA;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox gb;
        private System.Windows.Forms.DataGridView dgvMA;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvMB;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvMR;
        private System.Windows.Forms.Button btnSum;
        private System.Windows.Forms.Button btnRes;
        private System.Windows.Forms.Button btnEscal;
        private System.Windows.Forms.Button btnMulti;
        private System.Windows.Forms.TextBox txtEscal;
        private System.Windows.Forms.Label lblOper;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtColumB;
        private System.Windows.Forms.TextBox txtFilasB;
    }
}

