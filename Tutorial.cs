using System;

// So schreibst du einen Kommentar
/* Alle Zeichen die in dieser Kommtar-Variante stehen werden als Kommentar Interpretiert */

namespace Tutorial
{
    class Tutorial1
    {
        /* Mit 'static' werden Methoden bezeichnet die beim Aufruf kein spezifisches Objekt voraussetzen, 
        und 'void' beschreibt eine Methode ohne Rückgabewert. 
        'Main' ist eine Methode von herrausragender Bedeutung. Wenn Laufzeitumgebung der EXE-Datei startet, wird zuerst 'Main' ausgeführt*/


        static void Main()
        {
            //----------------------------------------------Elementare Syntax-------------------------------------------------------------------------------------

            Console.Write("Hallo...");                      //Anweisungen enden immer mit einem Semikolon // Methode erzeugt eine Ausgabe
                                                            //Konsolen-Cursor am Ende der Zeile 

            Console.                                        //Anweisungen können in verschiedene Zeilen aufgeteilt werden //
                WriteLine                                   //Diese Methode erzeugt eine Ausgabe in der Konsole // Cursor in der nächste Zeile
                /*Kommentar*/("C# macht spaß");             //Kommentare können in mitten einer Anweisung stehen


            Console.ReadLine();                             //Reagiert nur auf 'Enter'

            Console.ReadKey(); ; ; ; ; ;                    //Reagiert auf jede Taste //Mehrere Semikolons füren nicht zu einem Fehler            



            //----------------------------------------------Datendeklaration-------------------------------------------------------------------------------------

            int value;                                      //Deklaration durch Datentyp + Bezeichner
                                                            //(Der Bezeichner repräsentiert eine Speicheradresse im Arbeitsspeicher)

            /* Variablenbezeichner
            ->Ein Bezeichner setzt sich aus alphanumerischen Zeichen und dem Unterstrich zusammen.
              Leerzeichen und andere Sonderzeichen wie beispielsweise #, § und $ sind nicht zugelassen.           
            ->Ein Bezeichner muss mit einem Buchstaben oder dem Unterstrich anfangen.
            ->Ein einzelner Unterstrich als Variablenname ist nicht zugelassen.
            ->Der Bezeichner muss eindeutig sein, Er darf nicht gleichlautend mit einem Schlüsselwort, einer Methode
              , einer Klasse oder einem Objektnamen sein.
            */

            value = 23;                                     //Zuweisung eines gültigen Wertes (Initialisierung)

            double value2 = 1000.11;                        //Deklaration und Initialisierung können in einer Anweisung erfolgen
            Console.WriteLine(value+value2);                //Werte werden in der Konsole addiert ausgegeben

            long a = 10, b = 1000000000000000000;           //Mehrere Variablen gleichen Typs deklarieren und direkt initialisieren


            //----------------------------------------------Variable durch Platzhalter-------------------------------------------------------------------------------------

            Console.WriteLine
                ("Wert von 'a' = {0}\nWert von 'b' = {1}", b, a);           //Konsolenausgabe der Variable durch Platzhalter { }
            //test
        }
    }
}
