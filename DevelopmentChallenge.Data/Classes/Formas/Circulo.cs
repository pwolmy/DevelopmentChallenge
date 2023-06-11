using DevelopmentChallenge.Data.Interfaces;
using System;

namespace DevelopmentChallenge.Data.Classes.Formas
{
    public class Circulo : IFormaGeometrica
    {
        public decimal lado { get; set;} 
        public FormaTipo Tipo { get; set; }

        public Circulo(decimal lado)
        {
            this.lado = lado;
            Tipo = FormaTipo.Circulo;
        }

        public decimal CalcularArea()
        {
            return (decimal)Math.PI * (lado / 2) * (lado / 2);
        }

        public decimal CalcularPerimetro()
        {
            return (decimal)Math.PI * lado;
        }
    }
}
