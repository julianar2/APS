using ModeloBancoDeDados;
using System;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DALProduto
    {
        private DalConexao dalconexao;
        public DALProduto(DalConexao conexao)
        {
            this.dalconexao = conexao;
        }

        public void Incluir(ModeloProduto modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = dalconexao.ObjetoConexao;
            cmd.CommandText = "insert into produto(nome_produto, valor_produto) values (@nome, @preco); select @@IDENTITY;";
            cmd.Parameters.AddWithValue("@nome", modelo.NomeProduto);
            cmd.Parameters.AddWithValue("@preco", modelo.ValorProduto);
            dalconexao.Conectar();
            modelo.CodProduto = Convert.ToInt32(cmd.ExecuteScalar());
            dalconexao.Desconectar();
        }

        public void Alterar(ModeloProduto modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = dalconexao.ObjetoConexao;
            cmd.CommandText = "update produto set nome_produto = @nome, valor_produto = @preco where cod_produto = @codigo";
            cmd.Parameters.AddWithValue("@nome", modelo.NomeProduto);
            cmd.Parameters.AddWithValue("@preco", modelo.ValorProduto);
            cmd.Parameters.AddWithValue("@codigo", modelo.CodProduto);
            dalconexao.Conectar();
            cmd.ExecuteNonQuery();
            dalconexao.Desconectar();

        }

        public void Excluir(int codigo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = dalconexao.ObjetoConexao;
            cmd.CommandText = "delete from produto where cod_produto = @codigo ";
            cmd.Parameters.AddWithValue("@codigo", codigo);
            dalconexao.Conectar();
            cmd.ExecuteNonQuery();
            dalconexao.Desconectar();

        }

        public DataTable Localizar(String valor)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from produto where nome_produto like '%" + valor +"%'",dalconexao.StringConexao);
            da.Fill(tabela);
            return tabela;
               
        }

        public ModeloProduto CarregaModeloProduto(int codigo)
        {
            ModeloProduto modelo = new ModeloProduto();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = dalconexao.ObjetoConexao;
            cmd.CommandText = "select * from produto where cod_produto = @codigo";
            cmd.Parameters.AddWithValue("@codigo", codigo);
            dalconexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                modelo.CodProduto = Convert.ToInt32(registro["cod_produto"]);
                modelo.NomeProduto = Convert.ToString(registro["nome_produto"]);
                modelo.ValorProduto = Convert.ToDouble(registro["valor_produto"]);
            }
            dalconexao.Desconectar();
            return modelo;
        }
    }
}
