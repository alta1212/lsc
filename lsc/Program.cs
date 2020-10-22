using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuyHoachDong_DayConChungDaiNhat
{
    class QuyHoachDong_DayConChungDaiNhat
    {
        static int lsc(string X, string Y, int m, int n)
        {
            int[,] L = new int[m + 1, n + 1];

            for (int i = 0; i <= m; i++)
            {
                for (int j = 0; j <= n; j++)
                {
                    if (i == 0 || j == 0)
                        L[i, j] = 0;
                    else if (X[i - 1] == Y[j - 1])
                        L[i, j] = L[i - 1, j - 1] + 1;
                    else
                        L[i, j] = max(L[i - 1, j], L[i, j - 1]);
                }
            }
            return L[m, n];
        }
        static int max(int a, int b)
        {
            return (a > b) ? a : b;
        }
        static void Main(string[] args)
        {
            string X = "AGVCBTYB";
            string Y = "GXTXAYB";

            int m = X.Length;
            int n = Y.Length;

            Console.WriteLine("Do dai day con chung lon nhat la : {0}", lsc(X, Y, m, n));
            Console.ReadKey();
        }
    }
}