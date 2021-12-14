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

        public TModelsClientes Consultar(int Id)     {
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
            return objcliente;
        }

        public bool Guardar (TModelsClientes prmCliente, string prmUsuario) {
            bool ValResult = false;

            using (SqlConnection con = new SqlConnection(objparamSql.getStringCon())) {
                try
                {
                    con.Open();
                    SqlCommand sql = new SqlCommand("SP_INSERTAR_CLIENTES", con);
                    sql.CommandType = CommandType.StoredProcedure;
                    sql.CommandText = "SP_INSERTAR_CLIENTES";
                    sql.Parameters.AddWithValue("@prmIdentidad", prmCliente.Identidad);
                    sql.Parameters.AddWithValue("prmNombre", prmCliente.Nombre);
                    sql.Parameters.AddWithValue("@prmDireccion", prmCliente.Direccion);
                    sql.Parameters.AddWithValue("@prmTelefono", prmCliente.Telefono);
                    sql.Parameters.AddWithValue("@prmCorreo", prmCliente.Correo);
                    sql.Parameters.AddWithValue("@prmMunicipio", prmCliente.Municipio);
                    sql.Parameters.AddWithValue("@prmFechaNacimiento", prmCliente.FechaNacimiento);
                    sql.Parameters.AddWithValue("@prmUsuario", prmUsuario);
                    sql.Parameters.AddWithValue("@prmResult", SqlDbType.Int).Direction = ParameterDirection.Output;
                    sql.ExecuteNonQuery();
                    String Num = sql.Parameters["Result"].Value.ToString();
                    MessageBox.Show(Num);

                }
                catch (Exception Err )
                {
                    MessageBox.Show($"La Operacion No Se Pudo Completar \n {Err.Message} ");
                }

            }
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
