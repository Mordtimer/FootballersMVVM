using System;
using System.Collections.Generic;
using System.Text;

namespace FootballersMVVM.Models {
    public class Player {
        public Player() { }

        public Player(string name, string surname, int weight, int age) {
            Name = name;
            Surname = surname;
            Weight = weight;
            Age = age;
        }

        #region Properties
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Weight { get; set; }
        public int Age { get; set; }
        public string Description { get { return this.ToString(); } }
        #endregion

        public override string ToString() {
            return $"{Name} {Surname} waga: {Weight}, wiek: {Age}";
        }
    }
}
