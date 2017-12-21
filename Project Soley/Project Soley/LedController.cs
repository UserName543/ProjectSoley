using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Devices.Gpio;

namespace Project_Soley
{
    public class LedController
    {
        private const int greenLedPin = 17;     //green
        private const int redLEDPin = 4;    //red
        private const int blueLEDPin = 27;    //blue
        private const int whiteLEDPin = 22;    //white (remote lamp)
        public GpioPin redPin;
        public GpioPin greenPin;
        public GpioPin bluePin;
        public GpioPin whitePin;
        private GpioPinValue pinValue;


        public void InitGPIO()
        {
            var gpio = GpioController.GetDefault();

            // Show an error if there is no GPIO controller
            if (gpio == null)
            {
                redPin = null;
                greenPin = null;
                bluePin = null;
                whitePin = null;
                return;
            }

            GpioPinValue high = GpioPinValue.High;
            GpioPinValue low = GpioPinValue.Low;


            redPin = gpio.OpenPin(redLEDPin);
            redPin.Write(low);
            redPin.SetDriveMode(GpioPinDriveMode.Output);

            greenPin = gpio.OpenPin(greenLedPin);
            greenPin.Write(low);
            greenPin.SetDriveMode(GpioPinDriveMode.Output);

            bluePin = gpio.OpenPin(blueLEDPin);
            bluePin.Write(low);
            bluePin.SetDriveMode(GpioPinDriveMode.Output);

            whitePin = gpio.OpenPin(whiteLEDPin);
            whitePin.Write(low);
            whitePin.SetDriveMode(GpioPinDriveMode.Output);


        }

        public void LedOn(GpioPin pin, Boolean on)
        {
            if (on)
            {
                pin.Write(GpioPinValue.High);
            } else
            {
                pin.Write(GpioPinValue.Low);
            }

        }

        
    }
}
