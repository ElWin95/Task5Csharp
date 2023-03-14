namespace ConsoleAppTask5Csharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, numDigit;
            string strNum;
        L1:
            Console.Write("6 reqemli ededi daxil edin: ");
            strNum = Console.ReadLine();
            if (!int.TryParse(strNum, out num))
            {
                goto L1;
            }
            numDigit = (int)Math.Log10(num) + 1;
            if (numDigit > 8)
            {
                goto L1;
            }
        }
    }
}