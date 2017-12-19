using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Soley
{
    public class ClockLogic
    {
        Boolean _mon;
        Boolean _tue;
        Boolean _wed;
        Boolean _thu;
        Boolean _fri;
        Boolean _sat;
        Boolean _sun;
        DateTime _time;

        DateTime currentTime = new DateTime;

        //Constructor for weekly timer
        public ClockLogic(Boolean mon, Boolean tue, Boolean wed, Boolean thu, Boolean fri, Boolean sat, Boolean sun, DateTime time)
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

        public DateTime time
        {
            get { return _time; }
            set { _time = value; }
        }


    }
}
