using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace ListViewExample
{
    public class ChampGroup : ObservableCollection<Champs>
    {
        public string Campeones { get; set; }

        public ChampGroup(string campeones, IEnumerable<Champs> source)
            : base(source)
        {
            Campeones = campeones;
        }
    }
}