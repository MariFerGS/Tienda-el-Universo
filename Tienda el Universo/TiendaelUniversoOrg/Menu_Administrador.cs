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
    public partial class Menu_Administrador : Form
    {
        public Menu_Administrador()
        {
            InitializeComponent();
        }

   

        private void salir_Click(object sender, EventArgs e)
        {//función del boton salir
            Application.Exit();
        }

        private void btnreturn_Click(object sender, EventArgs e)
        {//llama y muestra el form clientes
            Menu_Clientes menu = new Menu_Clientes();
            this.Hide();//oculta el form administrador
            menu.ShowDialog();
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {//llama y muestra el form agregar articulos
            Add_Articles articulos = new Add_Articles();
            this.Hide();//oculta el form administrador al presionar agregar
            articulos.ShowDialog();
        }

     
        private void agregarToolStripMenuItem1_Click(object sender, EventArgs e)
        {//muestra y llama el form agregar usuario
            Agregar_Usuario user = new Agregar_Usuario();
            this.Hide();//oculta el form administrador al presionar el boton agregar
            user.ShowDialog();
        }

      

     

        private void Menu_Administrador_Load(object sender, EventArgs e)
        {

        }

        private void controlUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //muestra y llama el form agregar usuario
            Agregar_Usuario user = new Agregar_Usuario();
            this.Hide();//oculta el form administrador al presionar el boton agregar
            user.ShowDialog();
        }

      
     
   
        private void inventarioDeArtículosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //llama y muestra el form agregar articulos
            Add_Articles articulos = new Add_Articles();
            this.Hide();//oculta el form administrador al presionar agregar
            articulos.ShowDialog();
        }

        private void controlLocalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //muestra y llama el form Agregar usuario
            Locales_Agregars1 user = new Locales_Agregars1();
            this.Hide();//oculta el form administradr al presionar sobre buscar o eliminar 
            user.ShowDialog();
        }

        private void infoart_Click(object sender, EventArgs e)
        {
            //llama y muestra el form informacion de articulos
           Info_Articles infoarticulos = new Info_Articles();
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

        private void carrito_Click(object sender, EventArgs e)
        {
            //llama y muestra el form informacion de articulos
            Agregar_Carrito_Articulo_Comprados infoarticulos = new Agregar_Carrito_Articulo_Comprados();
            this.Hide();//oculta el form administrador al presionar agregar
            infoarticulos.ShowDialog();
        }
    }
}
