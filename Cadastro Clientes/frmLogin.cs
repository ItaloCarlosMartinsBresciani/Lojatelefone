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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
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



            try
            {

            
                txtUser.Focus();
                string sql ="SELECT * FROM cliente WHERE email = @1 and senha = @2";
                var dados = Conexao.selecionar(sql, new List<object> {txtUser.Text, txtSenha.Text} );
                dados.Read();
                if (dados.HasRows)
                {
                    MessageBox.Show("Olá Bicudo, seja bem vindo!\n\nCorrija com amor nosso trabalho ;)");
                    Conexao.desconectar();
                    this.Close();
                    
                }
                else{
                    MessageBox.Show("O usuário ou a senha estão incorretos, por favor redigite!");

                    txtUser.Clear();
                    txtSenha.Clear();
                }
            }
            catch
            {
                 MessageBox.Show("Registro não encontrado! Confira seus dados, por gentileza!.",
                                    "Login de Usuários", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                        return;
            }

            

            /*string usuario = txtUser.Text;
            string senha = txtSenha.Text;
            sql = "SELECT * FROM clientes WHERE usuario == usuario AND senha == senha";*/
        }
    }
}
