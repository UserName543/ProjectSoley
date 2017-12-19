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

// Die Elementvorlage "Leere Seite" wird unter https://go.microsoft.com/fwlink/?LinkId=234238 dokumentiert.

namespace Project_Soley
{
    /// <summary>
    /// Eine leere Seite, die eigenständig verwendet oder zu der innerhalb eines Rahmens navigiert werden kann.
    /// </summary>
    public sealed partial class WeeklyPage1 : Page
    {
        
        private TimeSpan _time;

        ClockLogic newWeeklyAlarm;

        public WeeklyPage1()
        {
            this.InitializeComponent();

       
            

            
        }

        private void WeeklyTimePicker_TimeChanged(object sender, TimePickerValueChangedEventArgs e)
        {
            _time =  WeeklyTimePicker.Time;

            //testbox2.Text = _mon.ToString() + _tue.ToString() + _wed.ToString() + _thu.ToString() + _fri.ToString() + _sat.ToString() + _sun.ToString() + _time;
        }

        private void MondayCheckbox_Checked(object sender, RoutedEventArgs e)
        {
              
        }

        private void TextBlock_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }

        private void setTimersTextblock_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            newWeeklyAlarm = new ClockLogic(MondayCheckbox.IsChecked, TuesdayCheckbox.IsChecked, WednesdayCheckbox.IsChecked, ThursdayCheckbox.IsChecked, FridayCheckbox.IsChecked, SaturdayCheckbox.IsChecked, SundayCheckbox.IsChecked, _time);
        }
    }
}
