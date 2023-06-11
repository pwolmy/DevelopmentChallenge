using DevelopmentChallenge.Data.Interfaces;
using System.Collections.Generic;

namespace DevelopmentChallenge.Data.Classes
{
    public class Ingles : _baseIdioma, IIdioma
    {
        public override string errorNotFound { get; set; } = "Word not found in dictionary";
        public override Dictionary<string, string> diccionario { get; set; } = new Dictionary<string, string>()
        {
            ["Area"] = "Area",
            ["Perimetro"] = "Perimeter",
            ["Lista Vacia"] = "Empty list of shapes",

            ["Reporte de Formas"] = "Shapes report",
            ["Total"] = "TOTAL",

            ["Formas"] = "shapes",
            ["Cuadrado"] = "Square",
            ["Cuadrados"] = "Squares",

            ["Circulo"] = "Circle",
            ["Circulos"] = "Circles",

            ["Triangulo"] = "Triangle",
            ["Triangulos"] = "Triangles",

            ["Trapecio"] = "Trapezium",
            ["Trapecios"] = "Trapezoids",

            ["Rectangulo"] = "Rectangle",
            ["Rectangulos"] = "Rectangles"
        };

    }
}
