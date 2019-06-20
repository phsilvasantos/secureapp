using System;
using System.IO;

namespace SecureApp.Utilities.Model
{
    public class Location
    {
        public static readonly string SecureApp =
            Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "SecureApp");

        public static readonly string FileToken = Path.Combine(SecureApp, "Guid.id");
    }
}