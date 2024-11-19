using System.Collections.ObjectModel;
using System.Linq;
using CommunityToolkit.Mvvm.ComponentModel;

namespace AvaloniaForEmbeddedLinuxTest.ViewModels;

public partial class MainViewModel : ViewModelBase
{
    public string Greeting { get; } = "Welcome to Avalonia!";

    [ObservableProperty]
    private int _value;
    
    public ObservableCollection<int> NumInts { get; } = new(Enumerable.Range(0, 101));
}
