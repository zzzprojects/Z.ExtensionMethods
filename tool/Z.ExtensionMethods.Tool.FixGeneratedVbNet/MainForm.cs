// Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// Website & Documentation: https://csharp-extension.com/
// Issues: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License (MIT): https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: https://zzzprojects.com/
// Copyright © ZZZ Projects Inc. All rights reserved.
using System;
using System.IO;
using System.Windows.Forms;

namespace Z.ExtensionMethods.Tool.FixGeneratedVbNet
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            DirectoryInfo outputDirectory = My.Config.AppSettings.OutputDirectoryPath.Replace("{DesktopPath}", desktopPath).ToDirectoryInfo();
            outputDirectory.EnsureDirectoryExists();
            outputDirectory.Clear();

            DirectoryInfo sourceDirectory = My.Config.AppSettings.SourceDirectoryPath.Replace("{DesktopPath}", desktopPath).ToDirectoryInfo();
            FileInfo[] files = sourceDirectory.GetFiles("*.*", SearchOption.AllDirectories);

            int i = 0;
            foreach (FileInfo file in files)
            {
                string s = file.ReadToEnd();

                s = s.Replace(@"	Private Sub New()
	End Sub", "")
                    .Replace("Public NotInheritable Partial Class Extensions", "Public Module Extensions_" + i)
                    .Replace("Public Shared Function", "Public Function")
                    .Replace("Public Shared Sub", "Public Sub")
                    .Replace("End Class", "End Module")
                    .Replace(@"'=======================================================
'Service provided by Telerik (www.telerik.com)
'Conversion powered by NRefactory.
'Twitter: @telerik
'Facebook: facebook.com/telerik
'=======================================================", "");

                string newPath = file.FullName.Replace(sourceDirectory.FullName, outputDirectory.FullName);
                newPath.ToFileInfo().EnsureDirectoryExists();
                s.SaveAs(newPath);

                i++;
            }
        }
    }
}