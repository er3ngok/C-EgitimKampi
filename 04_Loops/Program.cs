﻿namespace _04_Loops
{
    internal class Program
    {

        static void Main(string[] args)
        {
            #region For Loop

            // Döngüler

            // For (x;y;z)

            //x : başlangıç
            //y : bitiş
            //z : artış - azalış miktarı

            //int i;

            //for (i = 1; i <= 5; i++)
            //{
            //    Console.WriteLine("C# Eğitim Kampı");
            //}

            //----------------------------------------------------

            //for (int i = 0; i <= 20; i++)
            //{
            //    Console.WriteLine(i);

            //}

            //----------------------------------------------------

            //for (int i = 3; i <= 50; i+=3)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.Write("Lütfen ekrana yazılmasını istediğiniz adedi giriniz: ");
            //int finishValue = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= finishValue; i++)
            //{
            //    Console.WriteLine("Yaşasın Cumhuriyet");
            //}



            #endregion

            #region For Loop'u ile Karar Yapıları

            //----------------------------------------------------

            //for (int i = 0; i <= 100; i++)
            //{
            //    if (i % 5 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //----------------------------------------------------

            //int totalValue = 0;

            //for (int i = 1; i <= 10; i++)
            //{
            //    totalValue += i;

            //}

            //Console.WriteLine(totalValue);

            //----------------------------------------------------

            //int totalValue = 0;

            //for (int i = 1; i <= 20; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        totalValue += i;
            //        Console.WriteLine(i);
            //    }

            //}

            //Console.WriteLine("-------");
            //Console.WriteLine(totalValue);

            //----------------------------------------------------

            //int count = 0;

            //for (int i = 1; i <= 50; i++)
            //{
            //    if (i % 7 == 0)
            //    {
            //        count++;
            //    }
            //}

            //Console.WriteLine(count);

            //----------------------------------------------------

            //int bacteria = 1;

            //for (int i = 1; i <= 24; i++)
            //{
            //    bacteria *= 2;
            //    Console.WriteLine(i + ". Saat Sonunda: " + bacteria);
            //}




            #endregion

            #region While Loop

            //int i = 1;

            //while (i <= 10)
            //{
            //    Console.WriteLine("Merhaba Döngüler");
            //    i++;
            //}

            //----------------------------------------------------

            //int i = 1;

            //while (i <= 10)
            //{
            //    if (i % 3 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    i++;
            //}

            //----------------------------------------------------

            //int i = 1;

            //int sum = 0;

            //while (i <= 10)
            //{
            //    sum += i;
            //    i++;
            //}

            //Console.WriteLine(sum);

            //----------------------------------------------------

            #endregion

            #region Example Questions

            // Klavyeden girilen 3 basamaklı sayının basamakları toplamını hesaplayan kodu yazınız.

            //Console.WriteLine("Lütfen sayıyı giriniz: ");
            //int number = int.Parse(Console.ReadLine());

            //int ones, tens, hundreds;

            //int sum;

            //ones = number % 10;
            //tens = (number % 100) / 10;
            //hundreds = number / 100;

            //Console.WriteLine(hundreds + "-" + tens + "-" + ones);

            //sum = hundreds + tens + ones;

            //Console.WriteLine(sum);

            //----------------------------------------------------


            #endregion

            Console.Read();
        }
    }
}