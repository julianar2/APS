using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloBancoDeDados
{
    public class ModeloProduto
    {
        private int cod_produto;

        public int CodProduto
        {
            get { return this.cod_produto;}
            set { this.cod_produto = value;}
        }
        private String nome_produto;

        public String NomeProduto
        {
            get { return this.nome_produto; }
            set { this.nome_produto = value; }
        }
        private Double valor_produto;

        public Double ValorProduto
        {
            get { return this.valor_produto; }
            set { this.valor_produto = value; }
        }
    }
}
