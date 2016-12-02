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
    public partial class CodigoAdmin : Form
    {
        public CodigoAdmin()
        {
            InitializeComponent();
        }

        private void regresar_Click(object sender, EventArgs e)
        {//muestra el menu clientes al presionar regresar
            Menu_Clientes menuprincipal = new Menu_Clientes();
            this.Hide();//oculta el form codigo administrador al presionar ingresar
            menuprincipal.ShowDialog();
        }

        private void aceptar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tx_user.Text))//compara si el campo esta vació y envia el mensaje de que llene todos los datos
            {
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

                    //muestra el menu administrador al presionar ok en el message box
                    Menu_Administrador administrador = new Menu_Administrador();
                    this.Hide();//oculta el form codigo administrador al presionar ingresar
                    administrador.ShowDialog();

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

        private void CodigoAdmin_Load(object sender, EventArgs e)
        {

        }

        private void tx_user_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                tx_password.Focus();
            }

        }

        private void tx_password_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                aceptar.PerformClick();
            }

        }
    }
}
