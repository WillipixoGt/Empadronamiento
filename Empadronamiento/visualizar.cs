using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Empadronamiento
{
    public partial class visualizar : Form
    {
        public visualizar()
        {
            InitializeComponent();
        }

        private void visualizar_Load(object sender, EventArgs e)
        {
            ConexionBD conexion = new ConexionBD();
            conexion.abrir();

            string cadena = "SELECT * FROM personas";
            SqlCommand comando = new SqlCommand(cadena, conexion.conectarbd);
            SqlDataAdapter adaptador = new SqlDataAdapter(comando);

            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);

            ver.DataSource = tabla;
        }

        private void regresar_Click(object sender, EventArgs e)
        {
            this.Close();

            Form1 f3 = new Form1();
            f3.Show();
        }
    }
}
