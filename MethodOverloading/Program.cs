namespace MethodOverloading
{
    public class Program
    {
        static void Main(string[] args)
        {
            var x = 54;
            var y = 17;

                var answer = Add(x, y);

            var a = 54.64;
            var b = 17.93;

            var deciAnswer = Add((int)a, (int)b);

            var thirdAnswer = Add(1, 0, true);

            Console.WriteLine($"int add: {answer}");
            Console.WriteLine($"decimal add: {deciAnswer}");
            Console.WriteLine($"Boolean add: {thirdAnswer}");
        }

        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public static decimal Add(decimal num1, decimal num2)
        {
            return num1 + num2;
        }

        public static string Add(int num1, int num2, bool isCheck)
        {
            var sum = num1 + num2;

            if (isCheck == true && sum > 1)
            {
                return $"{sum} dollars";
            }
            else if (isCheck == true && sum == 1)
            {
                return $"{sum} dollar";
            }
            else if (isCheck == true && sum < 1)
            {
                return $"{sum} dollars";
            }
            else
            {
                return $"False. Amount entered: {sum.ToString()}";
            }
        }
    }
}
