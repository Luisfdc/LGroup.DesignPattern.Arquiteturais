using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LGroup.Arquiteturais.Domain.DomainModels.ValuesObjects
{
    public class Preco
    {
        public Preco(decimal cotacao,Moeda moeda,decimal valor)
        {
            Valor = valor;
            Cotacao = cotacao;
            Moeda = moeda;
        }
        public decimal PrecoTotal => GetValorTotal();
        public decimal Valor { get; private set; }
        public Moeda Moeda { get; private set; }
        public decimal Cotacao { get; private set; }
        public decimal GetValorTotal()
        {
            switch (Moeda)
            {
                case Moeda.Real:
                    return Valor;
                case Moeda.Dolar:
                    return Valor* Cotacao;
                case Moeda.Euro:
                    return Valor * Cotacao;
                        default:
                    throw new Exception("Moeda invalida");
            }
        }
    }
    public enum Moeda
    {
        Real,Dolar,Euro
    }
}
