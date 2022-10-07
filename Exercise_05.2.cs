using System;

public class Kirja
{
	string kirjaNimi;
	string kirjailija;
	int id;
	float hinta;
	
	public Kirja(string kirjaNimi, string kirjailija, int id, float hinta)
	{
		this.kirjaNimi = kirjaNimi;
		this.kirjailija = kirjailija;
		this.id = id;
		this.hinta = hinta;
	}
	
	public void VertaileKirja(Kirja kirja)
	{
		if (this.hinta > kirja.hinta) {
			Console.WriteLine(this.kirjaNimi + " on kalliimpi kuin " + kirja.kirjaNimi);
		} else {
			Console.WriteLine(this.kirjaNimi + " on halvempi kuin " + kirja.kirjaNimi);
		}
	}
}

class Ohjelma
{
    static void Main(string[] args)
    {
        Kirja k = new Kirja("Kirja", "K. Kirjoittaja", 528, 21.50f);
        Kirja k2 = new Kirja("Toinen Kirja", "O.Kirjailija", 347, 36.90f);
        k.VertaileKirja(k2);
    }
}