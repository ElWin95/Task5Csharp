using System;

namespace ConsoleAppTask5Csharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task1
            /* 1) 1-1000 qeder ededlerin cemi 7 bolunurmu?
             */

            //int sum = 0;
            //for (int i = 1; i <= 1000; i++)
            //{
            //    sum += i;
            //}
            //if (sum % 7 == 0)
            //{
            //    Console.WriteLine("1-1000 qeder ededlerin cemi 7-e bolunur");
            //}
            //else
            //{
            //    Console.WriteLine("1-1000 qeder ededlerin cemi 7-e bolunmur");
            //}
            #endregion
            #region Task2
            /* 2) 1-1000 qeder ededlerin icerisinde hem 7-e, hemde 8-e bolunenlerin siyahisi
             */

            //for (int i = 1; i <= 1000; i++)
            //{
            //    if (i % 7 == 0 && i % 8 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }

            //}
            #endregion
            #region Task3
            /* 3) 1-1000 qeder ederlerin icerisinden  ele ededleri cap et ki, reqemleri cemi 3-e bolunsun
             */
            //for (int i = 1; i <= 1000; i++)
            //{
            //    if (i % 3 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            #endregion
            #region Task4
            /* 4) 1-1000 qeder ederlerin icerisinden ele ededleri cap etki reqemleri cemi 3 e bolunsun ve sonuncu reqem 3 olmasin.
             */
            //for (int i = 1; i <= 1000; i++)
            //{
            //    if (i % 3 == 0 && i % 10 != 3)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            #endregion
            #region Task5
            /* 5)  1-1000 qeder ededlerin icerisinden  ele ededleri cap etki : hem reqemleri cemi 5-e bolunsun, hem de ozu 5-e bolunsun
             */
            //int sum = 0;
            //for (int i = 1; i <= 1000; i++)
            //{
            //    int num = i;
            //    while (num > 0)
            //    {
            //        sum += (num % 10);
            //        num /= 10;
            //    }
            //    if (i % 5 == 0 && sum % 5 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            #endregion
            #region Task6
            #region Task6.1
            /* 6)  1-1000 qeder ederlerin icerisinden  ele ededleri cap etki :
                        hem ozu cut eded olsun,        
                        hem reqemleri cemi tek eded olsun,
                        hem I reqemi tek eded olsun
             */
            //for (int i = 1; i <= 1000; i++)
            //{
            //    int firstDigit = i / 100;
            //    int sumOfDigits = (i / 100) + ((i / 10) % 10) + (i % 10);

            //    if (i % 2 == 0 && sumOfDigits % 2 != 0 && firstDigit % 2 != 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            #endregion
            #region Task6.2
            //for (int i = 1; i <= 1000; i++)
            //{
            //    int sumOfDigits = 0;
            //    int num = i;
            //    while (num > 0)
            //    {
            //        sumOfDigits += num % 10;
            //        num /= 10;
            //    }
            //    int firstDigit = i / 100;
            //    if (i % 2 == 0 && sumOfDigits % 2 != 0 && firstDigit % 2 != 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            #endregion
            #endregion
            #region Task7
            /* 7)  1-1000 qeder ederlerin icerisinden  ele ededleri cap etki :
                    hemin ededin daxilinde 3 reqemi umumiyyetle olmasin
             */
            //for (int i = 1; i <= 1000; i++)
            //{
            //    bool hasThree = false;
            //    int num = i;
            //    while (num > 0)
            //    {
            //        if (num % 10 == 3)
            //        {
            //            hasThree = true;
            //            break;
            //        }
            //        num /= 10;
            //    }

            //    if (!hasThree)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            #endregion
        }
    }
}