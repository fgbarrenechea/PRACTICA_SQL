namespace _26.BBDD_ANIDADAS
{
    partial class Form_productos
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
            this.btn_salir = new System.Windows.Forms.Button();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.btn_crear = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_leer = new System.Windows.Forms.Button();
            this.txt_id_tipo = new System.Windows.Forms.TextBox();
            this.lbl_id_tipo = new System.Windows.Forms.Label();
            this.txt_precio = new System.Windows.Forms.TextBox();
            this.lbl_precio = new System.Windows.Forms.Label();
            this.txt_descripcion = new System.Windows.Forms.TextBox();
            this.lbl_descripcion = new System.Windows.Forms.Label();
            this.txt_id_producto = new System.Windows.Forms.TextBox();
            this.lbl_id_producto = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(258, 203);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(82, 23);
            this.btn_salir.TabIndex = 10;
            this.btn_salir.Text = "SALIR";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.ForeColor = System.Drawing.Color.Purple;
            this.lbl_titulo.Location = new System.Drawing.Point(123, 11);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(176, 29);
            this.lbl_titulo.TabIndex = 8;
            this.lbl_titulo.Text = "PRODUCTOS";
            // 
            // btn_crear
            // 
            this.btn_crear.Location = new System.Drawing.Point(12, 174);
            this.btn_crear.Name = "btn_crear";
            this.btn_crear.Size = new System.Drawing.Size(82, 23);
            this.btn_crear.TabIndex = 27;
            this.btn_crear.Text = "CREAR";
            this.btn_crear.UseVisualStyleBackColor = true;
            this.btn_crear.Click += new System.EventHandler(this.btn_crear_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(258, 174);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(82, 23);
            this.btn_delete.TabIndex = 26;
            this.btn_delete.Text = "BORRAR";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(176, 174);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(82, 23);
            this.btn_update.TabIndex = 25;
            this.btn_update.Text = "ACTUALIZAR";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_leer
            // 
            this.btn_leer.Location = new System.Drawing.Point(94, 174);
            this.btn_leer.Name = "btn_leer";
            this.btn_leer.Size = new System.Drawing.Size(82, 23);
            this.btn_leer.TabIndex = 24;
            this.btn_leer.Text = "LEER";
            this.btn_leer.UseVisualStyleBackColor = true;
            this.btn_leer.Click += new System.EventHandler(this.btn_leer_Click);
            // 
            // txt_id_tipo
            // 
            this.txt_id_tipo.Location = new System.Drawing.Point(90, 134);
            this.txt_id_tipo.Name = "txt_id_tipo";
            this.txt_id_tipo.Size = new System.Drawing.Size(248, 20);
            this.txt_id_tipo.TabIndex = 35;
            // 
            // lbl_id_tipo
            // 
            this.lbl_id_tipo.AutoSize = true;
            this.lbl_id_tipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_id_tipo.Location = new System.Drawing.Point(38, 137);
            this.lbl_id_tipo.Name = "lbl_id_tipo";
            this.lbl_id_tipo.Size = new System.Drawing.Size(49, 13);
            this.lbl_id_tipo.TabIndex = 34;
            this.lbl_id_tipo.Text = "ID Tipo";
            this.lbl_id_tipo.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txt_precio
            // 
            this.txt_precio.Location = new System.Drawing.Point(90, 107);
            this.txt_precio.Name = "txt_precio";
            this.txt_precio.Size = new System.Drawing.Size(248, 20);
            this.txt_precio.TabIndex = 33;
            // 
            // lbl_precio
            // 
            this.lbl_precio.AutoSize = true;
            this.lbl_precio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_precio.Location = new System.Drawing.Point(44, 110);
            this.lbl_precio.Name = "lbl_precio";
            this.lbl_precio.Size = new System.Drawing.Size(43, 13);
            this.lbl_precio.TabIndex = 32;
            this.lbl_precio.Text = "Precio";
            this.lbl_precio.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.Location = new System.Drawing.Point(90, 80);
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.Size = new System.Drawing.Size(248, 20);
            this.txt_descripcion.TabIndex = 31;
            // 
            // lbl_descripcion
            // 
            this.lbl_descripcion.AutoSize = true;
            this.lbl_descripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_descripcion.Location = new System.Drawing.Point(13, 83);
            this.lbl_descripcion.Name = "lbl_descripcion";
            this.lbl_descripcion.Size = new System.Drawing.Size(74, 13);
            this.lbl_descripcion.TabIndex = 30;
            this.lbl_descripcion.Text = "Descripción";
            this.lbl_descripcion.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txt_id_producto
            // 
            this.txt_id_producto.Location = new System.Drawing.Point(90, 53);
            this.txt_id_producto.Name = "txt_id_producto";
            this.txt_id_producto.Size = new System.Drawing.Size(248, 20);
            this.txt_id_producto.TabIndex = 29;
            // 
            // lbl_id_producto
            // 
            this.lbl_id_producto.AutoSize = true;
            this.lbl_id_producto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_id_producto.Location = new System.Drawing.Point(12, 56);
            this.lbl_id_producto.Name = "lbl_id_producto";
            this.lbl_id_producto.Size = new System.Drawing.Size(75, 13);
            this.lbl_id_producto.TabIndex = 28;
            this.lbl_id_producto.Text = "ID Producto";
            this.lbl_id_producto.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Form_productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(346, 230);
            this.Controls.Add(this.txt_id_tipo);
            this.Controls.Add(this.lbl_id_tipo);
            this.Controls.Add(this.txt_precio);
            this.Controls.Add(this.lbl_precio);
            this.Controls.Add(this.txt_descripcion);
            this.Controls.Add(this.lbl_descripcion);
            this.Controls.Add(this.txt_id_producto);
            this.Controls.Add(this.lbl_id_producto);
            this.Controls.Add(this.btn_crear);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_leer);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.lbl_titulo);
            this.ForeColor = System.Drawing.Color.Purple;
            this.Name = "Form_productos";
            this.Text = "Form_Productos";
            this.Load += new System.EventHandler(this.Form_productos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Button btn_crear;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_leer;
        private System.Windows.Forms.TextBox txt_id_tipo;
        private System.Windows.Forms.Label lbl_id_tipo;
        private System.Windows.Forms.TextBox txt_precio;
        private System.Windows.Forms.Label lbl_precio;
        private System.Windows.Forms.TextBox txt_descripcion;
        private System.Windows.Forms.Label lbl_descripcion;
        private System.Windows.Forms.TextBox txt_id_producto;
        private System.Windows.Forms.Label lbl_id_producto;
    }
}