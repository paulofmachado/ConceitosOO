using System;

namespace ConceitosOO.Abstracao.Classe.Abstrata
{
    public class Potencializacao : CalculoBase
    {
        public Potencializacao(int valorA, int valorB) : base(valorA, valorB)
        {
        }

        protected override double CalculaOperacao() => Math.Pow(ValorA, ValorB);

        protected override string RecuperaOperacao() => "Potencializacao";
    }
}
