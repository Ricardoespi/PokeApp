using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using dominio;
using System.Security.AccessControl;
using System.Windows.Forms;

namespace negocio
{
    public class PokemonDatos
    {
        public List<Pokemon> listar()
        {
            List<Pokemon> lista = new List<Pokemon>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;
            try
            {
                conexion.ConnectionString = "server=.\\SQLEXPRESS; database=POKEDEX_DB; integrated security=true; ";
                comando.CommandType= System.Data.CommandType.Text;
                comando.CommandText = "select Numero, Nombre, P.Descripcion, UrlImagen, E.Descripcion Tipo, d.Descripcion Debilidad, P.IdTipo, P.IdDebilidad, P.Id from POKEMONS P, ELEMENTOS E, ELEMENTOS d  where p.IdTipo = E.Id and d.Id = p.IdDebilidad and p.Activo = 1";
                comando.Connection = conexion;

                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Pokemon aux = new Pokemon();
                    aux.Id = (int)lector["Id"];
                    aux.Numero = lector.GetInt32(0);
                    aux.Nombre = (string)lector["Nombre"];
                    aux.Descripcion = (string)lector["Descripcion"];

                    //if (!(lector.IsDBNull(lector.GetOrdinal("UrlImagen"))))
                    //    aux.UrlImagen = (string)lector["UrlImagen"];
                    if (!(lector["UrlImagen"] is DBNull))
                        aux.UrlImagen = (string)lector["UrlImagen"];

                    aux.Tipo = new Elemento();
                    aux.Tipo.Id = (int)lector["IdTipo"];
                    aux.Tipo.Descripcion = (string)lector["Tipo"];
                    aux.Debilidad = new Elemento();
                    aux.Debilidad.Id = (int)lector["IdDebilidad"];
                    aux.Debilidad.Descripcion = (string)lector["Debilidad"];

                    lista.Add(aux);
                }
                conexion.Close();
                return lista;
            }
            catch (Exception ex)
            {throw ex;}
            
        }
        public void agregar(Pokemon nuevo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setQuery(string.Format("insert into POKEMONS (Numero, Nombre, Descripcion, Activo, IdTipo, IdDebilidad, UrlImagen) values ({0}, '{1}', '{2}', 1, @idTipo, @idDebilidad, @urlImagen)", nuevo.Numero, nuevo.Nombre, nuevo.Descripcion));
                datos.setParametro("@idTipo", nuevo.Tipo.Id);
                datos.setParametro("@idDebilidad", nuevo.Debilidad.Id);
                datos.setParametro("@urlImagen", nuevo.UrlImagen);
                datos.ejecutarAccion();
            }
            catch (Exception ex) { throw ex; }
            finally { datos.cerrarConexion(); }
        }
        public void modificar(Pokemon poke)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setQuery("update POKEMONS set Numero = @numero, Nombre = @nombre, Descripcion = @desc, UrlImagen = @img, IdTipo = @idTipo, IdDebilidad = @idDebilidad where Id = @id;");
                datos.setParametro("@numero", poke.Numero);
                datos.setParametro("@nombre", poke.Nombre);
                datos.setParametro("@desc", poke.Descripcion);
                datos.setParametro("@img", poke.UrlImagen);
                datos.setParametro("@idTipo", poke.Tipo.Id);
                datos.setParametro("@idDebilidad", poke.Debilidad.Id);
                datos.setParametro("@id", poke.Id);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            { throw ex; }
            finally
            {
                datos.cerrarConexion();
            }
        }
        public void eliminar(int id)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setQuery("delete from pokemons where id = @id");
                datos.setParametro("@id", id);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            { throw ex; }
            finally
            {
                datos.cerrarConexion();
            }
        }
        public void eliminarLogico(int id)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setQuery("update POKEMONS set Activo = 0 where id = @id");
                datos.setParametro("@id", id);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            { throw ex; }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public List<Pokemon> filtrar(string campo, string criterio, string filtro)
        {
            List<Pokemon> lista = new List<Pokemon>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                string consulta = "select Numero, Nombre, P.Descripcion, UrlImagen, E.Descripcion Tipo, d.Descripcion Debilidad, P.IdTipo, P.IdDebilidad, P.Id from POKEMONS P, ELEMENTOS E, ELEMENTOS d  where p.IdTipo = E.Id and d.Id = p.IdDebilidad and p.Activo = 1 ";
                consulta += "and p." + campo;
                if (campo == "Numero" && filtro != "")
                {
                    switch (criterio)
                    {
                        case "Mayor a":
                            consulta += " > ";
                            break;
                        case "Menor a":
                            consulta += " < ";
                            break;
                        case "Igual a":
                            consulta += " = ";
                            break;
                    }
                    consulta += filtro;
                }
                else
                {
                    consulta += " like '";
                    switch (criterio)
                    {
                        case "Contiene":
                            consulta += "%" + filtro + "%'";
                            break;
                        case "Comienza con":
                            consulta += filtro + "%'";
                            break;
                        default:
                            consulta += "%" + filtro + "'";
                            break;
                    }
                }
                datos.setQuery(consulta);
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Pokemon aux = new Pokemon();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Numero = datos.Lector.GetInt32(0);
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    if (!(datos.Lector["UrlImagen"] is DBNull))
                        aux.UrlImagen = (string)datos.Lector["UrlImagen"];
                    aux.Tipo = new Elemento();
                    aux.Tipo.Id = (int)datos.Lector["IdTipo"];
                    aux.Tipo.Descripcion = (string)datos.Lector["Tipo"];
                    aux.Debilidad = new Elemento();
                    aux.Debilidad.Id = (int)datos.Lector["IdDebilidad"];
                    aux.Debilidad.Descripcion = (string)datos.Lector["Debilidad"];
                    lista.Add(aux);
                }

                return lista;
            }
            catch (Exception ex)
            { throw ex; }
            finally
            {
                datos.cerrarConexion();
            }
        }
        public List<Pokemon> filtrar(string campo, string criterio, string filtro, string campo2, string criterio2, string filtro2)
        {
            List<Pokemon> lista = new List<Pokemon>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                string consulta = "select Numero, Nombre, P.Descripcion, UrlImagen, E.Descripcion Tipo, d.Descripcion Debilidad, P.IdTipo, P.IdDebilidad, P.Id from POKEMONS P, ELEMENTOS E, ELEMENTOS d  where p.IdTipo = E.Id and d.Id = p.IdDebilidad and p.Activo = 1 ";
                consulta += "and p." + campo;
                if (campo == "Numero")
                {
                    switch (criterio)
                    {
                        case "Mayor a":
                            consulta += " > ";
                            break;
                        case "Menor a":
                            consulta += " < ";
                            break;
                        case "Igual a":
                            consulta += " = ";
                            break;
                    }
                    consulta += filtro;
                }
                else
                {
                    consulta += " like '";
                    switch (criterio)
                    {
                        case "Contiene":
                            consulta += "%" + filtro + "%'";
                            break;
                        case "Comienza con":
                            consulta += filtro + "%'";
                            break;
                        default:
                            consulta += "%" + filtro + "'";
                            break;
                    }
                }
                consulta += " and p." + campo2;
                if (campo2 == "Numero" && filtro2 != "")
                {
                    switch (criterio2)
                    {
                        case "Mayor a":
                            consulta += " > ";
                            break;
                        case "Menor a":
                            consulta += " < ";
                            break;
                        case "Igual a":
                            consulta += " = ";
                            break;
                    }
                    consulta += filtro2;
                }
                else
                {
                    consulta += " like '";
                    switch (criterio2)
                    {
                        case "Contiene":
                            consulta += "%" + filtro2 + "%'";
                            break;
                        case "Comienza con":
                            consulta += filtro2 + "%'";
                            break;
                        default:
                            consulta += "%" + filtro2 + "'";
                            break;
                    }
                }
                datos.setQuery(consulta);
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Pokemon aux = new Pokemon();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Numero = datos.Lector.GetInt32(0);
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    if (!(datos.Lector["UrlImagen"] is DBNull))
                        aux.UrlImagen = (string)datos.Lector["UrlImagen"];
                    aux.Tipo = new Elemento();
                    aux.Tipo.Id = (int)datos.Lector["IdTipo"];
                    aux.Tipo.Descripcion = (string)datos.Lector["Tipo"];
                    aux.Debilidad = new Elemento();
                    aux.Debilidad.Id = (int)datos.Lector["IdDebilidad"];
                    aux.Debilidad.Descripcion = (string)datos.Lector["Debilidad"];
                    lista.Add(aux);
                }

                return lista;
            }
            catch (Exception ex)
            { throw ex; }
            finally
            {
                datos.cerrarConexion();
            }
        }
    }
}
