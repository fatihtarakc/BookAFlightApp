namespace App.Core.Utilities.Helpers
{
    public static class HelperCharacter
    {
        private static readonly char[] upperCharacters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
        private static readonly char[] lowerCharacters = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
        private static readonly char[] digits = "0123456789".ToCharArray();
        private static readonly char[] turkishCharacters = { 'ç', 'Ç', 'ğ', 'Ğ', 'ı', 'İ', 'ö', 'Ö', 'ş', 'Ş', 'ü', 'Ü' };
        private static readonly char[] symbols = { '!', '@', '#', '$', '%', '^', '&', '*', '(', ')', '-', '_', '=', '+', '[', ']', '{', '}', '\\', '|', ';', ':', '\'', '\"', ',', '.', '<', '>', '/', '?', '`', '~' };
        public static bool DigitControl(string input) =>
            string.IsNullOrWhiteSpace(input) is true ? false : input.Any(character => digits.Contains(character));

        public static bool TRCharacterControl(string input) =>
            string.IsNullOrWhiteSpace(input) is true ? false : input.Any(character => turkishCharacters.Contains(character));

        public static bool SymbolControl(string input) =>
            string.IsNullOrWhiteSpace(input) is true ? false : input.Any(character => symbols.Contains(character));

        public static string Generator(int upperCharacter = 0, int lowerCharacter = 0, int turkishCharacter = 0, int digit = 0, int symbol = 0)
        {
            var random = new Random();
            var code = new StringBuilder();

            for (int i = 0; i < upperCharacter; i++) code.Append(upperCharacters[random.Next(upperCharacters.Length)]);
            for (int i = 0; i < lowerCharacter; i++) code.Append(lowerCharacters[random.Next(lowerCharacters.Length)]);
            for (int i = 0; i < turkishCharacter; i++) code.Append(turkishCharacters[random.Next(turkishCharacters.Length)]);
            for (int i = 0; i < digit; i++) code.Append(digits[random.Next(digits.Length)]);
            for (int i = 0; i < symbol; i++) code.Append(symbols[random.Next(symbols.Length)]);

            return new string(code.ToString().OrderBy(orderBy => random.Next()).ToArray());
        }
    }
}