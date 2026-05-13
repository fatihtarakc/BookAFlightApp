namespace App.Core.Utilities.Helpers
{
    public static class HelperDistance
    {
        private const decimal nauticalMilesToKilometersFactor = 1.852m;
        private const decimal kilometersToNauticalMilesFactor = 0.539957m;

        public static decimal ConvertNauticalMilesToKilometers(decimal nauticalMiles) => nauticalMiles * nauticalMilesToKilometersFactor;

        public static decimal ConvertKilometersToNauticalMiles(decimal kilometers) => kilometers * kilometersToNauticalMilesFactor;
    }
}