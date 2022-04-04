//Bookstore

string title ;
string author;
long ISBN;
int nPages;
double weight;
double height;
double widht;
double depth;
double averageRating;
int nReviews;
bool isKindle;
bool isCoverFlexible;

Console.WriteLine();

Console.WriteLine("Inserisci il titolo del libro: ");
title = Console.ReadLine();
Console.WriteLine("Inserisci l'autore del libro");
author = Console.ReadLine();
Console.WriteLine("Inserisci il codice ISBN:");
ISBN = Int64.Parse(Console.ReadLine());
Console.WriteLine("Inserisci il numero di pagine: ");
nPages = Int32.Parse( Console.ReadLine());
Console.WriteLine("Inserisci il peso: ");
weight = Double.Parse(Console.ReadLine());
Console.WriteLine("Inserisci l'altezza: ");
height = Double.Parse(Console.ReadLine());
Console.WriteLine("Inserisci la larghezza: ");
widht = Double.Parse(Console.ReadLine());
Console.WriteLine("Inserisci la profondità : ");
depth = Double.Parse(Console.ReadLine());
Console.WriteLine("Inserisci il rating medio: ");
averageRating = Double.Parse(Console.ReadLine());
Console.WriteLine("Inserisci il numero di review : ");
nReviews = Int32.Parse(Console.ReadLine());
Console.WriteLine("Inserisci SI se è presente su Kindle: ");
isKindle =  (Console.ReadLine()=="SI") ? true:false;
Console.WriteLine("Inserisci SI se la copertina è flessibile: ");
isCoverFlexible =  (Console.ReadLine() == "SI") ? true:false;




Console.WriteLine("——— IL LIBRO DI OGGI: " + title + " di " + author + " ——————-" +
    "\nISBN: " + ISBN +
    "\nNumero delle pagine: " + nPages + "pagine" +
    "\nPeso del libro: " + weight + "kg" +
    "\nDimensioni del libro: " + widht + "cm x " + height + "cm x " + depth + " cm" +
    "\nInformazioni Amazon: " +
    "\nNumero di recensioni: " + nReviews + " recensioni" +
    "\nValutazione media: " + averageRating + " stelline" +
    "\nKindle disponibile: " + (isKindle ? "Si" : "No") +
    "\nCopertina flessibile disponibile: " + (isCoverFlexible ? "Si" : "No"));