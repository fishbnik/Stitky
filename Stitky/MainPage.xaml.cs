namespace Stitky
{
    public partial class MainPage : ContentPage
    {
        Single VyrCislo;
        public MainPage()
        {
            InitializeComponent();
        }

        public void OnKlik(object? sender, EventArgs e)
        {

            int VyrCislo;

            if (int.TryParse(Cislo.Text, out VyrCislo))
            {
                NacteneCislo.Text = "Načtené trafo číslo: " + VyrCislo;
            }
            else
            {
                NacteneCislo.Text = "Zadej platné číslo!";
            }


        }
    }
}
