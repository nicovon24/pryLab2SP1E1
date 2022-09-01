namespace pryVonLab2Clase2
{
    partial class frmConsulta
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
            this.grdQuery = new System.Windows.Forms.DataGridView();
            this.grdValueLocalidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdValueCultivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdValueToneladas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdQuery)).BeginInit();
            this.SuspendLayout();
            // 
            // grdQuery
            // 
            this.grdQuery.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdQuery.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.grdValueLocalidad,
            this.grdValueCultivo,
            this.grdValueToneladas});
            this.grdQuery.Location = new System.Drawing.Point(0, 0);
            this.grdQuery.Name = "grdQuery";
            this.grdQuery.RowHeadersWidth = 51;
            this.grdQuery.RowTemplate.Height = 24;
            this.grdQuery.Size = new System.Drawing.Size(806, 454);
            this.grdQuery.TabIndex = 0;
            this.grdQuery.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdQuery_CellContentClick);
            // 
            // grdValueLocalidad
            // 
            this.grdValueLocalidad.HeaderText = "Localidad";
            this.grdValueLocalidad.MinimumWidth = 6;
            this.grdValueLocalidad.Name = "grdValueLocalidad";
            this.grdValueLocalidad.Width = 125;
            // 
            // grdValueCultivo
            // 
            this.grdValueCultivo.HeaderText = "Cultivo";
            this.grdValueCultivo.MinimumWidth = 6;
            this.grdValueCultivo.Name = "grdValueCultivo";
            this.grdValueCultivo.Width = 125;
            // 
            // grdValueToneladas
            // 
            this.grdValueToneladas.HeaderText = "Toneladas";
            this.grdValueToneladas.MinimumWidth = 6;
            this.grdValueToneladas.Name = "grdValueToneladas";
            this.grdValueToneladas.Width = 125;
            // 
            // frmConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grdQuery);
            this.Name = "frmConsulta";
            this.Text = "frmConsulta";
            ((System.ComponentModel.ISupportInitialize)(this.grdQuery)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdQuery;
        private System.Windows.Forms.DataGridViewTextBoxColumn grdValueLocalidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn grdValueCultivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn grdValueToneladas;
    }
}