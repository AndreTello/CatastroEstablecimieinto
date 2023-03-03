using BLL_CE.Catastro;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prueba_Postgres.RazonSocioEconomicaDelComerciante
{
    public partial class Frm_Discapacidad : Form
    {
        public Frm_Discapacidad()
        {
            InitializeComponent();
        }

        private void Volver_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }

        Cls_Discapacidad_BLL objbll = new Cls_Discapacidad_BLL();

        private string id = null;
        private bool editar = false;

        private void Frm_Discapacidad_Load(object sender, EventArgs e)
        {
            cmbestado.Items.Add("0");
            cmbestado.Items.Add("1");
            cmbestado.SelectedIndex = 0;
            Mostrar_Datos();
        }

        public void Mostrar_Datos()
        {
            Cls_Discapacidad_BLL objnew = new Cls_Discapacidad_BLL();
            datos.DataSource = objnew.Consultar_Discapacidad();
        }

        public void Limpiar()
        {
            txtnombre.Text = string.Empty;
            txtcarnet.Text = string.Empty;
            cmbestado.SelectedIndex = 0;
        }


        private void Mostrar_Click(object sender, EventArgs e)
        {
            Mostrar_Datos();
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            if (editar == false)
            {

                objbll.Insertar_Discapacidad(txtcarnet.Text, txtnombre.Text, cmbestado.Text);
                MessageBox.Show("REGISTRADO CORRECTAMENTE");
                Mostrar_Datos();
                Limpiar();

            }
            if (editar == true)
            {
<<<<<<< HEAD

               /* CultureInfo originalCulture = Thread.CurrentThread.CurrentCulture;

                CultureInfo englishCulture = new CultureInfo("en-US");

                // Establecer temporalmente la propiedad ListSeparator en la cultura inglesa
                Thread.CurrentThread.CurrentCulture = englishCulture;
                englishCulture.NumberFormat.NumberDecimalSeparator = ".";
                englishCulture.NumberFormat.NumberGroupSeparator = ",";

                objbll.Editar_Discapacidad(txtcarnet.Text, txtnombre.Text, decimal.Parse(txtporcentaje.Text, englishCulture), cmbestado.Text, id);

=======
>>>>>>> 46f9a24419873e2cfead247654ddd3c12e65a5a8
                objbll.Editar_Discapacidad(txtcarnet.Text, txtnombre.Text, cmbestado.Text, id);
                MessageBox.Show("ACTUALIZADO CORRECTAMENTE");
                Mostrar_Datos();
                editar = false;
                Limpiar();
               */
            }
        }

        private void Actualizar_Click(object sender, EventArgs e)
        {
            if (datos.SelectedRows.Count > 0)
            {
                editar = true;
                txtcarnet.Text = datos.CurrentRow.Cells["discapacidad_carnet"].Value.ToString();
                txtnombre.Text = datos.CurrentRow.Cells["discapacidad_nombre"].Value.ToString();
                cmbestado.Text = datos.CurrentRow.Cells["discapacidad_estado"].Value.ToString();
                id = datos.CurrentRow.Cells["discapacidad_id"].Value.ToString();
            }
            else
            {
                MessageBox.Show("SELECCIONE LA FILA A MODIFICAR");
            }
        }

        private void Consultar_Click(object sender, EventArgs e)
        {
            if (txtid.Text == "")
            {
                MessageBox.Show("Ingrese el id a buscar");
            }
            else
            {
                Cls_Discapacidad_BLL objnew = new Cls_Discapacidad_BLL();
                datos.DataSource = objnew.Consultar_IdDiscapacidad(txtid.Text);
                txtid.Text = string.Empty;
            }
        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
            if (datos.SelectedRows.Count > 0)
            {
                id = datos.CurrentRow.Cells["discapacidad_id"].Value.ToString();
                objbll.Eliminar_Discapacidad(id);
                MessageBox.Show("ELIMINADO CORRECTAMENTE");
                Mostrar_Datos();
                Limpiar();
            }
            else
            {
                MessageBox.Show("SELECCIONE LA FILA A ELIMINAR");
            }
        }
    }
}
