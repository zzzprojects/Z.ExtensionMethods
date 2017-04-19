// Description: C# Extension Methods Library to enhances the .NET Framework by adding hundreds of new methods. It drastically increases developers productivity and code readability. Support C# and VB.NET
// Website & Documentation: https://github.com/zzzprojects/Z.ExtensionMethods
// Forum: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License: https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: http://www.zzzprojects.com/
// Copyright © ZZZ Projects Inc. 2014 - 2016. All rights reserved.
namespace Z.Reflection.Test
{
    public static class StaticClass
    {
    }

    public abstract class AbstractClass
    {
    }

    public class PublicClass
    {
    }

    internal class InternalClass
    {
    }

    public interface IPublicInterface
    {
    }

    public class InheritedClass : PublicClass
    {
    }

    public class InheritedClassAndInterface : PublicClass, IPublicInterface
    {
    }

    public class GenericClass<T1, T2>
    {
    }

    public class GenericClassWithWhereClause<T> where T : class, new()
    {
    }

    public interface IGenericInterfaceWithInParameter<in T>
    {
    }

    public interface IGenericInterfaceWithOutParameter<out T>
    {
    }
}