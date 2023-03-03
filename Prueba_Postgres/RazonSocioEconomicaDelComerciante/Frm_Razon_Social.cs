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

namespace Prueba_Postgres.RazonSocioEconomicaDelComerciante
{
    public partial class Frm_Razon_Social : Form
    {
        public Frm_Razon_Social()
        {
            InitializeComponent();
        }

        private void Frm_Razon_Social_Load(object sender, EventArgs e)
        {
            cmbestado.Items.Add("0");
            cmbestado.Items.Add("1");
            cmbestado.SelectedIndex = 0;
            Listar_Comerciante();
            Listar_Etnia();
            Listar_Genero();
            Listar_Estado_Civil();
            Listar_Nacionalidad();
            Listar_Nivel_Educacion();
            Listar_Discapacidad();
            Mostrar_Datos();
        }

        Cls_Identificacion_Socio_Economica_BLL objbll = new Cls_Identificacion_Socio_Economica_BLL();

        private string id = null;
        private bool editar = false;

        public void Mostrar_Datos()
        {
            Cls_Identificacion_Socio_Economica_BLL objnew = new Cls_Identificacion_Socio_Economica_BLL();
            datos.DataSource = objnew.Consultar_Identificacion_Socio_Economica();
        }

        public void Limpiar()
        {
            cmbcomerciante.SelectedIndex = 0;
            cmbetnia.SelectedIndex = 0;
            cmbgenero.SelectedIndex = 0;
            cmbestado_civil.SelectedIndex = 0;
            cmbnacionalidad.SelectedIndex = 0;
            cmbnivel_educacion.SelectedIndex = 0;
            cmbdiscapacidad.SelectedIndex = 0;
            txtjefe.Text = string.Empty;
            txtdependientes.Text = string.Empty;
            txtndependientes.Text = string.Empty;
            txtparentezco.Text = string.Empty;
            cmbestado.SelectedIndex = 0;
        }

        private void Listar_Comerciante()
        {
            Cls_Comerciante_BLL objbll = new Cls_Comerciante_BLL();
            cmbcomerciante.DataSource = objbll.Listar_Comerciante();
            cmbcomerciante.DisplayMember = "comerciante_nombres_representante_legal";
            cmbcomerciante.ValueMember = "comerciante_id";
        }

        private void Listar_Etnia()
        {
            Cls_Etnia_BLL objbll = new Cls_Etnia_BLL();
            cmbetnia.DataSource = objbll.Listar_Etnia();
            cmbetnia.DisplayMember = "etnia_nombre";
            cmbetnia.ValueMember = "etnia_id";
        }

        private void Listar_Genero()
        {
            Cls_Genero_BLL objbll = new Cls_Genero_BLL();
            cmbgenero.DataSource = objbll.Listar_Genero();
            cmbgenero.DisplayMember = "genero_nombre";
            cmbgenero.ValueMember = "genero_id";
        }

        private void Listar_Estado_Civil()
        {
            Cls_Estado_Civil_BLL objbll = new Cls_Estado_Civil_BLL();
            cmbestado_civil.DataSource = objbll.Listar_Estado_Civil();
            cmbestado_civil.DisplayMember = "estado_civil_nombre";
            cmbestado_civil.ValueMember = "estado_civil_id";
        }

        private void Listar_Nacionalidad()
        {
            Cls_Nacionalidad_BLL objbll = new Cls_Nacionalidad_BLL();
            cmbnacionalidad.DataSource = objbll.Listar_Nacionalidad();
            cmbnacionalidad.DisplayMember = "nacionalidad_nombre";
            cmbnacionalidad.ValueMember = "nacionalidad_id";
        }

        private void Listar_Nivel_Educacion()
        {
            Cls_Nivel_Educacion_BLL objbll = new Cls_Nivel_Educacion_BLL();
            cmbnivel_educacion.DataSource = objbll.Listar_Nivel_Educacion();
            cmbnivel_educacion.DisplayMember = "nivel_educacion_nombre";
            cmbnivel_educacion.ValueMember = "nivel_educacion_id";
        }

        private void Listar_Discapacidad()
        {
            Cls_Discapacidad_BLL objbll = new Cls_Discapacidad_BLL();
            cmbdiscapacidad.DataSource = objbll.Listar_Discapacidad();
            cmbdiscapacidad.DisplayMember = "discapacidad_nombre";
            cmbdiscapacidad.ValueMember = "discapacidad_id";
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

        private void Guardar_Click(object sender, EventArgs e)
        {
            if (editar == false)
            {

                objbll.Insertar_Identificacion_Socio_Economica(Convert.ToInt32(cmbcomerciante.SelectedValue), Convert.ToInt32(cmbetnia.SelectedValue), Convert.ToInt32(cmbgenero.SelectedValue), Convert.ToInt32(cmbestado_civil.SelectedValue), Convert.ToInt32(cmbnacionalidad.SelectedValue), Convert.ToInt32(cmbnivel_educacion.SelectedValue), Convert.ToInt32(cmbdiscapacidad.SelectedValue), txtjefe.Text, txtdependientes.Text, txtndependientes.Text, txtparentezco.Text, cmbestado.Text);
                MessageBox.Show("REGISTRADO CORRECTAMENTE");
                Mostrar_Datos();
                Limpiar();
            }
            if (editar == true)
            {
                objbll.Editar_Identificacion_Socio_Economica(Convert.ToInt32(cmbcomerciante.SelectedValue), Convert.ToInt32(cmbetnia.SelectedValue), Convert.ToInt32(cmbgenero.SelectedValue), Convert.ToInt32(cmbestado_civil.SelectedValue), Convert.ToInt32(cmbnacionalidad.SelectedValue), Convert.ToInt32(cmbnivel_educacion.SelectedValue), Convert.ToInt32(cmbdiscapacidad.SelectedValue), txtjefe.Text, txtdependientes.Text, txtndependientes.Text, txtparentezco.Text, cmbestado.Text, id);
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
                cmbcomerciante.Text = datos.CurrentRow.Cells["comerciante_nombres_representante_legal"].Value.ToString();
                cmbetnia.Text = datos.CurrentRow.Cells["etnia_nombre"].Value.ToString();
                cmbgenero.Text = datos.CurrentRow.Cells["genero_nombre"].Value.ToString();
                cmbestado_civil.Text = datos.CurrentRow.Cells["estado_civil_nombre"].Value.ToString();
                cmbnacionalidad.Text = datos.CurrentRow.Cells["nacionalidad_nombre"].Value.ToString();
                cmbnivel_educacion.Text = datos.CurrentRow.Cells["nivel_educacion_nombre"].Value.ToString();
                cmbdiscapacidad.Text = datos.CurrentRow.Cells["discapacidad_nombre"].Value.ToString();
                txtjefe.Text = datos.CurrentRow.Cells["identificacion_socio_economica_jefe_familia"].Value.ToString();
                txtdependientes.Text = datos.CurrentRow.Cells["identificacion_socio_economica_dependientes"].Value.ToString();
                txtndependientes.Text = datos.CurrentRow.Cells["identificacion_socio_economica_numero_dependientes"].Value.ToString();
                txtparentezco.Text = datos.CurrentRow.Cells["identificacion_socio_economica_parentesco"].Value.ToString();
                cmbestado.Text = datos.CurrentRow.Cells["identificacion_socio_economica_estado"].Value.ToString();
                id = datos.CurrentRow.Cells["identificacion_socio_economica_id"].Value.ToString();
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
                id = datos.CurrentRow.Cells["identificacion_socio_economica_id"].Value.ToString();
                objbll.Eliminar_Identificacion_Socio_Economica(id);
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
                Cls_Identificacion_Socio_Economica_BLL objnew = new Cls_Identificacion_Socio_Economica_BLL();
                datos.DataSource = objnew.Consultar_IdIdentificacion_Socio_Economica(txtid.Text);
                txtid.Text = string.Empty;
            }
        }
    }
}
