// Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// Website & Documentation: https://csharp-extension.com/
// Issues: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License (MIT): https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: https://zzzprojects.com/
// Copyright © ZZZ Projects Inc. All rights reserved.
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Core.Test
{
    [TestClass]
    public class System_String_DecryptRSA
    {
        [TestMethod]
        public void DecryptRSA()
        {
            // Type
            string @this = "55-46-E9-4D-4E-B8-DF-34-B6-3E-EC-85-46-A4-B7-8E-E7-FC-79-81-9E-0C-D1-1B-81-25-33-8A-4B-E7-8F-E0-57-CC-12-F2-FC-B1-BD-5B-8B-5A-18-C5-97-9E-06-10-FF-96-FC-3A-6F-4F-94-41-F8-FB-88-A8-AF-35-48-45-8E-0C-3E-08-D9-38-F1-A6-92-31-AE-3A-C8-30-A5-54-3B-6A-78-35-9A-49-69-E0-EC-5E-F4-7D-A1-49-3A-7D-90-03-2D-EC-AE-CB-75-EC-78-BD-59-F0-16-78-EC-C4-5B-3A-9B-61-BC-14-F2-DC-61-55-0D-66-C3-57-91-26";

            // Examples
            string value = @this.DecryptRSA("Buzz"); // return "Fizz";

            // Unit Test
            Assert.AreEqual("Fizz", value);
        }
    }
}