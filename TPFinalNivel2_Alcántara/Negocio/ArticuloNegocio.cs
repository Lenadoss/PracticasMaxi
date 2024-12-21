using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Data;
using dominio;

namespace Negocio
{
    public class ArticuloNegocio
    {
        private List<Articulo> lista = new List<Articulo>();
        AccesoDatos Datos = new AccesoDatos();
        public List<Articulo> CargarListaBD()
        {
            try
            {
                Datos.CrearConexion();
                Datos.Consultar("SELECT A.Codigo, A.Nombre, A.Descripcion, M.Descripcion, C.Descripcion, A.ImagenUrl, A.Precio FROM ARTICULOS AS A, CATEGORIAS AS C, MARCAS AS M WHERE A.IdMarca = M.Id AND A.IdCategoria = C.Id");
                Datos.AbrirConexion();  
                using (SqlDataReader Lector = Datos.LeerConsulta()) //Crea una sola instancia de Lector y cerrará el lector cuando termine

                    while (Lector.Read())
                {
                    Articulo aux = new Articulo();
                    
                    aux.Codigo = (string)Lector["Codigo"];
                    aux.Nombre = (string)Lector["Nombre"];
                    aux.Descripcion = (string)Lector["Descripcion"];
                    aux.Marca = Lector.GetString(3);
                    aux.Categoria = Lector.GetString(4);
                    aux.Imagen = (string)Lector["ImagenUrl"];
                    aux.Precio = (decimal)Lector["Precio"];

                    lista.Add(aux);
                }
                return lista;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return lista;
            }
            finally
            {
                Datos.CerrarConexion();
            }
        }
            
    } 
}