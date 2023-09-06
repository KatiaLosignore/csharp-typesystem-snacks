// See https://aka.ms/new-console-template for more information
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
