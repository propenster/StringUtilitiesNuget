using System;
using System.Collections.Generic;
using System.Text;

namespace MyVeryFirstNugetPackage
{

    public class Program
    {

        public static void Main(String[] args)
        {
            string text = "My name is Faith Emmanuel Olusegun (v1) onpoint";

            string slugified = StringUtilities.Slugify(text);
            Console.WriteLine("Slugified string = " + slugified);
        }
    }
}
