using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace Four_in_a_row.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private string circle = "O";

        public string IsTaken
        {
            get { return circle; }
            set
            {
                //if (circle != value)
                //{
                circle = "O";
                OnPropertyChanged(nameof(IsTaken));
                //}
            }
        }
    }
}
