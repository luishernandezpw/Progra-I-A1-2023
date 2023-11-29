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
    public partial class frmImpresionInscripcion : Form
    {
        int _idInscripcion = 0;
        public frmImpresionInscripcion(int id)
        {
            _idInscripcion = id;
            InitializeComponent();
        }

        private void frmImpresionInscripcion_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'db_academicoDataSet.dtFichaInscripcion' Puede moverla o quitarla según sea necesario.
            this.dtFichaInscripcionTableAdapter.Fill(this.db_academicoDataSet.dtFichaInscripcion, _idInscripcion);

            this.rpvImpresionInscripcion.RefreshReport();
        }
    }
}
