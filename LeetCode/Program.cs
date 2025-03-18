using LeetCode._80;

var solution = new Solution();
int[] nums1 = [1,1,1,2,2,3];
solution.RemoveDuplicates(nums1);
NumsEqual([1,1,2,2,3], nums1);


return;

void NumsEqual(int[] expected, int[] res)
{
    var equals = Equals(expected, res);
    Console.BackgroundColor = equals ? ConsoleColor.DarkGreen : ConsoleColor.DarkRed;
    Console.WriteLine($"Expected: [{string.Join(',', expected)}], Actual: [{string.Join(',', res)}]");
    Console.ResetColor();
}


void Output(long expected, long result)
{
    Console.BackgroundColor = expected == result ? ConsoleColor.DarkGreen : ConsoleColor.DarkRed;
    Console.WriteLine($"Expected: {expected}, Actual: ${result}");
    Console.ResetColor();
}





