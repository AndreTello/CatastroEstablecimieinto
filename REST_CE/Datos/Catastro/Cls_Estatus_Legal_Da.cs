using Npgsql;
using REST_CE.Models.Catastro;

namespace REST_CE.Datos.Catastro
{
    public class Cls_Estatus_Legal_Da
    {
        Conexion.Conexion cn = new Conexion.Conexion();
        public async Task<List<Cls_Estatus_Legal_Model>> MostrarProductos()
        {
            var lista = new List<Cls_Estatus_Legal_Model>();
            using (var sql = new NpgsqlConnection(cn.getCadenaConexion()))
            {
                using (var cmd = new NpgsqlCommand("SELECT * FROM  catastroestablecimiento.cm_estatus_legal", sql))
                {
                    await sql.OpenAsync();
                    using (var dr = await cmd.ExecuteReaderAsync())
                    {
                        while (await dr.ReadAsync())
                        {
                            var obj = new Cls_Estatus_Legal_Model();
                            obj.estatus_legal_id = dr.GetInt32(0);
                            obj.puesto_id = dr.GetInt32(1);
                            obj.giro_negocio_id = dr.GetInt32(2);
                            obj.estatus_legal_fecha_ocupacion = dr.GetDateTime(3);
                            obj.estatus_legal_historial = dr.GetString(4);
                            obj.estatus_legal_estado_adjudicado = dr.GetInt32(5);
                            obj.estatus_legal_numero_puesto_adjudicado = dr.GetInt32(6);


                            obj.estatus_legal_condicion_uso = dr.GetString(7);
                            obj.estatus_legal_carta_adjudicacion = dr.GetByte(8);
                            obj.estatus_fecha_notificacion = dr.GetDateTime(9);
                            obj.estatus_legal_acta_resolucion_notificacion = dr.GetByte(10);
                            obj.estatus_legal_fecha_resolucion_notificacion = dr.GetDateTime(11);

                            obj.estatus_legal_convenio_nombre = dr.GetString(12);
                            obj.estatus_legal_convenio_numero = dr.GetInt32(13);
                            obj.estatus_legal_convenio_fecha = dr.GetDateTime(14);
                            obj.estatus_legal_condicion = dr.GetString(15);
                            obj.estatus_legal_cambio_giro = dr.GetInt32(16);
                            obj.estatus_legal_numero_oficio_cambio_giro = dr.GetString(17);
                            obj.estatus_legal_fecha_cambio_giro = dr.GetDateTime(18);
                            obj.estatus_legal_sanciones = dr.GetString(19);
                            obj.estatus_legal_numero_resolucion_sancion = dr.GetString(20);
                            obj.estatus_legal_fecha_resolucion_sancion = dr.GetDateTime(21);

                            lista.Add(obj);
                        }
                    }
                }
            }
            return lista;
        }

        public async Task Insert(Cls_Estatus_Legal_Model obj)
        {
            using (var sql = new NpgsqlConnection(cn.getCadenaConexion()))
            {
                using (var cmd = new NpgsqlCommand("INSERT INTO catastroestablecimiento.cm_estatus_legal(puesto_id, giro_negocio_id,estatus_legal_fecha_ocupacion, estatus_legal_historial,estatus_legal_estado_adjudicado, estatus_legal_numero_puesto_adjudicado,estatus_legal_condicion_uso,estatus_legal_carta_adjudicacion,estatus_fecha_notificacion,estatus_legal_acta_resolucion_notificacion,estatus_legal_fecha_resolucion_notificacion,estatus_legal_convenio_nombre,estatus_legal_convenio_numero,estatus_legal_convenio_fecha,estatus_legal_condicion,estatus_legal_cambio_giro,estatus_legal_numero_oficio_cambio_giro,estatus_legal_fecha_cambio_giro,estatus_legal_sanciones,estatus_legal_numero_resolucion_sancion,estatus_legal_fecha_resolucion_sancion) VALUES(@puesto_id, @giro_negocio_id,@estatus_legal_fecha_ocupacion, @estatus_legal_historial,@estatus_legal_estado_adjudicado, @estatus_legal_numero_puesto_adjudicado,@estatus_legal_condicion_uso,@estatus_legal_carta_adjudicacion,@estatus_fecha_notificacion,@estatus_legal_acta_resolucion_notificacion,@estatus_legal_fecha_resolucion_notificacion,@estatus_legal_convenio_nombre,@estatus_legal_convenio_numero,@estatus_legal_convenio_fecha,@estatus_legal_condicion,@estatus_legal_cambio_giro,@estatus_legal_numero_oficio_cambio_giro,@estatus_legal_fecha_cambio_giro,@estatus_legal_sanciones,@estatus_legal_numero_resolucion_sancion,@estatus_legal_fecha_resolucion_sancion)", sql))
                {
                    cmd.Parameters.AddWithValue("puesto_id", obj.puesto_id);
                    cmd.Parameters.AddWithValue("giro_negocio_id", obj.giro_negocio_id);
                    cmd.Parameters.AddWithValue("estatus_legal_fecha_ocupacion", obj.estatus_legal_fecha_ocupacion);
                    cmd.Parameters.AddWithValue("estatus_legal_historial", obj.estatus_legal_historial);
                    cmd.Parameters.AddWithValue("estatus_legal_estado_adjudicado", obj.estatus_legal_estado_adjudicado);
                    cmd.Parameters.AddWithValue("estatus_legal_numero_puesto_adjudicado", obj.estatus_legal_numero_puesto_adjudicado);
                    cmd.Parameters.AddWithValue("estatus_legal_carta_adjudicacion", obj.estatus_legal_carta_adjudicacion);
                    cmd.Parameters.AddWithValue("estatus_fecha_notificacion", obj.estatus_fecha_notificacion);
                    cmd.Parameters.AddWithValue("estatus_legal_acta_resolucion_notificacion", obj.estatus_legal_acta_resolucion_notificacion);
                    cmd.Parameters.AddWithValue("estatus_legal_fecha_resolucion_notificacion", obj.estatus_legal_fecha_resolucion_notificacion);
                    cmd.Parameters.AddWithValue("estatus_legal_convenio_nombre", obj.estatus_legal_convenio_nombre);
                    cmd.Parameters.AddWithValue("estatus_legal_convenio_numero", obj.estatus_legal_convenio_numero);
                    cmd.Parameters.AddWithValue("estatus_legal_convenio_fecha", obj.estatus_legal_convenio_fecha);
                    cmd.Parameters.AddWithValue("estatus_legal_condicion", obj.estatus_legal_condicion);
                    cmd.Parameters.AddWithValue("estatus_legal_cambio_giro", obj.estatus_legal_cambio_giro);
                    cmd.Parameters.AddWithValue("estatus_legal_numero_oficio_cambio_giro", obj.estatus_legal_numero_oficio_cambio_giro);
                    cmd.Parameters.AddWithValue("estatus_legal_condicion_uso", obj.estatus_legal_condicion_uso);
                    cmd.Parameters.AddWithValue("estatus_legal_fecha_cambio_giro", obj.estatus_legal_fecha_cambio_giro);
                    cmd.Parameters.AddWithValue("estatus_legal_sanciones", obj.estatus_legal_sanciones);
                    cmd.Parameters.AddWithValue("estatus_legal_numero_resolucion_sancion", obj.estatus_legal_numero_resolucion_sancion);
                    cmd.Parameters.AddWithValue("estatus_legal_fecha_resolucion_sancion", obj.estatus_legal_fecha_resolucion_sancion);
  
                    await sql.OpenAsync();
                    await cmd.ExecuteNonQueryAsync();
                }
            }
        }


        public async Task Edit(Cls_Estatus_Legal_Model obj)
        {
            using (var sql = new NpgsqlConnection(cn.getCadenaConexion()))
            {
                using (var cmd = new NpgsqlCommand("UPDATE catastroestablecimiento.cm_estatus_legal SET puesto_id=@puesto_id, giro_negocio_id=@giro_negocio_id,estatus_legal_fecha_ocupacion=@estatus_legal_fecha_ocupacion, estatus_legal_historial=@estatus_legal_historial,estatus_legal_estado_adjudicado=@estatus_legal_estado_adjudicado, estatus_legal_numero_puesto_adjudicado=@estatus_legal_numero_puesto_adjudicado,estatus_legal_condicion_uso=@estatus_legal_condicion_uso,estatus_legal_carta_adjudicacion=@estatus_legal_carta_adjudicacion,estatus_fecha_notificacion=@estatus_fecha_notificacion,estatus_legal_acta_resolucion_notificacion=@estatus_legal_acta_resolucion_notificacion,estatus_legal_fecha_resolucion_notificacion=@estatus_legal_fecha_resolucion_notificacion,estatus_legal_convenio_nombre=@estatus_legal_convenio_nombre,estatus_legal_convenio_numero=@estatus_legal_convenio_numero,estatus_legal_convenio_fecha=@estatus_legal_convenio_fecha,estatus_legal_condicion=@estatus_legal_condicion,estatus_legal_cambio_giro=@estatus_legal_cambio_giro,estatus_legal_numero_oficio_cambio_giro=@estatus_legal_numero_oficio_cambio_giro,estatus_legal_fecha_cambio_giro,estatus_legal_sanciones=@estatus_legal_fecha_cambio_giro,estatus_legal_sanciones=@estatus_legal_sanciones,estatus_legal_numero_resolucion_sancion=@estatus_legal_numero_resolucion_sancion,estatus_legal_fecha_resolucion_sancion=@estatus_legal_fecha_resolucion_sancion WHERE  estatus_legal_id=@estatus_legal_id", sql))
                {
                    cmd.Parameters.AddWithValue("estatus_legal_id", obj.estatus_legal_id);
                    cmd.Parameters.AddWithValue("puesto_id", obj.puesto_id);
                    cmd.Parameters.AddWithValue("giro_negocio_id", obj.giro_negocio_id);
                    cmd.Parameters.AddWithValue("estatus_legal_fecha_ocupacion", obj.estatus_legal_fecha_ocupacion);
                    cmd.Parameters.AddWithValue("estatus_legal_historial", obj.estatus_legal_historial);
                    cmd.Parameters.AddWithValue("estatus_legal_estado_adjudicado", obj.estatus_legal_estado_adjudicado);
                    cmd.Parameters.AddWithValue("estatus_legal_numero_puesto_adjudicado", obj.estatus_legal_numero_puesto_adjudicado);
                    cmd.Parameters.AddWithValue("estatus_legal_carta_adjudicacion", obj.estatus_legal_carta_adjudicacion);
                    cmd.Parameters.AddWithValue("estatus_fecha_notificacion", obj.estatus_fecha_notificacion);
                    cmd.Parameters.AddWithValue("estatus_legal_acta_resolucion_notificacion", obj.estatus_legal_acta_resolucion_notificacion);
                    cmd.Parameters.AddWithValue("estatus_legal_fecha_resolucion_notificacion", obj.estatus_legal_fecha_resolucion_notificacion);
                    cmd.Parameters.AddWithValue("estatus_legal_convenio_nombre", obj.estatus_legal_convenio_nombre);
                    cmd.Parameters.AddWithValue("estatus_legal_convenio_numero", obj.estatus_legal_convenio_numero);
                    cmd.Parameters.AddWithValue("estatus_legal_convenio_fecha", obj.estatus_legal_convenio_fecha);
                    cmd.Parameters.AddWithValue("estatus_legal_condicion", obj.estatus_legal_condicion);
                    cmd.Parameters.AddWithValue("estatus_legal_cambio_giro", obj.estatus_legal_cambio_giro);
                    cmd.Parameters.AddWithValue("estatus_legal_numero_oficio_cambio_giro", obj.estatus_legal_numero_oficio_cambio_giro);
                    cmd.Parameters.AddWithValue("estatus_legal_condicion_uso", obj.estatus_legal_condicion_uso);
                    cmd.Parameters.AddWithValue("estatus_legal_fecha_cambio_giro", obj.estatus_legal_fecha_cambio_giro);
                    cmd.Parameters.AddWithValue("estatus_legal_sanciones", obj.estatus_legal_sanciones);
                    cmd.Parameters.AddWithValue("estatus_legal_numero_resolucion_sancion", obj.estatus_legal_numero_resolucion_sancion);
                    cmd.Parameters.AddWithValue("estatus_legal_fecha_resolucion_sancion", obj.estatus_legal_fecha_resolucion_sancion);

                    await cmd.ExecuteNonQueryAsync();
                }
            }
        }

        public async Task Delete(int id)
        {
            using (var sql = new NpgsqlConnection(cn.getCadenaConexion()))
            {
                using (var cmd = new NpgsqlCommand("DELETE FROM catastroestablecimiento.cm_estatus_legal WHERE estatus_legal_id=@estatus_legal_id", sql))
                {
                    cmd.Parameters.AddWithValue("estatus_legal_id", id);
                    await sql.OpenAsync();
                    await cmd.ExecuteNonQueryAsync();
                }
            }
        }

    }


}

