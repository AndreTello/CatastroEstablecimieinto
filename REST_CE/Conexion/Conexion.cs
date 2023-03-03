namespace REST_CE.Conexion
{
    public class Conexion
    {
        private string cadenaConexion = string.Empty;
        public Conexion()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json").Build();
            cadenaConexion= builder.GetSection("ConnectionStrings:DefaultConnection").Value;
        }
        public string getCadenaConexion()
        {
            return cadenaConexion;
        }
    }
}
