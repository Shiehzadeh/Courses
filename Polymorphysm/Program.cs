using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphysm
{
    class Program
    {
        #region public  variable
        static int rWidth;
        static int rLength;
        static int sSide;
        static double cRadius;
        #endregion
        static void Main(string[] args)
        {
            GetInput();
            Initial();
            Console.ReadKey();
        }
        /// <summary>
        /// گرفتن اطلاعات از کاربر
        /// </summary>
        static void GetInput()
        {
            Console.Write("please enter Rectangle Width: ");
            rWidth = Convert.ToInt32(Console.ReadLine());
            Console.Write("please enter Rectangle Length: ");
            rLength = Convert.ToInt32(Console.ReadLine());
            Console.Write("please enter Square Side: ");
            sSide = Convert.ToInt32(Console.ReadLine());
            Console.Write("please enter Circle Radius: ");
            cRadius = Convert.ToInt32(Console.ReadLine());
        }
        /// <summary>
        /// تجزیه تحلیل و محاسبه محیط و مساحت اشکال
        /// </summary>
        static void Initial()
        {
            Rectangle r = new Rectangle(rWidth, rLength);
            Squar s = new Squar(sSide);
            Circle c = new Circle(cRadius);
            double rA =r.Area();
            double rE = r.Environment();
            double sA = s.Area();
            double sE = r.Environment();
            double cA = s.Area();
            double cE = r.Environment();
            Console.WriteLine($"Rectangle area is:{rA}");
            Console.WriteLine($"Rectangle Environment is:{rE}");
            Console.WriteLine($"Squar area is:{sA}");
            Console.WriteLine($"Squar Environment is:{sE}");
            Console.WriteLine($"Circle area is:{cA}");
            Console.WriteLine($"Circle Environment is:{cE}");


        }
    }
}
