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

namespace Prueba_Postgres
{
    public partial class Frm_Intervencion_Tecnica_E : Form
    {
        public Frm_Intervencion_Tecnica_E()
        {
            InitializeComponent();
        }

        private void Volver_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }

        private void Frm_Intervencion_Tecnica_E_Load(object sender, EventArgs e)
        {
            cmbestado.Items.Add("0");
            cmbestado.Items.Add("1");
            cmbestado.SelectedIndex = 0;
            Listar_Tipos_Intervencion();
            Mostrar_Datos();
        }

        Cls_Intervencion_Tecnica_Establecimiento_BLL objbll = new Cls_Intervencion_Tecnica_Establecimiento_BLL();

        private string id = null;
        private bool editar = false;

        public void Mostrar_Datos()
        {
            Cls_Intervencion_Tecnica_Establecimiento_BLL objnew = new Cls_Intervencion_Tecnica_Establecimiento_BLL();
            datos.DataSource = objnew.Consultar_Intervencion_Tecnica_Establecimiento();
        }

        public void Limpiar()
        {
            cmbtipo.SelectedIndex = 0;
            txtnombre.Text = string.Empty;
            txtfinicio.Text = string.Empty;
            cmbestado.SelectedIndex = 0;
            txtffin.Text = string.Empty;
        }

        private void Listar_Tipos_Intervencion()
        {
            Cls_Tipo_Intervencion_Tecnica_BLL objbll = new Cls_Tipo_Intervencion_Tecnica_BLL();
            cmbtipo.DataSource = objbll.Listar_Tipo_Intervencion_Tecnica();
            cmbtipo.DisplayMember = "tipo_intervencion_tecnica_establecimiento_nombre";
            cmbtipo.ValueMember = "tipo_intervencion_tecnica_establecimiento_id";
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            if (editar == false)
            {

                objbll.Insertar_Intervencion_Tecnica_Establecimiento(Convert.ToInt32(cmbtipo.SelectedValue), txtnombre.Text, txtfinicio.Text, txtffin.Text, cmbestado.Text);
                MessageBox.Show("REGISTRADO CORRECTAMENTE");
                Mostrar_Datos();
                Limpiar();
            }
            if (editar == true)
            {
                objbll.Editar_Intervencion_Tecnica_Establecimiento(Convert.ToInt32(cmbtipo.SelectedValue), txtnombre.Text, txtfinicio.Text, txtffin.Text, cmbestado.Text, id);
                MessageBox.Show("ACTUALIZADO CORRECTAMENTE");
                Mostrar_Datos();
                editar = false;
                Limpiar();
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
                Cls_Intervencion_Tecnica_Establecimiento_BLL objnew = new Cls_Intervencion_Tecnica_Establecimiento_BLL();
                datos.DataSource = objnew.Consultar_IdIntervencion_Tecnica_Establecimiento(txtid.Text);
                txtid.Text = string.Empty;
            }
        }

        private void Actualizar_Click(object sender, EventArgs e)
        {
            if (datos.SelectedRows.Count > 0)
            {
                editar = true;
                cmbtipo.Text = datos.CurrentRow.Cells["tipo_intervencion_tecnica_establecimiento_nombre"].Value.ToString();
                txtnombre.Text = datos.CurrentRow.Cells["intervencion_tecnica_establecimiento_nombre"].Value.ToString();
                txtfinicio.Text = datos.CurrentRow.Cells["intervencion_tecnica_establecimiento_fecha_inicio"].Value.ToString();
                txtffin.Text = datos.CurrentRow.Cells["intervencion_tecnica_establecimiento_fecha_fin"].Value.ToString();
                cmbestado.Text = datos.CurrentRow.Cells["intervencion_tecnica_establecimiento_estado"].Value.ToString();
                id = datos.CurrentRow.Cells["intervencion_tecnica_establecimiento_id"].Value.ToString();
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
                id = datos.CurrentRow.Cells["intervencion_tecnica_establecimiento_id"].Value.ToString();
                objbll.Eliminar_Intervencion_Tecnica_Establecimiento(id);
                MessageBox.Show("ELIMINADO CORRECTAMENTE");
                Mostrar_Datos();
                Limpiar();
            }
            else
            {
                MessageBox.Show("SELECCIONE LA FILA A ELIMINAR");
            }
        }

        private void Mostrar_Click(object sender, EventArgs e)
        {
            Mostrar_Datos();
        }
    }
}
