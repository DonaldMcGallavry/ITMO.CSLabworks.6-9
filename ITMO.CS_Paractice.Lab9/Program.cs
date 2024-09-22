namespace ITMO.CS_Paractice.Lab9
{
    
        
        
            
        internal class Program
        {


            static void Main()
            {
                //  int x = int.Parse(Console.ReadLine());
                //  int y = int.Parse(Console.ReadLine());
                //  int z = int.Parse(Console.ReadLine());

                //  Triangle.TrShow(x, y, z);
                //  Console.WriteLine("периметр = {0}, площадь = {1}", Triangle.Area(x, y, z), Triangle.Perimetr(x, y, z));

                Triangle tr1, tr2;
                tr1 = new Triangle(8, 10, 12);
                tr1.Show();
                tr1.Rotate();
                tr2 = new Triangle(5);
                tr2.Show();
                tr2.Rotate();


            Circle c1 = new Circle(5);
            c1.Show();

            Square s1 = new Square(18);
            s1.Show();
            s1.Rotate();
        }
        }
   

}
