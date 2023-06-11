using DevelopmentChallenge.Data.Interfaces;
using System;

namespace DevelopmentChallenge.Data.Classes.Formas
{
    public class TrianguloEquilatero : IFormaGeometrica
    {
        public decimal lado { get; set; }
        public FormaTipo Tipo { get; set; }

        public TrianguloEquilatero(decimal lado)
        {
            this.lado = lado;
            Tipo = FormaTipo.Triangulo;
        }

        public decimal CalcularArea()
        {
            return ((decimal)Math.Sqrt(3) / 4) * lado * lado;
        }

        public decimal CalcularPerimetro()
        {
            return lado * 3;
        }
    }
}
