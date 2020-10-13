using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//LIBRERIA SQL
using System.Data.Sql;
using System.Data.SqlClient;

namespace _26.BBDD_ANIDADAS
{
    public partial class Form_Mostrar_tablas : Form
    {
        // CONEXION A LA BASE DE DATOS (patch / BBDD / seguridad)
        string conectar = @"data source=P528853\SQLEXPRESS; initial catalog= PEDIDOS; integrated security= SSPI";
        //DEFINIMOS LA VARIABLE DE SqlConnection
        SqlConnection mi_conexion;


        //  ******************* FORMULARIOS *******************

        public Form_Mostrar_tablas()
        {
            InitializeComponent();
        }

        private void Form_Mostrar_tablas_Load(object sender, EventArgs e)
        {
            //VARIABLE QUE ESTABLECERA LA CONEXION
            mi_conexion = new SqlConnection(conectar);

            cbx_seleccion_tablas.Items.Clear();
            cbx_seleccion_tablas.Items.Add("CLIENTES");
            cbx_seleccion_tablas.Items.Add("PRODUCTOS");
            cbx_seleccion_tablas.Items.Add("TIPO DE PRODUCTO");
            cbx_seleccion_tablas.Items.Add("VENTAS");
        }


        //  ******************* BOTONES *******************

        //BOTON CERRAR
        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbx_tabla_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void cbx_seleccion_tablas_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tablas = Convert.ToString(cbx_seleccion_tablas.Text);

            switch (tablas)
            {
                //COMPLETA EL COMBOBOX CON LOS CAMPOS CORRESPONDIENTES UNA VEZ QUE SELECCIONAMOS LA TABLA
                case "CLIENTES":
                    cbx_campos_tablas.Items.Clear();
                    cbx_campos_tablas.Items.Add("ID cliente");
                    cbx_campos_tablas.Items.Add("Nombre");
                    cbx_campos_tablas.Items.Add("Apellido");
                    cbx_campos_tablas.Items.Add("Direccion");
                    cbx_campos_tablas.Items.Add("Provincia");
                    cbx_campos_tablas.Items.Add("Fecha de registro");
                    break;
                case "PRODUCTOS":
                    cbx_campos_tablas.Items.Clear();
                    cbx_campos_tablas.Items.Add("ID producto");
                    cbx_campos_tablas.Items.Add("Descripción");
                    cbx_campos_tablas.Items.Add("Precio");
                    cbx_campos_tablas.Items.Add("ID tipo de producto");
                    break;
                case "TIPO DE PRODUCTO":
                    cbx_campos_tablas.Items.Clear();
                    cbx_campos_tablas.Items.Add("ID tipo de producto");
                    cbx_campos_tablas.Items.Add("Descripción");
                    break;
                case "VENTAS":
                    cbx_campos_tablas.Items.Clear();
                    cbx_campos_tablas.Items.Add("ID ventas");
                    cbx_campos_tablas.Items.Add("Fecha de Venta");
                    cbx_campos_tablas.Items.Add("ID Producto");
                    cbx_campos_tablas.Items.Add("ID cliente");
                    cbx_campos_tablas.Items.Add("Cantidad");
                    break;
            }
        }

        // BOTON: MOSTRAR TODO
        private void btn_mostrar_todo_Click(object sender, EventArgs e)
        {
            string tablas = Convert.ToString(cbx_seleccion_tablas.Text);

            //MUESTRA TODA LA TABLA CLIENTES
            if (tablas == "CLIENTES")
            {
                SqlDataAdapter mostrar_todo;
                DataTable tabla = new DataTable();

                mi_conexion.Open();

                mostrar_todo = new SqlDataAdapter("Select * from Clientes", mi_conexion);

                mostrar_todo.Fill(tabla);

                mi_conexion.Close();

                dgw_mostrar_todo.DataSource = tabla;
            }
            //MUESTRA TODA LA TABLA PRODUCTOS
            else if (tablas == "PRODUCTOS")
            {
                SqlDataAdapter mostrar_todo;
                DataTable tabla = new DataTable();

                mi_conexion.Open();

                mostrar_todo = new SqlDataAdapter("Select * from Productos", mi_conexion);

                mostrar_todo.Fill(tabla);

                mi_conexion.Close();

                dgw_mostrar_todo.DataSource = tabla;
            }
            //MUESTRA TODA LA TABLA TIPO DE PRODUCTO
            else if (tablas == "TIPO DE PRODUCTO")
            {
                SqlDataAdapter mostrar_todo;
                DataTable tabla = new DataTable();

                mi_conexion.Open();

                mostrar_todo = new SqlDataAdapter("Select * from Tipo_Producto", mi_conexion);

                mostrar_todo.Fill(tabla);

                mi_conexion.Close();

                dgw_mostrar_todo.DataSource = tabla;
            }
            //MUESTRA TODA LA TABLA VENTAS
            else if (tablas == "VENTAS")
            {
                SqlDataAdapter mostrar_todo;
                DataTable tabla = new DataTable();

                mi_conexion.Open();

                mostrar_todo = new SqlDataAdapter("Select * from Ventas", mi_conexion);

                mostrar_todo.Fill(tabla);

                mi_conexion.Close();

                dgw_mostrar_todo.DataSource = tabla;
            }
            //MENSAJE DE ERROR
            else
            {
                MessageBox.Show("Elija una TABLA para proceder");
            }

        }

        // BOTON: BUSCAR POR
        private void btn_buscar_por_Click(object sender, EventArgs e)
        {
            string tablas = Convert.ToString(cbx_seleccion_tablas.Text);
            string categoria = Convert.ToString(cbx_campos_tablas.Text);
            string buscar = Convert.ToString(txt_campo.Text);

            if (tablas != "" && categoria != "" && buscar != "")
            { 
                switch (tablas)
            {
                //TABLA CLIENTES
                case "CLIENTES":
                    //BUSCA POR ID
                    if (categoria == "ID cliente")
                    {
                        SqlDataAdapter mostrar_por;

                        DataTable tabla_cat_cliente = new DataTable();

                        mi_conexion.Open();

                        mostrar_por = new SqlDataAdapter("select * from clientes where id_cliente=" + buscar, mi_conexion);

                        mostrar_por.Fill(tabla_cat_cliente);

                        mi_conexion.Close();

                        dgw_mostrar_todo.DataSource = tabla_cat_cliente;
                    }
                    //BUSCA POR NOMBRE
                    else if (categoria == "Nombre")
                    {
                        SqlDataAdapter mostrar_por;

                        DataTable tabla_cat_cliente = new DataTable();

                        mi_conexion.Open();

                        mostrar_por = new SqlDataAdapter("select * from clientes where nombre LIKE '%" + buscar + "%'", mi_conexion);

                        mostrar_por.Fill(tabla_cat_cliente);

                        mi_conexion.Close();

                        dgw_mostrar_todo.DataSource = tabla_cat_cliente;
                    }
                    //BUSCA POR APELLIDO
                    else if (categoria == "Apellido")
                    {
                        SqlDataAdapter mostrar_por;

                        DataTable tabla_cat_cliente = new DataTable();

                        mi_conexion.Open();

                        mostrar_por = new SqlDataAdapter("select * from clientes where apellido LIKE '%" + buscar + "%'", mi_conexion);

                        mostrar_por.Fill(tabla_cat_cliente);

                        mi_conexion.Close();

                        dgw_mostrar_todo.DataSource = tabla_cat_cliente;
                    }
                    //BUSCA POR DIRECCION
                    else if (categoria == "Direccion")
                    {
                        SqlDataAdapter mostrar_por;

                        DataTable tabla_cat_cliente = new DataTable();

                        mi_conexion.Open();

                        mostrar_por = new SqlDataAdapter("select * from clientes where direccion LIKE '%" + buscar + "%'", mi_conexion);

                        mostrar_por.Fill(tabla_cat_cliente);

                        mi_conexion.Close();

                        dgw_mostrar_todo.DataSource = tabla_cat_cliente;
                    }
                    //BUSCA POR PROVINCIAS
                    else if (categoria == "Provincia")
                    {
                        SqlDataAdapter mostrar_por;

                        DataTable tabla_cat_cliente = new DataTable();

                        mi_conexion.Open();

                        mostrar_por = new SqlDataAdapter("select * from clientes where provincia LIKE '%" + buscar + "%'", mi_conexion);

                        mostrar_por.Fill(tabla_cat_cliente);

                        mi_conexion.Close();

                        dgw_mostrar_todo.DataSource = tabla_cat_cliente;
                    }
                    //BUSCA POR FECHA DE REGISTRO
                    else if (categoria == "Fecha de registro")
                    {
                        SqlDataAdapter mostrar_por;

                        DataTable tabla_cat_cliente = new DataTable();

                        mi_conexion.Open();

                        mostrar_por = new SqlDataAdapter("select * from clientes where fecha_registracion= '" + buscar + "'", mi_conexion);

                        mostrar_por.Fill(tabla_cat_cliente);

                        mi_conexion.Close();

                        dgw_mostrar_todo.DataSource = tabla_cat_cliente;
                    }
                    // MENSAJE DE ERROR
                    else
                    {
                        MessageBox.Show("Elija una TABLA / CATEGORIA / escriba un TEXTO para proceder");
                    }
                    break;

                //TABLA PRODUCTOS
                case "PRODUCTOS":
                    //BUSCA POR ID
                    if (categoria == "ID producto")
                    {
                        SqlDataAdapter mostrar_por;

                        DataTable tabla_cat_cliente = new DataTable();

                        mi_conexion.Open();

                        mostrar_por = new SqlDataAdapter("select * from productos where id_producto=" + buscar, mi_conexion);

                        mostrar_por.Fill(tabla_cat_cliente);

                        mi_conexion.Close();

                        dgw_mostrar_todo.DataSource = tabla_cat_cliente;
                    }
                    //BUSCA POR DESCRIPCION
                    else if (categoria == "Descripción")
                    {
                        SqlDataAdapter mostrar_por;

                        DataTable tabla_cat_cliente = new DataTable();

                        mi_conexion.Open();

                        mostrar_por = new SqlDataAdapter("select * from productos where  descripcion LIKE '%" + buscar + "%'", mi_conexion);

                        mostrar_por.Fill(tabla_cat_cliente);

                        mi_conexion.Close();

                        dgw_mostrar_todo.DataSource = tabla_cat_cliente;
                    }
                    //BUSCA POR PRECIO
                    else if (categoria == "Precio")
                    {
                        SqlDataAdapter mostrar_por;

                        DataTable tabla_cat_cliente = new DataTable();

                        mi_conexion.Open();

                        mostrar_por = new SqlDataAdapter("select * from productos where precio=" + buscar, mi_conexion);

                        mostrar_por.Fill(tabla_cat_cliente);

                        mi_conexion.Close();

                        dgw_mostrar_todo.DataSource = tabla_cat_cliente;
                    }
                    //BUSCA POR ID TIPO DE PRODUCTO
                    else if (categoria == "ID tipo de producto")
                    {
                        SqlDataAdapter mostrar_por;

                        DataTable tabla_cat_cliente = new DataTable();

                        mi_conexion.Open();

                        mostrar_por = new SqlDataAdapter("select * from productos where id_tipo=" + buscar, mi_conexion);

                        mostrar_por.Fill(tabla_cat_cliente);

                        mi_conexion.Close();

                        dgw_mostrar_todo.DataSource = tabla_cat_cliente;
                    }
                    // MENSAJE DE ERROR
                    else
                    {
                        MessageBox.Show("Elija una TABLA / CATEGORIA / escriba un TEXTO para proceder");
                    }
                    break;

                //TABLA TIPO DE PRODUCTOS
                case "TIPO DE PRODUCTO":

                    //BUSCA POR ID TIPO DE PRODUCTO
                    if (categoria == "ID tipo de producto")
                    {
                        SqlDataAdapter mostrar_por;

                        DataTable tabla_cat_cliente = new DataTable();

                        mi_conexion.Open();

                        mostrar_por = new SqlDataAdapter("select * from Tipo_Producto where id_tipo=" + buscar, mi_conexion);

                        mostrar_por.Fill(tabla_cat_cliente);

                        mi_conexion.Close();

                        dgw_mostrar_todo.DataSource = tabla_cat_cliente;
                    }
                    //BUSCA POR DESCRIPCION
                    else if (categoria == "Descripción")
                    {
                        SqlDataAdapter mostrar_por;

                        DataTable tabla_cat_cliente = new DataTable();

                        mi_conexion.Open();

                        mostrar_por = new SqlDataAdapter("select * from Tipo_Producto where descripcion LIKE '%" + buscar + "%'", mi_conexion);

                        mostrar_por.Fill(tabla_cat_cliente);

                        mi_conexion.Close();

                        dgw_mostrar_todo.DataSource = tabla_cat_cliente;
                    }
                    // MENSAJE DE ERROR
                    else
                    {
                        MessageBox.Show("Elija una TABLA / CATEGORIA / escriba un TEXTO para proceder");
                    }
                    break;
                
                //TABLA VENTAS
                case "VENTAS":
                    //BUSCA POR ID VENTAS
                    if (categoria == "ID ventas")
                    {
                        SqlDataAdapter mostrar_por;

                        DataTable tabla_cat_cliente = new DataTable();

                        mi_conexion.Open();

                        mostrar_por = new SqlDataAdapter("select * from Ventas where id_venta=" + buscar, mi_conexion);

                        mostrar_por.Fill(tabla_cat_cliente);

                        mi_conexion.Close();

                        dgw_mostrar_todo.DataSource = tabla_cat_cliente;
                    }
                    //BUSCA POR FECHA DE REGISTRO
                    else if (categoria == "Fecha de Venta")
                    {
                        SqlDataAdapter mostrar_por;

                        DataTable tabla_cat_cliente = new DataTable();

                        mi_conexion.Open();

                        mostrar_por = new SqlDataAdapter("select * from Ventas where fecha_venta= '" + buscar + "'", mi_conexion);

                        mostrar_por.Fill(tabla_cat_cliente);

                        mi_conexion.Close();

                        dgw_mostrar_todo.DataSource = tabla_cat_cliente;
                    }
                    //BUSCA POR ID PRODUCTOS
                    else if (categoria == "ID Producto")
                    {
                        SqlDataAdapter mostrar_por;

                        DataTable tabla_cat_cliente = new DataTable();

                        mi_conexion.Open();

                        mostrar_por = new SqlDataAdapter("select * from Ventas where id_producto=" + buscar, mi_conexion);

                        mostrar_por.Fill(tabla_cat_cliente);

                        mi_conexion.Close();

                        dgw_mostrar_todo.DataSource = tabla_cat_cliente;
                    }
                    //BUSCA POR ID CLIENTE
                    else if (categoria == "ID cliente")
                    {
                        SqlDataAdapter mostrar_por;

                        DataTable tabla_cat_cliente = new DataTable();

                        mi_conexion.Open();

                        mostrar_por = new SqlDataAdapter("select * from Ventas where id_cliente=" + buscar, mi_conexion);

                        mostrar_por.Fill(tabla_cat_cliente);

                        mi_conexion.Close();

                        dgw_mostrar_todo.DataSource = tabla_cat_cliente;
                    }
                    //BUSCA POR CANTIDAD
                    else if (categoria == "Cantidad")
                    {
                        SqlDataAdapter mostrar_por;

                        DataTable tabla_cat_cliente = new DataTable();

                        mi_conexion.Open();

                        mostrar_por = new SqlDataAdapter("select * from Ventas where cantidad LIKE '%" + buscar + "%'", mi_conexion);

                        mostrar_por.Fill(tabla_cat_cliente);

                        mi_conexion.Close();

                        dgw_mostrar_todo.DataSource = tabla_cat_cliente;
                    }
                    // MENSAJE DE ERROR
                    else
                    {
                        MessageBox.Show("Elija una TABLA / CATEGORIA / escriba un TEXTO para proceder");
                    }
                    break;
                }
            }
            else
            {
                MessageBox.Show("Elija una TABLA / CATEGORIA / escriba un TEXTO para proceder");
            }
        }
    }
}
