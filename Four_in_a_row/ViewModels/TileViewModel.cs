using Four_in_a_row.Commands;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;

namespace Four_in_a_row.ViewModels
{
    public class TileViewModel : INotifyPropertyChanged
    {

        public ICommand ToggleCommand { get; }

        public TileViewModel()
        {
            ToggleCommand = new RelayCommand(InsertCircle);
        }

        private string _circle = "";

        public string IsTaken
        {
            get { return _circle; }
            set
            {
                if (_circle != value)
                {
                    _circle = value;
                    OnPropertyChanged(nameof(IsTaken));
                }
            }
        }
        public void InsertCircle()
        {        
                IsTaken = "O";     
        }
        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
