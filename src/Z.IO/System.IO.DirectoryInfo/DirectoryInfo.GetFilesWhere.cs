// Copyright (c) 2015 ZZZ Projects. All rights reserved
// Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
// Website: http://www.zzzprojects.com/
// Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
// All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

using System;
using System.IO;
using System.Linq;

public static partial class Extensions
{
    /// <summary>
    ///     Returns an enumerable collection of file names in a specified @this.
    /// </summary>
    /// <param name="this">The directory to search.</param>
    /// <param name="predicate">The predicate.</param>
    /// <returns>
    ///     An enumerable collection of the full names (including paths) for the files in the directory specified by
    ///     <paramref
    ///         name="this" />
    ///     .
    /// </returns>
    /// ###
    /// <exception cref="T:System.ArgumentException">
    ///     <paramref name="this " />is a zero-length string, contains only
    ///     white space, or contains invalid characters as defined by
    ///     <see
    ///         cref="M:System.IO.Path.GetInvalidPathChars" />
    ///     .
    /// </exception>
    /// ###
    /// <exception cref="T:System.ArgumentNullException">
    ///     <paramref name="this" /> is null.
    /// </exception>
    /// ###
    /// <exception cref="T:System.IO.DirectoryNotFoundException">
    ///     <paramref name="this" /> is invalid, such as
    ///     referring to an unmapped drive.
    /// </exception>
    /// ###
    /// <exception cref="T:System.IO.IOException">
    ///     <paramref name="this" /> is a file name.
    /// </exception>
    /// ###
    /// <exception cref="T:System.IO.PathTooLongException">
    ///     The specified @this, file name, or combined exceed the
    ///     system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters
    ///     and file names must be less than 260 characters.
    /// </exception>
    /// ###
    /// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission.</exception>
    /// ###
    /// <exception cref="T:System.UnauthorizedAccessException">The caller does not have the required permission.</exception>
    public static FileInfo[] GetFilesWhere(this DirectoryInfo @this, Func<FileInfo, bool> predicate)
    {
        return Directory.EnumerateFiles(@this.FullName).Select(x => new FileInfo(x)).Where(x => predicate(x)).ToArray();
    }

    /// <summary>
    ///     Returns an enumerable collection of file names that match a search pattern in a specified @this.
    /// </summary>
    /// <param name="this">The directory to search.</param>
    /// <param name="searchPattern">
    ///     The search string to match against the names of directories in
    ///     <paramref name="this" />.
    /// </param>
    /// <param name="predicate">The predicate.</param>
    /// <returns>
    ///     An enumerable collection of the full names (including paths) for the files in the directory specified by
    ///     <paramref
    ///         name="this" />
    ///     and that match the specified search pattern.
    /// </returns>
    /// <example>
    ///     <code>
    ///       using System;
    ///       using System.IO;
    ///       using Microsoft.VisualStudio.TestTools.UnitTesting;
    /// 
    /// 
    ///       namespace ExtensionMethods.Examples
    ///       {
    ///           [TestClass]
    ///           public class System_IO_DirectoryInfo_GetFilesWhere
    ///           {
    ///               [TestMethod]
    ///               public void GetFilesWhere()
    ///               {
    ///                   // Type
    ///                   var root = new DirectoryInfo(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, &quot;System_IO_DirectoryInfo_GetFilesWhere&quot;));
    ///                   Directory.CreateDirectory(root.FullName);
    /// 
    ///                   var file1 = new FileInfo(Path.Combine(root.FullName, &quot;test.txt&quot;));
    ///                   var file2 = new FileInfo(Path.Combine(root.FullName, &quot;test.cs&quot;));
    ///                   var file3 = new FileInfo(Path.Combine(root.FullName, &quot;test.asp&quot;));
    ///                   file1.Create();
    ///                   file2.Create();
    ///                   file3.Create();
    /// 
    ///                   // Exemples
    ///                   FileInfo[] result = root.GetFilesWhere(x =&gt; x.Extension == &quot;.txt&quot; || x.Extension == &quot;.cs&quot;);
    /// 
    ///                   // Unit Test
    ///                   Assert.AreEqual(2, result.Length);
    ///               }
    ///           }
    ///       }
    /// </code>
    /// </example>
    /// <example>
    ///     <code>
    ///       using System;
    ///       using System.IO;
    ///       using Microsoft.VisualStudio.TestTools.UnitTesting;
    ///       using Z.ExtensionMethods;
    /// 
    ///       namespace ExtensionMethods.Examples
    ///       {
    ///           [TestClass]
    ///           public class System_IO_DirectoryInfo_GetFilesWhere
    ///           {
    ///               [TestMethod]
    ///               public void GetFilesWhere()
    ///               {
    ///                   // Type
    ///                   var root = new DirectoryInfo(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, &quot;System_IO_DirectoryInfo_GetFilesWhere&quot;));
    ///                   Directory.CreateDirectory(root.FullName);
    /// 
    ///                   var file1 = new FileInfo(Path.Combine(root.FullName, &quot;test.txt&quot;));
    ///                   var file2 = new FileInfo(Path.Combine(root.FullName, &quot;test.cs&quot;));
    ///                   var file3 = new FileInfo(Path.Combine(root.FullName, &quot;test.asp&quot;));
    ///                   file1.Create();
    ///                   file2.Create();
    ///                   file3.Create();
    /// 
    ///                   // Exemples
    ///                   FileInfo[] result = root.GetFilesWhere(x =&gt; x.Extension == &quot;.txt&quot; || x.Extension == &quot;.cs&quot;);
    /// 
    ///                   // Unit Test
    ///                   Assert.AreEqual(2, result.Length);
    ///               }
    ///           }
    ///       }
    /// </code>
    /// </example>
    /// ###
    /// <exception cref="T:System.ArgumentException">
    ///     <paramref name="this " />is a zero-length string, contains only
    ///     white space, or contains invalid characters as defined by
    ///     <see
    ///         cref="M:System.IO.Path.GetInvalidPathChars" />
    ///     .- or -<paramref name="searchPattern" /> does not contain a valid pattern.
    /// </exception>
    /// ###
    /// <exception cref="T:System.ArgumentNullException">
    ///     <paramref name="this" /> is null.-or-
    ///     <paramref name="searchPattern" /> is null.
    /// </exception>
    /// ###
    /// <exception cref="T:System.IO.DirectoryNotFoundException">
    ///     <paramref name="this" /> is invalid, such as
    ///     referring to an unmapped drive.
    /// </exception>
    /// ###
    /// <exception cref="T:System.IO.IOException">
    ///     <paramref name="this" /> is a file name.
    /// </exception>
    /// ###
    /// <exception cref="T:System.IO.PathTooLongException">
    ///     The specified @this, file name, or combined exceed the
    ///     system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters
    ///     and file names must be less than 260 characters.
    /// </exception>
    /// ###
    /// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission.</exception>
    /// ###
    /// <exception cref="T:System.UnauthorizedAccessException">The caller does not have the required permission.</exception>
    public static FileInfo[] GetFilesWhere(this DirectoryInfo @this, String searchPattern, Func<FileInfo, bool> predicate)
    {
        return Directory.EnumerateFiles(@this.FullName, searchPattern).Select(x => new FileInfo(x)).Where(x => predicate(x)).ToArray();
    }

    /// <summary>
    ///     Returns an enumerable collection of file names that match a search pattern in a specified @this, and
    ///     optionally searches subdirectories.
    /// </summary>
    /// <param name="this">The directory to search.</param>
    /// <param name="searchPattern">
    ///     The search string to match against the names of directories in
    ///     <paramref name="this" />.
    /// </param>
    /// <param name="searchOption">
    ///     One of the enumeration values that specifies whether the search operation should
    ///     include only the current directory or should include all subdirectories.The default value is
    ///     <see
    ///         cref="F:System.IO.SearchOption.TopDirectoryOnly" />
    ///     .
    /// </param>
    /// <param name="predicate">The predicate.</param>
    /// <returns>
    ///     An enumerable collection of the full names (including paths) for the files in the directory specified by
    ///     <paramref
    ///         name="this" />
    ///     and that match the specified search pattern and option.
    /// </returns>
    /// <example>
    ///     <code>
    ///       using System;
    ///       using System.IO;
    ///       using Microsoft.VisualStudio.TestTools.UnitTesting;
    /// 
    /// 
    ///       namespace ExtensionMethods.Examples
    ///       {
    ///           [TestClass]
    ///           public class System_IO_DirectoryInfo_GetFilesWhere
    ///           {
    ///               [TestMethod]
    ///               public void GetFilesWhere()
    ///               {
    ///                   // Type
    ///                   var root = new DirectoryInfo(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, &quot;System_IO_DirectoryInfo_GetFilesWhere&quot;));
    ///                   Directory.CreateDirectory(root.FullName);
    /// 
    ///                   var file1 = new FileInfo(Path.Combine(root.FullName, &quot;test.txt&quot;));
    ///                   var file2 = new FileInfo(Path.Combine(root.FullName, &quot;test.cs&quot;));
    ///                   var file3 = new FileInfo(Path.Combine(root.FullName, &quot;test.asp&quot;));
    ///                   file1.Create();
    ///                   file2.Create();
    ///                   file3.Create();
    /// 
    ///                   // Exemples
    ///                   FileInfo[] result = root.GetFilesWhere(x =&gt; x.Extension == &quot;.txt&quot; || x.Extension == &quot;.cs&quot;);
    /// 
    ///                   // Unit Test
    ///                   Assert.AreEqual(2, result.Length);
    ///               }
    ///           }
    ///       }
    /// </code>
    /// </example>
    /// <example>
    ///     <code>
    ///       using System;
    ///       using System.IO;
    ///       using Microsoft.VisualStudio.TestTools.UnitTesting;
    ///       using Z.ExtensionMethods;
    /// 
    ///       namespace ExtensionMethods.Examples
    ///       {
    ///           [TestClass]
    ///           public class System_IO_DirectoryInfo_GetFilesWhere
    ///           {
    ///               [TestMethod]
    ///               public void GetFilesWhere()
    ///               {
    ///                   // Type
    ///                   var root = new DirectoryInfo(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, &quot;System_IO_DirectoryInfo_GetFilesWhere&quot;));
    ///                   Directory.CreateDirectory(root.FullName);
    /// 
    ///                   var file1 = new FileInfo(Path.Combine(root.FullName, &quot;test.txt&quot;));
    ///                   var file2 = new FileInfo(Path.Combine(root.FullName, &quot;test.cs&quot;));
    ///                   var file3 = new FileInfo(Path.Combine(root.FullName, &quot;test.asp&quot;));
    ///                   file1.Create();
    ///                   file2.Create();
    ///                   file3.Create();
    /// 
    ///                   // Exemples
    ///                   FileInfo[] result = root.GetFilesWhere(x =&gt; x.Extension == &quot;.txt&quot; || x.Extension == &quot;.cs&quot;);
    /// 
    ///                   // Unit Test
    ///                   Assert.AreEqual(2, result.Length);
    ///               }
    ///           }
    ///       }
    /// </code>
    /// </example>
    /// ###
    /// <exception cref="T:System.ArgumentException">
    ///     <paramref name="this " />is a zero-length string, contains only
    ///     white space, or contains invalid characters as defined by
    ///     <see
    ///         cref="M:System.IO.Path.GetInvalidPathChars" />
    ///     .- or -<paramref name="searchPattern" /> does not contain a valid pattern.
    /// </exception>
    /// ###
    /// <exception cref="T:System.ArgumentNullException">
    ///     <paramref name="this" /> is null.-or-
    ///     <paramref name="searchPattern" /> is null.
    /// </exception>
    /// ###
    /// <exception cref="T:System.ArgumentOutOfRangeException">
    ///     <paramref name="searchOption" /> is not a valid
    ///     <see cref="T:System.IO.SearchOption" /> value.
    /// </exception>
    /// ###
    /// <exception cref="T:System.IO.DirectoryNotFoundException">
    ///     <paramref name="this" /> is invalid, such as
    ///     referring to an unmapped drive.
    /// </exception>
    /// ###
    /// <exception cref="T:System.IO.IOException">
    ///     <paramref name="this" /> is a file name.
    /// </exception>
    /// ###
    /// <exception cref="T:System.IO.PathTooLongException">
    ///     The specified @this, file name, or combined exceed the
    ///     system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters
    ///     and file names must be less than 260 characters.
    /// </exception>
    /// ###
    /// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission.</exception>
    /// ###
    /// <exception cref="T:System.UnauthorizedAccessException">The caller does not have the required permission.</exception>
    public static FileInfo[] GetFilesWhere(this DirectoryInfo @this, String searchPattern, SearchOption searchOption, Func<FileInfo, bool> predicate)
    {
        return Directory.EnumerateFiles(@this.FullName, searchPattern, searchOption).Select(x => new FileInfo(x)).Where(x => predicate(x)).ToArray();
    }

    /// <summary>
    ///     Returns an enumerable collection of file names that match a search pattern in a specified @this.
    /// </summary>
    /// <param name="this">The directory to search.</param>
    /// <param name="searchPatterns">The search string to match against the names of directories in.</param>
    /// <param name="predicate">The predicate.</param>
    /// <returns>
    ///     An enumerable collection of the full names (including paths) for the files in the directory specified by
    ///     <paramref
    ///         name="this" />
    ///     and that match the specified search pattern.
    /// </returns>
    /// <example>
    ///     <code>
    ///       using System;
    ///       using System.IO;
    ///       using Microsoft.VisualStudio.TestTools.UnitTesting;
    /// 
    /// 
    ///       namespace ExtensionMethods.Examples
    ///       {
    ///           [TestClass]
    ///           public class System_IO_DirectoryInfo_GetFilesWhere
    ///           {
    ///               [TestMethod]
    ///               public void GetFilesWhere()
    ///               {
    ///                   // Type
    ///                   var root = new DirectoryInfo(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, &quot;System_IO_DirectoryInfo_GetFilesWhere&quot;));
    ///                   Directory.CreateDirectory(root.FullName);
    /// 
    ///                   var file1 = new FileInfo(Path.Combine(root.FullName, &quot;test.txt&quot;));
    ///                   var file2 = new FileInfo(Path.Combine(root.FullName, &quot;test.cs&quot;));
    ///                   var file3 = new FileInfo(Path.Combine(root.FullName, &quot;test.asp&quot;));
    ///                   file1.Create();
    ///                   file2.Create();
    ///                   file3.Create();
    /// 
    ///                   // Exemples
    ///                   FileInfo[] result = root.GetFilesWhere(x =&gt; x.Extension == &quot;.txt&quot; || x.Extension == &quot;.cs&quot;);
    /// 
    ///                   // Unit Test
    ///                   Assert.AreEqual(2, result.Length);
    ///               }
    ///           }
    ///       }
    /// </code>
    /// </example>
    /// <example>
    ///     <code>
    ///       using System;
    ///       using System.IO;
    ///       using Microsoft.VisualStudio.TestTools.UnitTesting;
    ///       using Z.ExtensionMethods;
    /// 
    ///       namespace ExtensionMethods.Examples
    ///       {
    ///           [TestClass]
    ///           public class System_IO_DirectoryInfo_GetFilesWhere
    ///           {
    ///               [TestMethod]
    ///               public void GetFilesWhere()
    ///               {
    ///                   // Type
    ///                   var root = new DirectoryInfo(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, &quot;System_IO_DirectoryInfo_GetFilesWhere&quot;));
    ///                   Directory.CreateDirectory(root.FullName);
    /// 
    ///                   var file1 = new FileInfo(Path.Combine(root.FullName, &quot;test.txt&quot;));
    ///                   var file2 = new FileInfo(Path.Combine(root.FullName, &quot;test.cs&quot;));
    ///                   var file3 = new FileInfo(Path.Combine(root.FullName, &quot;test.asp&quot;));
    ///                   file1.Create();
    ///                   file2.Create();
    ///                   file3.Create();
    /// 
    ///                   // Exemples
    ///                   FileInfo[] result = root.GetFilesWhere(x =&gt; x.Extension == &quot;.txt&quot; || x.Extension == &quot;.cs&quot;);
    /// 
    ///                   // Unit Test
    ///                   Assert.AreEqual(2, result.Length);
    ///               }
    ///           }
    ///       }
    /// </code>
    /// </example>
    /// ###
    /// <param name="searchPattern">
    ///     The search string to match against the names of directories in
    ///     <paramref name="this" />.
    /// </param>
    /// ###
    /// <exception cref="T:System.ArgumentException">
    ///     <paramref name="this " />is a zero-length string, contains only
    ///     white space, or contains invalid characters as defined by
    ///     <see
    ///         cref="M:System.IO.Path.GetInvalidPathChars" />
    ///     .- or -<paramref name="searchPattern" /> does not contain a valid pattern.
    /// </exception>
    /// ###
    /// <exception cref="T:System.ArgumentNullException">
    ///     <paramref name="this" /> is null.-or-
    ///     <paramref name="searchPattern" /> is null.
    /// </exception>
    /// ###
    /// <exception cref="T:System.IO.DirectoryNotFoundException">
    ///     <paramref name="this" /> is invalid, such as
    ///     referring to an unmapped drive.
    /// </exception>
    /// ###
    /// <exception cref="T:System.IO.IOException">
    ///     <paramref name="this" /> is a file name.
    /// </exception>
    /// ###
    /// <exception cref="T:System.IO.PathTooLongException">
    ///     The specified @this, file name, or combined exceed the
    ///     system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters
    ///     and file names must be less than 260 characters.
    /// </exception>
    /// ###
    /// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission.</exception>
    /// ###
    /// <exception cref="T:System.UnauthorizedAccessException">The caller does not have the required permission.</exception>
    public static FileInfo[] GetFilesWhere(this DirectoryInfo @this, String[] searchPatterns, Func<FileInfo, bool> predicate)
    {
        return searchPatterns.SelectMany(x => @this.GetFiles(x)).Distinct().Where(x => predicate(x)).ToArray();
    }

    /// <summary>
    ///     Returns an enumerable collection of file names that match a search pattern in a specified @this, and
    ///     optionally searches subdirectories.
    /// </summary>
    /// <param name="this">The directory to search.</param>
    /// <param name="searchPatterns">
    ///     The search string to match against the names of directories in
    ///     <paramref name="this" />.
    /// </param>
    /// <param name="searchOption">
    ///     One of the enumeration values that specifies whether the search operation should
    ///     include only the current directory or should include all subdirectories.The default value is
    ///     <see
    ///         cref="F:System.IO.SearchOption.TopDirectoryOnly" />
    ///     .
    /// </param>
    /// <param name="predicate">The predicate.</param>
    /// <returns>
    ///     An enumerable collection of the full names (including paths) for the files in the directory specified by
    ///     <paramref
    ///         name="this" />
    ///     and that match the specified search pattern and option.
    /// </returns>
    /// <example>
    ///     <code>
    ///       using System;
    ///       using System.IO;
    ///       using Microsoft.VisualStudio.TestTools.UnitTesting;
    /// 
    /// 
    ///       namespace ExtensionMethods.Examples
    ///       {
    ///           [TestClass]
    ///           public class System_IO_DirectoryInfo_GetFilesWhere
    ///           {
    ///               [TestMethod]
    ///               public void GetFilesWhere()
    ///               {
    ///                   // Type
    ///                   var root = new DirectoryInfo(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, &quot;System_IO_DirectoryInfo_GetFilesWhere&quot;));
    ///                   Directory.CreateDirectory(root.FullName);
    /// 
    ///                   var file1 = new FileInfo(Path.Combine(root.FullName, &quot;test.txt&quot;));
    ///                   var file2 = new FileInfo(Path.Combine(root.FullName, &quot;test.cs&quot;));
    ///                   var file3 = new FileInfo(Path.Combine(root.FullName, &quot;test.asp&quot;));
    ///                   file1.Create();
    ///                   file2.Create();
    ///                   file3.Create();
    /// 
    ///                   // Exemples
    ///                   FileInfo[] result = root.GetFilesWhere(x =&gt; x.Extension == &quot;.txt&quot; || x.Extension == &quot;.cs&quot;);
    /// 
    ///                   // Unit Test
    ///                   Assert.AreEqual(2, result.Length);
    ///               }
    ///           }
    ///       }
    /// </code>
    /// </example>
    /// <example>
    ///     <code>
    ///       using System;
    ///       using System.IO;
    ///       using Microsoft.VisualStudio.TestTools.UnitTesting;
    ///       using Z.ExtensionMethods;
    /// 
    ///       namespace ExtensionMethods.Examples
    ///       {
    ///           [TestClass]
    ///           public class System_IO_DirectoryInfo_GetFilesWhere
    ///           {
    ///               [TestMethod]
    ///               public void GetFilesWhere()
    ///               {
    ///                   // Type
    ///                   var root = new DirectoryInfo(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, &quot;System_IO_DirectoryInfo_GetFilesWhere&quot;));
    ///                   Directory.CreateDirectory(root.FullName);
    /// 
    ///                   var file1 = new FileInfo(Path.Combine(root.FullName, &quot;test.txt&quot;));
    ///                   var file2 = new FileInfo(Path.Combine(root.FullName, &quot;test.cs&quot;));
    ///                   var file3 = new FileInfo(Path.Combine(root.FullName, &quot;test.asp&quot;));
    ///                   file1.Create();
    ///                   file2.Create();
    ///                   file3.Create();
    /// 
    ///                   // Exemples
    ///                   FileInfo[] result = root.GetFilesWhere(x =&gt; x.Extension == &quot;.txt&quot; || x.Extension == &quot;.cs&quot;);
    /// 
    ///                   // Unit Test
    ///                   Assert.AreEqual(2, result.Length);
    ///               }
    ///           }
    ///       }
    /// </code>
    /// </example>
    /// ###
    /// <exception cref="T:System.ArgumentException">
    ///     <paramref name="this " />is a zero-length string, contains only
    ///     white space, or contains invalid characters as defined by
    ///     <see
    ///         cref="M:System.IO.Path.GetInvalidPathChars" />
    ///     .- or -<paramref name="searchPattern" /> does not contain a valid pattern.
    /// </exception>
    /// ###
    /// <exception cref="T:System.ArgumentNullException">
    ///     <paramref name="this" /> is null.-or-
    ///     <paramref name="searchPattern" /> is null.
    /// </exception>
    /// ###
    /// <exception cref="T:System.ArgumentOutOfRangeException">
    ///     <paramref name="searchOption" /> is not a valid
    ///     <see cref="T:System.IO.SearchOption" /> value.
    /// </exception>
    /// ###
    /// <exception cref="T:System.IO.DirectoryNotFoundException">
    ///     <paramref name="this" /> is invalid, such as
    ///     referring to an unmapped drive.
    /// </exception>
    /// ###
    /// <exception cref="T:System.IO.IOException">
    ///     <paramref name="this" /> is a file name.
    /// </exception>
    /// ###
    /// <exception cref="T:System.IO.PathTooLongException">
    ///     The specified @this, file name, or combined exceed the
    ///     system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters
    ///     and file names must be less than 260 characters.
    /// </exception>
    /// ###
    /// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission.</exception>
    /// ###
    /// <exception cref="T:System.UnauthorizedAccessException">The caller does not have the required permission.</exception>
    public static FileInfo[] GetFilesWhere(this DirectoryInfo @this, String[] searchPatterns, SearchOption searchOption, Func<FileInfo, bool> predicate)
    {
        return searchPatterns.SelectMany(x => @this.GetFiles(x, searchOption)).Distinct().Where(x => predicate(x)).ToArray();
    }
}