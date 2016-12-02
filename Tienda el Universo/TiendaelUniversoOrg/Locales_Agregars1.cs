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
    public partial class Locales_Agregars1 : Form
    {
        public Locales_Agregars1()
        {
            InitializeComponent();
        }

        private void tx_filtar_KeyPress(object sender, KeyPressEventArgs e)
        {//filtra informacion
            if (e.KeyChar == (char)13)

            {
                if (string.IsNullOrEmpty(tx_filtar.Text))
                {
                    this.articulo2TableAdapter.Fill(this.agregar_localito.Articulo2);
                    articulo2BindingSource.DataSource = this.agregar_localito.Articulo2; 
                   // dataGridView.DataSource = articulo2BindingSource;
                }


                else
                {
                    var query = from o in this.agregar_localito.Articulo2
                                where o.Código_Local == tx_filtar.Text || o.Ubicación == tx_filtar.Text || o.Venta.Contains(tx_filtar.Text)

                                select o;
                    articulo2BindingSource.DataSource = query.ToList();
                    //dataGridView.DataSource = query.ToList();
                }

            }
        }

        private void dataGridView_KeyDown(object sender, KeyEventArgs e)
        {//metodo borrar con la tecla delete
            {
                if (e.KeyCode == Keys.Delete)
                {
                    if (MessageBox.Show("¿Desea borrar la información guardada? ", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        articulo2BindingSource.RemoveCurrent();
                    }
                    else
                    {

                    }

                }



            }
        }

        private void btn_new_Click(object sender, EventArgs e)
        {//agrga una linea al data para almacenar la nueva información
            try
            {
                panel.Enabled = true;
                tx_codilocal.Focus();
                this.agregar_localito.Articulo2.AddArticulo2Row(this.agregar_localito.Articulo2.NewArticulo2Row());
                articulo2BindingSource.MoveLast();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                articulo2BindingSource.ResetBindings(false);

            }
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {//habilita los forms para editarlos
            panel.Enabled = true;
            tx_codilocal.Focus();

        }

        private void btn_save_Click(object sender, EventArgs e)
        {//guarda la informacion digitada en el data
            try
            {
                articulo2BindingSource.EndEdit();
                articulo2TableAdapter.Update(this.agregar_localito.Articulo2);
                panel.Enabled = false;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                articulo2BindingSource.ResetBindings(false);

            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {//deshabilita los textbox
            panel.Enabled = false;
            articulo2BindingSource.ResetBindings(false);
        }

        private void Locales_Agregars1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'agregar_localito.Articulo2' table. You can move, or remove it, as needed.
            this.articulo2TableAdapter.Fill(this.agregar_localito.Articulo2);
            articulo2BindingSource.DataSource = this.agregar_localito.Articulo2;
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            //funcion del botn salir
            Application.Exit();
        }

        private void regresar_Click(object sender, EventArgs e)
        {
            //muestra el form administrador
            Menu_Administrador menu = new Menu_Administrador();
            this.Hide();//oculta el form agregrar usuario al presionar regresar
            menu.ShowDialog();
        }
    }
}
