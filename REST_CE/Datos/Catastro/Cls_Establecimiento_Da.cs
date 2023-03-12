using Npgsql;
using REST_CE.Models.Catastro;

namespace REST_CE.Datos.Catastro
{
    public class Cls_Establecimiento_Da
    {
        Conexion.Conexion cn = new Conexion.Conexion();
        public async Task<List<Cls_Establecimiento_Model>> MostrarProductos()
        {
            var lista = new List<Cls_Establecimiento_Model>();
            using (var sql = new NpgsqlConnection(cn.getCadenaConexion()))
            {
                using (var cmd = new NpgsqlCommand("SELECT * FROM  catastroestablecimiento.cm_establecimiento", sql))
                {
                    await sql.OpenAsync();
                    using (var dr = await cmd.ExecuteReaderAsync())
                    {
                        while (await dr.ReadAsync())
                        {
                            var obj = new Cls_Establecimiento_Model();
                            obj.establecimiento_id = dr.GetInt32(0);
                            obj.lote_id = dr.GetInt32(1);
                            obj.administracion_zonal_id = dr.GetInt32(2);
                            obj.tipo_establecimiento_id = dr.GetInt32(3);
                            obj.asociacion_id = dr.GetInt32(4);
                            obj.intervencion_tecnica_establecimiento_id = dr.GetInt32(5);
                            obj.establecimiento_predio = dr.GetString(6);


                            obj.establecimiento_clave_catastral = dr.GetString(7);
                            obj.establecimiento_nomenclatura_vial = dr.GetString(8);
                            obj.establecimiento_calle_principal = dr.GetString(9);
                            obj.establecimiento_calle_secundaria = dr.GetString(10);
                            obj.establecimiento_paqueadero = dr.GetString(11);

                            obj.establecimiento_numero_parqueadero = dr.GetInt32(12);
                            obj.establecimiento_dias_apertura = dr.GetString(13);
                            obj.establecimiento_horario_atencion = dr.GetString(14);
                            obj.establecimiento_estado = dr.GetInt32(15);

                            lista.Add(obj);
                        }
                    }
                }
            }
            return lista;
        }

        public async Task Insert(Cls_Establecimiento_Model obj)
        {
            using (var sql = new NpgsqlConnection(cn.getCadenaConexion()))
            {
                using (var cmd = new NpgsqlCommand("INSERT INTO catastroestablecimiento.cm_establecimiento(lote_id, administracion_zonal_id, tipo_establecimiento_id, asociacion_id, intervencion_tecnica_establecimiento_id, establecimiento_predio,establecimiento_clave_catastral,establecimiento_nomenclatura_vial,establecimiento_calle_principal,establecimiento_calle_secundaria,establecimiento_paqueadero,establecimiento_numero_parqueadero,establecimiento_dias_apertura,establecimiento_horario_atencion,establecimiento_estado) VALUES(@lote_id,@administracion_zonal_id, @tipo_establecimiento_id, @asociacion_id, @intervencion_tecnica_establecimiento_id, @establecimiento_predio,@establecimiento_clave_catastral,@establecimiento_nomenclatura_vial,@establecimiento_calle_principal,@establecimiento_calle_secundaria,@establecimiento_paqueadero,@establecimiento_numero_parqueadero,@establecimiento_dias_apertura,@establecimiento_horario_atencion,@establecimiento_estado)", sql))
                {
                    cmd.Parameters.AddWithValue("lote_id", obj.lote_id);
                    cmd.Parameters.AddWithValue("administracion_zonal_id", obj.administracion_zonal_id);
                    cmd.Parameters.AddWithValue("tipo_establecimiento_id", obj.tipo_establecimiento_id);
                    cmd.Parameters.AddWithValue("asociacion_id", obj.asociacion_id);
                    cmd.Parameters.AddWithValue("intervencion_tecnica_establecimiento_id", obj.intervencion_tecnica_establecimiento_id);
                    cmd.Parameters.AddWithValue("establecimiento_predio", obj.establecimiento_predio);
                    cmd.Parameters.AddWithValue("establecimiento_clave_catastral", obj.establecimiento_clave_catastral);
                    cmd.Parameters.AddWithValue("establecimiento_nomenclatura_vial", obj.establecimiento_nomenclatura_vial);
                    cmd.Parameters.AddWithValue("establecimiento_calle_principal", obj.establecimiento_calle_principal);
                    cmd.Parameters.AddWithValue("establecimiento_calle_secundaria", obj.establecimiento_calle_secundaria);
                    cmd.Parameters.AddWithValue("establecimiento_paqueadero", obj.establecimiento_paqueadero);
                    cmd.Parameters.AddWithValue("establecimiento_numero_parqueadero", obj.establecimiento_numero_parqueadero);
                    cmd.Parameters.AddWithValue("establecimiento_dias_apertura", obj.establecimiento_dias_apertura);
                    cmd.Parameters.AddWithValue("establecimiento_horario_atencion", obj.establecimiento_horario_atencion);
                    cmd.Parameters.AddWithValue("establecimiento_estado", obj.establecimiento_estado);
                    await sql.OpenAsync();
                    await cmd.ExecuteNonQueryAsync();
                }
            }
        }


        public async Task Edit(Cls_Establecimiento_Model obj)
        {
            using (var sql = new NpgsqlConnection(cn.getCadenaConexion()))
            {
                using (var cmd = new NpgsqlCommand("UPDATE catastroestablecimiento.cm_establecimiento SET lote_id=@lote_id, administracion_zonal_id=@administracion_zonal_id, tipo_establecimiento_id=@tipo_establecimiento_id, asociacion_id=@asociacion_id, intervencion_tecnica_establecimiento_id=@intervencion_tecnica_establecimiento_id, establecimiento_predio=@establecimiento_predio,establecimiento_clave_catastral=@establecimiento_clave_catastral,establecimiento_nomenclatura_vial=@establecimiento_nomenclatura_vial,establecimiento_calle_principal=@establecimiento_calle_principal,establecimiento_calle_secundaria=@establecimiento_calle_secundaria,establecimiento_paqueadero=@establecimiento_paqueadero,establecimiento_numero_parqueadero=@establecimiento_numero_parqueadero,establecimiento_dias_apertura=@establecimiento_dias_apertura,establecimiento_horario_atencion=@establecimiento_horario_atencion,establecimiento_estado=@establecimiento_estado WHERE establecimiento_id = @establecimiento_id", sql))
                {
                    cmd.Parameters.AddWithValue("lote_id", obj.lote_id);
                    cmd.Parameters.AddWithValue("administracion_zonal_id", obj.administracion_zonal_id);
                    cmd.Parameters.AddWithValue("tipo_establecimiento_id", obj.tipo_establecimiento_id);
                    cmd.Parameters.AddWithValue("asociacion_id", obj.asociacion_id);
                    cmd.Parameters.AddWithValue("intervencion_tecnica_establecimiento_id", obj.intervencion_tecnica_establecimiento_id);
                    cmd.Parameters.AddWithValue("establecimiento_predio", obj.establecimiento_predio);
                    cmd.Parameters.AddWithValue("establecimiento_clave_catastral", obj.establecimiento_clave_catastral);
                    cmd.Parameters.AddWithValue("establecimiento_nomenclatura_vial", obj.establecimiento_nomenclatura_vial);
                    cmd.Parameters.AddWithValue("establecimiento_calle_principal", obj.establecimiento_calle_principal);
                    cmd.Parameters.AddWithValue("establecimiento_calle_secundaria", obj.establecimiento_calle_secundaria);
                    cmd.Parameters.AddWithValue("establecimiento_paqueadero", obj.establecimiento_paqueadero);
                    cmd.Parameters.AddWithValue("establecimiento_numero_parqueadero", obj.establecimiento_numero_parqueadero);
                    cmd.Parameters.AddWithValue("establecimiento_dias_apertura", obj.establecimiento_dias_apertura);
                    cmd.Parameters.AddWithValue("establecimiento_horario_atencion", obj.establecimiento_horario_atencion);
                    cmd.Parameters.AddWithValue("establecimiento_estado", obj.establecimiento_estado);
                    await sql.OpenAsync();
                    await cmd.ExecuteNonQueryAsync();
                }
            }
        }

        public async Task Delete(int id)
        {
            using (var sql = new NpgsqlConnection(cn.getCadenaConexion()))
            {
                using (var cmd = new NpgsqlCommand("DELETE FROM catastroestablecimiento.cm_establecimiento WHERE establecimiento_id = @establecimiento_id", sql))
                {
                    cmd.Parameters.AddWithValue("establecimiento_id", id);
                    await sql.OpenAsync();
                    await cmd.ExecuteNonQueryAsync();
                }
            }
        }

    }
}
