using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicios
{
    public partial class inscripcion : Form
    {
        public inscripcion()
        {
            InitializeComponent();
        }

        private void inscripcionBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.inscripcionBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.db_academicoDataSet);

        }

        private void inscripcion_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'db_academicoDataSet.dInscripcionMateria' Puede moverla o quitarla según sea necesario.
            this.dtDetalleInscripcionMateria.Fill(this.db_academicoDataSet.dInscripcionMateria);
            // TODO: esta línea de código carga datos en la tabla 'db_academicoDataSet.alumnos' Puede moverla o quitarla según sea necesario.
            this.alumnosTableAdapter.Fill(this.db_academicoDataSet.alumnos);
            // TODO: esta línea de código carga datos en la tabla 'db_academicoDataSet.matriculaAlumnosPeriodos' Puede moverla o quitarla según sea necesario.
            this.dtMatriculaAlumnosPeriodos.Fill(this.db_academicoDataSet.matriculaAlumnosPeriodos);
            // TODO: esta línea de código carga datos en la tabla 'db_academicoDataSet.inscripcion' Puede moverla o quitarla según sea necesario.
            this.inscripcionTableAdapter.Fill(this.db_academicoDataSet.inscripcion);

        }
    }
}
