using DevelopmentChallenge.Data.Interfaces;
using System.Collections.Generic;

namespace DevelopmentChallenge.Data.Classes
{
    public class Italiano : _baseIdioma, IIdioma
    {
        public override string errorNotFound { get; set; } = "Parola non trovata nel dizionario";
        public override Dictionary<string, string> diccionario { get; set; } = new Dictionary<string, string>()
        {
            ["Area"] = "Area",
            ["Perimetro"] = "Perimetro",
            ["Lista Vacia"] = "Elenco vuoto di forme",

            ["Reporte de Formas"] = "Rapporto sui forme",
            ["Total"] = "TOTALE",

            ["Formas"] = "forme",
            ["Cuadrado"] = "Piazza",
            ["Cuadrados"] = "Piazze",

            ["Circulo"] = "Cerchio",
            ["Circulos"] = "Cerchi",

            ["Triangulo"] = "Triangolo",
            ["Triangulos"] = "Triangoli",

            ["Trapecio"] = "Trapezio",
            ["Trapecios"] = "Trapezi",

            ["Rectangulo"] = "Rettangolo",
            ["Rectangulos"] = "Rettangoli"
        };

    }
}
