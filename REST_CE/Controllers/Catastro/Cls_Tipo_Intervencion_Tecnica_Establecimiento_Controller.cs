using Microsoft.AspNetCore.Mvc;
using REST_CE.Datos.Catastro;
using REST_CE.Models.Catastro;
namespace REST_CE.Controllers.Catastro
{
    [ApiController]
    [Route("tipo_intervencion_tecnica_establecimiento")]
    public class Cls_Tipo_Intervencion_Tecnica_Establecimiento_Controller: ControllerBase
    {
        Cls_Tipo_Intervencion_Tecnica_Establecimiento_Da obj = new Cls_Tipo_Intervencion_Tecnica_Establecimiento_Da();
        [HttpGet]
        [Route("listar")]
        public async Task<ActionResult<List<Cls_Tipo_Intervencion_Tecnica_Establecimiento_Model>>> Get()
        {
            var function = new Cls_Tipo_Intervencion_Tecnica_Establecimiento_Da();
            var lista = await function.MostrarProductos();
            return lista;
        }
        [HttpPost]
        [Route("guardar")]
        public async Task Post([FromBody] Cls_Tipo_Intervencion_Tecnica_Establecimiento_Model obj)
        {
            var function = new Cls_Tipo_Intervencion_Tecnica_Establecimiento_Da();
            await function.Insert(obj);
        }
        [HttpPut("edit/{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] Cls_Tipo_Intervencion_Tecnica_Establecimiento_Model obj)
        {
            var function = new Cls_Tipo_Intervencion_Tecnica_Establecimiento_Da();
            obj.tipo_intervencion_tecnica_establecimiento_id = id;
            await function.Edit(obj);
            return NoContent();
        }
        [HttpDelete("delete/{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var function = new Cls_Tipo_Intervencion_Tecnica_Establecimiento_Da();
            await function.Delete(id);
            return NoContent();
        }
    }
}
