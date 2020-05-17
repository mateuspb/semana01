using System;
using Xunit;

namespace Codenation.Challenge
{
    public class CesarCypherTest
    {
        [Fact]
        public void Should_Not_Accept_Null_When_Crypt()
        {            
            var cypher = new CesarCypher();
            Assert.Throws<ArgumentNullException>(() => cypher.Crypt(null));
        }

        [Fact]
        public void Should_Keep_Numbers_Out_When_Crypt()
        {
            var cypher = new CesarCypher();
            Assert.Equal("d1e2f3g4h5i6j7k8l9m0", cypher.Crypt("a1b2c3d4e5f6g7h8i9j0"));
        }

        [Fact]
        public void Teste_Crypt()
        {
            var cypher = new CesarCypher();
            Assert.Equal("whvwh 123 frp hvsdfr abc", cypher.Crypt("teste 123 com espaco xyz"));
        }

        [Fact]
        public void Teste_Decrypt()
        {
            var cypher = new CesarCypher();
            Assert.Equal("teste 123 com espaco xyz", cypher.Decrypt("whvwh 123 frp hvsdfr abc"));
        }

        [Fact]
        public void Teste_Crypt_Maiuscula()
        {
            var cypher = new CesarCypher();
            Assert.Equal("whvwh frp hvsdfr abc", cypher.Crypt("Teste COM espaco XYZ"));
        }

        [Fact]
        public void Teste_Decrypt_Maiuscula()
        {
            var cypher = new CesarCypher();
            Assert.Equal("teste com espaco xyz", cypher.Decrypt("Whvwh FRP hvsdfr ABC"));
        }

        [Fact]
        public void Teste_Crypt_Branco()
        {
            var cypher = new CesarCypher();
            Assert.Equal(" ", cypher.Crypt(" "));
        }

        [Fact]
        public void Teste_Decrypt_Branco()
        {
            var cypher = new CesarCypher();
            Assert.Equal(" ", cypher.Decrypt(" "));
        }

        [Fact]
        public void Teste_Crypt_Erro_Caracter_Invalido()
        {
            var cypher = new CesarCypher();
            Assert.Throws<ArgumentOutOfRangeException>(() => cypher.Crypt("Teste COM ç"));
        }
    }
}
