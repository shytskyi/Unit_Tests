namespace BL
{
    public class LiczbaFibonacci
    {
        public static List<int> Fibonacci(List<int> fibonacciNumbers)
        {
            if (fibonacciNumbers == null)
                 throw new ArgumentNullException(nameof(fibonacciNumbers));

            while (fibonacciNumbers.Count < 20)
            {
                int previous = fibonacciNumbers.Count > 0 ? fibonacciNumbers[fibonacciNumbers.Count - 1] : 0;
                int previous2 = fibonacciNumbers.Count > 1 ? fibonacciNumbers[fibonacciNumbers.Count - 2] : 1;


                fibonacciNumbers.Add(previous + previous2);
            }
            return fibonacciNumbers;
        }
    }
}
