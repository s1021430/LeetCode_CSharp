namespace LeetCode
{
    public class SqrtX
    {
        public static int MySqrt(int x) {
            switch (x)
            {
                case < 2:
                    return x;
                case < 4:
                    return 1;
            }
            var left = 0;
            var right = x;
            while(left < right)
            {
                var mid = (left + right) /2;
                if(x / mid >= mid) 
                    left = mid + 1;
                else 
                    right = mid;
            }
            return right-1;
        }
    }
}