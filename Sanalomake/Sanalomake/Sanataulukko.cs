namespace Sanalomake
{
    class Sanataulukko
    {
        string[] sanat;
        int sanoja;

        public Sanataulukko()
        {
            sanat = new string[100];
            sanoja = 0;
        }
        //Lisaasanat 
        public void LisaaSana(string sana) 
        {
            sanat[sanoja] = sana;
            sanoja++;
        }
        //HaeSanat palauttaa sanataulukon.
        public string[] HaeSanat()
        {
            return sanat;
        }
        //HaeKannteinen palautta sanat
        public string[] HaeKaanteinen()
        {
            string[] kaanteinen = new string[100];
            for (int i = 0; i < sanoja; i++)
            {
                kaanteinen[i] = sanat[sanoja - 1 - i];
            }
            return kaanteinen;

        }
    }
}
