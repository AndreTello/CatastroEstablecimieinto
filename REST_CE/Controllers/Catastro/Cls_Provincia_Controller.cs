
using Microsoft.AspNetCore.Mvc;
using REST_CE.Datos.Catastro;
using REST_CE.Models.Catastro;

namespace REST_CE.Controllers.Catastro
{
    [ApiController]
    [Route("provincia")]
    public class Cls_Provincia_Controller: ControllerBase
    {
        Cls_Provincia_Da obj = new Cls_Provincia_Da();

        [HttpGet]
        [Route("listar")]
        public async Task<ActionResult<List<Cls_Provincia_Model>>> Get()
        {
            var function = new Cls_Provincia_Da();
            var lista = await function.MostrarProvincias();
            
            return lista;
        }

        [HttpPost]
        [Route("guardar")]
        public async Task Post([FromBody] Cls_Provincia_Model obj)
        {
            var function = new Cls_Provincia_Da();
            await function.Insert(obj);
        }

        [HttpPut("edit/{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] Cls_Provincia_Model obj)
        {
            var function = new Cls_Provincia_Da();
            obj.provincia_id = id;
            await function.Edit(obj);
            return NoContent();
        }

        [HttpDelete("delete/{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var function = new Cls_Provincia_Da();
            await function.Delete(id);
            return NoContent();
        }
    }
}
