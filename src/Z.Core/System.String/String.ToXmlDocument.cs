// Copyright (c) 2015 ZZZ Projects. All rights reserved
// Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
// Website: http://www.zzzprojects.com/
// Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
// All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

using System.Xml;

public static partial class Extensions
{
    /// <summary>
    ///     A string extension method that converts the @this to an XmlDocument.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>@this as an XmlDocument.</returns>
    public static XmlDocument ToXmlDocument(this string @this)
    {
        var doc = new XmlDocument();
        doc.LoadXml(@this);
        return doc;
    }
}