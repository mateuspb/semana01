using System;

namespace Codenation.Challenge
{
    public class CesarCypher : ICrypt, IDecrypt
    {
        // funcao que efetua a criptografia de uma string
        // cifra o campo de texto utilizando o número de casas de deslocamento
        public string Crypt(string message)
        {
            return Converte(message, 3);
        }

        // funcao que efetua a descriptografia de uma string
        // decifra o campo de texto cifrado utilizando o número de casas de deslocamento
        public string Decrypt(string cryptedMessage)
        {
            return Converte(cryptedMessage, -3);
        }

        // funcao que efetua a criptografia ou descriptografia de um texto utilizando o deslocamento    
        public string Converte(string texto, int deslocamento)
        {
            // validacoes
            if (texto == null) throw new System.ArgumentNullException();
            if (texto == String.Empty) return texto;

            // declaracao de variaveis
            int caracter = 0;
            string saida = String.Empty;

            texto = texto.ToLower();
            
            // laco de repeticao para percorrer a string caracter por caracter
            for (int i = 0; i < texto.Length ; i++)
            {
                // pega o codigo ASCII do caracter na posicao 
                caracter = Convert.ToInt32(texto[i]);

                // se o caracter for uma letra efetua a criptografia
                if (caracter >= 97 && caracter <= 122)
                {
                    // efetua o deslocamento
                    caracter = caracter + deslocamento;

                    // se ultrapassou o alfabeto (caracteres de 'a' a 'z')
                    if (caracter > 122)
                    {
                        caracter = caracter - 26;
                    }
                    else if (caracter < 97)
                    {
                        caracter = caracter + 26;
                    }
                }
                // se o caracter nao for um numero ou um espaco gera excecao
                else if (!((caracter >= 48 && caracter <= 57) || (caracter == 32)))
                {
                    throw new System.ArgumentOutOfRangeException();
                }

                // adciona a letra criptografada ao texto
                saida += Convert.ToChar(caracter);
            }
            return saida;
        }
    }
}
