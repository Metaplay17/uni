using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Rational
    {
        private int m;
        private int n = 1;

        public Rational() { }
        public Rational(int m, int n)
        {
            this.m = m;
            if (n == 0)
            {
                throw new Exception("Division by zero");
            }
            this.n = n;
        }
        public int M
        {
            get { return m; }
            set { m = value; }
        }
        public int N
        {
            get { return n; }
            set
            {
                if (n == 0)
                {
                    throw new Exception("Divider cannot be zero");
                }
                n = value;
            }
        }
        public Rational Plus(Rational r2)
        {
            int m1 = this.m;
            int n1 = this.n;
            int m2 = r2.m;
            int n2 = r2.n;
            int resultN = FindNOK(n1, n2);
            int resultM = m1 * resultN / n1 + m2 * resultN / n2;
            int divider = FindNOD(resultN, resultM);
            resultN /= divider;
            resultM /= divider;
            return new Rational(resultM, resultN);
        }
        public static int FindNOD(int num1, int num2)
        {
            while (num1 != num2)
            {
                if (num2 > num1)
                {
                    int temp = num1;
                    num1 = num2;
                    num2 = temp;
                }
                num1 = num1 - num2;
            }
            return num1;
        }
        public static int FindNOK(int num1, int num2)
        {
            return num1 * num2 / FindNOD(num1, num2);
        }
    }
}
