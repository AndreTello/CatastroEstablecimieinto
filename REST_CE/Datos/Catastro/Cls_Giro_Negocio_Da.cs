using Npgsql;
using REST_CE.Models.Catastro;
using System.Data;

namespace REST_CE.Datos.Catastro
{
    public class Cls_Giro_Negocio_Da
    {
        Conexion.Conexion cn = new Conexion.Conexion();
        public async Task<List<Cls_Giro_Negocio_Model>> MostrarProductos()
        {
            var lista = new List<Cls_Giro_Negocio_Model>();
            using (var sql = new NpgsqlConnection(cn.getCadenaConexion()))
            {
                using (var cmd = new NpgsqlCommand("SELECT * FROM  catastroestablecimiento.cm_giro_negocio", sql))
                {
                    await sql.OpenAsync();
                    using (var dr = await cmd.ExecuteReaderAsync())
                    {
                        while (await dr.ReadAsync())
                        {
                            var obj = new Cls_Giro_Negocio_Model();
                            obj.giro_negocio_id = dr.GetInt32(0);
                            obj.tipo_producto_id = dr.GetInt32(1);
                            obj.giro_negocio_nombre = dr.GetString(2);
                            obj.giro_negocio_subgiro = dr.GetString(3);
                            obj.giro_negocio_abastecimiento = dr.GetString(4);
                            obj.giro_negocio_observacion = dr.GetString(5);
                            obj.giro_negocio_estado = dr.GetInt32(6);
;

                      

                            lista.Add(obj);
                        }
                    }
                }
            }
            return lista;
        }

        public async Task Insert(Cls_Giro_Negocio_Model obj)
        {
            using (var sql = new NpgsqlConnection(cn.getCadenaConexion()))
            {
                using (var cmd = new NpgsqlCommand("INSERT INTO catastroestablecimiento.cm_giro_negocio(tipo_producto_id,giro_negocio_nombre,giro_negocio_subgiro,giro_negocio_abastecimiento,giro_negocio_observacion,giro_negocio_estado) VALUES(@tipo_producto_id,@giro_negocio_nombre,@giro_negocio_subgiro,@giro_negocio_abastecimiento,@giro_negocio_observacion,@giro_negocio_estado)", sql))
                {
                    cmd.Parameters.AddWithValue("tipo_producto_id", obj.tipo_producto_id);
                    cmd.Parameters.AddWithValue("giro_negocio_nombre", obj.giro_negocio_nombre);
                    cmd.Parameters.AddWithValue("giro_negocio_subgiro", obj.giro_negocio_subgiro);
                    cmd.Parameters.AddWithValue("giro_negocio_abastecimiento", obj.giro_negocio_abastecimiento);
                    cmd.Parameters.AddWithValue("giro_negocio_observacion", obj.giro_negocio_observacion);
                    cmd.Parameters.AddWithValue("giro_negocio_estado", obj.giro_negocio_estado);
          
                 
                 
                    await sql.OpenAsync();
                    await cmd.ExecuteNonQueryAsync();
                }
            }
        }


        public async Task Edit(Cls_Giro_Negocio_Model obj)
        {
            using (var sql = new NpgsqlConnection(cn.getCadenaConexion()))
            {
                using (var cmd = new NpgsqlCommand("UPDATE catastroestablecimiento.cm_giro_negocio SET  tipo_producto_id=@tipo_producto_id,giro_negocio_nombre=@giro_negocio_nombre,giro_negocio_subgiro=@giro_negocio_subgiro,giro_negocio_abastecimiento=@giro_negocio_abastecimiento,giro_negocio_observacion=@giro_negocio_observacion,giro_negocio_estado=@giro_negocio_estado     WHERE tipo_producto_id = @tipo_producto_id", sql))
                {
                    cmd.Parameters.AddWithValue("tipo_producto_id", obj.tipo_producto_id);
                    cmd.Parameters.AddWithValue("giro_negocio_nombre", obj.giro_negocio_nombre);
                    cmd.Parameters.AddWithValue("giro_negocio_subgiro", obj.giro_negocio_subgiro);
                    cmd.Parameters.AddWithValue("giro_negocio_abastecimiento", obj.giro_negocio_abastecimiento);
                    cmd.Parameters.AddWithValue("giro_negocio_observacion", obj.giro_negocio_observacion);
                    cmd.Parameters.AddWithValue("giro_negocio_estado", obj.giro_negocio_estado);

                    await sql.OpenAsync();
                    await cmd.ExecuteNonQueryAsync();
                }
            }
        }

        public async Task Delete(int id)
        {
            using (var sql = new NpgsqlConnection(cn.getCadenaConexion()))
            {
                using (var cmd = new NpgsqlCommand("DELETE FROM catastroestablecimiento.cm_giro_negocio WHERE tipo_producto_id = @tipo_producto_id", sql))
                {
                    cmd.Parameters.AddWithValue("tipo_producto_id", id);
                    await sql.OpenAsync();
                    await cmd.ExecuteNonQueryAsync();
                }
            }
        }
    }
}
