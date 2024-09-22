using System.Xml.Linq;

namespace ITMO.CS_Practice._7lab
{
    public class Book : IComparable
    {
        private string Author;
        private string Name;
        private int Year;
        private int Pages;


        

        public void SetBook (String author, String name, int year, int pages)
        {
            this.Author = author;
            this.Name = name;
            this.Year = year;
            this.Pages = pages;
        }
        public void Show ()
        {
            Console.WriteLine ("\n Author: {0}  \n Name: {1} \n Year: {2} \n Pages: {3}", Author, Name, Year, Pages);
        }
        public int CompareTo(object obj)
        {
            Book it = (Book)obj;
            if (this.Year == it.Year) return 0;
            else if (this.Year > it.Year) return 1;
            else return -1;
        }
    }
    internal class Program
    {
        static void Main()
        {
            Book[] BookList = new Book[3];
            BookList[0] = new Book();
            BookList[0].SetBook("J.J.Abbrams", "Dont_Forget_The_Name", 1978, 197);
            BookList[1] = new Book();
            BookList[1].SetBook("J.R.R. Tolkien", "The Lord OF the Rings", 1937, 1077);
            BookList[2] = new Book();
            BookList[2].SetBook("L. Tolstoy", "War and Peace", 1867, 1225);

          Array.Sort(BookList);
          
            foreach (Book book in BookList)
            {
                book.Show();
                
            }
        }
    }
}
