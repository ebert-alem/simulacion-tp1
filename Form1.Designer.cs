
namespace Numeros_aleatorios
{
    partial class Ejercicio1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbOpcion = new System.Windows.Forms.GroupBox();
            this.rbMultiplicativo = new System.Windows.Forms.RadioButton();
            this.rbLineal = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.modulo = new System.Windows.Forms.TextBox();
            this.constanteMultiplicativa = new System.Windows.Forms.TextBox();
            this.constanteAditiva = new System.Windows.Forms.TextBox();
            this.enteroG = new System.Windows.Forms.TextBox();
            this.enteroK = new System.Windows.Forms.TextBox();
            this.semilla = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.gbResultados = new System.Windows.Forms.GroupBox();
            this.grdResultados = new System.Windows.Forms.DataGridView();
            this.iteracion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aleatorio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.gbOpcion.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.gbResultados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdResultados)).BeginInit();
            this.SuspendLayout();
            // 
            // gbOpcion
            // 
            this.gbOpcion.Controls.Add(this.rbMultiplicativo);
            this.gbOpcion.Controls.Add(this.rbLineal);
            this.gbOpcion.Location = new System.Drawing.Point(12, 98);
            this.gbOpcion.Name = "gbOpcion";
            this.gbOpcion.Size = new System.Drawing.Size(254, 100);
            this.gbOpcion.TabIndex = 0;
            this.gbOpcion.TabStop = false;
            this.gbOpcion.Text = "1. Seleccione un método:";
            // 
            // rbMultiplicativo
            // 
            this.rbMultiplicativo.AutoSize = true;
            this.rbMultiplicativo.Location = new System.Drawing.Point(38, 59);
            this.rbMultiplicativo.Name = "rbMultiplicativo";
            this.rbMultiplicativo.Size = new System.Drawing.Size(172, 19);
            this.rbMultiplicativo.TabIndex = 1;
            this.rbMultiplicativo.TabStop = true;
            this.rbMultiplicativo.Text = "Congruencial multiplicativo";
            this.rbMultiplicativo.UseVisualStyleBackColor = true;
            // 
            // rbLineal
            // 
            this.rbLineal.AutoSize = true;
            this.rbLineal.Location = new System.Drawing.Point(38, 33);
            this.rbLineal.Name = "rbLineal";
            this.rbLineal.Size = new System.Drawing.Size(127, 19);
            this.rbLineal.TabIndex = 0;
            this.rbLineal.TabStop = true;
            this.rbLineal.Text = "Congruencial lineal";
            this.rbLineal.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnCalcular);
            this.groupBox1.Controls.Add(this.modulo);
            this.groupBox1.Controls.Add(this.constanteMultiplicativa);
            this.groupBox1.Controls.Add(this.constanteAditiva);
            this.groupBox1.Controls.Add(this.enteroG);
            this.groupBox1.Controls.Add(this.enteroK);
            this.groupBox1.Controls.Add(this.semilla);
            this.groupBox1.Location = new System.Drawing.Point(12, 204);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(755, 134);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "2. Ingrese los valores:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(633, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 15);
            this.label6.TabIndex = 2;
            this.label6.Text = "m:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(514, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "a:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(395, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "c:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(276, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "g:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(157, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "k:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "x0:";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(330, 95);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(118, 27);
            this.btnCalcular.TabIndex = 1;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // modulo
            // 
            this.modulo.Location = new System.Drawing.Point(633, 54);
            this.modulo.Name = "modulo";
            this.modulo.PlaceholderText = "      m";
            this.modulo.Size = new System.Drawing.Size(100, 23);
            this.modulo.TabIndex = 0;
            this.modulo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.modulo_KeyDown);
            // 
            // constanteMultiplicativa
            // 
            this.constanteMultiplicativa.Location = new System.Drawing.Point(514, 54);
            this.constanteMultiplicativa.Name = "constanteMultiplicativa";
            this.constanteMultiplicativa.PlaceholderText = "      a";
            this.constanteMultiplicativa.Size = new System.Drawing.Size(100, 23);
            this.constanteMultiplicativa.TabIndex = 0;
            this.constanteMultiplicativa.KeyDown += new System.Windows.Forms.KeyEventHandler(this.constanteMultiplicativa_KeyDown);
            // 
            // constanteAditiva
            // 
            this.constanteAditiva.Location = new System.Drawing.Point(395, 54);
            this.constanteAditiva.Name = "constanteAditiva";
            this.constanteAditiva.PlaceholderText = "      c";
            this.constanteAditiva.Size = new System.Drawing.Size(100, 23);
            this.constanteAditiva.TabIndex = 0;
            // 
            // enteroG
            // 
            this.enteroG.Location = new System.Drawing.Point(276, 54);
            this.enteroG.Name = "enteroG";
            this.enteroG.PlaceholderText = "      g";
            this.enteroG.Size = new System.Drawing.Size(100, 23);
            this.enteroG.TabIndex = 0;
            this.enteroG.KeyDown += new System.Windows.Forms.KeyEventHandler(this.enteroG_KeyDown);
            // 
            // enteroK
            // 
            this.enteroK.Location = new System.Drawing.Point(157, 54);
            this.enteroK.Name = "enteroK";
            this.enteroK.PlaceholderText = "      k";
            this.enteroK.Size = new System.Drawing.Size(100, 23);
            this.enteroK.TabIndex = 0;
            this.enteroK.KeyDown += new System.Windows.Forms.KeyEventHandler(this.enteroK_KeyDown);
            // 
            // semilla
            // 
            this.semilla.Location = new System.Drawing.Point(38, 54);
            this.semilla.Name = "semilla";
            this.semilla.PlaceholderText = "      x0";
            this.semilla.Size = new System.Drawing.Size(100, 23);
            this.semilla.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(0)))), ((int)(((byte)(30)))));
            this.panel1.Controls.Add(this.lblTitulo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1364, 71);
            this.panel1.TabIndex = 2;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTitulo.Location = new System.Drawing.Point(12, 13);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(538, 40);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Generador de números pseudoaleatorios";
            // 
            // gbResultados
            // 
            this.gbResultados.Controls.Add(this.grdResultados);
            this.gbResultados.Controls.Add(this.btnMostrar);
            this.gbResultados.Location = new System.Drawing.Point(12, 344);
            this.gbResultados.Name = "gbResultados";
            this.gbResultados.Size = new System.Drawing.Size(755, 442);
            this.gbResultados.TabIndex = 3;
            this.gbResultados.TabStop = false;
            this.gbResultados.Text = "3. Resultados";
            // 
            // grdResultados
            // 
            this.grdResultados.AllowUserToAddRows = false;
            this.grdResultados.BackgroundColor = System.Drawing.Color.White;
            this.grdResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdResultados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iteracion,
            this.aleatorio});
            this.grdResultados.Location = new System.Drawing.Point(38, 41);
            this.grdResultados.Name = "grdResultados";
            this.grdResultados.RowHeadersVisible = false;
            this.grdResultados.RowTemplate.Height = 25;
            this.grdResultados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdResultados.Size = new System.Drawing.Size(576, 303);
            this.grdResultados.TabIndex = 0;
            this.grdResultados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // iteracion
            // 
            this.iteracion.HeaderText = "Iteracion";
            this.iteracion.Name = "iteracion";
            this.iteracion.ReadOnly = true;
            // 
            // aleatorio
            // 
            this.aleatorio.HeaderText = "Numero Aleatorio";
            this.aleatorio.Name = "aleatorio";
            this.aleatorio.ReadOnly = true;
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(615, 41);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(118, 27);
            this.btnMostrar.TabIndex = 1;
            this.btnMostrar.Text = "Mostrar fila";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // Ejercicio1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1381, 711);
            this.Controls.Add(this.gbResultados);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbOpcion);
            this.Name = "Ejercicio1";
            this.Text = "Ejercicio 1 - Simulacion";
            this.Load += new System.EventHandler(this.Ejercicio1_Load);
            this.gbOpcion.ResumeLayout(false);
            this.gbOpcion.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbResultados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdResultados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbOpcion;
        private System.Windows.Forms.RadioButton rbMultiplicativo;
        private System.Windows.Forms.RadioButton rbLineal;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox modulo;
        private System.Windows.Forms.TextBox constanteMultiplicativa;
        private System.Windows.Forms.TextBox constanteAditiva;
        private System.Windows.Forms.TextBox enteroG;
        private System.Windows.Forms.TextBox enteroK;
        private System.Windows.Forms.TextBox semilla;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox tabla;
        private System.Windows.Forms.GroupBox gbResultados;
        private System.Windows.Forms.DataGridView grdResultados;
        private System.Windows.Forms.DataGridViewTextBoxColumn iteracion;
        private System.Windows.Forms.DataGridViewTextBoxColumn aleatorio;
        private System.Windows.Forms.Button btnMostrar;
    }
}

