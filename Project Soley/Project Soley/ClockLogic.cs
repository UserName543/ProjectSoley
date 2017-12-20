using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Soley
{
    public class ClockLogic
    {
        private String _name;
        private bool _mon = false;
        private bool _tue = false;
        private bool _wed = false;
        private bool _thu = false;
        private bool _fri = false;
        private bool _sat = false;
        private bool _sun = false;
        private TimeSpan _time;

        public String Name { get; set; }
        public String Days { get; set; }
        public TimeSpan Time { get; set; }
        

        DateTime _currentTime = DateTime.Now;
        //TimeSpan timeDifference;

        //Constructor for weekly timer  NAME!?!
        public ClockLogic(String name, bool mon, bool tue, bool wed, bool thu, bool fri, bool sat, bool sun, TimeSpan time)
        {
            this._name = name;
            this._mon = mon;
            this._tue = tue;
            this._wed = wed;
            this._thu = thu;
            this._fri = fri;
            this._sat = sat;
            this._sun = sun;
            this._time = time;


        }

        public void ClockLogicToString()
        {

        }

        public void setName(String name)
        {
            _name = name;
        }

        public void setMonday(bool checkMon)
        {
            _mon = checkMon;
        }
        public void setTuesday(bool checkDay)
        {
            _tue = checkDay;
        }
        public void setWednesday(bool checkDay)
        {
            _wed = checkDay;
        }
        public void setThursday(bool checkDay)
        {
            _thu = checkDay;
        }
        public void setFriday(bool checkDay)
        {
            _fri = checkDay;
        }

        public void setSaturday(bool checkDay)
        {
            _sat = checkDay;
        }
        public void setSunday(bool checkDay)
        {
            _sun = checkDay;
        }


        public void setTime(TimeSpan setTime)
        {
            _time = setTime;
        }

        public String getName()
        {
            return _name;
        }

        public bool getMonday()
        {
            return _mon;
        }

        public bool getTuesday()
        {
            return _tue;
        }

        public bool getWednesday()
        {
            return _wed;
        }

        public bool getThursday()
        {
            return _thu;
        }

        public bool getFriday()
        {
            return _fri;
        }

        public bool getSaturday()
        {
            return _sat;
        }

        public bool getSunday()
        {
            return _sun;
        }

        public TimeSpan getTime()
        {
            return _time;
        }


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
