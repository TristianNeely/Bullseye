using System;

namespace Bullseye
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("bruh");
            Console.WriteLine("Jamagiae");
            Console.WriteLine("Test 2");
            
            public int randomX = random.Next(100);
            public int randomY = random.Next(100);
        }
       


        public void CreateDot() 
        {


        }
       public void AddPoint(PaintEventArgs e)
        {
         Point point1 = new Point(randomX, randomY);
         Point point2 = Point.Add(point1, new Size(randomX,randomY));
         e.Graphics.DrawLine(Pens.Red, point1, point2);
        }

    }
}
