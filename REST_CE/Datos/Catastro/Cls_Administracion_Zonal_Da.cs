using Microsoft.EntityFrameworkCore.Infrastructure;
using Npgsql;
using REST_CE.Models.Catastro;
namespace REST_CE.Datos.Catastro
{
    public class Cls_Administracion_Zonal_Da
    {
        Conexion.Conexion cn = new Conexion.Conexion();
        public async Task<List<Cls_Administracion_Zonal_Model>> MostrarProductos()
        {
            var lista = new List<Cls_Administracion_Zonal_Model>();
            using (var sql = new NpgsqlConnection(cn.getCadenaConexion()))
            {
                using (var cmd = new NpgsqlCommand("SELECT * FROM catastroestablecimiento.cm_administracion_zonal", sql))
                {
                    await sql.OpenAsync();
                    using (var dr = await cmd.ExecuteReaderAsync())
                    {
                        while (await dr.ReadAsync())
                        {
                            var obj = new Cls_Administracion_Zonal_Model();
                            obj.administracion_zonal_id = dr.GetInt32(0);
                            obj.administracion_zonal_nombre = dr.GetString(1);
                            obj.administracion_zonal_detalle = dr.GetString(2);
                            obj.administracion_zonal_telefono = dr.GetString(3);
                            obj.administracion_zonal_celular = dr.GetString(4);
                            obj.administracion_zonal_mail = dr.GetString(5);
                            obj.administracion_zonal_pagina_web = dr.GetString(6);
                            obj.administracion_zonal_representante = dr.GetString(7);
                            obj.administracion_zonal_estado = dr.GetInt32(8);
                            lista.Add(obj);
                        }
                    }
                    await sql.CloseAsync();
                }
            }
            return lista;
        }   
        public async Task Insert(Cls_Administracion_Zonal_Model obj)
        {
            using (var sql = new NpgsqlConnection(cn.getCadenaConexion()))
            {
                using (var cmd = new NpgsqlCommand("INSERT INTO catastroestablecimiento.cm_administracion_zonal(administracion_zonal_nombre, administracion_zonal_detalle, administracion_zonal_telefono, administracion_zonal_celular, administracion_zonal_mail, administracion_zonal_pagina_web, administracion_zonal_representante, administracion_zonal_estado) VALUES(@administracion_zonal_nombre, @administracion_zonal_detalle, @administracion_zonal_telefono, @administracion_zonal_celular, @administracion_zonal_mail, @administracion_zonal_pagina_web, @administracion_zonal_representante, @administracion_zonal_estado)", sql))
                {
                    cmd.Parameters.AddWithValue("administracion_zonal_nombre", obj.administracion_zonal_nombre);
                    cmd.Parameters.AddWithValue("administracion_zonal_detalle", obj.administracion_zonal_detalle);
                    cmd.Parameters.AddWithValue("administracion_zonal_telefono", obj.administracion_zonal_telefono);
                    cmd.Parameters.AddWithValue("administracion_zonal_celular", obj.administracion_zonal_celular);
                    cmd.Parameters.AddWithValue("administracion_zonal_mail", obj.administracion_zonal_mail);
                    cmd.Parameters.AddWithValue("administracion_zonal_pagina_web", obj.administracion_zonal_pagina_web);
                    cmd.Parameters.AddWithValue("administracion_zonal_representante", obj.administracion_zonal_representante);
                    cmd.Parameters.AddWithValue("administracion_zonal_estado", obj.administracion_zonal_estado);
                    await sql.OpenAsync();
                    await cmd.ExecuteNonQueryAsync();
                    await sql.CloseAsync();
                }
            }
        }
        public async Task Update(Cls_Administracion_Zonal_Model obj)
        {
            using (var sql = new NpgsqlConnection(cn.getCadenaConexion()))
            {
                using (var cmd = new NpgsqlCommand("UPDATE catastroestablecimiento.cm_administracion_zonal SET administracion_zonal_nombre = @administracion_zonal_nombre, administracion_zonal_detalle = @administracion_zonal_detalle, administracion_zonal_telefono = @administracion_zonal_telefono, administracion_zonal_celular = @administracion_zonal_celular, administracion_zonal_mail = @administracion_zonal_mail, administracion_zonal_pagina_web = @administracion_zonal_pagina_web, administracion_zonal_representante = @administracion_zonal_representante, administracion_zonal_estado = @administracion_zonal_estado WHERE administracion_zonal_id = @administracion_zonal_id", sql))
                {
                    cmd.Parameters.AddWithValue("administracion_zonal_id", obj.administracion_zonal_id);
                    cmd.Parameters.AddWithValue("administracion_zonal_nombre", obj.administracion_zonal_nombre);
                    cmd.Parameters.AddWithValue("administracion_zonal_detalle", obj.administracion_zonal_detalle);
                    cmd.Parameters.AddWithValue("administracion_zonal_telefono", obj.administracion_zonal_telefono);
                    cmd.Parameters.AddWithValue("administracion_zonal_celular", obj.administracion_zonal_celular);
                    cmd.Parameters.AddWithValue("administracion_zonal_mail", obj.administracion_zonal_mail);
                    cmd.Parameters.AddWithValue("administracion_zonal_pagina_web", obj.administracion_zonal_pagina_web);
                    cmd.Parameters.AddWithValue("administracion_zonal_representante", obj.administracion_zonal_representante);
                    cmd.Parameters.AddWithValue("administracion_zonal_estado", obj.administracion_zonal_estado);
                    await sql.OpenAsync();
                    await cmd.ExecuteNonQueryAsync();
                    await sql.CloseAsync();
                }
            }
        }
        public async Task Delete(int id)
        {
            using (var sql = new NpgsqlConnection(cn.getCadenaConexion()))
            {
                using (var cmd = new NpgsqlCommand("DELETE FROM catastroestablecimiento.cm_administracion_zonal WHERE administracion_zonal_id = @administracion_zonal_id", sql))
                {
                    cmd.Parameters.AddWithValue("administracion_zonal_id", id);
                    await sql.OpenAsync();
                    await cmd.ExecuteNonQueryAsync();
                    await sql.CloseAsync();
                }
            }
        }
    }
}
