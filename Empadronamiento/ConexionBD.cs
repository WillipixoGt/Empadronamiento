using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.SqlTypes;


namespace Empadronamiento
{
     class ConexionBD
    {
        string cadena = "Data source=DESKTOP-TON1BAR\\SQLEXPRESS; Initial Catalog= empadronamiento; Integrated Security=True";
        public SqlConnection conectarbd = new SqlConnection();

        public ConexionBD()
        {
            conectarbd.ConnectionString = cadena;
        }

        public void abrir()
        {
            try
            {
                conectarbd.Open();
                Console.WriteLine("Conexion Exitosa");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al abrir la BASE DE DATOS" + ex.Message);
            }

        }

        public void cerrar()
        {
            conectarbd.Close();
        }
    }

   
}
