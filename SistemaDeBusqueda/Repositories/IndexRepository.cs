using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaDeBusqueda.Repositories
{
    public class IndexRepository
    {
        private readonly string ConnectionString = "server=localhost;database=sb3600db;Integrated Security=true;";

        public bool ValidarUsuario(string usuario,string password)
        {
            bool resultado = false;
            using SqlConnection sql = new SqlConnection(ConnectionString);
            using SqlCommand cmd = new SqlCommand("select count(*) from usuarios where usuario = '"+ usuario + "' and [password] = '"+password+"'", sql);
            int valor;

            sql.Open();
            valor = (int)cmd.ExecuteScalar();
            if (valor > 0) 
            {
                resultado = true;
            }

            return resultado;
        }


    }
}
