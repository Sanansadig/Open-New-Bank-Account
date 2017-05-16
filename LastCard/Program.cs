
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LastCard
{
    class Program
    {
        static void Main(string[] args)
        {
            OldCard cardOld = new OldCard();
            Console.WriteLine("\n" + "Esas kartiniz haqda melumatlar" + "\n" + "Name :" + cardOld.Name + "\n" + "Surname :" + cardOld.Surname + "\n" +
            "CardNumber :" + cardOld.CardNumber + "\n" + "Secure Number : " +
            cardOld.SecureNumber + "\n" + "Month :" + cardOld.Month + "\n" + "Money in Card :" + cardOld.Amount + "\n" + "Year :" + cardOld.Year);

            Random rnd = new Random();
            int a1 = rnd.Next(0, 10);
            int a2 = rnd.Next(0, 10);
            int a3 = rnd.Next(0, 10);
            int a4 = rnd.Next(0, 10);
            int a5 = rnd.Next(0, 10);
            int a6 = rnd.Next(0, 10);
            int a7 = rnd.Next(0, 10);
            int a8 = rnd.Next(0, 10);
            int a9 = rnd.Next(0, 10);
            int a10 = rnd.Next(0, 10);
            int a11 = rnd.Next(0, 10);
            int a12 = rnd.Next(0, 10);
            int a13 = rnd.Next(0, 10);
            int a14 = rnd.Next(0, 10);
            string tCardNumber = "f";

            NewCard sas = new NewCard(a1, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12, a13, a14, tCardNumber);
             
            Console.WriteLine("\n" + "\n" + "..................  Yeni kart acilmasi ucun bu melumatlari daxil edin   ...............");

            Console.WriteLine("\n" + "\n" + "Yeni kartda gormek istediyiniz adi daxil edin");
            sas.Name = Console.ReadLine();
            Console.WriteLine("Yeni kartda gormek istediyiniz soyadi daxil edin");
            sas.Surname = Console.ReadLine();
            Console.WriteLine("Yeni kartda kocureceyiniz meblegi daxil edin");
            sas.Amount = Convert.ToInt64(Console.ReadLine());

            if(cardOld.Year>=sas.Year)
            {
                Console.WriteLine("Yeni kartin hansi ile qeder etibarli olasini daxil edin");
                sas.Year = Convert.ToInt32(Console.ReadLine());
            }
            else
            {
                Console.WriteLine("Yeni kartin son istifade ili esas karta olan ilden yuxari ola bilmez, xahis edirik tezeden daxil edin");
                sas.Year = Convert.ToInt32(Console.ReadLine());
            }
            if (cardOld.Month >= sas.Month)
            {
                Console.WriteLine("Yeni kartin hansi aya qeder etibarli olasini daxil edin");
                sas.Month = Convert.ToInt16(Console.ReadLine());
            }
            else
            {
                Console.WriteLine("Yeni kartin son istifade ayi esas karta olan ilden yuxari ola bilmez, xahis edirik tezeden daxil edin");
                sas.Year = Convert.ToInt32(Console.ReadLine());
            }
            int f1 = rnd.Next(0, 10);
            int f2 = rnd.Next(0, 10);
            int f3 = rnd.Next(0, 10);
            string totalCode = "a";

            double restMoney = cardOld.Amount - sas.Amount;

            SecureCode secure = new SecureCode(f1, f2, f3, totalCode);
            Console.WriteLine("\n" + "Yeni kartda adiniz: " + sas.Name +"\n" + "Yeni kartda soyadiniz: " + sas.Surname + "\n" + "Yeni kartda olan pul: " + sas.Amount + "\n" + "Esas kartda qalan pul: " + restMoney + "\n" + "Yeni kartin son istifade ili: " + sas.Year + "\n" + "Yeni kartin son istifade ayi: " + sas.Month + "\n"+ "Yeni kartin nomresi: " + sas.ACardNumber +"\n" + "Yeni kartda tehlukesizlik kodu: " + secure.Scode);
            Console.ReadLine();

        }
    }
}
