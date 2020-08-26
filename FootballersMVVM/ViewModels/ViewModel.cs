using FootballersMVVM.Models;
using System.Collections.ObjectModel;
using System.Windows.Controls.Primitives;
using System.Windows.Documents;

namespace FootballersMVVM.ViewModels {
    class ViewModel : BaseViewModel {
        private PlayerViewModel selectedPlayer;
        private PlayerViewModel newPlayer;
        private PlayerViewModel displayedPlayer;

        private ObservableCollection<PlayerViewModel> listOfPlayers;
        private RelayCommand addCommand;
        private RelayCommand modifyCommand;
        private RelayCommand deleteCommand;
        private RelayCommand saveCommand;

        public PlayerViewModel SelectedPlayer {
            get { return selectedPlayer; }
            set {
                if(value != null) {
                    selectedPlayer = value;
                    //displayedPlayer = new PlayerViewModel(value);
                    displayedPlayer.Name = value.Name;
                    displayedPlayer.Surname = value.Surname;
                    displayedPlayer.Age = value.Age;
                    displayedPlayer.Weight = value.Weight;
                }
            }
        }
        public PlayerViewModel NewPlayer { 
            get { return newPlayer; } 
        }
        public PlayerViewModel DisplayedPlayer {
            get { return displayedPlayer; }
        }
        
        public ViewModel() {
            listOfPlayers = StateOfAplication.Load();
            if(listOfPlayers.Count > 0) {
                //displayedPlayer = new PlayerViewModel(listOfPlayers[0]);

                displayedPlayer = new PlayerViewModel(
                    listOfPlayers[0].Name, listOfPlayers[0].Surname, listOfPlayers[0].Weight, listOfPlayers[0].Age);
                selectedPlayer = listOfPlayers[0];
            }
            else
                displayedPlayer = null;
            newPlayer = new PlayerViewModel();
        }

        public ObservableCollection<PlayerViewModel> ListOfPlayers {
            get { return listOfPlayers; }
            set { listOfPlayers = value; onPropertyChanged(nameof(ListOfPlayers)); }
        }

        public RelayCommand Save {
            get {
                if(saveCommand == null)
                    saveCommand = new RelayCommand(argument => { StateOfAplication.Save(listOfPlayers); }, argument => true);
                return saveCommand;
            }
        }
        public RelayCommand Add {
            get {
                if(addCommand == null) {
                    addCommand = new RelayCommand(argument => {
                        if(selectedPlayer != null) {
                            newPlayer = new PlayerViewModel(displayedPlayer);
                           
                            //newPlayer.Name = displayedPlayer.Name;
                            //newPlayer.Surname = displayedPlayer.Surname;
                            //newPlayer.Age = displayedPlayer.Age;
                            //newPlayer.Weight = displayedPlayer.Weight;
                            ListOfPlayers.Add(newPlayer);
                            selectedPlayer = ListOfPlayers[ListOfPlayers.Count -1];
                            System.Windows.MessageBox.Show("Postać została dodana do bazy!");
                        }
                    }, argument => true);
                }
                return addCommand;
            }
        }
        public RelayCommand Modify {
            get {
                if(modifyCommand == null) {
                    modifyCommand = new RelayCommand(argument => {
                        if(selectedPlayer != null) {
                            if(selectedPlayer != null & !string.IsNullOrEmpty(displayedPlayer.Name) &
                           !string.IsNullOrEmpty(displayedPlayer.Surname)) {
                                //selectedPlayer = new PlayerViewModel(selectedPlayer);
                                selectedPlayer.Name = displayedPlayer.Name;
                                selectedPlayer.Surname = displayedPlayer.Surname;
                                selectedPlayer.Age = displayedPlayer.Age;
                                selectedPlayer.Weight = displayedPlayer.Weight;
                            }
                        }
                    }, argument => true);
                   
                }
                return modifyCommand;
            }
        }
        public RelayCommand Delete {
            get {

                if(deleteCommand == null)
                    deleteCommand = new RelayCommand(argument => {
                        listOfPlayers.Remove(selectedPlayer);
                    },
                        argument => true);
                return deleteCommand;
            }
        }

    }
}
