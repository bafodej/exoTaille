// See https://aka.ms/new-console-template for more information
Console.WriteLine("---- Quelle taille dois-je prendre ? -----");




Console.WriteLine("Entrez votre taille (en cm ) :");
int TailleSaisie = int.Parse(Console.ReadLine());

Console.WriteLine("Entrez votre poids (en kg) :");
int PoidSaisie= int.Parse(Console.ReadLine());


if ((TailleSaisie > 145 && TailleSaisie <= 169) && (PoidSaisie >= 43 && PoidSaisie <= 65))
{
    Console.WriteLine("Prenez la taille 1.");

}

else if ((TailleSaisie >= 160 && TailleSaisie <= 178) && (PoidSaisie >= 48 && PoidSaisie <= 71) )
{
    Console.WriteLine("Prenez la taile 2.");
}

else if ( (TailleSaisie > 163 && TailleSaisie <= 183) && (PoidSaisie >= 72 && PoidSaisie <= 77)){
    Console.WriteLine("Prennez la taille 3.");
}

else
{
    Console.WriteLine(" Votre taille n'est pas disponible ..");
}