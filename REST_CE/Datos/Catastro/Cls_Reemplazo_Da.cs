using Npgsql;
using REST_CE.Models.Catastro;
using System.Data;

namespace REST_CE.Datos.Catastro
{
    public class Cls_Reemplazo_Da
    {
       
            Conexion.Conexion cn = new Conexion.Conexion();
            public async Task<List<Cls_Reemplazo_Model>> MostrarProductos()
            {
                var lista = new List<Cls_Reemplazo_Model>();
                using (var sql = new NpgsqlConnection(cn.getCadenaConexion()))
                {
                    using (var cmd = new NpgsqlCommand("SELECT * FROM  catastroestablecimiento.cm_reemplazo", sql))
                    {
                        await sql.OpenAsync();
                        using (var dr = await cmd.ExecuteReaderAsync())
                        {
                            while (await dr.ReadAsync())
                            {
                                var obj = new Cls_Reemplazo_Model();
                                obj.reemplazo_id = dr.GetInt32(0);
                                obj.reemplazo_cedula = dr.GetString(1);
                                obj.reemplazo_apellidos = dr.GetString(2);
                                obj.reemplazo_nombres = dr.GetString(3);
                                obj.reemplazo_autorizacion = dr.GetString(4);
                                obj.reemplazo_numero_oficio = dr.GetString(5);
                                obj.reemplazo_fecha_inicio = dr.GetDateTime(6);

                                obj.reemplazo_fecha_fin = dr.GetDateTime(7);
                                obj.reemplazo_estado = dr.GetInt32(8);
                                
                                lista.Add(obj);
                            }
                        }
                    }
                }
                return lista;
            }

            public async Task Insert(Cls_Reemplazo_Model obj)
            {
                using (var sql = new NpgsqlConnection(cn.getCadenaConexion()))
                {
                    using (var cmd = new NpgsqlCommand("INSERT INTO catastroestablecimiento.cm_reemplazo( reemplazo_cedula, reemplazo_apellidos, reemplazo_nombres, reemplazo_autorizacion,reemplazo_numero_oficio,reemplazo_fecha_inicio,reemplazo_fecha_fin,reemplazo_estado ) VALUES( @reemplazo_cedula, @reemplazo_apellidos, @reemplazo_nombres, @reemplazo_autorizacion,@reemplazo_numero_oficio,@reemplazo_fecha_inicio,@reemplazo_fecha_fin,@reemplazo_estado)", sql))
                    {
                        cmd.Parameters.AddWithValue("reemplazo_cedula", obj.reemplazo_cedula);
                        cmd.Parameters.AddWithValue("reemplazo_apellidos", obj.reemplazo_apellidos);
                        cmd.Parameters.AddWithValue("reemplazo_nombres", obj.reemplazo_nombres);
                        cmd.Parameters.AddWithValue("reemplazo_autorizacion", obj.reemplazo_autorizacion);
                        cmd.Parameters.AddWithValue("reemplazo_numero_oficio", obj.reemplazo_numero_oficio);
                        cmd.Parameters.AddWithValue("reemplazo_fecha_inicio", obj.reemplazo_fecha_inicio);
                        cmd.Parameters.AddWithValue("reemplazo_fecha_fin", obj.reemplazo_fecha_fin);
                        cmd.Parameters.AddWithValue("reemplazo_estado", obj.reemplazo_estado);


                
                        await sql.OpenAsync();
                        await cmd.ExecuteNonQueryAsync();
                    }
                }
            }


            public async Task Edit(Cls_Reemplazo_Model obj)
            {
                using (var sql = new NpgsqlConnection(cn.getCadenaConexion()))
                {
                    using (var cmd = new NpgsqlCommand("UPDATE catastroestablecimiento.cm_reemplazo SET reemplazo_cedula=@reemplazo_cedula, reemplazo_apellidos=@reemplazo_apellidos, reemplazo_nombres=@reemplazo_nombres, reemplazo_autorizacion=@reemplazo_autorizacion,reemplazo_numero_oficio=@reemplazo_numero_oficio,reemplazo_fecha_inicio=@reemplazo_fecha_inicio,reemplazo_fecha_fin=@reemplazo_fecha_fin,reemplazo_estado=@reemplazo_estado WHERE reemplazo_id = @reemplazo_id", sql))
                    {
                        cmd.Parameters.AddWithValue("reemplazo_id", obj.reemplazo_id);
                        cmd.Parameters.AddWithValue("reemplazo_cedula", obj.reemplazo_cedula);
                        cmd.Parameters.AddWithValue("reemplazo_apellidos", obj.reemplazo_apellidos);
                        cmd.Parameters.AddWithValue("reemplazo_nombres", obj.reemplazo_nombres);
                        cmd.Parameters.AddWithValue("reemplazo_autorizacion", obj.reemplazo_autorizacion);
                        cmd.Parameters.AddWithValue("reemplazo_numero_oficio", obj.reemplazo_numero_oficio);
                        cmd.Parameters.AddWithValue("reemplazo_fecha_inicio", obj.reemplazo_fecha_inicio);
                        cmd.Parameters.AddWithValue("reemplazo_fecha_fin", obj.reemplazo_fecha_fin);
                        cmd.Parameters.AddWithValue("reemplazo_estado", obj.reemplazo_estado);

                        await sql.OpenAsync();
                        await cmd.ExecuteNonQueryAsync();
                    }
                }
            }

            public async Task Delete(int id)
            {
                using (var sql = new NpgsqlConnection(cn.getCadenaConexion()))
                {
                    using (var cmd = new NpgsqlCommand("DELETE FROM catastroestablecimiento.cm_reemplazo WHERE reemplazo_id = @reemplazo_id", sql))
                    {
                        cmd.Parameters.AddWithValue("reemplazo_id", id);
                        await sql.OpenAsync();
                        await cmd.ExecuteNonQueryAsync();
                    }
                }
            }

        }
    
}
