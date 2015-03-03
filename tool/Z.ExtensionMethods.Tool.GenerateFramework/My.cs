using System.Configuration;

namespace Z.ExtensionMethods.Tool.GenerateFramework
{
    public static class My
    {
        public static class Config
        {
            public static class AppSettings
            {
                public static string OutputDirectoryPath = ConfigurationManager.AppSettings["OutputDirectoryPath"];
            }
        }
    }
}