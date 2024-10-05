using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Double Variables
            ////double number;
            ////number = 3.1234;
            ////Console.WriteLine(number);
            ////Console.WriteLine();

            //Console.WriteLine("***Fiyat Listesi***");
            //Console.WriteLine();

            //double bananaPrice, apricotPrice, peachPrice, tomatoPrice;

            //bananaPrice = 35.49;
            //apricotPrice = 18.75;
            //peachPrice = 21.99;
            //tomatoPrice = 15.25;
            //Console.WriteLine("-----Muz Fiyatı:" + bananaPrice + "TL");
            //Console.WriteLine("-----Kayısı Fiyatı:" + apricotPrice + "TL");
            //Console.WriteLine("-----Şeftali Fiyatı:" + peachPrice + "TL");
            //Console.WriteLine("-----Domates0 Fiyatı:" +tomatoPrice  + "TL");

            //double bananaGram, apricotGram, peachGram, tomatoGram;

            //bananaGram = 1.232;
            //apricotGram = 2.765;
            //peachGram = 0.985;
            //tomatoGram = 4.123;

            //double bananaTotalPrice, apricotTotalPrice, peachTotalPrice, tomatoTotalPrice;
            //bananaTotalPrice = bananaGram * bananaPrice;
            //apricotTotalPrice= apricotGram * apricotPrice;
            //peachTotalPrice = peachGram * peachPrice;
            //tomatoTotalPrice = tomatoGram * tomatoPrice;

            //Console.WriteLine();
            //Console.WriteLine();


            //Console.WriteLine("Alınan Ürün: Muz -" + "Birim Fiyatı: " + bananaPrice + "-Gramaj:" + bananaGram + "-Ürün Fiyatı=" +bananaTotalPrice +"TL");
            //Console.WriteLine("Alınan Ürün: Kayısı -" + "Birim Fiyatı: " + apricotPrice + "-Gramaj:" + apricotGram + "-Ürün Fiyatı=" +apricotTotalPrice +"TL");
            //Console.WriteLine("Alınan Ürün: Şeftali -" + "Birim Fiyatı: " + peachPrice + "-Gramaj:" + peachGram + "-Ürün Fiyatı=" + peachTotalPrice + "TL");
            //Console.WriteLine("Alınan Ürün: Domates -" + "Birim Fiyatı: " + tomatoPrice + "-Gramaj:" + tomatoGram + "-Ürün Fiyatı=" + tomatoTotalPrice + "TL");
            //Console.WriteLine() ;
            //Console.WriteLine() ;

            //double shoppingTotalPrice = bananaTotalPrice + apricotTotalPrice + peachTotalPrice + tomatoTotalPrice;
            //Console.WriteLine("Alışveriş Tutarı="+shoppingTotalPrice+"TL") ;




            #endregion

            #region String Process With On The Keyboard

            //Console.WriteLine("***Ali Güler Airlines Passenger Informations***");
            //Console.WriteLine();
            //Console.WriteLine();

            //string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge, passengerGender, passengerIdentyNumber;

            //Console.Write("Passenger Name:");
            //passengerName = Console.ReadLine();
            //Console.Write("Passenger Surname:");
            //passengerSurname = Console.ReadLine();
            //Console.Write("Passenger District:");
            //passengerDistrict = Console.ReadLine();
            //Console.Write("Passenger City:");
            //passengerCity = Console.ReadLine();
            //Console.Write("Passenger Age:");
            //passengerAge = Console.ReadLine();
            //Console.Write("Passenger Gender:");
            //passengerGender = Console.ReadLine();
            //Console.Write("Passenger Identy Number:");
            //passengerIdentyNumber = Console.ReadLine();

            //Console.WriteLine("-------------------------");
            //Console.WriteLine("Passenger Information:\n" + "Name:" + passengerName + "\n" + "Surname:" + passengerSurname + "\n"
            //    + "District:" + passengerDistrict + "\n" + "City:" + passengerCity + "\n"
            //    + "Age:" + passengerAge + "\n" + "Gender:" + passengerGender + "\n"
            //    + "Identy Number:" + passengerIdentyNumber);


            #endregion

            #region Int Process With On The Keyboard

            //int shoesPrices, computerPrices, chairPrices, tvPrices;
            //shoesPrices = 1000;
            //computerPrices = 23000;
            //chairPrices = 750;
            //tvPrices = 15000;

            //int shoesCount, computerCount, chairCount, tvCount;

            //Console.WriteLine("Alınan ayakkabı sayısını giriniz");
            //shoesCount = int.Parse(Console.ReadLine());
            //Console.WriteLine("Alınan bilgisayar sayısını giriniz");
            //computerCount = int.Parse(Console.ReadLine()); 
            //Console.WriteLine("Alınan sandalye sayısını giriniz");
            //chairCount = int.Parse(Console.ReadLine());
            //Console.WriteLine("Alınan televizyon sayısını giriniz");
            //tvCount = int.Parse(Console.ReadLine());

            //Console.WriteLine();
            //int toplamTutar = shoesCount*shoesPrices + computerCount*computerPrices + chairCount*chairPrices+ tvPrices*tvCount;
            //Console.WriteLine();
            //Console.WriteLine("Toplam ödenmesi gereken tutar:" + toplamTutar);

            #endregion

            #region Double Variables With On The Keyboard

            //double exam1, exam2, exam3, result;

            //Console.WriteLine("1.sınav notunu giriniz:");
            //exam1 = double.Parse(Console.ReadLine());
            //Console.WriteLine("2.sınav notunu giriniz:");
            //exam2 = double.Parse(Console.ReadLine());
            //Console.WriteLine("3.sınav notunu giriniz:");
            //exam3 = double.Parse(Console.ReadLine());

            //result = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine();
            //Console.WriteLine("Sınav Ortalaması:" + result);

            #endregion

            #region Char Variables With On The Keyboard

            //char gender;
            //Console.WriteLine("Cİnsiyet seçiniz:");
            //gender = char.Parse(Console.ReadLine());

            //Console.WriteLine("Seçtiğiniz Cinsiyet:" + gender);

            #endregion

            Console.Read(); 
        }
    }
}
