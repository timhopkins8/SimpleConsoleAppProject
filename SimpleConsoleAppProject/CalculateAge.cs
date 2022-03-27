using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleConsoleAppProject
{
    public class CalculateAge 
    {

        private string _dob;
        public CalculateAge(string dob)
        {
            _dob = dob;
        }

        public int CalculateAgeFromDob()
        {
            
            string[] split = _dob.Split("/");
            int year = Convert.ToInt32(split[2]);
            int month = Convert.ToInt32(split[0]);  
            int day = Convert.ToInt32(split[1]);

            int currentYear = DateTime.Now.Year;    
            int currentMonth =  DateTime.Now.Month;
            int currentDay = DateTime.Now.Day;

            if (month > currentMonth)
                return currentYear - year - 1;
            if (month < currentMonth)
                return currentYear - year;
            if (month == currentMonth)
            {
                if (day > currentDay)
                    return currentYear - year - 1;
                if (day <= currentDay)
                    return currentYear - year;
            }

            return 0;
        }
    }
}
