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
    public sealed partial class SubPage5 : Page
    {
        private string[] selectionItems = new string[] { "Ferdinand", "Frank", "Frida", "Nigel", "Tag", "Tanya", "Tanner", "Todd" };
        public SubPage5()
        {
            this.InitializeComponent();
        }

        private void MyCalendarView_SelectedDatesChanged(CalendarView sender, CalendarViewSelectedDatesChangedEventArgs args)
        {
            var selectedDates = sender.SelectedDates.Select(p => p.Date.Month.ToString() + "/" + p.Date.Day.ToString()).ToArray();
            var values = string.Join(", ", selectedDates);
            CalendarViewResultTextBlock.Text = values;
        }

        private void InnerFlyoutButton_Click(object sender, RoutedEventArgs e)
        {
            MyFlyout.Hide();
        }

        private void MyAutoSuggestBox_TextChanged(AutoSuggestBox sender, AutoSuggestBoxTextChangedEventArgs args)
        {
            var autoSuggestBox = (AutoSuggestBox)sender;
            var filtered = selectionItems.Where(p => p.StartsWith(autoSuggestBox.Text)).ToArray();
            autoSuggestBox.ItemsSource = filtered;
        }

        private void MyCheckBox_Tapped(object sender, TappedRoutedEventArgs e)
        {
            CheckBoxResultTextBlock.Text = MyCheckBox.IsChecked.ToString();
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            RadioButtonTextBlock.Text = (bool)YesRadioButton.IsChecked ? "Yes" : "No";
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ComboBoxResultTextBlock == null) return;

            var combo = (ComboBox)sender;
            var item = (ComboBoxItem)combo.SelectedItem;
            ComboBoxResultTextBlock.Text = item.Content.ToString();
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectedItems = MyListBox.Items.Cast<ListBoxItem>()
                .Where(p => p.IsSelected)
                .Select(t => t.Content.ToString())
                .ToArray();

            ListBoxResultTextBlock.Text = string.Join(", ", selectedItems);
        }

        private void MyToggleButton_Click(object sender, RoutedEventArgs e)
        {
            ToggleButtonResultTextBlock.Text = MyToggleButton.IsChecked.ToString();
        }

        private void ResponsiveLayout_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(SubPage6));
        }
    }
}
