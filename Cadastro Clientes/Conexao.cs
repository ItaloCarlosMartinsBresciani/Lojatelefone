using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Data;
using System.Buffers;

namespace Cadastro_Clientes
{
    /*CLASSE DE CONEXÃO AO BANCO*/
    public static class Conexao
    {
       private static string stringConexao = "Server = banco72a.postgresql.dbaas.com.br;" +
                                                "Database = banco72a; Port=5432;" +
                                                "User ID= banco72a; password = b@nco@unesp356;";

       static NpgsqlConnection cn;

       //Método de conexão com o banco
       public static void conectar()
       {
            if (cn == null)
            cn = new NpgsqlConnection();
            try
            {
                if (cn.State != ConnectionState.Open)
                {
                    cn.ConnectionString = stringConexao;
                    cn.Open(); //abre a conexão com o banco de dados
                }
            }
            catch (NpgsqlException ex)
            {
               throw new ApplicationException(ex.Message);
            }
       }

                public static object CarregaGrid(string sql)
            {
                conectar();
                NpgsqlCommand cmd = new NpgsqlCommand(sql, cn);
                NpgsqlDataAdapter daEntity = new NpgsqlDataAdapter(cmd);
                DataSet dsEntity = new DataSet();

                dsEntity.Clear();
                daEntity.Fill(dsEntity);
                return dsEntity.Tables[0];
            }

            //Método de desconexão com o banco
            public static void desconectar()
            {
                cn.Close();// fecha a conexão com o banco de dados
                cn.Dispose(); // libera os recursos utilizados
                cn = null;
            }

            //Execução de uma query no banco de dados sem retorno (insert/update/delete)
            public static void executar(string sql) // sql é o parâmetro recebido na chamada do método
            {
                try
                {
                    conectar();
                    NpgsqlCommand cmd = new NpgsqlCommand(sql, cn);
                    cmd.ExecuteNonQuery();
                }
                catch (NpgsqlException ex)
                {
                    throw new ApplicationException(ex.Message);
                }
                finally
                {
                    desconectar();
                }
            }

                
           

        //Execução de uma query no banco de dados com parametros
        public static void executar(string sql, List<object> parametros)
            // sql=parâmtero do texto de comando
            // list parametros= lista de parâmetros recbidos da chamada
            {
                try
                {
                    conectar();
                    NpgsqlCommand cmd = new NpgsqlCommand();
                    cmd.CommandText = sql;
                    cmd.Connection = cn;
                    int i = 1;
                    foreach (object parametro in parametros)
                        cmd.Parameters.AddWithValue(i++.ToString(), parametro); //adicionada cada parâmetro aos parâmetros no comando sql
                    cmd.ExecuteNonQuery(); 
                }
                catch (NpgsqlException ex)
                {
                    throw new ApplicationException(ex.Message);
                }
                finally
                {
                    desconectar();
                }
            }
            //Executa uma query no banco de dados com parametros retornando 'campoRetorno'
            public static int executar(string sql, List<object> parametros, string campoRetorno)
            {
                try
                {
                    conectar();
                    NpgsqlCommand cmd = new NpgsqlCommand();
                    int modificado = 0;
                    cmd.CommandText = sql + " RETURNING " + campoRetorno;
                    cmd.Connection = cn;
                    int i = 1;
                    foreach (object parametro in parametros)
                        cmd.Parameters.AddWithValue(i++.ToString(), parametro);
                    modificado = Convert.ToInt32(cmd.ExecuteScalar());
                    return modificado;
                }
                catch (NpgsqlException ex)
                {
                    throw new ApplicationException(ex.Message);
                }
                finally
                {
                    desconectar();
                }
            }

            //Select simples retornando um DataReader
            public static NpgsqlDataReader selecionar(string sql)
            {
                try
                {
                    conectar();
                    NpgsqlCommand cmd = new NpgsqlCommand(sql, cn);
                    return cmd.ExecuteReader(CommandBehavior.CloseConnection);
                }
                catch (NpgsqlException ex)
                {
                    desconectar();
                    throw new ApplicationException(ex.Message);
                }
            }
            //Select com parametros retornando um DataReader
            public static NpgsqlDataReader selecionar(string sql, List<object> parametros)
            {
                try
                {
                    conectar();
                    NpgsqlCommand cmd = new NpgsqlCommand();
                    cmd.CommandText = sql;
                    cmd.Connection = cn;
                    int i = 1;
                    foreach (object parametro in parametros)
                        cmd.Parameters.AddWithValue(i++.ToString(), parametro);
                    return cmd.ExecuteReader(CommandBehavior.CloseConnection);
                }
                catch (NpgsqlException ex)
                {
                    desconectar();
                    throw new ApplicationException(ex.Message);
                }
            }
            // Select retornando os dados em um DataTable
            public static DataTable selecionarDataTable(string sql)
            {
                try
                {
                    conectar();
                    // Cria o objeto DataTable
                    DataTable dt = new DataTable();
                    NpgsqlCommand cmd = new NpgsqlCommand(sql, cn);
                    NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
                    dt.Clear();
                    da.Fill(dt);
                    return dt;
                }
                catch (NpgsqlException ex)
                {
                    throw new ApplicationException(ex.Message);
                }
                finally
                {
                    desconectar();
                }
            }

             public static DataTable selecionarDataTable2(string sql, List<object> param)
            {
                try
                {
                    conectar();
                    // Cria o objeto DataTable
                    DataTable dt = new DataTable();
                    NpgsqlCommand cmd = new NpgsqlCommand(sql, cn);
                    int i = 1;
                    foreach (object parametro in param)
                        cmd.Parameters.AddWithValue(i++.ToString(), parametro);
                    NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
                    dt.Clear();
                    da.Fill(dt);
                    return dt;
                }
                catch (NpgsqlException ex)
                {
                    throw new ApplicationException(ex.Message);
                }
                finally
                {
                    desconectar();
                }
            }


            public static DataSet selecionarDataSet(string sql)
            {
                try
                {
                    conectar();
                    // Cria o objeto DataSet
                    DataSet ds = new DataSet();
                    NpgsqlCommand cmd = new NpgsqlCommand(sql, cn);
                    NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
                    da.Fill(ds);
                    return ds;
                }
                catch (NpgsqlException ex)
                {
                    throw new ApplicationException(ex.Message);
                }
                finally
                {
                    desconectar();
                }
            }
            public static DataSet selecionarDataSet(string tabela, string campos, string where = "", string orderBy = "")
            {
                try
                {
                    conectar();
                    // Cria o objeto DataSet
                    DataSet ds = new DataSet();
                    string sql = @"select " + campos + " from " + tabela;
                    if (where != "")
                        sql += @" where " + where + " ";
                    if (orderBy != "")
                        sql += @" order by " + orderBy + " ";
                    NpgsqlCommand cmd = new NpgsqlCommand(sql, cn);
                    NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
                    da.Fill(ds, tabela);
                    return ds;
                }
                catch (NpgsqlException ex)
                {
                    throw new ApplicationException(ex.Message);
                }
                finally
                {
                    desconectar();
                }
            }
             
        }
    }

