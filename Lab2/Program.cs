 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Program
    {

        private static List<int> testDataForTask5 = new List<int>(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });

        private static List<int> testDataForTask6 = new List<int>(new int[] {-10, -9, -8, -7, -6, -5, -4, -3, -2, -1, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });

        static void Main(string[] args)
        {
            Methods methods = new Methods();
            Console.Write(methods.max(5, 4));
            Console.Write(methods.max(1, 3, 4, 8));
            Console.Write(methods.min(5, 4));
            Console.Write(methods.min(5, 4, 7, 1));
            Console.Write(methods.task3(4));
            methods.task5(testDataForTask5);
            methods.task6(testDataForTask6);
            methods.task7();
            methods.task9(886);
            Console.Read();
        }
    }
}
