using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Negocios;

namespace PuntodeVenta
{
    public partial class FormUsers : Form
    {
        ConexionSQLN cn = new ConexionSQLN();
        

        public FormUsers()
        {
            InitializeComponent();
            dataGridView1.DataSource = cn.consultaDT();
        }

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            //Application.Exit();
        }

        private void btn_Nuevo_Click(object sender, EventArgs e)
        {
            string nombre = txt_nombre.Text;
            string apellido = txt_apellido.Text;
            string dni = txt_dni.Text;
            string telefono = txt_telefono.Text;
            string usuario = txt_usuario.Text;
            string contrasena = txt_contrasena.Text;
            cn.InsertarUsuario(nombre, apellido, dni, telefono, usuario, contrasena);

            dataGridView1.DataSource = cn.consultaDT();

            MessageBox.Show("Usuario ingresado con exito");
        }

        private void btn_ModificarUsuario_Click(object sender, EventArgs e)
        {
            string nombre = txt_nombre.Text;
            string apellido = txt_apellido.Text;
            string dni = txt_dni.Text;
            string telefono = txt_telefono.Text;
            string usuario = txt_usuario.Text;
            string contrasena = txt_contrasena.Text;

            cn.ModificarUsuario(nombre, apellido, dni, telefono, usuario, contrasena);

            dataGridView1.DataSource = cn.consultaDT();
        }

        private void btn_EliminarUsuario_Click(object sender, EventArgs e)
        {
            string dni = txt_dni.Text;

            cn.EliminarUsuario(dni);

            dataGridView1.DataSource = cn.consultaDT();
        }
    }
}
