using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
static double max(double arg,double b)
{
    if (arg>b) return arg;
    else return b;
}
     
        static void Main(string[] args)
        {
            double[,] A =new double[,] 
{{75,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
{95,64,0,0,0,0,0,0,0,0,0,0,0,0,0},
{17,47,82,0,0,0,0,0,0,0,0,0,0,0,0},
{18,35,87,10,0,0,0,0,0,0,0,0,0,0,0},
{20, 04, 82, 47, 65,0,0,0,0,0,0,0,0,0,0},
{19, 01, 23, 75, 03, 34,0,0,0,0,0,0,0,0,0},
{88, 02, 77, 73, 07, 63, 67,0,0,0,0,0,0,0,0},
{99, 65, 04, 28, 06, 16, 70, 92,0,0,0,0,0,0,0},
{41, 41, 26, 56, 83, 40, 80, 70, 33,0,0,0,0,0,0},
{41, 48, 72, 33, 47, 32, 37, 16, 94, 29,0,0,0,0,0},
{53, 71, 44, 65, 25, 43, 91, 52, 97, 51, 14,0,0,0,0},
{70, 11, 33, 28, 77, 73, 17, 78, 39, 68, 17, 57,0,0,0},
{91, 71, 52, 38, 17, 14, 91, 43, 58, 50, 27, 29, 48,0,0},
{63, 66, 04, 68, 89, 53, 67, 30, 73, 16, 69, 87, 40, 31,0},
{04, 62, 98, 27, 23, 09, 70, 98, 73, 93, 38, 53, 60, 04, 23}};

           int k=15;
           int m;
            for (int i=k-2;i>-1;i--)
                for (int j = 0; j < i + 1; j++)
                {
                    if (j == 0)
                        A[i, j] = A[i, j] + max(A[i + 1, j], A[i + 1, j + 1]);
                    else
                        A[i, j] = A[i, j] + max(max(A[i + 1, j], A[i + 1, j + 1]),A[i + 1, j -1]);
                }
            Console.WriteLine(A[1,1]);
            Console.ReadKey();
        }
    }
}
/*int k=0,h=0;
           bool f=false;
           int[] a = new int[100];
           for(int i=0;i<100;i++)
           {   
               if ((a[i-1]==1)||(i==0))
               if(a[i]==1)
                   k++;
               else
               {
                   if (h < k)
                       h = k;
               }
           }*/
