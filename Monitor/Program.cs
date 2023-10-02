using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;


namespace Monitor
{
    class Program
    {
        
        static double bruttoraktar(List<Vasar> monitorok)
        {
            double ossz = 0;

            foreach (var x in monitorok)
            {
                ossz += x.brutto(x.ara, x.afa) * 15;
            }
            return ossz;

        }
        
        static void Main(string[] args)
        {
            var monitorok = new List<Vasar>();
            using var sr = new StreamReader
                (
                path: @"..\..\..\src\monitor.txt",
                encoding: System.Text.Encoding.UTF8
                );
                sr.ReadLine();
            while (!sr.EndOfStream)
            {
                monitorok.Add(new Vasar(sr.ReadLine()));
            }
            foreach (var x in monitorok)
            {
                Console.WriteLine($"{x.gyartoja}, típus: {x.tipusa} méret: {x.merete} nettó ár: {(x.ara/(x.afa/100))}");
            }
            Console.WriteLine();
            foreach (var x in monitorok)
            {
                Console.WriteLine($"brutto ara {x.gyartoja} : {Math.Round(x.brutto(x.ara, x.afa))}ft");

                

                Console.WriteLine();
               
            }

            
            Console.WriteLine($"raktarertek: {Math.Round(bruttoraktar(monitorok))} ft");
            Console.WriteLine();
            var filePath = @"..\..\..\src\WriteFile.txt";
            using (StreamWriter outputFile = new StreamWriter(filePath))

                

                

                foreach (var x in monitorok)
                {
                    if (x.ara > 50000)
                    {
                        {
                            outputFile.WriteLine($"{x.gyartoja.ToUpper()} : {x.ara} ft {x.darab(15)}db");
                            Console.WriteLine($"{x.gyartoja.ToUpper()} : {x.ara} ft {x.darab(15)}db");
                        }
                    }
                }

            Console.WriteLine();

            foreach (var x in monitorok)
            {
                if (x.gyartoja == "hp")
                {
                    Console.WriteLine(x.db);
                }
                else
                {
                
                    var ize = monitorok.Max(m => m.ara);
                    Console.WriteLine($"{x.gyartoja}");
                }
            }
            
           




            Console.ReadLine();
            
            


        }
    }
}
