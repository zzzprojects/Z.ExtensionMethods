// Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// Website & Documentation: https://csharp-extension.com/
// Issues: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License (MIT): https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: https://zzzprojects.com/
// Copyright © ZZZ Projects Inc. All rights reserved.
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