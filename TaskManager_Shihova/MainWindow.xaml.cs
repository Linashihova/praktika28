using System.Windows;
using TaskManager_Shihova.ViewModels;

namespace TaskManager_Shihova
{
    public partial class MainWindow : Window
    {
        public static MainWindow init;
        public MainWindow()
        {
            InitializeComponent();
            init = this;
            DataContext = new VM_Pages();
        }
    }
}