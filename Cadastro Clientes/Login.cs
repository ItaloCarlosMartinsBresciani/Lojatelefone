using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cadastro_Clientes
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtUser.Text))
            {
                MessageBox.Show("Informe seu nome de usuário !!!",
                                        "Login",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                txtUser.Focus();
                return;
            }
            if (String.IsNullOrWhiteSpace(txtSenha.Text))
            {
                MessageBox.Show("Informe sua senha !!!",
                                        "Login",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                txtSenha.Focus();
                return;
            }

            string usuario = txtUser.Text;
            string senha = txtSenha.Text;
            sql = "SELECT * FROM clientes WHERE usuario == usuario AND senha == senha";
        }
    }
}
