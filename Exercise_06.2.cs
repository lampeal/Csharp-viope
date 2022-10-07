using System;

class Kirja
{
	public string Nimi;
	string kirjailija;
	string kustantaja;
	public float hinta = 0.0f;
	public string teema;
	public static string teemanNimi;
	
	public float Hinta
	{
		get
		{
		    if (hinta > 30) {
			return hinta * 0.9f;
		} else {
		    return hinta;
		    }
		}
		set
		{
		    if (hinta > 30) {
		        hinta = value * 0.9f;
		    } else { 
		        hinta = value;
		    }
		}
    }
	
	public Kirja()
	{
		this.Nimi = "Ei tiedossa";
		this.kirjailija = "Ei tiedossa";
		this.kustantaja = "Ei tiedossa";
		this.hinta = 0.0f;
		this.teema = "Ei tiedossa";
	}
	
	public Kirja(string Nimi, string kirjailija, string kustantaja, float hinta, string teema)
	{
		this.Nimi = Nimi;
		this.kirjailija = kirjailija;
		this.kustantaja = kustantaja;
		this.hinta = hinta;
		this.teema = teema;
	}
	
	public Kirja(Kirja kirja)
	{
		this.Nimi = kirja.Nimi;
		this.kirjailija = kirja.kirjailija;
		this.kustantaja = kirja.kustantaja;
		this.hinta = kirja.hinta;
		this.teema = kirja.teema;
	}
	
	public void HaeKirja(string Nimi)
	{
		if (this.Nimi == Nimi) {
			Console.WriteLine(Nimi + ", " + kirjailija + ", " + kustantaja + ", " + teema + ", " + hinta);
		} else { 
			Console.WriteLine("Kirjaa ei löytynyt.");
		}
	}
}

class Program
{
    public static void VaihdaTeema(Kirja kirja, string teemanNimi)
	{
		kirja.teema = teemanNimi;
	}

    static void Main(string[] args)
    {
        Kirja k = new Kirja("Kirja", "K. Kirjoittaja", "Kustannus Oy", 21.50f, "Dekkari");
        Kirja k2 = new Kirja("Toinen Kirja", "O. Kirjailija", "Kustantaja Ab", 36.90f, "Fantasia");
        Console.WriteLine(k.hinta);
        Console.WriteLine(k2.Hinta);
    }
}