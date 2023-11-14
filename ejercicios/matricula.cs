﻿using System;
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
    public partial class matricula : Form
    {
        public matricula()
        {
            InitializeComponent();
        }

        private void matricula_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'db_academicoDataSet.matriculaAlumnosPeriodos' Puede moverla o quitarla según sea necesario.
            this.dtMatriculaAlumnosPeriodos.Fill(this.db_academicoDataSet.matriculaAlumnosPeriodos);
            // TODO: esta línea de código carga datos en la tabla 'db_academicoDataSet.alumnos' Puede moverla o quitarla según sea necesario.
            this.alumnosTableAdapter.Fill(this.db_academicoDataSet.alumnos);
            // TODO: esta línea de código carga datos en la tabla 'db_academicoDataSet.periodos' Puede moverla o quitarla según sea necesario.
            this.periodosTableAdapter.Fill(this.db_academicoDataSet.periodos);
            this.matriculaTableAdapter1.Fill(this.db_academicoDataSet.matricula);
            nRegistrosMatricula();
        }
        private void nRegistrosMatricula()
        {
            lblnRegistroMatricula.Text = (matriculaBindingSource.Position + 1) + " de " + matriculaBindingSource.Count;
        }
        private void btnPrimeroMatricula_Click(object sender, EventArgs e)
        {
            matriculaBindingSource.MoveFirst();
            nRegistrosMatricula();
        }
        private void btnSiguienteMatricula_Click(object sender, EventArgs e)
        {
            matriculaBindingSource.MoveNext();
            nRegistrosMatricula();
        }
        private void btnUltimoMatricula_Click(object sender, EventArgs e)
        {
            matriculaBindingSource.MoveLast();
            nRegistrosMatricula();
        }
        private void btnAnteriorMatricula_Click(object sender, EventArgs e)
        {
            matriculaBindingSource.MovePrevious();
            nRegistrosMatricula();
        }

        private void btnNuevoMatricula_Click(object sender, EventArgs e)
        {
            if (btnNuevoMatricula.Text == "Nuevo"){
                btnNuevoMatricula.Text = "Guardar";
                btnModificarMatricula.Text = "Cancelar";
                estadoControles(true);

                matriculaBindingSource.AddNew();
            } else{
                matriculaBindingSource.EndEdit();
                this.matriculaTableAdapter1.Update(db_academicoDataSet);
                estadoControles(false);
                btnNuevoMatricula.Text = "Nuevo";
                btnModificarMatricula.Text = "Modificar";
            }
        }
        private void btnModificarMatricula_Click(object sender, EventArgs e)
        {
            if (btnModificarMatricula.Text == "Modificar"){
                btnNuevoMatricula.Text = "Guardar";
                btnModificarMatricula.Text = "Cancelar";
                estadoControles(true);

            }else{
                matriculaBindingSource.CancelEdit();

                estadoControles(false);
                btnNuevoMatricula.Text = "Nuevo";
                btnModificarMatricula.Text = "Modificar";
            }
        }
        private void estadoControles(Boolean estado)
        {
            cboAlumnoMatricula.Enabled = estado;
            cboPeriodoMatricula.Enabled = estado;
            dtFechaMatriucla.Enabled = estado;

            grbNavegacionMatricula.Enabled = !estado;
            btnEliminarMatricula.Enabled = !estado;
        }
        private void btnEliminarMatricula_Click(object sender, EventArgs e)
        {
            matriculaBindingSource.RemoveCurrent();
            this.matriculaTableAdapter1.Update(db_academicoDataSet);
            nRegistrosMatricula();
        }
    }
}
