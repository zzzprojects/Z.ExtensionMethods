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
    public class System_Data_DataTable_FirstRow
    {
        [TestMethod]
        public void FirstRow()
        {
            // Type
            var @this = new DataTable();

            // Variables
            @this.Columns.Add("UnitTest");
            @this.Rows.Add("Fizz");
            @this.Rows.Add("Buzz");

            // Exemples
            DataRow result = @this.FirstRow(); // return @this.Rows[0];

            // Unit Test
            Assert.AreEqual("Fizz", result["UnitTest"]);
        }
    }
}