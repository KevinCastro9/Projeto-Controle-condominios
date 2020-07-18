using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Bifrost_condos
{
    public class Conexão
    {
        SqlConnection con = new SqlConnection();

        //Construtor
        public Conexão()
        {
            con.ConnectionString = @"Data Source=DESKTOP-HDQ6L8M\SQLEXPRESS;Initial Catalog=Bifrost2 ;User Id=kevin;Password=12345";
        }
        //Metodo Conectar
        public SqlConnection conectar()
        {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }
        //Metodo Desconectar
        public void desconectar()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
        }
    }
}
