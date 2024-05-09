using Konstruktörerövningar5inl;
using System;

namespace Konstruktorerövningar5inl
{
    class Program
    {
        static void Main(string[] args)
        {
            Fordon bil1 = new Fordon();
            bil1.setTillvärkare("Mazda");
            bil1.setModell("Cosmo");
            bil1.setÅr(1983);
            bil1.setVikt(1150);

            Fordon bil2 = new Fordon();
            bil2.setTillvärkare("Toyota");
            bil2.setModell("Chaser");
            bil2.setÅr(1989);
            bil2.setVikt(1280);

            Console.WriteLine(bil1);
            Console.WriteLine(bil2);
        }
    }
}