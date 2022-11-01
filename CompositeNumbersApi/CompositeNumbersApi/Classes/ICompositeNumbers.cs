using Microsoft.AspNetCore.Mvc;

namespace CompositeNumbersApi.Classes
{
    public interface ICompositeNumbers
    {
        public bool CheckSingleCompositeNumber(int number);

        public List<long> CheckMultipleCompositeNumbers(int n1, int n2);
    }
}
