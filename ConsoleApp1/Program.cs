// See https://aka.ms/new-console-template for more information

using System.Text.RegularExpressions;
using ConsoleApp1;



var Matte = new Fag("M1","Matte", 60 );
var Biologi = new Fag("B2", "Biologi", 30);

var S01 = new Student("Harry Potter", 17, "Almenn", 01);
var S02 = new Student("Bjørn Reverud", 25, "Idrett", 02);

var karS01M1 = new Karakter(S01, Matte, 6);
var karS01B2 = new Karakter(S01, Biologi, 3);



S01.SkrivUtInfo();
S02.SkrivUtInfo();
Matte.SkrivUtInfo();
Biologi.SkrivUtInfo();

karS01M1.SkrivUtInfo();
karS01B2.SkrivUtInfo();

