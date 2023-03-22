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
            #region Task6.3
            /* 1-1000 qədər ədədlərin içərisindən  elə ədədləri çap etki :
                 həm özü cüt ədəd olsun,
                 həm rəqəmləri cəmi tək ədəd olsun,
                 həm 1-ci rəqəmi tək ədəd olsun. */
            //int sum, num1, num2, numDigit, firstNum;
            //for (int i = 1; i <= 1000; i++)
            //{
            //    num1 = i;
            //    if (num1 % 2 == 0) 
            //    {
            //        num2 = i; 
            //        sum = 0;
            //        while (num2 > 0)
            //        {
            //            sum += num2 % 10; 
            //            num2 /= 10;
            //        }
            //        if (sum % 2 == 1)
            //        {
            //            numDigit = (int)Math.Log10(i);
            //            firstNum = i / (int)Math.Pow(10, numDigit);
            //            if (firstNum % 2 == 1)
            //            {
            //                Console.WriteLine(i);
            //            }
            //        }
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
            //int temp1, temp2, digitSum, digit1, digit2;
            //for (int i = 1; i <= 100000; i++)
            //{
            //    bool allDigitsSame = true;
            //    temp1 = i;
            //    int lastDigit = temp1 % 10;
            //    while (temp1 > 0)
            //    {
            //          digit1 = temp1 % 10;
            //        if (digit1 != lastDigit)
            //        {
            //            allDigitsSame = false;
            //        }
            //        temp1 /= 10;
            //    }
            //l1:
            //    digitSum = 0;
            //    temp2 = i;
            //    while (temp2 > 0)
            //    {
            //        digit2 = temp2 % 10;
            //        if (digit2 == 5)
            //        {
            //            i++;
            //            goto l1;
            //        }
            //        digitSum += digit2;
            //        temp2 /= 10;
            //    }
            //    if (allDigitsSame && digitSum > 5)
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
            #region Task12.3
            //    for (int i = 1; i <= 100000; i++)
            //    {
            //        if (AllDigitsSame(i) && SumOfDigitsGreaterThan5(i) && NoDigitIs5(i))
            //        {
            //            Console.WriteLine(i);
            //        }
            //    }
            //}

            //static bool AllDigitsSame(int n)
            //{
            //    int lastDigit = n % 10;
            //    while (n > 0)
            //    {
            //        int digit = n % 10;
            //        if (digit != lastDigit)
            //        {
            //            return false;
            //        }
            //        n /= 10;
            //    }
            //    return true;
            //}

            //static bool SumOfDigitsGreaterThan5(int n)
            //{
            //    int sum = 0;
            //    while (n > 0)
            //    {
            //        sum += n % 10;
            //        n /= 10;
            //    }
            //    return sum > 5;
            //}

            //static bool NoDigitIs5(int n)
            //{
            //    while (n > 0)
            //    {
            //        int digit = n % 10;
            //        if (digit == 5)
            //        {
            //            return false;
            //        }
            //        n /= 10;
            //    }
            //    return true;
            #endregion
            #endregion
            #region Task13
            /* 13) 1-100000 qeder ederlerin icerisinden  ele ededleri cap etki :
                    hem butun reqemleri yalniz tek ededlerden ibaret olsun,
                    polindrom olsun,
                    daxilinde minimum 1 dene 5 reqemi olsun
             */
            //int sum, digit1, digit2, temp1, temp2, digitSum;
            //for (int i = 1; i <= 100000; i++)
            //{
            //l1:
            //    sum = 0;
            //    digitSum = 0;
            //    temp2 = i;
            //    while (temp2 > 0)
            //    {
            //        digit2 = temp2 % 10;
            //        if (digit2 % 2 == 0)
            //        {
            //            i++;
            //            goto l1;
            //        }
            //        digitSum += digit2;
            //        sum = sum * 10 + digit2;
            //        temp2 /= 10;
            //    }
            //    temp1 = i;
            //    bool hasFive = false;
            //    while (temp1 > 0)
            //    {
            //        digit1 = temp1 % 10;
            //        if (digit1 == 5)
            //        {
            //            hasFive = true;
            //            break;
            //        }
            //        temp1 /= 10;
            //    }
            //    if (i == sum && hasFive)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            #endregion
            #region Task14
            /* 14) 1-100000 qeder ederlerin icerisinden  ele ededleri cap etki :
                    hem ededin ozunun daxilinde minimum 2 dene 5 olsun,
                    hem ededin ozunun daxilinde 2 dene yanashi gelen 1 reqemi olsun
                    hem ededin reqemleri cemi 7- 15 arasinda olsun.
                    hem ededin reqemlerinin daxilinde 6 reqemi olmasin
             */

            //int digit1, digit2, digit3, temp1, temp2, temp3, digitSum, counter;
            //bool twoFive, twoOne;
            //for (int i = 1; i <= 100000; i++)
            //{
            //    counter = 0;
            //    twoFive = false;
            //    temp1 = i;
            //    while (temp1 > 0)
            //    {
            //        digit1 = temp1 % 10;
            //        if (digit1 == 5)
            //        {
            //            counter++;
            //            if (counter >= 2)
            //            {
            //                twoFive = true;
            //            }
            //        }
            //        temp1 /= 10;
            //    }
            //    temp2= i;
            //    twoOne= false;
            //    while (temp2 > 0)
            //    {
            //        digit2 = temp2 % 100;
            //        temp2 /= 10;
            //        if (digit2 == 11)
            //        {
            //            twoOne = true;
            //        }
            //    }
            //l1:
            //    digitSum = 0;
            //    temp3 = i;
            //    while (temp3 > 0)
            //    {
            //        digit3 = temp3 % 10;
            //        if (digit3 == 6)
            //        {
            //            i++;
            //            goto l1;
            //        }
            //        digitSum += digit3;
            //        temp3 /= 10;
            //    }
            //    if (digitSum > 7 && digitSum < 15 && twoFive & twoOne)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            #endregion
            #region Task15
            /* 15)* 1-10000 qeder ederlerin icerisinden  ele ededleri cap etki :
                    hem sade eded olsun
                    hem ededin ozunun daxilinde 0,1,5,7,9 reqemleri olmasin
                    hem ededin reqemleri ceminde 2 reqemi olmasin
             */

            //int temp, digit, sum;
            //int[] exclude = { 0, 1, 5, 7, 9 };

            //for (int i = 1; i < 10000; i++)
            //{
            //l1:
            //    sum = 0;
            //    if (i % 2 == 0 || (i % 3 == 0 && i != 3) || i % 5 == 0 || i % 7 == 0)
            //    {
            //        continue;
            //    }

            //    temp = i;
            //    while (temp > 0)
            //    {
            //        digit = temp % 10;

            //        if (Array.IndexOf(exclude, digit) != -1)
            //        {
            //            i++;
            //            goto l1;
            //        }

            //        sum += digit;
            //        temp /= 10;
            //    }

            //    while (sum > 0)
            //    {
            //        digit = sum % 10;
            //        if (digit == 2)
            //        {
            //            i++;
            //            goto l1;
            //        }
            //        sum /= 10;
            //    }
            //    Console.WriteLine(i);
            //}
            #endregion
        }
    }
}