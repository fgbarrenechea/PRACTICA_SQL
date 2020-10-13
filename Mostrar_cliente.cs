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
    public partial class Mostrar_Cliente : Form
    {
        // CONEXION A LA BASE DE DATOS (patch / BBDD / seguridad)
        string conectar = @"data source=P528853\SQLEXPRESS; initial catalog= PEDIDOS; integrated security= SSPI";
        //DEFINIMOS LA VARIABLE DE SqlConnection
        SqlConnection mi_conexion;

        //  ******************* FORMULARIOS *******************

        public Mostrar_Cliente()
        {
            InitializeComponent();
        }

        private void Mostrar_Cliente_Load(object sender, EventArgs e)
        {
            //Prepara la conexion para abrirse, sacando la informacion de la variable conexion
            mi_conexion = new SqlConnection(conectar);
        }

        //  ******************* BOTONES *******************

        //BOTON CERRAR
        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //BOTON BUSCAR
        private void btn_buscar_Click(object sender, EventArgs e)
        {
            SqlDataAdapter mostrar;
            DataTable tabla = new DataTable();

            mi_conexion.Open();

            mostrar = new SqlDataAdapter("Select * from Clientes",mi_conexion);
            mostrar.Fill(tabla);

            mi_conexion.Close();

            dgw_cliente.DataSource = tabla;


            /*
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
                SqlCommand leer = new SqlCommand("select * from Clientes where id_cliente=@ID", mi_conexion);

                //VINCULACION DE PARAMETROS
                leer.Parameters.AddWithValue("@ID", ID);

                //ABRO LA CONEXION
                mi_conexion.Open();
                //EJECUTO LA QUERY
                leer.ExecuteNonQuery();
                //CIERRO LA CONEXION
                mi_conexion.Close();
            }
            else
            {
                MessageBox.Show("Por favor ingrese algun valor"); //Mensaje de verificacion
            }
            */

        }

        private void btn_buscar_por_Click(object sender, EventArgs e)
        {
            if (cbx_tabla.Text=="CLIENTES")
            {
                MessageBox.Show("Elegistes CLIENTES"); //Mensaje de verificacio
            }
            else if (cbx_tabla.Text == "PRODUCTOS")
            {
                MessageBox.Show("Elegistes PRODCUTOS"); //Mensaje de verificacio
            }
            else if (cbx_tabla.Text == "TIPO DE PRODUCTOS")
            {
                MessageBox.Show("Elegistes TIPO DE PRODCUTOS"); //Mensaje de verificacio
            }
            else if (cbx_tabla.Text == "VENTAS")
            {
                MessageBox.Show("Elegistes VENTAS"); //Mensaje de verificacio
            }






            /*
            string a_buscar = Convert.ToString (txt_campo.Text) ;

            MessageBox.Show(a_buscar); //Mensaje de verificacio

            SqlDataAdapter mostrar;
            DataTable tabla = new DataTable();

            mi_conexion.Open();

            switch (a_buscar)
            {
                case "ID":
                    SqlDataAdapter mostrar;
                    DataTable tabla = new DataTable(); mostrar = new SqlDataAdapter("Select * from Clientes where id_cliente = @var", mi_conexion);
                    //VINCULACION DE PARAMETROS
                    mostrar.SelectCommand.Parameters.AddWithValue("@var", a_buscar);
                    mostrar.Fill(tabla);
                    break;
                case "NOMBRE":
                    mostrar = new SqlDataAdapter("Select * from Clientes where nombre = @var", mi_conexion);
                    //VINCULACION DE PARAMETROS
                    mostrar.SelectCommand.Parameters.AddWithValue("@var", a_buscar);
                    mostrar.Fill(tabla);
                    break;
                case "APELLIDO":
                    mostrar = new SqlDataAdapter("Select * from Clientes where apellido = @var", mi_conexion);
                    //VINCULACION DE PARAMETROS
                    mostrar.SelectCommand.Parameters.AddWithValue("@var", a_buscar);
                    mostrar.Fill(tabla);
                    break;
                case "DIRECCION":
                    mostrar = new SqlDataAdapter("Select * from Clientes where direccion = @var", mi_conexion);
                    //VINCULACION DE PARAMETROS
                    mostrar.SelectCommand.Parameters.AddWithValue("@var", a_buscar);
                    mostrar.Fill(tabla);
                    break;
                case "PROVINCIA":
                    mostrar = new SqlDataAdapter("Select * from Clientes where provincia = @var", mi_conexion);
                    //VINCULACION DE PARAMETROS
                    mostrar.SelectCommand.Parameters.AddWithValue("@var", a_buscar);
                    mostrar.Fill(tabla);
                    break;
                case "FECHA DE REGISTRACION":
                    mostrar = new SqlDataAdapter("Select * from Clientes where fecha_registracion = @var", mi_conexion);
                    //VINCULACION DE PARAMETROS
                    mostrar.SelectCommand.Parameters.AddWithValue("@var", a_buscar);
                    mostrar.Fill(tabla);
                    break;

            }
            
                       
            mi_conexion.Close();

            dgw_cliente.DataSource = tabla;
            */
        }

        //  ******************* FUNCIONES *******************

        void Tabla()
        {
            string a_buscar = Convert.ToString(txt_tabla.Text);
            string tablas ="";

            switch (a_buscar)
            {
                case "CLIENTES":
                    tablas = "Clientes";
                    break;
                case "PRODUCTOS":
                    tablas = "Productos";
                    break;
                case "TIPO DE PRODUCTO":
                    tablas = "Tipo_Producto";
                    break;
                case "VENTAS":
                    tablas = "Ventas";
                    break;
            }

        }

        void Campos()
        {
            string a_buscar = Convert.ToString(txt_tabla.Text);

            switch (a_buscar)
            {
                case "ID":

                    break;
                case "NOMBRE":
                    break;
                case "APELLIDO":
                    break;
                case "DIRECCION":
                    break;
                case "PROVINCIA":
                    break;
                case "FECHA DE REGISTRACION":
                    break;

            }
        }
    }
}
