using MotoTrack.Views;

namespace MotoTrack;

public partial class AppShell : Shell
{
    public AppShell()
    {
        // Thème sombre forcé, comme dans les maquettes.
        if (Application.Current != null) Application.Current.UserAppTheme = AppTheme.Dark;

        InitializeComponent();

        // Pages ouvertes « par-dessus » (avec flèche retour).
        Routing.RegisterRoute(nameof(InscriptionPage), typeof(InscriptionPage));
        Routing.RegisterRoute(nameof(FicheLocationPage), typeof(FicheLocationPage));
        Routing.RegisterRoute(nameof(ContactPage), typeof(ContactPage));
        Routing.RegisterRoute(nameof(ZoneAutorisePage), typeof(ZoneAutorisePage));
        Routing.RegisterRoute(nameof(SuiviPage), typeof(SuiviPage));
    }
}
