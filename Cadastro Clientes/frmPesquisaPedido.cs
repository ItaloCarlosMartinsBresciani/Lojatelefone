using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace Cadastro_Clientes
{
    public partial class frmPesquisaPedido : Form
    {
        private Int64 id_pedido;
        /*private string nome;
        private string telefone;
        private string email;*/
        public frmPesquisaPedido()
        {
            InitializeComponent();
        }

        private void frmPesquisaPedido_Load(object sender, EventArgs e)
        {
            CarregaGridPedido();
            CarregaProdutos();
            CarregaGridFabricante();
            InibicaoCampos();
        }
        public void InibicaoCampos()
        {
            cmbAparelho.Enabled = false;
            dateDataPedido1.Enabled = false;
            dateDataPedido2.Enabled = false;
            cmbFabricante.Enabled = false;
            numValorPedido1.Enabled = false;
            numValorPedido2.Enabled = false;
            

        }

        public void CarregaGridFabricante()
        {
            string sql;
            try
            {
                sql = "select nome, id_fabricante from fabricante order by id_fabricante";
                cmbFabricante.DisplayMember = "nome";
                cmbFabricante.ValueMember = "id_fabricante";
                cmbFabricante.DataSource = Conexao.selecionarDataTable(sql);
                cmbFabricante.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao acessar os fabricantes do pedido." +
                                "\n\nMais detalhes: " + ex.Message,
                                "Cadastro de Pedidos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public void CarregaProdutos()
        {
            string sql;
            try
            {
                sql = "select id_aparelho, modelo from aparelho order by modelo";
                cmbAparelho.DisplayMember = "modelo";
                cmbAparelho.ValueMember = "id_aparelho";
                cmbAparelho.DataSource = Conexao.selecionarDataTable(sql);
                cmbAparelho.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao acessar os aparelhos do pedido." +
                                "\n\nMais detalhes: " + ex.Message,
                                "Cadastro de Pedidos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CarregaGridPedido()
        {
            try
            {
                List<object> param = new List<object>();
                
                string sql;
                sql = "select * from pedido";
                sql += " order by id_pedido";
                dgvPedidos.DataSource = Conexao.selecionarDataTable2(sql, param);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao realizar a pesquisa de pedidos." +
                               "\n\nMais detalhes: " + ex.Message,
                               "Pesquisa de Pedidos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        
        public void CarregaPedido()
        {
            string sql;
            try
            {
                

                sql = "select p.id_pedido, a.modelo, f.nome as fabricante, a.preco, p.datahorapedido as data, p.observacao from aparelho a, pedido p, " +
                    "fabricante f where p.id_aparelho = a.id_aparelho AND f.id_fabricante = a.id_fabricante";
                if (chkAparelho.Checked)
                {
                    
                    sql += $" and a.id_aparelho = {Convert.ToInt64(cmbAparelho.SelectedValue)}";
                }

                if (chkDataPedido.Checked)
                {
                    
                    sql += $" and p.datahorapedido >= '{dateDataPedido1.Value.ToString("yyyy-MM-dd hh:mm:ss")}' AND p.datahorapedido <= '{dateDataPedido2.Value.ToString("yyyy-MM-dd hh:mm:ss")}'";
                }

                if (chkValorPedido.Checked)
                {
                    
                    sql += $" and a.preco >= {Convert.ToDecimal(numValorPedido1.Value)} AND a.preco <= {Convert.ToDecimal(numValorPedido2.Value)}";
                }

                if (chkFabricante.Checked)
                {
                    
                    sql += $" and a.id_fabricante = {Convert.ToInt64(cmbFabricante.SelectedValue)}";
                }
                dgvPedidos.DataSource = Conexao.selecionarDataTable(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao carregar os dados dos pedidos" +
                "\n\n, Mais detalhes: " + ex.Message,
                "Pesquisa de pedidos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
        }        

        private void btnSair_Click(object sender, EventArgs e)
        {
            DialogResult resp;
            resp = MessageBox.Show("Deseja realmente sair da pesquisa de clientes?",
                                    "Pesquisa de Clientes",
                                    MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Question);
            if (resp == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnPesquisarPedido_Click(object sender, EventArgs e)
        {
            CarregaPedido();
        }

        private void chkDataPedido_CheckedChanged(object sender, EventArgs e)
        {
            dateDataPedido1.Enabled = chkDataPedido.Checked;
            dateDataPedido2.Enabled = chkDataPedido.Checked;
        }

        private void chkAparelho_CheckedChanged(object sender, EventArgs e)
        {
            cmbAparelho.Enabled = chkAparelho.Checked;
        }

        private void chkValorPedido_CheckedChanged(object sender, EventArgs e)
        {
            numValorPedido1.Enabled = chkValorPedido.Checked;
            numValorPedido2.Enabled = chkValorPedido.Checked;
        }

        private void chkFabricante_CheckedChanged(object sender, EventArgs e)
        {
            cmbFabricante.Enabled = chkFabricante.Checked;
        }
    }
    
}
