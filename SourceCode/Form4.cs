using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace parcialDos
{
    public partial class Form4 : Form
    {
        private User currentUser = new User();
        public Form4(User pCurrentUser)
        {
            InitializeComponent();
            currentUser = pCurrentUser;
            LlenarCmbs();
        }

        private void LlenarCmbs()
        {
            
            List<Address> direcciones = new List<Address>();
            foreach (var unaDire in AddressDao.GetLista())
            {
                if (unaDire.idUser == currentUser.idUser)
                {
                    direcciones.Add(unaDire);
                }
            }
            cmbDelAddress.DataSource = null;
            cmbDelAddress.ValueMember = "idaddress";
            cmbDelAddress.DisplayMember = "address";
            cmbDelAddress.DataSource = direcciones;
            cmbAddressOrder.DataSource = null;
            cmbAddressOrder.ValueMember = "idaddress";
            cmbAddressOrder.DisplayMember = "address";
            cmbAddressOrder.DataSource = direcciones;
            cmbBusiOrder.DataSource = null;
            cmbBusiOrder.ValueMember = "idbusiness";
            cmbBusiOrder.DisplayMember = "name";
            cmbBusiOrder.DataSource = BusinessDao.GetLista();
            cmbAddresses.DataSource = null;
            cmbAddresses.ValueMember = "idaddress";
            cmbAddresses.DisplayMember = "address";
            cmbAddresses.DataSource = direcciones;
            cmbDelAddress.DataSource = null;
            cmbDelAddress.ValueMember = "idaddress";
            cmbDelAddress.DisplayMember = "address";
            cmbDelAddress.DataSource = direcciones;
            dgvMisOrdenes.DataSource = OrderDao.GetLista(currentUser.idUser);
        }
        private void cmbBusiOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Product> productos = new List<Product>();
            var unbi = (Business) cmbBusiOrder.SelectedItem;
            foreach (var prod in ProductDao.GetLista())
            {
                if (prod.idBusiness == unbi.idBusiness)
                {
                    productos.Add(prod);
                }
            }
            cmbProOrder.DataSource = null;
            cmbProOrder.ValueMember = "idProduct";
            cmbProOrder.DisplayMember = "name";
            cmbProOrder.DataSource = productos;
        }

        private void btnChangePass_Click(object sender, EventArgs e)
        {
            string cambio = txtChangePass.Text;
            if (cambio.Equals("") || cambio.Equals(currentUser.password))
                MessageBox.Show("Modifique su contraseña.");
            else
            {
                UserDao.UpdatePass(cambio, currentUser.userName);
                MessageBox.Show("Su contraseña ha sido modificada");
            }
        }

        private void updateAddresses()
        {
            cmbAddresses.DataSource = null;
            cmbAddresses.ValueMember = "idaddress";
            cmbAddresses.DisplayMember = "address";
            cmbAddresses.DataSource = AddressDao.GetLista(currentUser.idUser);
            cmbDelAddress.DataSource = null;
            cmbDelAddress.ValueMember = "idaddress";
            cmbDelAddress.DisplayMember = "address";
            cmbDelAddress.DataSource = AddressDao.GetLista(currentUser.idUser);
            cmbAddressOrder.DataSource = null;
            cmbAddressOrder.ValueMember = "idaddress";
            cmbAddressOrder.DisplayMember = "address";
            cmbAddressOrder.DataSource = AddressDao.GetLista(currentUser.idUser);
        }

        private void btnAddAddress_Click(object sender, EventArgs e)
        {
            string address = txtAddAddress.Text;
            if (address.Equals(""))
                MessageBox.Show("Escriba una direccion.");
            else
            {
                Address aux = new Address();
                aux.idUser = currentUser.idUser;
                aux.address = address;

                AddressDao.AddAddress(aux);
                MessageBox.Show("La direccion fue agregada.");
                updateAddresses();
            }
        }

        private void btnDelAddress_Click(object sender, EventArgs e)
        {
            AddressDao.DelAddress(cmbDelAddress.Text);
            MessageBox.Show("Direccion eliminada.");
            updateAddresses();
        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            Order orden = new Order();

            var pedido = (Product) cmbProOrder.SelectedItem;
            var lugar = (Address) cmbAddressOrder.SelectedItem;
            orden.idProduct = pedido.idProduct;
            orden.idAddress = lugar.idAddress;

            OrderDao.AddOrden(orden);
            MessageBox.Show("La direccion fue agregada.");
            
            cmbAddressOrder.DataSource = null;
            cmbAddressOrder.ValueMember = "idaddress";
            cmbAddressOrder.DisplayMember = "address";
            cmbAddressOrder.DataSource = AddressDao.GetLista(currentUser.idUser);
            
            cmbBusiOrder.DataSource = null;
            cmbBusiOrder.ValueMember = "idbusiness";
            cmbBusiOrder.DisplayMember = "name";
            cmbBusiOrder.DataSource = BusinessDao.GetLista();
            cmbProOrder.DataSource = null;
            cmbProOrder.ValueMember = "idproduct";
            cmbProOrder.DisplayMember = "name";
            cmbProOrder.DataSource = ProductDao.GetLista((Business) cmbBusiOrder.SelectedItem);

            List<int> ids = new List<int>();
            foreach (var place in AddressDao.GetLista())
            {
                if(place.idUser == currentUser.idUser)
                    ids.Add(place.idAddress);
            }

            foreach (var i in ids)
            {
                dgvMisOrdenes.DataSource = OrderDao.GetLista(i);
            }
            
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            txtMyName.Text = currentUser.fullName;
            txtMyUsrnm.Text = currentUser.userName;
            dgvMisOrdenes.DataSource = OrderDao.GetLista(currentUser.idUser);
            LlenarCmbs();
        }
    }
}
