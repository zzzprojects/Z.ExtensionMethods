// Copyright (c) 2015 ZZZ Projects. All rights reserved
// Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
// Website: http://www.zzzprojects.com/
// Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
// All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

using System.Linq;
using System.Reflection;
using System.Text;

public static partial class Extensions
{
    /// <summary>A PropertyInfo extension method that gets a declaraction.</summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>The declaraction.</returns>
    public static string GetDeclaraction(this PropertyInfo @this)
    {
        // Example: [Visibility] [Modifier] [Type] [Name | Indexer] { [VisibilityGetter] [Getter]; [VisibilitySetter] [Setter]; }
        var sb = new StringBuilder();

        // Variable
        bool canRead = @this.CanRead;
        bool canWrite = @this.CanWrite;
        int readLevel = 9;
        int writeLevel = 9;
        string readVisibility = "";
        string writeVisibility = "";

        // Variable Method
        bool isAbstract = false;
        bool isOverride = false;
        bool isStatic = false;
        bool isVirtual = false;

        // Set visibility
        if (canRead)
        {
            MethodInfo method = @this.GetGetMethod(true);
            isAbstract = method.IsAbstract;
            isOverride = method.GetBaseDefinition().DeclaringType != method.DeclaringType;
            isStatic = method.IsStatic;
            isVirtual = method.IsVirtual;

            if (method.IsPublic)
            {
                readLevel = 1;
                readVisibility = "public ";
            }
            else if (method.IsFamily)
            {
                readLevel = 2;
                readVisibility = "protected ";
            }
            else if (method.IsAssembly)
            {
                readLevel = 3;
                readVisibility = "internal ";
            }
            else if (method.IsPrivate)
            {
                readLevel = 5;
                readVisibility = "private ";
            }
            else
            {
                readLevel = 4;
                readVisibility = "protected internal ";
            }
        }
        if (canWrite)
        {
            MethodInfo method = @this.GetSetMethod(true);

            if (readLevel != 9)
            {
                isAbstract = method.IsAbstract;
                isOverride = method.GetBaseDefinition().DeclaringType != method.DeclaringType;
                isStatic = method.IsStatic;
                isVirtual = method.IsVirtual;
            }

            if (method.IsPublic)
            {
                writeLevel = 1;
                writeVisibility = "public ";
            }
            else if (method.IsFamily)
            {
                writeLevel = 2;
                writeVisibility = "protected ";
            }
            else if (method.IsAssembly)
            {
                writeLevel = 3;
                writeVisibility = "internal ";
            }
            else if (method.IsPrivate)
            {
                writeLevel = 5;
                writeVisibility = "private ";
            }
            else
            {
                writeLevel = 4;
                writeVisibility = "protected internal ";
            }
        }

        // Visibility
        if (canRead && canWrite)
        {
            sb.Append(readLevel <= writeLevel ? readVisibility : writeVisibility);
        }
        else if (canRead)
        {
            sb.Append(readVisibility);
        }
        else
        {
            sb.Append(writeVisibility);
        }

        // Modifier
        if (isAbstract)
        {
            sb.Append("abstract ");
        }
        else if (isOverride)
        {
            sb.Append("override ");
        }
        else if (isVirtual)
        {
            sb.Append("virtual ");
        }
        else if (isStatic)
        {
            sb.Append("static ");
        }

        // Type
        sb.Append(@this.PropertyType.GetShortDeclaraction());
        sb.Append(" ");

        // [Name | Indexer]
        ParameterInfo[] indexerParameter = @this.GetIndexParameters();
        if (indexerParameter.Length == 0)
        {
            // Name
            sb.Append(@this.Name);
        }
        else
        {
            // Indexer
            sb.Append("this");
            sb.Append("[");
            sb.Append(string.Join(", ", indexerParameter.Select(x => x.ParameterType.GetShortDeclaraction() + " " + x.Name)));
            sb.Append("]");
        }
        sb.Append(" ");

        sb.Append("{ ");
        // Getter
        if (@this.CanRead)
        {
            if (readLevel > writeLevel)
            {
                sb.Append(readVisibility);
            }
            sb.Append("get; ");
        }

        // Setter
        if (@this.CanWrite)
        {
            if (writeLevel > readLevel)
            {
                sb.Append(writeVisibility);
            }
            sb.Append("set; ");
        }
        sb.Append("}");

        return sb.ToString();
    }
}