namespace Testing_Lab1
{
    public class Programs
    {
        public int[] Sort(int[] array)
        {
            void Swap(ref int a, ref int b) => (a, b) = (b, a);

            var d = array.Length / 2;

            while (d >= 1)
            {
                for (var i = d; i < array.Length; i++)
                {
                    var j = i;
                    while ((j >= d) && (array[j - d] > array[j]))
                    {
                        Swap(ref array[j], ref array[j - d]);
                        j = j - d;
                    }
                }
                d = d / 2;
            }

            return array;
        }

        public bool Palindrome(string stroka)
        {
            if (stroka.Length < 2) return false;

            for (int i = 0; i < stroka.Length / 2; i++) if (stroka[i] != stroka[stroka.Length - i - 1]) return false;

            return true;
        }

        public int Factorial(int n)
        {
            if (n < 0) throw new Exception("A number less than zero");

            int factorial = 1;

            for (int i = 1; i <= n; i++) factorial *= i;

            return factorial;
        }

        public int Fibonacci(int n)
        {
            if (n < 0) throw new Exception("A number less than zero");

            if (n == 1) return 1;
            else if (n == 0) return 0;

            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }

        public double ExponentiationRealNumber(double a, double b) 
        {
            if (a <= 0) throw new Exception("You can't do that");

            return Math.Pow(a, b); 
        }

        public bool PrimeNumber(int number)
        {
            if (number < 0) return false;

            for (int i = 2; i < Math.Sqrt(number); i++) if (number % i == 0) return false;

            return true;
        }
    }
}