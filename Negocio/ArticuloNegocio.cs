using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class ArticuloNegocio
    {

        public List<Articulo> Listar()
        {
            List<Articulo> lista = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                string consulta = @"
                    SELECT A.Id, A.Codigo, A.Nombre, A.Descripcion, A.Precio, 
                           A.IdMarca, M.Descripcion AS MarcaDescripcion, 
                           A.IdCategoria, C.Descripcion AS CategoriaDescripcion
                    FROM ARTICULOS A
                    LEFT JOIN MARCAS M ON A.IdMarca = M.Id
                    LEFT JOIN CATEGORIAS C ON A.IdCategoria = C.Id";
                datos.SetearConsulta(consulta);
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();

                    aux.Id = (int)datos.Lector["Id"];
                    aux.Codigo = (string)datos.Lector["Codigo"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    aux.Precio = (decimal)datos.Lector["Precio"];

                    if (!(datos.Lector["IdMarca"] is DBNull))
                    {
                        aux.IdMarca = (int)datos.Lector["IdMarca"];
                        aux.Marca = new Marca();
                        aux.Marca.Id = aux.IdMarca;
                        string descripcion = datos.Lector["MarcaDescripcion"].ToString();
                        if (descripcion == "")
                        {
                            aux.Marca.Descripcion = "Sin Marca";
                        }
                        else
                        {
                            aux.Marca.Descripcion = descripcion;
                        }
                    }
                    else
                    {
                        aux.Marca.Descripcion = "Sin Marca";
                    }

                    if (!(datos.Lector["IdCategoria"] is DBNull))
                    {
                        aux.IdCategoria = (int)datos.Lector["IdCategoria"];
                        aux.Categoria = new Categoria();
                        aux.Categoria.Id = aux.IdCategoria;
                        string descripcion = datos.Lector["CategoriaDescripcion"].ToString();
                        if (descripcion == "")
                        {
                            aux.Categoria.Descripcion = "Sin Categoría";
                        }
                        else
                        {
                            aux.Categoria.Descripcion = descripcion;
                        }
                    }
                    else
                    {
                        aux.Categoria.Descripcion = "Sin Categoría";
                    }

                    lista.Add(aux);
                }

                return lista;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

            public int Agregar(Articulo nuevo)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.SetearConsulta(@"INSERT INTO ARTICULOS
                                      (Codigo, Nombre, Descripcion, IdMarca, IdCategoria, Precio)
                                      VALUES
                                      (@Codigo, @Nombre, @Descripcion, @IdMarca, @IdCategoria, @Precio);
                                        SELECT SCOPE_IDENTITY()");

                datos.SetearParametro("@Codigo", nuevo.Codigo);
                datos.SetearParametro("@Nombre", nuevo.Nombre);
                datos.SetearParametro("@Descripcion", nuevo.Descripcion);
                datos.SetearParametro("@IdMarca", nuevo.IdMarca);
                datos.SetearParametro("@IdCategoria", nuevo.IdCategoria);
                datos.SetearParametro("@Precio", nuevo.Precio);

                return (int)(decimal)datos.ejecutarScalar();
            }
            catch (Exception)
            {
                throw;
            }
            finally { datos.cerrarConexion(); }
         
    }
}
}
    
