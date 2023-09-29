using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App.Services;
using Xunit;

namespace Tests.Services
{
    public class ValidacoesListaTests
    {
        private ValidacoesLista _lista;
        public ValidacoesListaTests()
        {
            _lista = new ValidacoesLista();
        }

        [Fact]
        public void DeveRemoverNumerosNegativosDeUmaLista()
        {
            var valoresTests = new List<int> { -1, 2, -3, 4 };
            var resultadoEsperado = new List<int> { 2, 4 };
            // When
            var listaNumerosPositivos = _lista.RemoverNumerosNegativos(valoresTests).ToList();
            // Then
            Assert.Equal(resultadoEsperado, listaNumerosPositivos);
        }
        [Fact]
        public void DeveConterONumero9NaLista()
        {
            int numero = 9;
            var lista = new List<int> { 1, 2, 3, 4, 9 };
            // When
            bool contem = _lista.ListaContemDeterminadoNumero(lista, numero);
            // Then
            Assert.True(contem);
        }

        [Fact]
        public void NaoDeveConterONumero10NaLista()
        {
            int num = 10;
            var lista = new List<int> { 1, 2, 3 };
            // When
            bool contem = _lista.ListaContemDeterminadoNumero(lista, num);
            // Then
            Assert.False(contem);
        }
        [Fact]
        public void DeveMultiplicarOsElementosDaListaPor2()
        {
            // Given
            var lista = new List<int> { 2, 4, 6 };
            int multiplicador = 2;
            var resultadoEsperado = new List<int> { 4, 8, 12 };
            // When
            var resultado = _lista.MultiplicaNumerosLista(lista, multiplicador);
            // Then
            Assert.Equal(resultadoEsperado, resultado);
        }
        [Fact]
        public void DeveRetornaO9ComoMaiorNumeroDaLista()
        {
            // Given
            var lista = new List<int> { 2, 3, 4, 9 };
            int maiorValor = lista.Max();
            // When
            var resultado = _lista.RetornarMaiorNumeroLista(lista);
            // Then
            Assert.Equal(maiorValor, resultado);
        }

        [Fact]
        public void DeveRetornarOitoNegativoComoMenorNumeroDaLista()
        {
            // Given
            var lista = new List<int> { -8, -2, -1, 0, 2 };
            int menorNumero = lista.Min();
            // When
            var resultado = _lista.RetornarMenorNumeroLista(lista);
            // Then
            Assert.Equal(menorNumero, resultado);
        }
    }
}