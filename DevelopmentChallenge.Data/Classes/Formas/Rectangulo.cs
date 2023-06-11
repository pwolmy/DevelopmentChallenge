using DevelopmentChallenge.Data.Interfaces;

namespace DevelopmentChallenge.Data.Classes.Formas
{
    public class Rectangulo : IFormaGeometrica
    {

        public decimal lado { get; set; }
        public decimal lado2{ get; set; }
        public FormaTipo Tipo { get; set; }

        public Rectangulo(decimal lado1, decimal lado2)
        {
            this.lado = lado1;
            this.lado2 = lado2;
            Tipo = FormaTipo.Rectangulo;
        }

        public decimal CalcularArea()
        {
            return lado * lado2;
        }

        public decimal CalcularPerimetro()
        {
            return (lado * 2) + (lado2 * 2);
        }
    }
}
