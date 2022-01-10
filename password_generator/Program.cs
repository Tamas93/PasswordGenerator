using System;
using System.Text;

namespace password_generator
{
    class Program
    {
        static string Passworld(int x)
        {
            Random rnd = new Random();
            string chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            StringBuilder build = new StringBuilder();

            while(0 < x)
            {
                build.Append(chars[rnd.Next(chars.Length)]);
                x--;
            }
            return build.ToString();
        }
        static void Main(string[] args)
        {

            Console.Write("Hello, Ez egy random jelszó generátor program!\nKérlek Add meg hogy hány jegyből álljon a jelszó:");
            int a = int.Parse(Console.ReadLine());
            string password = Passworld(a);
            Console.WriteLine("A jelszód: {0}",password);

            Console.ReadKey();
        }
        
    }
   
}
