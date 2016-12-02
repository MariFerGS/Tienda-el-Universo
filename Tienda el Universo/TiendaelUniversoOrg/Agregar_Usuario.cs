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
    public partial class Agregar_Usuario : Form
    {
        public Agregar_Usuario()
        {//iniciliza con los texbox deshabilitados
            InitializeComponent();
            tx_code_local.Enabled = false;
            tx_code_user.Enabled = false;
            tx_email.Enabled = false;
            tx_name.Enabled = false;
            cmb_nivel.Enabled = false;
        }

        private void Agregar_Usuario_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataUser.User' table. You can move, or remove it, as needed.
            this.userTableAdapter.Fill(this.dataUser.User);
            userBindingSource.DataSource = this.dataUser.User;

        }

        private void btn_new_Click(object sender, EventArgs e)
        {
        }

        private void regresar_Click_1(object sender, EventArgs e)
        {
            //muestra el form administrador
            Menu_Administrador menu = new Menu_Administrador();
            this.Hide();//oculta el form agregrar usuario al presionar regresar
            menu.ShowDialog();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {//cierra el form
            Close();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {//función del boton guardar, todo lo que se encuentra en el panel lo guarda en la base de datos
            try
            {
                userBindingSource.EndEdit();
                userTableAdapter.Update(this.dataUser.User);
                panel_usuario.Enabled = false;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                userBindingSource.ResetBindings(false);

            }
        }

        private void btn_new_Click_1(object sender, EventArgs e)
        {//habilitA los textbox
            tx_code_local.Enabled = true;
            tx_code_user.Enabled = true;
            tx_email.Enabled = true;
            tx_name.Enabled = true;
            cmb_nivel.Enabled = true;
            try
            {//agrga nueva linea en el data
                panel_usuario.Enabled = true;
                tx_code_user.Focus();
                this.dataUser.User.AddUserRow(this.dataUser.User.NewUserRow());
                userBindingSource.MoveLast();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                userBindingSource.ResetBindings(false);

            }
            //borra los combo box de clasificacion y medida al presionar nuevo
            cmb_nivel.SelectedIndex = -1;

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {//deshabilita los txbox
            panel_usuario.Enabled = false;
            userBindingSource.ResetBindings(false);
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {//habilita todos los texbox para editar
            panel_usuario.Enabled = true;
            tx_code_user.Focus();
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {//borra con la tecla delete
            {
                if (e.KeyCode == Keys.Delete)
                {
                    if (MessageBox.Show("¿Desea borrar la información guardada? ", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                       userBindingSource.RemoveCurrent();
                    }
                    else
                    {
                        return;

                    }

                }



            }


        }

        private void tx_search_KeyPress(object sender, KeyPressEventArgs e)
        {
            //filtra informacion
            if (e.KeyChar == (char)13)

            {
                if (string.IsNullOrEmpty(tx_filtar.Text))
                {
                    //this.userTableAdapter.Fill(this.dataUser.User);
                    //userBindingSource.DataSource = this.dataUser.User;
                    dataGridView.DataSource = userBindingSource;
                }


                else
                {
                    var query = from o in this.dataUser.User
                                where o.Nombre == tx_filtar.Text || o.Nivel == tx_filtar.Text  || o.Correo==tx_filtar.Text 
                                //|| o.Código_Usuario == Convert.ToInt32(tx_filtar.Text)
                                //||o.Código_Usuario==Convert.ToInt32(tx_filtar.Text) || o.Código_Local==Convert.ToInt32(tx_filtar.Text)

                                select o;
                    //userBindingSource.DataSource = query.ToList();
                    dataGridView.DataSource = query.ToList();
                }

            }
        }

    }

}
