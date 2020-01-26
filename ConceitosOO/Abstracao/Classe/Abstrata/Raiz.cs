using System;

namespace ConceitosOO.Abstracao.Classe.Abstrata
{
    public class Raiz : CalculoBase
    {
        public Raiz(int valorA, int valorB) : base(valorA, valorB)
        {
        }

        protected override double CalculaOperacao() => Convert.ToSingle(Math.Sqrt(ValorA));

        protected override string RecuperaOperacao() => "Raiz";
    }
}
