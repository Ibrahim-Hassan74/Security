namespace Security.Extensions
{
    public static class CharExtensions
    {
        public static bool IsAsciiLetter(this char c)
        {
            return (c >= 'a' && c <= 'z') ||
                   (c >= 'A' && c <= 'Z');
        }
    }

}
