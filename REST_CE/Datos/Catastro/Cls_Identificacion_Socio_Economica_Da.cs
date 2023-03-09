using Npgsql;
using REST_CE.Models.Catastro;

namespace REST_CE.Datos.Catastro
{
    public class Cls_Identificacion_Socio_Economica_Da
    {
        Conexion.Conexion cn = new Conexion.Conexion();
        public async Task<List<Cls_Identificacion_Socio_Economica_Model>> MostrarProductos()
        {
            var lista = new List<Cls_Identificacion_Socio_Economica_Model>();
            using (var sql = new NpgsqlConnection(cn.getCadenaConexion()))
            {
                using (var cmd = new NpgsqlCommand("SELECT * FROM  catastroestablecimiento.cm_identificacion_socio_economica", sql))
                {
                    await sql.OpenAsync();
                    using (var dr = await cmd.ExecuteReaderAsync())
                    {
                        while (await dr.ReadAsync())
                        {
                            var obj = new Cls_Identificacion_Socio_Economica_Model();
                            obj.identificacion_socio_economica_id = dr.GetInt32(0);
                            obj.comerciante_id = dr.GetInt32(1);
                            obj.etnia_id = dr.GetInt32(2);
                            obj.genero_id = dr.GetInt32(3);
                            obj.estado_civil_id = dr.GetInt32(4);
                            obj.nacionalidad_id = dr.GetInt32(5);
                            obj.nivel_educacion_id = dr.GetInt32(6);


                            obj.discapacidad_id = dr.GetInt32(7);
                            obj.identificacion_socio_economica_jefe_familia = dr.GetString(8);
                            obj.identificacion_socio_economica_dependientes = dr.GetString(9);
                            obj.identificacion_socio_economica_numero_dependientes = dr.GetInt32(10);
                            obj.identificacion_socio_economica_parentesco = dr.GetString(11);

                            obj.identificacion_socio_economica_estado = dr.GetInt32(12);
                         
                            lista.Add(obj);
                        }
                    }
                }
            }
            return lista;
        }

        public async Task Insert(Cls_Identificacion_Socio_Economica_Model obj)
        {
            using (var sql = new NpgsqlConnection(cn.getCadenaConexion()))
            {
                using (var cmd = new NpgsqlCommand("INSERT INTO catastroestablecimiento.cm_identificacion_socio_economica(comerciante_id,etnia_id,genero_id,estado_civil_id, nacionalidad_id,nivel_educacion_id,discapacidad_id,identificacion_socio_economica_jefe_familia,identificacion_socio_economica_dependientes,identificacion_socio_economica_numero_dependientes,identificacion_socio_economica_parentesco,identificacion_socio_economica_estado) VALUES(@comerciante_id,@etnia_id,genero_id,@estado_civil_id, @nacionalidad_id,@nivel_educacion_id,@discapacidad_id,@identificacion_socio_economica_jefe_familia,@identificacion_socio_economica_dependientes,@identificacion_socio_economica_numero_dependientes,@identificacion_socio_economica_parentesco,@identificacion_socio_economica_estado)", sql))
                {
                    cmd.Parameters.AddWithValue("comerciante_id", obj.comerciante_id);
                    cmd.Parameters.AddWithValue("etnia_id", obj.etnia_id);
                    cmd.Parameters.AddWithValue("genero_id", obj.genero_id);
                    cmd.Parameters.AddWithValue("estado_civil_id", obj.estado_civil_id);
                    cmd.Parameters.AddWithValue("nacionalidad_id", obj.nacionalidad_id);
                    cmd.Parameters.AddWithValue("nivel_educacion_id", obj.nivel_educacion_id);
                    cmd.Parameters.AddWithValue("discapacidad_id", obj.discapacidad_id);
                    cmd.Parameters.AddWithValue("identificacion_socio_economica_jefe_familia", obj.identificacion_socio_economica_jefe_familia);
                    cmd.Parameters.AddWithValue("identificacion_socio_economica_dependientes", obj.identificacion_socio_economica_dependientes);
                    cmd.Parameters.AddWithValue("identificacion_socio_economica_numero_dependientes", obj.identificacion_socio_economica_numero_dependientes);
                    cmd.Parameters.AddWithValue("identificacion_socio_economica_parentesco", obj.identificacion_socio_economica_parentesco);
                    cmd.Parameters.AddWithValue("identificacion_socio_economica_estado", obj.identificacion_socio_economica_estado);
                  
                    await cmd.ExecuteNonQueryAsync();
                }
            }
        }


        public async Task Edit(Cls_Identificacion_Socio_Economica_Model obj)
        {
            using (var sql = new NpgsqlConnection(cn.getCadenaConexion()))
            {
                using (var cmd = new NpgsqlCommand("UPDATE catastroestablecimiento.cm_identificacion_socio_economica SET comerciante_id=@comerciante_id,etnia_id=@etnia_id,genero_id=@genero_id,estado_civil_id=@estado_civil_id, nacionalidad_id=@nacionalidad_id,nivel_educacion_id=@nivel_educacion_id,discapacidad_id=@discapacidad_id,identificacion_socio_economica_jefe_familia=@identificacion_socio_economica_jefe_familia,identificacion_socio_economica_dependientes=@identificacion_socio_economica_dependientes,identificacion_socio_economica_numero_dependientes=@identificacion_socio_economica_numero_dependientes,identificacion_socio_economica_parentesco=@identificacion_socio_economica_parentesco,identificacion_socio_economica_estado=@identificacion_socio_economica_estado WHERE identificacion_socio_economica_id = @identificacion_socio_economica_id", sql))
                {
                    cmd.Parameters.AddWithValue("identificacion_socio_economica_id", obj.identificacion_socio_economica_id);
                    cmd.Parameters.AddWithValue("comerciante_id", obj.comerciante_id);
                    cmd.Parameters.AddWithValue("etnia_id", obj.etnia_id);
                    cmd.Parameters.AddWithValue("genero_id", obj.genero_id);
                    cmd.Parameters.AddWithValue("estado_civil_id", obj.estado_civil_id);
                    cmd.Parameters.AddWithValue("nacionalidad_id", obj.nacionalidad_id);
                    cmd.Parameters.AddWithValue("nivel_educacion_id", obj.nivel_educacion_id);
                    cmd.Parameters.AddWithValue("discapacidad_id", obj.discapacidad_id);
                    cmd.Parameters.AddWithValue("identificacion_socio_economica_jefe_familia", obj.identificacion_socio_economica_jefe_familia);
                    cmd.Parameters.AddWithValue("identificacion_socio_economica_dependientes", obj.identificacion_socio_economica_dependientes);
                    cmd.Parameters.AddWithValue("identificacion_socio_economica_numero_dependientes", obj.identificacion_socio_economica_numero_dependientes);
                    cmd.Parameters.AddWithValue("identificacion_socio_economica_parentesco", obj.identificacion_socio_economica_parentesco);
                    cmd.Parameters.AddWithValue("identificacion_socio_economica_estado", obj.identificacion_socio_economica_estado);
                  
                    await sql.OpenAsync();
                    await cmd.ExecuteNonQueryAsync();
                }
            }
        }

        public async Task Delete(int id)
        {
            using (var sql = new NpgsqlConnection(cn.getCadenaConexion()))
            {
                using (var cmd = new NpgsqlCommand("DELETE FROM catastroestablecimiento.cm_identificacion_socio_economica WHERE identificacion_socio_economica_id = @identificacion_socio_economica_id", sql))
                {
                    cmd.Parameters.AddWithValue("identificacion_socio_economica_id", id);
                    await sql.OpenAsync();
                    await cmd.ExecuteNonQueryAsync();
                }
            }
        }


    }
}
