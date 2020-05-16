using System;

namespace Codenation.Challenge
{
    public class CesarCypher : ICrypt, IDecrypt
    {
        // funcao que efetua a criptografia de uma string
        // cifra o campo de texto utilizando o número de casas de deslocamento
        public string Crypt(string message)
        {
            // se a mensagem recebida for nula gera excecao
            if (message == null) throw new System.ArgumentNullException();

            // se a mensagem recebida estiver em branco
            if (message == String.Empty) return message;

            // definicao das variaveis
            int numCar = 0, num = 0, numero_casas = 3;
            string textoDec = "", textoCif = "";

            // converte a string recebida para letras minusculas
            textoDec = message.ToLower();

            // seta o tamanho do texto a ser criptografado
            numCar = textoDec.Length;

            // laco de repeticao para percorrer a string caracter por caracter
            for (int i = 0; i < numCar; i++)
            {
                // pega o codigo ASCII do caracter na posicao 
                num = Convert.ToInt32(textoDec[i]);
                
                // se o caracter for uma letra efetua a criptografia
                if (num >= 97 && num <= 122)
                {
                    // efetua o deslocamento, somando o numero de casas
                    num = num + numero_casas;

                    // se ultrapassou o alfabeto (caracteres de 'a' a 'z')
                    if (num > 122)
                    {
                        // retorna pra primeira letra e soma a quantidade que ultrapassou a ultima letra
                        num = 96 + (num - 122);
                    }
                }
                // se o caracter nao for um numero ou um espaco gera excecao
                else if (!((num >= 48 && num <= 57) || (num == 32)))
                {
                    throw new System.ArgumentOutOfRangeException();
                }

                // adciona a letra criptografada ao texto
                textoCif += Convert.ToChar(num);
            }
            // retorna a string contendo o texto criptografado
            return (textoCif);
        }

        // funcao que efetua a descriptografia de uma string
        // decifra o campo de texto cifrado utilizando o número de casas de deslocamento
        public string Decrypt(string cryptedMessage)
        {
            // se a mensagem recebida for nula gera excecao
            if (cryptedMessage == null) throw new System.ArgumentNullException();

            // definicao das variaveis
            int numCar = 0, num = 0, numero_casas = 3;
            string textoDec = "", textoCif = "";

            // converte a string recebida para letras minusculas
            textoCif = cryptedMessage.ToLower();

            // seta o tamanho do texto a ser descriptografado
            numCar = textoCif.Length;

            // laco de repeticao para percorrer a string caracter por caracter
            for (int i = 0; i < numCar; i++)
            {
                // pega o codigo ASCII do caracter na posicao 
                num = Convert.ToInt32(textoCif[i]);

                // se o caracter for uma letra efetua a descriptografia
                if (num >= 97 && num <= 122)
                {
                    // efetua o deslocamento, diminuindo o numero de casas
                    num = num - numero_casas;

                    // se ultrapassou o alfabeto (caracteres de 'a' a 'z')
                    if (num < 97)
                    {
                        // retorna pra ultima letra e diminui a quantidade que ultrapassou a primeira letra
                        num = 123 - (97 - num);
                    }
                }
                // se o caracter nao for um numero ou um espaco gera excecao
                else if (!((num >= 48 && num <= 57) || (num == 32)))
                {
                    throw new System.ArgumentOutOfRangeException();
                }

                // adciona a letra descriptografada ao texto
                textoDec += Convert.ToChar(num);
            }
            // retorna a string contendo o texto descriptografado
            return (textoDec);
        }
    }
}
