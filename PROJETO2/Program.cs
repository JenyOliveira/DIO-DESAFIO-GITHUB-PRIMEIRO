using System;
using PROJETO2.src.Entities;

class Program
{
    static void Main(string[] args) 
    {
        Knight arus = new Knight("Arus", 23, "Knight");
        Wizard wizard = new Wizard("Jennica", 23, "White Wizard");
        Ninja wedge = new Ninja("Wedge", 23, "Ninja");
        Wizard topapa = new Wizard("Topapa", 23, "Black Wizard");
        

        Console.WriteLine(wizard.Attack(1));
        Console.WriteLine(wizard.Attack(7));
        Console.WriteLine(wedge.Attack());
        Console.WriteLine(topapa.Attack());
        Console.WriteLine(arus.Attack());

    }
}

