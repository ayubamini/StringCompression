namespace StringCompression
{
    public static class CompressionValidator
    {
        public static void ValidateInput(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                throw new InvalidInputString();
            }
        }
    }
}