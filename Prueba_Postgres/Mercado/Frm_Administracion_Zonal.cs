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
    public partial class Frm_Administracion_Zonal : Form
    {
        public Frm_Administracion_Zonal()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void cmbestado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Volver_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }

        private void Frm_Administracion_Zonal_Load(object sender, EventArgs e)
        {
            cmbestado.Items.Add("0");
            cmbestado.Items.Add("1");
            cmbestado.SelectedIndex = 0;
            Mostrar_Datos();
        }

        Cls_Administracion_Zonal_BLL objbll = new Cls_Administracion_Zonal_BLL();

        private string id = null;
        private bool editar = false;

        public void Mostrar_Datos()
        {
            Cls_Administracion_Zonal_BLL objnew = new Cls_Administracion_Zonal_BLL();
            datos.DataSource = objnew.Consultar_Administracion_Zonal();
        }

        public void Limpiar()
        {
            txtnombre.Text = string.Empty;
            txtdetalle.Text = string.Empty;
            txttelefono.Text = string.Empty;
            txtcelular.Text = string.Empty;
            txtmail.Text = string.Empty;
            txtpweb.Text = string.Empty;
            txtrepresentante.Text = string.Empty;
            cmbestado.SelectedIndex = 0;
        }

        private void Consultar_Click(object sender, EventArgs e)
        {
            if (txtid.Text == "")
            {
                MessageBox.Show("Ingrese el id a buscar");
            }
            else
            {
                Cls_Administracion_Zonal_BLL objnew = new Cls_Administracion_Zonal_BLL();
                datos.DataSource = objnew.Consultar_IdAdministracion_Zonal(txtid.Text);
                txtid.Text = string.Empty;
            }
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            if (editar == false)
            {
                objbll.Insertar_Administracion_Zonal(txtnombre.Text, txtdetalle.Text, txttelefono.Text, txtcelular.Text, txtmail.Text, txtpweb.Text, txtrepresentante.Text, cmbestado.Text);
                MessageBox.Show("REGISTRADO CORRECTAMENTE");
                Mostrar_Datos();
                Limpiar();
            }
            if (editar == true)
            {
                objbll.Editar_Administracion_Zonal(txtnombre.Text, txtdetalle.Text, txttelefono.Text, txtcelular.Text, txtmail.Text, txtpweb.Text, txtrepresentante.Text, cmbestado.Text, id);
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
                txtnombre.Text = datos.CurrentRow.Cells["administracion_zonal_nombre"].Value.ToString();
                txtdetalle.Text = datos.CurrentRow.Cells["administracion_zonal_detalle"].Value.ToString();
                txttelefono.Text = datos.CurrentRow.Cells["administracion_zonal_telefono"].Value.ToString();
                txtcelular.Text = datos.CurrentRow.Cells["administracion_zonal_celular"].Value.ToString();
                txtmail.Text = datos.CurrentRow.Cells["administracion_zonal_mail"].Value.ToString();
                txtpweb.Text = datos.CurrentRow.Cells["administracion_zonal_pagina_web"].Value.ToString();
                txtrepresentante.Text = datos.CurrentRow.Cells["administracion_zonal_representante"].Value.ToString();
                cmbestado.Text = datos.CurrentRow.Cells["administracion_zonal_estado"].Value.ToString();
                id = datos.CurrentRow.Cells["administracion_zonal_id"].Value.ToString();
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
                id = datos.CurrentRow.Cells["administracion_zonal_id"].Value.ToString();
                objbll.Eliminar_Administracion_Zonal(id);
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
