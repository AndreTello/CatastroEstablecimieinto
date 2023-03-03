using Microsoft.AspNetCore.Mvc;
using REST_CE.Datos;
using REST_CE.Models;

namespace REST_CE.Controllers
{
    [ApiController]
    [Route("documento_puesto")]
    public class Cls_Documento_Puesto_Controller: ControllerBase
    {
        [HttpGet]
        [Route("listar")]
        public async Task<ActionResult<List<Cls_Documento_Puesto_Model>>> Get()
        {
            var function = new Cls_Documento_Puesto();
            var lista = await function.MostrarProductos();
            return lista;
        }

        [HttpPost]
        [Route("guardar")]
        public async Task Post([FromBody] Cls_Documento_Puesto_Model obj)
        {
            var function = new Cls_Documento_Puesto();
            await function.Insert(obj);
        }

        [HttpPut("edit/{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] Cls_Documento_Puesto_Model obj)
        {
            var function = new Cls_Documento_Puesto();
            obj.DOCUMENTO_PUESTO_ID1 = id;
            await function.Edit(obj);
            return NoContent();
        }

        [HttpDelete("delete/{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var function = new Cls_Documento_Puesto();
            await function.Delete(id);
            return NoContent();
        }   
    }
}
