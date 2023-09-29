using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App.Services;
using Xunit;

namespace Tests.Services
{
    public class ValidacoesStringTests
    {
        private ValidacoesString _string;
        public ValidacoesStringTests()
        {
            _string = new ValidacoesString();
        }

        [Fact]
        public void DeveRetornar6QuantidadeCaracteresDaPalavraMatrix()
        {
            string texto = "Matrix";
            int resultado = _string.RetornarQuantidadeCaracteres(texto);
            Assert.Equal(6, resultado);
        }
        [Fact]
        public void DeveConterAPalavraQualquerNoTexto()
        {
            // Given
            string texto = "Esse é um texto qualquer";
            string textoProcurado = "qualquer";
            // When
            bool resultado = _string.ContemCaractere(texto, textoProcurado);
            // Then
            Assert.True(resultado);
        }

        [Fact]
        public void NaoDeveConterAPalavraNoTexto()
        {
            // Given
            string texto = "Esse é um texto qualquer";
            string textoProcurado = "tests";
            // When
            bool resultado = _string.ContemCaractere(texto, textoProcurado);
            // Then
            Assert.False(resultado);
        }

        [Fact]
        public void TextoDeveTerminarComAPalavraProcurado()
        {
            // Given
            string texto = "Começo, meio e fim do texto procurado";
            string textoFinalizaCom = "procurado";
            // When
            bool resultado = _string.TextoTerminaCom(texto, textoFinalizaCom);
            // Then
            Assert.True(resultado);
        }

        [Fact]
        public void TextoNaoTerminarComAPalavraProcurado()
        {
            // Given
            string texto = "Começo, meio e fim do texto procurado";
            string textoFinalizaCom = "a";
            // When
            bool resultado = _string.TextoTerminaCom(texto, textoFinalizaCom);
            // Then
            Assert.False(resultado);
        }
    }
}