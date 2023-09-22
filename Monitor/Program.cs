using System;
using System.Collections.Generic;
using System.IO;

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
                Console.WriteLine($"f1 gyárstó: {x.gyartoja}, típus: {x.tipusa} méret: {x.merete} nettó ár: {(x.ara/(x.afa/100))}");
            }
            
            Console.WriteLine();
            foreach (var x in monitorok)
            {
                Console.WriteLine(bruttoraktar());
            }





            Console.ReadLine();


        }
    }
}
