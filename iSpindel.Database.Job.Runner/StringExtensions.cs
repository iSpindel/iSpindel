namespace iSpindel.Database.Job.Runner
{
    internal static class StringExtensions
    {
        public static string AppendTerminatorChar(this string prefix)
        {
            return prefix.EndsWith("/") ? prefix : prefix + '/';
        }

    }
}
