using System;

namespace Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new User("Azer", 12345) ;
            Console.WriteLine(user.full);
            Admin admin = new Admin(true, 23);
            Console.WriteLine(admin.Manager);
        }
    }
}
