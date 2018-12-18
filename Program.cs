using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int bim;
            double perimeter;
            Console.WriteLine("Donner la longueur d'un rayon d'un cercle");
            bim = int.Parse(Console.ReadLine());
            perimeter = 2 * bim * Math.PI;
            double area;
            area = bim * bim * Math.PI;
            Console.WriteLine("le périmetre du cercle est de " +perimeter + Environment.NewLine + "et son aire est de " + area);
        }
    }
}
