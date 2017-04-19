// Description: C# Extension Methods Library to enhances the .NET Framework by adding hundreds of new methods. It drastically increases developers productivity and code readability. Support C# and VB.NET
// Website & Documentation: https://github.com/zzzprojects/Z.ExtensionMethods
// Forum: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License: https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: http://www.zzzprojects.com/
// Copyright © ZZZ Projects Inc. 2014 - 2016. All rights reserved.
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Web.Test
{
    [TestClass]
    public class System_Web_UI_Control_FindControlRecursive
    {
        [TestMethod]
        public void FindControlRecursive()
        {
            // Type
            var @this = new Control();
            @this.Controls.Add(new Control {ID = "Fizz"});
            @this.Controls[0].Controls.Add(new Literal {ID = "Buzz"});

            // Examples
            Control value1 = @this.FindControlRecursive("Fizz"); // return control as Control.
            var value2 = @this.FindControlRecursive<Literal>("Buzz"); // return control as Literal.
            Control value3 = @this.FindControlRecursive("Z"); // return null;
        }
    }
}