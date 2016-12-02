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
    public partial class Forminico : Form
    {
        public Forminico()
        {
            InitializeComponent();
        }
        //variables de clase
        private int num = 0;

        private void enter_Click(object sender, EventArgs e)
        {//llama y muestra el menu principal clientes
            Menu_Clientes menu = new Menu_Clientes();
            this.Hide();//oculta el form inicial al presionar ingresar

            menu.ShowDialog();//muestra el form clientes
           


        }

        private void Forminico_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {//cierra el form principal
            Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //hace se cambie de color del titulo del menu principal
            num = num + 1;
            //si es diferente a cero entra.
            if (num % 2 == 0)
            {
                lbname1.Visible = true;
                labname2.Visible = false;
            }
            //si no es diferente entra a la condicion falsa
            else
            {
                lbname1.Visible = false;
                labname2.Visible = true;
            }
        }
    }
}
