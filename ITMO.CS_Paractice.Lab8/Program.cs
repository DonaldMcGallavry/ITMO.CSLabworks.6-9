namespace Lab06
{
    class Triangle
    {
        private int side1, side2, side3;
        public static double TrPer(int x, int y, int z)
        {

            double P = 0;
            bool ok = true;
            ok = Triangle.TrExist(x, y, z);
            if (ok)
            {
                P = x + y + z;
            }
            else
                P = 0;
            return P;
        }
        public static double TrSqua(int x, int y, int z)
        {
            double P = Triangle.TrPer(x, y, z);

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
        public static void TrShow(int x, int y, int z)
        {
            Console.WriteLine("Сторона x = {0}, Сторона y ={1}, Сторона z = {2}", x, y, z);

        }
        public static bool TrExist(in int x, in int y, in int z)
        {
            bool ok = true;
            if (x + y <= z || x + z <= y || y + z <= x)
                ok = false;
            else if (x < 0 || y < 0 || z < 0)
                ok = false;
            else ok = true;
            return ok;
        }

        //Конструктор для создания треугольика с заданными сторонами
        public Triangle (int x, int y, int z)
        {
            side1 = x;
            side2 = y;
            side3 = z;
        }

        // конструктор для создания равностороннего треугольника
        public Triangle(int x)
        {
            side1 = x;
            side2 = x;
            side3 = x;
        }

        public void Write ()
        {
            Console.WriteLine($"Side x: {side1} \nSide y: {side2} \nSide z: {side3}");
        }
    }
    internal class Program
    {


        static void Main()
        {
          //  int x = int.Parse(Console.ReadLine());
          //  int y = int.Parse(Console.ReadLine());
          //  int z = int.Parse(Console.ReadLine());

          //  Triangle.TrShow(x, y, z);
          //  Console.WriteLine("периметр = {0}, площадь = {1}", Triangle.TrSqua(x, y, z), Triangle.TrPer(x, y, z));

            Triangle tr1, tr2;
            tr1 = new Triangle(8, 10, 12);
            tr2 = new Triangle(5);

            tr1.Write();
            tr2.Write();
        }
    }
}
