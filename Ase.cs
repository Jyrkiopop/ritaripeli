namespace ritaripeli
{
    internal class Ase : Tavara
    {
        public int Vahinko { get; }

        public Ase(string nimi, int vahinko) : base(nimi)
        {
            Vahinko = vahinko;
        }
    }
}
