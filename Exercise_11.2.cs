/* Ohjelma, joka pyytää ja lukee tiedoston nimen, jonka sisällön se 
tulostaa näytölle jos tiedosto löytyy. Ohjelman tulee toimia hallitusti 
jos tiedostoa ei löydykään. Tiedosto, jonka ohjelma löytää on nimeltään 
tiedosto.txt Vihje: Ohjelmassa tulee käsitellä FileNotFoundException-poikkeus. */

using System;
using System.IO;

class Program
{
	static void Main(string[] args)
	{
		string FileToFind = string.Empty;
		try
		{
			Console.WriteLine("Anna tiedoston nimi:");
			FileToFind = Console.ReadLine();
			
			string[] lines = File.ReadAllLines(FileToFind);
			foreach (string line in lines)
			{
				Console.WriteLine(line);
			}
		}
		catch (FileNotFoundException e)
		{
				Console.WriteLine("Tiedostoa ei löytynyt nimellä {0}", FileToFind);
		}
		Console.ReadLine();
	}
}