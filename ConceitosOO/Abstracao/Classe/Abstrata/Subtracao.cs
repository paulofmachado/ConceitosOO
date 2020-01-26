namespace ConceitosOO.Abstracao.Classe.Abstrata
{
    public class Subtracao : CalculoBase
    {
        public Subtracao(int valorA, int valorB) : base(valorA, valorB)
        {
        }

        protected override double CalculaOperacao() => ValorA - ValorB;

        protected override string RecuperaOperacao() => "Subtracao";
    }
}
