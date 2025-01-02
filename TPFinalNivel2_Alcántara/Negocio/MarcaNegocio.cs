using Data;
using dominio;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
   public class MarcaNegocio
   {
        AccesoDatos Datos = new AccesoDatos();
        private List<Marca> Lista = new List<Marca>();

        public List<Marca> Listar()
        {
            try
            {
                Datos.CrearConexion();
                Datos.Consultar("SELECT Id, Descripcion FROM MARCAS");
                Datos.AbrirConexion();
                using (SqlDataReader Lector = Datos.LeerConsulta())
                    while (Lector.Read())
                    {
                        var aux = new Marca();
                        aux.Id = (int)Lector["Id"];
                        aux.Descripcion = (string)Lector["Descripcion"];
                        Lista.Add(aux);
                    }
                return Lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                Datos.CerrarConexion();
            }
        }
   }
}
