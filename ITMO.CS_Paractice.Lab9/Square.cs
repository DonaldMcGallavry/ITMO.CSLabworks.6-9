using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITMO.CS_Paractice.Lab9
{
     class Square: Shape,InterRotate
    {
        private int side;

        public Square(int x) : base(x)
        {
            this.side = x;
        }

        public override double Perimetr()
        {
            double P = side * 4;
            return P;
        }

        public override double Area()
        {
            double S = side * side;
            return S;
        }
        public void Rotate() //поворот фигуры на 90 градусов
        {
            Console.WriteLine("The Square has been roatated 90 degrees ");
        }

        public void Show()
        {
            Console.WriteLine($"Стороны квадрата равны: {side}\n " +
                $"Периметр равен:{Perimetr()} \nПлощадь равна:{Area()}");
        }
    }
}
