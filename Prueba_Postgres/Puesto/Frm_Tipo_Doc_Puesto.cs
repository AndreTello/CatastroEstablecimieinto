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
    public partial class Frm_Tipo_Doc_Puesto : Form
    {
        public Frm_Tipo_Doc_Puesto()
        {
            InitializeComponent();
        }

        private void Frm_Tipo_Doc_Puesto_Load(object sender, EventArgs e)
        {
            cmbestado.Items.Add("0");
            cmbestado.Items.Add("1");
            cmbestado.SelectedIndex = 0;
            Mostrar_Datos();
        }

        Cls_Tipo_Documento_Puesto_BLL objbll = new Cls_Tipo_Documento_Puesto_BLL();

        private string id = null;
        private bool editar = false;

        public void Mostrar_Datos()
        {
            Cls_Tipo_Documento_Puesto_BLL objnew = new Cls_Tipo_Documento_Puesto_BLL();
            datos.DataSource = objnew.Consultar_Tipo_Documento_Puesto();
        }

        public void Limpiar()
        {
            txtnombre.Text = string.Empty;
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
                objbll.Insertar_Tipo_Documento_Puesto(txtnombre.Text, cmbestado.Text);
                MessageBox.Show("REGISTRADO CORRECTAMENTE");
                Mostrar_Datos();
                Limpiar();
            }
            if (editar == true)
            {
                objbll.Editar_Tipo_Documento_Puesto(txtnombre.Text, cmbestado.Text, id);
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
                txtnombre.Text = datos.CurrentRow.Cells["tipo_documento_puesto_nombre"].Value.ToString();
                cmbestado.Text = datos.CurrentRow.Cells["tipo_documento_puesto_estado"].Value.ToString();
                id = datos.CurrentRow.Cells["tipo_documento_puesto_id"].Value.ToString();
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
                id = datos.CurrentRow.Cells["tipo_documento_puesto_id"].Value.ToString();
                objbll.Eliminar_Tipo_Documento_Puesto(id);
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
                Cls_Tipo_Documento_Puesto_BLL objnew = new Cls_Tipo_Documento_Puesto_BLL();
                datos.DataSource = objnew.Consultar_IdTipo_Documento_Puesto(txtid.Text);
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
