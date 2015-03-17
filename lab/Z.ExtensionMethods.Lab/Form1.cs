// Copyright (c) 2015 ZZZ Projects. All rights reserved
// Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
// Website: http://www.zzzprojects.com/
// Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
// All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml.Schema;
using Z.Reflection.Documentation.Test;

namespace Z.ExtensionMethods.Lab
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
      
           //var entityMembers =  typeof (Entity).GetMembers();
           // var list1 = entityMembers.Select(x => x.GetSignature()).ToList();
           // var list2 = entityMembers.Select(x => x.GetDeclaration()).ToList();
           // var list3 = entityMembers.Select(x => x.GetMemberName()).ToList();

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