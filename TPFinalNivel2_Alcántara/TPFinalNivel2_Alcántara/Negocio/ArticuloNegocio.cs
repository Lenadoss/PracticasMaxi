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
                Datos.Consultar("SELECT A.Id, A.Codigo, A.Nombre, A.Descripcion, M.Descripcion, C.Descripcion, A.ImagenUrl, A.Precio, M.Id AS IdMarca, C.Id AS IdCategoria FROM ARTICULOS AS A, CATEGORIAS AS C, MARCAS AS M WHERE A.IdMarca = M.Id AND A.IdCategoria = C.Id");
                Datos.AbrirConexion();  
                using (SqlDataReader Lector = Datos.LeerConsulta()) //Crea una sola instancia de Lector y cerrará el lector cuando termine

                while (Lector.Read())
                    {
                        Articulo aux = new Articulo();
                        aux.Id = (int)Lector["Id"];
                        aux.Codigo = (string)Lector["Codigo"];
                        aux.Nombre = (string)Lector["Nombre"];
                        aux.Descripcion = (string)Lector["Descripcion"];

                        aux.Marca = new Marca();
                        aux.Marca.Id = Lector.GetInt32(8);
                        aux.Marca.Descripcion = Lector.GetString(4);

                        aux.Categoria = new Categoria();
                        aux.Categoria.Id = Lector.GetInt32(9);
                        aux.Categoria.Descripcion = Lector.GetString(5); 

                    if(Lector["ImagenUrl"] != DBNull.Value)
                        aux.Imagen = (string)Lector["ImagenUrl"];

                        aux.Precio = (decimal)Lector["Precio"];

                        lista.Add(aux);
                }
                return lista;
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

     public void Agregar(Articulo NuevoArticulo)
        {
            try
            {
                Datos.CrearConexion();
                Datos.AbrirConexion();
                Datos.SetearParametro("@Codigo", NuevoArticulo.Codigo);
                Datos.SetearParametro("@Nombre", NuevoArticulo.Nombre);
                Datos.SetearParametro("@Descripcion", NuevoArticulo.Descripcion);
                Datos.SetearParametro("@IdMarca", NuevoArticulo.Marca.Id);
                Datos.SetearParametro("@IdCategoria", NuevoArticulo.Categoria.Id);
                Datos.SetearParametro("@Imagen", NuevoArticulo.Imagen);
                Datos.SetearParametro("@Precio", NuevoArticulo.Precio);
                Datos.Consultar("INSERT INTO ARTICULOS (Codigo, Nombre, Descripcion, IdMarca, IdCategoria, ImagenUrl, Precio) VALUES (@Codigo, @Nombre, @Descripcion, @IdMarca, @IdCategoria, @Imagen, @Precio)");
                Datos.EjecutarAccion();
            }
            catch (Exception ex )
            {
                throw ex;
            }
            finally
            {
                Datos.CerrarConexion();
            }
        }

        public void Modificar(Articulo Modificar)
        {
            try
            {
                Datos.CrearConexion();
                Datos.AbrirConexion();
                Datos.SetearParametro("@Id", Modificar.Id);
                Datos.SetearParametro("@Codigo", Modificar.Codigo);
                Datos.SetearParametro("@Nombre", Modificar.Nombre);
                Datos.SetearParametro("@Descripcion", Modificar.Descripcion);
                Datos.SetearParametro("@IdMarca", Modificar.Marca.Id);
                Datos.SetearParametro("@IdCategoria", Modificar.Categoria.Id);
                Datos.SetearParametro("@Imagen", Modificar.Imagen);
                Datos.SetearParametro("@Precio", Modificar.Precio);
                Datos.Consultar("UPDATE ARTICULOS SET Codigo = @Codigo, Nombre = @Nombre, Descripcion = @Descripcion, IdMarca = @IdMarca, IdCategoria = @IdCategoria, ImagenUrl = @Imagen, Precio = @Precio WHERE Id = @Id");
                Datos.EjecutarAccion();
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
        public void EliminarBD(Articulo articulo)
        {
            try
            {   
                Datos.CrearConexion();
                Datos.AbrirConexion();
                Datos.SetearParametro("@Id", articulo.Id);
                Datos.Consultar("DELETE FROM ARTICULOS WHERE Id = @Id");
                Datos.EjecutarAccion();
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
        public void EliminarLogico(Articulo articulo)
        {
            try
            {
                Datos.CrearConexion();
                Datos.AbrirConexion();
                Datos.SetearParametro("@Id", articulo.Id);
                Datos.Consultar("UPDATE ARTICULOS SET Activo = 0 WHERE Id = @Id");
                Datos.EjecutarAccion();
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
        public List<Articulo> Actualizar()
        {
            List<Articulo> ListaActualizada = new List<Articulo>();
            try
            {
                Datos.CrearConexion();
                Datos.AbrirConexion();
                Datos.Consultar("SELECT A.Id, A.Codigo, A.Nombre, A.Descripcion, M.Descripcion, C.Descripcion, A.ImagenUrl, A.Precio, M.Id AS IdMarca, C.Id AS IdCategoria FROM ARTICULOS AS A, CATEGORIAS AS C, MARCAS AS M WHERE A.IdMarca = M.Id AND A.IdCategoria = C.Id AND A.Nombre LIKE '%%'");
                using (SqlDataReader Lector = Datos.LeerConsulta())
                {
                    while (Lector.Read())
                    {
                        Articulo aux = new Articulo();
                        aux.Id = (int)Lector["Id"];
                        aux.Codigo = (string)Lector["Codigo"];
                        aux.Nombre = (string)Lector["Nombre"];
                        aux.Descripcion = (string)Lector["Descripcion"];
                        aux.Marca = new Marca();
                        aux.Marca.Id = Lector.GetInt32(8);
                        aux.Marca.Descripcion = Lector.GetString(4);
                        aux.Categoria = new Categoria();
                        aux.Categoria.Id = Lector.GetInt32(9);
                        aux.Categoria.Descripcion = Lector.GetString(5);
                        if (Lector["ImagenUrl"] != DBNull.Value)
                            aux.Imagen = (string)Lector["ImagenUrl"];
                        aux.Precio = (decimal)Lector["Precio"];
                        ListaActualizada.Add(aux);
                    }
                }
                return ListaActualizada;
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

        public List<Articulo> FiltroBD(string campo, string criterio, string filtro)
        {
            string consulta = "SELECT A.Id, A.Codigo, A.Nombre, A.Descripcion, M.Descripcion, C.Descripcion, A.ImagenUrl, A.Precio, M.Id AS IdMarca, C.Id AS IdCategoria FROM ARTICULOS AS A, CATEGORIAS AS C, MARCAS AS M WHERE A.IdMarca = M.Id AND A.IdCategoria = C.Id ";
            List<Articulo> lista = new List<Articulo>();
            try
            {
                if (campo == "Descripción")
                {
                    switch (criterio)
                    {
                        case "Comienza con":
                            consulta += "AND A.Descripcion LIKE '" + filtro + "%'";
                            break;

                        case "Termina con":
                            consulta += "AND A.Descripcion LIKE '%" + filtro + "'";
                            break;

                        default:
                            consulta = consulta + "AND A.Descripcion LIKE '% " + filtro + "%'";
                            break;
                    }
                }
                else
                {
                    switch (criterio)
                    {
                        case "Comienza con":
                            consulta += "AND A.Nombre LIKE '" + filtro + "%'";
                            break;

                        case "Termina con":
                            consulta += "AND A.Nombre LIKE '%" + filtro + "'";
                            break;

                        default:
                            consulta += "AND A.Nombre LIKE '%" + filtro + "%'";
                            break;
                    }
                }

                Datos.CrearConexion();
                Datos.Consultar(consulta);
                Datos.AbrirConexion();
                using (SqlDataReader Lector = Datos.LeerConsulta()) //Crea una sola instancia de Lector y cerrará el lector cuando termine

                    while (Lector.Read())
                    {
                        Articulo aux = new Articulo();
                        aux.Id = (int)Lector["Id"];
                        aux.Codigo = (string)Lector["Codigo"];
                        aux.Nombre = (string)Lector["Nombre"];
                        aux.Descripcion = (string)Lector["Descripcion"];

                        aux.Marca = new Marca();
                        aux.Marca.Id = Lector.GetInt32(8);
                        aux.Marca.Descripcion = Lector.GetString(4);

                        aux.Categoria = new Categoria();
                        aux.Categoria.Id = Lector.GetInt32(9);
                        aux.Categoria.Descripcion = Lector.GetString(5);

                        if (Lector["ImagenUrl"] != DBNull.Value)
                            aux.Imagen = (string)Lector["ImagenUrl"];

                        aux.Precio = (decimal)Lector["Precio"];

                        lista.Add(aux);
                    }
                return lista;
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