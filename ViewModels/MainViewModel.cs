using System.Collections.ObjectModel;
using System.Linq;

namespace AvaloniaForEmbeddedLinuxTest.ViewModels;

public partial class MainViewModel : ViewModelBase
{
    public string Greeting { get; } = "Welcome to Avalonia!";

    public ObservableCollection<int> NumInts { get; } = new(Enumerable.Range(100, 500));
}
