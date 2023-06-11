using DevelopmentChallenge.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DevelopmentChallenge.Data.Classes
{
    public class FormaGeometrica
    {

        public static string Imprimir(List<IFormaGeometrica> _formas, IIdioma _idioma)
        {
            var sb = new StringBuilder();

            if (!_formas.Any())
            {
                sb.Append($"<h1>{_idioma.Traducir("Lista Vacia")}!</h1>");
            }
            else
            {
                // Hay por lo menos una forma
                // HEADER
                sb.Append($"<h1>{_idioma.Traducir("Reporte de Formas")}</h1>");

                int countTypes = Enum.GetValues(typeof(FormaTipo)).Length;
                int[] numero = new int[countTypes];
                decimal[] area = new decimal[countTypes];
                decimal[] perimetro = new decimal[countTypes];
                for (var i = 0; i < _formas.Count; i++)
                {
                    int index = (int)_formas[i].Tipo;
                    numero[index]++;
                    area[(int)_formas[i].Tipo] += _formas[i].CalcularArea();
                    perimetro[(int)_formas[i].Tipo] += _formas[i].CalcularPerimetro();
                }

                int numeros = 0;
                decimal areas = 0;
                decimal perimetros = 0;
                for (var i = 0; i < countTypes; i++)
                {
                    sb.Append(ObtenerLinea(numero[i], area[i], perimetro[i], (FormaTipo)i, _idioma));
                    numeros += numero[i];
                    areas += area[i];
                    perimetros += perimetro[i];
                }

                // FOOTER
                sb.Append($"{_idioma.Traducir("Total")}:<br/>");
                sb.Append(numeros + " " + _idioma.Traducir("Formas") + " ");
                sb.Append(_idioma.Traducir("Perimetro") + " " + (perimetros).ToString("#.##") + " ");
                sb.Append(_idioma.Traducir("Area") + " " + (areas).ToString("#.##"));
            }

            return sb.ToString();
        }

        private static string ObtenerLinea(int cantidad, decimal area, decimal perimetro, FormaTipo tipo, IIdioma _idioma)
        {
            if (cantidad > 0)
            {
                return $"{cantidad} {TraducirForma(tipo, cantidad, _idioma)} | {_idioma.Traducir("Area")} {area:#.##} | {_idioma.Traducir("Perimetro")} {perimetro:#.##} <br/>";
            }

            return string.Empty;
        }

        private static string TraducirForma(FormaTipo tipo, int cantidad, IIdioma _idioma)
        {
            return _idioma.Traducir(tipo.ToString() + (cantidad > 1 ? "s" : ""));
        }
    }
}
