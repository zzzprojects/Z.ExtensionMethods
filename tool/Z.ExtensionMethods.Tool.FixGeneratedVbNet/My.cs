// Copyright (c) 2015 ZZZ Projects. All rights reserved
// Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
// Website: http://www.zzzprojects.com/
// Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
// All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

using System.Configuration;

namespace Z.ExtensionMethods.Tool.FixGeneratedVbNet
{
    public static class My
    {
        public static class Config
        {
            public static class AppSettings
            {
                public static string SourceDirectoryPath = ConfigurationManager.AppSettings["SourceDirectoryPath"];
                public static string OutputDirectoryPath = ConfigurationManager.AppSettings["OutputDirectoryPath"];
            }
        }
    }
}