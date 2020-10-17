using System;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

namespace Dz4
{
    class Program
    {
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
        static double Power1( double A,  double B)
        {
            if (A >0 )return A = Math.Exp(B * Math.Log(A));
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
        static double Power3(double A,double B)
        {
            if (B > Math.Round(B)) return Power2(A, (int) Math.Round(B));
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
                Console.WriteLine(Exp1(x,e));
            }



        }
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
        static double Cos1(double x, double e)
        {
            double result = 0;
            double n1 = 0;
            while (result >= e)
            {
                n1++;
                result += Math.Pow((-1), n1) * Math.Pow(x, 2 * n1 ) / (2 * n1 );
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
        static double Ln1(double x, double e)
        {
            double result = 0;
            double n1 = 0;
            while (result >= e)
            {
                n1++;
                result += Math.Pow((-1), n1) * Math.Pow(x, n1+1) / (n1 +1);
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
        static double Arctg1(double x, double e)
        {
            double result = 0;
            double n1 = 0;
            while (result >= e)
            {
                n1++;
                result += Math.Pow((-1), n1) * Math.Pow(x, 2*n1 + 1) / (2*n1 + 1);
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
        static double Power4(double x,double e,double a )
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
                Console.WriteLine(Power4(x, e,a));
            }
        }
        static void Main(string[] args)
        {
            
        }
    }
}
