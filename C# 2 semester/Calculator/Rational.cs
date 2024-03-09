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
        public static Rational Plus(Rational rat1, Rational rat2)
        {
            int m1 = rat1.M;
            int n1 = rat1.N;
            int m2 = rat2.M;
            int n2 = rat2.N;
            int resultN = n1 * n2;
            int resultM = m1 * n2 + m2 * n1;
            int nod = FindNOD(resultN, resultM);
            resultN /= nod;
            resultM /= nod;
            return new Rational(resultM, resultN);
        }
        public static Rational Minus(Rational rat1, Rational rat2)
        {
            int m1 = rat1.M;
            int n1 = rat1.N;
            int m2 = rat2.M;
            int n2 = rat2.N;
            int resultN = n1 * n2;
            int resultM = m1 * n2 - m2 * n1;
            int nod = FindNOD(resultN, resultM);
            resultN /= nod;
            resultM /= nod;
            return new Rational(resultM, resultN);
        }
        public static Rational Multiply(Rational rat1, Rational rat2)
        {
            int m1 = rat1.M;
            int n1 = rat1.N;
            int m2 = rat2.M;
            int n2 = rat2.N;
            int resultN = n1 * n2;
            int resultM = m1 * m2;
            int nod = FindNOD(resultN, resultM);
            resultN /= nod;
            resultM /= nod;
            return new Rational(resultM, resultN);
        }
        public static Rational Divide(Rational rat1, Rational rat2)
        {
            int m1 = rat1.M;
            int n1 = rat1.N;
            int m2 = rat2.N;
            int n2 = rat2.M;
            int resultN = n1 * n2;
            int resultM = m1 * m2;
            int nod = FindNOD(resultN, resultM);
            resultN /= nod;
            resultM /= nod;
            return new Rational(resultM, resultN);
        }
        public static int FindNOD(int num1, int num2)
        {
            if (num1 == 0) return num2;
            if (num2 == 0) return num1;
            num1 = Math.Abs(num1);
            num2 = Math.Abs(num2);
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
