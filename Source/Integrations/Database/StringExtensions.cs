namespace TreeDeliveryApp.Integrations.Database
{
    public static class StringExtensions
    {
        public static DateTime? ToDateTimeOrDefault(this string text) =>
            text != null && text != ""
            ? DateTime.ParseExact(text, "yyyy-MM-dd HH:mm:ss,fff", System.Globalization.CultureInfo.InvariantCulture)
               : null;
    }
}
