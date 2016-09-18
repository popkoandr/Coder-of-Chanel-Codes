using System.Windows;
using ChanelCodeCoder.ViewModels;

namespace ChannelCodesCoder
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            var vm = new MainWindowViewModel();
            InitializeComponent();
            this.DataContext = vm;
        }

    }
}
