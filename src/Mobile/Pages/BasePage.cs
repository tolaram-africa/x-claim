using Microsoft.Maui.Controls.PlatformConfiguration;
using Microsoft.Maui.Controls.PlatformConfiguration.iOSSpecific;

namespace XClaim.Mobile.Pages;

public abstract class BasePage : ContentPage {
    protected BasePage(in bool shouldUseSafeArea = false) {
        On<iOS>().SetUseSafeArea(shouldUseSafeArea);
        On<iOS>().SetModalPresentationStyle(UIModalPresentationStyle.FormSheet);
    }

    protected abstract void Build();

    protected override void OnNavigatedTo(NavigatedToEventArgs args) {
        base.OnNavigatedTo(args);
        Build();
#if DEBUG
        HotReloadService.UpdateApplicationEvent += ReloadUI;
#endif
    }

    protected override void OnNavigatedFrom(NavigatedFromEventArgs args) {
        base.OnNavigatedFrom(args);
#if DEBUG
        HotReloadService.UpdateApplicationEvent -= ReloadUI;
#endif
    }

    private void ReloadUI(Type[] obj) => MainThread.BeginInvokeOnMainThread(Build);
}

public abstract class BasePage<T> : BasePage where T : BaseViewModel {
    protected BasePage(in T viewModel, in bool shouldUseSafeArea = false) : base(shouldUseSafeArea) => base.BindingContext = viewModel;

    protected new T BindingContext => (T)base.BindingContext;
}
