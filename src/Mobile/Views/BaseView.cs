using Microsoft.Maui.Controls.PlatformConfiguration.iOSSpecific;
using Microsoft.Maui.Controls.PlatformConfiguration;
using XClaim.Mobile.ViewModel;

namespace XClaim.Mobile.Views;

public class BaseView : ContentPage
{
    protected BaseView(in bool shouldUseSafeArea = false) {
        On<iOS>().SetUseSafeArea(shouldUseSafeArea);
        On<iOS>().SetModalPresentationStyle(UIModalPresentationStyle.FormSheet);
    }
}

public abstract class BaseView<T> : BaseView where T : BaseViewModel {
    protected BaseView(in T viewModel, in bool shouldUseSafeArea = false) : base(shouldUseSafeArea) {
        base.BindingContext = viewModel;
    }

    protected new T BindingContext => (T)base.BindingContext;
}
