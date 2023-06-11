using DevelopmentChallenge.Data.Interfaces;
using System;

namespace DevelopmentChallenge.Data.Classes.Formas
{
    public class Trapecio : IFormaGeometrica
    {
        
        public decimal lado { get; set; }
        public decimal base1 { get; set; }
        public decimal base2 { get; set; }
        public decimal altura { get; set; }
        public FormaTipo Tipo { get; set; }

        public Trapecio(decimal base1, decimal base2, decimal altura)
        {
            this.base1 = base1;
            this.base2 = base2;
            this.altura = altura;

            var b = altura;
            var c = Math.Abs(base1 - base2) / 2;
            this.lado = (decimal)Math.Sqrt((double)(b * b) + (double)(c * c));
            Tipo = FormaTipo.Trapecio;
        }

        public decimal CalcularArea()
        {
            return ((base1 + base2 ) / 2 ) * altura;
        }

        public decimal CalcularPerimetro()
        {
            return (lado * 2) + base1 + base2;
        }
    }
}
