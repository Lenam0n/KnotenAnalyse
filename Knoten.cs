using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Knoten
{
    private int Id { get; set; }
    private string Name { get; set; }
    private int Dauer { get; set; }
    private int FEZ { get; set; }
    private int FAZ { get; set; }
    private List<Knoten>? Pre { get;set; }

    public Knoten(Knoten k)
    {
        Pre = new List<Knoten>();
        Pre.Add(k);
    }
    public Knoten()
    {
        Pre = null;
    }    
    public Knoten(int ID, int Dauer, int FEZ, int FAZ)
    {
        Id = ID;
        Name = Name;
    }

    public void test()
    {
        FEZ = FAZ + Dauer;
    }
}

