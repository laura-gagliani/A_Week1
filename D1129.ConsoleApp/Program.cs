// See https://aka.ms/new-console-template for more information

using D1129.ConsoleApp;

Console.WriteLine("Hello, World!");

//prima veniva generato il seguente codice:

//using System;
//using System.Collections.Generic;
//using System.Linq;

//namespace MyApp // Note: actual namespace depends on the project name.
//{
//    public class Program
//    {
//        public static void Main(string[] args)
//        {
//            Console.WriteLine("Hello World!");
//        }
//    }
//}

int a;
a = 3;
int b;
b = 4;

const decimal c = 5.3m;

float e, f = 2.34f;

int h = 10;
h = 'c'; //assegnazione implicita del char alla int (perché il char ha un numero associato..)

DateTime date = new DateTime(2021, 11, 29);
DateTime now = DateTime.Now;
DateTime today = DateTime.Today;



//ref types vs value types:

int n = 100;
int o = n; //o valrà 100... copio il valore
n = 1000;  // ora n vale 1000, ma o vale ancora 100!

Product prod1 = new Product();
prod1.Name = "Chiavetta_USB";
Product prod2 = prod1;     //copio il riferimento! anche prod2 punterà dove prod1, e avrà quindi lo stesso nome
prod2.Name = "Cavetto_USB_C"; // quindi se ora cambio il nome (a quel ref, ovvero a quella allocazione) lo cambio AD ENTRAMBI

string nome1 = "Alessandra";
string nome2 = nome1; //nome2 punterà dove nome1, ovvero alla stringa "Alessandra"
nome1 = "Ale"; //nome1 cambia in "Ale" perché di fatto si crea un nuovo riferimento di memoria, una nuova allocazione
               // la stringa difatti è immutabile, non si comporta esattamente come un ref type


//dichiarazione variabile di tipo CategoryEnum
CategoryEnum category = CategoryEnum.Elettronica;


//sfruttamento del tipo "var":
var cognome = "Degan";
var p = 30f;
var prod3 = new Product();   //non posso invece dire var tot = null; perché non ha info sufficiente per capire chi è "tot"

//classe madre Object:

object r = new object();


//chiamata metodi

MyMethods.PrintName("Alessandra");
