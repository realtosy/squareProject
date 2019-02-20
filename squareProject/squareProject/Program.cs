using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace squareProject
{
  class Program
  {
    static void Main(string[] args)
    {
      double a, b, h, r, S, pi = Math.PI;
      string figureNumber;
      Console.WriteLine("Площадь какой фигуры вы хотите посчитать? ");
      Console.WriteLine("\n1. Треугольник\n2. Прямоугольник\n3. Круг");
      figureNumber = Console.ReadLine();
      switch (figureNumber)
      {
        case "1":
          Console.WriteLine("\nВведите сторону и высоту треугольника\nСторона ");
          a = Convert.ToDouble(Console.ReadLine());
          Console.WriteLine("\nВысота ");
          h = Convert.ToDouble(Console.ReadLine());
          S = h * a * 0.5;
          Console.WriteLine($"Площадь равна {S}");
          break;
        case "2":
          Console.WriteLine("\nВведите стороны прямоугольника ");
          a = Convert.ToDouble(Console.ReadLine());
          b = Convert.ToDouble(Console.ReadLine());
          S = b * a;
          Console.WriteLine($"Площадь равна {S}");
          break;
        case "3":
          Console.WriteLine("\nВведите радиус круга ");
          r = Convert.ToDouble(Console.ReadLine());
          S = Math.Round(pi * r * r, 2);
          Console.WriteLine($"Площадь равна {S}");
          break;
        default:
          Console.WriteLine("\nТакого пункта нет");
          break;
      }
      Console.ReadKey(true);
    }
  }
}
