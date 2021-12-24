using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using COBRANZAS.Model;
using COBRANZAS.CLIENTES;
using System.Data;
using System.Windows.Forms;

namespace COBRANZAS.CLIENTES

{
    public class TCN_Clientes
    {
        TAD_Clientes objAD_Clientes = new TAD_Clientes();

        public TModelsClientes Consultar(String Id) 
        {
            var result = int.TryParse(Id, out int valId);
            if (result)
                return objAD_Clientes.Consultar(valId);
            else
                return default;           
        }

        public bool Guardar (TModelsClientes prmCliente, String prmUsuario)
        {
            return this.objAD_Clientes.Guardar(prmCliente, prmUsuario);
        }
        public bool Modificar(TModelsClientes prmCliente, String prmUsuario)
        {
            return this.objAD_Clientes.Modificar(prmCliente, prmUsuario);
        }

        public bool Anular(String prmIdCliente)
        {
            bool res = false;
            if (int.TryParse(prmIdCliente, out int valId))
            {
                res = this.objAD_Clientes.Anular(valId);
            }
            else
            {
                MessageBox.Show("El valor del ID es invalido", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return res;
        }
        public List<TModelsClientes> GetClientes() 
        {
            return objAD_Clientes.GetClientes();
        }

    }
}
