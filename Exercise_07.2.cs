using System;

class KulkuValine
{
	protected string tyyppi;
	protected string merkki;
	protected int vuosiMalli;
	protected float hinta;

	public KulkuValine()
	{
		tyyppi = "Tuntematon";
		merkki = "Tuntematon";
		vuosiMalli = 0;
		hinta = 0;
	}

	public KulkuValine(string tyyppi, string merkki, int vuosiMalli, float hinta)
	{
		this.tyyppi = tyyppi;
		this.merkki = merkki;
		this.vuosiMalli = vuosiMalli;
		this.hinta = hinta;
	}
	
	public virtual void TulostaTiedot()
	{
		Console.WriteLine(tyyppi + ", " + merkki + ", " + vuosiMalli + ", " + hinta);
	}
}

class Auto : KulkuValine
{
	int koneenKoko;
	string malli;
	int ovienLkm;
	
	public Auto() : base()
	{
	koneenKoko = 0;
	malli = "Tuntematon";
	ovienLkm = 0;
	}
	
	public Auto(string tyyppi, string merkki, int vuosiMalli, float hinta, int koneenKoko, string malli, int ovienLkm) : base(tyyppi, merkki, vuosiMalli, hinta)
	{
	this.koneenKoko = koneenKoko;
	this.malli = malli;
	this.ovienLkm = ovienLkm;
	}
	
	public override void TulostaTiedot()
	{
	    Console.WriteLine(tyyppi + ", " + merkki + ", " + vuosiMalli + ", " + hinta + ", " + koneenKoko + ", " + malli + ", " + ovienLkm);
	}
	
 	public override string ToString()
 	{
		return tyyppi + ", " + merkki + ", " + vuosiMalli + ", " + hinta + ", " + koneenKoko + ", " + malli + ", " + ovienLkm;
 	}
}

class Ohjelma
{
    static void Main(string[] args)
    {
        Auto a = new Auto("maasto", "Honda", 2014, 18190f, 143, "Civic", 4);
        Auto a2 = new Auto("farmari", "Skoda", 2014, 22990f, 151, "Octavia", 4);
        Console.WriteLine(a.ToString() + "\n" + a2.ToString());
        Console.WriteLine(a.Equals(a2));
    }
}