using DevelopmentChallenge.Data.Interfaces;
using System.Collections.Generic;

namespace DevelopmentChallenge.Data.Classes
{
    public abstract class _baseIdioma : IIdioma
    {
        public virtual string errorNotFound { get; set; } = "Palabra no encontrada en diccionario";

        public virtual Dictionary<string, string> diccionario { get; set; } = new Dictionary<string, string>()
        {
            ["Area"] = "Area",
            ["Perimetro"] = "Perimetro",
            ["Lista Vacia"] = "Lista vacía de formas",

            ["Reporte de Formas"] = "Reporte de Formas",
            ["Total"] = "TOTAL",

            ["Formas"] = "formas",
            ["Cuadrado"] = "Cuadrado",
            ["Cuadrados"] = "Cuadrados",

            ["Circulo"] = "Círculo",
            ["Circulos"] = "Círculos",

            ["Triangulo"] = "Triángulo",
            ["Triangulos"] = "Triángulos",

            ["Trapecio"] = "Trapecio",
            ["Trapecios"] = "Trapecios",

            ["Rectangulo"] = "Rectángulo",
            ["Rectangulos"] = "Rectángulos"
        };

        public virtual string Traducir(string palabra)
        {
            return (diccionario.ContainsKey(palabra) ? diccionario[palabra] : "Error: " + errorNotFound);
        }
    }
}
