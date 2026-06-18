namespace Stitky
{
    public partial class MainPage : ContentPage
    {
        
        public MainPage()
        {
            InitializeComponent();

            //Načtení nastavení složky protokolů při spuštění aplikace
            string slozkaProtokolu =
                Preferences.Get("SlozkaProtokolu", "");

        }

        // Metoda Nacist je akcí tlačítka Načíst trafo. Načte trafo s požadovaným číslem z nastavené složky
        public void Nacist(object sender, EventArgs e)
        {
            
            if (!int.TryParse(Cislo.Text, out int cislo))
            {
                NacteneCislo.Text = "Zadej platné číslo!";
            }
            else
            {
                Trafo noveTrafo = new Trafo(cislo);
                NacteneCislo.Text = "Načteno trafo číslo: " + noveTrafo.VyrCislo;
            }
        }

        
    }
}
