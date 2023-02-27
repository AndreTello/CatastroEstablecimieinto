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

namespace Prueba_Postgres.Comerciante
{
    public partial class Frm_Comerciante : Form
    {
        public Frm_Comerciante()
        {
            InitializeComponent();
        }

        private void Frm_Comerciante_Load(object sender, EventArgs e)
        {
            cmbestado.Items.Add("0");
            cmbestado.Items.Add("1");
            cmbestado.SelectedIndex = 0;
            Listar_Identificacion();
            Listar_Ocupante();
            Mostrar_Datos();
        }

        Cls_Comerciante_BLL objbll = new Cls_Comerciante_BLL();

        private string id = null;
        private bool editar = false;

        public void Mostrar_Datos()
        {
            Cls_Comerciante_BLL objnew = new Cls_Comerciante_BLL();
            datos.DataSource = objnew.Consultar_Comerciante();
        }

        public void Limpiar()
        {
            cmbidentificacion.SelectedIndex = 0;
            cmbocupante.SelectedIndex = 0;
            txtcedula.Text = string.Empty;
            txtapellido.Text = string.Empty;
            txtnombres.Text = string.Empty;
            txtfechan.Text = string.Empty;
            txtedad.Text = string.Empty;
            txtlugar.Text = string.Empty;
            txttelefono.Text = string.Empty;
            txtcelular.Text  = string.Empty;
            txtdireccion.Text = string.Empty;
            txtciudad.Text = string.Empty;
            txtprovincia.Text = string.Empty;
            txtemail.Text = string.Empty;            
            cmbestado.SelectedIndex = 0;
        }

        private void Listar_Identificacion()
        {
            Cls_Tipo_Identificacion_BLL objbll = new Cls_Tipo_Identificacion_BLL();
            cmbidentificacion.DataSource = objbll.Listar_Tipo_Identificacion();
            cmbidentificacion.DisplayMember = "tipo_identificacion_nombre";
            cmbidentificacion.ValueMember = "tipo_identificacion_id";
        }

        private void Listar_Ocupante()
        {
            Cls_Tipo_Ocupante_BLL objbll = new Cls_Tipo_Ocupante_BLL();
            cmbocupante.DataSource = objbll.Listar_Tipo_Ocupante();
            cmbocupante.DisplayMember = "tipo_ocupante_nombre";
            cmbocupante.ValueMember = "tipo_ocupante_id";
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            if (editar == false)
            {

                objbll.Insertar_Comerciante(Convert.ToInt32(cmbidentificacion.SelectedValue),  Convert.ToInt32(cmbocupante.SelectedValue), txtcedula.Text, txtapellido.Text, txtnombres.Text, txtfechan.Text, txtedad.Text, txtlugar.Text, txttelefono.Text, txtcelular.Text, txtdireccion.Text, txtciudad.Text, txtprovincia.Text, txtemail.Text, cmbestado.Text);
                MessageBox.Show("REGISTRADO CORRECTAMENTE");
                Mostrar_Datos();
                Limpiar();
            }
            if (editar == true)
            {
                objbll.Editar_Comerciante(Convert.ToInt32(cmbidentificacion.SelectedValue), Convert.ToInt32(cmbocupante.SelectedValue), txtcedula.Text, txtapellido.Text, txtnombres.Text, txtfechan.Text, txtedad.Text, txtlugar.Text, txttelefono.Text, txtcelular.Text, txtdireccion.Text, txtciudad.Text, txtprovincia.Text, txtemail.Text, cmbestado.Text, id);
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
                Cls_Comerciante_BLL objnew = new Cls_Comerciante_BLL();
                datos.DataSource = objnew.Consultar_IdComerciante(txtid.Text);
                txtid.Text = string.Empty;
            }

        }

        private void Actualizar_Click(object sender, EventArgs e)
        {
            if (datos.SelectedRows.Count > 0)
            {
                editar = true;
                cmbidentificacion.Text = datos.CurrentRow.Cells["tipo_identificacion_nombre"].Value.ToString();
                cmbocupante.Text = datos.CurrentRow.Cells["tipo_ocupante_nombre"].Value.ToString();
                txtcedula.Text = datos.CurrentRow.Cells["comerciante_cedula_ruc"].Value.ToString();
                txtapellido.Text = datos.CurrentRow.Cells["comerciante_apellidos_razon_social"].Value.ToString();
                txtnombres.Text = datos.CurrentRow.Cells["comerciante_nombres_representante_legal"].Value.ToString();
                txtfechan.Text = datos.CurrentRow.Cells["comerciante_fecha_nacimiento"].Value.ToString();
                txtedad.Text = datos.CurrentRow.Cells["comerciante_edad"].Value.ToString();
                txtlugar.Text = datos.CurrentRow.Cells["comerciante_lugar_origen"].Value.ToString();
                txttelefono.Text = datos.CurrentRow.Cells["comerciante_telefono_convencional"].Value.ToString();
                txtcelular.Text = datos.CurrentRow.Cells["comerciante_telefono_celular"].Value.ToString();
                txtdireccion.Text = datos.CurrentRow.Cells["comerciante_direccion_domicilio"].Value.ToString();
                txtciudad.Text = datos.CurrentRow.Cells["comerciante_ciudad"].Value.ToString();
                txtprovincia.Text = datos.CurrentRow.Cells["comerciante_provincia"].Value.ToString();
                txtemail.Text = datos.CurrentRow.Cells["comerciante_mail"].Value.ToString();
                cmbestado.Text = datos.CurrentRow.Cells["comerciante_estado"].Value.ToString();
                id = datos.CurrentRow.Cells["comerciante_id"].Value.ToString();
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
                id = datos.CurrentRow.Cells["comerciante_id"].Value.ToString();
                objbll.Eliminar_Comerciante(id);
                MessageBox.Show("ELIMINADO CORRECTAMENTE");
                Mostrar_Datos();
                Limpiar();
            }
            else
            {
                MessageBox.Show("SELECCIONE LA FILA A ELIMINAR");
            }
        }

        private void Volver_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }

        private void Mostrar_Click(object sender, EventArgs e)
        {
            Mostrar_Datos();
        }
    }
}
