using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoOrientacaoObjeto
{
    public class Produtos
    {
        private int codigo;
        private string descricao;
        private int valor;
        private int quantidade;


        public void setCodigo(int codigo)
        {  
            this.codigo = codigo; 
        }

        public int getCodigo()
        {
            return this.codigo;
        }

        public void setDescricao(string descricao)
        {  
            this.descricao = descricao;
        }

        public string getDescricao() 
        { 
            return this.descricao;
        }

        public void setValor(int valor)
        { 
            this.valor = valor;
        }

        public int getValor() 
        {
            return this.valor;
        }
    }   
}
