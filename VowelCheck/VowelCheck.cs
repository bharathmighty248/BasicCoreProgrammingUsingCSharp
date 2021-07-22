using System;
using System.Collections.Generic;
using System.Text;

namespace VowelCheck
{
    class VowelCheck
    {
        public void VowelOrConsonant()
        {
            Console.WriteLine("Give the Character to Check");
            char alphabet = Convert.ToChar(Console.ReadLine());
            if (alphabet =='a' || alphabet == 'e' || alphabet == 'i' || alphabet == 'o' || alphabet == 'u')
                Console.WriteLine(alphabet + " is Vowel");
            else if (alphabet == 'A' || alphabet == 'E' || alphabet == 'I' || alphabet == 'O' || alphabet == 'U')
                Console.WriteLine(alphabet + " is Vowel");
            else
                Console.WriteLine(alphabet + " is Not Vowel, It is Consonant");
        }
    }
}
