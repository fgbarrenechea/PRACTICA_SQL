using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//LIBRERIAS SQL
using System.Data.Sql; 
using System.Data.SqlClient;

namespace _26.BBDD_ANIDADAS
{
    public partial class Form_Mostrar_todo : Form
    {
        // CONEXION A LA BASE DE DATOS (patch / BBDD / seguridad)
        string conectar = @"data source=P528853\SQLEXPRESS; initial catalog= PEDIDOS; integrated security= SSPI";
        //DEFINIMOS LA VARIABLE DE SqlConnection
        SqlConnection mi_conexion;


        //  ******************* FORMULARIOS *******************

        public Form_Mostrar_todo()
        {
            InitializeComponent();
        }

        private void Form_Mostrar_todo_Load(object sender, EventArgs e)
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

        
    }   
}
