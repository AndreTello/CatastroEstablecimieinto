using Npgsql;
using REST_CE.Models.Catastro;

namespace REST_CE.Datos.Catastro
{
    public class Cls_Familiar_Da
    {
        Conexion.Conexion cn = new Conexion.Conexion();
        public async Task<List<Cls_Familiar_Model>> MostrarProductos()
        {
            var lista = new List<Cls_Familiar_Model>();
            using (var sql = new NpgsqlConnection(cn.getCadenaConexion()))
            {
                using (var cmd = new NpgsqlCommand("SELECT * FROM  catastroestablecimiento.cm_familiar", sql))
                {
                    await sql.OpenAsync();
                    using (var dr = await cmd.ExecuteReaderAsync())
                    {
                        while (await dr.ReadAsync())
                        {
                            var obj = new Cls_Familiar_Model();
                            obj.familiar_id = dr.GetInt32(0);
                            obj.tipo_familiar_id = dr.GetInt32(1);
                            obj.comerciante_id = dr.GetInt32(2);
                            obj.familiar_cedula = dr.GetString(3);
                            obj.familiar_apellidos = dr.GetString(4);
                            obj.familiar_nombres = dr.GetString(5);
                            obj.familiar_aporte_economico = dr.GetInt32(6);
                            obj.familiar_promedio_ingreso = dr.GetInt32(7);
                            obj.familiar_menor_edad = dr.GetString(8);
                            obj.familiar_escolaridad = dr.GetString(9);
                           
                            ;



                            lista.Add(obj);
                        }
                    }
                }
            }
            return lista;
        }

        public async Task Insert(Cls_Familiar_Model obj)
        {
            using (var sql = new NpgsqlConnection(cn.getCadenaConexion()))
            {
                using (var cmd = new NpgsqlCommand("INSERT INTO catastroestablecimiento.cm_familiar(tipo_familiar_id,comerciante_id,familiar_cedula,familiar_apellidos,familiar_nombres,familiar_aporte_economico,familiar_promedio_ingreso,familiar_menor_edad,familiar_escolaridad) VALUES(@tipo_familiar_id,@comerciante_id,@familiar_cedula,@familiar_apellidos,@familiar_nombres,@familiar_aporte_economico,@familiar_promedio_ingreso,@familiar_menor_edad,@familiar_escolaridad)", sql))
                {
                    cmd.Parameters.AddWithValue("tipo_familiar_id", obj.tipo_familiar_id);
                    cmd.Parameters.AddWithValue("comerciante_id", obj.comerciante_id);
                    cmd.Parameters.AddWithValue("familiar_cedula", obj.familiar_cedula);
                    cmd.Parameters.AddWithValue("familiar_apellidos", obj.familiar_apellidos);
                    cmd.Parameters.AddWithValue("familiar_nombres", obj.familiar_nombres);
                    cmd.Parameters.AddWithValue("familiar_aporte_economico", obj.familiar_aporte_economico);
                    cmd.Parameters.AddWithValue("familiar_promedio_ingreso", obj.familiar_promedio_ingreso);
                    cmd.Parameters.AddWithValue("familiar_menor_edad", obj.familiar_menor_edad);
                    cmd.Parameters.AddWithValue("familiar_escolaridad", obj.familiar_escolaridad);


                    await sql.OpenAsync();
                    await cmd.ExecuteNonQueryAsync();
                }
            }
        }


        public async Task Edit(Cls_Familiar_Model obj)
        {
            using (var sql = new NpgsqlConnection(cn.getCadenaConexion()))
            {
                using (var cmd = new NpgsqlCommand("UPDATE catastroestablecimiento.cm_familiar SET tipo_familiar_id=@tipo_familiar_id,comerciante_id=@comerciante_id,familiar_cedula=@familiar_cedula,familiar_apellidos=@familiar_apellidos,familiar_nombres=@familiar_nombres,familiar_aporte_economico=@familiar_aporte_economico,familiar_promedio_ingreso=@familiar_promedio_ingreso,familiar_menor_edad=@familiar_menor_edad,familiar_escolaridad=@familiar_escolaridad  WHERE tipo_familiar_id = @tipo_familiar_id", sql))
                {
                    cmd.Parameters.AddWithValue("tipo_familiar_id", obj.tipo_familiar_id);
                    cmd.Parameters.AddWithValue("comerciante_id", obj.comerciante_id);
                    cmd.Parameters.AddWithValue("familiar_cedula", obj.familiar_cedula);
                    cmd.Parameters.AddWithValue("familiar_apellidos", obj.familiar_apellidos);
                    cmd.Parameters.AddWithValue("familiar_nombres", obj.familiar_nombres);
                    cmd.Parameters.AddWithValue("familiar_aporte_economico", obj.familiar_aporte_economico);
                    cmd.Parameters.AddWithValue("familiar_promedio_ingreso", obj.familiar_promedio_ingreso);
                    cmd.Parameters.AddWithValue("familiar_menor_edad", obj.familiar_menor_edad);
                    cmd.Parameters.AddWithValue("familiar_escolaridad", obj.familiar_escolaridad);

                    await sql.OpenAsync();
                    await cmd.ExecuteNonQueryAsync();
                }
            }
        }

        public async Task Delete(int id)
        {
            using (var sql = new NpgsqlConnection(cn.getCadenaConexion()))
            {
                using (var cmd = new NpgsqlCommand("DELETE FROM catastroestablecimiento.cm_familiar WHERE tipo_familiar_id = @tipo_familiar_id", sql))
                {
                    cmd.Parameters.AddWithValue("tipo_familiar_id", id);
                    await sql.OpenAsync();
                    await cmd.ExecuteNonQueryAsync();
                }
            }
        }

    }
}
