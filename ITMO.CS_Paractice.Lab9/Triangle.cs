using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITMO.CS_Paractice.Lab9
{
     class Triangle:Shape,InterRotate
    {
        private int side1, side2, side3;

        //Конструктор для создания треугольика с заданными сторонами
        public Triangle(int x, int y, int z) : base(x, y, z)
        {
            this.side1 = x;
            this.side2 = y;
            this.side3 = z;
        }

        // конструктор для создания равностороннего треугольника
        public Triangle(int x) : base(x) 
        {
            this.side1 = x;
            this.side2 = x;
            this.side3 = x;
        }
        public override double Perimetr()
        {
            int x = side1;
            int y = side2;
            int z = side3;
            double P = 0;
            
            bool ok = Triangle.TrExist(x, y, z);
            if (ok)
            {
                P = x + y + z;
            }
            else
                P = 0;
            return P;
        }
        public override double Area()
        {
            int x = side1;
            int y = side2;
            int z = side3;
            double P = Perimetr();

            double Phalf = P / 2;
            double S = 0;
            bool ok = true;
            ok = Triangle.TrExist(x, y, z);
            if (ok)
            {
                S = (Phalf * (Phalf - x) * (Phalf - y) * (Phalf - z));

            }
            else
                S = 0;
            return S;
        }
       
        public static bool TrExist(int x, int y, int z)
        {
            bool ok = true;
            if (x + y <= z || x + z <= y || y + z <= x)
                ok = false;
            else if (x < 0 || y < 0 || z < 0)
                ok = false;
            else ok = true;
            return ok;
        }
        new public void Show()
        {
            Console.WriteLine($"Side x: {side1} \nSide y: {side2} \nSide z: {side3}\n" 
                + $"Периметр равен:{Perimetr()}" + "\n" + $"Площадь равна:{Area()}");
           
        }
        public void Rotate() //поворот фигуры на 90 градусов
        {
            Console.WriteLine("The Triangle has been roatated 90 degrees" + "\n");
        }
    }
}

