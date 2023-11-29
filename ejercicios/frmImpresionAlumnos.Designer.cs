namespace ejercicios
{
    partial class frmImpresionAlumnos
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
            this.rpvImpresionalumnos = new Microsoft.Reporting.WinForms.ReportViewer();
            this.db_academicoDataSet = new ejercicios.db_academicoDataSet();
            this.alumnosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.alumnosTableAdapter = new ejercicios.db_academicoDataSetTableAdapters.alumnosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.db_academicoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumnosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rpvImpresionalumnos
            // 
            this.rpvImpresionalumnos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource1.Name = "dsImprimirAlumnos";
            reportDataSource1.Value = this.alumnosBindingSource;
            this.rpvImpresionalumnos.LocalReport.DataSources.Add(reportDataSource1);
            this.rpvImpresionalumnos.LocalReport.ReportEmbeddedResource = "ejercicios.impresion_alumnos.rdlc";
            this.rpvImpresionalumnos.Location = new System.Drawing.Point(12, 12);
            this.rpvImpresionalumnos.Name = "rpvImpresionalumnos";
            this.rpvImpresionalumnos.ServerReport.BearerToken = null;
            this.rpvImpresionalumnos.Size = new System.Drawing.Size(679, 408);
            this.rpvImpresionalumnos.TabIndex = 0;
            // 
            // db_academicoDataSet
            // 
            this.db_academicoDataSet.DataSetName = "db_academicoDataSet";
            this.db_academicoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // alumnosBindingSource
            // 
            this.alumnosBindingSource.DataMember = "alumnos";
            this.alumnosBindingSource.DataSource = this.db_academicoDataSet;
            // 
            // alumnosTableAdapter
            // 
            this.alumnosTableAdapter.ClearBeforeFill = true;
            // 
            // frmImpresionAlumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 423);
            this.Controls.Add(this.rpvImpresionalumnos);
            this.Name = "frmImpresionAlumnos";
            this.Text = "Imprimir listado de alumnos";
            this.Load += new System.EventHandler(this.frmImpresionAlumnos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.db_academicoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumnosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpvImpresionalumnos;
        private System.Windows.Forms.BindingSource alumnosBindingSource;
        private db_academicoDataSet db_academicoDataSet;
        private db_academicoDataSetTableAdapters.alumnosTableAdapter alumnosTableAdapter;
    }
}