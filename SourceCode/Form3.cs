using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace parcialDos
{
    public partial class Form3 : Form
    {
        private string currentUser = "";

        public Form3(string pCurrentUser)
        {
            InitializeComponent();
            currentUser = pCurrentUser;
            LlenarCosas();
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            LlenarCosas();
        }

        private void LlenarCosas()
        {
            cmbAddProBusi.DataSource = null;
            cmbAddProBusi.ValueMember = "idbusiness";
            cmbAddProBusi.DisplayMember = "name";
            cmbAddProBusi.DataSource = BusinessDao.GetLista();
            cmbDelProd.DataSource = null;
            cmbDelProd.ValueMember = "idproduct";
            cmbDelProd.DisplayMember = "name";
            cmbDelProd.DataSource = ProductDao.GetLista((Business) cmbAddProBusi.SelectedItem);
            dgvOrdenes.DataSource = null;
            dgvOrdenes.DataSource = OrderDao.GetLista();
            dgvUser.DataSource = null;
            dgvUser.DataSource = UserDao.GetLista();
        }

        private void txtUsrnm_TextChanged(object sender, EventArgs e)
        {
            txtPass.Text = txtUsrnm.Text;
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            string usrnm = txtUsrnm.Text;
            string name = txtFullName.Text;
            txtPass.Text = usrnm;
            if (usrnm.Equals("") || name.Equals(""))
            {
                MessageBox.Show("Escriba un nombre de usuario y el nombre\ndel propietario de la cuenta.");
            }
            else
            {
                User nUser = new User(name, usrnm, usrnm, chbAdmin.Checked);
                UserDao.AddUser(nUser);
                MessageBox.Show("Usuario creado correctamente.");
            }
        }

        private void btnChangePass_Click(object sender, EventArgs e)
        {
            string cambio = txtChangePass.Text;
            if (cambio.Equals("") || cambio.Equals(UserDao.getCredential(currentUser)))
                MessageBox.Show("Modifique su contraseña.");
            else
            {
                UserDao.UpdatePass(cambio, currentUser);
                MessageBox.Show("Su contraseña ha sido modificada");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtDelUser.Text.Equals(""))
            {
                MessageBox.Show("Escriba un nombre de usuario.");
            }
            else
            {
                UserDao.DeleteUser(txtDelUser.Text);
                MessageBox.Show("Usuario eliminado.");
                LlenarCosas();
            }
        }

        private void btnAddBusi_Click(object sender, EventArgs e)
        {
            string businessName = txtAddBusi.Text;
            string businessDesc = txtDescBusi.Text;
            ;
            if (businessName.Equals(""))
            {
                MessageBox.Show("Escriba la informacion del negocio.");
            }
            else
            {
                Business nBusi = new Business(businessName, businessDesc);
                BusinessDao.AddBusi(nBusi);
                MessageBox.Show("Negocio agregado correctamente.");
                LlenarCosas();
            }
        }

        private void btnDelBusi_Click(object sender, EventArgs e)
        {
            if (txtDelBusi.Text.Equals(""))
            {
                MessageBox.Show("Escriba el nombre del negocio.");
            }
            else
            {
                BusinessDao.DelBusi(txtDelBusi.Text);
                MessageBox.Show("Negocio eliminado.");
                LlenarCosas();
            }
        }

        private void btnAddPro_Click(object sender, EventArgs e)
        {
            Business negocio = (Business) cmbAddProBusi.SelectedItem;
            int nombreNego = negocio.idBusiness;
            string nombrePro = txtAddProName.Text;
            Product unProduct = new Product(nombreNego , nombrePro);
            ProductDao.AddProd(unProduct);
            MessageBox.Show("Producto agregado.");
            LlenarCosas();
        }
        
        private void cmbAddProBusi_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Product> productos = new List<Product>();
            foreach (var prod in ProductDao.GetLista())
            {
                if (prod.idBusiness == cmbAddProBusi.SelectedIndex)
                {
                    productos.Add(prod);
                }
            }
            cmbDelProd.DataSource = null;
            cmbDelProd.ValueMember = "idproduct";
            cmbDelProd.DisplayMember = "name";
            cmbDelProd.DataSource = productos;
        }

        private void btnDelPro_Click(object sender, EventArgs e)
        {
            ProductDao.DelProd(cmbDelProd.Text);
            MessageBox.Show("Producto eliminado.");
            LlenarCosas();
        }
    }
}