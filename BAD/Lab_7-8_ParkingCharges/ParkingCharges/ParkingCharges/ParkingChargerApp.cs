using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ParkingCharges
{
    class ParkingChargerApp
    {
        const double MIN_FEE = 2.00;
        const double MAX_FEE = 10.00;
        const double EXTRA_HOUR_FEE = 0.50;

        private Dictionary<string, List<Register>> customerRegister = new Dictionary<string, List<Register>>();

        public void saveRegister(string customerName, TimeSpan period, DateTime whenDate)
        {
            Register r = new Register(period, whenDate);

            List<Register> customers;
            if (customerRegister.TryGetValue(customerName, out customers))
            {
                customers.Add(r);
            }
            else 
            {
                customers = new List<Register>();
                customers.Add(r);
                customerRegister.Add(customerName, customers);
            } 
        }

        public string printResume()
        {
            String text = "";

            List<string> keys = new List<string>(customerRegister.Keys);

            foreach (String nameKey in keys)
            {
                List<Register> customers;
                if (customerRegister.TryGetValue(nameKey, out customers))
                {
                    text += "Name: " + nameKey + "\n";
                    foreach (Register r in customers)
                    {
                        text += "Date: " + r.whenDate.ToShortDateString() + "\n";
                        text += "Time: " + r.period + "\n";
                        text += "Cost: " + string.Format("{0:C2}" , CalculateCharges(r.period))+ "\n"; 
                    }
                    text += "\n"; 
                }
            }
            return text;
        }

        public double CalculateCharges(TimeSpan time)
        {
            double finalFee = 0.0;

            if(time.Hours <= 3)
            {
                finalFee  = MIN_FEE;
            } 
            else
            {
                int extraHours = time.Hours - 3;
                if (time.Minutes > 0)
                {
                    extraHours++;
                }
                finalFee = MIN_FEE + extraHours * EXTRA_HOUR_FEE;
            }

            return (finalFee > MAX_FEE) ? MAX_FEE : finalFee; 
        }
    }
}
