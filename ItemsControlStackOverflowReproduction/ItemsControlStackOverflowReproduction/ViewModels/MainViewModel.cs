namespace ItemsControlStackOverflowReproduction.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        public string[] Values { get; } = new[]
        {
            "Hello",
            "World"
        };
    }
}