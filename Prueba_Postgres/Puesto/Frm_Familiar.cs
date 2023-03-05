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
    public partial class Frm_Familiar : Form
    {
        public Frm_Familiar()
        {
            InitializeComponent();
        }

        private void Frm_Familiar_Load(object sender, EventArgs e)
        {
            cmbestado.Items.Add("0");
            cmbestado.Items.Add("1");
            cmbestado.SelectedIndex = 0;
            Mostrar_Datos();
            Listar_Tipo();
            Listar_Comerciantes();
        }

        Cls_Familiar_BLL objbll = new Cls_Familiar_BLL();

        private string id = null;
        private bool editar = false;

        public void Mostrar_Datos()
        {
            Cls_Familiar_BLL objnew = new Cls_Familiar_BLL();
            datos.DataSource = objnew.Consultar_Familiar();
        }

        public void Limpiar()
        {
            cmbtipo.SelectedIndex = 0;
            cmbcomerciante.SelectedIndex = 0;
            txtcedula.Text = string.Empty;
            txtapellidos.Text = string.Empty;
            txtnombres.Text = string.Empty;
            txtmenor.Text = string.Empty;
            txtescolaridad.Text = string.Empty;
            cmbestado.SelectedIndex = 0;
        }

        private void Listar_Tipo()
        {
            Cls_Tipo_Familiar_BLL objbll = new Cls_Tipo_Familiar_BLL();
            cmbtipo.DataSource = objbll.Listar_Tipo_Familiar();
            cmbtipo.DisplayMember = "tipo_familiar_nombre";
            cmbtipo.ValueMember = "tipo_familiar_id";
        }

        private void Listar_Comerciantes()
        {
            Cls_Comerciante_BLL objbll = new Cls_Comerciante_BLL();
            cmbcomerciante.DataSource = objbll.Listar_Comerciante();
            cmbcomerciante.DisplayMember = "comerciante_nombres_representante_legal";
            cmbcomerciante.ValueMember = "comerciante_id";
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
                objbll.Insertar_Familiar(Convert.ToInt32(cmbtipo.SelectedValue), Convert.ToInt32(cmbcomerciante.SelectedValue), txtcedula.Text, txtapellidos.Text, txtnombres.Text, txtmenor.Text, txtescolaridad.Text, cmbestado.Text);
                MessageBox.Show("REGISTRADO CORRECTAMENTE");
                Mostrar_Datos();
                Limpiar();
            }
            if (editar == true)
            {
                objbll.Editar_Familiar(Convert.ToInt32(cmbtipo.SelectedValue), Convert.ToInt32(cmbcomerciante.SelectedValue), txtcedula.Text, txtapellidos.Text, txtnombres.Text, txtmenor.Text, txtescolaridad.Text, cmbestado.Text, id);
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
                cmbtipo.Text = datos.CurrentRow.Cells["tipo_familiar_nombre"].Value.ToString();
                cmbcomerciante.Text = datos.CurrentRow.Cells["comerciante_nombres_representante_legal"].Value.ToString();
                txtcedula.Text = datos.CurrentRow.Cells["familiar_cedula"].Value.ToString();
                txtapellidos.Text = datos.CurrentRow.Cells["familiar_apellidos"].Value.ToString();
                txtnombres.Text = datos.CurrentRow.Cells["familiar_nombres"].Value.ToString();
                txtmenor.Text = datos.CurrentRow.Cells["familiar_menor_edad"].Value.ToString();
                txtescolaridad.Text = datos.CurrentRow.Cells["familiar_escolaridad"].Value.ToString();
                cmbestado.Text = datos.CurrentRow.Cells["familiar_estado"].Value.ToString();
                id = datos.CurrentRow.Cells["familiar_id"].Value.ToString();
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
                id = datos.CurrentRow.Cells["familiar_id"].Value.ToString();
                objbll.Eliminar_Familiar(id);
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
                Cls_Familiar_BLL objnew = new Cls_Familiar_BLL();
                datos.DataSource = objnew.Consultar_IdFamiliar(txtid.Text);
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
