namespace SyncFusionTest
{
    public partial class MainPage : ContentPage
    {
        readonly MainViewModel viewModel = new();
        public MainPage()
        {
            InitializeComponent();
            BindingContext = viewModel;

            // Sets Light/Dark mode for Combo baox drop down
            AppTheme currentTheme = Application.Current.RequestedTheme;

            ResourceDictionary themeMode = new Resources.Styles.ComboBoxDropDownLight();
            Resources.MergedDictionaries.Add(themeMode);

            if (currentTheme == AppTheme.Dark)
                themeMode = new Resources.Styles.ComboBoxDropDownDark();
            if (themeMode != null)
            {
                Resources.MergedDictionaries.Clear();
                Resources.MergedDictionaries.Add(themeMode);
            }
        }
    }
}
