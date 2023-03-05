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

namespace Prueba_Postgres.GiroNegocio
{
    public partial class Frm_Giro_Negocio : Form
    {
        public Frm_Giro_Negocio()
        {
            InitializeComponent();
        }

        private void Frm_Giro_Negocio_Load(object sender, EventArgs e)
        {
            cmbestado.Items.Add("0");
            cmbestado.Items.Add("1");
            cmbestado.SelectedIndex = 0;
            Listar_Provincias();
            Mostrar_Datos();
        }

        Cls_Giro_Negocio_BLL objbll = new Cls_Giro_Negocio_BLL();

        private string id = null;
        private bool editar = false;

        private void Listar_Provincias()
        {
            Cls_Tipos_Producto_BLL objbll = new Cls_Tipos_Producto_BLL();
            cmbtipo.DataSource = objbll.Listar_Tipo_Producto();
            cmbtipo.DisplayMember = "tipo_producto_nombre";
            cmbtipo.ValueMember = "tipo_producto_id";
        }

        public void Mostrar_Datos()
        {
            Cls_Giro_Negocio_BLL objnew = new Cls_Giro_Negocio_BLL();
            datos.DataSource = objnew.Consultar_Giro_Negocio();
        }

        public void Limpiar()
        {
            cmbtipo.SelectedIndex = 0;
            txtnombre.Text = string.Empty;
            txtsubgiro.Text = string.Empty;
            txtabastecimiento.Text = string.Empty;
            txtobservacion.Text = string.Empty;
            cmbestado.SelectedIndex = 0;
        }

        private void Mostrar_Click(object sender, EventArgs e)
        {
            Mostrar_Datos();
            Limpiar();
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            if (editar == false)
            {

                objbll.Insertar_Giro_Negocio(Convert.ToInt32(cmbtipo.SelectedValue), txtnombre.Text, txtsubgiro.Text, txtabastecimiento.Text, txtobservacion.Text, cmbestado.Text);
                MessageBox.Show("REGISTRADO CORRECTAMENTE");
                Mostrar_Datos();
                Limpiar();
            }
            if (editar == true)
            {
                objbll.Editar_Giro_Negocio(Convert.ToInt32(cmbtipo.SelectedValue), txtnombre.Text, txtsubgiro.Text, txtabastecimiento.Text, txtobservacion.Text, cmbestado.Text, id);
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
                cmbtipo.Text = datos.CurrentRow.Cells["tipo_producto_nombre"].Value.ToString();
                txtnombre.Text = datos.CurrentRow.Cells["giro_negocio_nombre"].Value.ToString();
                txtsubgiro.Text = datos.CurrentRow.Cells["giro_negocio_subgiro"].Value.ToString();
                txtabastecimiento.Text = datos.CurrentRow.Cells["giro_negocio_abastecimiento"].Value.ToString();
                txtobservacion.Text = datos.CurrentRow.Cells["giro_negocio_observacion"].Value.ToString();
                cmbestado.Text = datos.CurrentRow.Cells["giro_negocio_estado"].Value.ToString();
                id = datos.CurrentRow.Cells["giro_negocio_id"].Value.ToString();
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
                id = datos.CurrentRow.Cells["giro_negocio_id"].Value.ToString();
                objbll.Eliminar_Giro_Negocio(id);
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
                Cls_Giro_Negocio_BLL objnew = new Cls_Giro_Negocio_BLL();
                datos.DataSource = objnew.Consultar_IdGiro_Negocio(txtid.Text);
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
