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
    public partial class frmImpresionMaterias : Form
    {
        public frmImpresionMaterias()
        {
            InitializeComponent();
        }

        private void frmImpresionMaterias_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'db_academicoDataSet.materias' Puede moverla o quitarla según sea necesario.
            this.materiasTableAdapter.Fill(this.db_academicoDataSet.materias);

            this.rpvImpresionMaterias.RefreshReport();
        }
    }
}
