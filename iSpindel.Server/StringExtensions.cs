namespace iSpindel.Server
{
    public static class StringExtensions
    {
        public static string AppendTerminatorChar(this string prefix)
        {
            return prefix.EndsWith("/") ? prefix : prefix + '/';
        }

    }
}
