/* Ohjelma, joka jatkuvasti pyytää käyttäjältä kaksi kokonaislukua, 
jakaa ne keskenään ja tallentaa jakolaskun tuloksen taulukkoon, jossa 
on kolmelle alkiolle tilaa. Ohjelman tulee toimia hallitusti jos luvut 
ovat väärässä formaatissa, taulukossa ei ole enää tilaa tai sattuu nollalla 
jako. Vihje: Ohjelmassa tulee käsitellä seuraavat poikkeukset: FormatException, 
IndexOutOfRangeException sekä DivideByZeroException. */
using System;

class Program
{
	static void Main(string[] args)
	{
		int[] tulokset = new int[3];
		try
		{
			for (int i=0; i < 3; i++)
			{
				Console.WriteLine("Anna kaksi kokonaislukua:");
				int luku1 = Convert.ToInt32(Console.ReadLine());
				int luku2 = Convert.ToInt32(Console.ReadLine());
				tulokset[i] = luku1 / luku2;
			}
		}
		catch (FormatException e)
		{
				Console.WriteLine("Luvut ovat väärässä formaatissa.");
		}
		catch (IndexOutOfRangeException e)
		{
				Console.WriteLine("Taulukossa ei ole enää tilaa.");
		}
		catch (DivideByZeroException e)
		{
			Console.WriteLine("Yritit jakaa nollalla.");
		}
	}
}