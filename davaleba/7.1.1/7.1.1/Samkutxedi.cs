using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._1._1
{
    class Samkutxedi
    {
        protected int side_X;
        protected int side_Y;
        protected int side_Z;
    }
    class Memkvidre:Samkutxedi
    {
        int perimetri;

        public Memkvidre(int side_x,int side_y,int side_z)
        {
            side_X = side_x;
            side_Y = side_y;
            side_Z = side_z;
        }
        public int Fartobi()
        {
            return (side_X * side_Y)/2;
        }
        public int Perimetri()
        {
            perimetri = side_X + side_Y + side_Z;
            return perimetri;
        }
    }
    
}
