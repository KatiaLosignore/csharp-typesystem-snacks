﻿// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


// Snack 1: L’utente inserisce due numeri in successione. Il software stampa il maggiore.

Console.WriteLine("Inserisci il primo numero:");

int numero1 = int.Parse(Console.ReadLine());

Console.WriteLine("Inserisci il secondo numero:");

int numero2 = int.Parse(Console.ReadLine());

if (numero1 > numero2)
{
    Console.WriteLine($"Il primo numero è maggiore: {numero1}");
} else if (numero1 == numero2)
{
    Console.WriteLine("I due numeri sono uguali!");
} else 
{
    Console.WriteLine($"Il secondo numero è maggiore: {numero2}");
}

Console.WriteLine("------------------------------------------------------");
// Snack 2 : L’utente inserisce due parole in successione. Il software stampa prima la parola più corta, poi la parola più lunga.

Console.WriteLine("Inserisci la prima parola:");

string parola1 = Console.ReadLine();

Console.WriteLine("Inserisci la seconda parola:");

string parola2 = Console.ReadLine();

if (parola1.Length < parola2.Length)
{
    Console.WriteLine($"La parola più corta è {parola1}");
    Console.WriteLine($"La parola più lunga è {parola2}");
} else if (parola1.Length == parola2.Length)
{
    Console.WriteLine($"Le due parole hanno la stessa lunghezza");
} else
{
    Console.WriteLine($"La parola più corta è {parola2}");
    Console.WriteLine($"La parola più lunga è {parola1}");
}

Console.WriteLine("------------------------------------------------------");
// Snack 3: Il software deve chiedere per 10 volte all’utente di inserire un numero. Il programma stampa la somma di tutti i numeri inseriti.

int sommaNumeri = 0;

for (int i = 0; i < 10; i++)
{
    Console.WriteLine("Inserisci un numero:");
    sommaNumeri += int.Parse(Console.ReadLine());
}

Console.WriteLine($"La somma di tutti i numeri inseriti è: {sommaNumeri}");

