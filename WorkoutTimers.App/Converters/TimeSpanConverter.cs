using System.Globalization;

namespace WorkoutTimers.App.Converters
{
    internal class TimeSpanConverter : IValueConverter
    {
        /// <summary>
        /// Converts the timespan value to a string
        /// </summary>
        /// <param name="value">The timespan to format as a string</param>
        /// <param name="targetType"></param>
        /// <param name="parameter">The format string to use for the timespan</param>
        /// <param name="culture">The cultureinfo to use for conversions</param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (targetType == typeof(string))
            {
                if (value != null)
                {
                    TimeSpan time = (TimeSpan)value;

                    if (parameter is string formatString)
                    {
                        return time.ToString(formatString);
                    }
                    else
                    {
                        return time.ToString();
                    }
                }
            }

            return null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {

            if (targetType == typeof(TimeSpan))
            {
                if (value is string timeString)
                {
                    TimeSpan result;
                    if (parameter is string formatString)
                    {
                        TimeSpan.TryParseExact(timeString, formatString, culture.DateTimeFormat, out result);
                    }
                    else
                    {
                        TimeSpan.TryParse(timeString, culture.DateTimeFormat, out result);
                    }

                    return result;
                }
            }

            return null;
        }
    }
}
