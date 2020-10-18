using System;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

namespace Dz4
{
    class Program
    {
        #region Proc16
        static int Signproc16(float x)
        {
            if (x == 0)
                return 0;
            if (x < 0)
                return -1;
            if (x > 0)
                return 1;
            return 1;
        }
        static void Proc16()
        {
            float A = float.Parse(Console.ReadLine());
            float B = float.Parse(Console.ReadLine());
            Console.WriteLine(Signproc16(A) + Signproc16(B));
        }
        #endregion
        #region Proc37-39

        static double Power1(double A, double B)
        {
            if (A > 0) return A = Math.Exp(B * Math.Log(A));
            return 0;
        }
        static void Proc37()
        {
            double A = double.Parse(Console.ReadLine());
            double B = double.Parse(Console.ReadLine());
            double C = double.Parse(Console.ReadLine());
            double P = double.Parse(Console.ReadLine());
            Console.WriteLine(Power1(A, P));
            Console.WriteLine(Power1(B, P));
            Console.WriteLine(Power1(C, P));
        }
        static double Power2(double A, int N)
        {
            if (N == 0) return 0;
            if (N > 0) return A = Math.Pow(A, N);
            if (N < 0) return A = 1 / Math.Pow(A, Math.Abs(N));
            return 0;
        }
        static void Proc38()
        {
            double A = double.Parse(Console.ReadLine());
            int K = int.Parse(Console.ReadLine());
            int L = int.Parse(Console.ReadLine());
            int M = int.Parse(Console.ReadLine());
            Console.WriteLine(Power2(A, K));
            Console.WriteLine(Power2(A, L));
            Console.WriteLine(Power2(A, M));
        }
        static double Power3(double A, double B)
        {
            if (B > Math.Round(B)) return Power2(A, (int)Math.Round(B));
            else return Power1(A, B);

        }
        static void Proc39()
        {
            double A = double.Parse(Console.ReadLine());
            double B = double.Parse(Console.ReadLine());
            double C = double.Parse(Console.ReadLine());
            double P = double.Parse(Console.ReadLine());
            Console.WriteLine(Power3(A, P));
            Console.WriteLine(Power3(B, P));
            Console.WriteLine(Power3(C, P));
        }
        #endregion
        #region Proc40
        static double Exp1(double x, double e)
        {
            double result = 0;
            double x1;
            double n1 = 0;
            int i = 0;
            double s;
            while (result >= e)
            {

                n1++;
                x1 = Math.Pow(x, n1);
                s = x1 / n1;
                result += s;
            }
            return result;
        }
        static void Proc40()
        {
            double x = double.Parse(Console.ReadLine());

            for (int i = 0; i < 6; i++)
            {
                double e = double.Parse(Console.ReadLine());
                Console.WriteLine(Exp1(x, e));
            }



        }
        #endregion
        #region Proc41
        static double Sin1(double x, double e)
        {
            double result = 0;
            double n1 = 0;
            while (result >= e)
            {
                n1++;
                result += Math.Pow((-1), n1) * Math.Pow(x, 2 * n1 + 1) / (2 * n1 + 1);
            }
            return result;

        }
        static void Proc41()
        {
            double x = double.Parse(Console.ReadLine());

            for (int i = 0; i < 6; i++)
            {
                double e = double.Parse(Console.ReadLine());
                Console.WriteLine(Sin1(x, e));
            }
        }
        #endregion
        #region Proc42
        static double Cos1(double x, double e)
        {
            double result = 0;
            double n1 = 0;
            while (result >= e)
            {
                n1++;
                result += Math.Pow((-1), n1) * Math.Pow(x, 2 * n1) / (2 * n1);
            }
            return result;

        }
        static void Proc42()
        {
            double x = double.Parse(Console.ReadLine());

            for (int i = 0; i < 6; i++)
            {
                double e = double.Parse(Console.ReadLine());
                Console.WriteLine(Cos1(x, e));
            }
        }
        #endregion
        #region Proc43
        static double Ln1(double x, double e)
        {
            double result = 0;
            double n1 = 0;
            while (result >= e)
            {
                n1++;
                result += Math.Pow((-1), n1) * Math.Pow(x, n1 + 1) / (n1 + 1);
            }
            return result;

        }
        static void Proc43()
        {
            double x = double.Parse(Console.ReadLine());

            for (int i = 0; i < 6; i++)
            {
                double e = double.Parse(Console.ReadLine());
                Console.WriteLine(Ln1(x, e));
            }
        }
        #endregion
        #region Proc44
        static double Arctg1(double x, double e)
        {
            double result = 0;
            double n1 = 0;
            while (result >= e)
            {
                n1++;
                result += Math.Pow((-1), n1) * Math.Pow(x, 2 * n1 + 1) / (2 * n1 + 1);
            }
            return result;

        }
        static void Proc44()
        {
            double x = double.Parse(Console.ReadLine());

            for (int i = 0; i < 6; i++)
            {
                double e = double.Parse(Console.ReadLine());
                Console.WriteLine(Arctg1(x, e));
            }
        }
        #endregion
        #region Proc45
        static double Power4(double x, double e, double a)
        {

            double result = 0;
            double n1 = 0;
            while (result >= e)
            {
                n1++;
                result += Math.Pow(x, n1) * (a - n1 - 1) / (n1);
            }
            return result;


        }
        static void Proc45()
        {
            double x = double.Parse(Console.ReadLine());
            double a = double.Parse(Console.ReadLine());
            for (int i = 0; i < 6; i++)
            {
                double e = double.Parse(Console.ReadLine());
                Console.WriteLine(Power4(x, e, a));
            }
        }
        #endregion
        #region Proc46
        static int NOD2(int A, int B)
        {
            if (A == 1 || B == 1) return 1;
            while (A * B != 0)
            {
                (A, B) = (B, A % B);
            }
            return A;
        }
        static void Proc46()
        {
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
            int C = int.Parse(Console.ReadLine());
            int D = int.Parse(Console.ReadLine());
            Console.WriteLine(NOD2(A, B));
            Console.WriteLine(NOD2(A, C));
            Console.WriteLine(NOD2(A, D));
        }


        #endregion
        #region Proc52-55

       static bool IsLeapYear(int Y)
        {
            if (Y % 100 == 0 && Y % 400 != 0) return false;
            if (Y % 4 == 0) return true;
            return false;
        }

        static void Proc52()
        {
            int year = int.Parse(Console.ReadLine());
            Console.WriteLine(IsLeapYear(year));
        }

        static int MonthDays(int M,int Y)
        {


                if (M == 1 || M == 4 || M == 6 || M == 9 || M == 11)
                    return 30;
                    
                if (M == 2)
                if (IsLeapYear(Y))
                    return 29;
                else return 28;
                
            return 31;


        }
        static void Proc53()
        {
            int year = int.Parse(Console.ReadLine()));
            int m1 = int.Parse(Console.ReadLine());
            int m2 = int.Parse(Console.ReadLine());
            int m3 = int.Parse(Console.ReadLine());
            Console.WriteLine(MonthDays(m1,year));
            Console.WriteLine(MonthDays(m2, year));
            Console.WriteLine(MonthDays(m3, year));



        }
        #endregion
        static void Main(string[] args)
        {
            Proc52();
        }
    }
}
