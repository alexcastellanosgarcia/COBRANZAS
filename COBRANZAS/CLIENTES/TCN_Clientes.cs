using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using COBRANZAS.Model;
using COBRANZAS.CLIENTES;
using System.Data;

namespace COBRANZAS.CLIENTES

{
    public class TCN_Clientes
    {
        TAD_Clientes objAD_Clientes = new TAD_Clientes();

        public TModelsClientes Consultar(String Id) {
            var result = int.TryParse(Id, out int valId);
            if (result)
                return objAD_Clientes.Consultar(valId);
            else
                return default;
           
        }


    }
}
