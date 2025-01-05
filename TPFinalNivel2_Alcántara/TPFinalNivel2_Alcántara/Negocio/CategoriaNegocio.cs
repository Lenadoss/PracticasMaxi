using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using dominio;

namespace Negocio
{
    public class CategoriaNegocio
    {
        AccesoDatos Datos = new AccesoDatos();
        private List<Categoria> Lista = new List<Categoria>();

        public List<Categoria> Listar()
        {
            try
            {
                Datos.CrearConexion();
                Datos.Consultar("SELECT Id, Descripcion FROM CATEGORIAS");
                Datos.AbrirConexion();
                using (SqlDataReader Lector = Datos.LeerConsulta())
                    while (Lector.Read())
                    {
                        Categoria aux = new Categoria();
                        aux.Id = (int)Lector["Id"];
                        aux.Descripcion = (string)Lector["Descripcion"];
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
                Datos.CerrarConexion();
            }
        }
    }
}
