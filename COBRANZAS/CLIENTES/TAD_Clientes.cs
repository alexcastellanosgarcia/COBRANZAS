using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using COBRANZAS.AdminDB;
using COBRANZAS.Model;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace COBRANZAS.CLIENTES
{
    public class TAD_Clientes
    {
        TModelsClientes objcliente = new TModelsClientes();
        TParamSql objparamSql = new TParamSql();

        public TAD_Clientes() 
        { 
         
        }

        public DataTable Consultar(int Id)     {

            DataTable dtClientes = new DataTable();
            using (SqlConnection con = new SqlConnection(objparamSql.getStringCon()))
            {                
                try {
                    con.Open();
                    SqlCommand query = new SqlCommand($"SELECT * FROM CLIENTES WHERE ID ={Id}", con);
                    
                    dtClientes.Load(query.ExecuteReader());
                    con.Close();
                    if (dtClientes.Rows.Count > 0)
                    {
                        foreach (DataRow Fila in dtClientes.Rows)
                            {
                            objcliente.Id = Convert.ToInt32(Fila["ID"].ToString());
                            objcliente.Identidad = (Fila["IDENTIDAD"].ToString());
                            objcliente.Direccion = (Fila["DIRECCION"].ToString());
                            objcliente.Telefono = (Fila["TELEFONO"].ToString());
                            objcliente.Correo = (Fila["CORREO"].ToString());
                            objcliente.Municipio = (Fila["MUNICIPIO"].ToString());
                            objcliente.UsuarioCreacion = (Fila["USUARIO_CREACION"].ToString());
                            objcliente.UsuarioModificacion = (Fila["USUARIO_MODIFICACION"].ToString());
                                                    }
                        }
                    }
                catch (Exception Err)
                {
                    MessageBox.Show($"La Operacion No Se Pudo Completar \n {Err.Message} ");
                }
            }  
            return dtClientes;
        }

        public bool Guardar (TModelsClientes prmCliente)
        {
            return false;
        }

        public bool Modificar(TModelsClientes prmCliente)
        {
            return false;
        }

        public bool Anular(TModelsClientes prmCliente)
        {
            return false;
        }
    }
}
