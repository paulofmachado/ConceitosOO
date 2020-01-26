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
            new Soma(10, 22).ImprimeResultado();

            new Multiplicacao(5, 5).ImprimeResultado();

            new Subtracao(10, 5).ImprimeResultado();

            // Criar operações (subtração, multiplicação, divisão, raiz, potencial (2 elevado a 3 ).
            // Ler Abstração material impresso.

        }
    }
}
 