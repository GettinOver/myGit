using System;
using System.Collections.Generic;
using System.Linq;
using system.Text;
using system.Threading.Tasks;

namespace Taschenrechner{
    class Programm{
        static void Main(string[] args){
            int zahl1, zahl2, ergebnis, aktion;
           bool gueltig;

           do {
               Console.WriteLine("Bitte geben Sie eine Zahl ein");
               gueltig = int.TryParse(Console.ReadLine(), out zahl1);
               Console.Clear();

               if (!gueltig) {
                   Console.WriteLine("Bitte geben Sie eine Ganzzahl ein");
               }
           } while (!gueltig);

           do {
               Console.WriteLine("Bitte geben Sie noch eine Zahl ein");
               gueltig = int.TryParse(Console.ReadLine(), out zahl2);
               Console.Clear();

               if (!gueltig) {
                   Console.WriteLine("Bitte geben Sie eine Ganzzahl ein");
               }
           } while (!gueltig);

           do {
               Console.Clear();
               Console.WriteLine("Zahl1: " + zahl1 + ", Zahl2: " + zahl2);
               Console.WriteLine("Bitte wählen Sie eine gewünschte Option aus:");
               Console.WriteLine("(1)Zahl1 ändern");
               Console.WriteLine("(2)Zahl2 ändern");
               Console.WriteLine("(3)Zahlen addieren");
               Console.WriteLine("(4)Zahlen subtrahieren");
               Console.WriteLine("(5)Zahlen multiplizieren");
               Console.WriteLine("(6)Zahlen dividieren");
               Console.WriteLine("(7)Programm Beenden");

               if (!gueltig) {
                   Console.WriteLine("Bitte geben Sie eine Zahl zwischen 1 und 7 ein");
               }

               gueltig = int.TryParse(Console.ReadLine(), out aktion);
           } while (!gueltig);

           switch (aktion) {
               case 1:
                   Console.Clear();
                   Console.WriteLine("Geben Sie eine neue Zahl ein");
                   zahl1 = Convert.ToInt16(Console.ReadLine());
                   Console.Clear();
                   goto default;
               case 2:
                   Console.Clear();
                   Console.WriteLine("Geben Sie eine neue Zahl ein");
                   zahl2 = Convert.ToInt16(Console.ReadLine());
                   Console.Clear();
                   goto default;
               case 3:
                   Console.Clear();
                   ergebnis = zahl1 + zahl2;
                   Console.WriteLine("Das ergebnis lautet: " + ergebnis);
                   Console.WriteLine("");
                   goto default;
               case 4:
                   Console.Clear();
                   ergebnis = zahl1 - zahl2;
                   Console.WriteLine("Das ergebnis lautet: " + ergebnis);
                   Console.WriteLine("");
                   goto default;
               case 5:
                   Console.Clear();
                   ergebnis = zahl1 * zahl2;
                   Console.WriteLine("Das ergebnis lautet: " + ergebnis);
                   Console.WriteLine("");
                   goto default;
               case 6:
                   Console.Clear();
                   ergebnis = zahl1 / zahl2;
                   Console.WriteLine("Das ergebnis lautet: " + ergebnis);
                   Console.WriteLine("");
                   goto default;
               case 7:
                   Environment.Exit(0);
                   break;
               default:
                   Console.WriteLine("Zahl1: " + zahl1 + ", Zahl2: " + zahl2);
                   Console.WriteLine("Bitte wählen Sie eine gewünschte Option aus:");
                   Console.WriteLine("(1)Zahl1 ändern");
                   Console.WriteLine("(2)Zahl2 ändern");
                   Console.WriteLine("(3)Zahlen addieren");
                   Console.WriteLine("(4)Zahlen subtrahieren");
                   Console.WriteLine("(5)Zahlen multiplizieren");
                   Console.WriteLine("(6)Zahlen dividieren");
                   Console.WriteLine("(7)Programm beenden");
                   aktion = Convert.ToInt16(Console.ReadLine());

                   if (aktion == 1) {
                       goto case 1;
                   } else if (aktion == 2) {
                       goto case 2;
                   } else if (aktion == 3) {
                       goto case 3;
                   } else if (aktion == 4) {
                       goto case 4;
                   } else if (aktion == 5) {
                       goto case 5;
                   } else if (aktion == 6) {
                       goto case 6;
                   } else if (aktion == 7) {
                       goto case 7;
                   }
                   break;
           }
        }
    }
}
