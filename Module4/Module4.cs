using System;
using System.Linq;

namespace M4
{
    public class Module4
    {
        static void Main(string[] args)
        {
            // Some code
        }


        public int Task_1_A(int[] array)
        {
            if (array == null || array.Length == 0) throw new ArgumentNullException("array");
            return array.Max();
        }

        public int Task_1_B(int[] array)
        {
            if (array == null || array.Length == 0) throw new ArgumentNullException("array");
            return array.Min();
        }

        public int Task_1_C(int[] array)
        {
            if (array == null || array.Length == 0) throw new ArgumentNullException("array");
            return array.Sum();
        }

        public int Task_1_D(int[] array)
        {
            if (array == null || array.Length == 0) throw new ArgumentNullException("array");
            return array.Max() - array.Min();
        }

        public void Task_1_E(int[] array)
        {
            if (array == null || array.Length == 0) throw new ArgumentNullException("array");
            
            var max = array.Max();
            var min = array.Min();
            
            for (int i = 0; i < array.Length; i++)
            {
                if (i % 2 == 0)
                    array[i] += max;
                else 
                    array[i] -= min;
            }
        }

        public int Task_2(int a, int b, int c)
        {
            return a + b + c;
        }

        public int Task_2(int a, int b)
        {
            return a + b;
        }

        public double Task_2(double a, double b, double c)
        {
            return a + b + c;
        }

        public string Task_2(string a, string b)
        {
            return string.Concat(a, b);
        }

        public int[] Task_2(int[] a, int[] b)
        {
            // Меняем массивы, чтобы а всегда был массивом с большей размерностью
            if (b.Length > a.Length)
                (a, b) = (b, a);
            
            for (int i = 0; i < b.Length; i++)
            {
                a[i] += b[i];
            }

            return a;
        }

        public void Task_3_A(ref int a, ref int b, ref int c)
        {
            a += 10;
            b += 10;
            c += 10;
        }

        public void Task_3_B(double radius, out double length, out double square)
        {
            if (radius < 0) throw new ArgumentException("radius");
            
            length = 2 * Math.PI * radius;
            square = Math.PI * Math.Pow(radius,2);
        }

        public void Task_3_C(int[] array, out int maxItem, out int minItem, out int sumOfItems)
        {
            if (array == null || array.Length == 0) throw new ArgumentNullException("array");
            
            maxItem = array.Max();
            minItem = array.Min();
            sumOfItems = array.Sum();
        }

        public (int, int, int) Task_4_A((int, int, int) numbers)
        {
            var a = numbers.Item1 + 10;
            var b = numbers.Item2 + 10;
            var c = numbers.Item3 + 10;
            
            return (a, b, c);
        }

        public (double, double) Task_4_B(double radius)
        {
            if (radius < 0) throw new ArgumentException("Radius should be more than 0", "radius");
            
            var length = 2 * Math.PI * radius;
            var square = Math.PI * Math.Pow(radius,2);

            return (length, square);
        }

        public (int, int, int) Task_4_C(int[] array)
        {
            if (array == null || array.Length == 0) throw new ArgumentNullException("array");
            
            return (array.Min(), array.Max(), array.Sum());
        }

        public void Task_5(int[] array)
        {
            if (array == null || array.Length == 0) throw new ArgumentNullException("array");
            for (int i = 0; i < array.Length; i++)
                array[i] += 5;
        }

        public void Task_6(int[] array, SortDirection direction)
        {
            if (array == null || array.Length == 0) throw new ArgumentNullException("array");
            
            Array.Sort(array);

            if (direction == SortDirection.Descending)
                Array.Reverse(array);
        }        

        public  double Task_7(Func<double, double> func, double x1, double x2, double e, double result = 0)
        {
            if (func == null)
                throw new ArgumentNullException("func");
            
            double c = (x2 + x1) / 2.0f;
            
            if (func(c) == 0 || x1 + x2 < e) 
                return c;
            
            if (func(c) * func(x1) < 0)
                return Task_7(func, x1, c, e, result);
            else
                return Task_7(func, c, x2, e, result);
        }
    }
}
