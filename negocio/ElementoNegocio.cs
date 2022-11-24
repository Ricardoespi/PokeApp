using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;

namespace negocio
{
    public class ElementoNegocio
    {
        public List<Elemento> listar()
        {
			List<Elemento> lista = new List<Elemento>();
			AccesoDatos datos = new AccesoDatos();
			try
			{
				datos.setQuery("select Id, Descripcion From ELEMENTOS");
				datos.ejecutarLectura();

				while (datos.Lector.Read())
				{
					Elemento aux = new Elemento();
					aux.Id = (int)datos.Lector["Id"];
					aux.Descripcion = (string)datos.Lector["Descripcion"];
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
				datos.cerrarConexion();
			}
        }
		public void agregar(Elemento nuevo)
		{
			AccesoDatos datos = new AccesoDatos();
			try
			{
				datos.setQuery("insert into Elementos values (@Descripcion)");
				datos.setParametro("@Descripcion", nuevo.Descripcion);
				datos.ejecutarAccion();
			}
			catch (Exception ex)
			{ MessageBox.Show(ex.ToString()); }
			finally
			{
				datos.cerrarConexion();
			}
			
		}
    }
}
