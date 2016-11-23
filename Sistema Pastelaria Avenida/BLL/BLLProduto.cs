using DAL;
using ModeloBancoDeDados;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    class BLLProduto
    {
        private DalConexao dalconexao;

        public BLLProduto(DalConexao conexao)
        {
            this.dalconexao = conexao;
        }

        private void Incluir(ModeloProduto modelo)
        {
            if(modelo.NomeProduto.Trim().Length == 0)
            {
                throw new Exception("O nome do produto é obrigatorio");
            }
            DALProduto DALobj = new DALProduto(dalconexao);
            DALobj.Incluir(modelo);
        }

        private void Alterar(ModeloProduto modelo)
        {
            if (modelo.CodProduto <= 0)
            {
                throw new Exception("O codigo do produto e obrigatorio");
            }


            if (modelo.NomeProduto.Trim().Length == 0)
            {
                throw new Exception("O nome do produto é obrigatorio");
            }
            DALProduto DALobj = new DALProduto(dalconexao);
            DALobj.Alterar(modelo);

        }

        public void Excluir(int codigo)
        {
            DALProduto DALobj = new DALProduto(dalconexao);
            DALobj.Excluir(codigo);

        }

        public DataTable Localizar(String valor)
        {
            DALProduto DALobj = new DALProduto(dalconexao);
            return DALobj.Localizar(valor);
        }

        public ModeloProduto CarregaModeloProduto(int codigo)
        {
            DALProduto DALobj = new DALProduto(dalconexao);
            return DALobj.CarregaModeloProduto(codigo);
        }


    }
}
