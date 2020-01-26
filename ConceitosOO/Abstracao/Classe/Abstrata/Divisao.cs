namespace ConceitosOO.Abstracao.Classe.Abstrata
{
    public class Divisao : CalculoBase
    {
        public Divisao(int valorA, int valorB) : base(valorA, valorB)
        {
        }

        protected override double CalculaOperacao() => ValorA / ValorB;

        protected override string RecuperaOperacao() => "Divisao";
    }
}
