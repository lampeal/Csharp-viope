/* 
Kirjoita C#-kielellä ohjelma, joka luo tiedoston rekisteri.txt. 
Tämän jälkeen ohjelman tulee pyytää kolmen työntekijän tietoja; 
id (int), nimi (string) ja palkka (float) ja kirjoittaa ne rekisteriin. 
Anna tiedostoon seuraavat tiedot:
id: 1 | nimi: Jari | palkka: 3500
id: 2 | nimi: Matti | palkka: 4800
id: 3 | nimi: Tuomas | palkka: 2100 
*/

using System;
using System.IO;
using System.Collections.Generic;

class Program 
{
	int[] id = new int[3];
	string[] nimi = new string[3];
	float[] palkka = new float[3];
	
	string tiedosto = "rekisteri.txt";
	
	public void Kirjoita()
	{
		Console.WriteLine("Anna kolmen työntekijän tiedot (id, nimi, palkka):");
		for (int i = 0; i < id.Length; i++)
		{
			Console.WriteLine("Anna id: ");
			id[i] = Convert.ToInt32(Console.ReadLine());
				
			Console.WriteLine("Anna nimi: ");
			nimi[i] = Console.ReadLine();
				
			Console.WriteLine("Anna palkka: ");
			palkka[i] = (float)Convert.ToDouble(Console.ReadLine());
		}
		
		FileStream fOutStream = File.Open(tiedosto, FileMode.Append, FileAccess.Write);
		StreamWriter sWriter = new StreamWriter(fOutStream);
		for (int i = 0; i < id.Length; i++)
		{
			sWriter.WriteLine(id[i] + " " + nimi[i] + " " + palkka[i]);	
		}
		sWriter.Flush();
		sWriter.Close();
	}
	
	public void tulostaTiedot()
	{
        
        List<int> idt = new List<int>();
        List<string> nimet = new List<string>();
        List<float> palkat = new List<float>();
        
		FileStream fInStream = File.OpenRead(tiedosto);
        StreamReader sReader = new StreamReader(fInStream);

        string rivi = null;
        while ((rivi = sReader.ReadLine()) != null)
        {
            string[] tyontekija = rivi.Split(new char[] { ' ' });
            idt.Add(Convert.ToInt32(tyontekija[0]));
            nimet.Add(tyontekija[1]);
            palkat.Add((float)Convert.ToDouble(tyontekija[2]));
        }

        sReader.Close();

        Console.WriteLine("Anna työntekijän id:");
        int id = Convert.ToInt32(Console.ReadLine());

        if (idt.Contains(id))
        {
            int index = idt.IndexOf(id);
            Console.WriteLine("id: " + idt[index] + " nimi: " + nimet[index] + " palkka: " + palkat[index]);
        }
        else
        {
            Console.WriteLine("Työntekijää ei löydy id-numerolla " + id);
        }
    }

	static void Main(string[] args)
	{
		Program i = new Program();
		i.tulostaTiedot();
	}
}