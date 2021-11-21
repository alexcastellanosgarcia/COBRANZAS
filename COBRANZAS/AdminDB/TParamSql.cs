using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace COBRANZAS.AdminDB
{
    public class TParamSql
    {
        private SqlConnectionStringBuilder objBuilder = new SqlConnectionStringBuilder();

        public TParamSql()
        {
            objBuilder.DataSource = "DESKTOP-LD7APCG";
            objBuilder.InitialCatalog = "PROYECTO_CSHARP";
            objBuilder.UserID = "sa";
            objBuilder.Password = "Admin%123";
        }

        // Retorna cadena de conexion.
        public String getStringCon()
        {
            return objBuilder.ConnectionString;
        }

    }
}
