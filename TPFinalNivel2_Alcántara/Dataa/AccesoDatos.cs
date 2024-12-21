using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class AccesoDatos
    {
        private SqlConnection Conexion = new SqlConnection();
        private SqlCommand Comando = new SqlCommand();
        private SqlDataReader Lector;
    
        public void CrearConexion()
        {
            try
            {
                Conexion.ConnectionString = "Server = .\\SQLEXPRESS; DataBase = CATALOGO_DB; integrated security = true";
                Comando.Connection = Conexion;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        public void Consultar(string Consulta)
        {
            try
            {
                Comando.CommandType = System.Data.CommandType.Text;
                Comando.CommandText = Consulta;
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void AbrirConexion() 
        {
            try
            {
                Conexion.Open();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public SqlDataReader LeerConsulta()
        {
            Comando.Connection = Conexion;
            try
            {
                Lector = Comando.ExecuteReader();
                return Lector;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void CerrarConexion()
        {
            try
            {
                if (Lector != null)
                    Lector.Close();
                Conexion.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
