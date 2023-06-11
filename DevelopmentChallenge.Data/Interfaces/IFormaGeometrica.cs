namespace DevelopmentChallenge.Data.Interfaces
{
    public enum FormaTipo
    {
        Cuadrado,
        Circulo,
        Triangulo,
        Trapecio,
        Rectangulo
    }   

    public interface IFormaGeometrica
    {
        decimal lado { get; set; }
        FormaTipo Tipo { get; set; }

        decimal CalcularArea();
        decimal CalcularPerimetro();
    }
}
