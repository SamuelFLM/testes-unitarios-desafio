using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;

namespace App.Services
{
    public class ValidacoesLista
    {
        public List<int> RemoverNumerosNegativos(List<int> lista)
        {
            var listaSemNegativos = lista.Where(x => x > 0).ToList();
            return listaSemNegativos;
        }
        public bool ListaContemDeterminadoNumero(List<int> lista, int numero)
        {
            bool resultado = lista.Contains(numero);
            return resultado;
        }

        public List<int> MultiplicaNumerosLista(List<int> lista, int numero)
        {
            var listaMultiplicada = lista.Select(x => x * numero).ToList();
            return listaMultiplicada;
        }

        public int RetornarMaiorNumeroLista(List<int> numeros)
        {
            return numeros.Max();
        }
        public int RetornarMenorNumeroLista(List<int> numeros)
        {
            return numeros.Min();
        }

    }
}