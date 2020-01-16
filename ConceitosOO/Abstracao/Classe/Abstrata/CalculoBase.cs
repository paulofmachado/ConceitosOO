using System;

namespace ConceitosOO.Abstracao.Classe.Abstrata
{
    public abstract class CalculoBase
    {
        protected CalculoBase(int valorA, int valorB)
        {
            ValorA = valorA;
            ValorB = valorB;
        }

        public int ValorA { get; }
        public int ValorB { get; }

        public void ImprimeResultado()
        {
            var resultado = CalculaOperacao();
            var operacao = RecuperaOperacao();

            Console.WriteLine($"A {operacao} com os valores {ValorA} e {ValorB} resultam em {resultado}");
        }

        protected abstract string RecuperaOperacao();
        protected abstract double CalculaOperacao();
    }
}
