
using Npgsql;
using REST_CE.Models;
using REST_CE.Models.Catastro;

namespace REST_CE.Datos.Catastro
{
    public class Cls_Puesto_Da
    {
        Conexion.Conexion cn = new Conexion.Conexion();
        public async Task<List<Cls_Puesto_Model>> MostrarProductos()
        {
            var lista = new List<Cls_Puesto_Model>();
            using (var sql = new NpgsqlConnection(cn.getCadenaConexion()))
            {
                using (var cmd = new NpgsqlCommand("SELECT * FROM  catastroestablecimiento.cm_puesto", sql))
                {
                    await sql.OpenAsync();
                    using (var dr = await cmd.ExecuteReaderAsync())
                    {
                        while (await dr.ReadAsync())
                        {
                            var obj = new Cls_Puesto_Model();
                            obj.puesto_id = dr.GetInt32(0);
                            obj.piso_id = dr.GetInt32(1);
                            obj.tipo_area_id = dr.GetInt32(2);
                            obj.comerciante_id = dr.GetInt32(3);
                            obj.ayudante_id = dr.GetInt32(4);
                            obj.reemplazo_id = dr.GetInt32(5);
                            obj.documento_puesto_id = dr.GetInt32(6);
                            

                            obj.puesto_predio = dr.GetString(7);
                            obj.puesto_clave_catastral = dr.GetString(8);
                            obj.puesto_area = dr.GetInt32(9);
                            obj.puesto_frente = dr.GetInt32(10);
                            obj.puesto_fondo = dr.GetInt32(11);
                            
                            obj.puesto_estado_conservacion = dr.GetString(12);
                            obj.puesto_acabados = dr.GetString(13);
                            obj.puesto_paredes = dr.GetString(14);
                            obj.puesto_remodelacion = dr.GetString(15);
                           
                            lista.Add(obj);
                        }
                    }
                }
            }
            return lista;
        }

        public async Task Insert(Cls_Puesto_Model obj)
        {
            using (var sql = new NpgsqlConnection(cn.getCadenaConexion()))
            {
                using (var cmd = new NpgsqlCommand("INSERT INTO catastroestablecimiento.cm_puesto(piso_id, tipo_area_id, comerciante_id, ayudante_id, reemplazo_id, documento_puesto_id,puesto_predio,puesto_clave_catastral,puesto_area,puesto_frente,puesto_fondo,puesto_estado_conservacion,puesto_acabados,puesto_paredes,puesto_remodelacion) VALUES(@piso_id, @tipo_area_id, @comerciante_id, @ayudante_id, @reemplazo_id, @documento_puesto_id,@puesto_predio,@puesto_clave_catastral,@puesto_area,@puesto_frente,@puesto_fondo,@puesto_estado_conservacion,@puesto_acabados,@puesto_paredes,@puesto_remodelacion)", sql))
                {
                    cmd.Parameters.AddWithValue("piso_id", obj.piso_id);
                    cmd.Parameters.AddWithValue("tipo_area_id", obj.tipo_area_id);
                    cmd.Parameters.AddWithValue("comerciante_id", obj.comerciante_id);
                    cmd.Parameters.AddWithValue("ayudante_id", obj.ayudante_id);
                    cmd.Parameters.AddWithValue("reemplazo_id", obj.reemplazo_id);
                    cmd.Parameters.AddWithValue("documento_puesto_id", obj.documento_puesto_id);
                    cmd.Parameters.AddWithValue("puesto_predio", obj.puesto_predio);
                    cmd.Parameters.AddWithValue("puesto_clave_catastral", obj.puesto_clave_catastral);
                    cmd.Parameters.AddWithValue("puesto_area", obj.puesto_area);
                    cmd.Parameters.AddWithValue("puesto_frente", obj.puesto_frente);
                    cmd.Parameters.AddWithValue("puesto_fondo", obj.puesto_fondo);
                    cmd.Parameters.AddWithValue("puesto_estado_conservacion", obj.puesto_estado_conservacion);
                    cmd.Parameters.AddWithValue("puesto_acabados", obj.puesto_acabados);
                    cmd.Parameters.AddWithValue("puesto_paredes", obj.puesto_paredes);
                    cmd.Parameters.AddWithValue("puesto_remodelacion", obj.puesto_remodelacion);
                    await sql.OpenAsync();
                    await cmd.ExecuteNonQueryAsync();
                }
            }
        }
        

        public async Task Edit(Cls_Puesto_Model obj)
        {
            using (var sql = new NpgsqlConnection(cn.getCadenaConexion()))
            {
                using (var cmd = new NpgsqlCommand("UPDATE catastroestablecimiento.cm_puesto SET piso_id=@piso_id, tipo_area_id=@tipo_area_id, comerciante_id=@comerciante_id, ayudante_id=@ayudante_id, reemplazo_id=@reemplazo_id, documento_puesto_id=@documento_puesto_id,puesto_predio=@puesto_predio,puesto_clave_catastral=@puesto_clave_catastral,puesto_area=@puesto_area,puesto_frente=@puesto_frente,puesto_fondo=@puesto_fondo,puesto_estado_conservacion=@puesto_estado_conservacion,puesto_acabados=@puesto_acabados,puesto_paredes=@puesto_paredes,puesto_remodelacion=@puesto_remodelacion WHERE puesto_id = @puesto_id", sql))
                {
                    cmd.Parameters.AddWithValue("puesto_id", obj.puesto_id);
                    cmd.Parameters.AddWithValue("piso_id", obj.piso_id);
                    cmd.Parameters.AddWithValue("tipo_area_id", obj.tipo_area_id);
                    cmd.Parameters.AddWithValue("comerciante_id", obj.comerciante_id);
                    cmd.Parameters.AddWithValue("ayudante_id", obj.ayudante_id);
                    cmd.Parameters.AddWithValue("reemplazo_id", obj.reemplazo_id);
                    cmd.Parameters.AddWithValue("documento_puesto_id", obj.documento_puesto_id);
                    cmd.Parameters.AddWithValue("puesto_predio", obj.puesto_predio);
                    cmd.Parameters.AddWithValue("puesto_clave_catastral", obj.puesto_clave_catastral);
                    cmd.Parameters.AddWithValue("puesto_area", obj.puesto_area);
                    cmd.Parameters.AddWithValue("puesto_frente", obj.puesto_frente);
                    cmd.Parameters.AddWithValue("puesto_fondo", obj.puesto_fondo);
                    cmd.Parameters.AddWithValue("puesto_estado_conservacion", obj.puesto_estado_conservacion);
                    cmd.Parameters.AddWithValue("puesto_acabados", obj.puesto_acabados);
                    cmd.Parameters.AddWithValue("puesto_paredes", obj.puesto_paredes);
                    cmd.Parameters.AddWithValue("puesto_remodelacion", obj.puesto_remodelacion);
                    await sql.OpenAsync();
                    await cmd.ExecuteNonQueryAsync();
                }
            }
        }

        public async Task Delete(int id)
        {
            using (var sql = new NpgsqlConnection(cn.getCadenaConexion()))
            {
                using (var cmd = new NpgsqlCommand("DELETE FROM catastroestablecimiento.cm_puesto WHERE puesto_id = @puesto_id", sql))
                {
                    cmd.Parameters.AddWithValue("puesto_id", id);
                    await sql.OpenAsync();
                    await cmd.ExecuteNonQueryAsync();
                }
            }
        }

    }

}

