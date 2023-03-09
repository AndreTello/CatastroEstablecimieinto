using Microsoft.AspNetCore.Mvc;
using REST_CE.Datos.Catastro;
using REST_CE.Models.Catastro;

namespace REST_CE.Controllers.Catastro
{
    [ApiController]
    [Route("intervencion_tecnica_establecimiento")]
    public class Cls_Intervencion_Tecnica_Establecimiento_Controller:ControllerBase
    {
        Cls_Intervencion_Tecnica_Establecimiento_Da obj = new Cls_Intervencion_Tecnica_Establecimiento_Da();

        [HttpGet]
        [Route("listar")]
        public async Task<ActionResult<List<Cls_Intervencion_Tecnica_Establecimiento_Model>>> Get()
        {
            var function = new Cls_Intervencion_Tecnica_Establecimiento_Da();
            var lista = await function.Mostrar();
            return lista;
        }

        [HttpPost]
        [Route("guardar")]
        public async Task Post([FromBody] Cls_Intervencion_Tecnica_Establecimiento_Model obj)
        {
            var function = new Cls_Intervencion_Tecnica_Establecimiento_Da();
            await function.Insert(obj);
        }

        [HttpPut("edit/{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] Cls_Intervencion_Tecnica_Establecimiento_Model obj)
        {
            var function = new Cls_Intervencion_Tecnica_Establecimiento_Da();
            obj.intervencion_tecnica_establecimiento_id = id;
            await function.Update(obj);
            return NoContent();
        }

        [HttpDelete("delete/{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var function = new Cls_Intervencion_Tecnica_Establecimiento_Da();
            await function.Delete(id);
            return NoContent();
        }   
    }
}
