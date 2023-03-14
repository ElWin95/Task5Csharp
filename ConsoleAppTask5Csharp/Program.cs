namespace ConsoleAppTask5Csharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task1
            /* 1) 1-1000 qeder ededlerin cemi 7 bolunurmu?
             */

            int sum = 0;
            for (int i = 1; i <= 1000; i++)
            {
                sum += i;
            }
            Console.WriteLine(sum);
            if (sum % 7 == 0)
            {
                Console.WriteLine("1-1000 qeder ededlerin cemi 7-e bolunur");
            }
            else
            {
                Console.WriteLine("1-1000 qeder ededlerin cemi 7-e bolunmur");
            }
            #endregion


        }
    }
}