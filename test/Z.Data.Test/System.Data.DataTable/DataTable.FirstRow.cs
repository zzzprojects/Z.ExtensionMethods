// Description: C# Extension Methods Library to enhances the .NET Framework by adding hundreds of new methods. It drastically increases developers productivity and code readability. Support C# and VB.NET
// Website & Documentation: https://github.com/zzzprojects/Z.ExtensionMethods
// Forum: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License: https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: http://www.zzzprojects.com/
// Copyright © ZZZ Projects Inc. 2014 - 2016. All rights reserved.
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