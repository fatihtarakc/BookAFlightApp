namespace App.Core.Utilities.Helpers
{
    public static class HelperTimeZone
    {
        private static readonly HashSet<string> timeZones = new(StringComparer.OrdinalIgnoreCase) { "UTC", "Europe/Istanbul", "Europe/London", "America/New_York", "Asia/Dubai" };

        public static IReadOnlyCollection<string> TimeZones => timeZones;

        public static bool IsValid(string value) => !string.IsNullOrWhiteSpace(value) && timeZones.Contains(value);
        //RuleFor(x => x.TimeZone).Must(TimeZoneCatalog.IsValid).WithMessage("Invalid timezone"); => fluent validation

        public static TimeZoneInfo GetTimeZone(string timeZoneId) => TimeZoneInfo.FindSystemTimeZoneById(timeZoneId);

        public static DateTime ConvertToUtc(DateTime localDateTime, string timeZoneId) => TimeZoneInfo.ConvertTimeToUtc(localDateTime, GetTimeZone(timeZoneId));
    }
}