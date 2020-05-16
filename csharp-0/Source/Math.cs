using System;
using System.Collections.Generic;

namespace Codenation.Challenge
{
    public class Math
    {
        // funcao que calcula a sequencia de Fibonacci 
        // retorna um objeto do tipo lista de inteiros
        public List<int> Fibonacci()
        {
            // variavel usada para setar maior numero possivel na sequencia de Fibonacci
            int maiorNumero = 350;
            // cria o objeto do tipo lista setando as duas posicoes iniciais com 0 e 1
            var sequenciaFibonacci = new List<int> { 0, 1 };
            // variavel usada para setar a possicao atual da lista
            // setado em um pois ao criar o array ja foi criado com dois registros
            int posAtual = 1;
            // laco de repeticao somando os dois ultimos numeros da lista e verificando 
            // se ele e menor ou igual ao numero maximo da sequencia de Fibonacci
            while (sequenciaFibonacci[posAtual - 1] + sequenciaFibonacci[posAtual] <= maiorNumero)
            {
                // adiciona elemento na lista igual a soma dos dois anteriores
                sequenciaFibonacci.Add(sequenciaFibonacci[posAtual - 1] + sequenciaFibonacci[posAtual]);
                // atualiza a ultima posicao da lista
                posAtual++;
            }
            // retorna a lista calculada contendo a sequencia de Fibonacci
            return sequenciaFibonacci;
        }

        // funcao que verifica se o numero passado por parametro existe na sequencia de Fibonacci e retorna TRUE ou FALSE
        public bool IsFibonacci(int numberToTest)
        {
            // chama metodo para montar a sequencia de Fibonacci e verifica se o numero passado existe na lista
            return Fibonacci().Contains(numberToTest);
        }
    }
}
