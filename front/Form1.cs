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

namespace front
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        b_Libro objbll = new b_Libro();

        private void consulta_Click(object sender, EventArgs e)
        {
            MostrarLibros();
        }

        public void MostrarLibros()
        {
            b_Libro objnew = new b_Libro();
            data.DataSource = objnew.ConsultarRegistro();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            objbll.ConsultarRegistro();
        }
    }
}
