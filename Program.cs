/****************************************************************************
**                        SAKARYA ÜNİVERSİTESİ                             **
**              BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ                  **   
**                BİLİŞİM SİSTEMLERİ MÜHENDİSLİĞİ BÖLÜMÜ                   **
**                   NESNEYE DAYALI PROGRAMLAMA DERSİ                      **
**                        2019-2020 BAHAR DÖNEMİ                           **
**                                                                         **
**        ÖDEV NUMARASI..........:  1                                      **
**        ÖĞRENCİ ADI............:  Sedat Sami TÜRKOĞLU                    **
**        ÖĞRENCİ NUMARASI.......:  B191200057                             **
**        DERSİN ALINDIĞI GRUP...:                                         **
**                                                                         **
 ***************************************************************************/


using System;


namespace rehber

{

    class Program

    {

        static void KisilerimiGoruntule(string[] array)              //kişi görüntüleme metodu oluşturuyoruz.
        {
            int deger = 7;
            Console.WriteLine(" 1- Ahmet Emre Şahin\n 2- Atahan Çakır\n 3- Burak Yılmaz\n 4- Canan Karatay\n 5- Davut Davutoğlu\n 6- Deniz Akyürek");



            for (int i = 1; i < array.Length; i++)          //az sonra ekleyeceğimiz yeni kişilerin halihazırdaki kişilere sıradan ekleniyor.
            {
                if (array[i] != null)
                {
                    Console.WriteLine(" {0}- {1}", deger, array[i]);
                    deger++;
                }
            }


            Console.WriteLine("Lutfen görüntülemek istediginiz kisinin sıra numarasını giriniz");

            string sırano = Console.ReadLine();

            if (sırano == "1")                            //kayıtlı kişilerin olabilmesi için kişiler oluşturuluyor.
            {
                Console.WriteLine(" Ahmet Emre Şahin \n\n Telefonu: 0514 141 23 45\n\n Mail Adresi: aemresahinn@gmail.com ");
                Console.ReadLine();
            }

            if (sırano == "2")
            {
                Console.WriteLine(" Atahan Çakır \n\n Telefonu: 0512 121 22 42\n\n Mail Adresi: a.cakir17@gmail.com ");
                Console.ReadLine();
            }

            if (sırano == "3")
            {
                Console.WriteLine("Burak Yılmaz \n\n Telefonu: 0532 111 13 05\n\n Mail Adresi: yilmazburak@gmail.com ");
                Console.ReadLine();
            }

            if (sırano == "4")
            {
                Console.WriteLine("Canan Karatay \n\n Telefonu: 0584 241 67 45\n\n Mail Adresi: canan.k.tay@gmail.com ");
                Console.ReadLine();
            }

            if (sırano == "5")
            {
                Console.WriteLine("Davut Davutoğlu \n\n Telefonu: 0574 341 53 25\n\n Mail Adresi: Davutdavutoglu@gmail.com ");
                Console.ReadLine();
            }

            if (sırano == "6")
            {
                Console.WriteLine("Deniz Akyürek \n\n Telefonu: 0564 456 34 98\n\n Mail Adresi: Denizakyurek.16@gmail.com ");
                Console.ReadLine();
            }

            Console.ReadLine();
        }

        static void YeniKisiEkle(string[] isimler, string[] telefonlar, string[] mailler)
        {

            //yeni kişi eklemek için metod oluşturuyoruz.
            Console.Clear();
            //isimler telefonlar ve mailler adında 3 string dizisi oluşturuyoruz.
            Console.WriteLine("-----Kayıt Ekranı-----");

            Console.WriteLine("----------------------");

            for (int i = 1; i < 3; i++)
            //bu for döngüsünde yeni ekleyeceğimiz 3 adet kişinin bilgilerini alıyoruz kullanıcıdan.       
            {

                Console.Write(i + ". Kişinin Adı - Soyadı = ");

                isimler[i] = Console.ReadLine();

                Console.Write(i + 1 + ". Kişinin Telefonu = ");

                telefonlar[i] = Console.ReadLine();

                Console.Write(i + 1 + ". Kişinin E Mail Adresi = ");

                mailler[i] = Console.ReadLine();

            }
        }


        static void Arama(string[] isim, string[] telefon, string[] mail)
        {
            do

            {                                                           //burada arama metodu oluşturup yeni oluşturduğumuz kişiler içinde arama yapıyoruz.

                Console.Clear();

                Console.WriteLine("*** Arama Ekranı ***");

                Console.WriteLine("----------------------");

                Console.Write("Aranan Kişinin Adı - Soyadı = ");

                string aranan = Console.ReadLine();                    //aranan kişinin bilgileri alınıyor.                         

                int sonuc = Array.IndexOf(isim, aranan);               //ve aranan kişi daha önce oluşturduğumuz kişiler içinde kontrol ediliyor.

                if (sonuc > 0)

                {

                    Console.WriteLine("Aradığınız Kişinin Telefonu = " + telefon[sonuc]);       //eğer doğru koşul sağlanırsa yani isim bulunursa kişi bilgileri ekrana basılır.

                    Console.WriteLine("Aradığınız Kişinin E Mail Adresi = " + mail[sonuc]);

                }

                else Console.Write("Aramaya kişi bulunamadı !\n");                              //bulunamazsa sonlanır ve yeni işlem için soru sorulur kullanıcıya.

                Console.Write("Aramaya Devam mı (E / H )");

                string girilen = Console.ReadLine().ToUpper();

                if (girilen == "H") break;

            } while (true);

        }

        static void Main(string[] args)              //Main fonksiyonu içinde işlemlere devam ediyoruz.

        {

            string[] isim = new string[10];                                                 //yeni diziler oluşturuluyor.

            string[] telefon = new string[10];

            string[] mail = new string[10];

            while (true)

            {

                Console.Clear();

                Console.Write(" 1- Kişilerimi Görüntüle \n 2- Yeni Kişi Ekle \n 3- Arama \n 4- Çıkış \n Seçiminiz - ");

                string secim = Console.ReadLine();

                if (secim == "1")
                {
                    KisilerimiGoruntule(isim);         //if bloklarının koşullarına göre yukarıdaki metodlar çalıştırılıyor.
                }

                if (secim == "2")

                {

                    YeniKisiEkle(isim, telefon, mail);

                }

                if (secim == "3")
                {

                    Arama(isim, telefon, mail);
                }

                if (secim == "4")

                {

                    break;

                }

            }

        }

    }

}