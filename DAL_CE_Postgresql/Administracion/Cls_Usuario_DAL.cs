using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace DAL_CE_Postgresql.Administracion
{
    public class Cls_Usuario_DAL
    {
        private int USUARIO_ID;
        private int ROL_ID;
        private string USUARIO_LOGIN;
        private string USUARIO_CLAVE;
        private string USUARIO_CEDULA;
        private string USUARIO_APELLIDOS;
        private string USUARIO_NOMBRES;
        private string USUARIO_MAIL;
        private string USUARIO_DIRECCION;
        private string USUARO_TELEFONO;
        private int USUARIO_ESTADO;

        public int USUARIO_ID1 { get => USUARIO_ID; set => USUARIO_ID = value; }
        public int ROL_ID1 { get => ROL_ID; set => ROL_ID = value; }
        public string USUARIO_LOGIN1 { get => USUARIO_LOGIN; set => USUARIO_LOGIN = value; }
        public string USUARIO_CLAVE1 { get => USUARIO_CLAVE; set => USUARIO_CLAVE = value; }
        public string USUARIO_CEDULA1 { get => USUARIO_CEDULA; set => USUARIO_CEDULA = value; }
        public string USUARIO_APELLIDOS1 { get => USUARIO_APELLIDOS; set => USUARIO_APELLIDOS = value; }
        public string USUARIO_NOMBRES1 { get => USUARIO_NOMBRES; set => USUARIO_NOMBRES = value; }
        public string USUARIO_MAIL1 { get => USUARIO_MAIL; set => USUARIO_MAIL = value; }
        public string USUARIO_DIRECCION1 { get => USUARIO_DIRECCION; set => USUARIO_DIRECCION = value; }
        public string USUARO_TELEFONO1 { get => USUARO_TELEFONO; set => USUARO_TELEFONO = value; }
        public int USUARIO_ESTADO1 { get => USUARIO_ESTADO; set => USUARIO_ESTADO = value; }

        public void Ingresar_Usuario()
        {
            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show("A OCURRIDO UN ERROR:  " + ex);
            }
            finally
            {

            }
        }
        public void Consultar_Usuario()
        {
            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show("A OCURRIDO UN ERROR:  "+ex);
            }
            finally
            {

            }
        }
        public void Modificar_Usuario()
        {
            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show("A OCURRIDO UN ERROR:  " + ex);
            }
            finally
            {

            }
        }
        public void Eliminar_Usuario()
        {
            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show("A OCURRIDO UN ERROR:  " + ex);
            }
            finally
            {

            }
        }
    }
}
