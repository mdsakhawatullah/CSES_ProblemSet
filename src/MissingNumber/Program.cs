namespace MissingNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string[] numbers = Console.ReadLine().Split();
            int[] array = Array.ConvertAll(numbers, int.Parse);

            int totalSum = n * (n + 1) / 2;
            int sum = 0;

            foreach (int num in array)
            {
                sum += num;

            }

            int missingSum = totalSum - sum;
            Console.WriteLine(missingSum);
        }
    }
}
