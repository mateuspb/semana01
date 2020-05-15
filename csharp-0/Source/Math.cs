using System;
using System.Collections.Generic;

namespace Codenation.Challenge
{
    public class Math
    {
        public List<int> Fibonacci()
        {
            int maiorNumero = 350;
            int posAtual = 1;
            var sequenciaFibonacci = new List<int> {0, 1};
            while (sequenciaFibonacci[posAtual - 1] + sequenciaFibonacci[posAtual] <= maiorNumero)
            {
                sequenciaFibonacci.Add(sequenciaFibonacci[posAtual - 1] + sequenciaFibonacci[posAtual]);
                posAtual++;
            }
            return sequenciaFibonacci;
        }

        public bool IsFibonacci(int numberToTest)
        {
            // chama metodo para montar a sequencia de fibonacci
            return Fibonacci().Contains(numberToTest);
        }
    }
}
