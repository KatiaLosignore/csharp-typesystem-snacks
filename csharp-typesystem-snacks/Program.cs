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

Console.WriteLine("------------------------------------------------------");
// Snack 4: Calcola la somma e la media dei numeri da 2 a 10.

int[] numeri = { 2, 3, 4, 5 , 6, 7, 8, 9, 10 };

int somma = 0;

for (int i = 0; i < numeri.Length; i++)
{
    somma += numeri[i];
}

float mediaNumeri = (float)somma / numeri.Length;

Console.WriteLine($"La somma dei numeri è: {somma}");

Console.WriteLine($"La media dei numeri è: {mediaNumeri}");

Console.WriteLine("------------------------------------------------------");
// Snack 5: Il software chiede all’utente di inserire un numero. Se il numero inserito è pari, stampa il numero, se è dispari, stampa il numero successivo.

Console.WriteLine("Inserisci un numero:");

int numInserito = int.Parse(Console.ReadLine());

if (numInserito % 2 == 0)
{
    Console.WriteLine($"Hai inserito un numero pari: {numInserito}");
} else 
{
    Console.WriteLine($"Hai inserito un numero dispari. Il numero successivo è: {numInserito + 1}");
}

Console.WriteLine("------------------------------------------------------");
// Snack 6: In un array sono contenuti i nomi degli invitati alla festa del grande Gatsby. Chiedi all’utente il suo nome e comunicagli se può partecipare o meno alla festa.

string[] invitatiGatsby = { "Luciano", "Paolo", "Luca", "Silvana", "Valeria", "Laura" , "Gianni"};

Console.WriteLine("Inserisci il tuo nome:");

string nomeUtente = Console.ReadLine();

bool invitoFesta = false;

foreach (string invitato in invitatiGatsby)
{
    if (nomeUtente == invitato)
    {
        Console.WriteLine("Benvenuto alla festa del grande Gatsby!");
        invitoFesta = true;
    }
}

if (!invitoFesta)
{
    Console.WriteLine("Mi dispiace non sei nella lista degli invitati alla festa del grande Gatsby!");
}

Console.WriteLine("------------------------------------------------------");
// Snack 7: Crea un array vuoto. Chiedi per 6 volte all’utente di inserire un numero, se è dispari inseriscilo nell’array.

int[] arrayVuoto = new int[6];
int index = 0;

for (int i = 0; i < 6; i++)
{
    Console.WriteLine("Inserisci un numero per 6 volte!");
    int numUtente = int.Parse(Console.ReadLine());

    // verifico se il numero è dispari
    if (numUtente % 2 != 0)
    {
        arrayVuoto[index] = numUtente;   // aggiungo il numero dispari all'array vuoto
        index++;
    }
}

Console.WriteLine("I numeri dispari inseriti sono: ");

for (int i = 0; i < index; i++)
{
    Console.WriteLine(arrayVuoto[i]);
}

Console.WriteLine("------------------------------------------------------");
// Snack 8: Crea un array di numeri interi e fai la somma di tutti gli elementi che sono in posizione dispari.

int[] arrayInteri = { 1, 5, 8, 10, 18, 20, 4 };

int sommaDispari = 0;

for (int i = 0; i < arrayInteri.Length; i++)
{
    if (i % 2 != 0)  // Verifico se l'indice è dispari
    {
        sommaDispari += arrayInteri[i];  //  Aggiungo l'elemento in posizione dispari alla somma
    }


}
 
Console.WriteLine($"La somma degli elementi che sono in posizione dispari è: {sommaDispari}");

Console.WriteLine("------------------------------------------------------");
// Snack 9: Crea un array vuoto e chiedi all’utente un numero da inserire nell’array. Continua a chiedere i numeri all’utente e a inserirli nell’array, fino a quando la somma degli elementi è minore di 50.

int[] arrayNumeri = new int[49];
int sommaNum = 0;
int ind = 0;

for (int i = 0; i < 50; i++)
{
    Console.WriteLine("Inserisci un numero: ");
    int numero = int.Parse(Console.ReadLine());
    sommaNum += numero;

    if (sommaNum < 50)
    {
        arrayNumeri[ind] = numero;
        ind++;
    } else
    {
        Console.WriteLine($"Non puoi più inserire numeri perchè hai raggiunto il limite massimo di 50!");
        break;
    }

}

Console.WriteLine("------------------------------------------------------");
// Snack 10: Fai inserire un numero, che chiameremo N, all’utente. Genera N array, ognuno formato da 10 numeri casuali tra 1 e 100. Ogni volta che ne crei uno, stampalo a schermo.

Console.WriteLine("Inserisci un numero: ");
int N = int.Parse(Console.ReadLine());

Random random = new Random();

for (int i = 0; i < N; i++)
{
    int[] array = new int[10];

    for (int j = 0; j < 10; j++)
    {
        array[j] = random.Next(1, 101);  // Genera un numero casuale da 1 a 100
        Console.Write(array[j] + " ");
    }

    Console.WriteLine();
    
}