using OverwatchLibrary;
using OverwatchLibrary.Factories;
using OverwatchLibrary.Interfaces;

namespace OverwatchOcrReader.ViewModels;

public partial class MainViewModel : ViewModelBase
{
    public string Greeting => "Welcome to Avalonia!";

    public MainViewModel()
    {
        IHero hero01 = HeroFactory.CreateHero("DUMMY");
    }
}
