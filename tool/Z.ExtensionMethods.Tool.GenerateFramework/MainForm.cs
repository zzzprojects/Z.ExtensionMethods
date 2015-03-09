// Copyright (c) 2015 ZZZ Projects. All rights reserved
// Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
// Website: http://www.zzzprojects.com/
// Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
// All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

using System;
using System.Collections.Generic;
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
        public const string Template_WithNamespace = @"using MySql.Data.MySqlClient;
using Z.Core.Extensions;
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
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            DirectoryInfo outputDirectory = My.Config.AppSettings.OutputDirectoryPath.Replace("{DesktopPath}", desktopPath).ToDirectoryInfo();
            outputDirectory.EnsureDirectoryExists();
            outputDirectory.Clear();

            // GET files
            DirectoryInfo sourceDirectory = Environment.CurrentDirectory.PathCombine("..\\".Repeat(4), "src").ToDirectoryInfo();
            List<FileInfo> list = sourceDirectory.GetFiles("*.cs", SearchOption.AllDirectories).
                Where(x => !x.FullName.Contains("\\Properties\\")).ToList();

            DirectoryInfo workingDirectory;
            string template;

            // Z.ExtensionMethods
            {
                workingDirectory = outputDirectory.CreateSubdirectory("Z.ExtensionMethods");
                list.ForEach(x =>
                {
                    FileInfo newFile = x.FullName.Replace(sourceDirectory.FullName, workingDirectory.FullName).ToFileInfo();
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
                    FileInfo newFile = x.FullName.Replace(sourceDirectory.FullName, workingDirectory.FullName).ToFileInfo();
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
                    FileInfo newFile = x.FullName.Replace(sourceDirectory.FullName, workingDirectory.FullName).ToFileInfo();
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
                    FileInfo newFile = x.FullName.Replace(sourceDirectory.FullName, workingDirectory.FullName).ToFileInfo();
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
                    FileInfo newFile = x.FullName.Replace(sourceDirectory.FullName, workingDirectory.FullName).ToFileInfo();
                    newFile.EnsureDirectoryExists();

                    int lastPos = x.FullName.IndexOf("\\", sourceDirectory.FullName.Length + 1, StringComparison.Ordinal);
                    string currentNamespace = x.FullName.Substring(sourceDirectory.FullName.Length + 1, lastPos - sourceDirectory.FullName.Length - 1);
                    template = Template_WithNamespace;
                    template
                        .Replace("@(Model.Namespace)", currentNamespace)
                        .Replace("@(Model.Content)", x.ReadToEnd().Replace("using MySql.Data.MySqlClient;", "")).SaveAs(newFile);
                });
            }
        }
    }
}