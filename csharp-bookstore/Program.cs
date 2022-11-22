var titolo = "Clean Code: A Handbook of Agile Software Craftsmanship";
var autore = "Robert C. Martin";
long isbn10 = 9780132350884;
long isbn13 = 9780132350884;
int pagine = 431;
double peso = 0.8;
double larghezza = 17.78;
double altezza = 2.79;
double profondità = 23.37;
double valutazione = 4.7;
int numerovalutazioni = 4571;
bool kindle = true;
bool copertinarigida = false;

Console.WriteLine("---------------------------------- Il Libro Di Oggi--------------------------------------");
Console.WriteLine("");
Console.WriteLine(titolo + " di " + autore);
Console.WriteLine();
Console.WriteLine("-----------------------------------------------------------------------------------------");
Console.WriteLine();
Console.WriteLine("Informazioni Generiche:");
Console.WriteLine("ISBN: " + isbn10 + "    " + isbn13);
Console.WriteLine("Numero Di Pagine: " + pagine + " Pagine");
Console.WriteLine("Peso Del Libro: " + peso + " Kg");
Console.WriteLine("Dimensioni Del Libro: " + larghezza + " x " + altezza + " x " + profondità + " cm");
Console.WriteLine("");
Console.WriteLine("Informazioni Amazon:");
Console.WriteLine("Numero Di Recensioni: " + numerovalutazioni + " Recensioni");
Console.WriteLine("Valutazione Media: " + valutazione + " Stelline");
Console.WriteLine("Kindle Disponibile: " + kindle);
Console.WriteLine("Copertina Rigida: " + copertinarigida);



