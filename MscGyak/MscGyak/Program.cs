// See https://aka.ms/new-console-template for more information

using System;
using System.Collections;
using MscGyak.model;

Console.WriteLine("Hello, World!");

//Kipróbáltam a Baleset osztályt

MotorBaleset balesetObjektum = new MotorBaleset();
MotorBaleset ujBaleset = new MotorBaleset([232, 233]);
MotorBaleset baleset3 = new MotorBaleset([232, 233], 2);
MotorBaleset baleset4 = new MotorBaleset (true);

Console.WriteLine(balesetObjektum.Fokozat);
Console.WriteLine(ujBaleset.Fokozat);
Console.WriteLine(baleset3.Fokozat);
Console.WriteLine (baleset4.Bukosisak);

baleset4.GridKalkulator();

Console.WriteLine(balesetObjektum.Datum);

/*
balesetObjektum.Datum = DateTime.Now;
balesetObjektum.Fokozat= 4;
//Console.WriteLine(baleset.Datum + " " + baleset.Fokozat);
String asdasdasd = "valami szöveg";
Console.WriteLine(asdasdasd.Equals("más szöveg"));
*/

