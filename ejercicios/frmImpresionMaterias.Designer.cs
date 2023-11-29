namespace ejercicios
{
    partial class frmImpresionMaterias
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
            this.rpvImpresionMaterias = new Microsoft.Reporting.WinForms.ReportViewer();
            this.db_academicoDataSet = new ejercicios.db_academicoDataSet();
            this.materiasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.materiasTableAdapter = new ejercicios.db_academicoDataSetTableAdapters.materiasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.db_academicoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materiasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rpvImpresionMaterias
            // 
            this.rpvImpresionMaterias.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource1.Name = "dsImpresionMaterias";
            reportDataSource1.Value = this.materiasBindingSource;
            this.rpvImpresionMaterias.LocalReport.DataSources.Add(reportDataSource1);
            this.rpvImpresionMaterias.LocalReport.ReportEmbeddedResource = "ejercicios.impresion_materias.rdlc";
            this.rpvImpresionMaterias.Location = new System.Drawing.Point(12, 12);
            this.rpvImpresionMaterias.Name = "rpvImpresionMaterias";
            this.rpvImpresionMaterias.ServerReport.BearerToken = null;
            this.rpvImpresionMaterias.Size = new System.Drawing.Size(776, 439);
            this.rpvImpresionMaterias.TabIndex = 0;
            // 
            // db_academicoDataSet
            // 
            this.db_academicoDataSet.DataSetName = "db_academicoDataSet";
            this.db_academicoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // materiasBindingSource
            // 
            this.materiasBindingSource.DataMember = "materias";
            this.materiasBindingSource.DataSource = this.db_academicoDataSet;
            // 
            // materiasTableAdapter
            // 
            this.materiasTableAdapter.ClearBeforeFill = true;
            // 
            // frmImpresionMaterias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rpvImpresionMaterias);
            this.Name = "frmImpresionMaterias";
            this.Text = "frmImpresionMaterias";
            this.Load += new System.EventHandler(this.frmImpresionMaterias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.db_academicoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materiasBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpvImpresionMaterias;
        private System.Windows.Forms.BindingSource materiasBindingSource;
        private db_academicoDataSet db_academicoDataSet;
        private db_academicoDataSetTableAdapters.materiasTableAdapter materiasTableAdapter;
    }
}