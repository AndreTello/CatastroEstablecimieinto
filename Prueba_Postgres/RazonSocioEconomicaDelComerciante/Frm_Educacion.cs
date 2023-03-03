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
    public partial class Frm_Educacion : Form
    {
        public Frm_Educacion()
        {
            InitializeComponent();
        }

        private void Volver_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();    
        }

        private void Frm_Educacion_Load(object sender, EventArgs e)
        {
            cmbestado.Items.Add("0");
            cmbestado.Items.Add("1");
            cmbestado.SelectedIndex = 0;
            Mostrar_Datos();
        }

        Cls_Nivel_Educacion_BLL objbll = new Cls_Nivel_Educacion_BLL();

        private string id = null;
        private bool editar = false;

        public void Mostrar_Datos()
        {
            Cls_Nivel_Educacion_BLL objnew = new Cls_Nivel_Educacion_BLL();
            datos.DataSource = objnew.Consultar_Nivel_Educacion();
        }

        public void Limpiar()
        {
            txtnombre.Text = string.Empty;
            txtdetalle.Text = string.Empty;
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

                objbll.Insertar_Nivel_Educacion(txtnombre.Text, txtdetalle.Text, cmbestado.Text);
                MessageBox.Show("REGISTRADO CORRECTAMENTE");
                Mostrar_Datos();
                Limpiar();

            }
            if (editar == true)
            {
                objbll.Editar_Nivel_Educacion(txtnombre.Text, txtdetalle.Text, cmbestado.Text, id);
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
                txtnombre.Text = datos.CurrentRow.Cells["nivel_educacion_nombre"].Value.ToString();
                txtdetalle.Text = datos.CurrentRow.Cells["nivel_educacion_detalle"].Value.ToString();
                cmbestado.Text = datos.CurrentRow.Cells["nivel_educacion_estado"].Value.ToString();
                id = datos.CurrentRow.Cells["nivel_educacion_id"].Value.ToString();
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
                id = datos.CurrentRow.Cells["nivel_educacion_id"].Value.ToString();
                objbll.Eliminar_Nivel_Educacion(id);
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
                Cls_Nivel_Educacion_BLL objnew = new Cls_Nivel_Educacion_BLL();
                datos.DataSource = objnew.Consultar_IdNivel_Educacion(txtid.Text);
                txtid.Text = string.Empty;
            }
        }
    }
}
