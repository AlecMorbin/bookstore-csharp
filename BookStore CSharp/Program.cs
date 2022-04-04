//Bookstore

string printAuthor(string[] authors)
{
    string result = "";

    foreach (string author in authors)
    {
        result = result + " " + author;
    }
    return result;
}

string title = "Clean Code: A Handbook of Agile Software Craftsmanship";
string[] authors = {"Robert C. Martin" , "Dean Wampler"};
long ISBN = 9780132350884;
int nPages = 431;
double height = 23.5;
double widht = 17.91;
double depth = 2.54;
double averageRating = 4.7;
int nReviews = 0;
bool isKindle = true;
bool isCoverFlexible = true;

Console.WriteLine("——— IL LIBRO DI OGGI: " +title+" di " +printAuthor(authors)+ "——————-" +
    "\nISBN" + ISBN +
    "\nNumero delle pagine: <<numeroPagine>> pagine" +
    "\nPeso del libro: <<pesoLibro>> kg" +
    "\nDimensioni del libro: <<larghezza>> cm x <<lunghezza>> cm x <<profondita>> cm" +
    "\nInformazioni Amazon:" +
    "\nNumero di recensioni: <<numeroRecensioni>> recensioni" +
    "\nValutazione media: <<valutazioneMedia>> stelline" +
    "\nKindle disponibile: Si o No" +
    "\nCopertina flessibile disponibile: Si o No" );