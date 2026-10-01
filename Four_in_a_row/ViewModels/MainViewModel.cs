using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using Four_in_a_row.Commands;

namespace Four_in_a_row.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {

        public MainViewModel()
        {
            ToggleXO = new RelayCommand(Toggle);
        }
        public RelayCommand ToggleXO { get; }
        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private string circle;

        public string IsTaken
        {
            get { return circle; }
            set
            {
                if (circle != value)
                {
                    circle = value;
                    OnPropertyChanged(nameof(IsTaken));
                }
            }
        }
        public void Toggle(object? parameter)
        {
            if (IsTaken == "O")
            {
                IsTaken = "X";
            }
            else
            {
                IsTaken = "O";
            }
        }
    }
}
