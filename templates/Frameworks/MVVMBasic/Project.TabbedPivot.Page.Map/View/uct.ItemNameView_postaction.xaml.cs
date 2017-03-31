namespace ItemNamespace.View
{
    public sealed partial class uct.ItemNameView : Page
    {
        public uct.ItemNameView()
        {
            InitializeComponent();
            Loaded += OnLoaded;
        }        
        
        //{[{
        protected override async void OnNavigatedTo(NavigationEventArgs e)
        {
            if (ViewModel == null)
            {
                throw new ArgumentNullException("ViewModel");
            }
            
            await ViewModel.InitializeAsync(mapControl);
        }

        protected override void OnNavigatedFrom(NavigationEventArgs e)
        {
            if (ViewModel == null)
            {
                throw new ArgumentNullException("ViewModel");
            }

            ViewModel.Cleanup();
        }     
        //}]}
    }
}
