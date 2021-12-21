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

        List<TModelsClientes> objListClientes = new List<TModelsClientes>();

        public TAD_Clientes()
        {

        }
        //Consulta la informacion de un cliente

        public TModelsClientes Consultar(int Id)
        {
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
                            objcliente.Nombre = (Fila["NOMBRE"].ToString());
                            objcliente.Identidad = (Fila["IDENTIDAD"].ToString());
                            objcliente.Direccion = (Fila["DIRECCION"].ToString());
                            objcliente.Telefono = (Fila["TELEFONO"].ToString());
                            objcliente.Correo = (Fila["CORREO"].ToString());
                            objcliente.Municipio = (Fila["MUNICIPIO"].ToString());
                            objcliente.UsuarioCreacion = (Fila["USUARIO_CREACION"].ToString());
                            objcliente.UsuarioModificacion = (Fila["USUARIO_MODIFICACION"].ToString());
                            DateTime Fecha_Creacion = new DateTime();
                            objcliente.FechaCreacion = (DateTime.TryParse(Fila["FECHA_CREACION"].ToString(), out Fecha_Creacion) ? Fecha_Creacion : Fecha_Creacion);
                            DateTime Fecha_Nacimiento = new DateTime(); ;
                            objcliente.FechaNacimiento = (DateTime.TryParse(Fila["FECHA_NACIMIENTO"].ToString(), out Fecha_Nacimiento) ? Fecha_Nacimiento : Fecha_Nacimiento);
                            DateTime Fecha_Mod = new DateTime();
                            objcliente.FechaModificacion = (DateTime.TryParse(Fila["FECHA_MODIFICACION"].ToString(), out Fecha_Mod) ? Fecha_Mod : Fecha_Mod);

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

        //Devuelve la Lista de Clientes
        public List<TModelsClientes> GetClientes()
        {
            List<TModelsClientes> Clientes = new List<TModelsClientes>();

            using (SqlConnection con = new SqlConnection(objparamSql.getStringCon())) 
            {
                try
                {
                    con.Open();
                    SqlCommand objquery = new SqlCommand("SP_LISTAR_CLIENTES", con);
                    DataTable objdtDatos = new DataTable();
                    objdtDatos.Load(objquery.ExecuteReader());

                    if (objdtDatos.Rows.Count > 0)
                    {
                        foreach (DataRow Fila in objdtDatos.Rows)
                        {
                            Clientes.Add(new TModelsClientes
                            {
                                Id = (int)Fila["ID"],
                                Identidad = Fila["IDENTIDAD"].ToString(),
                                Nombre = Fila["NOMBRE"].ToString(),
                                Direccion = Fila["DIRECCION"].ToString(),
                                Telefono = Fila["TELEFONO"].ToString(),
                                Correo = Fila["CORREO"].ToString(),
                                Municipio = Fila["MUNICIPIO"].ToString(),
                                FechaNacimiento = (DateTime)Fila["FECHA_NACIMIENTO"],
                                UsuarioCreacion = Fila["USUARIO_CREACION"].ToString()
                            });                                                               
                        }                                       
                    }
                }
                catch(Exception Err)
                {
                    MessageBox.Show($"La Operacion no se Pudo Completar\n {Err.Message} ");
                }
                             }

            return Clientes;
        }

        //Guarda un nuevo registro para un Cliente
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
                    sql.Parameters.AddWithValue("@Result", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
                    sql.ExecuteNonQuery();
                    int Num = (int)sql.Parameters["@Result"].Value;

                    if (Num == 1)
                        ValResult = true;
                }
                catch (Exception Err )
                {
                    MessageBox.Show($"La Operacion No Se Pudo Completar \n {Err.Message} ");
                }

            }
                return ValResult;
        }

        //Modifica la informacion de un cliente
        public bool Modificar(TModelsClientes prmCliente, string prmUsuario)
        {
            bool ValResult = false;

            using (SqlConnection con = new SqlConnection(objparamSql.getStringCon()))
            {
                try
                {
                    con.Open();
                    SqlCommand sql = new SqlCommand("SP_ACTUALIZAR_CLIENTES", con);
                    sql.CommandType = CommandType.StoredProcedure;
                    sql.Parameters.AddWithValue("@prmId", prmCliente.Id);
                    sql.Parameters.AddWithValue("@prmIdentidad", prmCliente.Identidad);
                    sql.Parameters.AddWithValue("prmNombre", prmCliente.Nombre);
                    sql.Parameters.AddWithValue("@prmDireccion", prmCliente.Direccion);
                    sql.Parameters.AddWithValue("@prmTelefono", prmCliente.Telefono);
                    sql.Parameters.AddWithValue("@prmCorreo", prmCliente.Correo);
                    sql.Parameters.AddWithValue("@prmMunicipio", prmCliente.Municipio);
                    sql.Parameters.AddWithValue("@prmFechaNacimiento", prmCliente.FechaNacimiento);
                    sql.Parameters.AddWithValue("@prmUsuario", prmUsuario);
                    sql.Parameters.AddWithValue("@Result", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
                    sql.ExecuteNonQuery();
                    int Num = (int)sql.Parameters["@Result"].Value;

                    if (Num == 1)
                        ValResult = true;
                }
                catch (Exception Err)
                {
                    MessageBox.Show($"La Operacion No Se Pudo Completar \n {Err.Message} ");
                }

            }
            return ValResult;
        }

        public bool Anular(TModelsClientes prmCliente)
        {
            return false;
        }


    }
}
