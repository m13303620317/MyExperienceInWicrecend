using Microsoft.Toolkit.Uwp.Notifications;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace MyExperienceInWicrecend
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class SubPage8 : Page
    {
        public SubPage8()
        {
            this.InitializeComponent();
        }

        private void Toast_Click(object sender, RoutedEventArgs e)
        {
            new ToastContentBuilder()
                .AddText(ToastTitle.Text, hintMaxLines : 1)
                .AddText(ToastContent.Text)
                .Show();
        }

        private void LastPage_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(LastPage));
        }
    }
}
