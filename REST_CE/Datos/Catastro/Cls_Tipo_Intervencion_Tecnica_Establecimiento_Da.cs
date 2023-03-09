using Npgsql;
using REST_CE.Models.Catastro;
namespace REST_CE.Datos.Catastro
{
    public class Cls_Tipo_Intervencion_Tecnica_Establecimiento_Da
    {
        Conexion.Conexion cn = new Conexion.Conexion();
        public async Task<List<Cls_Tipo_Intervencion_Tecnica_Establecimiento_Model>> MostrarProductos()
        {
            var lista = new List<Cls_Tipo_Intervencion_Tecnica_Establecimiento_Model>();
            using(var sql = new NpgsqlConnection(cn.getCadenaConexion()))
            {
                using(var cmd = new NpgsqlCommand("SELECT * FROM tipo_intervencion_tecnica_establecimiento", sql))
                {
                    await sql.OpenAsync();
                    using(var dr = await cmd.ExecuteReaderAsync())
                    {
                        while(await dr.ReadAsync())
                        {
                            var obj = new Cls_Tipo_Intervencion_Tecnica_Establecimiento_Model();
                            obj.tipo_intervencion_tecnica_establecimiento_id = dr.GetInt32(0);
                            obj.tipo_intervencion_tecnica_establecimiento_nombre = dr.GetString(1);
                            obj.tipo_intervencion_tecnica_establecimiento_detalle = dr.GetString(2);
                            obj.tipo_intervencion_tecnica_establecimiento_estado = dr.GetInt32(3);
                            lista.Add(obj);
                        }
                    }
                }
            }
            return lista;
        }
        public async Task Insert(Cls_Tipo_Intervencion_Tecnica_Establecimiento_Model obj)
        {
            using(var sql = new NpgsqlConnection(cn.getCadenaConexion()))
            {
                using(var cmd = new NpgsqlCommand("INSERT INTO tipo_intervencion_tecnica_establecimiento(tipo_intervencion_tecnica_establecimiento_nombre, tipo_intervencion_tecnica_establecimiento_detalle, tipo_intervencion_tecnica_establecimiento_estado) VALUES(@tipo_intervencion_tecnica_establecimiento_nombre, @tipo_intervencion_tecnica_establecimiento_detalle, @tipo_intervencion_tecnica_establecimiento_estado)", sql))
                {
                    cmd.Parameters.AddWithValue("tipo_intervencion_tecnica_establecimiento_nombre", obj.tipo_intervencion_tecnica_establecimiento_nombre);
                    cmd.Parameters.AddWithValue("tipo_intervencion_tecnica_establecimiento_detalle", obj.tipo_intervencion_tecnica_establecimiento_detalle);
                    cmd.Parameters.AddWithValue("tipo_intervencion_tecnica_establecimiento_estado", obj.tipo_intervencion_tecnica_establecimiento_estado);
                    await sql.OpenAsync();
                    await cmd.ExecuteNonQueryAsync();
                }
            }
        }
        public async Task Edit(Cls_Tipo_Intervencion_Tecnica_Establecimiento_Model obj)
        {
            using(var sql = new NpgsqlConnection(cn.getCadenaConexion()))
            {
                using(var cmd = new NpgsqlCommand("UPDATE tipo_intervencion_tecnica_establecimiento SET tipo_intervencion_tecnica_establecimiento_nombre = @tipo_intervencion_tecnica_establecimiento_nombre, tipo_intervencion_tecnica_establecimiento_detalle = @tipo_intervencion_tecnica_establecimiento_detalle, tipo_intervencion_tecnica_establecimiento_estado = @tipo_intervencion_tecnica_establecimiento_estado WHERE tipo_intervencion_tecnica_establecimiento_id = @tipo_intervencion_tecnica_establecimiento_id", sql))
                {
                    cmd.Parameters.AddWithValue("tipo_intervencion_tecnica_establecimiento_id", obj.tipo_intervencion_tecnica_establecimiento_id);
                    cmd.Parameters.AddWithValue("tipo_intervencion_tecnica_establecimiento_nombre", obj.tipo_intervencion_tecnica_establecimiento_nombre);
                    cmd.Parameters.AddWithValue("tipo_intervencion_tecnica_establecimiento_detalle", obj.tipo_intervencion_tecnica_establecimiento_detalle);
                    cmd.Parameters.AddWithValue("tipo_intervencion_tecnica_establecimiento_estado", obj.tipo_intervencion_tecnica_establecimiento_estado);
                    await sql.OpenAsync();
                    await cmd.ExecuteNonQueryAsync();
                }
            }
        }
        public async Task Delete(int obj)
        {
            using(var sql = new NpgsqlConnection(cn.getCadenaConexion()))
            {
                using(var cmd = new NpgsqlCommand("DELETE FROM tipo_intervencion_tecnica_establecimiento WHERE tipo_intervencion_tecnica_establecimiento_id = @tipo_intervencion_tecnica_establecimiento_id", sql))
                {
                    cmd.Parameters.AddWithValue("tipo_intervencion_tecnica_establecimiento_id", obj);
                    await sql.OpenAsync();
                    await cmd.ExecuteNonQueryAsync();
                }
            }
        }
    }
}
