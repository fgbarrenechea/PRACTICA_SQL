namespace _26.BBDD_ANIDADAS
{
    partial class Form_Mostrar_tablas
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
            this.txt_campo = new System.Windows.Forms.TextBox();
            this.btn_buscar_por = new System.Windows.Forms.Button();
            this.btn_mostrar_todo = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.dgw_mostrar_todo = new System.Windows.Forms.DataGridView();
            this.cbx_campos_tablas = new System.Windows.Forms.ComboBox();
            this.cbx_seleccion_tablas = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_mostrar_todo)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_campo
            // 
            this.txt_campo.Location = new System.Drawing.Point(318, 84);
            this.txt_campo.Name = "txt_campo";
            this.txt_campo.Size = new System.Drawing.Size(232, 20);
            this.txt_campo.TabIndex = 23;
            // 
            // btn_buscar_por
            // 
            this.btn_buscar_por.Location = new System.Drawing.Point(14, 83);
            this.btn_buscar_por.Name = "btn_buscar_por";
            this.btn_buscar_por.Size = new System.Drawing.Size(123, 21);
            this.btn_buscar_por.TabIndex = 21;
            this.btn_buscar_por.Text = "BUSCAR POR";
            this.btn_buscar_por.UseVisualStyleBackColor = true;
            this.btn_buscar_por.Click += new System.EventHandler(this.btn_buscar_por_Click);
            // 
            // btn_mostrar_todo
            // 
            this.btn_mostrar_todo.Location = new System.Drawing.Point(675, 84);
            this.btn_mostrar_todo.Name = "btn_mostrar_todo";
            this.btn_mostrar_todo.Size = new System.Drawing.Size(110, 27);
            this.btn_mostrar_todo.TabIndex = 20;
            this.btn_mostrar_todo.Text = "MOSTRAR TODO";
            this.btn_mostrar_todo.UseVisualStyleBackColor = true;
            this.btn_mostrar_todo.Click += new System.EventHandler(this.btn_mostrar_todo_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(703, 377);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(82, 23);
            this.btn_salir.TabIndex = 19;
            this.btn_salir.Text = "SALIR";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.ForeColor = System.Drawing.Color.Purple;
            this.lbl_titulo.Location = new System.Drawing.Point(265, 9);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(244, 29);
            this.lbl_titulo.TabIndex = 18;
            this.lbl_titulo.Text = "MOSTRAR TABLAS";
            // 
            // dgw_mostrar_todo
            // 
            this.dgw_mostrar_todo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_mostrar_todo.Location = new System.Drawing.Point(14, 117);
            this.dgw_mostrar_todo.Name = "dgw_mostrar_todo";
            this.dgw_mostrar_todo.Size = new System.Drawing.Size(771, 254);
            this.dgw_mostrar_todo.TabIndex = 17;
            // 
            // cbx_campos_tablas
            // 
            this.cbx_campos_tablas.FormattingEnabled = true;
            this.cbx_campos_tablas.Location = new System.Drawing.Point(143, 83);
            this.cbx_campos_tablas.Name = "cbx_campos_tablas";
            this.cbx_campos_tablas.Size = new System.Drawing.Size(169, 21);
            this.cbx_campos_tablas.TabIndex = 26;
            // 
            // cbx_seleccion_tablas
            // 
            this.cbx_seleccion_tablas.FormattingEnabled = true;
            this.cbx_seleccion_tablas.Location = new System.Drawing.Point(14, 54);
            this.cbx_seleccion_tablas.Name = "cbx_seleccion_tablas";
            this.cbx_seleccion_tablas.Size = new System.Drawing.Size(771, 21);
            this.cbx_seleccion_tablas.TabIndex = 25;
            this.cbx_seleccion_tablas.SelectedIndexChanged += new System.EventHandler(this.cbx_seleccion_tablas_SelectedIndexChanged);
            // 
            // Form_Mostrar_tablas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(800, 403);
            this.Controls.Add(this.cbx_campos_tablas);
            this.Controls.Add(this.cbx_seleccion_tablas);
            this.Controls.Add(this.txt_campo);
            this.Controls.Add(this.btn_buscar_por);
            this.Controls.Add(this.btn_mostrar_todo);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.lbl_titulo);
            this.Controls.Add(this.dgw_mostrar_todo);
            this.ForeColor = System.Drawing.Color.Purple;
            this.Name = "Form_Mostrar_tablas";
            this.Text = "Mostrar";
            this.Load += new System.EventHandler(this.Form_Mostrar_tablas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgw_mostrar_todo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_campo;
        private System.Windows.Forms.Button btn_buscar_por;
        private System.Windows.Forms.Button btn_mostrar_todo;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.DataGridView dgw_mostrar_todo;
        private System.Windows.Forms.ComboBox cbx_campos_tablas;
        private System.Windows.Forms.ComboBox cbx_seleccion_tablas;
    }
}