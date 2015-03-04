// Copyright (c) 2015 ZZZ Projects. All rights reserved
// Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
// Website: http://www.zzzprojects.com/
// Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
// All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

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