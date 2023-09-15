namespace Programming_Task___Random_Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random generator = new Random();
            List<int> numbers = new List<int>();
            int zeroCount = 0;

            for(int i = 0; i < 20; i++)
                numbers.Add(generator.Next(41));
            Console.WriteLine(string.Join(", ", numbers));
            Console.WriteLine("The average is " + numbers.Average());
            Console.WriteLine("The largest number is " + numbers.Max());
            Console.WriteLine("The smallest number is " + numbers.Min());

            // Prints words for multipes of ten
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == 10)
                    Console.Write("Ten ");
                else if (numbers[i] == 20)
                    Console.Write("Twenty ");
                else if (numbers[i] == 30)
                    Console.Write("Thirty ");
                else if (numbers[i] == 40)
                    Console.Write("Fourty ");
                else
                    Console.Write(numbers[i] + " ");
            }

            Console.WriteLine();
            Console.WriteLine("Double List");
            for (int i = 0; i < numbers.Count; i++)
                numbers[i] = numbers[i] * 2;
            Console.WriteLine("Set values < 50 to zero");
            for (int i = 0; i < numbers.Count; i++)
                if (numbers[i] < 50)
                    numbers[i] = 0;
            Console.WriteLine(string.Join(", ", numbers));
            Console.WriteLine("Challenge - Count Zeroes");
            for (int i = 0; i < numbers.Count; i++)
                if (numbers[i] == 0)
                    zeroCount += 1;
            Console.WriteLine("There are " + zeroCount + " zeroes");
        }
    }
}