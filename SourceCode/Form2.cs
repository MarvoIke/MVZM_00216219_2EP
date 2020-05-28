using System;
using System.Windows.Forms;

namespace parcialDos
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        
        public void Form2_Load(object sender, EventArgs e)
        {
            
        }
        
        private void btnPreoceder_Click(object sender, EventArgs e)
        {
            string user = txtUsrnm.Text , contra = txtPass.Text;
            if (user.Equals("") || contra.Equals(""))
            { 
                MessageBox.Show("Escriba sus credenciales.");
            }
            
            else if (!contra.Equals(UserDao.getCredential(user)))
            {
                MessageBox.Show("Contraseña o usuario incorrecto.");
            }

            else
            {
                if (UserDao.isAdmin(user))
                {
                    Hide();
                    Form3 admin = new Form3(txtUsrnm.Text);
                    admin.ShowDialog();
                    Close();
                }
                else
                {
                    User aux = new User();
                    foreach (var unMen in UserDao.GetLista())
                    {
                        if (unMen.userName.Equals(user))
                        {
                            aux = unMen;
                            break;
                        }
                    }
                    Hide();
                    Form4 normal = new Form4(aux);
                    normal.ShowDialog();
                    Close();
                }
            }
        }
    }
}
