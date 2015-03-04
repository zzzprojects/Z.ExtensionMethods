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
    public class System_Web_UI_Control_FindControl
    {
        [TestMethod]
        public void FindControl()
        {
            // Type
            var @this = new Control();
            @this.Controls.Add(new Literal {ID = "Fizz"});

            // Examples
            var value1 = @this.FindControl<Literal>("Fizz"); // return control as Literal.
            var value2 = @this.FindControl<Literal>("Buzz"); // return null;
        }
    }
}