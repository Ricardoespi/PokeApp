using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocio;

namespace winformapp_1_
{
    public partial class frmPokemons : Form
    {
        private List<Pokemon> listaPokemons; 
        private List<Pokemon> listaFiltrada;
        public frmPokemons()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            cargar();
            cboCampo.Items.Add("Numero");
            cboCampo.Items.Add("Nombre");
            cboCampo.Items.Add("Descripcion");
            cboCampo2.Items.Add("Numero");
            cboCampo2.Items.Add("Nombre");
            cboCampo2.Items.Add("Descripcion");
        }
        private void dgvPokemons_SelectionChanged(object sender, EventArgs e)
        {
            if(dgvPokemons.CurrentRow != null)
            {
                Pokemon seleccionado = (Pokemon)dgvPokemons.CurrentRow.DataBoundItem;
                cargarImagen(seleccionado.UrlImagen);
            }
            
        }
        private void cargar()
        {
            PokemonDatos datos = new PokemonDatos();
            try
            {
                listaPokemons = datos.listar();
                dgvPokemons.DataSource = listaPokemons;
                ocultarColumnas();
                cargarImagen(listaPokemons[0].UrlImagen);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void ocultarColumnas()
        {
            dgvPokemons.Columns["UrlImagen"].Visible = false;
            dgvPokemons.Columns["Id"].Visible = false;
        }
        private void cargarImagen(string imagen)
        {
            try{ pbxPokemons.Load(imagen); }
            catch (Exception ex){ pbxPokemons.Load("https://t3.ftcdn.net/jpg/02/48/42/64/360_F_248426448_NVKLywWqArG2ADUxDq6QprtIzsF82dMF.jpg"); }
        }

        private void btnElementos_Click(object sender, EventArgs e)
        {
            new frmElementos().ShowDialog();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmNuevoPokemon alta = new frmNuevoPokemon();
            alta.ShowDialog();
            cargar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvPokemons.CurrentRow != null)
            {
                Pokemon seleccionado = (Pokemon)dgvPokemons.CurrentRow.DataBoundItem;
                frmNuevoPokemon modificar = new frmNuevoPokemon(seleccionado);
                modificar.ShowDialog();
                cargar();
            }
        }

        private void btnEliminarFisico_Click(object sender, EventArgs e)
        {
            eliminar();
        }

        private void btnEliminarLogico_Click(object sender, EventArgs e)
        {
            eliminar(true);
        }
        private void eliminar(bool logico = false)
        {
            if(dgvPokemons.CurrentRow != null)
            {
                Pokemon seleccionado;
                PokemonDatos conexion = new PokemonDatos();
                try
                {
                    if (DialogResult.Yes == MessageBox.Show("¿Estas seguro de que quieres eliminarlo?", "Eliminar Pokemon", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation))
                    {
                        seleccionado = (Pokemon)dgvPokemons.CurrentRow.DataBoundItem;
                        if (logico)
                            conexion.eliminarLogico(seleccionado.Id);
                        else
                            conexion.eliminar(seleccionado.Id);
                        cargar();
                    }
                }
                catch (Exception ex)
                { MessageBox.Show(ex.ToString()); }
            }
        }
        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtFiltro.Text;
            try
            {
                if (filtro != "")
                {
                    if (rbNombre.Checked)
                    {
                        listaFiltrada = listaPokemons.FindAll(x => x.Nombre.ToUpper().Contains(filtro.ToUpper()));
                        goto found;
                    }
                    if (rbNumero.Checked)
                    {
                        listaFiltrada = listaPokemons.FindAll(x => x.Numero.ToString().Contains(filtro));
                        goto found;
                    }
                    if (rbDescripcion.Checked)
                    {
                        listaFiltrada = listaPokemons.FindAll(x => x.Descripcion.ToUpper().Contains(filtro.ToUpper()));
                        goto found;
                    }
                    if (rbTipo.Checked)
                    {
                        listaFiltrada = listaPokemons.FindAll(x => x.Tipo.Descripcion.ToUpper().Contains(filtro.ToUpper()));
                        goto found;
                    }
                    if (rbDebilidad.Checked)
                    {
                        listaFiltrada = listaPokemons.FindAll(x => x.Debilidad.Descripcion.ToUpper().Contains(filtro.ToUpper()));
                        goto found;
                    }
                }
                else
                    listaFiltrada = listaPokemons;
                found:
                {
                    dgvPokemons.DataSource = null;
                    dgvPokemons.DataSource = listaFiltrada;
                    ocultarColumnas();
                }
                
            
            }
            catch (Exception ex)
            { throw ex; }
        }

        private void cboCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcion = cboCampo.SelectedItem.ToString();
            if(opcion == "Numero")
            {
                cboCriterio.Items.Clear();
                cboCriterio.Items.Add("Mayor a");
                cboCriterio.Items.Add("Menor a");
                cboCriterio.Items.Add("Igual a");
            }
            else
            {
                cboCriterio.Items.Clear();
                cboCriterio.Items.Add("Contiene");
                cboCriterio.Items.Add("Comienza con");
                cboCriterio.Items.Add("Termina con");
            }
        }
        private bool validarFiltro()
        {
            if(cboCampo.SelectedIndex < 0)
            {
                MessageBox.Show("Por favor seleccione un campo a filtrar.");
                return true;
            }
            if(cboCriterio.SelectedIndex < 0)
            {
                MessageBox.Show("Por favor seleccione un criterio a filtrar.");
                return true;
            }if (cboCampo.SelectedItem.ToString() == "Numero")
            {
                if (string.IsNullOrEmpty(txtFiltroAvanzado.Text))
                {
                    MessageBox.Show("Debe escribir en el filtro si es numérico.");
                    return true;
                }
                if (!(soloNumeros(txtFiltroAvanzado.Text)))
                {
                    MessageBox.Show("Solo números para filtro numérico.");
                    return true;
                }
            }
            
            if(cboCriterio2.Visible==true)
            {
                if(cboCampo2.SelectedIndex < 0)
                {
                    MessageBox.Show("Por favor seleccione segundo campo a filtrar.");
                    return true;
                }
                if(cboCriterio2.SelectedIndex <0)
                {
                    MessageBox.Show("Por favor seleccione un segundo criterio a filtrar.");
                    return true;
                }
                if(cboCampo2.SelectedItem.ToString() == "Numero")
                {
                    if (string.IsNullOrEmpty(txtFiltroAvanzado2.Text))
                    {
                        MessageBox.Show("Debe escribir en el filtro si es numérico.");
                        return true;
                    }
                    if (!(soloNumeros(txtFiltroAvanzado2.Text)))
                    {
                        MessageBox.Show("Solo números para filtro numérico.");
                        return true;
                    }
                }
                

            }
            return false;
        }
        private bool soloNumeros(string cadena)
        {
            foreach (char caracter in cadena)
            {
                if (!(char.IsNumber(caracter)))
                    return false;
            }
            return true;
        }
        private void btnFiltro_Click(object sender, EventArgs e)
        {
            PokemonDatos datos = new PokemonDatos();
            try
            {
                if (validarFiltro())
                    return;
                string campo = cboCampo.SelectedItem.ToString();
                string criterio = cboCriterio.SelectedItem.ToString();
                string filtro = txtFiltroAvanzado.Text;
                if (cboCriterio2.SelectedItem == null)
                {
                    dgvPokemons.DataSource = datos.filtrar(campo, criterio, filtro);
                }
                else
                {
                    string campo2 = cboCampo2.SelectedItem.ToString();
                    string criterio2 = cboCriterio2.SelectedItem.ToString();
                    string filtro2 = txtFiltroAvanzado2.Text;//para hacer esto mejor podria hacer un 
//método agregarFiltro que me ponga la lógica de la adicion del filtro en filtrar(), pasando la consulta
//por referencia, agregandole el and y todo lo demás. asi podiendo agregar cuantos filtros
//como quiera, y no tener que estar creando una sobrecarga de filtrar si quiero agregar filtros.
                    dgvPokemons.DataSource = datos.filtrar(campo, criterio, filtro, campo2, criterio2, filtro2);
                }
                    
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }

        private void cboCampo2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cboCampo2.SelectedItem != null)
            {
                string opcion = cboCampo2.SelectedItem.ToString();
                if (opcion == "Numero")
                {
                    cboCriterio2.Items.Clear();
                    cboCriterio2.Items.Add("Mayor a");
                    cboCriterio2.Items.Add("Menor a");
                    cboCriterio2.Items.Add("Igual a");
                }
                else
                {
                    cboCriterio2.Items.Clear();
                    cboCriterio2.Items.Add("Contiene");
                    cboCriterio2.Items.Add("Comienza con");
                    cboCriterio2.Items.Add("Termina con");
                }
            }
        }
        private void btnAgregarFiltro_Click(object sender, EventArgs e)
        {
            if(lblFiltroAvanzado2.Visible == false)
            {
                lblCampo2.Visible = true;
                cboCampo2.Visible = true;
                lblCriterio2.Visible = true;
                cboCriterio2.Visible = true;
                lblFiltroAvanzado2.Visible = true;
                txtFiltroAvanzado2.Visible = true;
                btnAgregarFiltro.Text = "Quitar Filtro";
            }
            else
            {
                lblCampo2.Visible = false;
                cboCampo2.Visible = false;
                cboCampo2.SelectedIndex = -1;
                lblCriterio2.Visible = false;
                cboCriterio2.Visible = false;
                cboCriterio2.SelectedIndex = -1;
                lblFiltroAvanzado2.Visible = false;
                txtFiltroAvanzado2.Visible = false;
                txtFiltroAvanzado2.Text = "";
                btnAgregarFiltro.Text = "Agregar Filtro";
            }
            
        }

        private void dgvPokemons_DataSourceChanged(object sender, EventArgs e)
        {
            if(dgvPokemons.CurrentRow == null)
            {
                btnAgregar.Enabled = false;
                btnModificar.Enabled = false;
                btnEliminarFisico.Enabled = false;
                btnEliminarLogico.Enabled = false;
                return;
            }
            btnAgregar.Enabled = true;
            btnModificar.Enabled = true;
            btnEliminarFisico.Enabled = true;
            btnEliminarLogico.Enabled = true;
        }
    }
}
