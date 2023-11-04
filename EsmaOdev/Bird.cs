
using System;
using System.Collections.Generic;

namespace EsmaOdev
{
    public class Bird : Animals // Animal sınıfından kalıtım aldık.
    {

        public static List<Bird> Birds { get; set; } = new List<Bird>();

        public static void Add(Bird bird)
        {
           Birds.Add(bird);
        }

        public override string SesCikar()// ses çıkar metodunu ezdik burada çünkü her sınıfta farklı bir ses çıkarıyor.
        {
            return "Cik Cik!";
        }

        public override string ToString()
        {
            return $"Adı : {Name}, Yaşı : {Age}, Türü : {Species}";
        }
    }
}
