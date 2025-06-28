namespace _07_ForEachLoops
{

    internal class Program
    {

        static void Main(string[] args)
        {

            #region For Each Loops

            // For Each Döngüsü 4 parametreye sahiptir (1; 2; 3; 4)

            // 1: Değişken Türü
            // 2: Değişken Adı
            // 3: In
            // 4: Liste, Koleksiyon, Dizi

            //string[] cities = { "Milano", "Roma", "Budapest", "Ankara", "Istanbul", "Warsaw" };

            //foreach (string x in cities)
            //{
            //    Console.WriteLine(x);
            //}

            //----------------------------------------------------

            //int[] numbers = { 45, 78, 985, 635, 74, 11, 22, 33, 41, 205, 6578, 10394 };

            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            //----------------------------------------------------

            //int[] numbers = { 45, 78, 985, 635, 74, 11, 22, 33, 41, 205, 6578, 10394 };

            //foreach (int number in numbers)
            //{
            //    if (number % 2 == 0)
            //    {
            //        Console.WriteLine(number);
            //    }
            //}

            //----------------------------------------------------

            //int[] numbers = { 45, 78, 985, 635, 74, 11, 22, 33, 41, 205, 6578, 10394 };

            //int total = 0;

            //foreach (int i in numbers)
            //{
            //    total += i;
            //}

            //Console.WriteLine(total);

            //----------------------------------------------------

            //List<int> numbers = new List<int>()
            //{
            //    1, 2, 3, 4, 5, 8
            //};

            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(numbers);
            //}

            //----------------------------------------------------

            //string word = "Merhaba";

            //foreach (char c in word)
            //{
            //    Console.WriteLine(c);
            //}

            #endregion

            #region Örnek Sınav Sistemi Uygulaması

            /*

            Console.Write("***** C# Eğitim Kampı Sınav Uygulaması *****");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            // Sınıftaki Öğrenci Sayısını Kullanıcıdan Alma
            Console.WriteLine("---------------------------");
            Console.Write("Sınıftaki öğrenci sayısı: ");
            int studentCount = int.Parse(Console.ReadLine());
            Console.WriteLine("---------------------------");

            // Öğrenci İsimlerini ve Not Ort. Saklayacak Diziler
            string[] studentNames = new string[studentCount];
            double[] studentExamAvg = new double[studentCount];

            for (int i = 0; i < studentCount; i++)
            {
                Console.Write($"{i + 1}. Öğrencinin ismini giriniz: ");
                studentNames[i] = Console.ReadLine();

                double totalExamResult = 0;

                // Her öğrenci için 3 sınav notu girişi

                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{studentNames[i]} isimli öğrencinin {j + 1}. sınav notunu giriniz: ");
                    double value = double.Parse(Console.ReadLine());
                    totalExamResult += value; // Notları topluyoruz
                }
                Console.WriteLine();

                studentExamAvg[i] = totalExamResult / 3;
            }

            // Öğrencilerin Ortalaması ve Geçip Kalma Durumları

            for (int i = 0; i < studentCount; i++)
            {
                Console.WriteLine($"{studentNames[i]} isimli öğrencinin ortalaması: {studentExamAvg[i]}");

                // Öğrencilerin Geçip / Kalma Durumları

                if (studentExamAvg[i] >= 50)
                {
                    Console.WriteLine($"{studentNames[i]} isimli öğrenci dersi geçti.");
                }
                else
                {
                    Console.WriteLine($"{studentNames[i]} isimli öğrenci dersten kaldı.");
                }

                Console.WriteLine("----------------------------------------------");
            }

            */

            #endregion

            Console.Read();
        }
    }
}