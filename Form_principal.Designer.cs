namespace _26.BBDD_ANIDADAS
{
    partial class form_principal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_cliente = new System.Windows.Forms.Button();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.btn_ventas = new System.Windows.Forms.Button();
            this.btn_tipo_productos = new System.Windows.Forms.Button();
            this.btn_productos = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.btn_tablas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_cliente
            // 
            this.btn_cliente.Location = new System.Drawing.Point(12, 63);
            this.btn_cliente.Name = "btn_cliente";
            this.btn_cliente.Size = new System.Drawing.Size(219, 23);
            this.btn_cliente.TabIndex = 0;
            this.btn_cliente.Text = "CLIENTES";
            this.btn_cliente.UseVisualStyleBackColor = true;
            this.btn_cliente.Click += new System.EventHandler(this.btn_cliente_Click);
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.ForeColor = System.Drawing.Color.Purple;
            this.lbl_titulo.Location = new System.Drawing.Point(6, 16);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(228, 29);
            this.lbl_titulo.TabIndex = 1;
            this.lbl_titulo.Text = "MENU PRINCIPAL";
            // 
            // btn_ventas
            // 
            this.btn_ventas.Location = new System.Drawing.Point(12, 150);
            this.btn_ventas.Name = "btn_ventas";
            this.btn_ventas.Size = new System.Drawing.Size(219, 23);
            this.btn_ventas.TabIndex = 2;
            this.btn_ventas.Text = "VENTAS";
            this.btn_ventas.UseVisualStyleBackColor = true;
            this.btn_ventas.Click += new System.EventHandler(this.btn_ventas_Click);
            // 
            // btn_tipo_productos
            // 
            this.btn_tipo_productos.Location = new System.Drawing.Point(12, 121);
            this.btn_tipo_productos.Name = "btn_tipo_productos";
            this.btn_tipo_productos.Size = new System.Drawing.Size(219, 23);
            this.btn_tipo_productos.TabIndex = 3;
            this.btn_tipo_productos.Text = "TIPO DE PRODUCTOS";
            this.btn_tipo_productos.UseVisualStyleBackColor = true;
            this.btn_tipo_productos.Click += new System.EventHandler(this.btn_tipo_productos_Click);
            // 
            // btn_productos
            // 
            this.btn_productos.Location = new System.Drawing.Point(12, 92);
            this.btn_productos.Name = "btn_productos";
            this.btn_productos.Size = new System.Drawing.Size(219, 23);
            this.btn_productos.TabIndex = 4;
            this.btn_productos.Text = "PRODUCTOS";
            this.btn_productos.UseVisualStyleBackColor = true;
            this.btn_productos.Click += new System.EventHandler(this.btn_productos_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(152, 224);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(82, 23);
            this.btn_salir.TabIndex = 5;
            this.btn_salir.Text = "SALIR";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // btn_tablas
            // 
            this.btn_tablas.Location = new System.Drawing.Point(11, 179);
            this.btn_tablas.Name = "btn_tablas";
            this.btn_tablas.Size = new System.Drawing.Size(219, 23);
            this.btn_tablas.TabIndex = 6;
            this.btn_tablas.Text = "VER TODOS LOS REGISTROS";
            this.btn_tablas.UseVisualStyleBackColor = true;
            this.btn_tablas.Click += new System.EventHandler(this.btn_tablas_Click);
            // 
            // form_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(240, 250);
            this.Controls.Add(this.btn_tablas);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_productos);
            this.Controls.Add(this.btn_tipo_productos);
            this.Controls.Add(this.btn_ventas);
            this.Controls.Add(this.lbl_titulo);
            this.Controls.Add(this.btn_cliente);
            this.ForeColor = System.Drawing.Color.Purple;
            this.Name = "form_principal";
            this.Text = "PEDIDOS 1.0";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_cliente;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Button btn_ventas;
        private System.Windows.Forms.Button btn_tipo_productos;
        private System.Windows.Forms.Button btn_productos;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Button btn_tablas;
    }
}

