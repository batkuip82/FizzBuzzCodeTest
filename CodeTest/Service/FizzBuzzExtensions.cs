namespace CodeTest.Service
{
    public static class FizzBuzzExtensions
    {
        public static bool IsMultipleOf(this int number, int target)
        {
            return number % target == 0;
        }
    }
}
