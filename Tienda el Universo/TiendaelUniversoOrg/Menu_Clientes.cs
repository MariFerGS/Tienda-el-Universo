using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TiendaelUniversoOrg
{
    public partial class Menu_Clientes : Form
    {
        public Menu_Clientes()
        {
            InitializeComponent();
        }

        private void btnreturn_Click(object sender, EventArgs e)
        {
            //regresa al form inicial
            Forminico menuprincipal = new Forminico();
            this.Hide();//oculta el form clientes al presionar regresar
            menuprincipal.ShowDialog();


        }

   

        private void empleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {//muestra el form codigo empleado
            codigo_empleado code = new codigo_empleado();
            code.ShowDialog();
         
            
        }

        private void salir_Click(object sender, EventArgs e)
        {//funcion del boton salir
            Application.Exit();
        }

        private void administradorToolStripMenuItem_Click(object sender, EventArgs e)
        {//muestra el form del codigo administrador
            CodigoAdmin code = new CodigoAdmin();
            code.ShowDialog();
        }

        private void infoart_Click(object sender, EventArgs e)
        {
            //llama y muestra el form informacion de articulos
            Info_Articles infoarticulos = new Info_Articles();
            this.Hide();//oculta el form administrador al presionar agregar
            infoarticulos.ShowDialog();
        }

        private void carrito_Click(object sender, EventArgs e)
        {
           

            //llama y muestra el form informacion de articulos
            Agregar_Carrito_Articulo_Comprados infoarticulos = new Agregar_Carrito_Articulo_Comprados   ();
            this.Hide();//oculta el form administrador al presionar agregar
            infoarticulos.ShowDialog();
          
            
        }

        private void Compras_Click(object sender, EventArgs e)
        {
            //llama y muestra el form informacion de articulos
            Agregar_Carrito infoarticulos = new Agregar_Carrito();
            this.Hide();//oculta el form administrador al presionar agregar
            infoarticulos.ShowDialog();
        }

        private void Menu_Clientes_Load(object sender, EventArgs e)
        {

        }
    }
}
