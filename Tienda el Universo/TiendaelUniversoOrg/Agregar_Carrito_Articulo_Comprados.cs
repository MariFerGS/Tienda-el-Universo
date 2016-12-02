using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;//librería necesaria para guardar en excel

namespace TiendaelUniversoOrg
{
    public partial class Agregar_Carrito_Articulo_Comprados : Form
    {
        public Agregar_Carrito_Articulo_Comprados()
        {
            InitializeComponent();
        }

        private void Agregar_Carrito_Articulo_Comprados_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'arti_AdmiDataSet1.BSA' table. You can move, or remove it, as needed.
            this.bSATableAdapter.Fill(this.arti_AdmiDataSet1.BSA);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void regresar_Click(object sender, EventArgs e)
        {
            //regresa al menu clientes
            Menu_Clientes menuadmin = new Menu_Clientes();
            this.Hide();//oculta el form agregar articulos al presionar regresar
            menuadmin.ShowDialog();//muesta clientes
        }

        private void salir_Click(object sender, EventArgs e)
        {
            //funcion del boton salir
            Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            double total;
            double impuesto;//variablle que nos va a servir para hacer la operacion del impuesto
            double subtotal = 0;//se inicializa la variable en 0, ya que va a mantener la suma de las cantidades
            foreach (DataGridViewRow row in dataGridView.Rows)
            {//recorre las filas del datagriedview
                 if ((row.Cells["columna_precio"].Value == null) == false) {//verifica si las celdas del datagried estan con datos
                        subtotal += Convert.ToDouble(row.Cells["columna_precio"].Value); //suma todas las cantidades que aparezcan en la columna precio
                    }

            }
            impuesto =subtotal * 0.13;//operacion del impuesto de compra
            total = subtotal + impuesto;

         tx_subtotal_compra.Text = Convert.ToString(subtotal);//imprime el total de la compra en el tx_subtotal  
            tx_iva.Text = Convert.ToString(impuesto);
           
            tx_total_compra.Text = Convert.ToString(total);//imprime el total por la compra con el impuesto incluido
        }

        // metodo de borrar en el datagrid
        private void dataGridView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)//pregunta si la tecla presionada en la de delete
            {//manda un mensaje que pregunta si desea borrar la información
                if (MessageBox.Show("¿Desea borrar la información guardada? ", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {//si es si borra la informacion de la base de datos

                    bSABindingSource.RemoveCurrent();
                }
                else
                {//en caso contrario se devuelve al form
                    return;
                }
            }

        }
        public void ExportarExcel(DataGridView grd)//metodo que exporta lo que hay en el form de agregar carrito a excel
        {
          //try y catch en caso de error
            try
            {

                SaveFileDialog fichero = new SaveFileDialog();//instancia que guarda el archivo
                fichero.Filter = "Excel (*.xls)|*.xls";//se declaran las posibles extensiones que nos sirven para guardar el archivo
                fichero.FileName = "Factura";//le asignamos el nombre al archivo cuando se guarde(se puede cambiar el nombre en ejecucion)
                if (fichero.ShowDialog() == DialogResult.OK)//si se le da aceptar a la ventana de guardar el archivo
                {
                    Microsoft.Office.Interop.Excel.Application aplicacion;//interaccion con microsoft
                    Microsoft.Office.Interop.Excel.Workbook libros_trabajo;//libro en que se va a trabajar en excel
                    Microsoft.Office.Interop.Excel.Worksheet hoja_trabajo;//hoja de trabajo n la que se va a guardar la información

                    aplicacion = new Microsoft.Office.Interop.Excel.Application();//si la respuesta es si pasa la informacion al libro y hoja de trabajo en excel
                    libros_trabajo = aplicacion.Workbooks.Add();//todo lo que lleve la palabra aplicacion se añadirá al libro en excel
                    hoja_trabajo = (Microsoft.Office.Interop.Excel.Worksheet)libros_trabajo.Worksheets.get_Item(1);//se define que solo una hoja se va a ocupar
                    //Datos que van a ir en la hoja de excel con su respectiva posición
                    aplicacion.Cells[1, 4] = "Tienda el Universo";
                    aplicacion.Cells[2, 1] = "Factura de Compra";
                    aplicacion.Cells[4, 1] = "Datos del Cliente";
                    aplicacion.Cells[6, 1] = "Nombre:";
                    aplicacion.Cells[7, 1] = "Dirección:";
                    aplicacion.Cells[8, 1] = "Teléfono:";
                    aplicacion.Cells[16, 5] = "SUBTOTAL:";
                    aplicacion.Cells[17, 5] = "I.V:";
                    aplicacion.Cells[18, 5] = "TOTAL:";
                    aplicacion.Cells[10, 1] = "Código Artículo:";
                    aplicacion.Cells[10, 2] = "Precio:";
                    aplicacion.Cells[10, 3] = "Clasificación:";
                    aplicacion.Cells[10, 4] = "Medida:";
                    aplicacion.Cells[10, 5] = "Descripción:";
                    //llamada de la informacion que se ingrese en los textbox
                    aplicacion.Cells[6, 2] = tx_name.Text;
                    aplicacion.Cells[7, 2] = tx_direccion.Text;
                    aplicacion.Cells[8, 2] = tx_telefono.Text;
                    aplicacion.Cells[16, 6] = tx_subtotal_compra.Text;
                    aplicacion.Cells[17, 6] =tx_iva.Text;
                    aplicacion.Cells[18, 6] = tx_total_compra.Text;

                    //Recorremos el DataGridView rellenando la hoja de trabajo
                    for (int i = 0; i < grd.Rows.Count - 1; i++)
                    {
                        for (int j = 0; j < grd.Columns.Count; j++)
                        {
                            if ((grd.Rows[i].Cells[j].Value == null) == false)//verifica si la celda esta con información la agrega al libro
                            {
                                hoja_trabajo.Cells[i + 11, j + 1] = grd.Rows[i].Cells[j].Value.ToString();
                                //recorre la hoja de excel llenando los campos, a partir de la fila 11 columna 1
                            }
                        }
                    }
                    libros_trabajo.SaveAs(fichero.FileName,//guarda el libro
                        Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal);
                    libros_trabajo.Close(true);//cierra el excel 
                    aplicacion.Quit();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al exportar la informacion debido a: " + ex.ToString());//mensaje en caso de error
            }

        }

        private void lk_imprimir_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ExportarExcel(dataGridView);//llama el método exporta excel a partir del link imprimir
        }
    }
    }

