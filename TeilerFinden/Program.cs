using System;

namespace TeilerFinden
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Bitte geben Sie eine positive Ganzzahl ein! (Leere Eingabe beendet das Programm)");

                try
                {
                    string input = Console.ReadLine();
                    if (input.Equals("")) break;
                    int inputNumber = Convert.ToInt32(input);



                    if (inputNumber < 1)
                    {
                        Console.WriteLine("Die Zahl muss positiv sein!");
                        continue;
                    }

                    int groessteZahl = 0;

                    if (inputNumber > groessteZahl) groessteZahl = inputNumber;

                    int summe = 0;
                    int anzahlTeiler = 0;
                    //Ausgabe der Teiler
                    Console.Write("Teiler: ");
                    for (int i = inputNumber; i > 0; i--)
                    {
                        if (inputNumber % i == 0)
                        {
                            if(i == 1)
                            {
                                Console.WriteLine(i);
                            }
                            else
                            {
                                Console.Write("{0}, ", i);
                            }
                            summe += i;
                            anzahlTeiler += 1;
                        }
                    }
                    Console.WriteLine("Summe der Teiler: {0}", summe);
                    Console.WriteLine("Anzahl Teiler: {0}", anzahlTeiler);
                    Console.WriteLine("Die groesste Zahl war: {0}", groessteZahl);
                }
                catch (System.FormatException)
                {
                    Console.WriteLine("Diese Eingabe ist keine Zahl!");
                }
                catch (System.OverflowException)
                {
                    Console.WriteLine("Die Zahl ist zu gross!");
                }


            }
        }
    }
}
