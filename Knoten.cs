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
        }
        else
        {
            this.FAZ = 0;
            Pre = null;
        }

        this.FEZ = FEZCalc();
    }

    // Constructor without the Knoten k parameter
    public Knoten(int ID, string Name, int Dauer)
    {
        this.ID = ID;
        this.Name = Name;
        this.Dauer = Dauer;

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

    //FUNKTIONEN

    private void knotencheck(List<Knoten> k)
    {
        Pre = new List<Knoten>();
        foreach (Knoten knoten in k)
        {
            Pre.Add(knoten);
        }
    }
    
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


    private Knoten? NachfolgerKnotenSuchen(List<Knoten> alleKnoten)
    {
        foreach (var knoten in alleKnoten)
        {
            if (knoten.Pre != null && knoten.Pre.Contains(this))
            {
                return knoten;
            }
        }
        return null;
    }

    private int FEZCalc(){ return FEZ = this.FAZ + this.Dauer;}
    private int SAZCalc(){ return SAZ = this.SEZ - this.Dauer;}
    private int SEZCalc(List<Knoten> l)
    {
        var nachfolger = NachfolgerKnotenSuchen(l); 
        return SEZ = nachfolger == null ? this.FEZ : FAZCalc2(l);   
    } 
    private int GPCalc(){ return GP = this.SEZ - this.FEZ; }
    private int FPCalc(Knoten k){ return FP = k.FAZ - this.FEZ; }

    public void LateSetter(List<Knoten> l)
    {
        this.SEZ = SEZCalc(l);
        this.SAZ = SAZCalc();
        this.GP = GPCalc();
        this.FP = (NachfolgerKnotenSuchen(l) is Knoten nachfolger) ? FPCalc(nachfolger) : 0;

    }

    private int FAZCalc2(List<Knoten>? k = null)
    {
        List<Knoten>? l = new List<Knoten>();
        foreach (var knoten in k)
        {
            if (knoten.Pre != null && knoten.Pre.Contains(this))
            {
                l.Add(knoten);
            }
        }


        int lowest = 0;
        if (l != null)
        {
            foreach (var item in l)
            {
                int v = item.getFEZ();
                if (v < lowest) lowest = v;
            }
            return lowest;
        }
        return lowest;
    }

}

