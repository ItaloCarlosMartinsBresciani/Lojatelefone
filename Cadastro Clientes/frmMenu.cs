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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            this.Visible = false;
            frmSplash splash = new frmSplash();
            splash.ShowDialog();
            frmLogin frmLogin = new frmLogin();
            frmLogin.ShowDialog();
            this.Visible = true;
        }

        private void btnCadastroClientes_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmCadastroClientes cliente = new frmCadastroClientes();
            cliente.ShowDialog();
            this.Visible = true;
        }

        private void btnCadastroFabricantes_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmCadastroFabricante fabricante = new frmCadastroFabricante();
            fabricante.ShowDialog();
            this.Visible = true;
        }

        private void btnCadastroProdutos_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmCadastroAparelhos aparelho = new frmCadastroAparelhos();
            aparelho.ShowDialog();
            this.Visible = true;
        }

        private void btnPesquisaFabricante_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmPesquisaFabricante pesq_fab = new frmPesquisaFabricante();
            pesq_fab.ShowDialog();
            this.Visible = true;
        }

        private void btnPesquisaCliente_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmPesquisaCliente pesq_cliente = new frmPesquisaCliente();
            pesq_cliente.ShowDialog();
            this.Visible = true;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            DialogResult resposta;
            resposta = MessageBox.Show("Deseja realmente sair desta aplicação?",
                                            "Menu",
                                            MessageBoxButtons.YesNo,
                                            MessageBoxIcon.Question);
            if (resposta == DialogResult.Yes)
                this.Close();
            else
                btnCadastroClientes.Focus();
        }

        private void btnCadastrar_pedidos_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmCadastroPedidos pedido = new frmCadastroPedidos();
            pedido.ShowDialog();
            this.Visible = true;
        
        }

        private void btnPesquisaPedidos_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmPesquisaPedido pedido2 = new frmPesquisaPedido();
            pedido2.ShowDialog();
            this.Visible = true;
        }
    }
}
