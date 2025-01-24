namespace TrivialGeografia
{
    public partial class App : Application
    {
        public App()
        { 
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("Ngo9BigBOggjHTQxAR8/V1NDaF5cWGFCf1JpQnxbf1x0ZFxMZVlbRXFPMyBoS35RckRjWH5ecXZXR2lUVUxx");
            InitializeComponent();

            MainPage = new AppShell();
        }
    }
}
