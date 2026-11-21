using System.Windows.Controls;

namespace TaskManager_Shihova.View
{
    public partial class Main : Page
    {
        public Main(object Context)
        {
            InitializeComponent();
            DataContext = Context;
        }
    }
}
