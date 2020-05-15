using System;

namespace Codenation.Challenge
{
    public class CesarCypher : ICrypt, IDecrypt
    {
        public string Crypt(string message)
        {
            // cifra o campo de texto cifrado utilizando o número de casas de deslocamento
            int numCar = 0, num = 0, numero_casas = 3;
            string textoDec = "", textoCif = "";

            if (message == null)
            {
                throw new System.ArgumentNullException();
            }

            if (message == String.Empty)
            {
                return message;
            }

            textoDec = message.ToLower();
            numCar = textoDec.Length;
            for (int i = 0; i < numCar; i++)
            {
                num = Convert.ToInt32(textoDec[i]);
                if (num >= 97 && num <= 122)
                {
                    num = num + numero_casas;
                    if (num > 122)
                    {
                        num = 96 + (num - 122);
                    }
                }
                else if ((num >= 48 && num <= 57) || num == 32)
                {
                    // mantem valor
                }
                else if (num == 0)
                {
                    throw new System.ArgumentNullException();
                }
                else
                {
                    throw new System.ArgumentOutOfRangeException();
                }

                textoCif += Convert.ToChar(num);
            }
            return (textoCif);
        }

        public string Decrypt(string cryptedMessage)
        {
            // decifra o campo de texto cifrado utilizando o número de casas de deslocamento
            int numCar = 0, num = 0, numero_casas = 3;
            string textoDec = "", textoCif = "";

            if (cryptedMessage == null)
            {
                throw new System.ArgumentNullException();
            }

            textoCif = cryptedMessage.ToLower();
            numCar = textoCif.Length;
            for (int i = 0; i < numCar; i++)
            {
                num = Convert.ToInt32(textoCif[i]);
                if (num >= 97 && num <= 122)
                {
                    num = num - numero_casas;
                    if (num < 97)
                    {
                        num = 123 - (97 - num);
                    }
                }
                else if ((num >= 48 && num <= 57) || num == 32)
                {
                    // mantem valor
                }
                else if (num == 0)
                {
                    throw new System.ArgumentNullException();
                }
                else
                {
                    throw new System.ArgumentOutOfRangeException();
                }
                textoDec += Convert.ToChar(num);
            }
            return (textoDec);
        }
    }
}
