using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITMO.CS_Paractice.Lab9
{
     class Circle: Shape
    {
        private int R;

        public Circle(int x) : base(x)
        {
            this.R = x;
        }
        public override double Perimetr()
        {
            double P = 2*Math.PI*R;
            return P;
        }

        public override double Area()
        {
            double S = Math.PI * R * R;
            return S;
        }
        public void Show()
        {
            Console.WriteLine($"Радиус окружности равен: {R}\n" +
                $"Периметр равен:{Perimetr()}" + "\n" + $"Площадь равна:{Area()}" + "\n");
           
        }
    }
}
