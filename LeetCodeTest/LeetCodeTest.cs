namespace LeetCodeTest;

public class Tests
{
    [Test]
    public void TwoSumTest()//1
    {
        var input = new[] { 2, 7, 11, 15 };
        const int target = 9;
        var expected = new[] { 0, 1 };
        var actual = _1TwoSum.TwoSum(input,target);
        Assert.That(actual, Is.EquivalentTo(expected));
    }
    
    [Test]
    public void ValidParenthesesTest()//20
    {
        const string input = "()[]{}";
        var actual = ValidParentheses.IsValid(input);
        Assert.That(actual, Is.True);
    }
    
    [Test]
    public void RemoveElementTest()//27
    {
        var input = new[] { 3,2,2,3 };
        const int val = 3;
        const int expected = 2;
        var actual = RemoveElement_27.RemoveElement(input, val);
        Assert.That(actual, Is.EqualTo(expected));
    }
    
    [Test]
    public void ImplementStrStrTest()//28
    {
        const string haystack = "hello";
        const string needle = "ll";
        const int expected = 2;
        var actual = ImplementStrStr_28.StrStr(haystack, needle);
        Assert.That(actual, Is.EqualTo(expected));
    }
    
    [Test]
    public void MaximumSubarrayTest()//53
    {
        var input = new[]{ -2, 1, -3, 4, -1, 2, 1, -5, 4 };
        const int expected = 6;
        var actual = MaximumSubarray.MaxSubArray(input);
        Assert.That(actual, Is.EqualTo(expected));
    }
    
    [Test]
    public void PlusOneTest()//66
    {
        var input = new[]{ 1,2,3 }; 
        var expected = new[]{ 1,2,4 };
        var actual = PlusOne_66.PlusOne(input);
        Assert.That(actual, Is.EquivalentTo(expected));
    }
    
    [Test]
    public void SqrtXTest()//69
    {
        const int input = 4; 
        const int expected = 2;
        var actual = SqrtX.MySqrt(input);
        Assert.That(actual, Is.EqualTo(expected));
    }
    
    [Test]
    public void ClimbingStairsTest()//70
    {
        const int input = 2; 
        const int expected = 2;
        var actual = _70ClimbingStairs.ClimbStairs(input);
        Assert.That(actual, Is.EqualTo(expected));
    }
    
    [Test]
    public void Base7Test()//504
    {
        const int input = 100;
        const string expected = "202";
        var actual = Base7converter.ConvertToBase7(input);
        Assert.That(actual, Is.EqualTo(expected));
    }
}