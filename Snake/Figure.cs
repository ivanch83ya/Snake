using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Figure
    {
        protected List<Point> pList;

        //Virtual class - любой его класс-наследник, может переопределить этот метод
        //и использовать свою реализацию класса Draw()
        public virtual void Draw()
        {
            foreach (Point p in pList)
            { 
                p.Draw();
            }
        }
    }
}
