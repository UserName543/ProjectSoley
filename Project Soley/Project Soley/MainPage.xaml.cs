using System;
using System.Collections.ObjectModel;
using Windows.Devices.Gpio;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;

// Die Elementvorlage "Leere Seite" wird unter https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x407 dokumentiert.

namespace Project_Soley
{
    /// <summary>
    /// Eine leere Seite, die eigenständig verwendet oder zu der innerhalb eines Rahmens navigiert werden kann.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        DispatcherTimer Timer = new DispatcherTimer();
        DispatcherTimer alarmTimer = new DispatcherTimer();
        WeeklyPage1 WeeklyPage = new WeeklyPage1();
        
        ObservableCollection<ClockLogic> alarms = new ObservableCollection<ClockLogic>();
        ClockLogic alarmClock = new ClockLogic("test", false, false, false, false, false, false, false, DateTime.Now);
        private const int LED_PIN = 24;     //green
        private const int LED_PIN1 = 17;    //red
        private const int LED_PIN2 = 22;    //blue
        private const int LED_PIN3 = 27;    //white (remote lamp)
        private GpioPin pin;
        private GpioPin pin1;
        private GpioPin pin2;
        private GpioPinValue pinValue;
        private DispatcherTimer timer;
        private SolidColorBrush redBrush = new SolidColorBrush(Windows.UI.Colors.Red);
        private SolidColorBrush grayBrush = new SolidColorBrush(Windows.UI.Colors.LightGray);


        public MainPage()
        {
            this.InitializeComponent();
            timerForClock();

            //Timer Timer = new Timer();
            DataContext = this;
            

            /*alarmTimer.Tick += alarmTimer_Tick;
            alarmTimer.Interval = new TimeSpan(0, 1, 0);
            alarmTimer.Start();*/

            InitGPIO();
            /*if (pin != null)
            {
                timer.Start();
            }*/
        }

   

        public async void timerForClock()
        {
            Timer.Tick += Timer_Tick;
            Timer.Interval = new TimeSpan(0, 0, 1);
            Timer.Start();
        }

        private void Timer_Tick(object sender, object e)
        {
            Time.Text = DateTime.Now.ToString("hh:mm");
            Seconds.Text = DateTime.Now.ToString("ss");

                alarms = WeeklyPage.alarms;
                foreach (var alarm in alarms)
                {
                    alarmClock.alarm(alarm.getTime());
                }

                /*
                if (pinValue == GpioPinValue.High)
                {
                    pinValue = GpioPinValue.Low;
                    pin.Write(pinValue);
                    LED.Fill = redBrush;
                }
                else
                {
                    pinValue = GpioPinValue.High;
                    pin.Write(pinValue);
                    LED.Fill = grayBrush;
                }*/
        }

        private void alarmTimer_Tick(object sender, object e)
        {
            /*alarms = WeeklyPage.alarms;
            foreach (var alarm in alarms)
            {
                alarmClock.alarm(alarm.getTime());
            }*/
        }



        public void InitGPIO()
        {
            var gpio = GpioController.GetDefault();

            // Show an error if there is no GPIO controller
            if (gpio == null)
            {
                pin = null;
                //GpioStatus.Text = "There is no GPIO controller on this device.";
                return;
            }

            pin = gpio.OpenPin(LED_PIN2);
            pin1 = gpio.OpenPin(LED_PIN);
            pin2 = gpio.OpenPin(LED_PIN1);
            pinValue = GpioPinValue.High;
            pin.Write(pinValue);
            pin1.Write(pinValue);
            pin2.Write(pinValue);
            pin.SetDriveMode(GpioPinDriveMode.Output);
            pin2.SetDriveMode(GpioPinDriveMode.Output);
            pin1.SetDriveMode(GpioPinDriveMode.Output);
            //GpioStatus.Text = "GPIO pin initialized correctly.";

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

        private void SoundButton_Click(object sender, RoutedEventArgs e)
        {
            alarmClock.playSound();
        }
    }
}