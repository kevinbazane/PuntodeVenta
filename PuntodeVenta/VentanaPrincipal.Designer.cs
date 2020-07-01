namespace PuntodeVenta
{
    partial class VentanaPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Cerrar = new System.Windows.Forms.Button();
            this.Archivo = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirFactura = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.txt_menu_imp_venta = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.txt_menu_descuento = new System.Windows.Forms.ToolStripTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btn_Menu_Usuario = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_Menu_Inventario = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_numFactura = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_codigo = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_codigo_producto = new System.Windows.Forms.TextBox();
            this.txt_cantidad = new System.Windows.Forms.TextBox();
            this.txt_impuesto_venta = new System.Windows.Forms.TextBox();
            this.txt_descuento = new System.Windows.Forms.TextBox();
            this.btn_AgregarProducto = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Cerrar
            // 
            this.btn_Cerrar.Location = new System.Drawing.Point(701, 436);
            this.btn_Cerrar.Name = "btn_Cerrar";
            this.btn_Cerrar.Size = new System.Drawing.Size(75, 23);
            this.btn_Cerrar.TabIndex = 0;
            this.btn_Cerrar.Text = "Cerrar";
            this.btn_Cerrar.UseVisualStyleBackColor = true;
            this.btn_Cerrar.Click += new System.EventHandler(this.btn_Cerrar_Click);
            // 
            // Archivo
            // 
            this.Archivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirFactura});
            this.Archivo.Name = "Archivo";
            this.Archivo.Size = new System.Drawing.Size(60, 20);
            this.Archivo.Text = "Archivo";
            // 
            // abrirFactura
            // 
            this.abrirFactura.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2});
            this.abrirFactura.Name = "abrirFactura";
            this.abrirFactura.Size = new System.Drawing.Size(198, 22);
            this.abrirFactura.Text = "Imp. Venta y Descuento";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txt_menu_imp_venta});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(130, 22);
            this.toolStripMenuItem1.Text = "Imp.Venta";
            // 
            // txt_menu_imp_venta
            // 
            this.txt_menu_imp_venta.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_menu_imp_venta.Name = "txt_menu_imp_venta";
            this.txt_menu_imp_venta.Size = new System.Drawing.Size(100, 23);
            this.txt_menu_imp_venta.Text = "9";
            this.txt_menu_imp_venta.TextChanged += new System.EventHandler(this.ImpVenta);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txt_menu_descuento});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(130, 22);
            this.toolStripMenuItem2.Text = "Descuento";
            // 
            // txt_menu_descuento
            // 
            this.txt_menu_descuento.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_menu_descuento.Name = "txt_menu_descuento";
            this.txt_menu_descuento.Size = new System.Drawing.Size(100, 23);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Archivo,
            this.btn_Menu_Usuario,
            this.btn_Menu_Inventario});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btn_Menu_Usuario
            // 
            this.btn_Menu_Usuario.Name = "btn_Menu_Usuario";
            this.btn_Menu_Usuario.Size = new System.Drawing.Size(64, 20);
            this.btn_Menu_Usuario.Text = "Usuarios";
            this.btn_Menu_Usuario.Click += new System.EventHandler(this.btn_Menu_Usuario_Click);
            // 
            // btn_Menu_Inventario
            // 
            this.btn_Menu_Inventario.Name = "btn_Menu_Inventario";
            this.btn_Menu_Inventario.Size = new System.Drawing.Size(72, 20);
            this.btn_Menu_Inventario.Text = "Inventario";
            this.btn_Menu_Inventario.Click += new System.EventHandler(this.btn_Menu_Inventario_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(171, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "N° Factura";
            // 
            // txt_numFactura
            // 
            this.txt_numFactura.Location = new System.Drawing.Point(235, 40);
            this.txt_numFactura.Name = "txt_numFactura";
            this.txt_numFactura.Size = new System.Drawing.Size(100, 20);
            this.txt_numFactura.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(174, 81);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(602, 209);
            this.dataGridView1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(440, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Cliente";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(485, 44);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(291, 20);
            this.textBox2.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Codigo Cliente";
            // 
            // txt_codigo
            // 
            this.txt_codigo.Location = new System.Drawing.Point(26, 123);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(100, 20);
            this.txt_codigo.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(26, 158);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(171, 315);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Sub Total";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(277, 315);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Imp Venta";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(277, 341);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Descuento";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(277, 371);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Total";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(440, 315);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Codigo de Producto";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(562, 315);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Cantidad";
            // 
            // txt_codigo_producto
            // 
            this.txt_codigo_producto.Location = new System.Drawing.Point(443, 334);
            this.txt_codigo_producto.Name = "txt_codigo_producto";
            this.txt_codigo_producto.Size = new System.Drawing.Size(100, 20);
            this.txt_codigo_producto.TabIndex = 16;
            // 
            // txt_cantidad
            // 
            this.txt_cantidad.Location = new System.Drawing.Point(565, 334);
            this.txt_cantidad.Name = "txt_cantidad";
            this.txt_cantidad.Size = new System.Drawing.Size(100, 20);
            this.txt_cantidad.TabIndex = 17;
            // 
            // txt_impuesto_venta
            // 
            this.txt_impuesto_venta.Location = new System.Drawing.Point(341, 315);
            this.txt_impuesto_venta.Name = "txt_impuesto_venta";
            this.txt_impuesto_venta.Size = new System.Drawing.Size(61, 20);
            this.txt_impuesto_venta.TabIndex = 18;
            // 
            // txt_descuento
            // 
            this.txt_descuento.Location = new System.Drawing.Point(341, 341);
            this.txt_descuento.Name = "txt_descuento";
            this.txt_descuento.Size = new System.Drawing.Size(61, 20);
            this.txt_descuento.TabIndex = 19;
            // 
            // btn_AgregarProducto
            // 
            this.btn_AgregarProducto.Location = new System.Drawing.Point(443, 371);
            this.btn_AgregarProducto.Name = "btn_AgregarProducto";
            this.btn_AgregarProducto.Size = new System.Drawing.Size(222, 47);
            this.btn_AgregarProducto.TabIndex = 20;
            this.btn_AgregarProducto.Text = "Agregar Producto";
            this.btn_AgregarProducto.UseVisualStyleBackColor = true;
            this.btn_AgregarProducto.Click += new System.EventHandler(this.btn_AgregarProducto_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(676, 315);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 103);
            this.button3.TabIndex = 21;
            this.button3.Text = "Facturar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // VentanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 471);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btn_AgregarProducto);
            this.Controls.Add(this.txt_descuento);
            this.Controls.Add(this.txt_impuesto_venta);
            this.Controls.Add(this.txt_cantidad);
            this.Controls.Add(this.txt_codigo_producto);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_codigo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txt_numFactura);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Cerrar);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "VentanaPrincipal";
            this.Text = "VentanaPrincipal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Cerrar;
        private System.Windows.Forms.ToolStripMenuItem Archivo;
        private System.Windows.Forms.ToolStripMenuItem abrirFactura;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btn_Menu_Usuario;
        private System.Windows.Forms.ToolStripMenuItem btn_Menu_Inventario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_numFactura;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_codigo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_codigo_producto;
        private System.Windows.Forms.TextBox txt_cantidad;
        private System.Windows.Forms.TextBox txt_impuesto_venta;
        private System.Windows.Forms.TextBox txt_descuento;
        private System.Windows.Forms.Button btn_AgregarProducto;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripTextBox txt_menu_imp_venta;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripTextBox txt_menu_descuento;
    }
}