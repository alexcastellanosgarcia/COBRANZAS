using MaterialSkin.Controls;
using System;
using COBRANZAS.CLIENTES;
using COBRANZAS.Model;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COBRANZAS.CLIENTES
{
    public partial class frmClientes : MaterialForm
            {

        TCN_Clientes objCNClientes = new TCN_Clientes();

                public frmClientes()
        {
            InitializeComponent();
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {

        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            var Cliente = objCNClientes.Consultar(tbxid.Text);

            tbxidentidad.Text = Cliente.Identidad;
            tbxnombre.Text = Cliente.Nombre;            
            tbxdireccion.Text = Cliente.Direccion;
            tbxtelefono.Text = Cliente.Telefono;
            tbxcorreo.Text = Cliente.Correo;
            tbxmunicipio.Text = Cliente.Municipio;

        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }

        private void materialButton1_Click_1(object sender, EventArgs e)
        {
            TModelsClientes cliente = new TModelsClientes();

            cliente.Identidad = tbxidentidad.Text;
            cliente.Nombre = tbxnombre.Text;            
            cliente.Direccion = tbxdireccion.Text;
            cliente.Telefono = tbxtelefono.Text;
            cliente.Correo = tbxcorreo.Text;
            cliente.Municipio = tbxmunicipio.Text;
            DateTime FechaNac = new DateTime(2001, 12, 14);
            cliente.FechaNacimiento = FechaNac;

            var respuesta = this.objCNClientes.Guardar(cliente, "Sistema");
            if (respuesta)
                MessageBox.Show("El Cliente se ha guardado exitosamente");
            else
                MessageBox.Show("El cliente no se ha podido Guardar");

            
        }

        private void tbxFechaNac_TextChanged(object sender, EventArgs e)
        {

        }

        private void materialCard1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
