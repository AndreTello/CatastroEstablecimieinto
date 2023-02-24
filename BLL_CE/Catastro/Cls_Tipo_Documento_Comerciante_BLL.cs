﻿using DAL_CE_Postgresql.Catastro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_CE.Catastro
{
    public class Cls_Tipo_Documento_Comerciante_BLL
    {
        Cls_Tipo_Documento_Comerciante_DAL objdll = new Cls_Tipo_Documento_Comerciante_DAL();

        public void Consultar()
        {
            objdll.Consultar_Tipo_Documento_Comerciante();
        }

        public void Insertar()
        {
            objdll.Ingresar_Tipo_Documento_Comerciante();
        }

        public void Editar()
        {
            objdll.Modificar_Tipo_Documento_Comerciante();
        }

        public void Eliminar()
        {
            objdll.Eliminar_Tipo_Documento_Comerciante();
        }

    }
}