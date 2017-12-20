using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using System.Text;
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
        ClockLogic newWeeklyAlarm;
        ObservableCollection<ClockLogic> alarms = new ObservableCollection<ClockLogic>();

        public WeeklyPage1()
        {
            this.InitializeComponent();

            newWeeklyAlarm = new ClockLogic(AlarmName.ToString(), false, false, false, false, false, false, false, WeeklyTimePicker.Time);
        }

        private void WeeklyTimePicker_TimeChanged(object sender, TimePickerValueChangedEventArgs e)
        {
            newWeeklyAlarm.setTime(WeeklyTimePicker.Time);

            //testbox2.Text = _mon.ToString() + _tue.ToString() + _wed.ToString() + _thu.ToString() + _fri.ToString() + _sat.ToString() + _sun.ToString() + _time;
        }

        private string checkBoxArray()
        {
            CheckBox[] weekdayboxes = new CheckBox[6];
            //String finalBoxes = ConvertStringArrayToString(checkedBoxes);
            weekdayboxes[0] = MondayCheckbox;
            weekdayboxes[1] = TuesdayCheckbox;
            weekdayboxes[2] = WednesdayCheckbox;
            weekdayboxes[3] = ThursdayCheckbox;
            weekdayboxes[4] = FridayCheckbox;
            weekdayboxes[5] = SaturdayCheckbox;
            weekdayboxes[6] = SundayCheckbox;

            List<string> checkedBoxes = new List<string>();

            for (int i = 0; i < 7; i++)
            {
                if(weekdayboxes[0].IsChecked == true)
                {
                    checkedBoxes.Add("Monday");
                }

                if(weekdayboxes[1].IsChecked == true)
                {
                    checkedBoxes.Add("Tuesday");
                }

                if(weekdayboxes[2].IsChecked == true)
                {
                    checkedBoxes.Add("Wednesday");
                }

                if(weekdayboxes[3].IsChecked == true)
                {
                    checkedBoxes.Add("Thursday");
                }

                if(weekdayboxes[4].IsChecked == true)
                {
                    checkedBoxes.Add("Friday");
                }

                if(weekdayboxes[5].IsChecked == true)
                {
                    checkedBoxes.Add("Saturday");
                }

                if (weekdayboxes[6].IsChecked == true)
                {
                    checkedBoxes.Add("Sunday");
                }
            }
            string allDays = string.Join(",", checkedBoxes.ToArray());
            return allDays;
        }

        /*static string ConvertStringArrayToString(CheckBox[] array)
        {
            // Concatenate all the elements into a StringBuilder.
            StringBuilder builder = new StringBuilder();
            foreach (CheckBox value in array)
            {
                builder.Append(value);
                builder.Append('.');
            }
            return builder.ToString();
        }*/
        

        private void setWeeksofDay()
        {
            if (MondayCheckbox.IsChecked == true)
            {
                newWeeklyAlarm.setMonday(true);
            }

            if (TuesdayCheckbox.IsChecked == true)
            {
                newWeeklyAlarm.setTuesday(true);
            }

            if (WednesdayCheckbox.IsChecked == true)
            {
                newWeeklyAlarm.setWednesday(true);
            }

            if (ThursdayCheckbox.IsChecked == true)
            {
                newWeeklyAlarm.setThursday(true);
            }

            if (FridayCheckbox.IsChecked == true)
            {
                newWeeklyAlarm.setFriday(true);
            }

            if (SaturdayCheckbox.IsChecked == true)
            {
                newWeeklyAlarm.setSaturday(true);
            }

            if (SundayCheckbox.IsChecked == true)
            {
                newWeeklyAlarm.setSunday(true);
            }
        }

        private void getStatusofDays()
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
            setWeeksofDay();
            newWeeklyAlarm = new ClockLogic(newWeeklyAlarm.getName(), newWeeklyAlarm.getMonday(), newWeeklyAlarm.getTuesday(),
                newWeeklyAlarm.getWednesday(), newWeeklyAlarm.getThursday(), newWeeklyAlarm.getFriday(), newWeeklyAlarm.getSaturday(),
                newWeeklyAlarm.getSunday(), newWeeklyAlarm.getTime())
            { Name = newWeeklyAlarm.getName() , Days = checkBoxArray(), Time = newWeeklyAlarm.getTime()};
            alarms.Add(newWeeklyAlarm);
        }

        
    }
}
