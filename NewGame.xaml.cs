using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Core;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using System.Threading.Tasks;
using Windows.Storage.Pickers;
using Windows.Storage;
using Windows.UI.Xaml.Media.Imaging;
// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Game
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class NewGame : Page
    {
        public static BitmapImage Source { get; private set; }

        public NewGame()
        {
            this.InitializeComponent();
            SystemNavigationManager.GetForCurrentView().AppViewBackButtonVisibility = AppViewBackButtonVisibility.Visible;
            SystemNavigationManager.GetForCurrentView().BackRequested += (s, e) =>
            {
                this.Frame.Navigate(typeof(MainPage));
            };
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void Image_PointerPressed(object sender, PointerRoutedEventArgs e)
        {

        }

        private void Image_PointerPressed_1(object sender, PointerRoutedEventArgs e)
        {

        }

        private void Image_PointerPressed_2(object sender, PointerRoutedEventArgs e)
        {

        }

        private void Image_PointerPressed_3(object sender, PointerRoutedEventArgs e)
        {

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

        }

        private void Image_PointerPressed_4()
        {

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(GamePlay));
        }

        private async void Buttonfilepick_Click(object sender, RoutedEventArgs e)
        {
           // GamePlay gp = new GamePlay();
            FileOpenPicker openPicker = new FileOpenPicker();
            openPicker.ViewMode = PickerViewMode.Thumbnail;
            openPicker.SuggestedStartLocation = PickerLocationId.PicturesLibrary;
            openPicker.FileTypeFilter.Add(".jpg");
            openPicker.FileTypeFilter.Add(".jpeg");
            openPicker.FileTypeFilter.Add(".png");
            StorageFile file = await openPicker.PickSingleFileAsync();
            
            if (file != null)
            {
                textblockoutput.Text = "Selected File:" + file.Path;
                var stream = await file.OpenAsync(Windows.Storage.FileAccessMode.Read);
                var image = new BitmapImage();
                image.SetSource(stream);
                imageview.Source = image;
            }
            else
            {
                textblockoutput.Text = "Try Again..";
            }

            
            
        }

        private void Image_PointerPressed_5(object sender, PointerRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(GamePlay));
        }

        private void Image_PointerPressed_6(object sender, PointerRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(GamePlay));
        }

        private void Image_PointerPressed_7(object sender, PointerRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(GamePlay));
        }

        private void Image_PointerPressed_8(object sender, PointerRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(GamePlay));
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(NewGame));
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MyHighScore));
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Setting));
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(About));
        }
    }
}
