using System.Globalization;

namespace ERP.WebAPI.Services.Common
{
    public static class ConvertService
    {
        public static DateTime? ConvertStrToDateTime(string? value)
        {
            if(String.IsNullOrEmpty(value))
                return null;
            string dateFormat = "dd/MM/yyyy";

            // Create a custom format provider with the desired format
            CultureInfo provider = new CultureInfo("es-ES"); // Use "en-US" to ensure "/" is treated as date separator
            provider.DateTimeFormat.ShortDatePattern = dateFormat;

            DateTime dateTime;
            // Try parsing the date string
            if (DateTime.TryParse(value, provider, DateTimeStyles.None, out dateTime))
            {
                return dateTime;
            }

            return null;
        }
    }
}
