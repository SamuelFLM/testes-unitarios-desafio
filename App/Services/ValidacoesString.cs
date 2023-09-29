using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App.Services
{
    public class ValidacoesString
    {
        public int RetornarQuantidadeCaracteres(string texto)
        {
            return texto.Length;
        }

        public bool ContemCaractere(string texto, string textoProcurado)
        {
            bool contem = texto.Contains(textoProcurado);
            return contem;
        }
        public bool TextoTerminaCom(string texto, string textoProcurado){
            bool contem = texto.EndsWith(textoProcurado);
            return contem;
        }
    }
}