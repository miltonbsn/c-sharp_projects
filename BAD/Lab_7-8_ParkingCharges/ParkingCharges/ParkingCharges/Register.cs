using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ParkingCharges
{
    class Register
    {
        public TimeSpan period { get; set; }
        public DateTime whenDate { get; set; }

        public Register(TimeSpan period, DateTime whenDate)
        {
            this.period = period;
            this.whenDate = whenDate;
        }
    }
}
