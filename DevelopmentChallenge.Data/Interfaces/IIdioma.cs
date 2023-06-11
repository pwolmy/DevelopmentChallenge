using System.Collections.Generic;

namespace DevelopmentChallenge.Data.Interfaces
{
    public interface IIdioma
    {
        Dictionary<string, string> diccionario { get; set; }

        string Traducir(string palabra);
    }
}
