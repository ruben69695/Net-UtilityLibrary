using System;
using System.Collections.Generic;
using System.Text;

namespace UtilityLibraries
{
    /// <summary>
    /// Static class that offers universal functions with Date/Times for .NET Standard Platform (Continuous updating class)
    /// </summary>
    public static class DatesLibrary
    {
        /// <summary>
        /// This function calculates the interval between two dates, the first date it's necessary to be slower than date2 to get the good result
        /// </summary>
        /// <param name="date1">The first date, needs to be slower than the second date parameter</param>
        /// <param name="date2">The second date, needs to be grower than the first date parameter</param>
        /// <returns>TimeSpan</returns>
        public static TimeSpan CalculateIntervalBetweenDates(DateTime date1, DateTime date2)
        {
            TimeSpan interval = new TimeSpan();

            if (date1 != null && date2 != null)
            {
                interval = date2 - date1;
            }

            return interval;
        }

        /// <summary>
        /// This function returns the interval in the next form: 2 days 10 hours 6 minutes 5 seconds
        /// </summary>
        /// <param name="timeSpan">Structure timespan</param>
        /// <returns>String</returns>
        public static String ParseIntervalBetweenDates(TimeSpan timeSpan)
        {
            String interval = "";


            if (timeSpan != null)
            {
                string[] items = timeSpan.ToString().Split('.');

                if (items.Length > 2)    // TimeSpan Contains days interval
                {
                    string[] time = items[1].Split(':');
                    interval = String.Format("{0} days {1} hours {2} minutes and {3} seconds", items[0], time[0], time[1], time[2]);
                }
                else                    // TimeSpan Not Contains days interval
                {
                    string[] time = items[0].Split(':');
                    interval = String.Format("{0} hours {1} minutes and {2} seconds", time[0], time[1], time[2]);
                }

            }

            return interval;

        }
    }
}