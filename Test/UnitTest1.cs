using Testing_Lab1;
using NUnit.Framework;

namespace Test
{
    [TestFixture]
    public class Tests
    {
        private Programs programs;

        private Func<int[], int[]> Sort;
        private Func<string, bool> Palindrome;
        private Func<int, int> Factorial;
        private Func<int, int> Fibonacci;
        private Func<double, double, double> Exponentiation;
        private Func<int, bool> PrimeNumber;

        [SetUp]
        public void Setup()
        {
            programs = new Programs();

            Sort = programs.Sort;
            Palindrome = programs.Palindrome;
            Factorial = programs.Factorial;
            Fibonacci = programs.Fibonacci;
            Exponentiation = programs.ExponentiationRealNumber;
            PrimeNumber = programs.PrimeNumber;
        }

        [Test]
        public void Test_Sort()
        {
            int[] array1 = new int[10] { 1, 7, 10, 24, 65, 12, 56, 5, 1, 2};
            int[] array_correct1 = new int[10] { 1, 1, 2, 5, 7, 10, 12, 24, 56, 65 };

            int[] array2 = new int[10] { -1, -2, 3, -4, -5, -6, 7, 8, 9, 10 };
            int[] array_correct2 = new int[10] { -6, -5, -4, -2, -1, 3, 7, 8, 9, 10 };

            CollectionAssert.AreEqual(Sort(array1), array_correct1);
            CollectionAssert.AreEqual(Sort(array2), array_correct2);
        }

        [Test]
        public void Test_Palindrome()
        {
            string str1 = string.Empty;
            string str2 = "1";

            string str3 = "111";
            string str4 = "020";
            string str5 = "001";

            string[] tests = { str1, str2, str3, str4, str5 };


            Assert.False(Palindrome(str1));
            Assert.False(Palindrome(str2));
            Assert.True(Palindrome(str3));
            Assert.True(Palindrome(str4));
            Assert.False(Palindrome(str5));

        }

        [Test]
        public void Test_Factorial()
        {
            Exception ex = Assert.Throws<Exception>(() => Factorial(-1));

            Assert.That(Factorial(5), Is.EqualTo(120));
            Assert.That(ex.Message, Is.EqualTo("A number less than zero"));
        }

        [Test]
        public void Test_Fibonacci()
        {
            Exception ex = Assert.Throws<Exception>(() => Fibonacci(-1));

            Assert.That(Fibonacci(7), Is.EqualTo(13));
            Assert.That(ex.Message, Is.EqualTo("A number less than zero"));
        }

        [Test]
        public void Test_ExponentiationRealNumber() 
        {
            Exception ex1 = Assert.Throws<Exception>(() => Exponentiation(-0.1, 0.1));
            Exception ex2 = Assert.Throws<Exception>(() => Exponentiation(0.0, -0.1));

            Assert.That(ex1.Message, Is.EqualTo("You can't do that"));
            Assert.That(ex2.Message, Is.EqualTo("You can't do that"));

            Assert.That(Exponentiation(1.1, 1.1), Is.EqualTo(1.1105342410545758));
        }

        [Test]
        public void Test_PrimeNumber()
        {
            int a = 191;
            int b = -191;
            int c = 10;
            int d = -10;

            Assert.True(PrimeNumber(a));
            Assert.False(PrimeNumber(b));
            Assert.False(PrimeNumber(c));
            Assert.False(PrimeNumber(d));
        }
    }
}
