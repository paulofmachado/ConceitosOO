namespace ConceitosOO.Abstracao.Classe.Abstrata
{
    public class Multiplicacao : CalculoBase
    {
        public Multiplicacao(int valorA, int valorB) : base(valorA, valorB)
        {
        }

        protected override double CalculaOperacao() => ValorA * ValorB;

        protected override string RecuperaOperacao() => "Multiplicacao";
    }
}
