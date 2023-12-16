using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task00
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string FirstName = "Moohamed";
            string SecondName = "Shoaib";
            string FullName;
            FullName = string.Concat(FirstName, " ", SecondName);
            Console.WriteLine(FullName);

            string firstMessage = "Hallo world";
            string worldword = firstMessage.Substring(0, 5);
            Console.WriteLine(worldword);

            string days = "Welcome Mr Mohamed Iam so happy to help you";
            string[] AllText = days.Split(' ');
            foreach (string text in AllText)
            {
                Console.SetCursorPosition(88, 22);
                foreach (char c in text)
                {
                    Console.Write(c + " ");
                    Console.Beep(5900, 100);
                    
                }
                Thread.Sleep(500);
                Console.SetCursorPosition(88, 22);
                Console.Write(" ************** ");
            }
            Console.ReadKey();
            
            
            Console.WriteLine("122");
            Console.WriteLine("122");
            Console.WriteLine("122");
            Console.WriteLine("122");
            Console.WriteLine("123");
            Console.WriteLine("122");
            Console.WriteLine("final");
            Console.WriteLine("Yahoo");

        }
    }
}
