using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _26.BBDD_ANIDADAS
{
    public partial class form_principal : Form
    {
       
        public form_principal()
        {
            InitializeComponent();
        }

        //NOTON MUESTRA CLIENTES
        private void btn_cliente_Click(object sender, EventArgs e)
        {
            //DECLARACION DE LOS FORMULARIOS
            Form_clientes cliente = new Form_clientes();
            //LLAMA AL FORMULARIO CLIENTES
            cliente.Show();
        }

        //NOTON MUESTRA PRODCUTOS
        private void btn_productos_Click(object sender, EventArgs e)
        {
            //DECLARACION DE LOS FORMULARIOS
            Form_productos producto = new Form_productos();
            //LLAMA AL FORMULARIO PRODUCTOS
            producto.Show();

        }

        //NOTON MUESTRA TIPO PRODUCTOS
        private void btn_tipo_productos_Click(object sender, EventArgs e)
        {
            //DECLARACION DE LOS FORMULARIOS
            Form_tipo_producto tipo = new Form_tipo_producto();
            //LLAMA AL FORMULARIO TIPO DE PRODUCTOS
            tipo.Show();

        }

        //NOTON MUESTRA VENTAS
        private void btn_ventas_Click(object sender, EventArgs e)
        {
            //DECLARACION DE LOS FORMULARIOS
             Form_ventas ventas = new Form_ventas();
            //LLAMA AL FORMULARIO VENTAS
            ventas.Show();

        }

        //NOTON MUESTRA CERRAR
        private void btn_salir_Click(object sender, EventArgs e)
        {
            //CIERRA EL FORMUALRIO
            this.Close();
        }

       /* private void button1_Click(object sender, EventArgs e)
        {
            //DECLARACION DE LOS FORMULARIOS
            Form_Mostrar_tablas mostrar = new Form_Mostrar_tablas();
            //LLAMA AL FORMULARIO CLIENTES
            mostrar.Show();
        }*/

        //NOTON MUESTRA LAS TABLAS COMPLETAS
        private void btn_tablas_Click(object sender, EventArgs e)
        {
            //DECLARACION DE LOS FORMULARIOS
            Form_Mostrar_tablas mostrar_tablas = new Form_Mostrar_tablas();
            //LLAMA AL FORMULARIO CLIENTES
            mostrar_tablas.Show();
        }
    }
}
