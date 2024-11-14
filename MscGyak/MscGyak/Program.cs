// See https://aka.ms/new-console-template for more information

using System;
using System.Collections;

Console.WriteLine("Hello, World!");

//Kipróbáltam a Baleset osztályt

Baleset balesetObjektum = new Baleset();
Baleset ujBaleset = new Baleset([232, 233]);
Baleset baleset3 = new Baleset([232, 233], 2);

Console.WriteLine(balesetObjektum.Fokozat);
Console.WriteLine(ujBaleset.Fokozat);
Console.WriteLine(baleset3.Fokozat);

Console.WriteLine(balesetObjektum.Datum);

/*
balesetObjektum.Datum = DateTime.Now;
balesetObjektum.Fokozat= 4;
//Console.WriteLine(baleset.Datum + " " + baleset.Fokozat);
String asdasdasd = "valami szöveg";
Console.WriteLine(asdasdasd.Equals("más szöveg"));
*/

