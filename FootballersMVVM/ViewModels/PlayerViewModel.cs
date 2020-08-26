using FootballersMVVM.Models;

namespace FootballersMVVM.ViewModels {
   
    /// <summary>
    /// Implementation of Player in View Model
    /// </summary>
    class PlayerViewModel : BaseViewModel {

        private Player player;
        public PlayerViewModel(string name, string surname, int weight, int age) {
            this.player = new Player(name, surname, weight, age);
        }

        public PlayerViewModel() {
            player = new Player(string.Empty, string.Empty, 50, 20);
        }

        public PlayerViewModel(PlayerViewModel player) {
            this.player = new Player();
            this.player.Name = player.Name;
            this.player.Surname = player.Surname;
            this.player.Weight = player.Weight;
            this.player.Age = player.Age;
        }
        public string Name {
            get { return player.Name; }
            set { player.Name = value; onPropertyChanged(nameof(Name)); }
        }
        public string Surname {
            get { return player.Surname; }
            set { player.Surname = value; onPropertyChanged(nameof(Surname)); }
        }

        public int Weight {
            get { return player.Weight; }
            set { player.Weight = value; onPropertyChanged(nameof(Weight)); }
        }

        public int Age {
            get { return player.Age; }
            set { player.Age = value; onPropertyChanged(nameof(Age)); }
        }

        public string Description {
            get {return player.Description; }
            set { onPropertyChanged(nameof(Description));  }
        }
    }
}
