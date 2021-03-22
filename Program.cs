using Encoder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringEncoding
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string ");
            string inputString = Console.ReadLine();
            EncoderProcessor encode = new EncoderProcessor();
            encode.Encode(inputString);
        }
    }
}
