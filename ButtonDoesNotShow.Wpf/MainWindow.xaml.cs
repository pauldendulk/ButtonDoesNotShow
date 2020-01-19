using System;
using Xamarin.Forms.Platform.WPF;
using Xamarin.Forms;

namespace ButtonDoesNotShow.Wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : FormsApplicationPage
    {
        public MainWindow()
        {
            InitializeComponent();

            Xamarin.Forms.Forms.Init();

            LoadApplication(new ButtonDoesNotShow.App());
        }
    }
}
