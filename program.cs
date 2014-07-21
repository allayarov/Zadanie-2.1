using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_21
{
    public class Line
    {
        int[,] _priamaia;
        public int _k;
        int _b;
        public int c;

        public Line(int k, int b)
        {
            _k = k;
            _b = b;
            c = b;
            _priamaia = new int[k, b];
        }
        public void parallel(int k)
        {
            if (_k == 0)
                Console.WriteLine("Прямая параллельна оси абсцис");
            else
                Console.WriteLine("Прямая не параллельна оси абсцис");
        }
        public void npriamaia(int k)
        {
            if (_k != 0)
                Console.WriteLine("Прямая перпендекулярная данной и проходящая через начало координат: y=-" + (k) + "x");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Угловой коэффициент прямой : k=");
            int k = int.Parse(Console.ReadLine());
            Console.Write("Свободный коэффициент прямой : b=");
            int b = int.Parse(Console.ReadLine());
            Line priamaia = new Line(k, b);
            priamaia.parallel(k);
            priamaia.npriamaia(k);
            Console.ReadKey();
        }
    }
}
