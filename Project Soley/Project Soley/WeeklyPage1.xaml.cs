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
        public ObservableCollection<ClockLogic> alarms { get; set; } = new ObservableCollection<ClockLogic>();

        public WeeklyPage1()
        {
            this.InitializeComponent();

            newWeeklyAlarm = new ClockLogic(AlarmName.Text, false, false, false, false, false, false, false, DateTime.Now);
        }

        private void WeeklyTimePicker_TimeChanged(object sender, TimePickerValueChangedEventArgs e)
        {
            newWeeklyAlarm.setTime(convertTimePickerToDateTime(WeeklyTimePicker.Time));

            //testbox2.Text = _mon.ToString() + _tue.ToString() + _wed.ToString() + _thu.ToString() + _fri.ToString() + _sat.ToString() + _sun.ToString() + _time;
        }

        private DateTime convertTimePickerToDateTime(TimeSpan timePicker)
        {
            int timePickerHours = timePicker.Hours;
            int timePickerMin = timePicker.Minutes;
            int timePickerSecs = timePicker.Seconds;
            int today = newWeeklyAlarm.getTime().Day;
            int month = newWeeklyAlarm.getTime().Month;
            int year = newWeeklyAlarm.getTime().Year;
            
            DateTime convertedTime = new DateTime(year, month, today, timePickerHours, timePickerMin, timePickerSecs);

            return convertedTime;
        }   

        private string checkBoxArray()
        {
            string allDays = "";
            bool?[] weekdayboxes = new bool?[7];
            //String finalBoxes = ConvertStringArrayToString(checkedBoxes);
            weekdayboxes[0] = MondayCheckbox.IsChecked;
            weekdayboxes[1] = TuesdayCheckbox.IsChecked;
            weekdayboxes[2] = WednesdayCheckbox.IsChecked;
            weekdayboxes[3] = ThursdayCheckbox.IsChecked;
            weekdayboxes[4] = FridayCheckbox.IsChecked;
            weekdayboxes[5] = SaturdayCheckbox.IsChecked;
            weekdayboxes[6] = SundayCheckbox.IsChecked;

            

            
                
            if(weekdayboxes[0] == true)
            {
                allDays = "Monday";
            }

            if(weekdayboxes[1] == true)
            {
                if (allDays.Equals(""))
                {
                    allDays = "Tuesday";
                }
                else
                {
                    allDays = allDays + ", Tuesday"; 
                }
            }

            if(weekdayboxes[2] == true)
            {
                if (allDays.Equals(""))
                {
                    allDays = "Wedesday";
                }
                else
                {
                    allDays = allDays + ", Wedesday";
                }
            }

            if(weekdayboxes[3] == true)
            {
                if (allDays.Equals(""))
                {
                    allDays = "Thursday";
                }
                else
                {
                    allDays = allDays + ", Thursday";
                }
            }

            if(weekdayboxes[4] == true)
            {
                if (allDays.Equals(""))
                {
                    allDays = "Friday";
                }
                else
                {
                    allDays = allDays + ", Friday";
                }
            }

            if(weekdayboxes[5] == true)
            {
                if (allDays.Equals(""))
                {
                    allDays = "Saturday";
                }
                else
                {
                    allDays = allDays + ", Saturday";
                }
            }

            if (weekdayboxes[6] == true)
            {
                if (allDays.Equals(""))
                {
                    allDays = "Sunday";
                }
                else
                {
                    allDays = allDays + ", Sunday";
                }
            }
            
            
            return allDays;
        }

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

        private void AlarmName_TextChanged(object sender, TextChangedEventArgs e)
        {
            newWeeklyAlarm.setName(AlarmName.Text);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            setWeeksofDay();
            newWeeklyAlarm = new ClockLogic(newWeeklyAlarm.getName(), newWeeklyAlarm.getMonday(), newWeeklyAlarm.getTuesday(),
                newWeeklyAlarm.getWednesday(), newWeeklyAlarm.getThursday(), newWeeklyAlarm.getFriday(), newWeeklyAlarm.getSaturday(),
                newWeeklyAlarm.getSunday(), newWeeklyAlarm.getTime())
            { Name = newWeeklyAlarm.getName() , Days = checkBoxArray(), Time = newWeeklyAlarm.DateTimeToTimePickertoString(newWeeklyAlarm.getTime()) };
            alarms.Add(newWeeklyAlarm);
            WeeklyList.ItemsSource = alarms;

            MondayCheckbox.IsChecked = false;
            TuesdayCheckbox.IsChecked = false;
            WednesdayCheckbox.IsChecked = false;
            ThursdayCheckbox.IsChecked = false;
            FridayCheckbox.IsChecked = false;
            SaturdayCheckbox.IsChecked = false;
            SundayCheckbox.IsChecked = false;

            AlarmName.Text = "Alarm";
        }


        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }
    }
}
