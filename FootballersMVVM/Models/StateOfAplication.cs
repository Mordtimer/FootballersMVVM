using FootballersMVVM.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;

namespace FootballersMVVM.Models {
    class StateOfAplication {

        private static string filePath = "Footballers.txt";
        public static ObservableCollection<PlayerViewModel> players = new ObservableCollection<PlayerViewModel>();
        
        /// <summary>
        /// Wczytanie Listy piłkarzy z pliku txt
        /// </summary>
        /// <returns>Lista zawodników PlayerViewModel</returns>
        public static ObservableCollection<PlayerViewModel> Load() {
            ObservableCollection<PlayerViewModel> team = new ObservableCollection<PlayerViewModel>();

            // Wczytanie tekstu z pliku i utworzenie listy piłkarzy
            string dataFromFile = File.ReadAllText(filePath).Trim();
            List<string> txtPlayers = dataFromFile.Split(Environment.NewLine).ToList();

            // Tworzenie listy obiektów PlayerViewModel
            try {
                txtPlayers.ForEach(txtPlayer => team.Add(ConvertToPlayerVM(txtPlayer)));
            }
            catch { }
                return team;
        }

        /// <summary>
        /// Konwersja stringa do obiektu PlayerViewModel
        /// </summary>
        /// <returns>Piłkarz przedstawiony za pomocą PlayerViewModel</returns>
        private static PlayerViewModel ConvertToPlayerVM(string txtPlayer) {
            // 0 - imie, 1 - nazwisko, 2 - wiek, 3 - waga
            string[] playerInfo = txtPlayer.Split(';');

            string name = playerInfo[0].Trim();
            string lastName = playerInfo[1].Trim();
            int age = 0;
            int weight = 0;

            try {
                age = int.Parse(playerInfo[2].Trim());
                weight = int.Parse(playerInfo[3].Trim());
            }
            catch { }

            return new PlayerViewModel(name, lastName, weight, age);
        }

        /// <summary>
        /// Zapisanie aktualnego stanu aplikacji do piku
        /// </summary>
        /// <param name="collectionOfPlayers">Aktualny stan listy graczy</param>
        public static void Save(ObservableCollection<PlayerViewModel> collectionOfPlayers) {
            
            string dataToSave = string.Empty;
            foreach(PlayerViewModel player in collectionOfPlayers) {
                dataToSave += $"{player.Name} ; {player.Surname} ; {player.Age} ; {player.Weight} {Environment.NewLine}";
            }
            File.WriteAllText(filePath, dataToSave.Trim());
        }

        }
    }
