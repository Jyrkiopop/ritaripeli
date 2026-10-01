using System.Collections.Generic;

{
    internal class NuoliKauppa : IKauppa
    {
        private List<TavaraJaHinta> tavarat;

        public NuoliKauppa()
        {
            tavarat = new List<TavaraJaHinta>
            {
                new TavaraJaHinta(new Nuoli("Perusnuoli", vahinko: 2), hinta: 3),
                new TavaraJaHinta(new Nuoli("Hieno nuoli", vahinko: 5), hinta: 10)
            };
        }

        public List<TavaraJaHinta> ListaaTavarat()
        {
            return tavarat;
        }

        public Tavara? OstaTavara(int valittuTavara, Lompakko rahapussi)
        {
            if (valittuTavara < 0 || valittuTavara >= tavarat.Count)
            {
                return null;
            }

            TavaraJaHinta valinta = tavarat[valittuTavara];

            int maksettu = rahapussi.OtaRahaa(valinta.Hinta);
            if (maksettu == 0)
            {
                return null;
            }

            return valinta.Esine;
        }
    }
}