using Npgsql;
using REST_CE.Models.Catastro;

namespace REST_CE.Datos.Catastro
{
    public class Cls_Documento_Comerciante_Da
    {


        Conexion.Conexion cn = new Conexion.Conexion();
        public async Task<List<Cls_Documento_Comerciante_Model>> MostrarProductos()
        {
            var lista = new List<Cls_Documento_Comerciante_Model>();
            using (var sql = new NpgsqlConnection(cn.getCadenaConexion()))
            {
                using (var cmd = new NpgsqlCommand("SELECT * FROM  catastroestablecimiento.cm_documento_comerciante", sql))
                {
                    await sql.OpenAsync();
                    using (var dr = await cmd.ExecuteReaderAsync())
                    {
                        while (await dr.ReadAsync())
                        {
                            var obj = new Cls_Documento_Comerciante_Model();
                            obj.documento_comerciante_id = dr.GetInt32(0);
                            obj.tipo_documento_comerciante_id = dr.GetInt32(1);
                            obj.comerciante_id = dr.GetInt32(2);
                            obj.documento_comerciante_nombre = dr.GetString(3);
                            obj.documento_comerciante_fecha = dr.GetDateTime(4);
                            obj.documento_comerciante_archivo = dr.GetByte(5);
                            obj.documento_comerciante_detalle = dr.GetString(6);
                            obj.documento_comerciante_observacion = dr.GetString(5);
                            obj.documento_comerciante_estado = dr.GetInt32(6);
                    



                            lista.Add(obj);
                        }
                    }
                }
            }
            return lista;
        }

        public async Task Insert(Cls_Documento_Comerciante_Model obj)
        {
            using (var sql = new NpgsqlConnection(cn.getCadenaConexion()))
            {
                using (var cmd = new NpgsqlCommand("INSERT INTO catastroestablecimiento.cm_documento_comerciante(tipo_documento_comerciante_id,comerciante_id,documento_comerciante_nombre,documento_comerciante_fecha,documento_comerciante_archivo,documento_comerciante_detalle,documento_comerciante_observacion,documento_comerciante_estado) VALUES(@tipo_documento_comerciante_id,@comerciante_id,@documento_comerciante_nombre,@documento_comerciante_fecha,@documento_comerciante_archivo,@documento_comerciante_detalle,@documento_comerciante_observacion,@documento_comerciante_estado)", sql))
                {
                    cmd.Parameters.AddWithValue("tipo_documento_comerciante_id", obj.tipo_documento_comerciante_id);
                    cmd.Parameters.AddWithValue("comerciante_id", obj.comerciante_id);
                    cmd.Parameters.AddWithValue("documento_comerciante_nombre", obj.documento_comerciante_nombre);
                    cmd.Parameters.AddWithValue("documento_comerciante_fecha", obj.documento_comerciante_fecha);
                    cmd.Parameters.AddWithValue("documento_comerciante_archivo", obj.documento_comerciante_archivo);
                    cmd.Parameters.AddWithValue("documento_comerciante_detalle", obj.documento_comerciante_detalle);

                    cmd.Parameters.AddWithValue("documento_comerciante_observacion", obj.documento_comerciante_observacion);
                    cmd.Parameters.AddWithValue("documento_comerciante_estado", obj.documento_comerciante_estado);


                    await sql.OpenAsync();
                    await cmd.ExecuteNonQueryAsync();
                }
            }
        }


        public async Task Edit(Cls_Documento_Comerciante_Model obj)
        {
            using (var sql = new NpgsqlConnection(cn.getCadenaConexion()))
            {
                using (var cmd = new NpgsqlCommand("UPDATE catastroestablecimiento.cm_documento_comerciante SET  tipo_documento_comerciante_id= @tipo_documento_comerciante_id,comerciante_id=@comerciante_id,documento_comerciante_nombre=@documento_comerciante_nombre,documento_comerciante_fecha=@documento_comerciante_fecha,documento_comerciante_archivo=@documento_comerciante_archivo,documento_comerciante_detalle=@documento_comerciante_detalle,documento_comerciante_observacion=@documento_comerciante_observacion,documento_comerciante_estado=@documento_comerciante_estado     WHERE documento_comerciante_id = @documento_comerciante_id", sql))
                {
                    cmd.Parameters.AddWithValue("documento_comerciante_id", obj.documento_comerciante_id);
                    cmd.Parameters.AddWithValue("tipo_documento_comerciante_id", obj.tipo_documento_comerciante_id);
                    cmd.Parameters.AddWithValue("comerciante_id", obj.comerciante_id);
                    cmd.Parameters.AddWithValue("documento_comerciante_nombre", obj.documento_comerciante_nombre);
                    cmd.Parameters.AddWithValue("documento_comerciante_fecha", obj.documento_comerciante_fecha);
                    cmd.Parameters.AddWithValue("documento_comerciante_archivo", obj.documento_comerciante_archivo);
                    cmd.Parameters.AddWithValue("documento_comerciante_detalle", obj.documento_comerciante_detalle);

                    cmd.Parameters.AddWithValue("documento_comerciante_observacion", obj.documento_comerciante_observacion);
                    cmd.Parameters.AddWithValue("documento_comerciante_estado", obj.documento_comerciante_estado);

                    await sql.OpenAsync();
                    await cmd.ExecuteNonQueryAsync();
                }
            }
        }

        public async Task Delete(int id)
        {
            using (var sql = new NpgsqlConnection(cn.getCadenaConexion()))
            {
                using (var cmd = new NpgsqlCommand("DELETE FROM catastroestablecimiento.cm_documento_comerciante WHERE documento_comerciante_id = @documento_comerciante_id", sql))
                {
                    cmd.Parameters.AddWithValue("documento_comerciante_id", id);
                    await sql.OpenAsync();
                    await cmd.ExecuteNonQueryAsync();
                }
            }
        }
    }
}
