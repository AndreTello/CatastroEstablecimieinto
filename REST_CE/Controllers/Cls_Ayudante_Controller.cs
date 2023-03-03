using Microsoft.AspNetCore.Mvc;
using REST_CE.Datos;
using REST_CE.Models;

namespace REST_CE.Controllers
{

    [ApiController]
    [Route("ayudante")]
    public class Cls_Ayudante_Controller : ControllerBase
    {
        Cls_Ayudante obj = new Cls_Ayudante();

        [HttpGet]
        [Route("listar")]
        public async Task<ActionResult<List<Cls_Ayudante_Model>>> Get()
        {
            var function = new Cls_Ayudante();
            var lista = await function.MostrarProductos();
            return lista;
        }

        [HttpPost]
        [Route("guardar")]
        public async Task Post([FromBody] Cls_Ayudante_Model obj)
        {
            var function = new Cls_Ayudante();
            await function.Insert(obj);
        }

        [HttpPut("edit/{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] Cls_Ayudante_Model obj)
        {
            var function = new Cls_Ayudante();
            obj.ayudante_id = id;
            await function.Edit(obj);
            return NoContent();
        }

        [HttpDelete("delete/{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var function = new Cls_Ayudante();
            await function.Delete(id);
            return NoContent();
        }

    }
}
