// See https://aka.ms/new-console-template for more information


/*
 * For
 */
Console.WriteLine("For løkker");


//// udskriver ti gange
//int tal = 8;

//tal = tal + 1;

//tal += 1; // tal = tal + 1
//tal *= 4; // tal = tal * 4 

//tal++; // tal = tal + 1
//tal--; // tal = tal - 1
//       //tal**; // ikke tilladt


////  start     fortsætte  tælle op
//for(int i = 1; i <= 10; i++)
//{
//    Console.WriteLine(i);
//}


//// laver 17 gennemløb 0-16
//for (int i = 0; i < 17; i++)
//{
//    Console.WriteLine(i);
//}


//// laver 17 gennemløb 17-1
//for (int i = 17; i > 0; i--)
//{
//    Console.WriteLine(i);
//}


///*
// * While
// */
//Console.WriteLine("While løkker");

//int ix = 1; // start
//while(ix <= 10)  // fortsætter?
//{
//    Console.WriteLine(ix);

//    ix++; // tæller op
//}


//String linje = "";
//while (linje.ToLower() != "stop")
//{
//    Console.WriteLine(linje);

//    Console.Write("Næste linje (skriv STOP for at stoppe): ");
//    linje = Console.ReadLine();
//}


/*
 * Liste som data struktur
 */

// Liste af tal

// erklære liste

List<int> liste;

// oprette
liste = new List<int>();

// lægge noget i listen
liste.Add(10);
liste.Add(2);
liste.Add(7);
liste.Add(4);
liste.Add(3);

int detteTal = liste[2];
Console.WriteLine(detteTal);


/*
 * gennemløb af liste me for (ikke optimalt)
 */
for (int i = 0; i < liste.Count; i++)
{
    Console.WriteLine($"på plads {i} ligger tal {liste[i]}");
}




/*
 * gennemløb af liste med foreach
 */
foreach (int helTal in liste)
{
    Console.WriteLine("foreach : " + helTal);
}


/*
 * 100 tilfældige tal
 */
Random rnd = new Random(DateTime.Now.Millisecond);
List<int> tilfældigeTal = new List<int>();

for (int i = 0; i < 100; i++)
{
    tilfældigeTal.Add(rnd.Next(592,994));
}

foreach(int næsteTal in tilfældigeTal)
{
    Console.WriteLine(næsteTal);
}


Console.WriteLine("gennemsnit " + tilfældigeTal.Average());
Console.WriteLine("Max " + tilfældigeTal.Max());
Console.WriteLine("Min " + tilfældigeTal.Min());

int maxValue = 0;
foreach (int t in tilfældigeTal)
{
    if (t > maxValue)
    {
        maxValue = t;
    }
}
Console.WriteLine("Mit max er " + maxValue);






