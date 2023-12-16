using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Media;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task00
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            //SoundPlayer player01 = new SoundPlayer(@"I:\C#\API KAYAN\Lecture 3\Biano.wav");
            //player01.PlayLooping();
            //Thread.Sleep(2000);
            //string FirstName = "Moohamed";
            //string SecondName = "Shoaib";
            //string FullName;
            //FullName = string.Concat(FirstName, " ", SecondName);
            //Console.WriteLine(FullName);

            //string firstMessage = "Hallo world";
            //string worldword = firstMessage.Substring(0, 5);
            //Console.WriteLine(worldword);

            //string days = "Welcome Mr Mohamed Iam so happy to help you";
            //string[] AllText = days.Split(' ');
            //foreach (string text in AllText)
            //{
            //    Console.SetCursorPosition(88, 22);
            //    foreach (char c in text)
            //    {
            //        Console.Write(c + " ");
            //        Console.Beep(5900, 100);

            //    }
            //    Thread.Sleep(500);
            //    Console.SetCursorPosition(88, 22);
            //    Console.Write(" ************** ");
            //}

            //string Sentence = " hi mr mohamed iam your copilot here you ca,n tell me what do you want";

            //Console.WriteLine(Sentence);
            //string newstring = Sentence.Replace("mohamed", "**********");
            //Console.WriteLine(newstring);

            //string oldtext = "Hi mr mohamed";
            //Console.WriteLine(oldtext.ToLower());
            //Console.WriteLine(oldtext.ToUpper());
            //bool check = oldtext.Contains("Hi");
            //Console.WriteLine(oldtext);
            //Console.WriteLine(check);

            //string UserName = WindowsIdentity.GetCurrent().Name;
            //string UserName2 = Environment.UserName;
            //Console.WriteLine(UserName);
            //Console.WriteLine(UserName2);

            //Console.WriteLine("Write any number");
            //string stringNum = Console.ReadLine();
            //Console.WriteLine(stringNum+6);
            //int realNum = int.Parse(stringNum);
            //Console.WriteLine(realNum + 6);

            string UserPhrase01 = Console.ReadLine();
            string UserPhrase02 = UserPhrase01.ToLower();
            string Vowels = "aeiou";
            char[] chars = UserPhrase01.ToCharArray();
            int i = 0 ;
            int e = 0 ;
            
            foreach (char c in chars)
            {
                bool check = (c == 'a' || c == 'i' || c == 'e' || c == 'o' || c == 'u');
                if (check == true) { i++; }
                
            }
            
            foreach (char c01 in Vowels)
            {
                bool check01 = UserPhrase02.Contains(c01);
                if (check01 == true) { e++;}
            }
            Console.WriteLine($"Your word contain {i} vowels in tottal and contain {e} in unique");







        }
    }
}
