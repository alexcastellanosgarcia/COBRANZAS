using MaterialSkin.Controls;
using System;
using COBRANZAS.CLIENTES;
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
            var Cliente = objCNClientes.Consultar(txtID.Text);
           
               
                    txtNOMBRE.Text = Cliente.Nombre;
                    txtIDENTIDAD.Text = Cliente.Identidad
                
            
        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }

        private void materialButton1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
