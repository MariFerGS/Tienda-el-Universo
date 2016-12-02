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
    public partial class Info_Articles : Form
    {
        public Info_Articles()
        {
            InitializeComponent();
        }

        private void Info_Articles_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBArt.DB' table. You can move, or remove it, as needed.
            this.dBTableAdapter.Fill(this.dBArt.DB);

        }

        private void salir_Click(object sender, EventArgs e)
        {//cierra el from
            Close();
        }

        private void btnreturn_Click(object sender, EventArgs e)
        {
            //regresa al menu administrador
            Menu_Clientes menu = new Menu_Clientes();
            this.Hide();//oculta el form de informacion del articulo al presionar regresar
            menu.ShowDialog();//muesta el menu administrador
        }

        private void tx_search_KeyPress(object sender, KeyPressEventArgs e)
        {
            //filtra informacion
            if (e.KeyChar == (char)13)

            {
                if (string.IsNullOrEmpty(tx_search.Text))
                {//busca en el data

                    dataGridView.DataSource = dBBindingSource;
                }


                else
                {
                    var query = from o in this.dBArt.DB
                                where o.Clasificación == tx_search.Text || o.Unidad_Medida == tx_search.Text || o.Descripción == tx_search.Text
                                //|| o.Precio == Convert.ToInt32(tx_search.Text)|| o.Código_Artículo== Convert.ToInt32(tx_search.Text) || 
                                //o.Inventario==Convert.ToInt32(tx_search.Text) ||o.Código_Usuario==Convert.ToInt32(tx_search.Text) ||o.Descripción==tx_search.Text

                                select o;

                    dataGridView.DataSource = query.ToList();
                }

            }
        }
    }
}
