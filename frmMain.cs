using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pry.AUTOCARsp1SEMESTRE2
{
    public partial class frmAutocar : Form
    {

        List<clsRepuestos> ListaRepuestos = new List<clsRepuestos>();

        void LimpiarControles()
        {
            txtCodigo.Text = "";
            txtNombre.Text = "";
            cmdMarca.SelectedIndex = -1;
            txtPrecio.Text = "";
        }

        public frmAutocar()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            clsRepuestos objRepuesto = new clsRepuestos();
            objRepuesto.codigo = int.Parse(txtCodigo.Text);
            objRepuesto.nombre = txtNombre.Text;
            objRepuesto.marca = cmdMarca.Text;
            objRepuesto.precio = int.Parse(txtPrecio.Text);
            if (optNacional.Checked)
            {
                objRepuesto.Origen = "Nacional";
            }
            else
            {
                objRepuesto.Origen = "Importado";
            }
            ListaRepuestos.Add(objRepuesto);
            MessageBox.Show(objRepuesto.Consultar(), "Repuesto");
            LimpiarControles();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            lstRepuestos.Items.Clear();
            foreach (clsRepuestos repuesto in ListaRepuestos)
            {
                lstRepuestos.Items.Add(repuesto.codigo + " " + repuesto + " " + repuesto.marca + " " + repuesto.precio + " " + repuesto.Origen);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
           // LimpiarControles();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}