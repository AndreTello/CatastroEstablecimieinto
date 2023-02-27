using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL_CE;
using BLL_CE.Catastro;

namespace Prueba_Postgres
{
    public partial class Frm_Tipos_Producto : Form
    {
        public Frm_Tipos_Producto()
        {
            InitializeComponent();
        }

        

        private void Frm_Tipos_Producto_Load(object sender, EventArgs e)
        {
            
        }

        private void Guardar_Click(object sender, EventArgs e)
        {

        }

        private void Consultar_Click(object sender, EventArgs e)
        {
            Mostrar_Datos();
        }

        public void Mostrar_Datos()
        {
            
           // datos.DataSource = con.Consultar_Tipos_Producto();
        }
    }
}
