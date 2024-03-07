using System;
using System.Drawing;
using System.Windows.Forms;

namespace KriitikkoApp
{
    public partial class Form1 : Form
    {
        //Luodaan käyttäjä
        Kriitikko kayttaja;
        //Listanäkymän suosikkirivi
        ListViewItem suosikkiRivi;

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Lomakkeen avaamisen yhteydessä tehtävät toimet
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            //Taulukko yhden elokuvan tiedoille
            string[] tiedot = new string[4];
            //Listanäkymän yksi rivi
            ListViewItem rivi;

            //listanäkymän muoto
            listView1.View = View.Details;
            //Apuviivat näkyviin
            listView1.GridLines = true;

            //Lisätään otsikot taulukkoon
            listView1.Columns.Add("Leffa", 100);
            listView1.Columns.Add("Komentti", 300);
            listView1.Columns.Add("Pituus", 100);
            listView1.Columns.Add("Arvosana", 100);

            //Lisätään srvosteluja
            kayttaja = new Kriitikko();
            kayttaja.LisaaLeffa(new Leffa("RED", "Hauska", new TimeSpan(1, 45, 00), 8));
            kayttaja.LisaaLeffa(new Leffa("MIB", "Loistava", new TimeSpan(2, 19, 00), 9));
            kayttaja.LisaaLeffa(new Leffa("Reservoir Dogs", "Verinen", new TimeSpan(1, 31, 00), 1));

            //Lisätään rivejä listanäkymään elokuva kerrallaan
            foreach(Leffa leffa in kayttaja.Leffat)
            {
                tiedot[0] = leffa.Nimi;
                tiedot[1] = leffa.Kuvaus;
                tiedot[2] = leffa.Pituus.ToString();
                tiedot[3] = leffa.Arvosana.ToString();
                rivi = new ListViewItem(tiedot);
                if(leffa.Nimi == kayttaja.Suosikki.Nimi)
                {
                    rivi.BackColor = Color.Yellow;
                    suosikkiRivi = rivi;
                }
                listView1.Items.Add(rivi);
            }
        }

        /// <summary>
        /// Elokuvan lisäys-nappulan painamisen toiminnot
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            // Taulukko yhden elokuvan tiedoille.
            string[] tiedot = new string[4];
            // Listanäkymän yksi rivi.
            ListViewItem rivi;
            // Luetaan tiedot lomakkeesta taulukkoon.
            tiedot[0] = leffanNimi.Text;
            tiedot[1] = leffanKommentti.Text;
            tiedot[2] = leffanPituus.Text;
            tiedot[3] = leffanArvosana.Text;
            // Muunnetaan taulukko listan riviksi.
            rivi = new ListViewItem(tiedot);
            // Merkataan, jos uusi suosikki.
            if (int.Parse(leffanArvosana.Text) > kayttaja.Suosikki.Arvosana)
            {
                rivi.BackColor = Color.Yellow;
                suosikkiRivi.BackColor = Color.Transparent;
                suosikkiRivi = rivi;
            }
            
            // Lisätään listan rivi listanäkymään.
            listView1.Items.Add(rivi);
            // Lisätään elokuva käyttäjän listaan.
            int tunnit, minuutit, sekunnit;
            string[] aika = new string[3];
            aika = tiedot[2].Split(':');
            tunnit = int.Parse(aika[0]);
            minuutit = int.Parse(aika[1]);
            sekunnit = int.Parse(aika[2]);
            TimeSpan pituus = new TimeSpan(tunnit, minuutit, sekunnit);
            kayttaja.LisaaLeffa(new Leffa(tiedot[0], tiedot[1], pituus, int.Parse(tiedot[3])));
        }
    }
}
