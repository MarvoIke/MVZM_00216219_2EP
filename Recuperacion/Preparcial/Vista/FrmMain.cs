using Preparcial.Modelo;
using Preparcial.Controlador;
using System.Windows.Forms;
using System.Linq;
using System;

namespace Preparcial.Vista
{
    public partial class FrmMain : Form
    {
        private Usuario u;

        public FrmMain(Usuario u)
        {
            InitializeComponent();
            this.u = u;
        }

        private void bttnCreateUser_Click(object sender, EventArgs e)
        {
            if (!txtNewUser.Text.Equals(""))
            {
                ControladorUsuario.CrearUsuario(txtNewUser.Text);
                txtNewUser.Clear();
                ActualizarCrearUsuario();
            }
            else
                MessageBox.Show("Escriba el nombre de usuario.");
        }

        private void ActualizarCrearUsuario()
        {
            dgvCreateUser.DataSource = ControladorUsuario.GetUsuariosTable();
        }

        private void ActualizarInventario()
        {
            dgvInventary.DataSource = ControladorInventario.GetProductosTable();
        }

        private void ActualizarOrdenes()
        {
            dgvAllOrders.DataSource = ControladorPedido.GetPedidosTable();
        }

        private void ActualizarOrdenesUsuario()
        {
            cmbProductMakeOrder.DataSource = null;
            cmbProductMakeOrder.ValueMember = "idArticulo";
            cmbProductMakeOrder.DisplayMember = "producto";
            cmbProductMakeOrder.DataSource = ControladorInventario.GetProductos();
            dgvMyOrders.DataSource = ControladorPedido.GetPedidosUsuarioTable(u.IdUsuario);
        }

        private void bttnAddInventary_Click(object sender, EventArgs e) 
        {
            if (txtProductNameInventary.Text.Equals("") ||
                txtDescriptionInventary.Text.Equals("") ||
                txtPriceInventary.Text.Equals("") ||
                txtStockInventary.Text.Equals(""))
                MessageBox.Show("No puede dejar campos vacios");
            else
            {
                ControladorInventario.AnadirProducto(txtProductNameInventary.Text, txtDescriptionInventary.Text,
                    txtPriceInventary.Text, txtStockInventary.Text);
                txtProductNameInventary.Clear();
                txtDescriptionInventary.Clear();
                txtPriceInventary.Clear();
                txtStockInventary.Clear();

                ActualizarInventario();
            }
        }

        private void bttnDeleteInventary_Click(object sender, EventArgs e)
        {
            if(txtDeleteInventary.Text.Equals(""))
                MessageBox.Show("No puede dejar campos vacios");
            else
            {
                ControladorInventario.EliminarProducto(txtDeleteInventary.Text);
                txtDeleteInventary.Clear();
                ActualizarInventario();
            }
        }

        private void bttnUpdateStockInventary_Click(object sender, EventArgs e)
        {
            if (txtUpdateStockIdInventary.Text.Equals("") || txtUpdateStockInventary.Text.Equals(""))
                MessageBox.Show("No puede dejar campos vacios");
            else
            {
                ControladorInventario.ActualizarProducto(txtUpdateStockIdInventary.Text, txtUpdateStockInventary.Text);
                MessageBox.Show("Se ha actualizado el producto");
                txtUpdateStockIdInventary.Clear();
                txtUpdateStockInventary.Clear();
                ActualizarInventario();
            }
        }

        private void bttnMakeOrder_Click(object sender, EventArgs e)
        {
            if (txtMakeOrderQuantity.Text.Equals(""))
                MessageBox.Show("No puede dejar campos vacios");
            else
            {
                int modStock = 0;
                int usrid = Convert.ToInt32(u.IdUsuario);
                int prdct = Convert.ToInt32(cmbProductMakeOrder.SelectedValue.ToString());
                int cant = Convert.ToInt32(txtMakeOrderQuantity.Text);
                foreach (var product in ControladorInventario.GetProductos())
                {
                    if (product.idArticulo.Equals(cmbProductMakeOrder.SelectedValue.ToString()))
                    {
                        modStock = Convert.ToInt32(product.stock);
                        break;
                    }
                }
                modStock -= cant;
                if (modStock < 0)
                {
                    MessageBox.Show("Error: El stok es insuficiente.");
                }
                else
                {
                    ControladorPedido.HacerPedido(usrid, prdct, cant);
                    ControladorInventario.ActualizarProducto(cmbProductMakeOrder.SelectedValue.ToString()
                        , modStock.ToString());
                    MessageBox.Show("Pedido realizado.");
                    txtMakeOrderQuantity.Clear();
                    ActualizarOrdenesUsuario();
                }
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab.Name.Equals("createNewUserTab") && u.Admin)
                ActualizarCrearUsuario();

            else if (tabControl1.SelectedTab.Name.Equals("inventaryTab") && u.Admin)
                ActualizarInventario();

            else if (tabControl1.SelectedTab.Name.Equals("createOrderTab") && !u.Admin)
                ActualizarOrdenesUsuario();

            else if (tabControl1.SelectedTab.Name.Equals("viewOrdersTab") && u.Admin)
                ActualizarOrdenes();

            else if (tabControl1.SelectedTab.Name.Equals("generalTab"))
            {}

            else

            {
                    MessageBox.Show("No tiene permisos para ver esta pestana");
                    tabControl1.SelectedTab = tabControl1.TabPages[0];
            }

        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
