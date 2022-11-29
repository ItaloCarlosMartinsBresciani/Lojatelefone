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
    public partial class frmPesquisaCliente : Form
    {
        private Int64 id_cliente;
        private string nome;
        private string telefone;
        private string email;
        public frmPesquisaCliente()
        {
            InitializeComponent();
        }

        private void frmPesquisaCliente_Load(object sender, EventArgs e)
        {
            CarregaGridCliente();
            InibicaoCampos();
        }

        public void InibicaoCampos()
        {
            txtId_cliente.Enabled = false;
            txtNome_cliente.Enabled = false;
            txtTelefone.Enabled = false;
            txtEmail.Enabled = false;
        }

        private void CarregaGridCliente()
        {
            try
            {
                string sql;
                sql = "select * from cliente";
                sql += " order by nome";
                dgvClientes.DataSource = Conexao.selecionarDataTable(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao realizar a pesquisa de clientes." +
                               "\n\nMais detalhes: " + ex.Message,
                               "Pesquisa de Clientes", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            frmCadastroClientes cadastro_cliente = new frmCadastroClientes();
            cadastro_cliente.ShowDialog();
            CarregaGridCliente();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult resp;
            string sql;
            try
            {
                if (id_cliente != 0)
                {
                    resp = MessageBox.Show("Deseja realmente excluir o cliente " + nome + "?",
                                            "Cadastro de Clientes",
                                            MessageBoxButtons.YesNo,
                                            MessageBoxIcon.Question);
                    if (resp == DialogResult.Yes)
                    {
                        List<object> parametro = new List<object>();
                        parametro.Add(id_cliente);
                        
                        sql = "delete from cliente";
                        sql+= " where id_cliente = @1";
                        Conexao.executar(sql, parametro);

                        MessageBox.Show("Cliente excluído com sucesso!!!", "Pesquisa de Clientes",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                        CarregaGridCliente();
                        InibicaoCampos();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao realizar a exclusão do cliente." +
                                "\n\nMais detalhes: " + ex.Message,
                                "Pesquisa de Clientes", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void LimpaForm()
        {
            txtId_cliente.Text = "";
            txtTelefone.Text = "";
            txtNome_cliente.Text = "";
            txtEmail.Text = "";
        }

        public void PesquisarCliente(Int64 id_cliente)
        {
            string sql;
            try
            {
                sql = "select * from cliente";
                sql += " where id_cliente = @1";
                List<object> parametro = new List<object>();
                parametro.Add(id_cliente);
                NpgsqlDataReader dr = Conexao.selecionar(sql, parametro);
                if (dr.Read())
                {
                    txtId_cliente.Text = dr["id_cliente"].ToString();
                    txtNome_cliente.Text = dr["nome"].ToString();
                    txtTelefone.Text = dr["telefone"].ToString();
                    txtEmail.Text = dr["email"].ToString();
                }
                else
                {
                    MessageBox.Show("ID do cliente não encontrado !!!",
                                    "Pesquisa de Clientes", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    LimpaForm();
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao acessar os dados do cliente." +
                                "\n\nMais detalhes:" + ex.Message,
                                "Pesquisa de Clientes", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LimpaForm();
            }
        }
        private void dgvClientes_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            id_cliente = Convert.ToInt64(dgvClientes.Rows[e.RowIndex].Cells[0].Value);
            nome = dgvClientes.Rows[e.RowIndex].Cells[1].Value.ToString();
            telefone = dgvClientes.Rows[e.RowIndex].Cells[2].Value.ToString();
            email = dgvClientes.Rows[e.RowIndex].Cells[3].Value.ToString();
            PesquisarCliente(id_cliente);

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

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            txtNome_cliente.Enabled = true;
            txtTelefone.Enabled = true;
            txtEmail.Enabled = true;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtNome_cliente.Text) && !String.IsNullOrEmpty(txtTelefone.Text) && !String.IsNullOrEmpty(txtEmail.Text))
            {
                if (!String.IsNullOrEmpty(txtId_cliente.Text))
                {
                    string sql;
                    try
                    {
                        List<object> parametros = new List<object>();
                        parametros.Add(txtNome_cliente.Text);//@1
                        parametros.Add(txtTelefone.Text);//@2
                        parametros.Add(txtEmail.Text);//@3
                        parametros.Add(Convert.ToInt64(txtId_cliente.Text));//@4

                        sql = "update cliente set";
                        sql += " nome = @1,";
                        sql += " telefone = @2,";
                        sql += " email = @3";
                        sql += " where id_cliente = @4";

                        Conexao.executar(sql, parametros);

                        MessageBox.Show("Cliente atualizado com sucesso!!!", "Pesquisa de Clientes",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                        CarregaGridCliente();
                        InibicaoCampos();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ocorreu um erro ao salvar os dados do cliente !!!" +
                                    "\n\nMais detalhes:" + ex.Message, "Pesquisa de Clientes",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
            else
            {
                MessageBox.Show("Não foi possível salvar. Todos os campos devem ser preenchidos!",
                                "Pesquisa de Clientes", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
    
}
