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