using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Side x: ");
            int side_x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Side y: ");
            int side_y = Convert.ToInt32(Console.ReadLine());
            Console.Write("Side z: ");
            int side_z = Convert.ToInt32(Console.ReadLine());

            Memkvidre memkvidre = new Memkvidre(side_x, side_y, side_z);

            int shedegi1 = memkvidre.Fartobi();
            int shedegi2 = memkvidre.Perimetri();

            Console.WriteLine($"\nSamkutxedis fartobi: {shedegi1}\nSamkutxedis perimetri: {shedegi2}");
            Console.ReadKey();
        }
    }
}
