using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TiendaelUniversoOrg
{
    public partial class Agregar_Carrito : Form
    {
        public Agregar_Carrito()
        {
            InitializeComponent();
        }

        private void regresar_Click(object sender, EventArgs e)
        {

            //muestra el form administrador
            Menu_Administrador menu = new Menu_Administrador();
            this.Hide();//oculta el form agregrar usuario al presionar regresar
            menu.ShowDialog();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {  
            try
            {//guarda los registro que uno selecciono al siguiente cuadro
                bSABindingSource.EndEdit();
                bSATableAdapter.Update(this.arti_AdmiDataSet.BSA);
                panel_add_articles.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                bSABindingSource.ResetBindings(false);

            }
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            try
            {//Agrega una nueva linea a cuado de la base de datos
                panel_add_articles.Enabled = true;
                tx_codeart.Focus();
                this.arti_AdmiDataSet.BSA.AddBSARow(this.arti_AdmiDataSet.BSA.NewBSARow());
                bSABindingSource.MoveLast();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                bSABindingSource.ResetBindings(false);

            }
        }

        private void Agregar_Carrito_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet.DB' table. You can move, or remove it, as needed.
            this.dBTableAdapter.Fill(this.databaseDataSet.DB);
            // TODO: This line of code loads data into the 'arti_AdmiDataSet.BSA' table. You can move, or remove it, as needed.
            this.bSATableAdapter.Fill(this.arti_AdmiDataSet.BSA);
           
        }

        private void mostrar_Click(object sender, EventArgs e)
        {//llena la base de datos dependiendo de la pocion 
            tx_precio.Text= this.dataGridView.CurrentRow.Cells[0].Value.ToString();
            tx_codeart.Text = this.dataGridView.CurrentRow.Cells[1].Value.ToString();
            tx_inventario.Text = this.dataGridView.CurrentRow.Cells[2].Value.ToString();
            cmb_clasificacion.Text = this.dataGridView.CurrentRow.Cells[3].Value.ToString();
            cbx_medida.Text = this.dataGridView.CurrentRow.Cells[4].Value.ToString();
            tx_descripcion.Text = this.dataGridView.CurrentRow.Cells[5].Value.ToString();
           
        }

        private void panel_add_articles_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void salir_Click(object sender, EventArgs e)
        {
            //funcion del boton salir
            Application.Exit();
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {

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
                    var query = from o in this.databaseDataSet.DB
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
