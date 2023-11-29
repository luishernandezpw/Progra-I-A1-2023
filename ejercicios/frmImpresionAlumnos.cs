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
    public partial class frmImpresionAlumnos : Form
    {
        public frmImpresionAlumnos()
        {
            InitializeComponent();
        }

        private void frmImpresionAlumnos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'db_academicoDataSet.alumnos' Puede moverla o quitarla según sea necesario.
            this.alumnosTableAdapter.Fill(this.db_academicoDataSet.alumnos);

            this.rpvImpresionalumnos.RefreshReport();
        }
    }
}
