using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitap02
{
    public class Rational
    {
        private readonly long numerator;   
        private readonly long denominator; 

        public Rational(int numerator, int denominator)
        {
            if (denominator == 0)
            {
                throw new ArgumentException("Mẫu số không thể bằng 0.");
            }

            long gcd = Gcd(numerator, denominator);
            this.numerator = numerator / gcd;
            this.denominator = denominator / gcd;

            if (this.denominator < 0)
            {
                this.numerator = -this.numerator;
                this.denominator = -this.denominator;
            }
        }

        public Rational Plus(Rational b)
        {
            long newNumerator = this.numerator * b.denominator + b.numerator * this.denominator;
            long newDenominator = this.denominator * b.denominator;
            return new Rational((int)newNumerator, (int)newDenominator);
        }

        public Rational Minus(Rational b)
        {
            long newNumerator = this.numerator * b.denominator - b.numerator * this.denominator;
            long newDenominator = this.denominator * b.denominator;
            return new Rational((int)newNumerator, (int)newDenominator);
        }

        public Rational Times(Rational b)
        {
            long newNumerator = this.numerator * b.numerator;
            long newDenominator = this.denominator * b.denominator;
            return new Rational((int)newNumerator, (int)newDenominator);
        }

        public Rational Divides(Rational b)
        {
            if (b.numerator == 0)
            {
                throw new ArithmeticException("Không thể chia cho 0.");
            }
            long newNumerator = this.numerator * b.denominator;
            long newDenominator = this.denominator * b.numerator;
            return new Rational((int)newNumerator, (int)newDenominator);
        }

        public bool Equals(Rational that)
        {
            return this.numerator == that.numerator && this.denominator == that.denominator;
        }

        public override string ToString()
        {
            if (denominator == 1)
            {
                return numerator.ToString(); 
            }
            return numerator + "/" + denominator; 
        }

        private long Gcd(long a, long b)
        {
            if (b == 0) return Math.Abs(a);
            return Gcd(b, a % b);
        }

        public static void run16()
        {
            Rational r1 = new Rational(1, 2); 
            Rational r2 = new Rational(2, 3); 

            Console.WriteLine("r1 = " + r1);
            Console.WriteLine("r2 = " + r2);

            Console.WriteLine("r1 + r2 = " + r1.Plus(r2));
            Console.WriteLine("r1 - r2 = " + r1.Minus(r2));
            Console.WriteLine("r1 * r2 = " + r1.Times(r2));
            Console.WriteLine("r1 / r2 = " + r1.Divides(r2));
            Console.WriteLine("r1 equals r2? " + r1.Equals(r2));

            Rational r3 = new Rational(4, 8); 
            Console.WriteLine("r3 = " + r3);
            Console.WriteLine("r1 equals r3? " + r1.Equals(r3));
        }
    }
}
