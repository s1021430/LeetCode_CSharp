namespace LeetCode
{
    public class Base7converter
    {
        public static string ConvertToBase7(int num) {
            switch (num)
            {
                case < 0:
                    return $"-{ConvertToBase7(-num)}";
                case < 7:
                    return num.ToString();
                default:
                {
                    var base7 = ConvertToBase7(num/7);
                    return $"{base7}{num % 7}";
                }
            }
        }
    }
}