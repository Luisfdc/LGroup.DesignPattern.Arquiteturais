using LGroup.Arquiteturais.Domain.DomainModels.ValuesObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LGroup.Arquiteturais.Domain.DomainModels.Entities
{
    public class Curso
    {
        private Curso(){}
        public Curso(string nome)
        {
            this.Nome = nome;
            this.Professores = new List<Professor>();
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public Preco Preco { get; private set; }

        public void AddPreco(decimal cotacao,Moeda moeda,decimal valor)
        {
            if(cotacao == default(decimal))
                throw new ApplicationException("Cotação invalida");

            if (valor <= default(decimal))
                throw new ApplicationException("Valor invalido");

            this.Preco = new Preco(cotacao, moeda, valor);
        }

        public ICollection<Professor> Professores { get; set; }
    }
}
