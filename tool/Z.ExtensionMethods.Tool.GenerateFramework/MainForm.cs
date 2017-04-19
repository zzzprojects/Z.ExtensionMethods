// Description: C# Extension Methods Library to enhances the .NET Framework by adding hundreds of new methods. It drastically increases developers productivity and code readability. Support C# and VB.NET
// Website & Documentation: https://github.com/zzzprojects/Z.ExtensionMethods
// Forum: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License: https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: http://www.zzzprojects.com/
// Copyright © ZZZ Projects Inc. 2014 - 2016. All rights reserved.
using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Z.ExtensionMethods.Tool.GenerateFramework
{
    public partial class MainForm : Form
    {
        public const string Template_NoNamespace = "@(Model.Content)";
        public const string Template_NoNamespace_WithObjectNamespace = @"using Z.ExtensionMethods.ObjectExtensions;

@(Model.Content)";
        public const string Template_WithNamespace = @"using Z.Core.Extensions;
using Z.Data.Extensions;

namespace @(Model.Namespace).Extensions
{

@(Model.Content)

}";
        public const string Template_Z_ExtensionMethods = @"namespace Z.ExtensionMethods
{

@(Model.Content)

}";
        public const string Template_Z_ExtensionMethods_WithTwoNamespaceExtensions = @"using Z.ExtensionMethods.ObjectExtensions;

namespace Z.ExtensionMethods
{

@(Model.Content)

}";
        public const string Template_Z_ExtensionMethods_WithObjectExtensions = @"using Z.ExtensionMethods.ObjectExtensions;

@(Model.Content)
";
        public const string Template_Z_ExtensionMethods_ObjectExtensions = @"namespace Z.ExtensionMethods.ObjectExtensions
{

@(Model.Content)

}";

        public MainForm()
        {
            InitializeComponent();

            // CLEAR OutputDirectory
            var desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            var outputDirectory = My.Config.AppSettings.OutputDirectoryPath.Replace("{DesktopPath}", desktopPath).ToDirectoryInfo();
            outputDirectory.EnsureDirectoryExists();
            outputDirectory.Clear();

            // GET files
            var sourceDirectory = Environment.CurrentDirectory.PathCombine("..\\".Repeat(4), "src").ToDirectoryInfo();
            var list = sourceDirectory.GetFiles("*.cs", SearchOption.AllDirectories)
                .Where(x => !x.FullName.Contains("\\Properties\\"))
                .Where(x => !x.FullName.Contains("\\Z.Data.MySql\\"))
                .Where(x => !x.FullName.Contains("\\Z.Data.SQLite\\"))
                .Where(x => !x.FullName.Contains("\\Z.Data.SqlServerCe\\")).ToList();

            DirectoryInfo workingDirectory;
            string template;

            // Z.ExtensionMethods
            {
                workingDirectory = outputDirectory.CreateSubdirectory("Z.ExtensionMethods");
                list.ForEach(x =>
                {
                    var newFile = x.FullName.Replace(sourceDirectory.FullName, workingDirectory.FullName).ToFileInfo();
                    newFile.EnsureDirectoryExists();

                    template = Template_NoNamespace;
                    template.Replace("@(Model.Content)", x.ReadToEnd()).SaveAs(newFile);
                });
            }

            // Z.ExtensionMethods.OneNamespace
            {
                workingDirectory = outputDirectory.CreateSubdirectory("Z.ExtensionMethods.WithOneNamespace");
                list.ForEach(x =>
                {
                    var newFile = x.FullName.Replace(sourceDirectory.FullName, workingDirectory.FullName).ToFileInfo();
                    newFile.EnsureDirectoryExists();

                    template = Template_Z_ExtensionMethods;
                    template.Replace("@(Model.Content)", x.ReadToEnd()).SaveAs(newFile);
                });
            }

            // Z.ExtensionMethods.TwoNamespace
            {
                workingDirectory = outputDirectory.CreateSubdirectory("Z.ExtensionMethods.WithTwoNamespace");
                list.ForEach(x =>
                {
                    var newFile = x.FullName.Replace(sourceDirectory.FullName, workingDirectory.FullName).ToFileInfo();
                    newFile.EnsureDirectoryExists();

                    template = newFile.FullName.Contains("System.Object") ? Template_Z_ExtensionMethods_ObjectExtensions : Template_Z_ExtensionMethods_WithTwoNamespaceExtensions;
                    template.Replace("@(Model.Content)", x.ReadToEnd()).SaveAs(newFile);
                });
            }


            // Z.ExtensionMethods.WithObjectNamespace
            {
                workingDirectory = outputDirectory.CreateSubdirectory("Z.ExtensionMethods.WithObjectNamespace");
                list.ForEach(x =>
                {
                    var newFile = x.FullName.Replace(sourceDirectory.FullName, workingDirectory.FullName).ToFileInfo();
                    newFile.EnsureDirectoryExists();

                    template = newFile.FullName.Contains("System.Object") ? Template_Z_ExtensionMethods_ObjectExtensions : Template_Z_ExtensionMethods_WithObjectExtensions;
                    template.Replace("@(Model.Content)", x.ReadToEnd()).SaveAs(newFile);
                });
            }

            // Z.ExtensionMethods.WithNamespace
            {
                workingDirectory = outputDirectory.CreateSubdirectory("Z.ExtensionMethods.WithNamespace");
                list.ForEach(x =>
                {
                    var newFile = x.FullName.Replace(sourceDirectory.FullName, workingDirectory.FullName).ToFileInfo();
                    newFile.EnsureDirectoryExists();

                    var lastPos = x.FullName.IndexOf("\\", sourceDirectory.FullName.Length + 1, StringComparison.Ordinal);
                    var currentNamespace = x.FullName.Substring(sourceDirectory.FullName.Length + 1, lastPos - sourceDirectory.FullName.Length - 1);
                    template = Template_WithNamespace;
                    template
                        .Replace("@(Model.Namespace)", currentNamespace)
                        .Replace("@(Model.Content)", x.ReadToEnd().Replace("using MySql.Data.MySqlClient;", "")).SaveAs(newFile);
                });
            }

            // DB Specialized
            {
                var listSpecialized = sourceDirectory.GetFiles("*.cs", SearchOption.AllDirectories)
                    .Where(x => !x.FullName.Contains("\\Properties\\"))
                    .Where(x => x.FullName.Contains("\\Z.Data.MySql\\") || x.FullName.Contains("\\Z.Data.SQLite\\") || x.FullName.Contains("\\Z.Data.SqlServerCe\\"))
                    .ToList();

                workingDirectory = outputDirectory;
                listSpecialized.ForEach(x =>
                {
                    var newFile = x.FullName.Replace(sourceDirectory.FullName, workingDirectory.FullName).ToFileInfo();
                    newFile.EnsureDirectoryExists();

                    template = Template_NoNamespace;
                    template.Replace("@(Model.Content)", x.ReadToEnd()).SaveAs(newFile);
                });
            }
        }
    }
}