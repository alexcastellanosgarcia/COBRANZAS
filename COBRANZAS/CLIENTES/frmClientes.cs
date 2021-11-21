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
            if (Cliente.Rows.Count > 0)
            {
                foreach (DataRow Fila in Cliente.Rows)
                {
                    txtNOMBRE.Text = Fila["NOMBRE"].ToString();
                    txtIDENTIDAD.Text = Fila["IDENTIDAD"].ToString();
                }
            }
        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
