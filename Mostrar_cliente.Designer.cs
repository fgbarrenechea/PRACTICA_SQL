namespace _26.BBDD_ANIDADAS
{
    partial class Mostrar_Cliente
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
            this.dgw_cliente = new System.Windows.Forms.DataGridView();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.btn_salir = new System.Windows.Forms.Button();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.btn_buscar_por = new System.Windows.Forms.Button();
            this.cbx_campos = new System.Windows.Forms.ComboBox();
            this.txt_campo = new System.Windows.Forms.TextBox();
            this.txt_tabla = new System.Windows.Forms.TextBox();
            this.cbx_tabla = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_cliente)).BeginInit();
            this.SuspendLayout();
            // 
            // dgw_cliente
            // 
            this.dgw_cliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_cliente.Location = new System.Drawing.Point(12, 133);
            this.dgw_cliente.Name = "dgw_cliente";
            this.dgw_cliente.Size = new System.Drawing.Size(771, 254);
            this.dgw_cliente.TabIndex = 0;
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.ForeColor = System.Drawing.Color.Purple;
            this.lbl_titulo.Location = new System.Drawing.Point(263, 25);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(256, 29);
            this.lbl_titulo.TabIndex = 9;
            this.lbl_titulo.Text = "MOSTRAR CLIENTE";
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(701, 393);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(82, 23);
            this.btn_salir.TabIndex = 10;
            this.btn_salir.Text = "SALIR";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(686, 72);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(97, 55);
            this.btn_buscar.TabIndex = 11;
            this.btn_buscar.Text = "MOSTRAR TODO";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // btn_buscar_por
            // 
            this.btn_buscar_por.Location = new System.Drawing.Point(12, 72);
            this.btn_buscar_por.Name = "btn_buscar_por";
            this.btn_buscar_por.Size = new System.Drawing.Size(83, 48);
            this.btn_buscar_por.TabIndex = 12;
            this.btn_buscar_por.Text = "BUSCAR POR";
            this.btn_buscar_por.UseVisualStyleBackColor = true;
            this.btn_buscar_por.Click += new System.EventHandler(this.btn_buscar_por_Click);
            // 
            // cbx_campos
            // 
            this.cbx_campos.FormattingEnabled = true;
            this.cbx_campos.Items.AddRange(new object[] {
            "ID",
            "NOMBRE",
            "APELLIDO",
            "DIRECCION",
            "PROVINCIA",
            "FECHA DE REGISTRACION"});
            this.cbx_campos.Location = new System.Drawing.Point(101, 99);
            this.cbx_campos.Name = "cbx_campos";
            this.cbx_campos.Size = new System.Drawing.Size(169, 21);
            this.cbx_campos.TabIndex = 13;
            // 
            // txt_campo
            // 
            this.txt_campo.Location = new System.Drawing.Point(276, 100);
            this.txt_campo.Name = "txt_campo";
            this.txt_campo.Size = new System.Drawing.Size(232, 20);
            this.txt_campo.TabIndex = 14;
            this.txt_campo.Text = "Ingrese el texto a buscar";
            // 
            // txt_tabla
            // 
            this.txt_tabla.Location = new System.Drawing.Point(276, 76);
            this.txt_tabla.Name = "txt_tabla";
            this.txt_tabla.Size = new System.Drawing.Size(232, 20);
            this.txt_tabla.TabIndex = 16;
            this.txt_tabla.Text = "Ingrese el texto a buscar";
            // 
            // cbx_tabla
            // 
            this.cbx_tabla.AutoCompleteCustomSource.AddRange(new string[] {
            "CLIENTES",
            "PRODUCTOS",
            "TIPO DE PRODUCTO",
            "VENTAS"});
            this.cbx_tabla.FormattingEnabled = true;
            this.cbx_tabla.Items.AddRange(new object[] {
            "ID",
            "NOMBRE",
            "APELLIDO",
            "DIRECCION",
            "PROVINCIA",
            "FECHA DE REGISTRACION"});
            this.cbx_tabla.Location = new System.Drawing.Point(101, 75);
            this.cbx_tabla.Name = "cbx_tabla";
            this.cbx_tabla.Size = new System.Drawing.Size(169, 21);
            this.cbx_tabla.TabIndex = 15;
            // 
            // Mostrar_Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(795, 415);
            this.Controls.Add(this.txt_tabla);
            this.Controls.Add(this.cbx_tabla);
            this.Controls.Add(this.txt_campo);
            this.Controls.Add(this.cbx_campos);
            this.Controls.Add(this.btn_buscar_por);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.lbl_titulo);
            this.Controls.Add(this.dgw_cliente);
            this.ForeColor = System.Drawing.Color.Purple;
            this.Name = "Mostrar_Cliente";
            this.Text = "Mostrar_Cliente";
            this.Load += new System.EventHandler(this.Mostrar_Cliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgw_cliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgw_cliente;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Button btn_buscar_por;
        private System.Windows.Forms.ComboBox cbx_campos;
        private System.Windows.Forms.TextBox txt_campo;
        private System.Windows.Forms.TextBox txt_tabla;
        private System.Windows.Forms.ComboBox cbx_tabla;
    }
}