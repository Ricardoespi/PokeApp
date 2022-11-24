using dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using negocio;

namespace winformapp_1_
{
    public partial class frmElementos : Form
    {
        public frmElementos()
        {
            InitializeComponent();
        }

        private void FormpruebaElementos_Load(object sender, EventArgs e)
        {
            cargar();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            ElementoNegocio datos = new ElementoNegocio();
            Elemento nuevo = new Elemento();
            nuevo.Descripcion = txtbxElemento.Text;
            datos.agregar(nuevo);
            cargar();
        }
        private void cargar()
        {
            try
            {
                ElementoNegocio datos = new ElementoNegocio();
                dgvElementos.DataSource = datos.listar();
            }
            catch (Exception ex)
            { throw ex; }
        }
    }
}
