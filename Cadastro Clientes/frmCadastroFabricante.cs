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
    public partial class frmCadastroFabricante : Form
    {
        public frmCadastroFabricante()
        {
            InitializeComponent();
        }

        private void frmCadastroFabricante_Load(object sender, EventArgs e)
        {

        }

        private void LimpaForm()
        {
            txtID_Fabricante.Clear();
            txtNome.Clear();
            txtID_Fabricante.Focus();
        }

        private void HabilitaBotoes(bool estadoNovo = true)
        {
            if (estadoNovo) //se os botões estiverem habilitados (estado=true)
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
                txtID_Fabricante.Enabled = true;
            }
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(txtNome.Text))
            {
                string sql;
                try
                {
                    if (!String.IsNullOrEmpty(txtID_Fabricante.Text))// se o id estiver preenchido(alteração de dados)
                    {
                        sql = "update fabricante set";
                        sql += " nome = @1";
                        sql += " where id_fabricante= @2";
                    }
                    else//se o id não estiver preenchido
                    {
                        sql = "insert into fabricante (nome)";
                        sql += " values (@1)";
                    }

                    List<object> parametros = new List<object>();
                    parametros.Add(txtNome.Text); //@1
                    if (!String.IsNullOrEmpty(txtID_Fabricante.Text))
                        parametros.Add(Convert.ToInt64(txtID_Fabricante.Text));//@2

                    Conexao.executar(sql, parametros);

                    MessageBox.Show("Cliente cadastrado com sucesso!!!", "Cadastro de Clientes",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtID_Fabricante.Enabled = false;
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
                                "Cadastro de Fabricantes", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
            

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult resp;
            string sql;
            try
            {
                if (!String.IsNullOrEmpty(txtID_Fabricante.Text))//se ID estiver preenchido
                {
                    resp = MessageBox.Show("Deseja realmente excluir este fabricante?",
                                           "Cadastro de Fabricantes",
                                           MessageBoxButtons.YesNo,
                                           MessageBoxIcon.Question);
                    if (resp == DialogResult.Yes)
                    {
                        sql = "delete from fabricante"; //exclusão física
                        sql += "     where id_fabricante = @1";
                        
                        List<object> parametro = new List<object>();
                        parametro.Add(Convert.ToInt64(txtID_Fabricante.Text));
                        
                        Conexao.executar(sql, parametro);
                        
                        MessageBox.Show("Fabricante excluído com sucesso !!!",
                                        "Cadastro de Fabricantes",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                        LimpaForm();
                        HabilitaBotoes(false);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao excluir o fabricante !!!" +
                                "\n\nMais detalhes: " + ex.Message,
                                "Cadastro de Fabricantes", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
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
                LimpaForm();
                HabilitaBotoes(false);
                txtID_Fabricante.Focus();
            }
    
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            DialogResult resp;
            resp = MessageBox.Show("Deseja realmente sair do cadastro de fabricantes?",
                                    "Cadastro de Fabricantes",
                                    MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Question);
            if (resp == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            LimpaForm();
            txtID_Fabricante.Enabled = false; //ativado=falso (desativa o campo de ID)
            txtNome.Focus();
            HabilitaBotoes();
        }

        private void txtID_Fabricante_Validated(object sender, EventArgs e)
        {
            string sql;
            try
            {
                if (!String.IsNullOrEmpty(txtID_Fabricante.Text)) //verifica se não é nulo = se está preenchido
                {
                    btnSalvar.Enabled = false;
                    sql = "select * from fabricante"; 
                    sql += " where id_fabricante = @1"; //monta sql com parâmetro
                    List<object> parametro = new List<object>();
                    parametro.Add(Convert.ToInt64(txtID_Fabricante.Text));
                    NpgsqlDataReader dr = Conexao.selecionar(sql, parametro);

                    if (dr.Read())
                    {
                        txtNome.Text = dr["nome"].ToString();
                    }
                    else
                    {
                        LimpaForm();
                        MessageBox.Show("Id do fabricante não encontrado !!!",
                                        "Cadastro de Fabricantes",
                                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    dr.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao processar o comando no banco de dados" + "\n\nMais detalhes: "
                                + ex.Message, "Cadastro de Fabricantes", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
