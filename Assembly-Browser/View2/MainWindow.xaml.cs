using System.Windows;
using System.Windows.Input;
using ViewModel;

namespace AssemblyBrowser
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var viewModel = new MainView();
            DataContext = viewModel;
            var commandBinding = new CommandBinding();
            commandBinding.Command = ApplicationCommands.Open;
            commandBinding.Executed += viewModel.LoadAssembly;
            menuItem_Open.CommandBindings.Add(commandBinding);
        }
    }
}
