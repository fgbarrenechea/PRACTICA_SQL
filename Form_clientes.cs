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
    public partial class Form_clientes : Form
    {
        // CONEXION A LA BASE DE DATOS (patch / BBDD / seguridad)
        string conectar = @"data source=P528853\SQLEXPRESS; initial catalog= PEDIDOS; integrated security= SSPI";
        //DEFINIMOS LA VARIABLE DE SqlConnection
        SqlConnection mi_conexion;

        //  ******************* FORMULARIOS *******************
        public Form_clientes()
        {
            InitializeComponent();
        }


        /*
        //DECLARACION DE VARIABLES
        string ID = Convert.ToString(txt_ID.Text);
        string nombre = Convert.ToString(txt_nombre.Text);
        string apellido = Convert.ToString(txt_apellido.Text);
        string direccion = Convert.ToString(txt_direccion.Text);
        string provincia = Convert.ToString(txt_provincia.Text);
        string registro = Convert.ToString(txt_registro.Text);
        */
         
        private void Form_clientes_Load(object sender, EventArgs e)
        {
            //Prepara la conexion para abrirse, sacando la informacion de la variable conexion
            mi_conexion = new SqlConnection(conectar);
                       
        }


        //  ******************* FORMULARIOS *******************

        //CIERRA EL FORMULARIO
        private void btn_salir_Click(object sender, EventArgs e)
        {
           this.Close();
        }

        //  ******************* BOTONES *******************

        //INSERTA UN NUEVO CLIENTE
        private void btn_crear_Click(object sender, EventArgs e)
        {
            if (txt_ID.Text == "")
            {
                //DECLARACION DE VARIABLES
                string nombre = Convert.ToString(txt_nombre.Text);
                string apellido = Convert.ToString(txt_apellido.Text);
                string direccion = Convert.ToString(txt_direccion.Text);
                string provincia = Convert.ToString(txt_provincia.Text);
                string registro = Convert.ToString(txt_registro.Text);

                //VARIABLE DONDE ALMACENO LA INSTRUCCION SQL
                SqlCommand nvo_registro = new SqlCommand();
                //vARIABLE QUE MATCHEA LA CONEXION
                nvo_registro = mi_conexion.CreateCommand();
                //INSTRUCCION SQL
                nvo_registro.CommandText = "insert into Clientes (nombre, apellido, direccion, provincia, fecha_registracion) " +
                                           "values(@nombre, @apellido, @direccion, @provincia, @registro)";

                //VINCULACION DE PARAMETROS
                nvo_registro.Parameters.AddWithValue("@nombre", nombre);
                nvo_registro.Parameters.AddWithValue("@apellido", apellido);
                nvo_registro.Parameters.AddWithValue("@direccion", direccion);
                nvo_registro.Parameters.AddWithValue("@provincia", provincia);
                nvo_registro.Parameters.AddWithValue("@registro", registro);

                //ABRO LA CONEXION
                mi_conexion.Open();
                //EJECUTO LA QUERY
                nvo_registro.ExecuteNonQuery();
                //CIERRO LA CONEXION
                mi_conexion.Close();

                Limpiar();

                MessageBox.Show("Agrego un nuevo Cliente"); //Mensaje de verificacion
            }
            else
            {
                MessageBox.Show("Por favor no complete el campo de ID CLIENTE"); //Mensaje de verificacion
            }
        }
        
        //ACTUALIZA UN CLIENTE
        private void btn_update_Click(object sender, EventArgs e)
        {
            //DECLARACION DE VARIABLES
            string ID = Convert.ToString(txt_ID.Text);
            string nombre = Convert.ToString(txt_nombre.Text);
            string apellido = Convert.ToString(txt_apellido.Text);
            string direccion = Convert.ToString(txt_direccion.Text);
            string provincia = Convert.ToString(txt_provincia.Text);
            string registro = Convert.ToString(txt_registro.Text);

            if (txt_ID.Text != "")
            {
                //VARIABLE DONDE ALMACENO LA INSTRUCCION SQL Y LA CONEXION
                SqlCommand actualizar = new SqlCommand("update Clientes set nombre=@nombre, apellido=@apellido, direccion=@direccion" +
                                                       ", provincia=@provincia, fecha_registracion=@registro where id_cliente=@ID", mi_conexion);
                //VINCULACION DE PARAMETROS
                actualizar.Parameters.AddWithValue("@ID", ID);
                actualizar.Parameters.AddWithValue("@nombre", nombre);
                actualizar.Parameters.AddWithValue("@apellido", apellido);
                actualizar.Parameters.AddWithValue("@direccion", direccion);
                actualizar.Parameters.AddWithValue("@provincia", provincia);
                actualizar.Parameters.AddWithValue("@registro", registro);

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
   
        //BORRA UN CLIENTE
        private void btn_delete_Click(object sender, EventArgs e)
        {
            //DECLARACION DE VARIABLES
            string ID = Convert.ToString(txt_ID.Text);

            if (txt_ID.Text != "")
            {
                //CREACION DE LA VARIABLE BORRAR
                SqlCommand borrar = new SqlCommand();
                
                //VARIABLE + CONEXION
                borrar = mi_conexion.CreateCommand();

                //VARIABLE DONDE ALMACENO LA INSTRUCCION
                borrar.CommandText = "delete from Clientes where id_cliente=@ID";

                //VINCULACION DE PARAMETROS
                borrar.Parameters.AddWithValue("@ID", ID);

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
 
        //MUESTRA UN MOSTRAR
        private void btn_leer_Click(object sender, EventArgs e)
        {
            //DECLARACION DE LOS FORMULARIOS
            Form_Mostrar_tablas mostrar_tablas = new Form_Mostrar_tablas();
            //LLAMA AL FORMULARIO CLIENTES
            mostrar_tablas.Show();

        }

        //  ******************* FUNCIONES *******************

        //FUNCION LIMPIAR
        void Limpiar()
        {
            txt_ID.Text = "";
            txt_nombre.Text = "";
            txt_apellido.Text = "";
            txt_direccion.Text = "";
            txt_provincia.Text = "";
            txt_registro.Text = "";
        }


    }
}
