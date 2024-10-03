using System;
using System.Diagnostics;
using System.Numerics;

namespace Baitap02
{
    internal class RationalWithBigInteger
    {
        private readonly BigInteger numerator;   
        private readonly BigInteger denominator; 

        public RationalWithBigInteger(BigInteger numerator, BigInteger denominator)
        {
            Debug.Assert(denominator != 0, "Mẫu số không thể bằng 0."); 

            BigInteger gcd = Gcd(numerator, denominator);
            this.numerator = numerator / (BigInteger)gcd; 
            this.denominator = denominator / (BigInteger)gcd; 

            if (this.denominator < 0)
            {
                this.numerator = -this.numerator;
                this.denominator = -this.denominator;
            }
        }

        public RationalWithBigInteger Plus(RationalWithBigInteger b)
        {
            BigInteger newNumerator = this.numerator * b.denominator + b.numerator * this.denominator;
            BigInteger newDenominator = this.denominator * b.denominator;
            return new RationalWithBigInteger((int)newNumerator, (int)newDenominator);
        }

        public RationalWithBigInteger Minus(RationalWithBigInteger b)
        {
            BigInteger newNumerator = this.numerator * b.denominator - b.numerator * this.denominator;
            BigInteger newDenominator = this.denominator * b.denominator;
            return new RationalWithBigInteger((int)newNumerator, (int)newDenominator);
        }

        public RationalWithBigInteger Times(RationalWithBigInteger b)
        {
            BigInteger newNumerator = this.numerator * b.numerator;
            BigInteger newDenominator = this.denominator * b.denominator;
            return new RationalWithBigInteger((int)newNumerator, (int)newDenominator);
        }

        public RationalWithBigInteger Divides(RationalWithBigInteger b)
        {
            Debug.Assert(b.numerator != 0, "Không thể chia cho 0."); 
            BigInteger newNumerator = this.numerator * b.denominator;
            BigInteger newDenominator = this.denominator * b.numerator;
            return new RationalWithBigInteger((int)newNumerator, (int)newDenominator);
        }

        public bool Equals(RationalWithBigInteger that)
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

        private BigInteger Gcd(BigInteger a, BigInteger b)
        {
            if (b == 0) return BigInteger.Abs(a);
            return Gcd(b, a % b);
        }

        public static void run17()
        {
            RationalWithBigInteger r1 = new RationalWithBigInteger(1, 2); 
            RationalWithBigInteger r2 = new RationalWithBigInteger(2, 3); 

            Console.WriteLine("r1 = " + r1);
            Console.WriteLine("r2 = " + r2);

            Console.WriteLine("r1 + r2 = " + r1.Plus(r2));
            Console.WriteLine("r1 - r2 = " + r1.Minus(r2));
            Console.WriteLine("r1 * r2 = " + r1.Times(r2));
            Console.WriteLine("r1 / r2 = " + r1.Divides(r2));
            Console.WriteLine("r1 equals r2? " + r1.Equals(r2));

            RationalWithBigInteger r3 = new RationalWithBigInteger(
                BigInteger.Parse("2382456823862836458234763456345634564567"),
                BigInteger.Parse("345734573456745674567456745674574567")
            );
            Console.WriteLine("r3 = " + r3);
            Console.WriteLine("r1 equals r3? " + r1.Equals(r3));
        }
    }
}
