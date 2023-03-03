using Microsoft.AspNetCore.Mvc;
using REST_CE.Models;

using System.Data;
using Newtonsoft.Json;
using REST_CE.Datos;

namespace REST_CE.Controllers
{
    [ApiController]
    [Route("tipo_documento_puesto")]
    public class Cls_Tipo_Documento_Puesto_Controller : ControllerBase
    {
        
        [HttpGet]
        [Route("listar")]
        public async Task <ActionResult<List<Cls_Tipo_Documento_Puesto_Model>>> Get()
        {
            var function = new Cls_Tipo_Documento_Puesto();
            var lista =  await function.MostrarProductos();
            return lista;
        }

        [HttpPost]
        [Route("guardar")]
        public async Task Post([FromBody] Cls_Tipo_Documento_Puesto_Model obj)
        {
            var function = new Cls_Tipo_Documento_Puesto();
            await function.Insert(obj);
            
        }
        [HttpPut("edit/{id}")]
        public async Task <ActionResult>Put(int id, [FromBody] Cls_Tipo_Documento_Puesto_Model obj)
        {
            var function = new Cls_Tipo_Documento_Puesto();
            obj.TIPO_DOCUMENTO_PUESTO_ID1 = id;
            await function.Edit(obj);
            return NoContent();
        }

        [HttpDelete("delete/{id}")]
        public async Task <ActionResult> Delete(int id)
        {
            var function = new Cls_Tipo_Documento_Puesto();
            await function.Delete(id);
            return NoContent();
        }
    }

}
