using ConceitosOO.Abstracao.Classe.Abstrata;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConceitosOO
{
    class Program
    {
        public static void Main(string[] args)
        {
            new Soma(3, 2).ImprimeResultado();
            new Multiplicacao(5, 1).ImprimeResultado();
            new Subtracao(10, 5).ImprimeResultado();
            new Divisao(10, 2).ImprimeResultado();
            new Raiz(25, 0).ImprimeResultado();
            new Potencializacao(5, 2).ImprimeResultado();

            // Criar operações (subtração, multiplicação, divisão, raiz, potencial (2 elevado a 3 ).
            // Ler Abstração material impresso.

        }
    }
}
