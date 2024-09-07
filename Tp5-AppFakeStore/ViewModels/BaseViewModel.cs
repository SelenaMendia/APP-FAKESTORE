using CommunityToolkit.Mvvm.ComponentModel;

namespace Tp5_AppFakeStore.ViewModels;

public partial class BaseViewModel : ObservableObject
{
    [ObservableProperty]
    private bool isBusy;

    [ObservableProperty]
    private string title;
}
