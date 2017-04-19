// Description: C# Extension Methods Library to enhances the .NET Framework by adding hundreds of new methods. It drastically increases developers productivity and code readability. Support C# and VB.NET
// Website & Documentation: https://github.com/zzzprojects/Z.ExtensionMethods
// Forum: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License: https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: http://www.zzzprojects.com/
// Copyright © ZZZ Projects Inc. 2014 - 2016. All rights reserved.
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Z.ExtensionMethods.Lab
{
    public class MyClass
    {
        
    }
    public static class LabExtension
    {
        public static IEnumerable<T> MergeInnerEnumerable<T>(this IEnumerable<IEnumerable<T>> @this)
        {
            var file = @"c:\path";
            List<IEnumerable<T>> listItem = @this.ToList();

            var list = new List<T>();

            foreach (var item in listItem)
            {
                list.AddRange(item);
            }

            return list;
        }

        public static IEnumerable<T> MergeDistinctInnerEnumerable<T>(this IEnumerable<IEnumerable<T>> @this)
        {
            List<IEnumerable<T>> listItem = @this.ToList();

            var list = new List<T>();

            foreach (var item in listItem)
            {
                list = list.Union(item).ToList();
            }

            return list;
        }

        public static string StripHtml(this string @this)
        {
            var path = new StringBuilder(@this);
            var sb = new StringBuilder();

            int pos = 0;

            while (pos < path.Length)
            {
                char ch = path[pos];
                pos++;

                if (ch == '<')
                {
                    // Loop until we close the tag
                    while (pos < path.Length)
                    {
                        ch = path[pos];
                        pos++;

                        if (ch == '>')
                        {
                            break;
                        }

                        if (ch == '\'')
                        {
                            // Skip attribute starting with single quote
                            pos = GetIndexAfterNextSingleQuote(path, pos);
                        }
                        else if (ch == '"')
                        {
                            // Skip attribute starting with double quote
                            pos = GetIndexAfterNextDoubleQuote(path, pos);
                        }
                    }
                }
                else
                {
                    sb.Append(ch);
                }
            }

            return sb.ToString();
        }

        public static string Substring(StringBuilder @this, int startIndex)
        {
            return @this.ToString(startIndex, @this.Length - startIndex);
        }

        public static string Substring(StringBuilder @this, int startIndex, int length)
        {
            return @this.ToString(startIndex, length);
        }


        public static int StripHtml_EndTag(this StringBuilder path, int pos)
        {
            return pos;
        }
        public static int GetIndexAfterNextSingleQuote(StringBuilder path, int startIndex)
        {
            while (startIndex < path.Length)
            {
                char ch = path[startIndex];
                startIndex++;

                char nextChar;
                if (ch == '\\' && startIndex < path.Length && ((nextChar = path[startIndex]) == '\\' || nextChar == '\''))
                {
                    startIndex++; // Treat as escape character for \\ or \"
                }
                else if (ch == '\'')
                {
                    return startIndex;
                }
            }

            return startIndex;
        }

        public static int GetIndexAfterNextDoubleQuote(StringBuilder path, int startIndex)
        {
            while (startIndex < path.Length)
            {
                char ch = path[startIndex];
                startIndex++;

                char nextChar;
                if (ch == '\\' && startIndex < path.Length && ((nextChar = path[startIndex]) == '\\' || nextChar == '"'))
                {
                    startIndex++; // Treat as escape character for \\ or \"
                }
                else if (ch == '"')
                {
                    return startIndex;
                }
            }

            return startIndex;
        }
    }

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            var aaaa = (Attribute)null;
    
            StringBuilder sb = new StringBuilder("0123456789");
            var b4 = "abc".Substring(1, 4);
            char ch = '\'';
            char ch2 = '"';
            string tag = "a<b class='to>to'>c</b>d";
            string tag2 = tag.StripHtml();
            var a = new[] {"a", "b", "c"};
            var b = new[] {"c", "d"};

            using (var command = new SqlCommand())
            {
               // command.ExecuteDataSet();
            }

            var c = new List<String[]> {a, b};
            IEnumerable<string> d = c.MergeInnerEnumerable();
        }

        public void Misc()
        {
            // object a = null;
            // string b = "";
            // MethodBase mi = MethodBase.GetCurrentMethod();
            // MethodInfo serialize2 = typeof (MethodInfo).GetMethod("FormatNameAndSig", BindingFlags.NonPublic | BindingFlags.Instance, null, new[] {typeof (bool)}, null);
            // //MethodInfo serialize = typeof (MethodInfo).GetMethod("FormatNameAndSig", BindingFlags.NonPublic | BindingFlags.Instance);

            // MethodInfo[] methods = typeof (Entity).GetMethods();
            // MethodInfo abc = methods[0];

            // var serialize = serialize2.Invoke(abc, new[] {(object) true});
            // MethodInfo test1 = abc.GetRuntimeBaseDefinition();
            // string assemblyDirectory = @"C:\Program Files (x86)\Reference Assemblies\Microsoft\Framework\.NETFramework\v4.5.1";

            // FileInfo dll = assemblyDirectory.ToDirectoryInfo().GetFiles("System.Core.dll")[0];
            // FileInfo xml = assemblyDirectory.ToDirectoryInfo().GetFiles("System.Core.xml")[0];


            // Assembly assembly = Assembly.UnsafeLoadFrom(dll.FullName);

            // XDocument xDoc = XDocument.Load(xml.FullName);
            // IEnumerable<XElement> members = xDoc.Element("doc").Element("members").Elements("member");

            // Dictionary<string, string> dict = members.Select(x => x.Attribute("name").Value).ToDictionary(x => x);


            // Type[] types = assembly.GetTypes();
            // List<string> memberNames = types.SelectMany(x => x.GetMembers()).Select(x => x.GetMemberName()).OrderBy(x => x).ToList();
            // List<string> typeNames = types.Select(x => x.GetMemberName()).ToList();

            // typeNames.ForEach(x =>
            // {
            //     if (dict.ContainsKey(x))
            //     {
            //         dict.Remove(x);
            //     }
            // });
            // memberNames.ForEach(x =>
            // {
            //     if (dict.ContainsKey(x))
            //     {
            //         dict.Remove(x);
            //     }
            // });

            // var missingTypes = dict.Where(x => x.Value.StartsWith("T:")).ToList();
            // var missingProperty = dict.Where(x => x.Value.StartsWith("P:") && !x.Value.Contains("#")).ToList();
            // var missingField = dict.Where(x => x.Value.StartsWith("F:")).ToList();
            // var missingEvent = dict.Where(x => x.Value.StartsWith("E:")).ToList();
            // var missingMethod = dict.Where(x => x.Value.StartsWith("M:")).ToList();
            // List<string> toVerify = memberNames.Where(x => x.StartsWith("P:System.Runtime.CompilerServices")).OrderBy(x => x).ToList();
        }
    }
}