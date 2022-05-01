using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ListViewExample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListViewGroup : ContentPage
    {
        ObservableCollection<ChampGroup> listChamps = new ObservableCollection<ChampGroup>();
        public ObservableCollection<ChampGroup> ListChamp { get { return listChamps; } }
        public ListViewGroup()
        {
            InitializeComponent();
            ViewChamp.ItemsSource = listChamps;
            listChamps.Add(new ChampGroup("Lee sin", new[] {
            new Champs
            {
                Rol = "Jungla",
                Daño = "Fisico"
            }
            }));
            listChamps.Add(new ChampGroup("Leblanc", new[] {
            new Champs
            {
                Rol = "Mid",
                Daño = "Magico"
            }
            }));
            listChamps.Add(new ChampGroup("Sett", new[] {
            new Champs
            {
                Rol = "Top",
                Daño = "Fisico"
            }
            }));
        }
    }
}