namespace Stitky
{
    public partial class MainPage : ContentPage
    {
        // nepotřebuju int VyrCislo;
        public MainPage()
        {
            InitializeComponent();
        }

        // Metoda Nacist je součástí tlačítka Načíst trafo. Načte trafo s požadovaným číslem z nastavené složky
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
