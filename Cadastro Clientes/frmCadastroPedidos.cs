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
    public partial class frmCadastroPedidos : Form
    {
        Int64 id_pedido;
        public frmCadastroPedidos()
        {
            InitializeComponent();
        }

        private void frmCadastroPedidos_Load(object sender, EventArgs e)
        {
            CarregaPedidos();
            CarregaProdutos();
        }

        public void CarregaPedidos()
        {
            string sql;
            try
            {
                sql = "select pedido.id_pedido, aparelho.modelo, aparelho.preco, aparelho.quantidade, pedido.datahorapedido, pedido.observacao";
                sql += " from pedido inner join aparelho";
                sql += " on pedido.id_aparelho = aparelho.id_aparelho";
                sql += " order by aparelho.modelo";
                dgPedidos.DataSource = Conexao.selecionarDataTable(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao carregar os dados dos pedidos." +
                                "\n\nMais detalhes: " + ex.Message,
                                "Cadastro de Aparelhos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void CarregaProdutos()
        {
            string sql;
            try
            {
                sql = "select id_aparelho, modelo from aparelho order by modelo";
                cmbProduto.DisplayMember = "modelo";
                cmbProduto.ValueMember = "id_aparelho";
                cmbProduto.DataSource = Conexao.selecionarDataTable(sql);
                cmbProduto.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao acessar os aparelhos do pedido." +
                                "\n\nMais detalhes: " + ex.Message,
                                "Cadastro de Pedidos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void LimpaForm()
        {
            txtID_Pedido.Clear();
            cmbProduto.SelectedIndex = -1;
            dtPedido.Value = DateTime.Now;
            txtObservações.Clear();
            
        }

        private void HabilitaBotoes(bool estadoNovo = true)
        {
            if (estadoNovo) //se o botão Novo tiver sido clicado (estado=true)
            {
                btnNovo.Enabled = false; //não poderemos clicar para adicionar novo cadastro (pois já está cadastrando)
                btnSalvar.Enabled = true; //poderemos salvar cadastro
                btnCancelar.Enabled = true;//poderemos cancelar a adição do novo cadastro
                btnExcluir.Enabled = false;// não poderemos excluir cadastro
                btnSair.Enabled = false;//não poderemos sair do form
            }
            else //se o botão Novo não estiver habilitado
            {
                btnNovo.Enabled = true; //poderemos add novo cadastro
                btnSalvar.Enabled = true; //poderemos salvar cadastro
                btnCancelar.Enabled = true;//poderemos cancelar a adição do novo cadastro
                btnExcluir.Enabled = true;//poderemos excluir cadastro
                btnSair.Enabled = true;//poderemos sair do form
                txtID_Pedido.Enabled = true;
            }
        }

        public void PesquisarPedido(Int64 id_pedido)
        {
            string sql;
            try
            {
                List<object> parametro = new List<object>();
                parametro.Add(Convert.ToInt64(txtID_Pedido.Text));

                sql = "select * from pedido";
                sql += " where id_pedido = @1";
                
                NpgsqlDataReader dr = Conexao.selecionar(sql, parametro);
                if (dr.Read())
                {
                    txtID_Pedido.Text = dr["id_pedido"].ToString();
                    dtPedido.Value = Convert.ToDateTime(dr["datahorapedido"]);
                    txtObservações.Text = dr["observacao"].ToString();
                    cmbProduto.SelectedValue = Convert.ToInt64(dr["id_aparelho"]);
                }
                else
                {
                    MessageBox.Show("ID do pedido não encontrado !!!",
                                    "Cadastro de Pedidos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    LimpaForm();
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao acessar os dados do Pedido." +
                                "\n\nMais detalhes:" + ex.Message,
                                "Cadastro de Pedidos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LimpaForm();
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            LimpaForm();
            txtID_Pedido.Enabled = false; //ativado=falso (desativa o campo de ID)
            dtPedido.Focus();
            HabilitaBotoes();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(Convert.ToString(dtPedido.Value)) && !String.IsNullOrEmpty(txtObservações.Text) && !String.IsNullOrEmpty(Convert.ToString(cmbProduto.SelectedValue)))
            {
                string sql;
                try
                {
                    List<object> param = new List<object>();
                    param.Add(Convert.ToInt64(cmbProduto.SelectedValue));
                    param.Add(Convert.ToDateTime(dtPedido.Value));
                    param.Add(txtObservações.Text);

                    if (!String.IsNullOrEmpty(txtID_Pedido.Text))
                    {
                        param.Add(Convert.ToInt64(txtID_Pedido.Text));
                        sql = "update pedido set";
                        sql += " id_aparelho = @1,";
                        sql += " datahorapedido = @2,";
                        sql += " observacao = @3";
                        sql += " where id_pedido = @4";
                    }
                    else
                    {
                        sql = "insert into pedido(id_aparelho, datahorapedido, observacao)";
                        sql += " VALUES(@1, @2, @3)";
                    }

                    Conexao.executar(sql, param);

                    MessageBox.Show("Pedido cadastrado com sucesso !!!",
                                            "Cadastro de Pedidos",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Information);
                    HabilitaBotoes(false);
                    CarregaPedidos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro ao realizar a ação no banco de dados." +
                                    "\n\nMais detalhes:" + ex.Message,
                                    "Cadastro de Pedidos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    LimpaForm();
                }
            }
            else
            {
                MessageBox.Show("Não foi possível salvar. Todos os campos devem ser preenchidos!",
                                "Cadastro de Pedidos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult resp;
            resp = MessageBox.Show("Deseja realmente cancelar este cadastro?",
                                    "Cadastro de Pedidos",
                                    MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Question);
            if (resp == DialogResult.Yes)
            {
                LimpaForm();
                HabilitaBotoes(false);
                txtID_Pedido.Focus();
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult resp;
            string sql;
            try
            {
                if (!String.IsNullOrEmpty(txtID_Pedido.Text))//se ID estiver preenchido
                {
                    resp = MessageBox.Show("Deseja realmente excluir este pedido?",
                                           "Cadastro de Pedidos",
                                           MessageBoxButtons.YesNo,
                                           MessageBoxIcon.Question);
                    if (resp == DialogResult.Yes)
                    {
                        List<object> parametro = new List<object>();
                        parametro.Add(Convert.ToInt64(txtID_Pedido.Text)); 

                        sql = "delete from pedido"; //exclusão física
                        sql += "     where id_pedido = @1";

                        Conexao.executar(sql, parametro);

                        MessageBox.Show("Pedido removido com sucesso !!!",
                                        "Cadastro de Pedidos",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                        LimpaForm();
                        HabilitaBotoes(false);
                        CarregaPedidos();
                        txtID_Pedido.Focus();

                    }
                }
                else
                {
                    MessageBox.Show("Não foi selecionado nenhum ID para ser excluído. \nCaso desejo excluir um pedido indique seu ID",
                                           "Cadastro de Pedidos",
                                           MessageBoxButtons.OK,
                                           MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao excluir o Pedido !!!" +
                                "\n\nMais detalhes: " + ex.Message,
                                "Cadastro de Pedidos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            DialogResult resp;
            resp = MessageBox.Show("Deseja realmente sair do cadastro de Pedidos?",
                                    "Cadastro de Pedidos",
                                    MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Question);
            if (resp == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void txtID_Pedido_Validated(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtID_Pedido.Text))
            {
                PesquisarPedido(Convert.ToInt64(txtID_Pedido.Text));
            }
        }

        private void dgPedidos_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            id_pedido = Convert.ToInt64(dgPedidos.Rows[e.RowIndex].Cells[0].Value);
            txtID_Pedido.Text = id_pedido.ToString();
            PesquisarPedido(id_pedido);
        }
    }
}
