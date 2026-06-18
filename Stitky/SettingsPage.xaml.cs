using CommunityToolkit.Maui.Storage;
namespace Stitky
{
    public partial class SettingsPage : ContentPage
    {
        public SettingsPage()
        {
            InitializeComponent();
        }

        private async void VyberSlozkyProtokolu(object sender, EventArgs e)
        {
            string VybranaSlozka = string.Empty;
            var result = await FolderPicker.Default.PickAsync();

            if (result.IsSuccessful)
            {
                VybranaSlozka = result.Folder.Path;
                SlozkaProtokolu.Text = VybranaSlozka;
            }
            else
            {
                SlozkaProtokolu.Text = "Nebyla vybrána žádná složka.";
            }
        }
    }
}