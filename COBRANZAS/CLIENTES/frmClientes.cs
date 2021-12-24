using MaterialSkin.Controls;
using System;
using COBRANZAS.CLIENTES;
using COBRANZAS.Model;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COBRANZAS.CLIENTES
{
    public partial class frmClientes : MaterialForm
    {

        TCN_Clientes objCNClientes = new TCN_Clientes();        //Objeto de la capa de negocio
        readonly string Usuario = "AlxCast";                    

        private int Accion;                                     // 1=Nuevo, 2=Modificar, 3=Anular



        public frmClientes()
        {
            InitializeComponent();
            this.Accion = 1;
        }

        
    //Limpia los controles del formulario
        private void Limpiar() 
        {           
            tbxid.Text = "";
            tbxidentidad.Text = ""; 
            tbxnombre.Text = "";
            tbxdireccion.Text = "";
            tbxtelefono.Text = "";
            tbxcorreo.Text = "";
            tbxmunicipio.Text = "";
            dtpFechaNac.Value = DateTime.Now;
            lblCreadopor.Text = "";
            lblFechaCreacion.Text = "";
            lblFechaMod.Text = "";
            lblUsuarioMod.Text = "";
            this.Accion = 1;
        }

    // Carga Datos en el datagridview
        private void CargarGrid()
        {
            dgvClientes.Rows.Clear();
            List<TModelsClientes> clientes = this.objCNClientes.GetClientes();
            foreach (var col in clientes)
            {
                dgvClientes.Rows.Add(col.Id, col.Identidad, col.Nombre, col.Direccion, col.Telefono, col.Correo, col.Municipio, col.FechaNacimiento, col.UsuarioCreacion, col.Activo);
            }

        }
        private void frmClientes_Load(object sender, EventArgs e)
        {
            this.CargarGrid();
        }
        
    //Boton Buscar Clientes
        private void materialButton1_Click(object sender, EventArgs e)
        {
            var Cliente = objCNClientes.Consultar(tbxid.Text);
            if (Cliente != null)
            {
                tbxidentidad.Text = Cliente.Identidad;
                tbxnombre.Text = Cliente.Nombre;
                tbxdireccion.Text = Cliente.Direccion;
                tbxtelefono.Text = Cliente.Telefono;
                tbxcorreo.Text = Cliente.Correo;
                tbxmunicipio.Text = Cliente.Municipio;
                dtpFechaNac.Value = Cliente.FechaNacimiento;
                lblCreadopor.Text = $"Creado por: {Cliente.UsuarioCreacion} ";
                lblFechaCreacion.Text = $"Creado el: {Cliente.FechaCreacion} ";
                lblUsuarioMod.Text = $"Modificado por: {Cliente.UsuarioModificacion} ";
                lblFechaMod.Text = $"Modificado el: {Cliente.FechaModificacion} ";

                this.Accion = 2;
                tbxid.Enabled = false;
            }
            
            this.CargarGrid();
        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }


    //Boton Guardar Clientes
        private void materialButton1_Click_1(object sender, EventArgs e)
        {
            TModelsClientes cliente = new TModelsClientes();

            
            cliente.Identidad = tbxidentidad.Text;
            cliente.Nombre = tbxnombre.Text;            
            cliente.Direccion = tbxdireccion.Text;
            cliente.Telefono = tbxtelefono.Text;
            cliente.Correo = tbxcorreo.Text;
            cliente.Municipio = tbxmunicipio.Text;
            cliente.FechaNacimiento = dtpFechaNac.Value;

            bool respuesta = false;

            if (this.Accion == 1)
                respuesta = this.objCNClientes.Guardar(cliente, this.Usuario);

            if (this.Accion == 2)
            {
                cliente.Id = Convert.ToInt32(tbxid.Text);
                respuesta = this.objCNClientes.Modificar(cliente, this.Usuario);                
            }
            if (respuesta)
            {
                MessageBox.Show("El Cliente se ha guardado exitosamente", "ACEPTAR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Limpiar();
                tbxid.Enabled = true;
            }
            else
                MessageBox.Show("El cliente no se ha podido Guardar", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            this.CargarGrid();
        }

        private void tbxFechaNac_TextChanged(object sender, EventArgs e)
        {

        }

        private void materialCard1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void materialLabel9_Click(object sender, EventArgs e)
        {

        }


    //Boton Limpiar Datos en texbox
        private void materialButton1_Click_2(object sender, EventArgs e)
        {
            this.Limpiar();
            tbxid.Enabled = true;
            this.CargarGrid();
        }

    //Metodo para cargar datos de datagridview en los texbox para Modificacion
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)       
        {
            int numFila = e.RowIndex;

            tbxid.Text = dgvClientes.Rows[numFila].Cells["col_id"].Value.ToString();
            tbxidentidad.Text = dgvClientes.Rows[numFila].Cells["col_identidad"].Value.ToString();
            tbxnombre.Text = dgvClientes.Rows[numFila].Cells["col_nombre"].Value.ToString();
            tbxdireccion.Text = dgvClientes.Rows[numFila].Cells["col_direccion"].Value.ToString();
            tbxtelefono.Text = dgvClientes.Rows[numFila].Cells["col_telefono"].Value.ToString();
            tbxcorreo.Text = dgvClientes.Rows[numFila].Cells["col_correo"].Value.ToString();
            tbxmunicipio.Text = dgvClientes.Rows[numFila].Cells["col_municipio"].Value.ToString();
            tbxcorreo.Text = dgvClientes.Rows[numFila].Cells["col_correo"].Value.ToString();
            dtpFechaNac.Text = dgvClientes.Rows[numFila].Cells["col_fecha_nac"].Value.ToString();

            this.Accion = 2;
            tbxid.Enabled = false;
        }

        private void False(object sender, EventArgs e)
        {

        }

        private void True(object sender, EventArgs e)
        {

        }

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
