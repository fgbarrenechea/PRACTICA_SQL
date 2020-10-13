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
    public partial class Form_tipo_producto : Form
    {
        // CONEXION A LA BASE DE DATOS (patch / BBDD / seguridad)
        string conectar = @"data source=P528853\SQLEXPRESS; initial catalog= PEDIDOS; integrated security= SSPI";
        //DEFINIMOS LA VARIABLE DE SqlConnection
        SqlConnection mi_conexion;

        //  ******************* FORMULARIOS *******************

        public Form_tipo_producto()
        {
            InitializeComponent();
        }

        private void Form_tipo_producto_Load(object sender, EventArgs e)
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

        //INSERTA UN NUEVO TIPO DE PRODUCTO
        private void btn_crear_Click(object sender, EventArgs e)
        {
            if (txt_id_tipo_producto.Text == "")
            {

                //DECLARACION DE VARIABLES
                string descripcion = Convert.ToString(txt_descripcion.Text);
                
                //VARIABLE DONDE ALMACENO LA INSTRUCCION SQL
                SqlCommand nvo_registro = new SqlCommand();
                //vARIABLE QUE MATCHEA LA CONEXION
                nvo_registro = mi_conexion.CreateCommand();
                //INSTRUCCION SQL
                nvo_registro.CommandText = "insert into Tipo_Producto (descripcion) values (@descripcion)";

                //VINCULACION DE PARAMETROS
                nvo_registro.Parameters.AddWithValue("@descripcion", descripcion);

                //ABRO LA CONEXION
                mi_conexion.Open();
                //EJECUTO LA QUERY
                nvo_registro.ExecuteNonQuery();
                //CIERRO LA CONEXION
                mi_conexion.Close();

                txt_id_tipo_producto.Text = "";
                txt_descripcion.Text = "";

                MessageBox.Show("Agrego un nuevo Tipo de Producto"); //Mensaje de verificacion
            }
            else
            {
                MessageBox.Show("Por favor no complete el campo de ID TIPO PRODUCTO"); //Mensaje de verificacion
            }

        }

        //MUESTRA UN TIPO DE PRODUCTO
        private void btn_leer_Click(object sender, EventArgs e)
        {
            //DECLARACION DE LOS FORMULARIOS
            Form_Mostrar_tablas mostrar_tablas = new Form_Mostrar_tablas();
            //LLAMA AL FORMULARIO CLIENTES
            mostrar_tablas.Show();
        }

        //ACTUALIZA UN TIPO DE PRODUCTO
        private void btn_update_Click(object sender, EventArgs e)
        {

            //DECLARACION DE VARIABLES
            string ID_tipo_producto = Convert.ToString(txt_id_tipo_producto.Text);
            string descripcion = Convert.ToString(txt_descripcion.Text);

            if (txt_id_tipo_producto.Text != "")
            {
                //VARIABLE DONDE ALMACENO LA INSTRUCCION SQL Y LA CONEXION
                SqlCommand actualizar = new SqlCommand("update Tipo_Producto set descripcion=@descripcion where id_tipo=@ID", mi_conexion);

                //VINCULACION DE PARAMETROS
                actualizar.Parameters.AddWithValue("@descripcion", descripcion);
                actualizar.Parameters.AddWithValue("@ID", ID_tipo_producto);


                //ABRO LA CONEXION
                mi_conexion.Open();
                //EJECUTO LA QUERY
                actualizar.ExecuteNonQuery();
                //CIERRO LA CONEXION
                mi_conexion.Close();

                txt_id_tipo_producto.Text = "";
                txt_descripcion.Text = "";

                MessageBox.Show("Se actualizó correctamente el registro"); //Mensaje de verificacion
            }
            else
            {
                MessageBox.Show("Por favor ingrese algun valor"); //Mensaje de verificacion
            }

        }

        //BORRA UN TIPO DE PRODUCTO
        private void btn_delete_Click(object sender, EventArgs e)
        {
            //DECLARACION DE VARIABLES
            string ID_tipo_producto = Convert.ToString(txt_id_tipo_producto.Text);

            if (txt_id_tipo_producto.Text != "")
            {
                //CREACION DE LA VARIABLE BORRAR
                SqlCommand borrar = new SqlCommand();

                //VARIABLE + CONEXION
                borrar = mi_conexion.CreateCommand();

                //VARIABLE DONDE ALMACENO LA INSTRUCCION
                borrar.CommandText = "delete from Tipo_Producto where id_tipo=@ID";

                //VINCULACION DE PARAMETROS
                borrar.Parameters.AddWithValue("@ID", ID_tipo_producto);

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
    }
}
