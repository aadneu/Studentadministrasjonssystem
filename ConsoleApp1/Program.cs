// See https://aka.ms/new-console-template for more information

using System.Text.RegularExpressions;
using ConsoleApp1;

var Matte = new Fag("M1","Matte", 60 );
var Biologi = new Fag("B2", "Biologi", 30);
var Fysikk = new Fag("F1", "Fysikk", 45);
var Gym = new Fag("G1", "Gym", 15);
var Norsk = new Fag("N1", "Norsk", 30);

var S01 = new Student("Harry Potter", 17, "Almenn", 01);
var S02 = new Student("Karl Reverud", 25, "Idrett", 02);

S01.LeggTilFag(Matte);
S01.LeggTilFag(Biologi);
S01.LeggTilFag(Fysikk);
S01.LeggTilFag(Gym);
S01.LeggTilFag(Norsk);

S01.LeggTilKarakter(Matte, 4);
S01.LeggTilKarakter(Biologi, 3);
S01.LeggTilKarakter(Fysikk, 5);
S01.LeggTilKarakter(Gym, 6);
S01.LeggTilKarakter(Norsk, 3);

Console.WriteLine("Karakterinfo:");
S01.SkrivUtKarakterInfo();
Console.Write("StudiePoeng: ");
Console.WriteLine(S01.BeregnStudiePoeng());
Console.Write("Karaktersnitt: ");
Console.WriteLine(S01.BeregnKarakterSnitt());





/*
var karS01M1 = new Karakter(S01, Matte, 4);
var karS01B2 = new Karakter(S01, Biologi, 3);
var karS01F1 = new Karakter(S01, Fysikk, 5);
var karS01G1 = new Karakter(S01, Gym, 6);
var karS01N1 = new Karakter(S01, Norsk, 2);
*/

/*
var Fagliste = new List<string>();
Fagliste.Add(Matte.Fagnavn);
Fagliste.Add(Gym.Fagnavn);
Fagliste.Add(Norsk.Fagnavn);
Fagliste.Add(Biologi.Fagnavn);
Fagliste.Add(Fysikk.Fagnavn);

foreach(var fag in  Fagliste){
    Console.WriteLine(fag);
}
*/
/*
S01.SkrivUtInfo();
S02.SkrivUtInfo();

Matte.SkrivUtInfo();
Biologi.SkrivUtInfo();

karS01M1.SkrivUtInfo();
karS01B2.SkrivUtInfo();
*/
