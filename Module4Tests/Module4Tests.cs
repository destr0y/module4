using NUnit.Framework;
using System;

namespace M4
{
    [TestFixture]
    public class Module4Tests
    {
        Module4 program = new Module4();
        int[] numbers = new int[] { -1, 12, 23, 94, -65 };

        [TestCase(null)]
        [TestCase(new int[] { })]
        public void Task_1_A_Test_throws_ArgumentNullException_nullArgument(int[] array)
        {
            Exception ex = Assert.Catch(() => program.Task_1_A(array));
            Assert.IsInstanceOf(typeof(ArgumentNullException), ex);

        }

        [TestCase(new int[] { -1, 12, 23, 94, -65 }, ExpectedResult = 94)]
        [TestCase(new int[] { -1, -2, 0, 0 }, ExpectedResult = 0)]
        [TestCase(new int[] { -1, -2, -10, -10, -1 }, ExpectedResult = -1)]
        [TestCase(new int[] { 0, 0 }, ExpectedResult = 0)]
        [TestCase(new int[] { -10 }, ExpectedResult = -10)]
        public int Task_1_A_Test_properly_find_max_item(int[] array)
        {
            return program.Task_1_A(array);
        }

        [TestCase(null)]
        [TestCase(new int[] { })]
        public void Task_1_B_Test_throws_ArgumentNullException_nullArgument(int[] array)
        {
            Exception ex = Assert.Catch(() => program.Task_1_B(array));
            Assert.IsInstanceOf(typeof(ArgumentNullException), ex);

        }

        [TestCase(new int[] { -1, 12, 23, 94, -65 }, ExpectedResult = -65)]
        [TestCase(new int[] { -1, -2, 0, 0 }, ExpectedResult = -2)]
        [TestCase(new int[] { -1, -2, -10, -10, -1 }, ExpectedResult = -10)]
        [TestCase(new int[] { 0, 0 }, ExpectedResult = 0)]
        [TestCase(new int[] { -10 }, ExpectedResult = -10)]
        public int Task_1_B_Test_properly_find_min_item(int[] array)
        {
            return program.Task_1_B(array);
        }

        [TestCase(null)]
        [TestCase(new int[] { })]
        public void Task_1_C_Test_throws_ArgumentNullException_nullArgument(int[] array)
        {
            Exception ex = Assert.Catch(() => program.Task_1_C(array));
            Assert.IsInstanceOf(typeof(ArgumentNullException), ex);

        }

        [TestCase(new int[] { -1, 12, 23, 94, -65 }, ExpectedResult = 63)]
        [TestCase(new int[] { -1, -2, 0, 0 }, ExpectedResult = -3)]
        [TestCase(new int[] { -1, -2, -10, -10, -1 }, ExpectedResult = -24)]
        [TestCase(new int[] { 0, 0 }, ExpectedResult = 0)]
        [TestCase(new int[] { -10 }, ExpectedResult = -10)]
        public int Task_1_C_Test_properly_find_sum_of_items(int[] array)
        {
            return program.Task_1_C(array);
        }

        [TestCase(null)]
        [TestCase(new int[] { })]
        public void Task_1_D_Test_throws_ArgumentNullException_nullArgument(int[] array)
        {
            Exception ex = Assert.Catch(() => program.Task_1_D(array));
            Assert.IsInstanceOf(typeof(ArgumentNullException), ex);

        }

        [TestCase(new int[] { -1, 12, 23, 94, -65 }, ExpectedResult = 159)]
        [TestCase(new int[] { -1, -2, 0, 0 }, ExpectedResult = 2)]
        [TestCase(new int[] { -1, -2, -10, -10, -1 }, ExpectedResult = 9)]
        [TestCase(new int[] { 0, 0 }, ExpectedResult = 0)]
        [TestCase(new int[] { -10 }, ExpectedResult = 0)]
        public int Task_1_D_Test_properly_find_difference_between_maxItem_and_minItem(int[] array)
        {
            return program.Task_1_D(array);
        }

        [TestCase(null)]
        [TestCase(new int[] { })]
        public void Task_1_E_Test_throws_ArgumentNullException_nullArgument(int[] array)
        {
            Exception ex = Assert.Catch(() => program.Task_1_E(array));
            Assert.IsInstanceOf(typeof(ArgumentNullException), ex);

        }

        [TestCase(new int[] { -1, 12, 23, 94, -65 }, new int[] { 93, 77, 117, 159, 29 })]
        [TestCase(new int[] { -1, -2, 0, 0 }, new int[] { -1, 0, 0, 2 })]
        [TestCase(new int[] { 0, 0 }, new int[] { 0, 0 })]
        [TestCase(new int[] { -10 }, new int[] { -20 })]
        public void Task_1_E_properly_increase_even_item_and_decrese_odd_item(int[] array, int[] expected)
        {
            program.Task_1_E(array);
            CollectionAssert.AreEqual(expected, array);
        }

        [TestCase(1, 2, 3, ExpectedResult = 6)]
        [TestCase(0, 0, 0, ExpectedResult = 0)]
        [TestCase(10, 0, -10, ExpectedResult = 0)]
        [TestCase(10, 0, -10, ExpectedResult = 0)]
        public int Task_2_properly_sum_3_integers(int a, int b, int c)
        {
            return program.Task_2(a, b, c);
        }

        [TestCase(1, 2, ExpectedResult = 3)]
        [TestCase(0, 0, ExpectedResult = 0)]
        [TestCase(10, 0, ExpectedResult = 10)]
        [TestCase(10, -10, ExpectedResult = 0)]
        public int Task_2_properly_sum_2_integers(int a, int b)
        {
            return program.Task_2(a, b);
        }

        [TestCase(1.1, 2.2, 3.3, ExpectedResult = 6.6)]
        [TestCase(0, 0, 0, ExpectedResult = 0.0)]
        [TestCase(10.1, 0, -2.1, ExpectedResult = 8.0)]
        [TestCase(10.0, -10.0, 0.0, ExpectedResult = 0.0)]
        public double Task_2_properly_sum_3_doubles(double a, double b, double c)
        {
            return program.Task_2(a, b, c);
        }

        [TestCase("a", "b", ExpectedResult = "ab")]
        public string Task_2_properly_sum_2_strings(string a, string b)
        {
            return program.Task_2(a, b);
        }

        [TestCase(new int[] { -1, 12, 23, 94, -65 }, new int[] { -1, 12, 23, 94, -65 }, ExpectedResult = new int[] { -2, 24, 46, 188, -130 })]
        [TestCase(new int[] { -1, 12, 23, 94, -65 }, new int[] { 0 }, ExpectedResult = new int[] { -1, 12, 23, 94, -65 })]
        [TestCase(new int[] { 0 }, new int[] { 0 }, ExpectedResult = new int[] { 0 })]
        [TestCase(new int[] { 0 }, new int[] { -1, 12, 23, 94, -65 }, ExpectedResult = new int[] { -1, 12, 23, 94, -65 })]
        [TestCase(new int[] { 1, 2, 3 }, new int[] { -1, 12, 23, 94, -65 }, ExpectedResult = new int[] { 0, 14, 26, 94, -65 })]

        public int[] Task_2_properly_sum_2_arrays(int[] array1, int[] array2)
        {
            return program.Task_2(array1, array2);
        }

        [TestCase(10, 20, 30, new int[] { 20, 30, 40 })]
        [TestCase(0, 0, 0, new int[] { 10, 10, 10 })]
        [TestCase(-2, -2, -2, new int[] { 8, 8, 8 })]
        public void Task_3_properly_increase_3_integers_with_10(int a, int b, int c, int[] expected)
        {
            program.Task_3_A(ref a, ref b, ref c);
            Assert.That(a, Is.EqualTo(expected[0]));
            Assert.That(b, Is.EqualTo(expected[1]));
            Assert.That(c, Is.EqualTo(expected[2]));
        }

        [TestCase(-5)]
        public void Task_3_B_Test_throws_ArgumentException_when_argument_is_negative(int radius)
        {
            double length, square;
            Exception ex = Assert.Catch(() => program.Task_3_B(radius, out length, out square));
            Assert.IsInstanceOf(typeof(Exception), ex);

        }

        [TestCase(0, new double[] { 0, 0 })]
        [TestCase(1, new double[] { 2 * Math.PI, Math.PI * 1 })]
        [TestCase(2, new double[] { 4 * Math.PI, Math.PI * 4 })]
        public void Task_3_properly_find_length_and_square_of_the_circle(double radius, double[] results)
        {
            double length;
            double square;
            program.Task_3_B(radius, out length, out square);
            Assert.That(length, Is.EqualTo(results[0]));
            Assert.That(square, Is.EqualTo(results[1]));
        }

        [TestCase(null)]
        [TestCase(new int[] { })]
        public void Task_3_C_Test_throws_ArgumentNullException_nullArgument(int[] array)
        {
            int maxItem, minItem, sumOfItems;
            Exception ex = Assert.Catch(() => program.Task_3_C(array, out maxItem, out minItem, out sumOfItems));
            Assert.IsInstanceOf(typeof(Exception), ex);

        }

        [TestCase(new int[] { 1, 2, 3 }, new int[] { 3, 1, 6 })]
        [TestCase(new int[] { 0 }, new int[] { 0, 0, 0 })]
        [TestCase(new int[] { 0, -10 }, new int[] { 0, -10, -10 })]
        [TestCase(new int[] { -10, 0, 10 }, new int[] { 10, -10, 0 })]
        [TestCase(new int[] { -10, -10, 10, 10 }, new int[] { 10, -10, 0 })]
        public void Task_3_C_properly_find_max_and_min_and_sum_of_array(int[] array, int[] results)
        {
            int maxItem, minItem, sumOfItems;
            program.Task_3_C(array, out maxItem, out minItem, out sumOfItems);
            Assert.That(maxItem, Is.EqualTo(results[0]));
            Assert.That(minItem, Is.EqualTo(results[1]));
            Assert.That(sumOfItems, Is.EqualTo(results[2]));
        }



    }
}
