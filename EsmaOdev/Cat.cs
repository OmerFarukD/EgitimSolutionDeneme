

using System;

namespace EsmaOdev
{
    public class Cat: Animals
    {
        
        internal static void Add(Cat cat)
        {
            throw new NotImplementedException();
        }

        public override string SesCikar() // ses çıkar metodunu ezdik burada çünkü her sınıfta farklı bir ses çıkarıyor.
        {
            return "Miyav!";
        }
    }
}
