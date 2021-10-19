using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab13
{

    class Program
    {
        static void Main(string[] args)
        {
            MultiBuilding multibuilding = new MultiBuilding("", -1, 0, 0, 0);
            multibuilding.SetParams();
            multibuilding.SetLevel();
            multibuilding.Print();
            Console.ReadKey();
        }
    }
    class Building
    {
        string a { get; set; }
        double l;
        public double L
        {
            set
            {
                if (value > 0)
                {
                    l = value;
                }
                else
                {
                    Console.WriteLine("Введите положительное число");                    
                }                
            }
            get
            {
                return l;
            }
        }
        double b;
        public double B
        {
            set
            {
                if (value > 0)
                {
                    b = value;
                }
                else
                {
                    Console.WriteLine("Введите положительное число");
                }
            }
            get
            {
                return b;
            }
        }
        double h;
        public double H
        {
            set
            {
                if (value > 0)
                {
                    h = value;
                }
                else
                {
                    Console.WriteLine("Введите положительное число");
                }
            }
            get
            {
                return h;
            }
        }

        public Building(string A, double L, double B, double H)
        {
            a = A;
            l = L;
            b = B;
            h = H;
        }
        public void SetParams()
        {
            Console.WriteLine("Введите адрес здания");
            a = Console.ReadLine();
            Console.WriteLine("Введите длину здания");
            L = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите ширину здания");
            B = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите высоту здания");
            H = Convert.ToDouble(Console.ReadLine());
        }
        public void Print()
        {
            Console.WriteLine("Рассматриваемое здание, расположенное по адресу - {0} имеет длину {1}м, ширину {2}м и высоту {3}м", a, l, b, h);
        }
    }
    sealed class MultiBuilding : Building
    {
        int n;
        public int N
        {
            set
            {
                if (value > 0)
                {
                    n = value;
                }
                else
                {
                    Console.WriteLine("Введите положительное число");
                }
            }
            get
            {
                return n;
            }
        }

        public MultiBuilding(string a, double l, double b, double h, int N)
            : base(a, l, b, h)
        {
            N = n;
        }

        public void SetLevel()
        {
            Console.WriteLine("Введите этажность здания");
            N = Convert.ToInt32(Console.ReadLine());
        }
        public void Print(string a, double l, double b, double h)
        {
            Console.WriteLine("Рассматриваемое здание {0}-этажное, расположенное по адресу - {1} имеет длину {2}м, ширину {3}м и высоту {4}м", n, a, l, b, h);
        }
    }
}
