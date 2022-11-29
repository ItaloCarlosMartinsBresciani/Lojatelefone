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
    public partial class frmCadastroAparelhos : Form
    {
        Int64 id_aparelho;
        public frmCadastroAparelhos()
        {
            InitializeComponent();
        }

        private void frmCadastroAparelhos_Load(object sender, EventArgs e)
        {
            CarregaAparelhos();
            CarregaFabricante();
        }

        public void CarregaAparelhos()
        {
            string sql;
            try
            {
                sql = "select aparelho.id_aparelho, fabricante.nome, aparelho.modelo, aparelho.quantidade, aparelho.preco";
                sql += " from aparelho inner join fabricante";
                sql += " on aparelho.id_fabricante = fabricante.id_fabricante";
                sql += " order by aparelho.modelo";
                dgvAparelhos.DataSource = Conexao.selecionarDataTable(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao carregar os dados dos aparelhos." +
                                "\n\nMais detalhes: " + ex.Message,
                                "Cadastro de Aparelhos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void CarregaFabricante()
        {
            string sql;
            try
            {
                sql = "select id_fabricante, nome from fabricante order by nome";
                cmbFabricante.DisplayMember = "nome";
                cmbFabricante.ValueMember = "id_fabricante";
                cmbFabricante.DataSource = Conexao.selecionarDataTable(sql);
                cmbFabricante.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao acessar os fabricantes de aparelho." +
                                "\n\nMais detalhes: " + ex.Message,
                                "Cadastro de Aparelhos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void LimpaForm()
        {
            txtID_Aparelho.Clear();
            cmbFabricante.SelectedIndex = -1;
            txtModelo.Clear();
            numAltura.Value = Convert.ToDecimal(0.00);
            numEspessura.Value = Convert.ToDecimal(0.00);
            numPreco.Value = Convert.ToDecimal(0.00);
            numDesconto.Value = Convert.ToDecimal(0.00);
            numLargura.Value = Convert.ToDecimal(0.00);
            numPeso.Value = Convert.ToDecimal(0.00);
            numQtde_estoque.Value = Convert.ToDecimal(0);
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
                txtID_Aparelho.Enabled = true;
            }
        }

        public void PesquisarAparelho(Int64 id_aparelho)
        {
            string sql;
            try
            {
                sql = "select * from aparelho";
                sql += " where id_aparelho = @1";
                List<object> parametro = new List<object> ();
                parametro.Add(Convert.ToInt64(txtID_Aparelho.Text));
                NpgsqlDataReader dr = Conexao.selecionar(sql, parametro);
                if (dr.Read())
                {
                    txtModelo.Text = dr["modelo"].ToString();
                    numAltura.Value = Convert.ToDecimal(dr["altura"]);
                    numLargura.Value = Convert.ToDecimal(dr["largura"]);
                    numEspessura.Value = Convert.ToDecimal(dr["espessura"]);
                    numPeso.Value = Convert.ToDecimal(dr["peso"]);

                    cmbFabricante.SelectedValue = Convert.ToInt64(dr["id_fabricante"]);
                }
                else
                {
                    MessageBox.Show("ID do aparelho não encontrado !!!",
                                    "Cadastro de Aparelhos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    LimpaForm();
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao acessar os dados do aparelho." + 
                                "\n\nMais detalhes:" + ex.Message,
                                "Cadastro de Aparelhos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LimpaForm();
            }
        }

        private void dgvAparelhos_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            id_aparelho = Convert.ToInt64(dgvAparelhos.Rows[e.RowIndex].Cells[0].Value);
            txtID_Aparelho.Text = id_aparelho.ToString();
            PesquisarAparelho(id_aparelho);
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            LimpaForm();
            txtID_Aparelho.Enabled = false; //ativado=falso (desativa o campo de ID)
            txtModelo.Focus();
            HabilitaBotoes();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(Convert.ToString(cmbFabricante.SelectedValue)) &&
               !String.IsNullOrEmpty(txtModelo.Text) && 
               !String.IsNullOrEmpty(Convert.ToString(numAltura.Value)) &&
               !String.IsNullOrEmpty(Convert.ToString(numLargura.Value)) &&
               !String.IsNullOrEmpty(Convert.ToString(numEspessura.Value)) &&
               !String.IsNullOrEmpty(Convert.ToString(numPeso.Value)) &&
               !String.IsNullOrEmpty(Convert.ToString(numPreco.Value)) &&
               !String.IsNullOrEmpty(Convert.ToString(numQtde_estoque.Value)) &&
               !String.IsNullOrEmpty(Convert.ToString(numDesconto.Value)))
            {
                string sql;
                try
                {
                    List<object> param = new List<object>();
                    param.Add(Convert.ToInt64(cmbFabricante.SelectedValue));
                    param.Add(txtModelo.Text);
                    param.Add(numAltura.Value);
                    param.Add(numLargura.Value);
                    param.Add(numEspessura.Value);
                    param.Add(numPeso.Value);
                    param.Add(numPreco.Value);
                    param.Add(Convert.ToInt64(numQtde_estoque.Value));
                    param.Add(numDesconto.Value);
                    //param.Add(Convert.ToInt64(txtID_Aparelho.Text));

                    if (!String.IsNullOrEmpty(txtID_Aparelho.Text))
                    {
                        param.Add(Convert.ToInt64(txtID_Aparelho.Text));
                        sql = "update aparelho set";
                        sql += " id_fabricante = @1,";
                        sql += " modelo = @2,";
                        sql += " altura = @3,";
                        sql += " largura = @4,";
                        sql += " espessura = @5,";
                        sql += " peso = @6,";
                        sql += " preco = @7,";
                        sql += " quantidade = @8,";
                        sql += " desconto = @9";
                        sql += " where id_aparelho = @10";
                    }
                    else
                    {
                        sql = "insert into aparelho(id_fabricante, modelo, altura, largura, espessura, peso, preco, quantidade, desconto)";
                        sql += " VALUES(@1, @2, @3, @4, @5, @6, @7, @8, @9)";
                    }

                    Conexao.executar(sql, param);

                    MessageBox.Show("Aparelho cadastrado com sucesso !!!",
                                            "Cadastro de Aparelhos",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Information);
                    HabilitaBotoes(false);
                    CarregaAparelhos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro ao realizar a ação no banco de dados." +
                                    "\n\nMais detalhes:" + ex.Message,
                                    "Cadastro de Aparelhos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    LimpaForm();
                }
            }
            else
            {
                MessageBox.Show("Não foi possível salvar. Todos os campos devem ser preenchidos!",
                                "Cadastro de Aparelhos",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            
        }

        private void txtID_Aparelho_Validated(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtID_Aparelho.Text))
            {
                PesquisarAparelho(Convert.ToInt64(txtID_Aparelho.Text));
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult resp;
            resp = MessageBox.Show("Deseja realmente cancelar este cadastro?",
                                    "Cadastro de Aparelhos",
                                    MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Question);
            if (resp == DialogResult.Yes)
            {
                LimpaForm();
                HabilitaBotoes(false);
                txtID_Aparelho.Focus();
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult resp;
            string sql;
            try
            {
                if (!String.IsNullOrEmpty(txtID_Aparelho.Text))//se ID estiver preenchido
                {
                    resp = MessageBox.Show("Deseja realmente excluir este aparelho?",
                                           "Cadastro de Aparelhos",
                                           MessageBoxButtons.YesNo,
                                           MessageBoxIcon.Question);
                    if (resp == DialogResult.Yes)
                    {
                        sql = "delete from aparelho"; //exclusão física
                        sql += "     where id_aparelho = @1";

                        List<object> parametro = new List<object>();
                        parametro.Add(Convert.ToInt64(txtID_Aparelho.Text));

                        Conexao.executar(sql, parametro);

                        MessageBox.Show("Aparelho excluído com sucesso !!!",
                                        "Cadastro de Aparelhos",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                        LimpaForm();
                        HabilitaBotoes(false);
                        CarregaAparelhos();
                        txtID_Aparelho.Focus();

                    }
                }
                else
                {
                    MessageBox.Show("Não foi selecionado nenhum ID para ser excluído. \nCaso desejo excluir um aparelho indique seu ID",
                                           "Cadastro de Aparelhos",
                                           MessageBoxButtons.OK,
                                           MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao excluir o aparelho !!!" +
                                "\n\nMais detalhes: " + ex.Message,
                                "Cadastro de Aparelhos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            DialogResult resp;
            resp = MessageBox.Show("Deseja realmente sair do cadastro de aparelhos?",
                                    "Cadastro de Aparelhos",
                                    MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Question);
            if (resp == DialogResult.Yes)
            {
                this.Close();
            }
        }

    }
}
