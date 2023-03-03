
using Npgsql;
using REST_CE.Conexion;
using REST_CE.Models;
using System.Formats.Asn1;

namespace REST_CE.Datos
{
    public class Cls_Tipo_Documento_Puesto
    {
        Conexion.Conexion cn = new Conexion.Conexion();

        public async Task <List<Cls_Tipo_Documento_Puesto_Model>> MostrarProductos()
        {
            var lista = new List<Cls_Tipo_Documento_Puesto_Model>();
            using (var sql = new NpgsqlConnection(cn.getCadenaConexion()))
            {
                using (var cmd = new NpgsqlCommand("SELECT * FROM catastroestablecimiento.cm_tipo_documento_puesto", sql))
                {
                    await sql.OpenAsync();
                    using (var dr = await cmd.ExecuteReaderAsync())
                    {
                        while (await dr.ReadAsync())
                        {
                            var obj = new Cls_Tipo_Documento_Puesto_Model();
                            obj.TIPO_DOCUMENTO_PUESTO_ID1 = dr.GetInt32(0);
                            obj.TIPO_DOCUMENTO_PUESTO_NOMBRE1 = dr.GetString(1);
                            obj.TIPO_DOCUMENTO_PUESTO_ESTADO1 = dr.GetInt16(2);
                            lista.Add(obj);
                        }
                    }
                    
                }
            }
            return lista;

        }

        public async Task Insert(Cls_Tipo_Documento_Puesto_Model obj)
        {
            using (var sql = new NpgsqlConnection(cn.getCadenaConexion()))
            {
                using (var cmd = new NpgsqlCommand("INSERT INTO catastroestablecimiento.cm_tipo_documento_puesto (TIPO_DOCUMENTO_PUESTO_NOMBRE, TIPO_DOCUMENTO_PUESTO_ESTADO) VALUES (@TIPO_DOCUMENTO_PUESTO_NOMBRE, @TIPO_DOCUMENTO_PUESTO_ESTADO)", sql))
                {
                    await sql.OpenAsync();
                    cmd.Parameters.AddWithValue("@TIPO_DOCUMENTO_PUESTO_NOMBRE", obj.TIPO_DOCUMENTO_PUESTO_NOMBRE1.Trim());
                    cmd.Parameters.AddWithValue("@TIPO_DOCUMENTO_PUESTO_ESTADO", obj.TIPO_DOCUMENTO_PUESTO_ESTADO1);
                    await cmd.ExecuteNonQueryAsync();
                }
            }
        }

        public async Task Edit(Cls_Tipo_Documento_Puesto_Model obj)
        {
            using (var sql = new NpgsqlConnection(cn.getCadenaConexion()))
            {
                using (var cmd = new NpgsqlCommand("update catastroestablecimiento.cm_tipo_documento_puesto set TIPO_DOCUMENTO_PUESTO_NOMBRE = @TIPO_DOCUMENTO_PUESTO_NOMBRE , TIPO_DOCUMENTO_PUESTO_ESTADO =  @TIPO_DOCUMENTO_PUESTO_ESTADO where TIPO_DOCUMENTO_PUESTO_ID = @TIPO_DOCUMENTO_PUESTO_ID", sql))
                {
                    await sql.OpenAsync();

                    cmd.Parameters.AddWithValue("@TIPO_DOCUMENTO_PUESTO_ID", obj.TIPO_DOCUMENTO_PUESTO_ID1);
                    cmd.Parameters.AddWithValue("@TIPO_DOCUMENTO_PUESTO_NOMBRE", obj.TIPO_DOCUMENTO_PUESTO_NOMBRE1.Trim());
                    cmd.Parameters.AddWithValue("@TIPO_DOCUMENTO_PUESTO_ESTADO", obj.TIPO_DOCUMENTO_PUESTO_ESTADO1);
                    await cmd.ExecuteNonQueryAsync();
                }
            }
        }

        public async Task Delete(int id)
        {
            using (var sql = new NpgsqlConnection(cn.getCadenaConexion()))
            {
                using (var cmd = new NpgsqlCommand("delete from catastroestablecimiento.cm_tipo_documento_puesto where TIPO_DOCUMENTO_PUESTO_ID = @TIPO_DOCUMENTO_PUESTO_ID", sql))
                {
                    await sql.OpenAsync();
                    cmd.Parameters.AddWithValue("@TIPO_DOCUMENTO_PUESTO_ID", id);
                    await cmd.ExecuteNonQueryAsync();
                }
            }
        }
    }

}
