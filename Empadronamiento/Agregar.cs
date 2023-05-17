using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Empadronamiento
{
    public partial class Agregar : Form
    {
        public Agregar()
        {
            InitializeComponent();
        }

        private void regresar_Click(object sender, EventArgs e)
        {
            this.Close();

            Form1 fr2= new Form1();
            fr2.Show();

        }

        private void ingresar_Click(object sender, EventArgs e)
        {
            ConexionBD conexion = new ConexionBD();
            conexion.abrir();

            string nombre = name.Text;
            string apellido = lastname.Text;
            string telefono = phone.Text;
            string cui = idnumber.Text;
            string departamento = state.Text;
            string correo = email.Text;

            string cadena = "insert into personas (nombre, apellido, telefono, cui, departamento, correo) values ('" + name.Text + "', '" + lastname.Text + "','" + phone.Text + "','" + idnumber.Text + "', '" + state.Text + "', '" + email.Text + "')";
            SqlCommand comando = new SqlCommand(cadena, conexion.conectarbd);
            comando.ExecuteNonQuery();
            MessageBox.Show("Se ha empadronado correctamente");

            name.Text = "";
            lastname.Text = "";
            phone.Text = "";
            idnumber.Text = "";
            state.Text = "";
            email.Text = "";

        }
    }
}
