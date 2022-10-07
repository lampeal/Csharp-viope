using System;
using System.Collections.Generic;

class Jumppa : IComparable
{
    public string nimi;
	public string[] ajat;
	public string[] paikat;

	public override string ToString()
    {
        string jumppa = nimi+"\najat:\n";
        for (int i = 0; i < ajat.Length; i++)
        {
            jumppa += ajat[i] + "\n";
        }

        jumppa += "\npaikat:\n";

        for (int i = 0; i < paikat.Length; i++)
        {
            jumppa += paikat[i] + "\n";
        }
        return jumppa;
    }
	
	public Jumppa(string nimi, string[] ajat, string[] paikat)
	{
		this.nimi=nimi;
		this.ajat=ajat;
		this.paikat=paikat;
	}

public int CompareTo(Object obj)
    {
    	Jumppa i = obj as Jumppa;
    	return this.nimi.CompareTo(i.nimi);
    }
}

class Ohjelma
{
	static void Main(string[]args)
	{
		List<Jumppa> jumpat=new List<Jumppa>();
		string[] jAjat={"Keskiviikko 9:30", "Perjantai 9:30"};
		string[] jPaikat={"Liikuntasali"};
		jumpat.Add(new Jumppa("juniori",jAjat,jPaikat));
		
		string[] sAjat={"Maanantai 8:00","Tiistai 8:30"};
		string[] sPaikat={"Liikuntasali"};
		jumpat.Add(new Jumppa("seniori",sAjat,sPaikat));
		
		string[] pAjat={"Lauantai 12:30","Sunnuntai 13:00"};
		string[] pPaikat={"Puisto","Liikuntasali"};
		jumpat.Add(new Jumppa("perhe",pAjat,pPaikat));
		
		string[] nAjat={"Tiistai 8:00","Perjantai 8:00"};
		string[] nPaikat={"Puisto"};
		jumpat.Add(new Jumppa("naisten",nAjat,nPaikat));
		
		string[] mAjat={"Maanantai 8:00","Torstai 8:00"};
		string[] mPaikat={"Liikuntasali","Puisto"};
		jumpat.Add(new Jumppa("miesten",mAjat,mPaikat));
		
		foreach(Jumppa i in jumpat)
		{
			Console.WriteLine(i.ToString());	
		}
	}
}