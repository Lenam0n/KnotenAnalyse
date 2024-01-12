using System;
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
        Knoten k1 = new Knoten(1,"uwu",3);
        knotens.Add(k1);
        Knoten k2 = new Knoten(2, "owo", 1, new List<Knoten>() { k1 });
        knotens.Add(k2);
        Knoten k3 = new Knoten(3, "ara", 1, new List<Knoten>() { k1,k2 });

        /*
        Console.WriteLine( k1.getFEZ() + " K1");
        Console.WriteLine( k1.getFEZ() + " K2");
        Console.WriteLine( k3.getFEZ() + " K3");        
        Console.WriteLine( k1.getFAZ() + " K1");
        Console.WriteLine( k1.getFAZ() + " K2");
        Console.WriteLine( k3.getFAZ() + " K3");        
        Console.WriteLine( k1.getDauer() + " K1");
        Console.WriteLine( k1.getDauer() + " K2");
        Console.WriteLine( k3.getDauer() + " K3");*/
        
    }

}
