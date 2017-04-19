// Description: C# Extension Methods Library to enhances the .NET Framework by adding hundreds of new methods. It drastically increases developers productivity and code readability. Support C# and VB.NET
// Website & Documentation: https://github.com/zzzprojects/Z.ExtensionMethods
// Forum: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License: https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: http://www.zzzprojects.com/
// Copyright © ZZZ Projects Inc. 2014 - 2016. All rights reserved.
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace Z.Reflection.Documentation.Test
{
    /// <summary>An entity.</summary>
    public class Entity
    {
        /// <summary>The field int.</summary>
        public static int FieldInt = 3;

        private int _propertyInt;

        /// <summary>Default constructor.</summary>
        public Entity()
        {
        }

        /// <summary>Constructor.</summary>
        /// <param name="param0">The parameter 0.</param>
        public Entity(int param0)
        {
        }

        /// <summary>The property int.</summary>
        public int PropertyInt { get; set; }

        public int PropertyIntGet
        {
            get { return _propertyInt; }
        }

        public int PropertyIntSet
        {
            set { _propertyInt = value; }
        }

        /// <summary>Indexer to get items within this collection using array index syntax.</summary>
        /// <param name="param0">The parameter 0.</param>
        /// <returns>The indexed item.</returns>
        public int this[int param0]
        {
            get { return 1; }
        }

        /// <summary>Indexer to get items within this collection using array index syntax.</summary>
        /// <param name="param0">The parameter 0.</param>
        /// <param name="param1">The first parameter.</param>
        /// <returns>The indexed item.</returns>
        public int this[int param0, string param1]
        {
            get { return 1; }
        }

        /// <summary>Method 0.</summary>
        /// <returns>An int.</returns>
        public int Method0()
        {
            return 1;
        }

        /// <summary>Method optional default value.</summary>
        /// <param name="param0">(Optional) The parameter 0.</param>
        /// <returns>An int.</returns>
        public int MethodOptionalDefaultValue(int param0 = 1)
        {
            return 1;
        }

        /// <summary>Method in.</summary>
        /// <param name="param">The parameter.</param>
        /// <returns>An int.</returns>
        public int MethodIn([In] object param)
        {
            return 1;
        }

        /// <summary>Method out.</summary>
        /// <param name="param">The parameter.</param>
        /// <returns>An int.</returns>
        public int MethodOut([Out] object param)
        {
            return 1;
        }

        /// <summary>Method default value.</summary>
        /// <param name="param">The parameter.</param>
        /// <returns>An int.</returns>
        public int MethodDefaultValue([DefaultValue(-10)] int param)
        {
            return 1;
        }

        /// <summary>Method optional.</summary>
        /// <param name="param">The parameter.</param>
        /// <returns>An int.</returns>
        public int MethodOptional([Optional, In, Out] int param)
        {
            return 1;
        }

        /// <summary>Method 1.</summary>
        /// <param name="param0">The parameter 0.</param>
        /// <returns>An int.</returns>
        public int Method1(int param0)
        {
            return 1;
        }

        /// <summary>Method 2.</summary>
        /// <param name="param0">The parameter 0.</param>
        /// <param name="param1">The first parameter.</param>
        /// <returns>An int.</returns>
        public int Method2(int param0, string param1)
        {
            return 1;
        }

        /// <summary>Method out.</summary>
        /// <param name="param0">[in,out] The parameter 0.</param>
        /// <returns>An int.</returns>
        public int MethodOut(out int param0)
        {
            param0 = 1;
            return 1;
        }

        /// <summary>Method reference.</summary>
        /// <param name="param0">[in,out] The parameter 0.</param>
        /// <returns>An int.</returns>
        public int MethodRef(ref int param0)
        {
            return 1;
        }

        /// <summary>Method parameters.</summary>
        /// <param name="list">A variable-length parameters list containing list.</param>
        /// <returns>An int.</returns>
        public int MethodParams(params int[] list)
        {
            return 1;
        }

        /// <summary>Method generic 1.</summary>
        /// <typeparam name="T">Generic type parameter.</typeparam>
        /// <param name="param0">The parameter 0.</param>
        /// <returns>A T.</returns>
        public T MethodGeneric1<T>(T param0)
        {
            return param0;
        }

        /// <summary>Method generic 2.</summary>
        /// <typeparam name="T1">Generic type parameter.</typeparam>
        /// <typeparam name="T2">Generic type parameter.</typeparam>
        /// <param name="param0">The parameter 0.</param>
        /// <param name="param1">The first parameter.</param>
        /// <returns>A T1.</returns>
        public T1 MethodGeneric2<T1, T2>(T1 param0, T2 param1)
        {
            return param0;
        }

        /// <summary>Tests dictionary.</summary>
        /// <param name="abc">The abc.</param>
        /// <param name="abc2">The second abc.</param>
        /// <returns>An int.</returns>
        public int TestDict(Dictionary<string, string> abc, Dictionary<string, Dictionary<string, string>> abc2)
        {
            return 1;
        }

        /// <summary>Tests dictionary.</summary>
        /// <param name="abc">The abc.</param>
        /// <param name="abc2">The second abc.</param>
        /// <returns>An int.</returns>
        public int TestDictGeneric<T1, T2>(Dictionary<T1, T2> abc, Dictionary<T2, Dictionary<T2, T1>> abc2)
        {
            return 1;
        }
    }
}