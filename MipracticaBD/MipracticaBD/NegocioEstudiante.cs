using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Linq.Expressions;

namespace MipracticaBD
{
    internal class NegocioEstudiante
    {
        public List<Estudiante> ListarEstudiante()
        {
            List<Estudiante> ListaEstudiantes = new List<Estudiante>();  
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;

            try
            {
                conexion.ConnectionString = "Server = ODANEL\\SQLEXPRESS; DataBase = ESTUDIANTES_DB; integrated security = true";
                comando.CommandType = System.Data.CommandType.Text;
                comando.Connection = conexion;
                comando.CommandText = "SELECT id, nombre, apellido, edad FROM INFORMACION";
                conexion.Open();

                lector = comando.ExecuteReader();

                while(lector.Read())
                {
                    Estudiante aux = new Estudiante();
                    aux.Id = lector.GetInt32(0);
                    aux.Nombre = (string)lector["nombre"];
                    aux.Apellido = (string)lector["apellido"];
                    aux.Edad = lector.GetInt32(3);

                    ListaEstudiantes.Add(aux);
                }

                return ListaEstudiantes;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexion.Close();
            }
        }
    }
}
