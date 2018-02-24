namespace CodeTest.Service
{
    public class FizzBuzzService : IFizzBuzzService
    {
        public string GetResult(int number)
        {
            if (number.IsMultipleOf(7) && number.IsMultipleOf(9))
                return "CN";
            else if (number.IsMultipleOf(7))
                return "C";
            else if (number.IsMultipleOf(9))
                return "N";

            return number.ToString();
        }
    }
}
