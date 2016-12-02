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
    public partial class Add_Articles : Form
    {
        public Add_Articles()
        {//al inciar el form todoos los textbox estan deshabilitados
            InitializeComponent();
            tx_codeart.Enabled = false;
            tx_code_user.Enabled = false;
            tx_descripcion.Enabled = false;
            tx_inventario.Enabled = false;
            tx_precio.Enabled = false;
            cbx_medida.Enabled = false;
            cmb_clasificacion.Enabled = false;
            pb_add_articles.Enabled = false;
        }

      

        private void Add_Articles_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBArt.DB' table. You can move, or remove it, as needed.

            this.dBTableAdapter.Fill(this.dBArt.DB);
            dBBindingSource.DataSource = this.dBArt.DB;


        }

      

        private void regresar_Click_1(object sender, EventArgs e)
        {
            //regresa al menu clientes
            Menu_Clientes menuadmin = new Menu_Clientes();
            this.Hide();//oculta el form agregar articulos al presionar regresar
            menuadmin.ShowDialog();//muesta clientes
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {//cierra el form
            Close();
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
                                where o.Clasificación==tx_search.Text|| o.Unidad_Medida==tx_search.Text || o.Descripción == tx_search.Text
                                //|| o.Precio == Convert.ToInt32(tx_search.Text)|| o.Código_Artículo== Convert.ToInt32(tx_search.Text) || 
                                //o.Inventario==Convert.ToInt32(tx_search.Text) ||o.Código_Usuario==Convert.ToInt32(tx_search.Text) ||o.Descripción==tx_search.Text

                                select o;
              
                    dataGridView.DataSource = query.ToList();
                }

            }

        }
        //metodo que borra en el datagried
        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (MessageBox.Show("¿Desea borrar la información guardada? ", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    dBBindingSource.RemoveCurrent();
                }
                else
                {
                    return;
                }
            }


        }

        private void btn_save_Click(object sender, EventArgs e)
        {//al presionar el boton se guarda la informacion en la data
            try
            {
                dBBindingSource.EndEdit();
                dBTableAdapter.Update(this.dBArt.DB);
                panel_add_articles.Enabled = false;


            }
            catch (Exception ex)
            {//en caso de error laza mensaje
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dBBindingSource.ResetBindings(false);

            }
        }

        private void btn_new_Click_1(object sender, EventArgs e)
        {//al darle new activa todos los texbox
            tx_codeart.Enabled =true;
            tx_code_user.Enabled = true;
            tx_descripcion.Enabled = true;
            tx_inventario.Enabled = true;
            tx_precio.Enabled = true;
            cbx_medida.Enabled = true;
            cmb_clasificacion.Enabled = true;
            pb_add_articles .Enabled= true;
            try
            {//habilita otra linea en el data para guardar la información
               panel_add_articles.Enabled = true;
               tx_codeart.Focus();
                this.dBArt.DB.AddDBRow(this.dBArt.DB.NewDBRow());
                dBBindingSource.MoveLast();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dBBindingSource.ResetBindings(false);

            }
            //borra los combo box de clasificacion y medida al presionar nuevo
            cmb_clasificacion.SelectedIndex = -1;
            cbx_medida.SelectedIndex = -1;
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {//al presionar cancelar deshabilita todos los forms
            panel_add_articles.Enabled = false;
            dBBindingSource.ResetBindings(false);

        }

        private void btn_editar_Click(object sender, EventArgs e)
        {//si se presiona editar habilita los textbos para cambiar la informacion
           panel_add_articles.Enabled = true;
            tx_codeart.Focus();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {//método que busca las imagenes
            try
            {
                using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "JPEG|*.jpg", ValidateNames = true, Multiselect = false })//abre la ventana para seleccionar la imagen con ese formato
                    if (ofd.ShowDialog() == DialogResult.OK)
                    {//agraga la imagen al data
                        pb_add_articles.Image = Image.FromFile(ofd.FileName);
                        
                    }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       
    }
    }
    

