using System;
using System.Collections.Generic;

namespace EsmaOdev
{
 
    internal class Program
    {
        private static string species;
        private static string age;
        private static string name;

        static void Main(string[] args)
        {
            
            /*
            List<Cat> kediler = new List<Cat>();  //Burada kedi adında bir liste oluşturduk. Bu listenin içine girdiğimiz kedileri listeleyecek.
            Console.Write("Kaç tane kedi oluşturmak istersiniz? ");
            int kediSayisi = int.Parse(Console.ReadLine());  // int parse int32 ile aynıdır yanı convert.toInt32 ile aynı.
            for (int i = 0; i < kediSayisi; i++)// sonra bir döngü oluşturduk kaç tane kedi ile ilgili değer girecekse ona göre konsolda çıkacak.
            {
                Console.Write("Kedinin adını girin: ");// kedinin adını yaşını türünü sırasıyla istedik.
                string name = Console.ReadLine();
                Console.Write("Kedinin yaşını girin: ");
                string age = Console.ReadLine();
                Console.Write("Kedinin Türünü Giriniz: ");
                string species = Console.ReadLine(); 
               
            }
            */
 
     
         //   List<Bird> kuslar = new List<Bird>();
            Console.Write("Kaç tane kuş oluşturmak istersiniz? ");
            int kusSayisi = int.Parse(Console.ReadLine());
            for (int i = 0; i < kusSayisi; i++)
            {
                Console.Write("Kuşun adını girin: ");
                string name = Console.ReadLine();
                Console.Write("Kuşun yaşını girin: ");
                string age = Console.ReadLine();
                Console.Write("Kedinin Türünü Giriniz: ");
                string species = Console.ReadLine();

                Bird bird = new Bird() { Age = age, Name = name, Species = species };
                Bird.Add(bird);
                Console.WriteLine(bird.SesCikar());
            }
            Bird.Birds.ForEach(x=> Console.WriteLine(x));



            List<Dog> kopekler = new List<Dog>();
            Console.Write("Kaç tane kuş oluşturmak istersiniz? ");
            int kopekSayisi = int.Parse(Console.ReadLine());
            for (int i = 0; i < kopekSayisi; i++)
            {
                Console.Write("Köpeğin adını girin: ");
                string name = Console.ReadLine();
                Console.Write("Köpeğin yaşını girin: ");
                string age = Console.ReadLine();
                Console.Write("Köpeğin Türünü Giriniz: ");
                string species = Console.ReadLine();
                
            }

        }
    }
}