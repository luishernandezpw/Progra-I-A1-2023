namespace ejercicios
{
    partial class frmImpresionInscripcion
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.rpvImpresionInscripcion = new Microsoft.Reporting.WinForms.ReportViewer();
            this.db_academicoDataSet = new ejercicios.db_academicoDataSet();
            this.dtFichaInscripcionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtFichaInscripcionTableAdapter = new ejercicios.db_academicoDataSetTableAdapters.dtFichaInscripcionTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.db_academicoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFichaInscripcionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rpvImpresionInscripcion
            // 
            this.rpvImpresionInscripcion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource1.Name = "dsImpresionInscripcion";
            reportDataSource1.Value = this.dtFichaInscripcionBindingSource;
            this.rpvImpresionInscripcion.LocalReport.DataSources.Add(reportDataSource1);
            this.rpvImpresionInscripcion.LocalReport.ReportEmbeddedResource = "ejercicios.impresion_inscripcion.rdlc";
            this.rpvImpresionInscripcion.Location = new System.Drawing.Point(12, 12);
            this.rpvImpresionInscripcion.Name = "rpvImpresionInscripcion";
            this.rpvImpresionInscripcion.ServerReport.BearerToken = null;
            this.rpvImpresionInscripcion.Size = new System.Drawing.Size(776, 426);
            this.rpvImpresionInscripcion.TabIndex = 0;
            // 
            // db_academicoDataSet
            // 
            this.db_academicoDataSet.DataSetName = "db_academicoDataSet";
            this.db_academicoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dtFichaInscripcionBindingSource
            // 
            this.dtFichaInscripcionBindingSource.DataMember = "dtFichaInscripcion";
            this.dtFichaInscripcionBindingSource.DataSource = this.db_academicoDataSet;
            // 
            // dtFichaInscripcionTableAdapter
            // 
            this.dtFichaInscripcionTableAdapter.ClearBeforeFill = true;
            // 
            // frmImpresionInscripcion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rpvImpresionInscripcion);
            this.Name = "frmImpresionInscripcion";
            this.Text = "Impresion de la ficha de inscripcion";
            this.Load += new System.EventHandler(this.frmImpresionInscripcion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.db_academicoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFichaInscripcionBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpvImpresionInscripcion;
        private System.Windows.Forms.BindingSource dtFichaInscripcionBindingSource;
        private db_academicoDataSet db_academicoDataSet;
        private db_academicoDataSetTableAdapters.dtFichaInscripcionTableAdapter dtFichaInscripcionTableAdapter;
    }
}