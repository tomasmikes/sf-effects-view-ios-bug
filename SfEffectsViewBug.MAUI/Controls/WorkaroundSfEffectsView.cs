using Syncfusion.Maui.Core;

namespace SfEffectsViewBug.MAUI.Controls;

public class WorkaroundSfEffectsView : SfEffectsView
{
    public WorkaroundSfEffectsView()
    {
        TouchUpEffects = SfEffects.Selection;
        SelectionChanged += itemEffectsView_SelectionChanged;
        TouchDownEffects = SfEffects.Ripple;
    }

    private void itemEffectsView_SelectionChanged(object sender, EventArgs e)
    {
        if (sender is SfEffectsView effectsView && effectsView.IsSelected)
        {
            effectsView.IsSelected = false;
        }
    }
}