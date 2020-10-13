namespace _26.BBDD_ANIDADAS
{
    partial class Form_ventas
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
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.btn_salir = new System.Windows.Forms.Button();
            this.btn_crear = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_leer = new System.Windows.Forms.Button();
            this.txt_cantidad = new System.Windows.Forms.TextBox();
            this.lbl_Cantidad = new System.Windows.Forms.Label();
            this.txt_ID_cliente = new System.Windows.Forms.TextBox();
            this.lbl_ID_cliente = new System.Windows.Forms.Label();
            this.txt_producto = new System.Windows.Forms.TextBox();
            this.lbl_producto = new System.Windows.Forms.Label();
            this.txt_fecha = new System.Windows.Forms.TextBox();
            this.lbl_fecha = new System.Windows.Forms.Label();
            this.txt_id_ventas = new System.Windows.Forms.TextBox();
            this.lbl_id_ventas = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.ForeColor = System.Drawing.Color.Purple;
            this.lbl_titulo.Location = new System.Drawing.Point(99, 9);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(115, 29);
            this.lbl_titulo.TabIndex = 3;
            this.lbl_titulo.Text = "VENTAS";
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(248, 234);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(82, 23);
            this.btn_salir.TabIndex = 11;
            this.btn_salir.Text = "SALIR";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // btn_crear
            // 
            this.btn_crear.Location = new System.Drawing.Point(2, 189);
            this.btn_crear.Name = "btn_crear";
            this.btn_crear.Size = new System.Drawing.Size(82, 23);
            this.btn_crear.TabIndex = 27;
            this.btn_crear.Text = "CREAR";
            this.btn_crear.UseVisualStyleBackColor = true;
            this.btn_crear.Click += new System.EventHandler(this.btn_crear_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(248, 189);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(82, 23);
            this.btn_delete.TabIndex = 26;
            this.btn_delete.Text = "BORRAR";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(166, 189);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(82, 23);
            this.btn_update.TabIndex = 25;
            this.btn_update.Text = "ACTUALIZAR";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_leer
            // 
            this.btn_leer.Location = new System.Drawing.Point(84, 189);
            this.btn_leer.Name = "btn_leer";
            this.btn_leer.Size = new System.Drawing.Size(82, 23);
            this.btn_leer.TabIndex = 24;
            this.btn_leer.Text = "LEER";
            this.btn_leer.UseVisualStyleBackColor = true;
            this.btn_leer.Click += new System.EventHandler(this.btn_leer_Click);
            // 
            // txt_cantidad
            // 
            this.txt_cantidad.Location = new System.Drawing.Point(80, 154);
            this.txt_cantidad.Name = "txt_cantidad";
            this.txt_cantidad.Size = new System.Drawing.Size(248, 20);
            this.txt_cantidad.TabIndex = 37;
            // 
            // lbl_Cantidad
            // 
            this.lbl_Cantidad.AutoSize = true;
            this.lbl_Cantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Cantidad.Location = new System.Drawing.Point(20, 157);
            this.lbl_Cantidad.Name = "lbl_Cantidad";
            this.lbl_Cantidad.Size = new System.Drawing.Size(57, 13);
            this.lbl_Cantidad.TabIndex = 36;
            this.lbl_Cantidad.Text = "Cantidad";
            this.lbl_Cantidad.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txt_ID_cliente
            // 
            this.txt_ID_cliente.Location = new System.Drawing.Point(80, 127);
            this.txt_ID_cliente.Name = "txt_ID_cliente";
            this.txt_ID_cliente.Size = new System.Drawing.Size(248, 20);
            this.txt_ID_cliente.TabIndex = 35;
            // 
            // lbl_ID_cliente
            // 
            this.lbl_ID_cliente.AutoSize = true;
            this.lbl_ID_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ID_cliente.Location = new System.Drawing.Point(14, 130);
            this.lbl_ID_cliente.Name = "lbl_ID_cliente";
            this.lbl_ID_cliente.Size = new System.Drawing.Size(63, 13);
            this.lbl_ID_cliente.TabIndex = 34;
            this.lbl_ID_cliente.Text = "ID Cliente";
            this.lbl_ID_cliente.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txt_producto
            // 
            this.txt_producto.AcceptsTab = true;
            this.txt_producto.Location = new System.Drawing.Point(80, 100);
            this.txt_producto.Name = "txt_producto";
            this.txt_producto.Size = new System.Drawing.Size(248, 20);
            this.txt_producto.TabIndex = 33;
            // 
            // lbl_producto
            // 
            this.lbl_producto.AutoSize = true;
            this.lbl_producto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_producto.Location = new System.Drawing.Point(2, 103);
            this.lbl_producto.Name = "lbl_producto";
            this.lbl_producto.Size = new System.Drawing.Size(75, 13);
            this.lbl_producto.TabIndex = 32;
            this.lbl_producto.Text = "ID Producto";
            this.lbl_producto.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txt_fecha
            // 
            this.txt_fecha.Location = new System.Drawing.Point(80, 73);
            this.txt_fecha.Name = "txt_fecha";
            this.txt_fecha.Size = new System.Drawing.Size(248, 20);
            this.txt_fecha.TabIndex = 31;
            // 
            // lbl_fecha
            // 
            this.lbl_fecha.AutoSize = true;
            this.lbl_fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fecha.Location = new System.Drawing.Point(35, 76);
            this.lbl_fecha.Name = "lbl_fecha";
            this.lbl_fecha.Size = new System.Drawing.Size(42, 13);
            this.lbl_fecha.TabIndex = 30;
            this.lbl_fecha.Text = "Fecha";
            this.lbl_fecha.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txt_id_ventas
            // 
            this.txt_id_ventas.Location = new System.Drawing.Point(80, 46);
            this.txt_id_ventas.Name = "txt_id_ventas";
            this.txt_id_ventas.Size = new System.Drawing.Size(248, 20);
            this.txt_id_ventas.TabIndex = 29;
            // 
            // lbl_id_ventas
            // 
            this.lbl_id_ventas.AutoSize = true;
            this.lbl_id_ventas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_id_ventas.Location = new System.Drawing.Point(14, 49);
            this.lbl_id_ventas.Name = "lbl_id_ventas";
            this.lbl_id_ventas.Size = new System.Drawing.Size(63, 13);
            this.lbl_id_ventas.TabIndex = 28;
            this.lbl_id_ventas.Text = "ID Ventas";
            this.lbl_id_ventas.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Form_ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(332, 259);
            this.Controls.Add(this.txt_cantidad);
            this.Controls.Add(this.lbl_Cantidad);
            this.Controls.Add(this.txt_ID_cliente);
            this.Controls.Add(this.lbl_ID_cliente);
            this.Controls.Add(this.txt_producto);
            this.Controls.Add(this.lbl_producto);
            this.Controls.Add(this.txt_fecha);
            this.Controls.Add(this.lbl_fecha);
            this.Controls.Add(this.txt_id_ventas);
            this.Controls.Add(this.lbl_id_ventas);
            this.Controls.Add(this.btn_crear);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_leer);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.lbl_titulo);
            this.ForeColor = System.Drawing.Color.Purple;
            this.Name = "Form_ventas";
            this.Text = "Form_ventas";
            this.Load += new System.EventHandler(this.Form_ventas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Button btn_crear;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_leer;
        private System.Windows.Forms.TextBox txt_cantidad;
        private System.Windows.Forms.Label lbl_Cantidad;
        private System.Windows.Forms.TextBox txt_ID_cliente;
        private System.Windows.Forms.Label lbl_ID_cliente;
        private System.Windows.Forms.TextBox txt_producto;
        private System.Windows.Forms.Label lbl_producto;
        private System.Windows.Forms.TextBox txt_fecha;
        private System.Windows.Forms.Label lbl_fecha;
        private System.Windows.Forms.TextBox txt_id_ventas;
        private System.Windows.Forms.Label lbl_id_ventas;
    }
}