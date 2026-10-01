using System;

internal class RuokaAnnos: Tavara
{
	public int Parannus { get; }

	public RuokaAnnos(string nimi, int Parannus) : base(nimi)
    {
        Parannus = parannus;
    }
}