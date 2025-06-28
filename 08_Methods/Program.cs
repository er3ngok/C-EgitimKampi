namespace _08_Methods
{

    internal class Program
    {

        static void Main(string[] args)
        {

            #region Void Methodlar

            // Methodlar ikiye ayrılır.
            // Değer döndüren ve döndürmeyen
            // Methodlar --> () ile gösterilir
            // Customer --> Listele, ekle, sil, güncelle
            // Void --> Değer döndürmeyen method

            //void CustomerList()
            //{
            //    Console.WriteLine("Ali Yıldız");
            //    Console.WriteLine("Ayşe Yıldız");
            //    Console.WriteLine("Hakan Öztürk");
            //    Console.WriteLine("Merve Çınar");
            //}

            //CustomerList();

            //----------------------------------------------------

            //void Sum()
            //{
            //    int x = 1;
            //    int y = 2;
            //    int z = x + y;
            //    Console.WriteLine(z);
            //}

            //Sum();

            //----------------------------------------------------



            #endregion

            #region Geriye Değer Döndürmeyen String Parametreli Methodlar

            //void Print(string customerName)
            //{
            //    Console.WriteLine(customerName);
            //}

            //Print("Eren");

            //----------------------------------------------------

            //void customerCard(string name, string surname)
            //{
            //    Console.WriteLine("Müşteri: " + name + " " + surname);
            //}

            //customerCard("Eren", "Gök");

            #endregion

            #region Geriye Değer Döndürmeyen Int Parametleri Methodlar

            //void Sum(int number1, int number2, int number3)
            //{
            //    int result = number1 + number2 + number3;

            //    Console.WriteLine(result);
            //}

            //Sum(1, 3, 6);

            #endregion

            #region Geriye Değer Döndüren Methodlar

            //string CustomerName()
            //{
            //    return "Buse Yıldız";
            //}

            //CustomerName();

            //------------------------------------------------------

            //string StudentCard()
            //{
            //    string name = "Ali";
            //    string surname = "Kaya";

            //    return name + " " + surname;
            //}

            //Console.WriteLine(StudentCard());

            #endregion

            #region Geriye Değer Döndüren String Parametreli Methodlar

            //string CountryCard(string countryName, string capital, string flagColor)
            //{
            //    string cardInfo = "Ülke: " + countryName + " - Başkent: " + capital + " - Bayrak Rengi: " + flagColor;
            //    return cardInfo;
            //}

            //string x, y, z;

            //Console.Write("Ülke adını giriniz: ");
            //x = Console.ReadLine();

            //Console.Write("Başkenti giriniz: ");
            //y = Console.ReadLine();

            //Console.Write("Bayrak rengini giriniz: ");
            //z = Console.ReadLine();

            //Console.WriteLine(CountryCard(x, y, z));

            #endregion

            #region Geriye Değer Döndüren Int Parametreli Methodlar

            //int Sum(int num1, int num2)
            //{
            //    int result = num1 + num2;
            //    return result;
            //}

            //Console.WriteLine(Sum(4, 5));
            //Console.WriteLine(Sum(77, 8));

            #endregion

            #region Örnek Uygulama

            //string ExamResult(string student, int exam1, int exam2, int exam3)
            //{
            //    int result = (exam1 + exam2 + exam3) / 3;

            //    if (result >= 50)
            //    {
            //        return student + " isimli öğrenci sınavı geçti" + " Ortalaması: " + result;
            //    }
            //    else
            //    {
            //        return student + " isimli öğrenci başarısız oldu" + "Ortalaması: " + result;
            //    }
            //}

            //Console.WriteLine(ExamResult("Eren", 77, 75, 89));
            //Console.WriteLine(ExamResult("Ali", 25, 41, 85));

            #endregion

            Console.Read();

        }
    }
}