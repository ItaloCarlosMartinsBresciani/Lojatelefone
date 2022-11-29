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
    public partial class frmPesquisaFabricante : Form
    {
        private Int64 id_fabricante;
        private string nome;
        public frmPesquisaFabricante()
        {
            InitializeComponent();
        }

        private void frmPesquisaFabricante_Load(object sender, EventArgs e)
        {
            CarregaGridFabricante();
            InibicaoCampos();
        }

        public void InibicaoCampos()
        {
            txtId_Fabricante.Enabled = false;
            txtNome_fabricante.Enabled = false;
        }

        private void CarregaGridFabricante()
        {
            try
            {
                string sql;
                sql = "select * from fabricante";
                sql += " order by nome";
                dgvFabricantes.DataSource = Conexao.selecionarDataTable(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao realizar a pesquisa de fabricantes." +
                               "\n\nMais detalhes: " + ex.Message,
                               "Pesquisa de Fabricantes", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            frmCadastroFabricante cadastro_fabricante = new frmCadastroFabricante();
            cadastro_fabricante.ShowDialog();
            CarregaGridFabricante();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult resp;
            string sql;
            try
            {
                if (id_fabricante != 0)
                {
                    resp = MessageBox.Show("Deseja realmente excluir o fabricante " + nome + "?",
                                            "Cadastro de Fabricantes",
                                            MessageBoxButtons.YesNo,
                                            MessageBoxIcon.Question);
                    if (resp == DialogResult.Yes)
                    {
                        List<object> parametro = new List<object>();
                        parametro.Add(id_fabricante);

                        sql = "delete from fabricante";
                        sql += " where id_fabricante = @1";
                        Conexao.executar(sql, parametro);

                        MessageBox.Show("Fabricante excluído com sucesso!!!", "Pesquisa de Fabricantes",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                        CarregaGridFabricante();
                        InibicaoCampos();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao realizar a exclusão do fabricante." +
                                "\n\nMais detalhes: " + ex.Message,
                                "Pesquisa de Fabricantes", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void LimpaForm()
        {
            txtId_Fabricante.Text = "";
            txtNome_fabricante.Text = "";
            
        }

        public void PesquisarFabricante(Int64 id_fabricante)
        {
            string sql;
            try
            {
                sql = "select * from fabricante";
                sql += " where id_fabricante = @1";
                List<object> parametro = new List<object>();
                parametro.Add(id_fabricante);
                NpgsqlDataReader dr = Conexao.selecionar(sql, parametro);
                if (dr.Read())
                {
                    txtId_Fabricante.Text = dr["id_fabricante"].ToString();
                    txtNome_fabricante.Text = dr["nome"].ToString();
                }
                else
                {
                    MessageBox.Show("ID do fabricante não encontrado !!!",
                                    "Pesquisa de Fabricantes", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    LimpaForm();
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao acessar os dados do fabricante." +
                                "\n\nMais detalhes:" + ex.Message,
                                "Pesquisa de Fabricantes", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LimpaForm();
            }
        }
        private void dgvFabricantes_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            id_fabricante = Convert.ToInt64(dgvFabricantes.Rows[e.RowIndex].Cells[0].Value);
            nome = dgvFabricantes.Rows[e.RowIndex].Cells[1].Value.ToString();
            PesquisarFabricante(id_fabricante);

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            DialogResult resp;
            resp = MessageBox.Show("Deseja realmente sair da pesquisa de fabricantes?",
                                    "Pesquisa de Fabricantes",
                                    MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Question);
            if (resp == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            txtNome_fabricante.Enabled = true;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtNome_fabricante.Text))
            {
                if (!String.IsNullOrEmpty(txtId_Fabricante.Text))
                {
                    string sql;
                    try
                    {
                        List<object> parametros = new List<object>();
                        parametros.Add(txtNome_fabricante.Text);//@1
                        parametros.Add(Convert.ToInt64(txtId_Fabricante.Text));//@2

                        sql = "update fabricante set";
                        sql += " nome = @1";
                        sql += " where id_fabricante = @2";

                        Conexao.executar(sql, parametros);

                        MessageBox.Show("Fabricante atualizado com sucesso!!!", "Pesquisa de Fabricantes",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                        CarregaGridFabricante();
                        InibicaoCampos();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ocorreu um erro ao salvar os dados do fabricante !!!" +
                                    "\n\nMais detalhes:" + ex.Message, "Pesquisa de Fabricantes",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
            else
            {
                MessageBox.Show("Não foi possível salvar. Todos os campos devem ser preenchidos!",
                                "Pesquisa de Fabricantes", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }

}
