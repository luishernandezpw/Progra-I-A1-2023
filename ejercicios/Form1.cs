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
    public partial class Form1 : Form
    {
        Conversores objConversor = new Conversores();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConvertirConversores_Click(object sender, EventArgs e)
        {
            int de = cboDeConversores.SelectedIndex, a = cboAConversores.SelectedIndex ;
            double cantidad = double.Parse(txtCantidadConversores.Text), 
                respuesta = objConversor.convertir(cboTipoConversor.SelectedIndex, de, a, cantidad);
            
            lblRespuestaConversores.Text = "Respuesta: " + Math.Round(respuesta,3);
        }

        private void cboTipoConversor_TextChanged(object sender, EventArgs e)
        {
            cboDeConversores.Items.Clear();
            cboAConversores.Items.Clear();

            cboDeConversores.Items.AddRange(objConversor.etiquetas[cboTipoConversor.SelectedIndex]);
            cboAConversores.Items.AddRange(objConversor.etiquetas[cboTipoConversor.SelectedIndex]);
        }
    }
}
