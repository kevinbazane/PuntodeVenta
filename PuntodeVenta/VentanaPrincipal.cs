using Negocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuntodeVenta
{
    public partial class VentanaPrincipal : Form
    {

        private DataTable dt;
        ConexionSQLN sqln = new ConexionSQLN();

        public VentanaPrincipal()
        {
            InitializeComponent();
            txt_impuesto_venta.Text = txt_menu_imp_venta.Text;
            txt_descuento.Text = txt_menu_descuento.Text;

            dt = new DataTable();
            dt.Columns.Add("Codigo");
            dt.Columns.Add("Producto");
            dt.Columns.Add("Precio x Unidad");
            dt.Columns.Add("Cantidad");
            dt.Columns.Add("Descuento");
            dt.Columns.Add("Precio Total");

            dataGridView1.DataSource = dt;

            txt_numFactura.Text = sqln.ConsultaFactura();
        }

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
            
        }

        private void btn_Menu_Usuario_Click(object sender, EventArgs e)
        {
            FormUsers v1 = new FormUsers();
            this.Hide();
            v1.ShowDialog();
            this.Show();
        }

        private void btn_Menu_Inventario_Click(object sender, EventArgs e)
        {
            FormsInventario v1 = new FormsInventario();
            this.Hide();
            v1.ShowDialog();
            this.Show();
        }

        private void ImpVenta(object sender, EventArgs e)
        {
            txt_impuesto_venta.Text = txt_menu_imp_venta.Text;
            txt_descuento.Text = txt_menu_descuento.Text;
        }

        private void btn_AgregarProducto_Click(object sender, EventArgs e)
        {
            DataRow row = dt.NewRow();

            row["Codigo"] = txt_codigo.Text;
            row["Producto"] = "Producto X";
            row["Precio x Unidad"] = "3500";
            row["Cantidad"] = txt_cantidad.Text;
            row["Descuento"] = txt_descuento.Text;
            row["Precio Total"] = "10000";

            dt.Rows.Add(row);
        }
    }
}
