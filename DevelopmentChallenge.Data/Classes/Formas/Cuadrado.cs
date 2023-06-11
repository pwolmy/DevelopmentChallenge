using DevelopmentChallenge.Data.Interfaces;

namespace DevelopmentChallenge.Data.Classes.Formas
{
    public class Cuadrado : IFormaGeometrica
    {
        public decimal lado { get; set; }
        public FormaTipo Tipo { get; set; }
        
        public Cuadrado(decimal lado)
        {
            this.lado = lado;
            Tipo = FormaTipo.Cuadrado;
        }

        public decimal CalcularArea()
        {
            return lado * lado;
        }

        public decimal CalcularPerimetro()
        {
            return lado * 4;
        }
    }
}
