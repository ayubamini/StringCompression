namespace StringCompression
{
    public static class Compression
    {
        private static string compressedInput = string.Empty;

        public static string Compress(string input)
        {
            CompressionValidator.ValidateInput(input);

            compressedInput = CollapseConsecutiveCharacter(input, input.Length);

            return compressedInput;
        }

        private static string CollapseConsecutiveCharacter(string input, int length)
        {
            var result = string.Empty;

            for (var i = 0; i < length; i++)
            {
                var numberOfCharacter = 1;

                while (i < length - 1 && input[i] == input[i + 1])
                {
                    numberOfCharacter++;
                    i++;
                }

                if (numberOfCharacter == 1)
                    result += input[i].ToString();
                else
                    result += input[i].ToString() + numberOfCharacter;
            }

            return result;
        }
    }
}
