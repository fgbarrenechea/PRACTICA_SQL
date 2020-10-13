using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql; //importar esta libreria para trabajar con Sql
using System.Data.SqlClient; //importar esta libreria para trabajar con Sql

namespace _26.BBDD_ANIDADAS
{
    public partial class Form_productos : Form
    {
        // CONEXION A LA BASE DE DATOS (patch / BBDD / seguridad)
        string conectar = @"data source=P528853\SQLEXPRESS; initial catalog= PEDIDOS; integrated security= SSPI";
        //DEFINIMOS LA VARIABLE DE SqlConnection
        SqlConnection mi_conexion;

        //  ******************* FORMULARIOS *******************

        public Form_productos()
        {
            InitializeComponent();
        }

        private void Form_productos_Load(object sender, EventArgs e)
        {
            //Prepara la conexion para abrirse, sacando la informacion de la variable conexion
            mi_conexion = new SqlConnection(conectar);
        }

        //  ******************* BOTONES *******************

        //CIERRA EL FORMULARIO
        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //INSERTA UN NUEVO PRODUCTO
        private void btn_crear_Click(object sender, EventArgs e)
        {
            if (txt_id_producto.Text == "")
            {

                //DECLARACION DE VARIABLES
                string descripcion = Convert.ToString(txt_descripcion.Text);
                string precio = Convert.ToString(txt_precio.Text);
                string ID_tipo = Convert.ToString(txt_id_tipo.Text);

                //VARIABLE DONDE ALMACENO LA INSTRUCCION SQL
                SqlCommand nvo_registro = new SqlCommand();
                //vARIABLE QUE MATCHEA LA CONEXION
                nvo_registro = mi_conexion.CreateCommand();
                //INSTRUCCION SQL
                nvo_registro.CommandText = "insert into Productos (descripcion, precio, id_tipo) values (@descripcion, @precio, @ID_tipo)";

                //VINCULACION DE PARAMETROS
                nvo_registro.Parameters.AddWithValue("@descripcion", descripcion);
                nvo_registro.Parameters.AddWithValue("@precio", precio);
                nvo_registro.Parameters.AddWithValue("@ID_tipo", ID_tipo);

                //ABRO LA CONEXION
                mi_conexion.Open();
                //EJECUTO LA QUERY
                nvo_registro.ExecuteNonQuery();
                //CIERRO LA CONEXION
                mi_conexion.Close();

                Limpiar();

                MessageBox.Show("Agrego un nuevo Producto"); //Mensaje de verificacion
            }
            else
            {
                MessageBox.Show("Por favor no complete el campo de ID PRODUCTO"); //Mensaje de verificacion
            }

        }

        //MUESTRA UN PRODUCTO
        private void btn_leer_Click(object sender, EventArgs e)
        {
            //DECLARACION DE LOS FORMULARIOS
            Form_Mostrar_tablas mostrar_tablas = new Form_Mostrar_tablas();
            //LLAMA AL FORMULARIO CLIENTES
            mostrar_tablas.Show();
        }

        //ACTUALIZA UN PRODUCTO
        private void btn_update_Click(object sender, EventArgs e)
        {
            //DECLARACION DE VARIABLES
            string ID_producto = Convert.ToString(txt_id_producto.Text);
            string descripcion = Convert.ToString(txt_descripcion.Text);
            string precio = Convert.ToString(txt_precio.Text);
            string ID_tipo = Convert.ToString(txt_id_tipo.Text);

            if (txt_id_producto.Text != "")
            {
                //VARIABLE DONDE ALMACENO LA INSTRUCCION SQL Y LA CONEXION
                SqlCommand actualizar = new SqlCommand("update Productos set descripcion=@descripcion, precio=@precio," +
                                                       " id_tipo=@ID_tipo where id_producto=@ID_producto", mi_conexion);
            
                //VINCULACION DE PARAMETROS
                actualizar.Parameters.AddWithValue("@ID_producto", ID_producto);
                actualizar.Parameters.AddWithValue("@descripcion", descripcion);
                actualizar.Parameters.AddWithValue("@precio", precio);
                actualizar.Parameters.AddWithValue("@ID_tipo", ID_tipo);

                //ABRO LA CONEXION
                mi_conexion.Open();
                //EJECUTO LA QUERY
                actualizar.ExecuteNonQuery();
                //CIERRO LA CONEXION
                mi_conexion.Close();

                Limpiar();

                MessageBox.Show("Se actualizó correctamente el registro"); //Mensaje de verificacion
            }
            else
            {
                MessageBox.Show("Por favor ingrese algun valor"); //Mensaje de verificacion
            }
        }

        //BORRA UN PRODUCTO
        private void btn_delete_Click(object sender, EventArgs e)
        {
            //DECLARACION DE VARIABLES
            string ID_producto = Convert.ToString(txt_id_producto.Text);

            if (txt_id_producto.Text != "")
            {
                //CREACION DE LA VARIABLE BORRAR
                SqlCommand borrar = new SqlCommand();

                //VARIABLE + CONEXION
                borrar = mi_conexion.CreateCommand();

                //VARIABLE DONDE ALMACENO LA INSTRUCCION
                borrar.CommandText = "delete from Productos where id_producto=@ID_producto";

                //VINCULACION DE PARAMETROS
                borrar.Parameters.AddWithValue("@ID_producto", ID_producto);

                //Abro la conexion
                mi_conexion.Open();
                //Ejecuta el comando
                borrar.ExecuteNonQuery();
                //Cierra la conexion
                mi_conexion.Close();

                MessageBox.Show("Borro el registro"); //Mensaja de verificacion
            }
            else
            {
                MessageBox.Show("Por favor ingrese un ID. \nSolo se borrara por ese valor."); //Mensaja de verificacion
            }
        }

        //  ******************* FUNCIONES *******************

        //FUNCION LIMPIAR
        void Limpiar()
        {
            txt_id_producto.Text = "";
            txt_descripcion.Text = "";
            txt_precio.Text = "";
            txt_id_tipo.Text = "";

        }

    }
}
