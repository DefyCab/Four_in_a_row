using System.Windows;
using Four_in_a_row.ViewModels;


namespace Four_in_a_row
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            DataContext = new MainViewModel();
        }
    }
}