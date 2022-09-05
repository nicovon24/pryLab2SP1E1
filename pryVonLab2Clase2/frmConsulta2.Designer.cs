namespace pryVonLab2Clase2
{
    partial class frmConsulta2
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
            this.localidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cultivo1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cultivo2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cultivo3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cultivo4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cultivo5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdQuery)).BeginInit();
            this.SuspendLayout();
            // 
            // grdQuery
            // 
            this.grdQuery.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdQuery.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.localidad,
            this.cultivo1,
            this.cultivo2,
            this.cultivo3,
            this.cultivo4,
            this.cultivo5});
            this.grdQuery.Location = new System.Drawing.Point(-4, -1);
            this.grdQuery.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grdQuery.Name = "grdQuery";
            this.grdQuery.RowHeadersWidth = 51;
            this.grdQuery.RowTemplate.Height = 24;
            this.grdQuery.Size = new System.Drawing.Size(928, 369);
            this.grdQuery.TabIndex = 1;
            this.grdQuery.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdQuery_CellContentClick);
            // 
            // localidad
            // 
            this.localidad.HeaderText = "Localidad";
            this.localidad.MinimumWidth = 6;
            this.localidad.Name = "localidad";
            this.localidad.Width = 125;
            // 
            // cultivo1
            // 
            this.cultivo1.HeaderText = "Cultivo 1";
            this.cultivo1.MinimumWidth = 6;
            this.cultivo1.Name = "cultivo1";
            this.cultivo1.Width = 125;
            // 
            // cultivo2
            // 
            this.cultivo2.HeaderText = "Cultivo 2";
            this.cultivo2.MinimumWidth = 6;
            this.cultivo2.Name = "cultivo2";
            this.cultivo2.Width = 125;
            // 
            // cultivo3
            // 
            this.cultivo3.HeaderText = "Cultivo 3";
            this.cultivo3.MinimumWidth = 6;
            this.cultivo3.Name = "cultivo3";
            this.cultivo3.Width = 125;
            // 
            // cultivo4
            // 
            this.cultivo4.HeaderText = "Cultivo 4";
            this.cultivo4.MinimumWidth = 6;
            this.cultivo4.Name = "cultivo4";
            this.cultivo4.Width = 125;
            // 
            // cultivo5
            // 
            this.cultivo5.HeaderText = "Cultivo 5";
            this.cultivo5.MinimumWidth = 6;
            this.cultivo5.Name = "cultivo5";
            this.cultivo5.Width = 125;
            // 
            // frmConsulta2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 366);
            this.Controls.Add(this.grdQuery);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmConsulta2";
            this.Text = "frmConsulta2";
            ((System.ComponentModel.ISupportInitialize)(this.grdQuery)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdQuery;
        private System.Windows.Forms.DataGridViewTextBoxColumn localidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn cultivo1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cultivo2;
        private System.Windows.Forms.DataGridViewTextBoxColumn cultivo3;
        private System.Windows.Forms.DataGridViewTextBoxColumn cultivo4;
        private System.Windows.Forms.DataGridViewTextBoxColumn cultivo5;
    }
}