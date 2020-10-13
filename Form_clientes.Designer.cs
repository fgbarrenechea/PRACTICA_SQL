namespace _26.BBDD_ANIDADAS
{
    partial class Form_clientes
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
            this.lbl_id = new System.Windows.Forms.Label();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.txt_apellido = new System.Windows.Forms.TextBox();
            this.lbl_apellido = new System.Windows.Forms.Label();
            this.txt_direccion = new System.Windows.Forms.TextBox();
            this.lbl_direccion = new System.Windows.Forms.Label();
            this.txt_provincia = new System.Windows.Forms.TextBox();
            this.lbl_provincia = new System.Windows.Forms.Label();
            this.txt_registro = new System.Windows.Forms.TextBox();
            this.lbl_registro = new System.Windows.Forms.Label();
            this.btn_leer = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_crear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.ForeColor = System.Drawing.Color.Purple;
            this.lbl_titulo.Location = new System.Drawing.Point(100, 20);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(139, 29);
            this.lbl_titulo.TabIndex = 2;
            this.lbl_titulo.Text = "CLIENTES";
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(240, 273);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(82, 23);
            this.btn_salir.TabIndex = 7;
            this.btn_salir.Text = "SALIR";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_id.Location = new System.Drawing.Point(16, 75);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(63, 13);
            this.lbl_id.TabIndex = 8;
            this.lbl_id.Text = "ID Cliente";
            this.lbl_id.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txt_ID
            // 
            this.txt_ID.Location = new System.Drawing.Point(84, 72);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(248, 20);
            this.txt_ID.TabIndex = 9;
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(84, 99);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(248, 20);
            this.txt_nombre.TabIndex = 11;
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombre.Location = new System.Drawing.Point(29, 102);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(50, 13);
            this.lbl_nombre.TabIndex = 10;
            this.lbl_nombre.Text = "Nombre";
            this.lbl_nombre.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txt_apellido
            // 
            this.txt_apellido.Location = new System.Drawing.Point(84, 126);
            this.txt_apellido.Name = "txt_apellido";
            this.txt_apellido.Size = new System.Drawing.Size(248, 20);
            this.txt_apellido.TabIndex = 13;
            // 
            // lbl_apellido
            // 
            this.lbl_apellido.AutoSize = true;
            this.lbl_apellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_apellido.Location = new System.Drawing.Point(27, 129);
            this.lbl_apellido.Name = "lbl_apellido";
            this.lbl_apellido.Size = new System.Drawing.Size(52, 13);
            this.lbl_apellido.TabIndex = 12;
            this.lbl_apellido.Text = "Apellido";
            this.lbl_apellido.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txt_direccion
            // 
            this.txt_direccion.Location = new System.Drawing.Point(84, 153);
            this.txt_direccion.Name = "txt_direccion";
            this.txt_direccion.Size = new System.Drawing.Size(248, 20);
            this.txt_direccion.TabIndex = 15;
            // 
            // lbl_direccion
            // 
            this.lbl_direccion.AutoSize = true;
            this.lbl_direccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_direccion.Location = new System.Drawing.Point(18, 156);
            this.lbl_direccion.Name = "lbl_direccion";
            this.lbl_direccion.Size = new System.Drawing.Size(61, 13);
            this.lbl_direccion.TabIndex = 14;
            this.lbl_direccion.Text = "Direccion";
            this.lbl_direccion.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txt_provincia
            // 
            this.txt_provincia.Location = new System.Drawing.Point(84, 180);
            this.txt_provincia.Name = "txt_provincia";
            this.txt_provincia.Size = new System.Drawing.Size(248, 20);
            this.txt_provincia.TabIndex = 17;
            // 
            // lbl_provincia
            // 
            this.lbl_provincia.AutoSize = true;
            this.lbl_provincia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_provincia.Location = new System.Drawing.Point(19, 183);
            this.lbl_provincia.Name = "lbl_provincia";
            this.lbl_provincia.Size = new System.Drawing.Size(60, 13);
            this.lbl_provincia.TabIndex = 16;
            this.lbl_provincia.Text = "Provincia";
            this.lbl_provincia.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txt_registro
            // 
            this.txt_registro.Location = new System.Drawing.Point(84, 207);
            this.txt_registro.Name = "txt_registro";
            this.txt_registro.Size = new System.Drawing.Size(248, 20);
            this.txt_registro.TabIndex = 19;
            // 
            // lbl_registro
            // 
            this.lbl_registro.AutoSize = true;
            this.lbl_registro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_registro.Location = new System.Drawing.Point(25, 210);
            this.lbl_registro.Name = "lbl_registro";
            this.lbl_registro.Size = new System.Drawing.Size(54, 13);
            this.lbl_registro.TabIndex = 18;
            this.lbl_registro.Text = "Registro";
            this.lbl_registro.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btn_leer
            // 
            this.btn_leer.Location = new System.Drawing.Point(86, 233);
            this.btn_leer.Name = "btn_leer";
            this.btn_leer.Size = new System.Drawing.Size(82, 23);
            this.btn_leer.TabIndex = 20;
            this.btn_leer.Text = "LEER";
            this.btn_leer.UseVisualStyleBackColor = true;
            this.btn_leer.Click += new System.EventHandler(this.btn_leer_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(168, 233);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(82, 23);
            this.btn_update.TabIndex = 21;
            this.btn_update.Text = "ACTUALIZAR";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(250, 233);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(82, 23);
            this.btn_delete.TabIndex = 22;
            this.btn_delete.Text = "BORRAR";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_crear
            // 
            this.btn_crear.Location = new System.Drawing.Point(4, 233);
            this.btn_crear.Name = "btn_crear";
            this.btn_crear.Size = new System.Drawing.Size(82, 23);
            this.btn_crear.TabIndex = 23;
            this.btn_crear.Text = "CREAR";
            this.btn_crear.UseVisualStyleBackColor = true;
            this.btn_crear.Click += new System.EventHandler(this.btn_crear_Click);
            // 
            // Form_clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(342, 309);
            this.Controls.Add(this.btn_crear);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_leer);
            this.Controls.Add(this.txt_registro);
            this.Controls.Add(this.lbl_registro);
            this.Controls.Add(this.txt_provincia);
            this.Controls.Add(this.lbl_provincia);
            this.Controls.Add(this.txt_direccion);
            this.Controls.Add(this.lbl_direccion);
            this.Controls.Add(this.txt_apellido);
            this.Controls.Add(this.lbl_apellido);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.lbl_nombre);
            this.Controls.Add(this.txt_ID);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.lbl_titulo);
            this.ForeColor = System.Drawing.Color.Purple;
            this.Name = "Form_clientes";
            this.Text = "Form_clientes";
            this.Load += new System.EventHandler(this.Form_clientes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.TextBox txt_apellido;
        private System.Windows.Forms.Label lbl_apellido;
        private System.Windows.Forms.TextBox txt_direccion;
        private System.Windows.Forms.Label lbl_direccion;
        private System.Windows.Forms.TextBox txt_provincia;
        private System.Windows.Forms.Label lbl_provincia;
        private System.Windows.Forms.TextBox txt_registro;
        private System.Windows.Forms.Label lbl_registro;
        private System.Windows.Forms.Button btn_leer;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_crear;
    }
}