using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Soley
{
    public class ClockLogic
    {
        private bool? _mon { get; set; }
        private bool? _tue { get; set; }
        private bool? _wed { get; set; }
        private bool? _thu { get; set; }
        private bool? _fri { get; set; }
        private bool? _sat { get; set; }
        private bool? _sun { get; set; }
        private TimeSpan _time;


        DateTime _currentTime = DateTime.Now;
        //TimeSpan timeDifference;

        //Constructor for weekly timer  NAME!?!
        public ClockLogic(bool? mon, bool? tue, bool? wed, bool? thu, bool? fri, bool? sat, bool? sun, TimeSpan time)
        {
            this._mon = mon;
            this._tue = tue;
            this._wed = wed;
            this._thu = thu;
            this._fri = fri;
            this._sat = sat;
            this._sun = sun;
            this._time = time;


        }

        /*public DateTime time
        {
            get { return _time; }
            set { _time = value; }
        }*/

        private void alarm()
        {
            DayOfWeek dow = DateTime.Now.DayOfWeek;



            /*if(dow.Equals("Monday") && _mon)
            {

            }
            */


        }
    }
}
