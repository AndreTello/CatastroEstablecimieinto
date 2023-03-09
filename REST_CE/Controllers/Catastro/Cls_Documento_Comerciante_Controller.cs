using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using REST_CE.Datos.Catastro;
using REST_CE.Models.Catastro;

namespace REST_CE.Controllers.Catastro
{
    [Route("documento_comerciante")]
    [ApiController]
    public class Cls_Documento_Comerciante_Controller : ControllerBase
    {
        Cls_Documento_Comerciante_Model obj = new Cls_Documento_Comerciante_Model();

        [HttpGet]
        [Route("listar")]
        public async Task<ActionResult<List<Cls_Documento_Comerciante_Model>>> Get()
        {
            var function = new Cls_Documento_Comerciante_Da();
            var lista = await function.MostrarProductos();
            return lista;
        }

        [HttpPost]
        [Route("guardar")]
        public async Task Post([FromBody] Cls_Documento_Comerciante_Model obj)
        {
            var function = new Cls_Documento_Comerciante_Da();
            await function.Insert(obj);
        }

        [HttpPut("edit/{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] Cls_Documento_Comerciante_Model obj)
        {
            var function = new Cls_Documento_Comerciante_Da();
            obj.documento_comerciante_id = id;
            await function.Edit(obj);
            return NoContent();
        }

        [HttpDelete("delete/{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var function = new Cls_Documento_Comerciante_Da();
            await function.Delete(id);
            return NoContent();
        }







    }
}
