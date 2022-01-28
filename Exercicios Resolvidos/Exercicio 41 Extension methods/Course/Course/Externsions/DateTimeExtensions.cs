using System.Globalization;


namespace System
{
    internal static class DateTimeExtensions
    {
        public static string ElapsedTime(this DateTime thisObj)
        {
            TimeSpan duration = DateTime.Now.Subtract(thisObj); //Subtrai o tempo de agora com que foi setado no DateTime.

            if (duration.TotalHours < 24.0)
            {
                return duration.TotalHours.ToString("F1", CultureInfo.InvariantCulture) + " hours";
            }
            else
            {
                return duration.TotalDays.ToString("F1", CultureInfo.InvariantCulture) + " days";
            }
        }
    }
}
