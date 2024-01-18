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
        Knoten k1 = new Knoten(1,"uwu",3,null);
        knotens.Add(k1);
        Knoten k2 = new Knoten(2, "owo", 1, new List<Knoten>() { k1 });
        knotens.Add(k2);
        Knoten k3 = new Knoten(3, "ara", 1, new List<Knoten>() { k1,k2 });


        foreach (var item in knotens)
        {
            item.LateSetter(knotens);

            Console.WriteLine(item.getFEZ() + " - " + item.getName() + " - " + "FEZ");
            Console.WriteLine(item.getFAZ() + " - " + item.getName() + " - " + "FAZ");
            Console.WriteLine(item.getDauer() + " - " + item.getName() + " - " + "Dauer");
            Console.WriteLine(item.getSAZ() + " - " + item.getName() + " - " + "SAZ");
            Console.WriteLine(item.getSEZ() + " - " + item.getName() + " - " + "SEZ");
            //Console.WriteLine(item.getGP() + " - " + item.getName() + " - " + "GP");
            //Console.WriteLine(item.getFP() + " - " + item.getName() + " - " + "FP");
            Console.WriteLine("---------------------------------------");
        }





            
    }

}
