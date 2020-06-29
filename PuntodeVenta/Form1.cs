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
    public partial class Form1 : Form
    {
        ConexionSQLN cn = new ConexionSQLN();

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Ingresar_Click(object sender, EventArgs e)
        {
            string a = txt_usuario.Text;
            string b = txt_password.Text;

            if (cn.conSQL(a, b) == 1)
            {
                MessageBox.Show("Bienvenido");

                this.Hide();

                VentanaPrincipal v1 = new VentanaPrincipal();
                v1.Show();
            }
            else
            {
                MessageBox.Show("Usuario no encontrado");
            }

        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
