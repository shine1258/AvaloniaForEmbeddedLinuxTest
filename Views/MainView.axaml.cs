using Avalonia.Controls;
using AvaloniaForEmbeddedLinuxTest.ViewModels;

namespace AvaloniaForEmbeddedLinuxTest.Views;

public partial class MainView : UserControl
{
    public MainView()
    {
        InitializeComponent();
        DataContext = new MainViewModel();
    }
}
