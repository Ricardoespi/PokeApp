using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocio;

namespace winformapp_1_
{
    public partial class frmNuevoPokemon : Form
    {
        private Pokemon pokemon = null;
        OpenFileDialog archivo = null;
        public frmNuevoPokemon()
        {
            InitializeComponent();
        }
        public frmNuevoPokemon(Pokemon pokemon)
        {
            InitializeComponent();
            this.pokemon = pokemon;
            Text = "Modificar Pokemon";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            PokemonDatos negocio = new PokemonDatos();
            try
            {
                if (pokemon == null)
                    pokemon = new Pokemon();
            
                pokemon.Numero = int.Parse(txtbxNumero.Text);
                pokemon.Nombre = txtbxNombre.Text;
                pokemon.Descripcion = txtbxDescripcion.Text;
                pokemon.UrlImagen = txtbxUrlImagen.Text;
                pokemon.Tipo = (Elemento)cboTipo.SelectedItem;
                pokemon.Debilidad = (Elemento)cboDebilidad.SelectedItem;

                if(pokemon.Id != 0)
                {
                    negocio.modificar(pokemon);
                    MessageBox.Show("Modificado exitosamente");
                }
                else
                {
                    negocio.agregar(pokemon);
                    MessageBox.Show("Agregado exitosamente");
                }

                if (archivo != null && !(txtbxUrlImagen.Text.Contains("http")))
                    File.Copy(archivo.FileName, ConfigurationManager.AppSettings["image-folder"] + archivo.SafeFileName, true);

                    Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void frmNuevoPokemon_Load(object sender, EventArgs e)
        {
            ElementoNegocio elementoNegocio = new ElementoNegocio();
            try
            {
                cboTipo.DataSource = elementoNegocio.listar();
                cboTipo.ValueMember = "Id";
                cboTipo.DisplayMember = "Descripcion";
                cboDebilidad.DataSource = elementoNegocio.listar();
                cboDebilidad.ValueMember = "Id";
                cboDebilidad.DisplayMember = "Descripcion";

                if(pokemon != null)
                {
                    txtbxNumero.Text = pokemon.Numero.ToString();
                    txtbxNombre.Text = pokemon.Nombre;
                    txtbxDescripcion.Text = pokemon.Descripcion;
                    txtbxUrlImagen.Text = pokemon.UrlImagen;
                    cargarImagen(pokemon.UrlImagen);
                    cboTipo.SelectedValue = pokemon.Tipo.Id;
                    cboDebilidad.SelectedValue = pokemon.Debilidad.Id;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void txtbxUrlImagen_Leave(object sender, EventArgs e)
        {
            cargarImagen(txtbxUrlImagen.Text);
        }
        private void cargarImagen(string imagen)
        {
            try { pbxNuevoPokemon.Load(imagen); }
            catch (Exception ex) { pbxNuevoPokemon.Load("https://t3.ftcdn.net/jpg/02/48/42/64/360_F_248426448_NVKLywWqArG2ADUxDq6QprtIzsF82dMF.jpg"); }
        }

        private void btnAgregarImagen_Click(object sender, EventArgs e)
        {
            archivo = new OpenFileDialog();
            archivo.Filter = "jpg|*.jpg|png|*.png";
            if(archivo.ShowDialog() == DialogResult.OK)
            {
                txtbxUrlImagen.Text = archivo.FileName;
                cargarImagen(archivo.FileName);
                //File.Copy(archivo.FileName, ConfigurationManager.AppSettings["image-folder"] + archivo.SafeFileName);
            }
        }
    }
}
