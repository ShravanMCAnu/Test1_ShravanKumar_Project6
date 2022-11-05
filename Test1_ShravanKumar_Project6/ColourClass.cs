using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1_ShravanKumar_Project6
{
    public class ColourClass
    {
      
        public void ColourPrinter(char choice)
        {
            switch (choice)
            {
                case 'V' or 'v':
                    Console.WriteLine("Violet");
                    break;
                case 'I' or 'i':
                    Console.WriteLine("Indigo");
                    break;
                case 'B' or 'b':
                    Console.WriteLine("Blue");
                    break;
                case 'G' or 'g':
                    Console.WriteLine("Green");
                    break;
                case 'Y' or 'y':
                    Console.WriteLine("Yellow");
                    break;
                case 'O' or 'o':
                    Console.WriteLine("Orange");
                    break;
                case 'R' or 'r':
                    Console.WriteLine("Red");
                    break;
            }
        }
       

    }
}
