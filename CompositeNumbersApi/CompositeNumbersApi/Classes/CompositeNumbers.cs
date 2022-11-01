namespace CompositeNumbersApi.Classes
{
    public class CompositeNumbers : ICompositeNumbers
    {
        public int Count { get; private set; }
        public bool CheckSingleCompositeNumber(int number)
        {
            // Corner cases
            if (number <= 1) return false;
            if (number <= 3) return false;

            // This is checked so that we can skip
            // middle five numbers in below loop
            if (number % 2 == 0 || number % 3 == 0) return true;

            for (int i = 5; i * i <= number; i = i + 6)

                if (number % i == 0 || number % (i + 2) == 0)
                    return true;

            return false;
        }
        // Did you mean: Tuple<List<long>, int> ??
        // Only one return type allowed :)
        public List<long> CheckMultipleCompositeNumbers(int n1, int n2)
        {
            List<long> result = new List<long>();
            Count = 0;
            for (int i = n1; i <= n2; i++)
            {
                if (CheckSingleCompositeNumber(i))
                {
                    Count++;
                    result.Add(i);
                }
            }
            return result;
        }
    }
}
