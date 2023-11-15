namespace ejercicios
{
    partial class inscripcion
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
            System.Windows.Forms.Label idInscripcionLabel;
            System.Windows.Forms.Label fechaLabel;
            System.Windows.Forms.Label idAlumnoLabel;
            this.db_academicoDataSet = new ejercicios.db_academicoDataSet();
            this.inscripcionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inscripcionTableAdapter = new ejercicios.db_academicoDataSetTableAdapters.inscripcionTableAdapter();
            this.tableAdapterManager = new ejercicios.db_academicoDataSetTableAdapters.TableAdapterManager();
            this.alumnosTableAdapter = new ejercicios.db_academicoDataSetTableAdapters.alumnosTableAdapter();
            this.idInscripcionTextBox = new System.Windows.Forms.TextBox();
            this.fechaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.matriculaAlumnosPeriodosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtMatriculaAlumnosPeriodos = new ejercicios.db_academicoDataSetTableAdapters.dtMatriculaAlumnosPeriodos();
            this.idAlumnoComboBox = new System.Windows.Forms.ComboBox();
            this.alumnosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dInscripcionMateriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtDetalleInscripcionMateria = new ejercicios.db_academicoDataSetTableAdapters.dtDetalleInscripcionMateria();
            this.dInscripcionMateriaDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            idInscripcionLabel = new System.Windows.Forms.Label();
            fechaLabel = new System.Windows.Forms.Label();
            idAlumnoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.db_academicoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inscripcionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matriculaAlumnosPeriodosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumnosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dInscripcionMateriaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dInscripcionMateriaDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // idInscripcionLabel
            // 
            idInscripcionLabel.AutoSize = true;
            idInscripcionLabel.Location = new System.Drawing.Point(41, 39);
            idInscripcionLabel.Name = "idInscripcionLabel";
            idInscripcionLabel.Size = new System.Drawing.Size(21, 13);
            idInscripcionLabel.TabIndex = 1;
            idInscripcionLabel.Text = "ID:";
            // 
            // fechaLabel
            // 
            fechaLabel.AutoSize = true;
            fechaLabel.Location = new System.Drawing.Point(41, 82);
            fechaLabel.Name = "fechaLabel";
            fechaLabel.Size = new System.Drawing.Size(40, 13);
            fechaLabel.TabIndex = 5;
            fechaLabel.Text = "Fecha:";
            // 
            // idAlumnoLabel
            // 
            idAlumnoLabel.AutoSize = true;
            idAlumnoLabel.Location = new System.Drawing.Point(41, 132);
            idAlumnoLabel.Name = "idAlumnoLabel";
            idAlumnoLabel.Size = new System.Drawing.Size(45, 13);
            idAlumnoLabel.TabIndex = 7;
            idAlumnoLabel.Text = "Alumno:";
            // 
            // db_academicoDataSet
            // 
            this.db_academicoDataSet.DataSetName = "db_academicoDataSet";
            this.db_academicoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // inscripcionBindingSource
            // 
            this.inscripcionBindingSource.DataMember = "inscripcion";
            this.inscripcionBindingSource.DataSource = this.db_academicoDataSet;
            // 
            // inscripcionTableAdapter
            // 
            this.inscripcionTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.alumnosTableAdapter = this.alumnosTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.detalle_inscripcionTableAdapter = null;
            this.tableAdapterManager.detalle_notasTableAdapter = null;
            this.tableAdapterManager.docentesTableAdapter = null;
            this.tableAdapterManager.inscripcionTableAdapter = this.inscripcionTableAdapter;
            this.tableAdapterManager.materiasTableAdapter = null;
            this.tableAdapterManager.matriculaTableAdapter = null;
            this.tableAdapterManager.notasTableAdapter = null;
            this.tableAdapterManager.periodosTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ejercicios.db_academicoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // alumnosTableAdapter
            // 
            this.alumnosTableAdapter.ClearBeforeFill = true;
            // 
            // idInscripcionTextBox
            // 
            this.idInscripcionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inscripcionBindingSource, "idInscripcion", true));
            this.idInscripcionTextBox.Enabled = false;
            this.idInscripcionTextBox.Location = new System.Drawing.Point(92, 32);
            this.idInscripcionTextBox.Name = "idInscripcionTextBox";
            this.idInscripcionTextBox.Size = new System.Drawing.Size(87, 20);
            this.idInscripcionTextBox.TabIndex = 2;
            // 
            // fechaDateTimePicker
            // 
            this.fechaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.inscripcionBindingSource, "fecha", true));
            this.fechaDateTimePicker.Location = new System.Drawing.Point(92, 78);
            this.fechaDateTimePicker.Name = "fechaDateTimePicker";
            this.fechaDateTimePicker.Size = new System.Drawing.Size(210, 20);
            this.fechaDateTimePicker.TabIndex = 6;
            // 
            // matriculaAlumnosPeriodosBindingSource
            // 
            this.matriculaAlumnosPeriodosBindingSource.DataMember = "matriculaAlumnosPeriodos";
            this.matriculaAlumnosPeriodosBindingSource.DataSource = this.db_academicoDataSet;
            // 
            // dtMatriculaAlumnosPeriodos
            // 
            this.dtMatriculaAlumnosPeriodos.ClearBeforeFill = true;
            // 
            // idAlumnoComboBox
            // 
            this.idAlumnoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.matriculaAlumnosPeriodosBindingSource, "idAlumno", true));
            this.idAlumnoComboBox.DataSource = this.alumnosBindingSource;
            this.idAlumnoComboBox.DisplayMember = "nombre";
            this.idAlumnoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.idAlumnoComboBox.FormattingEnabled = true;
            this.idAlumnoComboBox.Location = new System.Drawing.Point(92, 129);
            this.idAlumnoComboBox.Name = "idAlumnoComboBox";
            this.idAlumnoComboBox.Size = new System.Drawing.Size(205, 21);
            this.idAlumnoComboBox.TabIndex = 8;
            this.idAlumnoComboBox.ValueMember = "idAlumno";
            // 
            // alumnosBindingSource
            // 
            this.alumnosBindingSource.DataMember = "alumnos";
            this.alumnosBindingSource.DataSource = this.db_academicoDataSet;
            // 
            // dInscripcionMateriaBindingSource
            // 
            this.dInscripcionMateriaBindingSource.DataMember = "dInscripcionMateria";
            this.dInscripcionMateriaBindingSource.DataSource = this.db_academicoDataSet;
            // 
            // dtDetalleInscripcionMateria
            // 
            this.dtDetalleInscripcionMateria.ClearBeforeFill = true;
            // 
            // dInscripcionMateriaDataGridView
            // 
            this.dInscripcionMateriaDataGridView.AutoGenerateColumns = false;
            this.dInscripcionMateriaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dInscripcionMateriaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.dInscripcionMateriaDataGridView.DataSource = this.dInscripcionMateriaBindingSource;
            this.dInscripcionMateriaDataGridView.Location = new System.Drawing.Point(44, 172);
            this.dInscripcionMateriaDataGridView.Name = "dInscripcionMateriaDataGridView";
            this.dInscripcionMateriaDataGridView.Size = new System.Drawing.Size(547, 329);
            this.dInscripcionMateriaDataGridView.TabIndex = 8;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "idDetalle";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "idInscripcion";
            this.dataGridViewTextBoxColumn2.HeaderText = "idInscripcion";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Visible = false;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "idMateria";
            this.dataGridViewTextBoxColumn3.HeaderText = "idMateria";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Visible = false;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "codigo";
            this.dataGridViewTextBoxColumn4.HeaderText = "CODIGO";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "materia";
            this.dataGridViewTextBoxColumn5.HeaderText = "MATERIA";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 200;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "uv";
            this.dataGridViewTextBoxColumn6.HeaderText = "UV";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // inscripcion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 513);
            this.Controls.Add(this.dInscripcionMateriaDataGridView);
            this.Controls.Add(idAlumnoLabel);
            this.Controls.Add(this.idAlumnoComboBox);
            this.Controls.Add(idInscripcionLabel);
            this.Controls.Add(this.idInscripcionTextBox);
            this.Controls.Add(fechaLabel);
            this.Controls.Add(this.fechaDateTimePicker);
            this.Name = "inscripcion";
            this.Text = "inscripcion";
            this.Load += new System.EventHandler(this.inscripcion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.db_academicoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inscripcionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matriculaAlumnosPeriodosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumnosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dInscripcionMateriaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dInscripcionMateriaDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private db_academicoDataSet db_academicoDataSet;
        private System.Windows.Forms.BindingSource inscripcionBindingSource;
        private db_academicoDataSetTableAdapters.inscripcionTableAdapter inscripcionTableAdapter;
        private db_academicoDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox idInscripcionTextBox;
        private System.Windows.Forms.DateTimePicker fechaDateTimePicker;
        private System.Windows.Forms.BindingSource matriculaAlumnosPeriodosBindingSource;
        private db_academicoDataSetTableAdapters.dtMatriculaAlumnosPeriodos dtMatriculaAlumnosPeriodos;
        private db_academicoDataSetTableAdapters.alumnosTableAdapter alumnosTableAdapter;
        private System.Windows.Forms.ComboBox idAlumnoComboBox;
        private System.Windows.Forms.BindingSource alumnosBindingSource;
        private System.Windows.Forms.BindingSource dInscripcionMateriaBindingSource;
        private db_academicoDataSetTableAdapters.dtDetalleInscripcionMateria dtDetalleInscripcionMateria;
        private System.Windows.Forms.DataGridView dInscripcionMateriaDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}