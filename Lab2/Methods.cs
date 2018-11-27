using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Methods
    {
        private string method = "Method ";

        private string with = " with ";

        private string parameters = " parameters should be return value ";

        public string max(int x, int y)
        {
            int result = 0;

            if (x > y)
            {
                result = x;
            }
            else
            {
                result = y;
            }

            return "\n" + method + "max" + with + 2 + parameters + result;

        }

        public string max(int a, int b, int c, int d)
        {
            int result = 0;

            if (a > b && a > c && a > d)
            {
                result = a;
            }
            else if (b > a && b > c && b > d)
            {
                result = b;
            }
            else if (c > a && c > b && c > d)
            {
                result = c;
            }
            else if (d > a && d > b && d > c)
            {
                result = d;
            }

            return "\n" + method + "max" + with + 4 + parameters + result;

        }

        public string min(int x, int y)
        {
            int result = 0;

            if (x < y)
            {
                result = x;
            }
            else
            {
                result = y;
            }

            return "\n" + method + "min" + with + 2 + parameters + result;

        }

        public string min(int a, int b, int c, int d)
        {
            int result = 0;

            if (a < b && a < c && a < d)
            {
                result = a;
            }
            else if (b < a && b < c && b < d)
            {
                result = b;
            }
            else if (c < a && c < b && c < d)
            {
                result = c;
            }
            else if (d < a && d < b && d < c)
            {
                result = d;
            }

            return "\n" + method + "min" + with + 4 + parameters + result;

        }

        public string task3(double x)
        {
            double result = 0;
            double sin = Math.Sin(x);
            double cos = Math.Cos(2 * x);
            result = sin + cos;
            return "\n" + method + "task3" + with + 1 + parameters + result.ToString();
        }

        public void task4()
        {
            
        }

        public void task5(List<int> value)
        {
            for(int i = 0; i < value.Count; i++)
            {
                 if(value[i] % 2 != 0)
                 {
                    Console.Write("\n" + "net " + value[i].ToString());     
                }
                else
                 {
                    if(value[i] > 0)
                    {
                        int changeToNegative = (value[i]) * -1;
                        Console.Write("\n" + "task 5 should be return " + changeToNegative.ToString());

                    }
                    else
                    {
                        int changeToPositive = Math.Abs(value[i]);
                        Console.Write("\n" + "task 5 should be return " + changeToPositive.ToString());
                    }

                }
            
             }       
           
        }

        public void task6(List<int> value)
        {
            for(int i = 0; i < value.Count; i++)
            {
                if (value[i] > 0)
                {
                   double resultPositive = Math.Pow(value[i], 2);
                    Console.Write("\n" + "task 6 should be return " + resultPositive);
                }
                else
                {
                    double resultNegative = Math.Pow(value[i], 3);
                    Console.Write("\n" + "task 6 should be return " + resultNegative);
                }

            }
           
        }

        public void task7()
        {
         
        } 

        public void task8()
        {

        }

        public void task9(int value)
        {
            int i = Math.Abs(value);
            while (i >= 10)
                i /= 10;
            Console.Write("\n" + i.ToString());

            int lastDigit = (value % 10);
            Console.Write("\n" + lastDigit.ToString());
        }

    }
        

    
}
