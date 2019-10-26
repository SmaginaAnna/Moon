using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace калькулятор_рац_чисел
{
    class Rational
    {
        private int chisl;
        private int znam;


        public Rational(int chislitel, int znaminatel)
        {
            this.chisl = chislitel;
            this.znam = znaminatel;

        }
        public static Rational operator *(Rational r1, Rational r2)
        {
            return new Rational(r1.chisl * r2.chisl, r1.znam * r2.znam);
        }


        public static Rational operator /(Rational r1, Rational r2)
        {
            return new Rational(r1.chisl * r2.znam, r2.chisl * r1.znam);
        }

        public static Rational operator +(Rational r1, Rational r2)
        {
            return new Rational(r1.chisl * r2.znam + r2.chisl * r1.znam, r1.znam * r2.znam);
        }

        public static Rational operator -(Rational r1, Rational r2)
        {
            return new Rational(r1.chisl * r2.znam - r2.chisl * r1.znam, r1.znam * r2.znam);
        }



        public static void Reduction(ref Rational r)
        {
            int r1 = r.chisl;
            int r2 = r.znam;
            while (r2 != 0)
            {
                r2 = r1 % (r1 = r2);
            }

            r.chisl = r.chisl / r1;
            r.znam = r.znam / r1;

        }

        public static string ToString(Rational r3)
        {
            string result = Convert.ToString(r3.chisl) + "/" + Convert.ToString(r3.znam);
            return result;
        }

    }
}
