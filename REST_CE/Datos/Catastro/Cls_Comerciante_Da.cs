using Npgsql;
using REST_CE.Models.Catastro;
using System.Data;

namespace REST_CE.Datos.Catastro
{
    public class Cls_Comerciante_Da
    {

        Conexion.Conexion cn = new Conexion.Conexion();
        public async Task<List<Cls_Comerciante_Model>> MostrarProductos()
        {
            var lista = new List<Cls_Comerciante_Model>();
            using (var sql = new NpgsqlConnection(cn.getCadenaConexion()))
            {
                using (var cmd = new NpgsqlCommand("SELECT * FROM  catastroestablecimiento.cm_comerciante", sql))
                {
                    await sql.OpenAsync();
                    using (var dr = await cmd.ExecuteReaderAsync())
                    {
                        while (await dr.ReadAsync())
                        {
                            var obj = new Cls_Comerciante_Model();
                            obj.comerciante_id = dr.GetInt32(0);
                            obj.tipo_identificacion_id = dr.GetInt32(1);
                            obj.tipo_ocupante_id = dr.GetInt32(2);
                            obj.comerciante_cedula_ruc = dr.GetString(3);
                            obj.comerciante_apellidos_razon_social = dr.GetString(4);
                            obj.comerciante_nombres_representante_legal = dr.GetString(5);
                            obj.comerciante_fecha_nacimiento = dr.GetString(6);


                            obj.comerciante_edad = dr.GetInt32(7);
                            obj.comerciante_lugar_origen = dr.GetString(8);
                            obj.comerciante_telefono_convencional = dr.GetString(9);
                            obj.comerciante_telefono_celular = dr.GetString(10);
                            obj.comerciante_direccion_domicilio = dr.GetString(11);

                            obj.comerciante_ciudad = dr.GetString(12);
                            obj.comerciante_provincia = dr.GetString(13);
                            obj.comerciante_mail = dr.GetString(14);
                            obj.comerciante_estado = dr.GetInt32(15);

                            lista.Add(obj);
                        }
                    }
                }
            }
            return lista;
        }

        public async Task Insert(Cls_Comerciante_Model obj)
        {
            using (var sql = new NpgsqlConnection(cn.getCadenaConexion()))
            {
                using (var cmd = new NpgsqlCommand("INSERT INTO catastroestablecimiento.cm_comerciante( tipo_identificacion_id, tipo_ocupante_id, comerciante_cedula_ruc, comerciante_apellidos_razon_social, comerciante_nombres_representante_legal,comerciante_fecha_nacimiento,comerciante_edad,comerciante_lugar_origen,comerciante_telefono_convencional,comerciante_telefono_celular,comerciante_direccion_domicilio,comerciante_ciudad,comerciante_provincia,comerciante_mail,comerciante_estado) VALUES(@tipo_identificacion_id, @tipo_ocupante_id, @comerciante_cedula_ruc, @comerciante_apellidos_razon_social, @comerciante_nombres_representante_legal,@comerciante_fecha_nacimiento,@comerciante_edad,@comerciante_lugar_origen,@comerciante_telefono_convencional,@comerciante_telefono_celular,@comerciante_direccion_domicilio,@comerciante_ciudad,@comerciante_provincia,@comerciante_mail,@comerciante_estado)", sql))
                {
                    cmd.Parameters.AddWithValue("tipo_identificacion_id", obj.tipo_identificacion_id);
                    cmd.Parameters.AddWithValue("tipo_ocupante_id", obj.tipo_ocupante_id);
                    cmd.Parameters.AddWithValue("comerciante_cedula_ruc", obj.comerciante_cedula_ruc);
                    cmd.Parameters.AddWithValue("comerciante_apellidos_razon_social", obj.comerciante_apellidos_razon_social);
                    cmd.Parameters.AddWithValue("comerciante_nombres_representante_legal", obj.comerciante_nombres_representante_legal);
                    cmd.Parameters.AddWithValue("comerciante_fecha_nacimiento", obj.comerciante_fecha_nacimiento);
                    cmd.Parameters.AddWithValue("comerciante_edad", obj.comerciante_edad);
                    cmd.Parameters.AddWithValue("comerciante_lugar_origen", obj.comerciante_lugar_origen);
                    cmd.Parameters.AddWithValue("comerciante_telefono_convencional", obj.comerciante_telefono_convencional);
                    cmd.Parameters.AddWithValue("comerciante_telefono_celular", obj.comerciante_telefono_celular);
                    cmd.Parameters.AddWithValue("comerciante_direccion_domicilio", obj.comerciante_direccion_domicilio);
                    cmd.Parameters.AddWithValue("comerciante_ciudad", obj.comerciante_ciudad);
                    cmd.Parameters.AddWithValue("comerciante_provincia", obj.comerciante_provincia);
                    cmd.Parameters.AddWithValue("comerciante_mail", obj.comerciante_mail);
                    cmd.Parameters.AddWithValue("comerciante_estado", obj.comerciante_estado);
                    await sql.OpenAsync();
                    await cmd.ExecuteNonQueryAsync();
                }
            }
        }


        public async Task Edit(Cls_Comerciante_Model obj)
        {
            using (var sql = new NpgsqlConnection(cn.getCadenaConexion()))
            {
                using (var cmd = new NpgsqlCommand("UPDATE catastroestablecimiento.cm_comerciante SET piso_id=@piso_id, tipo_area_id=@tipo_area_id, comerciante_id=@comerciante_id, ayudante_id=@ayudante_id, reemplazo_id=@reemplazo_id, documento_puesto_id=@documento_puesto_id,puesto_predio=@puesto_predio,puesto_clave_catastral=@puesto_clave_catastral,puesto_area=@puesto_area,puesto_frente=@puesto_frente,puesto_fondo=@puesto_fondo,puesto_estado_conservacion=@puesto_estado_conservacion,puesto_acabados=@puesto_acabados,puesto_paredes=@puesto_paredes,puesto_remodelacion=@puesto_remodelacion WHERE comerciante_id = @comerciante_id", sql))
                {
                    cmd.Parameters.AddWithValue("comerciante_id", obj.comerciante_id);
                    cmd.Parameters.AddWithValue("tipo_identificacion_id", obj.tipo_identificacion_id);
                    cmd.Parameters.AddWithValue("tipo_ocupante_id", obj.tipo_ocupante_id);
                    cmd.Parameters.AddWithValue("comerciante_cedula_ruc", obj.comerciante_cedula_ruc);
                    cmd.Parameters.AddWithValue("comerciante_apellidos_razon_social", obj.comerciante_apellidos_razon_social);
                    cmd.Parameters.AddWithValue("comerciante_nombres_representante_legal", obj.comerciante_nombres_representante_legal);
                    cmd.Parameters.AddWithValue("comerciante_fecha_nacimiento", obj.comerciante_fecha_nacimiento);
                    cmd.Parameters.AddWithValue("comerciante_edad", obj.comerciante_edad);
                    cmd.Parameters.AddWithValue("comerciante_lugar_origen", obj.comerciante_lugar_origen);
                    cmd.Parameters.AddWithValue("comerciante_telefono_convencional", obj.comerciante_telefono_convencional);
                    cmd.Parameters.AddWithValue("comerciante_telefono_celular", obj.comerciante_telefono_celular);
                    cmd.Parameters.AddWithValue("comerciante_direccion_domicilio", obj.comerciante_direccion_domicilio);
                    cmd.Parameters.AddWithValue("comerciante_ciudad", obj.comerciante_ciudad);
                    cmd.Parameters.AddWithValue("comerciante_provincia", obj.comerciante_provincia);
                    cmd.Parameters.AddWithValue("comerciante_mail", obj.comerciante_mail);
                    cmd.Parameters.AddWithValue("comerciante_estado", obj.comerciante_estado);
                    await sql.OpenAsync();
                    await cmd.ExecuteNonQueryAsync();
                }
            }
        }

        public async Task Delete(int id)
        {
            using (var sql = new NpgsqlConnection(cn.getCadenaConexion()))
            {
                using (var cmd = new NpgsqlCommand("DELETE FROM catastroestablecimiento.cm_comerciante WHERE comerciante_id = @comerciante_id", sql))
                {
                    cmd.Parameters.AddWithValue("comerciante_id", id);
                    await sql.OpenAsync();
                    await cmd.ExecuteNonQueryAsync();
                }
            }
        }


    }
}
