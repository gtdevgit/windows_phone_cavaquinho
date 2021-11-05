using System;
using System.Windows;
using Microsoft.Phone.Controls;
using System.Threading;
using Microsoft.Phone.Shell;
using System.Device.Location;
using System.Diagnostics;
using Microsoft.Phone.Net.NetworkInformation;

namespace Cavaquinho
{
    public partial class MainPage : PhoneApplicationPage
    {
        private ProgressIndicator progressIndicator = new ProgressIndicator();
        private Boolean JouerStoryBoard = true;
        private GeoCoordinateWatcher gcw = null;

        // Constructeur
        public MainPage()
        {
            InitializeComponent();

            DataContext = App.ViewModel;

            SystemTray.SetIsVisible(this, true);         
            progressIndicator.IsVisible = true;
            progressIndicator.IsIndeterminate = true;
            progressIndicator.Text = "";
            SystemTray.SetProgressIndicator(this, progressIndicator);

            // Provide the location to the AdControl for better targeting (optional).
            // This is done by starting a GeoCoordinateWatcher and waiting for the location to be available.
            // The callback will set the location into the ad. 
            // Note: The location may not be available in time for the first ad request.
            this.gcw = new GeoCoordinateWatcher();
            this.gcw.PositionChanged += new EventHandler<GeoPositionChangedEventArgs<GeoCoordinate>>(gcw_PositionChanged);
            this.gcw.Start(false);

            Thread.Sleep(250);
            this.StoryboardVisibility.Completed += new EventHandler(StoryboardVisibility_Completed);
            this.Loaded += new RoutedEventHandler(MainPage_Loaded);
        }

        void MainPage_Loaded(object sender, RoutedEventArgs e)
        {
            if (JouerStoryBoard)
            {
                this.StoryboardVisibility.BeginTime = TimeSpan.FromMilliseconds(500);
                this.StoryboardVisibility.Begin();
            }

            if (!App.ViewModel.IsDataLoaded)
                App.ViewModel.Restaurer();
        }

        void StoryboardVisibility_Completed(object sender, EventArgs e)
        {
            // Retire l'image du splashscreen
            JouerStoryBoard = false;
            this.LayoutRoot.Children.Remove(this.SplashScreen);
            SystemTray.SetProgressIndicator(this, null);
            SystemTray.SetIsVisible(this, false);
        }

        private void gcw_PositionChanged(object sender, GeoPositionChangedEventArgs<GeoCoordinate> e)
        {
            // Stop the GeoCoordinateWatcher now that we have the device location.
            this.gcw.Stop();

            cavaquinho_adUnit1.Latitude = e.Position.Location.Latitude;
            cavaquinho_adUnit1.Longitude = e.Position.Location.Longitude;

            Debug.WriteLine("Device lat/long: " + e.Position.Location.Latitude + ", " + e.Position.Location.Longitude);
        }

        private void adControl1_ErrorOccurred(object sender, Microsoft.Advertising.AdErrorEventArgs e)
        {
            Debug.WriteLine("AdControl error: " + e.Error.Message);
            cavaquinho_adUnit1.Visibility = System.Windows.Visibility.Collapsed;
            if (NetworkInterface.GetIsNetworkAvailable())
                joker1.Visibility = System.Windows.Visibility.Visible;
        }

        private void adControl1_AdRefreshed(object sender, EventArgs e)
        {
            Debug.WriteLine("AdControl new ad received");
        }

        #region IDisposable Members

        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }

        private void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (this.gcw != null)
                {
                    this.gcw.Dispose();
                    this.gcw = null;
                }
            }
        }

        #endregion
    }
}