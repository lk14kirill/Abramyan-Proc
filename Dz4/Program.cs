using System;
using System.ComponentModel.DataAnnotations.Schema;
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
        #region Proc52-53

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
            int year = int.Parse(Console.ReadLine());
            int m1 = int.Parse(Console.ReadLine());
            int m2 = int.Parse(Console.ReadLine());
            int m3 = int.Parse(Console.ReadLine());
            Console.WriteLine(MonthDays(m1,year));
            Console.WriteLine(MonthDays(m2, year));
            Console.WriteLine(MonthDays(m3, year));
        }
        #endregion
        #region Proc56-59

        static void TakeDoubles(out double[] Values)
        {
            Values = new double[7];
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());
            double x4 = double.Parse(Console.ReadLine());
            double y4 = double.Parse(Console.ReadLine());
            Values[0] = x1;
            Values[1] = y1;
            Values[2] = x2;
            Values[3] = y2;
            Values[4] = x3;
            Values[5] = y3;
            Values[6] = x4;
            Values[7] = y4;
        }
        static double Leng(double xA, double yA, double xB, double yB)
        {
            return Math.Sqrt(Math.Pow((xA - xB), 2) + Math.Pow((yA - yB), 2));
        }



        static void Proc56()
        {
            TakeDoubles(out double[] Values);
            Console.WriteLine(Leng(Values[0], Values[1], Values[2], Values[3]));
            Console.WriteLine(Leng(Values[0], Values[1], Values[4], Values[5]));
            Console.WriteLine(Leng(Values[0], Values[1], Values[6], Values[7]));


        }
        static double Perim(double xA, double yA, double xB, double yB,double xC,double yC)
        {
            double a = Leng(xA, yA, xB, yB);
            double b = Leng(xA, yA, xC ,yC);
            double c = Leng(xB, yB, xC, yC);
            return a + b + c;
        }
        static void Proc57()
        {
            TakeDoubles(out double[] Values);
            Console.WriteLine(Perim(Values[0], Values[1], Values[2], Values[3], Values[4], Values[5]));
            Console.WriteLine(Perim(Values[0], Values[1], Values[3], Values[4], Values[6], Values[7]));
            Console.WriteLine(Perim(Values[0], Values[1], Values[4], Values[5], Values[6], Values[7]));
        }
        static double Area(double xA, double yA, double xB, double yB, double xC, double yC )
        {
            double p = Perim(xA, yA, xB, yB, xC, yC);
            double AB = Math.Abs(Leng(xA, yA, xB, yB));
            double AC = Leng(xA, yA, xB, yB);
            double BC = Leng(xB, yB, xC, yC);
            return Math.Sqrt(p*(p-AB)*(p-AC)*(p-BC));
        }

        static void Proc58()
        {
            TakeDoubles(out double[] Values);
            Console.WriteLine(Area(Values[0], Values[1], Values[2], Values[3], Values[4], Values[5]));
            Console.WriteLine(Area(Values[0], Values[1], Values[3], Values[4], Values[6], Values[7]));
            Console.WriteLine(Area(Values[0], Values[1], Values[4], Values[5], Values[6], Values[7]));
        }
        static double Dist(double xP, double yP,double xA, double yA, double xB, double yB)
        {
            double Spab = Area(xP, yP, xA, yA, xB, yB);
            double AB = Math.Abs(Leng(xA, yA, xB, yB));

            return 2 * Spab / AB;
        }
        static void Proc59()
        {
            TakeDoubles(out double[] Values);
            Console.WriteLine(Area(Values[0], Values[1], Values[2], Values[3], Values[4], Values[5]));
            Console.WriteLine(Area(Values[0], Values[1], Values[2], Values[3], Values[6], Values[7]));
            Console.WriteLine(Area(Values[0], Values[1], Values[4], Values[5], Values[6], Values[7]));
        }

        #endregion
        static void Main(string[] args)
        {
            Proc58();
        }
    }
}
