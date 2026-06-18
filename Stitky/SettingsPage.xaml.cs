using CommunityToolkit.Maui.Storage;
namespace Stitky
{
    public partial class SettingsPage : ContentPage
    {
        public SettingsPage()
        {
            InitializeComponent();

            SlozkaProtokolu.Text =
                  Preferences.Get("SlozkaProtokolu", "");

        }

        private async void VyberSlozkyProtokolu(object sender, EventArgs e)
        {
            string VybranaSlozka = string.Empty;
            var result = await FolderPicker.Default.PickAsync();
            
            // Výběr složky protokolů a uložení cesty do nastavení aplikace
            
            if (result.IsSuccessful)
            {
                VybranaSlozka = result.Folder.Path;
                SlozkaProtokolu.Text = VybranaSlozka;

                //Uložení cesty do nastavení aplikace
                Preferences.Set(
                            "SlozkaProtokolu",
                            result.Folder.Path);

            }
            else
            {
                SlozkaProtokolu.Text = "Nebyla vybrána žádná složka.";
            }
        }
    }
}