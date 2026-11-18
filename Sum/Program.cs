public class Adder
{
    public static int Sum (int[] numbers) {
        int result = 0;
        for (int i=0 ; i<numbers.Length ; i++) {
            result += numbers[i];
        }
        return result;
    }

    public static void Main (string[] args) {
        int[] testcase1 = {1, 3, 5, 2, 3, 7};
        int[] testcase2 = {5, 6, 2, 3};
        Console.WriteLine(Sum(testcase1)); // 1+3+5+2+3+7=21 -- Output is correct
        Console.WriteLine(Sum(testcase2)); // 5+6+2+3=16 -- Output is incorrect
    }
}