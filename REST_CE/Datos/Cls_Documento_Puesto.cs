using Npgsql;
using REST_CE.Models;

namespace REST_CE.Datos
{
    public class Cls_Documento_Puesto
    {
        Conexion.Conexion cn = new Conexion.Conexion();

        public async Task <List<Cls_Documento_Puesto_Model>> MostrarProductos()
        {
            var lista = new List<Cls_Documento_Puesto_Model>();
            using (var sql = new NpgsqlConnection(cn.getCadenaConexion()))
            {
                using (var cmd = new NpgsqlCommand("SELECT * FROM catastroestablecimiento.cm_documento_puesto", sql))
                {
                    await sql.OpenAsync();
                    using (var dr = await cmd.ExecuteReaderAsync())
                    {
                        while (await dr.ReadAsync())
                        {
                            var obj = new Cls_Documento_Puesto_Model();
                            obj.DOCUMENTO_PUESTO_ID1 = dr.GetInt32(0);
                            obj.TIPO_DOCUMENTO_PUESTO_ID1 = dr.GetInt32(1);
                            obj.PUESTO_ID1 = dr.GetInt32(2);
                            obj.DOCUMENTO_PUESTO_NOMBRE1 = dr.GetString(3);
                            obj.DOCUMENTO_PUESTO_FECHA1 = dr.GetDateTime(4);
                            obj.DOCUMENTO_PUESTO_DETALLE1 = dr.GetString(5);
                            obj.DOCUMENTO_PUESTO_OBSERVACION1 = dr.GetString(6);
                            obj.DOCUMENTO_PUESTO_ESTADO1 = dr.GetInt16(7);
                            

                            lista.Add(obj);
                        }
                    }
                    
                }
            }
            return lista;

        }   

        public async Task Insert(Cls_Documento_Puesto_Model obj)
        {
            using (var sql = new NpgsqlConnection(cn.getCadenaConexion()))
            {
                using (var cmd = new NpgsqlCommand("INSERT INTO catastroestablecimiento.cm_documento_puesto (TIPO_DOCUMENTO_PUESTO_ID, PUESTO_ID, DOCUMENTO_PUESTO_NOMBRE, DOCUMENTO_PUESTO_FECHA, DOCUMENTO_PUESTO_DETALLE, DOCUMENTO_PUESTO_OBSERVACION, DOCUMENTO_PUESTO_ESTADO) VALUES (@TIPO_DOCUMENTO_PUESTO_ID, @PUESTO_ID, @DOCUMENTO_PUESTO_NOMBRE, @DOCUMENTO_PUESTO_FECHA, @DOCUMENTO_PUESTO_DETALLE, @DOCUMENTO_PUESTO_OBSERVACION, @DOCUMENTO_PUESTO_ESTADO)", sql))
                {
                    await sql.OpenAsync();
                    cmd.Parameters.AddWithValue("@TIPO_DOCUMENTO_PUESTO_ID", obj.TIPO_DOCUMENTO_PUESTO_ID1);
                    cmd.Parameters.AddWithValue("@PUESTO_ID", obj.PUESTO_ID1);
                    cmd.Parameters.AddWithValue("@DOCUMENTO_PUESTO_NOMBRE", obj.DOCUMENTO_PUESTO_NOMBRE1.Trim());
                    cmd.Parameters.AddWithValue("@DOCUMENTO_PUESTO_FECHA", obj.DOCUMENTO_PUESTO_FECHA1);
                    cmd.Parameters.AddWithValue("@DOCUMENTO_PUESTO_DETALLE", obj.DOCUMENTO_PUESTO_DETALLE1.Trim());
                    cmd.Parameters.AddWithValue("@DOCUMENTO_PUESTO_OBSERVACION", obj.DOCUMENTO_PUESTO_OBSERVACION1.Trim());
                    cmd.Parameters.AddWithValue("@DOCUMENTO_PUESTO_ESTADO", obj.DOCUMENTO_PUESTO_ESTADO1);
                    await cmd.ExecuteNonQueryAsync();
                }
            }
        }

        public async Task Edit(Cls_Documento_Puesto_Model obj)
        {
            using (var sql = new NpgsqlConnection(cn.getCadenaConexion()))
            {
                using (var cmd = new NpgsqlCommand("UPDATE catastroestablecimiento.cm_documento_puesto SET TIPO_DOCUMENTO_PUESTO_ID = @TIPO_DOCUMENTO_PUESTO_ID, PUESTO_ID = @PUESTO_ID, DOCUMENTO_PUESTO_NOMBRE = @DOCUMENTO_PUESTO_NOMBRE, DOCUMENTO_PUESTO_FECHA = @DOCUMENTO_PUESTO_FECHA, DOCUMENTO_PUESTO_DETALLE = @DOCUMENTO_PUESTO_DETALLE, DOCUMENTO_PUESTO_OBSERVACION = @DOCUMENTO_PUESTO_OBSERVACION, DOCUMENTO_PUESTO_ESTADO = @DOCUMENTO_PUESTO_ESTADO WHERE DOCUMENTO_PUESTO_ID = @DOCUMENTO_PUESTO_ID", sql))
                {
                    await sql.OpenAsync();
                    cmd.Parameters.AddWithValue("@DOCUMENTO_PUESTO_ID", obj.DOCUMENTO_PUESTO_ID1);
                    cmd.Parameters.AddWithValue("@TIPO_DOCUMENTO_PUESTO_ID", obj.TIPO_DOCUMENTO_PUESTO_ID1);
                    cmd.Parameters.AddWithValue("@PUESTO_ID", obj.PUESTO_ID1);
                    cmd.Parameters.AddWithValue("@DOCUMENTO_PUESTO_NOMBRE", obj.DOCUMENTO_PUESTO_NOMBRE1.Trim());
                    cmd.Parameters.AddWithValue("@DOCUMENTO_PUESTO_FECHA", obj.DOCUMENTO_PUESTO_FECHA1);
                    cmd.Parameters.AddWithValue("@DOCUMENTO_PUESTO_DETALLE", obj.DOCUMENTO_PUESTO_DETALLE1.Trim());
                    cmd.Parameters.AddWithValue("@DOCUMENTO_PUESTO_OBSERVACION", obj.DOCUMENTO_PUESTO_OBSERVACION1.Trim());
                    cmd.Parameters.AddWithValue("@DOCUMENTO_PUESTO_ESTADO", obj.DOCUMENTO_PUESTO_ESTADO1);
                    await cmd.ExecuteNonQueryAsync();
                }
            }
        }   

        public async Task Delete(int id)
        {
            using (var sql = new NpgsqlConnection(cn.getCadenaConexion()))
            {
                using (var cmd = new NpgsqlCommand("DELETE FROM catastroestablecimiento.cm_documento_puesto WHERE DOCUMENTO_PUESTO_ID = @DOCUMENTO_PUESTO_ID", sql))
                {
                    await sql.OpenAsync();
                    cmd.Parameters.AddWithValue("@DOCUMENTO_PUESTO_ID", id);
                    await cmd.ExecuteNonQueryAsync();
                }
            }
        }
    }
}
