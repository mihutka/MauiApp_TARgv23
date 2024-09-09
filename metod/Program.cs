using System.Security.Cryptography.X509Certificates;

namespace metod
{
    enum Color
    {
        Red,
        Green, 
        Blue,
        Yellow,
        
        

    }
    class Point
    {
         public int x;

         public int y;

         public Color color;

         



    }




    internal class Program
    {
        
        static void Main(string[] args)
        {
            Point p = new Point();

            p = null;

            p.x = 4;
            p.y = 2;
            p.color = Color.Red;

            Console.WriteLine(p.x);
            Console.WriteLine(p.y);
        }
    }
}
