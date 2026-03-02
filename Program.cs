// See https://aka.ms/new-console-template for more information
public class Program
{
    public static void Main(string[] args)
    {
        List<int> numbers = new List<int>() { 1, 2, 1, 6, 4, 2, 6, 3 };
        for (int i = 0; i < numbers.Count; i++)
        {
            for (int j = i + 1; j < numbers.Count; j++)
            {
                if (numbers[i] == numbers[j])
                {
                    numbers.RemoveAt(j);
                    j--;
                }
            }
        }

        foreach (var number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}

    






