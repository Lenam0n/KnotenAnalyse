using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Knoten
{
    private int ID { get; set; }
    private string Name { get; set; }
    private int Dauer { get; set; }
    private int FEZ { get; set; }
    private int FAZ { get; set; }    
    private int SEZ { get; set; }
    private int SAZ { get; set; }
    private int FP { get; set; }
    private int GP { get; set; }
    private List<Knoten>? Pre { get;set; }

    public Knoten(int ID, string Name, int Dauer, List<Knoten>? k = null)
        : this(ID, Name, Dauer)
    {

        // Additional logic when Knoten k is not null
        if (k != null)
        {
            knotencheck(k);
            this.FAZ = FAZCalc(k);
            Console.WriteLine(this.FAZ + "anf1" + this.Name);

        }
        else
        {
            Console.WriteLine("UUWUWUUWWU");
            this.FAZ = 100;
            ueu();
        }
    }

    // Constructor without the Knoten k parameter
    public Knoten(int ID, string Name, int Dauer)
    {
        this.ID = ID;
        this.Name = Name;
        this.Dauer = Dauer;
        this.FEZ = FEZCalc();
        Console.WriteLine(this.FAZ+ "anf2" + this.Name);
        //Console.WriteLine(this.FEZ + "end");

    }



    //GETTER

    public int getID() { return this.ID; }
    public string getName(){ return this.Name;}
    public int getDauer(){ return this.Dauer;}
    public int getFAZ(){ return this.FAZ; }    
    public int getFEZ(){ return this.FEZ;}
    public int getSAZ() { return this.SAZ; }
    public int getSEZ() { return this.SEZ; }
    public int getGP() { return this.GP; }
    public int getFP() { return this.FP; }
    public List<Knoten>? getPRE() { return this.Pre; }

    //SETTER
    /*
    public int setID(){ return this.ID;}
    public string setName(){ return this.Name;}
    public int setDauer(){ return this.Dauer;}
    public int setFAZ(){ return this.FAZ;}
    public int setFEZ() { return this.FEZ;}
    */

    //FUNKTIONEN

    private void knotencheck(List<Knoten> k)
    {
        Pre = new List<Knoten>();
        foreach (Knoten knoten in k)
        {
            Pre.Add(knoten);
        }

    }
    private void ueu() { Pre = null;}
    private int FAZCalc(List<Knoten>? k = null)
    {
        int highest = 0;
        foreach (var item in k)
        {
            int v = item.getFEZ();
            if (v > highest) highest = v;
        }

        return highest;
    }
    private int FEZCalc(){ return FEZ = this.FAZ + this.Dauer;}    
    public int SAZCalc(){ return SAZ = this.SEZ - this.Dauer;}
    public int SEZCalc(Knoten k){ return SEZ = k.FAZ - this.SAZ; }
    public int GPCalc(){ return GP = this.SEZ - this.FEZ; }    
    public int FPCalc(Knoten k){ return FP = k.FAZ - this.FEZ; }
    public void print()
    {
        Console.WriteLine(ID + "," + Name + "," + Dauer + "," + FAZ + "," );
        if(Pre != null)
        {
            Console.WriteLine(Pre[0].Name);
        }
    }
}

