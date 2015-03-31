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