using System.Globalization;

namespace Practice
{
    static class DateTimeExt
    {
        //Thats how you extends methods in C# ex:this DateTime dateTime 
        public static string ElapsedTime(this DateTime dateTime)
        {
            TimeSpan duration = DateTime.Now.Subtract(dateTime);
            if (duration.TotalHours < 24.0)
            {
                return duration.TotalHours.ToString("F1", CultureInfo.InvariantCulture) + " hours";
            }
            return duration.TotalDays.ToString("F1", CultureInfo.InvariantCulture) + " days";
        }
    }
}