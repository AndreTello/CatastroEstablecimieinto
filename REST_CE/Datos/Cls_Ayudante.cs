using Npgsql;
using REST_CE.Models;
namespace REST_CE.Datos
{
    public class Cls_Ayudante
    {
        Conexion.Conexion cn = new Conexion.Conexion();
        public async Task <List<Cls_Ayudante_Model>> MostrarProductos()
        {
            var lista = new List<Cls_Ayudante_Model>();
            using (var sql = new NpgsqlConnection(cn.getCadenaConexion()))
            {
                using (var cmd = new NpgsqlCommand("SELECT * FROM catastroestablecimiento.cm_ayudante", sql))
                {
                    await sql.OpenAsync();
                    using (var dr = await cmd.ExecuteReaderAsync())
                    {
                        while (await dr.ReadAsync())
                        {
                            var obj = new Cls_Ayudante_Model();
                            obj.ayudante_id = dr.GetInt32(0);
                            obj.ayudante_cedula = dr.GetString(1);
                            obj.ayudante_apellido = dr.GetString(2);
                            obj.ayudante_nombre = dr.GetString(3);
                            obj.ayudante_parentezco = dr.GetString(4);
                            obj.ayudante_autorizacion = dr.GetString(5);
                            obj.ayudante_numero_oficio = dr.GetString(6);
                            obj.ayudante_fecha_oficio = dr.GetDateTime(7);
                            lista.Add(obj);
                        }
                    }
                }
            }
            return lista;
        }

        public async Task Insert(Cls_Ayudante_Model obj)
        {
            using (var sql = new NpgsqlConnection(cn.getCadenaConexion()))
            {
                using (var cmd = new NpgsqlCommand("INSERT INTO catastroestablecimiento.cm_ayudante(ayudante_cedula, ayudante_nombres, ayudante_apellidos, ayudante_parentezco, ayudante_autorizacion, ayudante_numero_oficio, ayudante_fecha_oficio) VALUES(@ayudante_cedula, @ayudante_nombres, @ayudante_apellidos, @ayudante_parentezco, @ayudante_autorizacion, @ayudante_numero_oficio, @ayudante_fecha_oficio)", sql))
                {
                    cmd.Parameters.AddWithValue("ayudante_cedula", obj.ayudante_cedula);
                    cmd.Parameters.AddWithValue("ayudante_nombres", obj.ayudante_nombre);
                    cmd.Parameters.AddWithValue("ayudante_apellidos", obj.ayudante_apellido);
                    cmd.Parameters.AddWithValue("ayudante_parentezco", obj.ayudante_parentezco);
                    cmd.Parameters.AddWithValue("ayudante_autorizacion", obj.ayudante_autorizacion);
                    cmd.Parameters.AddWithValue("ayudante_numero_oficio", obj.ayudante_numero_oficio);
                    cmd.Parameters.AddWithValue("ayudante_fecha_oficio", obj.ayudante_fecha_oficio);
                    await sql.OpenAsync();
                    await cmd.ExecuteNonQueryAsync();
                }
            }
        }

        public async Task Edit(Cls_Ayudante_Model obj)
        {
            using (var sql = new NpgsqlConnection(cn.getCadenaConexion()))
            {
                using (var cmd = new NpgsqlCommand("UPDATE catastroestablecimiento.cm_ayudante SET ayudante_cedula = @ayudante_cedula, ayudante_nombres = @ayudante_nombres, ayudante_apellidos = @ayudante_apellidos, ayudante_parentezco = @ayudante_parentezco, ayudante_autorizacion = @ayudante_autorizacion, ayudante_numero_oficio = @ayudante_numero_oficio, ayudante_fecha_oficio = @ayudante_fecha_oficio WHERE ayudante_id = @ayudante_id", sql))
                {
                    cmd.Parameters.AddWithValue("ayudante_id", obj.ayudante_id);
                    cmd.Parameters.AddWithValue("ayudante_cedula", obj.ayudante_cedula);
                    cmd.Parameters.AddWithValue("ayudante_nombres", obj.ayudante_nombre);
                    cmd.Parameters.AddWithValue("ayudante_apellidos", obj.ayudante_apellido);
                    cmd.Parameters.AddWithValue("ayudante_parentezco", obj.ayudante_parentezco);
                    cmd.Parameters.AddWithValue("ayudante_autorizacion", obj.ayudante_autorizacion);
                    cmd.Parameters.AddWithValue("ayudante_numero_oficio", obj.ayudante_numero_oficio);
                    cmd.Parameters.AddWithValue("ayudante_fecha_oficio", obj.ayudante_fecha_oficio);
                    await sql.OpenAsync();
                    await cmd.ExecuteNonQueryAsync();
                }
            }
        }

        public async Task Delete(int id)
        {
            using (var sql = new NpgsqlConnection(cn.getCadenaConexion()))
            {
                using (var cmd = new NpgsqlCommand("DELETE FROM catastroestablecimiento.cm_ayudante WHERE ayudante_id = @ayudante_id", sql))
                {
                    cmd.Parameters.AddWithValue("ayudante_id", id);
                    await sql.OpenAsync();
                    await cmd.ExecuteNonQueryAsync();
                }
            }
        }
        
    }
}
