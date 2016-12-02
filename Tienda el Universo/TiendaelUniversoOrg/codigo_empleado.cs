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
    public partial class codigo_empleado : Form
    {
        public codigo_empleado()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //muestra el menu clientes al presionar regresar
            Menu_Clientes menuprincipal = new Menu_Clientes();
            this.Hide();//oculta el form codigo administrador al presionar ingresar
            menuprincipal.ShowDialog();
        }

        private void tx_user_KeyPress(object sender, KeyPressEventArgs e)
        {//enfoca en la claves
            if (e.KeyChar == (char)13)
            {
                tx_password.Focus();
            }


        }

        private void tx_password_KeyPress(object sender, KeyPressEventArgs e)
        {//si se la da ok busca en la data si estan las claves
            if (e.KeyChar == (char)13)
            {
                aceptar.PerformClick();
            }
        }

        private void aceptar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tx_user.Text))//compara si el campo esta vació y envia el mensaje de que llene todos los datos
            {//si esta vació e usuario le pide que porfavor lo llene
                MessageBox.Show("Por favor ingrese su nombre de usuario.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tx_user.Focus();//se enfoca en el tx de usurario
                return;
            }
            else if (string.IsNullOrEmpty(tx_password.Text))
            {
                MessageBox.Show("Por favor ingrese su contraseña.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tx_password.Focus();
                return;

            }
            try
            {
                //compara si la información ingresada es correcta con la informacion que hay en base de datos
                LoginDataTableAdapters.UsersTableAdapter user = new LoginDataTableAdapters.UsersTableAdapter();
                LoginData.UsersDataTable dt = user.GetDataByUsernamePassword(tx_user.Text, tx_password.Text);
                if (dt.Rows.Count > 0)
                {//si la informacion coincide sa el mensaje de bienvenida
                    MessageBox.Show("¡Bienvenido!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //llama y muestra el form agregar articulos
                    Add_Articles articulos = new Add_Articles();
                    this.Hide();//oculta el form codigo empleado al presionar ok
                    articulos.ShowDialog();

                }
                else
                {//si los datos no coinciden informa al usuario de que alguno de los datos es incorrecto
                    MessageBox.Show("El usuario o contraseña son incorrectos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //limpia los texbox al darle ok al message box
                    tx_password.Clear();
                    tx_user.Clear();

                }

            }
            catch (Exception ex)
            {//en caso de que se produzca un error manda el mensaje de error del sistema
                MessageBox.Show(ex.Message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void codigo_empleado_Load(object sender, EventArgs e)
        {

        }
    }
  }

