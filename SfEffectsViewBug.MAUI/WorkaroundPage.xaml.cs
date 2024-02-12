using CommunityToolkit.Mvvm.Input;
using SfEffectsViewBug.MAUI.Models;
using Syncfusion.Maui.Core;

namespace SfEffectsViewBug.MAUI;

public partial class WorkaroundPage
{
    public List<DataModel> Data { get; set; } = new();

    public AsyncRelayCommand TouchUpCommand { get; set; }

    public WorkaroundPage()
    {
        for (var i = 0; i < 20; i++)
        {
            var item = new DataModel
            {
                Name = $"Item {i}",
                Description = $"Description {i}",
            };
                
            Data.Add(item);
        }
            
        TouchUpCommand = new AsyncRelayCommand(TouchUpAction);

        InitializeComponent();
    }
        
    private async Task TouchUpAction()
    {
        await DisplayAlert("Alert", "TouchUp command has been triggered.", "OK");
    }
}