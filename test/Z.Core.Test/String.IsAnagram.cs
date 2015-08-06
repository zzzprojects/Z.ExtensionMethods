// Copyright (c) 2015 ZZZ Projects. All rights reserved
// Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
// Website: http://www.zzzprojects.com/
// Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
// All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Core.Test
{
    [TestClass]
    public class System_String_IsAnagram
    {
        [TestMethod]
        public void IsAnagram()
        {
            // Type
            string @thisAnagram = "abba";
            string @thisNotAnagram = "abab";
            string @EmptyString = "";
            string @otherString = "abba";

            // Examples
            bool value1 = @thisAnagram.IsAnagram();                 // return true;
            bool value2 = @thisNotAnagram.IsAnagram();              // return false;
            bool value3 = @EmptyString.IsAnagram();                 // return true because reverse an empty string is an empty string;
            bool value4 = @thisAnagram.IsAnagram(@otherString);     // return true;
            bool value5 = @thisNotAnagram.IsAnagram(@otherString);  // return false;
            bool value6 = @EmptyString.IsAnagram(@EmptyString);     // return true;

            
            // Unit Test
            Assert.IsTrue(value1);
            Assert.IsFalse(value2);
            Assert.IsTrue(value3);
            
        }
    }
}
