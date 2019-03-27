// Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// Website & Documentation: https://csharp-extension.com/
// Issues: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License (MIT): https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: https://zzzprojects.com/
// Copyright © ZZZ Projects Inc. All rights reserved.
using System.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Data.Test
{
    [TestClass]
    public class System_Data_DataRow_ToExpandoObject
    {
        [TestMethod]
        public void ToExpandoObject()
        {
            // Type
            var @this = new DataTable();

            // Variables
            @this.Columns.Add("IntColumn", typeof (int));
            @this.Columns.Add("StringColumn", typeof (string));
            @this.Rows.Add(1, "Fizz");

            // Exemples
            dynamic expandoObject = @this.Rows[0].ToExpandoObject();

            // Unit Test
            Assert.AreEqual(1, expandoObject.IntColumn);
            Assert.AreEqual("Fizz", expandoObject.StringColumn);
        }
    }
}