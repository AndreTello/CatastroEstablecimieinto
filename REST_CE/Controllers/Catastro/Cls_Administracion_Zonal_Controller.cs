using Microsoft.AspNetCore.Mvc;
using REST_CE.Datos.Catastro;
using REST_CE.Models.Catastro;
namespace REST_CE.Controllers.Catastro
{

    [ApiController]
    [Route("administracion_zonal")]
    public class Cls_Administracion_Zonal_Controller : ControllerBase
    {
        Cls_Administracion_Zonal_Da obj = new Cls_Administracion_Zonal_Da();

        [HttpGet]
        [Route("listar")]
        public async Task<ActionResult<List<Cls_Administracion_Zonal_Model>>> Get()
        {
            var function = new Cls_Administracion_Zonal_Da();
            var lista = await function.MostrarProductos();
            return lista;
        }

        [HttpPost]
        [Route("guardar")]
        public async Task Post([FromBody] Cls_Administracion_Zonal_Model obj)
        {
            var function = new Cls_Administracion_Zonal_Da();
            await function.Insert(obj);
        }

        [HttpPut("edit/{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] Cls_Administracion_Zonal_Model obj)
        {
            var function = new Cls_Administracion_Zonal_Da();
            obj.administracion_zonal_id = id;
            await function.Update(obj);
            return NoContent();
        }

        [HttpDelete("delete/{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var function = new Cls_Administracion_Zonal_Da();
            await function.Delete(id);
            return NoContent();
        }

    }
}

