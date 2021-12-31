using System.Globalization;

namespace Utils.Extensions
{
    public static class DateTimeExtensions
    {
        public static string ToShamsi(this DateTime date, string separator = "/")
        {

            PersianCalendar pc = new PersianCalendar();
            return pc.GetYear(date) + separator + pc.GetMonth(date).ToString("00") + separator +
                   pc.GetDayOfMonth(date).ToString("00");
        }
    }
}
