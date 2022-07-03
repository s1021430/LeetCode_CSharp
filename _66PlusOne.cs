namespace LeetCode
{
    public class PlusOne_66
    {
        public static int[] PlusOne(int[] digits)
        {
            var plusOne = false;
            for (var i = digits.Length - 1; i >= 0; i--)
            {
                if (plusOne)
                {
                    if (digits[i] == 9)
                    {
                        digits[i] = 0;
                        continue;
                    }
                    plusOne = false;
                    digits[i]++;
                    break;
                }
                if (digits[i] == 9)
                {
                    digits[i] = 0;
                    plusOne = true;
                    continue;
                }
                digits[i]++;
                break;
            }
            if (plusOne == false) return digits;
            var plus = new[]{1};
            var result = new int[digits.Length + 1];
            plus.CopyTo(result, 0);
            digits.CopyTo(result, 1);
            return result;
        }
    }
}