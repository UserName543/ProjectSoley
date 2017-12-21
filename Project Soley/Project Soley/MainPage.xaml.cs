using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.Devices.Gpio;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.UI.Core;
using Windows.Devices.Input;

// Die Elementvorlage "Leere Seite" wird unter https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x407 dokumentiert.

namespace Project_Soley
{
    /// <summary>
    /// Eine leere Seite, die eigenständig verwendet oder zu der innerhalb eines Rahmens navigiert werden kann.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        DispatcherTimer Timer = new DispatcherTimer();
        private const int LED_PIN = 24;     //green
        private const int LED_PIN1 = 17;    //red
        private const int LED_PIN2 = 22;    //blue
        private const int LED_PIN3 = 27;    //white (remote lamp)
        private GpioPin pin;
        private GpioPin pin1;
        private GpioPin pin2;
        private GpioPinValue pinValue;
        private DispatcherTimer timer;


        public MainPage()
        {
            this.InitializeComponent();


            //Timer Timer = new Timer();
            DataContext = this;
            Timer.Tick += Timer_Tick;
            Timer.Interval = new TimeSpan(0, 0, 1);
            Timer.Start();

            LedController ledController = new LedController();
            ledController.InitGPIO();


        }


    private void Timer_Tick(object sender, object e)
    {
        Time.Text = DateTime.Now.ToString("hh:mm");
        Seconds.Text = DateTime.Now.ToString("ss");

        }

        private void optionButton_Click(object sender, RoutedEventArgs e)
        {
            testbox.Text = "Button is clicked";
        }

        private void optionButton_PointerEntered(object sender, PointerRoutedEventArgs e)
        {

        }

        private void optionButton_PointerExited(object sender, PointerRoutedEventArgs e)
        {
            optionButton.UseSystemFocusVisuals = false;
        }

        
        private void weekly_alarm_Tapped(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(WeeklyPage1));
        }

        private void one_time_alarm_Tapped(object sender, TappedRoutedEventArgs e)
        {

        }

        
    }
}