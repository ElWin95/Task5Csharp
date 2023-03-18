using System;
using System.ComponentModel.DataAnnotations;

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
            ////Qeyd: eger eded 3 - e bolunurse, ededin reqemleri cemi de 3 - e bolunur.
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
            #region Task8
            /* 8)  1-1000 qeder ederlerin icerisinden, daxilinde 3 reqemi olmayib, reqemleri cemi 3 olan en sonuncu eded hansidir?
             */
            //int max = 0;
            //for (int i = 1; i <= 1000; i++)
            //{
            //    bool hasThree = false;
            //    int num1 = i;
            //    int num2 = i;
            //    while (num1 > 0)
            //    {
            //        if (num1 % 10 == 3)
            //        {
            //            hasThree = true;
            //            break;
            //        }
            //        num1 /= 10;
            //    }
            //    int sumOfDigits = 0;
            //    if (!hasThree)
            //    {
            //        while (num2 > 0)
            //        {
            //            sumOfDigits += num2 % 10;
            //            num2 /= 10;
            //        }
            //        if (sumOfDigits == 3)
            //        {
            //            if (i > max)
            //            {
            //                max = i;
            //            }
            //        }      
            //    }
            //}
            //Console.WriteLine($"Netice: {max}");
            #endregion
            #region Task9
            /* 9)  1-1000 qeder ederlerin icerisinde 11-e bolunub reqemleri cemi 11-den boyuk olan 11-ci eded hansidir?

             */
            //int num;
            //int sumOfDigits = 0;
            //int count = 0;
            //for (int i = 11; i <= 1000; i += 11)
            //{
            //   num = i;
            //   while (num > 0)
            //   {
            //      sumOfDigits += num % 10;
            //      num /= 10;
            //   }
            //   if (sumOfDigits > 11)
            //   {
            //       count++;
            //       if (count == 11)
            //       {
            //           Console.WriteLine(i);
            //           break;
            //       }
            //   }
            //    sumOfDigits = 0;
            //}
            #endregion
            #region Task10
            /* 10) 1-1000 qeder CUT ederlerin icerisinde reqemleri cemi 5 ile 7 arasinda olan en boyuk eded hansidir?
             */

            //int num, sumOfDigits;
            //int max = 0;
            //for (int i = 1; i <= 1000; i ++)
            //{
            //    sumOfDigits = 0;
            //    if (i % 2 == 0)
            //    {
            //        num = i;
            //        while (num > 0)
            //        {
            //            sumOfDigits += num % 10;
            //            num /= 10;
            //        }
            //        if (sumOfDigits > 5 && sumOfDigits < 7)
            //        {
            //            if (i > max)
            //            {
            //                max = i;
            //            }
            //        }
            //    }

            //}
            //Console.WriteLine(max);
            #endregion
            #region Task11
            /* 11) 1-1000 qeder ederlerin icerisinden  ele ededleri cap etki :
                     hem polindrom olsun,
                     hem ededin reqemleri daxilinde 3 olmasin
                     hem ededin reqemleri cemi 10 dan boyuk olsun
             */

            //int sum, digit, temp, digitSum;

            //for (int i = 1; i <= 1000; i++)
            //{
            //    l1:
            //    sum = 0;
            //    digitSum = 0;
            //    temp = i;
            //    while (temp > 0)
            //    {
            //        digit = temp % 10;
            //        if (digit == 3)
            //        {
            //            i++;
            //            goto l1;
            //        }
            //        digitSum += digit;
            //        sum = sum * 10 + digit;
            //        temp /= 10;
            //    }
            //    if (i == sum && digitSum > 10)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            #endregion
            #region Task12
            #region Task12.1
            /* 12) 1-100000 qeder ederlerin icerisinden  ele ededleri cap etki :
                    hem butun reqemleri eyni olsun,
                    hem reqemleri cemi 5 den boyuk olsun
                    hem reqemleri arasinda 5 reqemi olmasin    
             */

            int sum, digit, temp, temp2, digitSum, lastDigit;

            //for (int i = 1; i <= 100; i++)
            //{
            int i = 1111;
                bool allDigitsEquals = true;
                
                lastDigit = i % 10;
                i /= 10;
                while (i > 0)
                {
                    if (i % 10 != lastDigit)
                    {
                        allDigitsEquals= false;
                        break;
                    }
                    i /= 10;
                }
                Console.WriteLine(i);
            //l1:
            //    sum = 0;
            //    digitSum = 0;
            //    temp = i;
            //    while (temp > 0)
            //    {
            //        digit = temp % 10;
            //        if (digit == 5)
            //        {
            //            i++;
            //            goto l1;
            //        }
            //        digitSum += digit;
            //        sum = sum * 10 + digit;
            //        temp /= 10;
            //    }
            //    if (i == sum && digitSum > 5)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            #endregion
            #region Task12.2
            //for (int i = 1; i <= 100000; i++)
            //{
            //    // Ədədin bütün rəqəmləri eyni olsun şərtini yoxlayırıq
            //    bool allSameDigits = i.ToString().Distinct().Count() == 1;

            //    // Ədədin rəqəmləri cəmi 5-dən böyük olsun şərtini yoxlayırıq
            //    bool sumOfDigitsGreaterThan5 = i.ToString().Sum(digit => int.Parse(digit.ToString())) > 5;

            //    // Ədədin rəqəmləri arasında 5 rəqəmi olmasın şərtini yoxlayırıq
            //    bool doesNotContainDigit5 = !i.ToString().Contains("5");

            //    // Bütün şərtləri yoxlayırıq və uyğun ədədləri çap edirik
            //    if (allSameDigits && sumOfDigitsGreaterThan5 && doesNotContainDigit5)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            #endregion
            #endregion
        }
    }
}