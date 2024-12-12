using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicaciónPráctica
{
    internal class DiscoNegocio
    {
        public List<Disco> Listar()
        {
            List<Disco> Lista = new List<Disco>();
            SqlConnection Conexion = new SqlConnection();
            SqlCommand Comando = new SqlCommand();
            SqlDataReader Lector;

            try
            {
                Conexion.ConnectionString = "Server = ODANEL\\SQLEXPRESS; DataBase = DISCOS_DB; Integrated Security = true";
                Comando.CommandType = System.Data.CommandType.Text;
                Comando.CommandText = "SELECT D.Id, D.Titulo, D.FechaLanzamiento, D.CantidadCanciones, D.UrlImagenTapa, E.Descripcion, T.Descripcion AS EDICION FROM DISCOS AS D, ESTILOS AS E, TIPOSEDICION AS T WHERE D.IdEstilo = E.Id AND D.IdTipoEdicion = T.Id";
                Comando.Connection = Conexion;
                Conexion.Open();
                Lector = Comando.ExecuteReader();

                while (Lector.Read())
                {
                    int Id = (int)Lector["Id"];
                    string Titulo = (string)Lector["Titulo"];
                    DateTime FechaLanzamiento = (DateTime)Lector["FechaLanzamiento"];
                    int CantidadCanciones = (int)Lector["CantidadCanciones"];
                    string UrlImagen = (string)Lector["UrlImagenTapa"];
                    string Estilo = (string)Lector["Descripcion"];
                    string TipoEdicion = (string)Lector["EDICION"];

                    Disco aux = new Disco(Id, Titulo, FechaLanzamiento, CantidadCanciones, UrlImagen, Estilo, TipoEdicion);
                    Lista.Add(aux);
                }
                return Lista;
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                Conexion.Close();
            }
        }
    }
}
