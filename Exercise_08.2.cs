using System;

public interface IAsiakas
{
	string HaeAsiakas(string Nimi, object obj);
	float LaskeBonus();
}

public interface ITuote
{
	string HaeTuote(string Nimi, object obj);
	float LaskeYhteisArvo();
}

public class Asiakas : IAsiakas
{
	protected string AsiakasNimi;
	protected float ostokset;
	
	public Asiakas(string AsiakasNimi, float ostokset)
	{
	    this.AsiakasNimi = AsiakasNimi;
	    this.ostokset = ostokset;
	}
	
	public override string ToString()
    {
        return AsiakasNimi + ", " + ostokset;
    }
	
	public string HaeAsiakas(string Nimi, object obj)
	{
		if (this.AsiakasNimi == Nimi) {
            return ToString();
		} else {
		    return null;
		}
	}
	
	public float LaskeBonus()
	{
		if (this.ostokset <= 1000) {
			return this.ostokset * 0.02f;
		} else if (this.ostokset > 1000 && this.ostokset <= 2000) {
	    	return this.ostokset * 0.03f;
		} else { 
			return this.ostokset * 0.05f;
	    }
    }
}

public class Tuote : ITuote
{
	protected string nimi;
	protected float yksikkoHinta;
	protected int lukuMaara;
	
	public Tuote(string nimi, float yksikkoHinta, int lukuMaara)
	{
		this.nimi = nimi;
		this.yksikkoHinta = yksikkoHinta;
		this.lukuMaara = lukuMaara;
	}
	
    public override string ToString()
    {
        return nimi + ", " + yksikkoHinta + ", " + lukuMaara;
    }
	
	public string HaeTuote(string Nimi, object obj)
	{
		if (this.nimi == Nimi) {
            return "Tuote";
		 } else {
		    return null;
		}
	}
	
	public float LaskeYhteisArvo()
	{
		float yhteisArvo = yksikkoHinta * lukuMaara;
		return yhteisArvo;
	}
}

class Ohjelma
{
    static void Main (string[] args)
    {
        Asiakas[] asiakkaat = new Asiakas[3];
        asiakkaat[0] = new Asiakas("Jari", 300);
        asiakkaat[1] = new Asiakas("Teppo", 3900);
        asiakkaat[2] = new Asiakas("Johanna", 2200);

        for (int i = 0; i < asiakkaat.Length; i++)
		{
            Console.WriteLine(asiakkaat[i].HaeAsiakas("Teppo", asiakkaat[i]));
            Console.WriteLine(asiakkaat[i].LaskeBonus());
		}
    }
}
