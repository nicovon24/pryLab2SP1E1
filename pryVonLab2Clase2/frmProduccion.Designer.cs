
namespace pryVonLab2Clase2
{
    partial class frmProduccion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblCultivo = new System.Windows.Forms.Label();
            this.lblLocalidad = new System.Windows.Forms.Label();
            this.lblToneladas = new System.Windows.Forms.Label();
            this.nudToneladas = new System.Windows.Forms.NumericUpDown();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.dateDate = new System.Windows.Forms.DateTimePicker();
            this.lblDate = new System.Windows.Forms.Label();
            this.cbLocalidades = new System.Windows.Forms.ComboBox();
            this.cbCultivos = new System.Windows.Forms.ComboBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudToneladas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCultivo
            // 
            this.lblCultivo.AutoSize = true;
            this.lblCultivo.Location = new System.Drawing.Point(16, 178);
            this.lblCultivo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCultivo.Name = "lblCultivo";
            this.lblCultivo.Size = new System.Drawing.Size(116, 16);
            this.lblCultivo.TabIndex = 5;
            this.lblCultivo.Text = "Seleccione cultivo";
            // 
            // lblLocalidad
            // 
            this.lblLocalidad.AutoSize = true;
            this.lblLocalidad.Location = new System.Drawing.Point(16, 110);
            this.lblLocalidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLocalidad.Name = "lblLocalidad";
            this.lblLocalidad.Size = new System.Drawing.Size(134, 16);
            this.lblLocalidad.TabIndex = 4;
            this.lblLocalidad.Text = "Seleccione localidad";
            // 
            // lblToneladas
            // 
            this.lblToneladas.AutoSize = true;
            this.lblToneladas.Location = new System.Drawing.Point(16, 250);
            this.lblToneladas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblToneladas.Name = "lblToneladas";
            this.lblToneladas.Size = new System.Drawing.Size(73, 16);
            this.lblToneladas.TabIndex = 8;
            this.lblToneladas.Text = "Toneladas\r\n";
            // 
            // nudToneladas
            // 
            this.nudToneladas.Location = new System.Drawing.Point(176, 247);
            this.nudToneladas.Margin = new System.Windows.Forms.Padding(4);
            this.nudToneladas.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudToneladas.Name = "nudToneladas";
            this.nudToneladas.Size = new System.Drawing.Size(125, 22);
            this.nudToneladas.TabIndex = 9;
            this.nudToneladas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(364, 329);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(100, 28);
            this.btnAceptar.TabIndex = 10;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // dateDate
            // 
            this.dateDate.Location = new System.Drawing.Point(177, 33);
            this.dateDate.Margin = new System.Windows.Forms.Padding(4);
            this.dateDate.Name = "dateDate";
            this.dateDate.Size = new System.Drawing.Size(287, 22);
            this.dateDate.TabIndex = 11;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(16, 38);
            this.lblDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(111, 16);
            this.lblDate.TabIndex = 12;
            this.lblDate.Text = "Seleccione fecha\r\n";
            // 
            // cbLocalidades
            // 
            this.cbLocalidades.FormattingEnabled = true;
            this.cbLocalidades.Location = new System.Drawing.Point(176, 102);
            this.cbLocalidades.Name = "cbLocalidades";
            this.cbLocalidades.Size = new System.Drawing.Size(287, 24);
            this.cbLocalidades.TabIndex = 13;
            this.cbLocalidades.SelectedIndexChanged += new System.EventHandler(this.cbLocalidades_SelectedIndexChanged);
            // 
            // cbCultivos
            // 
            this.cbCultivos.FormattingEnabled = true;
            this.cbCultivos.Location = new System.Drawing.Point(176, 170);
            this.cbCultivos.Name = "cbCultivos";
            this.cbCultivos.Size = new System.Drawing.Size(287, 24);
            this.cbCultivos.TabIndex = 14;
            this.cbCultivos.SelectedIndexChanged += new System.EventHandler(this.cbCultivos_SelectedIndexChanged);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(201, 329);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(100, 28);
            this.btnReset.TabIndex = 15;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(19, 329);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(4);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(100, 28);
            this.btnVolver.TabIndex = 16;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // frmProduccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 394);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.cbCultivos);
            this.Controls.Add(this.cbLocalidades);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.dateDate);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.nudToneladas);
            this.Controls.Add(this.lblToneladas);
            this.Controls.Add(this.lblCultivo);
            this.Controls.Add(this.lblLocalidad);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmProduccion";
            this.Text = "Produccion";
            this.Load += new System.EventHandler(this.frmProduccion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudToneladas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblCultivo;
        private System.Windows.Forms.Label lblLocalidad;
        private System.Windows.Forms.Label lblToneladas;
        private System.Windows.Forms.NumericUpDown nudToneladas;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.DateTimePicker dateDate;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.ComboBox cbLocalidades;
        private System.Windows.Forms.ComboBox cbCultivos;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnVolver;
    }
}