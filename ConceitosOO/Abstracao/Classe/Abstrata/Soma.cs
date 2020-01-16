using System;

namespace ConceitosOO.Abstracao.Classe.Abstrata
{
    public class Soma : CalculoBase
    {
        public Soma(int valorA, int valorB) : base(valorA, valorB)
        {
        }

        protected override double CalculaOperacao() => ValorA + ValorB;

        protected override string RecuperaOperacao() => "Soma";
    }
}
