using Npgsql;
using REST_CE.Models.Catastro;
using System.Data;

namespace REST_CE.Datos.Catastro
{
    public class Cls_Provincia_Da
    {
        Conexion.Conexion cn = new Conexion.Conexion();

        private readonly NpgsqlConnection _connection;
        public Cls_Provincia_Da()
        {
            _connection = new NpgsqlConnection(cn.getCadenaConexion());
        }
        public async Task<List<Cls_Provincia_Model>> MostrarProvincias()
        {
            List<Cls_Provincia_Model> lista = new List<Cls_Provincia_Model>();

            using (var cmd = new NpgsqlCommand("select * from catastroestablecimiento.cm_provincia", _connection))
            {
                await _connection.OpenAsync();
                using (var dr = await cmd.ExecuteReaderAsync())
                {
                    while (await dr.ReadAsync())
                    {
                        Cls_Provincia_Model obj = new Cls_Provincia_Model();
                        obj.provincia_id = dr.GetInt32(0);
                        obj.provincia_codigo = dr.GetString(1);
                        obj.provincia_nombre = dr.GetString(2);
                        obj.provincia_estado = dr.GetInt32(3);
                        obj.provincia_observacion = dr.GetString(4);
                        lista.Add(obj);
                    }
                }
            }
            await _connection.CloseAsync();
            return lista;
        }
        public async Task Insert(Cls_Provincia_Model obj)
        {
            using (var cmd = new NpgsqlCommand("insert into catastroestablecimiento.cm_provincia(provincia_codigo, provincia_nombre, provincia_estado, provincia_observacion) values (@provincia_codigo, @provincia_nombre, @provincia_estado, @provincia_observacion)", _connection))
            {
                cmd.Parameters.AddWithValue("provincia_codigo", obj.provincia_codigo);
                cmd.Parameters.AddWithValue("provincia_nombre", obj.provincia_nombre);
                cmd.Parameters.AddWithValue("provincia_estado", NpgsqlTypes.NpgsqlDbType.Integer, obj.provincia_estado);
                cmd.Parameters.AddWithValue("provincia_observacion", obj.provincia_observacion);
                await _connection.OpenAsync();
                await cmd.ExecuteNonQueryAsync();
            }
            await _connection.CloseAsync();
           
        }
        public async Task Edit(Cls_Provincia_Model obj)
        {

            using (var cmd = new NpgsqlCommand("update catastroestablecimiento.cm_provincia set provincia_codigo = @provincia_codigo, provincia_nombre = @provincia_nombre, provincia_observacion = @provincia_observacion, provincia_estado = @provincia_estado where provincia_id = @provincia_id", _connection))
            {
                cmd.Parameters.AddWithValue("provincia_codigo", obj.provincia_codigo);
                cmd.Parameters.AddWithValue("provincia_nombre", obj.provincia_nombre);
                cmd.Parameters.AddWithValue("provincia_observacion", obj.provincia_observacion);
                cmd.Parameters.AddWithValue("provincia_estado", obj.provincia_estado);
                cmd.Parameters.AddWithValue("provincia_id", obj.provincia_id);
                await _connection.OpenAsync();
                await cmd.ExecuteNonQueryAsync();

            }
            await _connection.CloseAsync();
        
        }
        public async Task Delete(int id)
        {
            using (var cmd = new NpgsqlCommand("delete from catastroestablecimiento.cm_provincia where provincia_id = @provincia_id", _connection))
            {
                cmd.Parameters.AddWithValue("provincia_id", id);
                await _connection.OpenAsync();
                await cmd.ExecuteNonQueryAsync();
            }
            await _connection.CloseAsync();
           
        }
    }
}
