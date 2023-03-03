using BLL_CE.Catastro;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prueba_Postgres.Puesto
{
    public partial class Frm_Reemplazo : Form
    {
        public Frm_Reemplazo()
        {
            InitializeComponent();
        }

        private void Frm_Reemplazo_Load(object sender, EventArgs e)
        {
            cmbestado.Items.Add("0");
            cmbestado.Items.Add("1");
            cmbestado.SelectedIndex = 0;
            Mostrar_Datos();
        }

        Cls_Reemplazo_BLL objbll = new Cls_Reemplazo_BLL();

        private string id = null;
        private bool editar = false;

        public void Mostrar_Datos()
        {
            Cls_Reemplazo_BLL objnew = new Cls_Reemplazo_BLL();
            datos.DataSource = objnew.Consultar_Reemplazo();
        }

        public void Limpiar()
        {
            txtcedula.Text = string.Empty;
            txtapellidos.Text = string.Empty;
            txtnombres.Text = string.Empty;
            txtautorizacion.Text = string.Empty;
            txtnoficio.Text = string.Empty;
            dateinicio.Text = string.Empty;
            datefin.Text = string.Empty;
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
                objbll.Insertar_Reemplazo(txtcedula.Text, txtapellidos.Text, txtnombres.Text, txtautorizacion.Text, txtnoficio.Text, dateinicio.Text, datefin.Text, cmbestado.Text);
                MessageBox.Show("REGISTRADO CORRECTAMENTE");
                Mostrar_Datos();
                Limpiar();
            }
            if (editar == true)
            {
                objbll.Editar_Reemplazo(txtcedula.Text, txtapellidos.Text, txtnombres.Text, txtautorizacion.Text, txtnoficio.Text, dateinicio.Text, datefin.Text, cmbestado.Text, id);
                MessageBox.Show("ACTUALIZADO CORRECTAMENTE");
                Mostrar_Datos();
                editar = false;
                Limpiar();
            }
        }

        private void Actualizar_Click(object sender, EventArgs e)
        {
            if (datos.SelectedRows.Count > 0)
            {
                editar = true;
                txtcedula.Text = datos.CurrentRow.Cells["reemplazo_cedula"].Value.ToString();
                txtapellidos.Text = datos.CurrentRow.Cells["reemplazo_apellidos"].Value.ToString();
                txtnombres.Text = datos.CurrentRow.Cells["reemplazo_nombres"].Value.ToString();
                txtautorizacion.Text = datos.CurrentRow.Cells["reemplazo_autorizacion"].Value.ToString();
                txtnoficio.Text = datos.CurrentRow.Cells["reemplazo_numero_oficio"].Value.ToString();
                dateinicio.Text = datos.CurrentRow.Cells["reemplazo_fecha_inicio"].Value.ToString();
                datefin.Text = datos.CurrentRow.Cells["reemplazo_fecha_fin"].Value.ToString();
                cmbestado.Text = datos.CurrentRow.Cells["reemplazo_estado"].Value.ToString();
                id = datos.CurrentRow.Cells["reemplazo_id"].Value.ToString();
            }
            else
            {
                MessageBox.Show("SELECCIONE LA FILA A MODIFICAR");
            }
        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
            if (datos.SelectedRows.Count > 0)
            {
                id = datos.CurrentRow.Cells["reemplazo_id"].Value.ToString();
                objbll.Eliminar_Reemplazo(id);
                MessageBox.Show("ELIMINADO CORRECTAMENTE");
                Mostrar_Datos();
                Limpiar();
            }
            else
            {
                MessageBox.Show("SELECCIONE LA FILA A ELIMINAR");
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
                Cls_Reemplazo_BLL objnew = new Cls_Reemplazo_BLL();
                datos.DataSource = objnew.Consultar_IdReemplazo(txtid.Text);
                txtid.Text = string.Empty;
            }
        }

        private void Volver_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }
    }
}
