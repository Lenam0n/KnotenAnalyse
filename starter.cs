using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


class starter
{
    public static void Main()
    {
        List<Knoten> knotens = new List<Knoten>();
        //ID , Name , Dauer, Knoten
        Knoten k1 = new Knoten(1, "AA", 1, null);
        knotens.Add(k1);
        Knoten k2 = new Knoten(2, "HSD", 1, new List<Knoten>() { k1 });
        knotens.Add(k2);
        Knoten k3 = new Knoten(3, "AB", 3, new List<Knoten>() { k1 });
        knotens.Add(k3);
        Knoten k4 = new Knoten(4, "BHS", 3, new List<Knoten>() { k2, k3 });
        knotens.Add(k4);
        Knoten k5 = new Knoten(5, "AL, VI", 2, new List<Knoten>() { k4 });
        knotens.Add(k5);
        Knoten k6 = new Knoten(6, "KM", 1, new List<Knoten>() { k5 });
        knotens.Add(k6);
        Knoten k7 = new Knoten(7, "SL", 2, new List<Knoten>() { k5 });
        knotens.Add(k7);
        Knoten k8 = new Knoten(8, "SÜ", 1, new List<Knoten>() { k6, k7 });
        knotens.Add(k8);


        foreach (var item in knotens)
        {
            item.LateSetter(knotens);
            ausgabe(item);

        }
        List<Knoten> l = new List<Knoten>();
        int Gdauer = 0;
        foreach (Knoten item in knotens)
        {
            if (/*item.getGP() == 0 &&*/ item.getFP() == 0)
            {
                Gdauer += item.getDauer();
                l.Add(item);
            }
        }
        Console.WriteLine("Kritischer Pfad");
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        
        foreach (var item in l) { Console.WriteLine(item.getID() + " - " + item.getName()); }
        Console.WriteLine("*******************************");
        Console.WriteLine("Gesamt Dauer des Projektes");
        Console.WriteLine(Gdauer);


    }
    private static void ausgabe(Knoten item)
    {
        
        Console.WriteLine(item.getFEZ() + " - " + item.getName() + " - " + "FEZ");
        Console.WriteLine(item.getFAZ() + " - " + item.getName() + " - " + "FAZ");
        Console.WriteLine(item.getDauer() + " - " + item.getName() + " - " + "Dauer");
        Console.WriteLine(item.getSAZ() + " - " + item.getName() + " - " + "SAZ");
        Console.WriteLine(item.getSEZ() + " - " + item.getName() + " - " + "SEZ");
        Console.WriteLine(item.getGP() + " - " + item.getName() + " - " + "GP");
        Console.WriteLine(item.getFP() + " - " + item.getName() + " - " + "FP");
        Console.WriteLine("---------------------------------------");
    }

}
