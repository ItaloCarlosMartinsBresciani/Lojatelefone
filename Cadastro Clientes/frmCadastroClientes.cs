using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql; //referência ao postgres

namespace Cadastro_Clientes
{
    public partial class frmCadastroClientes : Form
    {
        public frmCadastroClientes()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtNome.Text) && !String.IsNullOrEmpty(txtEmail.Text) && !String.IsNullOrEmpty(Convert.ToString(mskTelefone.Text)))
            {
                string sql;
                try
                {
                    //Testes de Consistência e regras de negócio
                    if (String.IsNullOrEmpty(txtNome.Text))//caso o campo de nome não tenha sido preenchido
                    {
                        MessageBox.Show("Preencha o nome do cliente !!!", "Cadastro de Clientes",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtNome.Focus();
                        return;
                    }
                    if (String.IsNullOrEmpty(txtID_Cliente.Text))// caso o campo de Id não tenha sido preenchido
                    {
                        sql = "insert into cliente (nome, telefone, email)";
                        sql += "values (@1, @2, @3)";
                    }
                    else //caso o id tenha sido inserido, mostrando que o usuário deseja alterar seus dados
                    {
                        sql = "update cliente set"; //atualizamos os dados na tabela daquele registro
                        sql += "nome = @1,";
                        sql += "telefone = @2,";
                        sql += "email = @3";
                        sql += "where id_cliente = @4";
                    }
                    sql = "insert into cliente (nome, telefone, email)";
                    sql += "values (@1,@2,@3)";


                    //Lista de parametros
                    List<object> parametros = new List<object>();
                    parametros.Add(txtNome.Text);
                    parametros.Add(mskTelefone.Text);
                    parametros.Add(txtEmail.Text);
                    if (!String.IsNullOrWhiteSpace(txtID_Cliente.Text)) //se o ID não está vazio
                        parametros.Add(Convert.ToInt64(txtID_Cliente.Text));

                    Conexao.executar(sql, parametros); //comando de insert ou update= comand non query

                    MessageBox.Show("Cliente cadastrado com sucesso!!!", "Cadastro de Clientes",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtID_Cliente.Enabled = false;
                    LimpaForm();
                    HabilitaBotoes(false);
                }
                catch (NpgsqlException ex)
                {
                    MessageBox.Show("Ocorreu um erro ao salvar os dados do cliente !!!" +
                                    "\n\nMais detalhes:" + ex.Message, "Cadastro de Clientes",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Não foi possível salvar. Todos os campos devem ser preenchidos!",
                                "Cadastro de Clientes", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void LimpaForm ()
        {
            txtID_Cliente.Clear();
            txtNome.Clear();
            mskTelefone.Clear();
            txtEmail.Clear();
            txtID_Cliente.Focus();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            LimpaForm();
            txtID_Cliente.Enabled = false; //ativado=falso (desativa o campo de ID)
            HabilitaBotoes();
            txtNome.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult resp;
            resp = MessageBox.Show("Deseja realmente cancelar este cadastro?",
                                    "Cadastro de Fabricantes",
                                    MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Question);
            if (resp == DialogResult.Yes)
            {
                txtID_Cliente.Enabled = true; //ativa o campo de ID
                LimpaForm();
                HabilitaBotoes(false);
            }
        }

        private void HabilitaBotoes(bool estadoNovo = true)
        {
            if(estadoNovo) //se os botões estiverem habilitados (estado=true)
            {
                btnNovo.Enabled = false; //não poderemos clicar para adicionar novo cadastro (pois já está cadastrando)
                btnSalvar.Enabled = true; //poderemos salvar cadastro
                btnCancelar.Enabled = true;//poderemos cancelar a adição do novo cadastro
                btnExcluir.Enabled = false;// não poderemos excluir cadastro
                btnSair.Enabled = false;//não poderemos sair do form
            }
            else //se os botões não estiverem habilitados
            {
                btnNovo.Enabled = true; //poderemos add novo cadastro
                btnSalvar.Enabled = true; //poderemos salvar cadastro
                btnCancelar.Enabled = true;//poderemos cancelar a adição do novo cadastro
                btnExcluir.Enabled = true;//poderemos excluir cadastro
                btnSair.Enabled = true;//poderemos sair do form
                txtID_Cliente.Enabled = true;
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult resp;
            string sql;
            try
            {
                if(!String.IsNullOrEmpty(txtID_Cliente.Text))//se ID estiver preenchido
                {
                    resp = MessageBox.Show("Deseja realmente excluir o cliente " +
                                            txtNome.Text, "Cadastro Clientes",
                                            MessageBoxButtons.YesNo,
                                            MessageBoxIcon.Question);
                    if (resp == DialogResult.Yes)
                    {
                        sql = "delete from cliente"; //exclusão física
                        sql += "     where id_cliente = @1";
                        List<object> parametro = new List<object>();
                        parametro.Add(Convert.ToInt64(txtID_Cliente.Text));
                        Conexao.executar(sql, parametro);
                        MessageBox.Show("Cliente excluído com sucesso !!!",
                                         "Cadastro de Clientes",
                                         MessageBoxButtons.OK,
                                         MessageBoxIcon.Information);
                        LimpaForm();
                        HabilitaBotoes(false);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao excluir o cliente !!!" +
                                "\n\nMais detalhes: " + ex.Message,
                                "Cadastro de Clientes", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            DialogResult resp;
            resp = MessageBox.Show("Deseja realmente sair do cadastro de clientes?",
                                    "Cadastro de Clientes",
                                    MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Question);
            if (resp == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void frmCadastroClientes_Load(object sender, EventArgs e)
        {

        }

        private void txtID_Cliente_Validated(object sender, EventArgs e)
        {

            string sql;
            try
            {
                if (!String.IsNullOrEmpty(txtID_Cliente.Text)) //verifica se não é nulo
                {
                    btnSalvar.Enabled = false;
                    sql = "select * from cliente";
                    sql += " where id_cliente = @1"; //monta sql com parâmetro
                    List<object> parametro = new List<object>();
                    parametro.Add(Convert.ToInt64(txtID_Cliente.Text));
                    NpgsqlDataReader dr = Conexao.selecionar(sql, parametro);

                    if (dr.Read())
                    {
                        txtNome.Text = dr["nome"].ToString();
                        txtEmail.Text = dr["email"].ToString();
                        mskTelefone.Text = dr["telefone"].ToString();
                    }
                    else
                    {
                        LimpaForm();
                        MessageBox.Show("Id do cliente não encontrado !!!",
                                    "Cadastro de Clientes",
                                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    }
                    dr.Close();
                    
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao processar o comando no banco de dados" + "\n\nMais detalhes: "
                                + ex.Message, "Cadastro de Clientes", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
