using Microsoft.AspNetCore.Mvc;
using REST_CE.Datos.Catastro;
using REST_CE.Models.Catastro;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace REST_CE.Controllers.Catastro
{
    [Route("Identificacion_Socio_Economica")]
    [ApiController]
    public class Cls_Identificacion_Socio_Economica_Controller : ControllerBase
    {
        Cls_Identificacion_Socio_Economica_Model obj = new Cls_Identificacion_Socio_Economica_Model();

        [HttpGet]
        [Route("listar")]
        public async Task<ActionResult<List<Cls_Identificacion_Socio_Economica_Model>>> Get()
        {
            var function = new Cls_Identificacion_Socio_Economica_Da();
            var lista = await function.MostrarProductos();
            return lista;
        }

        [HttpPost]
        [Route("guardar")]
        public async Task Post([FromBody] Cls_Identificacion_Socio_Economica_Model obj)
        {
            var function = new Cls_Identificacion_Socio_Economica_Da();
            await function.Insert(obj);
        }

        [HttpPut("edit/{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] Cls_Identificacion_Socio_Economica_Model obj)
        {
            var function = new Cls_Identificacion_Socio_Economica_Da();
            obj.identificacion_socio_economica_id = id;
            await function.Edit(obj);
            return NoContent();
        }

        [HttpDelete("delete/{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var function = new Cls_Puesto_Da();
            await function.Delete(id);
            return NoContent();
        }
    }
}
