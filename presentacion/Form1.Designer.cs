
namespace presentacion
{
    partial class Form1
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
            this.dtInicio = new System.Windows.Forms.DateTimePicker();
            this.dtFin = new System.Windows.Forms.DateTimePicker();
            this.dgvInicio = new System.Windows.Forms.DataGridView();
            this.dgvFin = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblPrimerValor = new System.Windows.Forms.Label();
            this.lblUltimoValor = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInicio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFin)).BeginInit();
            this.SuspendLayout();
            // 
            // dtInicio
            // 
            this.dtInicio.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtInicio.Location = new System.Drawing.Point(128, 146);
            this.dtInicio.Name = "dtInicio";
            this.dtInicio.Size = new System.Drawing.Size(200, 22);
            this.dtInicio.TabIndex = 0;
            // 
            // dtFin
            // 
            this.dtFin.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtFin.Location = new System.Drawing.Point(408, 146);
            this.dtFin.Name = "dtFin";
            this.dtFin.Size = new System.Drawing.Size(200, 22);
            this.dtFin.TabIndex = 1;
            // 
            // dgvInicio
            // 
            this.dgvInicio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInicio.Location = new System.Drawing.Point(73, 184);
            this.dgvInicio.Name = "dgvInicio";
            this.dgvInicio.RowHeadersWidth = 51;
            this.dgvInicio.RowTemplate.Height = 24;
            this.dgvInicio.Size = new System.Drawing.Size(273, 92);
            this.dgvInicio.TabIndex = 2;
            // 
            // dgvFin
            // 
            this.dgvFin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFin.Location = new System.Drawing.Point(396, 184);
            this.dgvFin.Name = "dgvFin";
            this.dgvFin.RowHeadersWidth = 51;
            this.dgvFin.RowTemplate.Height = 24;
            this.dgvFin.Size = new System.Drawing.Size(321, 92);
            this.dgvFin.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(194, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Hora inicio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(475, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Hora fin";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(316, 391);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(129, 47);
            this.btnCalcular.TabIndex = 6;
            this.btnCalcular.Text = "button1";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblPrimerValor
            // 
            this.lblPrimerValor.AutoSize = true;
            this.lblPrimerValor.Location = new System.Drawing.Point(194, 317);
            this.lblPrimerValor.Name = "lblPrimerValor";
            this.lblPrimerValor.Size = new System.Drawing.Size(16, 17);
            this.lblPrimerValor.TabIndex = 7;
            this.lblPrimerValor.Text = "0";
            // 
            // lblUltimoValor
            // 
            this.lblUltimoValor.AutoSize = true;
            this.lblUltimoValor.Location = new System.Drawing.Point(486, 317);
            this.lblUltimoValor.Name = "lblUltimoValor";
            this.lblUltimoValor.Size = new System.Drawing.Size(16, 17);
            this.lblUltimoValor.TabIndex = 8;
            this.lblUltimoValor.Text = "0";
            this.lblUltimoValor.Click += new System.EventHandler(this.lblSegundoValor_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(362, 327);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(16, 17);
            this.lblResultado.TabIndex = 9;
            this.lblResultado.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lblUltimoValor);
            this.Controls.Add(this.lblPrimerValor);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvFin);
            this.Controls.Add(this.dgvInicio);
            this.Controls.Add(this.dtFin);
            this.Controls.Add(this.dtInicio);
            this.Name = "Form1";
            this.Text = "x";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInicio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtInicio;
        private System.Windows.Forms.DateTimePicker dtFin;
        private System.Windows.Forms.DataGridView dgvInicio;
        private System.Windows.Forms.DataGridView dgvFin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblPrimerValor;
        private System.Windows.Forms.Label lblUltimoValor;
        private System.Windows.Forms.Label lblResultado;
    }
}

