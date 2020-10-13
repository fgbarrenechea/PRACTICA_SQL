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
    public partial class Form_ventas : Form
    {
        // CONEXION A LA BASE DE DATOS (patch / BBDD / seguridad)
        string conectar = @"data source=P528853\SQLEXPRESS; initial catalog= PEDIDOS; integrated security= SSPI";
        //DEFINIMOS LA VARIABLE DE SqlConnection
        SqlConnection mi_conexion;

        //  ******************* FORMULARIOS *******************

        public Form_ventas()
        {
            InitializeComponent();
        }
                
        private void Form_ventas_Load(object sender, EventArgs e)
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

        //INSERTA UNA NUEVA VENTA
        private void btn_crear_Click(object sender, EventArgs e)
        {
            if (txt_id_ventas.Text == "")
            {

                //DECLARACION DE VARIABLES
                string fecha = Convert.ToString(txt_fecha.Text);
                string ID_producto = Convert.ToString(txt_producto.Text);
                string ID_cliente = Convert.ToString(txt_ID_cliente.Text);
                string cantidad = Convert.ToString(txt_cantidad.Text);

                //VARIABLE DONDE ALMACENO LA INSTRUCCION SQL
                SqlCommand nvo_registro = new SqlCommand();
                //vARIABLE QUE MATCHEA LA CONEXION
                nvo_registro = mi_conexion.CreateCommand();
                //INSTRUCCION SQL
                nvo_registro.CommandText = "insert into Ventas (fecha_venta, id_producto, id_cliente, cantidad)" +
                                           "values (@fecha,@ID_producto,@ID_cliente,@cantidad)";

                //VINCULACION DE PARAMETROS
                nvo_registro.Parameters.AddWithValue("@fecha", fecha);
                nvo_registro.Parameters.AddWithValue("@ID_producto", ID_producto);
                nvo_registro.Parameters.AddWithValue("@ID_cliente", ID_cliente);
                nvo_registro.Parameters.AddWithValue("@cantidad", cantidad);

                //ABRO LA CONEXION
                mi_conexion.Open();
                //EJECUTO LA QUERY
                nvo_registro.ExecuteNonQuery();
                //CIERRO LA CONEXION
                mi_conexion.Close();

                Limpiar();

                MessageBox.Show("Agrego un nuevo Tipo de Producto"); //Mensaje de verificacion
            }
            else
            {
                MessageBox.Show("Por favor no complete el campo de ID TIPO PRODUCTO"); //Mensaje de verificacion
            }
        }

        //MUESTRA UNA VENTA
        private void btn_leer_Click(object sender, EventArgs e)
        {
            //DECLARACION DE LOS FORMULARIOS
            Form_Mostrar_tablas mostrar_tablas = new Form_Mostrar_tablas();
            //LLAMA AL FORMULARIO CLIENTES
            mostrar_tablas.Show();
        }

        //ACTUALIZA UNA VENTA
        private void btn_update_Click(object sender, EventArgs e)
        {
            //DECLARACION DE VARIABLES
            string ID_venta = Convert.ToString(txt_id_ventas.Text);
            string fecha = Convert.ToString(txt_fecha.Text);
            string ID_producto = Convert.ToString(txt_producto.Text);
            string ID_cliente = Convert.ToString(txt_ID_cliente.Text);
            string cantidad = Convert.ToString(txt_cantidad.Text);

            if (txt_id_ventas.Text != "")
            {
                //VARIABLE DONDE ALMACENO LA INSTRUCCION SQL Y LA CONEXION
                SqlCommand actualizar = new SqlCommand("update Ventas set fecha_venta=@fecha, id_producto=@ID_producto, id_cliente=@ID_cliente," +
                                                       " cantidad=@cantidad where id_venta=@ID", mi_conexion);

                //VINCULACION DE PARAMETROS
                actualizar.Parameters.AddWithValue("@ID", ID_venta);
                actualizar.Parameters.AddWithValue("@fecha", fecha);
                actualizar.Parameters.AddWithValue("@ID_producto", ID_producto);
                actualizar.Parameters.AddWithValue("@ID_cliente", ID_cliente);
                actualizar.Parameters.AddWithValue("@cantidad", cantidad);
                
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

        //BORRA UNA VENTA
        private void btn_delete_Click(object sender, EventArgs e)
        {
            //DECLARACION DE VARIABLES
            string ID_venta = Convert.ToString(txt_id_ventas.Text);

            if (txt_id_ventas.Text != "")
            {
                //CREACION DE LA VARIABLE BORRAR
                SqlCommand borrar = new SqlCommand();

                //VARIABLE + CONEXION
                borrar = mi_conexion.CreateCommand();

                //VARIABLE DONDE ALMACENO LA INSTRUCCION
                borrar.CommandText = "delete from Ventas where id_venta=@ID";

                //VINCULACION DE PARAMETROS
                borrar.Parameters.AddWithValue("@ID", ID_venta);

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
        void Limpiar()
        {
            txt_id_ventas.Text = "";
            txt_fecha.Text = "";
            txt_producto.Text = "";
            txt_ID_cliente.Text = "";
            txt_cantidad.Text = "";
        }
    }
}
