using System.Configuration;

namespace Z.Data.Test
{
    public static class My
    {
        public static class Config
        {
            public static class ConnectionString
            {
                public static ConnectionStringSettings UnitTest = ConfigurationManager.ConnectionStrings["UnitTest"];
            }
        }
    }
}