using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wiederholung {
    class Program {
        static void Main(string[] args) {
            int atn = 0, atn2, urTag, zielTag;
			bool gueltig;
			string termin;
			string[] termine = new string[32];
			string[] days = new string[32];
			string[] menu = { "Wählen Sie die gewünschte Operation aus:", "(1) Kalender aufrufen", "(2) Termin hinzufügen", "(3) Termin löschen", "(4) Termin verschieben", "(5) Programm beenden" };

			//array days füllen (für ausgabe von kalender)
			for (int i = 1; i < days.Length; i++) {
				days[i] = "Tag " + i + ": ";
			}

			//ausgabe des arrays menu (zur ausgabe des menüs)
			do {
				foreach (string operation in menu) {
					Console.WriteLine(operation);
				}
				gueltig = int.TryParse(Console.ReadLine(), out atn);

				if (!gueltig) {
					Console.Clear();
					Console.WriteLine("Bitte geben Sie eine Zahl zwischen 1 und 5 ein");
					Console.ReadLine();
				}
				Console.Clear();
			} while (!gueltig);

			//verarbeitung des menüs
			switch (atn) {
				case 1://kalender aufrufen
					foreach (string day in days) {
						Console.WriteLine(day);
					}

					Console.WriteLine("");

					//ausgabe des arrays menu (zur ausgabe des menüs)
					do {
						foreach (string operation in menu) {
							Console.WriteLine(operation);
						}
						gueltig = int.TryParse(Console.ReadLine(), out atn);

						if (!gueltig) {
							Console.Clear();
							Console.WriteLine("Bitte geben Sie eine Zahl zwischen 1 und 5 ein");
							Console.ReadKey();
						}
						Console.Clear();
					} while (!gueltig);

					if (atn == 1) {
						goto case 1;
					} else if (atn == 2) {
						goto case 2;
					} else if (atn == 3) {
						goto case 3;
					} else if (atn == 4) {
						goto case 4;
					} else if (atn == 5) {
						goto case 5;
					}
					break;
				case 2://termin hinzufügen
					do {
						Console.Clear();
						Console.WriteLine("An welchem Tag wollen Sie einen Termin hinzufügen?");
						gueltig = int.TryParse(Console.ReadLine(), out atn2);
						Console.Clear();

						if (!gueltig) {
							Console.Clear();
							Console.WriteLine("Bitte geben Sie eine Zahl zwischen 1 und 31 ein");
							Console.ReadKey();
						}
					} while (!gueltig);

					Console.Clear();
					Console.WriteLine("Bitte bennen Sie Ihren Termin");
					termin = Convert.ToString(Console.ReadLine());

					//eintrag des termins in das array termine
					for (int i = atn2; i == atn2; i++) {
						termine[i] = termin;
					}

					//hinzufügen des termins ins array days
					for (int i = atn2; i == atn2; i++) {
						days[i] = days[i] + termine[i];
					}

					Console.Clear();

					//ausgabe des arrays menu (zur ausgabe des menüs)
					do {
						foreach (string operation in menu) {
							Console.WriteLine(operation);
						}
						gueltig = int.TryParse(Console.ReadLine(), out atn);

						if (!gueltig) {
							Console.Clear();
							Console.WriteLine("Bitte geben Sie eine Zahl zwischen 1 und 5 ein");
							Console.ReadKey();
						}
						Console.Clear();
					} while (!gueltig);

					if (atn == 1) {
						goto case 1;
					} else if (atn == 2) {
						goto case 2;
					} else if (atn == 3) {
						goto case 3;
					} else if (atn == 4) {
						goto case 4;
					} else if (atn == 5) {
						goto case 5;
					}
					break;
				case 3://termin löschen
					do {
						Console.Clear();
						Console.WriteLine("An welchem Tag wollen Sie einen Termin entfernen?");
						gueltig = int.TryParse(Console.ReadLine(), out atn2);
						Console.Clear();

						if (!gueltig) {
							Console.Clear();
							Console.WriteLine("Bitte geben Sie eine Zahl zwischen 1 und 31 ein");
							Console.ReadKey();
						}
					} while (!gueltig);

					//überschreiben des eingegebenen tages mit default wert
					for (int i = atn2; i == atn2; i++) {
						days[i] = "Tag " + i + ": ";
					}

					//ausgabe des arrays menu (zur ausgabe des menüs)
					do {
						foreach (string operation in menu) {
							Console.WriteLine(operation);
						}
						gueltig = int.TryParse(Console.ReadLine(), out atn);

						if (!gueltig) {
							Console.Clear();
							Console.WriteLine("Bitte geben Sie eine Zahl zwischen 1 und 5 ein");
							Console.ReadKey();
						}
						Console.Clear();
					} while (!gueltig);

					if (atn == 1) {
						goto case 1;
					} else if (atn == 2) {
						goto case 2;
					} else if (atn == 3) {
						goto case 3;
					} else if (atn == 4) {
						goto case 4;
					} else if (atn == 5) {
						goto case 5;
					}
					break;
				case 4://termin verschieben
					do {
						Console.Clear();
						Console.WriteLine("Bitte geben Sie den Ursprungstag ein");
						gueltig = int.TryParse(Console.ReadLine(), out urTag);

						if (!gueltig) {
							Console.Clear();
							Console.WriteLine("Bitte geben Sie eine Zahl zwischen 1 und 31 ein");
							Console.ReadKey();
						}
					} while (!gueltig);

					do {
						Console.Clear();
						Console.WriteLine("Bitte geben Sie den Zieltag ein");
						gueltig = int.TryParse(Console.ReadLine(), out zielTag);

						if (!gueltig) {
							Console.Clear();
							Console.WriteLine("Bitte geben Sie eine Zahl zwischen 1 und 31 ein");
							Console.ReadKey();
						}
						Console.Clear();
					} while (!gueltig);

					//verschieben des termins
					for (int i = zielTag; i == zielTag ; i++) {
						days[i] = days[i] + termine[urTag];     //speichern des termines im zieltag
						for (int n = urTag; n == urTag; n++) {
							days[n] = "Tag " + n + ": ";		//ersetzen des ursprungstages durch default wert
						}
					}

					do {
						foreach (string operation in menu) {
							Console.WriteLine(operation);
						}
						gueltig = int.TryParse(Console.ReadLine(), out atn);

						if (!gueltig) {
							Console.Clear();
							Console.WriteLine("Bitte geben Sie eine Zahl zwischen 1 und 5 ein");
							Console.ReadKey();
						}
						Console.Clear();
					} while (!gueltig);

					if (atn == 1) {
						goto case 1;
					} else if (atn == 2) {
						goto case 2;
					} else if (atn == 3) {
						goto case 3;
					} else if (atn == 4) {
						goto case 4;
					} else if (atn == 5) {
						goto case 5;
					}
					break;
				case 5://console schließen
					Environment.Exit(0);
					break;
			}

			Console.ReadKey();
		}
    }
}
