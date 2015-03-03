using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Core.Test
{
    [TestClass]
    public class System_Enum_GetCustomAttributeDescription
    {
        public enum TestEnum
        {
            [System.ComponentModel.Description("Test Description")] Test
        }

        [TestMethod]
        public void GetCustomAttributeDescription()
        {
            // Type
            var @this = TestEnum.Test;

            // Exemples
            string result = @this.GetCustomAttributeDescription(); // return "Test Description";

            // Unit Test
            Assert.AreEqual("Test Description", result);
        }
    }
}