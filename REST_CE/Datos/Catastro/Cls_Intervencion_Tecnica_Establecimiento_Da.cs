using Npgsql;
using REST_CE.Models.Catastro;
namespace REST_CE.Datos.Catastro
{
    public class Cls_Intervencion_Tecnica_Establecimiento_Da
    {
        Conexion.Conexion cn = new Conexion.Conexion();
        public async Task<List<Cls_Intervencion_Tecnica_Establecimiento_Model>> Mostrar()
        {
            var lista = new List<Cls_Intervencion_Tecnica_Establecimiento_Model>();
            using(var sql = new NpgsqlConnection(cn.getCadenaConexion()))
            {
                using(var cmd = new NpgsqlCommand("SELECT * FROM catastroestablecimiento.cm_intervencion_tecnica_establecimiento", sql))
                {
                    await sql.OpenAsync();
                    using (var dr = await cmd.ExecuteReaderAsync())
                    {
                        var obj = new Cls_Intervencion_Tecnica_Establecimiento_Model();
                        obj.intervencion_tecnica_establecimiento_id = dr.GetInt32(0);
                        obj.tipo_intervencion_tecnica_establecimiento_id = dr.GetInt32(1);
                        obj.intervencion_tecnica_establecimiento_nombre = dr.GetString(2);
                        obj.intervencion_tecnica_establecimiento_fecha_inicio = dr.GetString(3);
                        obj.intervencion_tecnica_establecimiento_fecha_fin = dr.GetString(4);
                        obj.intervencion_tecnica_establecimiento_estado = dr.GetInt32(5);
                        lista.Add(obj);
                    }
                }
            }
            return lista;
        }
        public async Task Insert(Cls_Intervencion_Tecnica_Establecimiento_Model obj)
        {
            using (var sql = new NpgsqlConnection(cn.getCadenaConexion()))
            {
                using (var cmd = new NpgsqlCommand("INSERT INTO catastroestablecimiento.cm_intervencion_tecnica_establecimiento(tipo_intervencion_tecnica_establecimiento_id, intervencion_tecnica_establecimiento_nombre, intervencion_tecnica_establecimiento_fecha_inicio, intervencion_tecnica_establecimiento_fecha_fin, intervencion_tecnica_establecimiento_estado) VALUES(@tipo_intervencion_tecnica_establecimiento_id, @intervencion_tecnica_establecimiento_nombre, @intervencion_tecnica_establecimiento_fecha_inicio, @intervencion_tecnica_establecimiento_fecha_fin, @intervencion_tecnica_establecimiento_estado)", sql))
                {
                    cmd.Parameters.AddWithValue("tipo_intervencion_tecnica_establecimiento_id", obj.tipo_intervencion_tecnica_establecimiento_id);
                    cmd.Parameters.AddWithValue("intervencion_tecnica_establecimiento_nombre", obj.intervencion_tecnica_establecimiento_nombre);
                    cmd.Parameters.AddWithValue("intervencion_tecnica_establecimiento_fecha_inicio", obj.intervencion_tecnica_establecimiento_fecha_inicio);
                    cmd.Parameters.AddWithValue("intervencion_tecnica_establecimiento_fecha_fin", obj.intervencion_tecnica_establecimiento_fecha_fin);
                    cmd.Parameters.AddWithValue("intervencion_tecnica_establecimiento_estado", obj.intervencion_tecnica_establecimiento_estado);
                    await sql.OpenAsync();
                    await cmd.ExecuteNonQueryAsync();
                }
            }
        }
        public async Task Update(Cls_Intervencion_Tecnica_Establecimiento_Model obj)
        {
            using (var sql = new NpgsqlConnection(cn.getCadenaConexion()))
            {
                using (var cmd = new NpgsqlCommand("UPDATE catastroestablecimiento.cm_intervencion_tecnica_establecimiento SET tipo_intervencion_tecnica_establecimiento_id = @tipo_intervencion_tecnica_establecimiento_id, intervencion_tecnica_establecimiento_nombre = @intervencion_tecnica_establecimiento_nombre, intervencion_tecnica_establecimiento_fecha_inicio = @intervencion_tecnica_establecimiento_fecha_inicio, intervencion_tecnica_establecimiento_fecha_fin = @intervencion_tecnica_establecimiento_fecha_fin, intervencion_tecnica_establecimiento_estado = @intervencion_tecnica_establecimiento_estado WHERE intervencion_tecnica_establecimiento_id = @intervencion_tecnica_establecimiento_id", sql))
                {
                    cmd.Parameters.AddWithValue("intervencion_tecnica_establecimiento_id", obj.intervencion_tecnica_establecimiento_id);
                    cmd.Parameters.AddWithValue("tipo_intervencion_tecnica_establecimiento_id", obj.tipo_intervencion_tecnica_establecimiento_id);
                    cmd.Parameters.AddWithValue("intervencion_tecnica_establecimiento_nombre", obj.intervencion_tecnica_establecimiento_nombre);
                    cmd.Parameters.AddWithValue("intervencion_tecnica_establecimiento_fecha_inicio", obj.intervencion_tecnica_establecimiento_fecha_inicio);
                    cmd.Parameters.AddWithValue("intervencion_tecnica_establecimiento_fecha_fin", obj.intervencion_tecnica_establecimiento_fecha_fin);
                    cmd.Parameters.AddWithValue("intervencion_tecnica_establecimiento_estado", obj.intervencion_tecnica_establecimiento_estado);
                    await sql.OpenAsync();
                    await cmd.ExecuteNonQueryAsync();
                }
            }
        }
        public async Task Delete(int obj)
        {
            using (var sql = new NpgsqlConnection(cn.getCadenaConexion()))
            {
                using (var cmd = new NpgsqlCommand("DELETE FROM catastroestablecimiento.cm_intervencion_tecnica_establecimiento WHERE intervencion_tecnica_establecimiento_id = @intervencion_tecnica_establecimiento_id", sql))
                {
                    cmd.Parameters.AddWithValue("intervencion_tecnica_establecimiento_id", obj);
                    await sql.OpenAsync();
                    await cmd.ExecuteNonQueryAsync();
                }
            }
        }

    }
}
