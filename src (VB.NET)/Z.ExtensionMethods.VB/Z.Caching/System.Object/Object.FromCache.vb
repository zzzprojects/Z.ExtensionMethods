
'' Copyright (c) 2015 ZZZ Projects. All rights reserved
'' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
'' Website: http://www.zzzprojects.com/
'' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
'' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

'Imports System.Linq.Expressions
'Imports System.Runtime.Caching

'Public Module Extensions_0

'    ''' <summary>A TKey extension method that from cache.</summary>
'    ''' <typeparam name="T">Generic type parameter.</typeparam>
'    ''' <typeparam name="TValue">Type of the value.</typeparam>
'    ''' <param name="this">The @this to act on.</param>
'    ''' <param name="cache">The cache.</param>
'    ''' <param name="key">The key.</param>
'    ''' <param name="value">The value.</param>
'    ''' <returns>A TValue.</returns>
'    <System.Runtime.CompilerServices.Extension> _
'    Public Function FromCache(Of T, TValue)(this As T, cache As MemoryCache, key As String, value As TValue) As TValue
'        Dim item As Object = If(cache.AddOrGetExisting(key, value, New CacheItemPolicy()), value)

'        Return DirectCast(item, TValue)
'    End Function

'    ''' <summary>A TKey extension method that from cache.</summary>
'    ''' <typeparam name="T">Generic type parameter.</typeparam>
'    ''' <typeparam name="TValue">Type of the value.</typeparam>
'    ''' <param name="this">The @this to act on.</param>
'    ''' <param name="key">The key.</param>
'    ''' <param name="value">The value.</param>
'    ''' <returns>A TValue.</returns>
'    <System.Runtime.CompilerServices.Extension> _
'    Public Function FromCache(Of T, TValue)(this As T, key As String, value As TValue) As TValue
'        Return this.FromCache(MemoryCache.[Default], key, value)
'    End Function

'    ''' <summary>A TKey extension method that from cache.</summary>
'    ''' <typeparam name="T">Generic type parameter.</typeparam>
'    ''' <typeparam name="TValue">Type of the value.</typeparam>
'    ''' <param name="this">The @this to act on.</param>
'    ''' <param name="cache">The cache.</param>
'    ''' <param name="key">The key.</param>
'    ''' <param name="valueFactory">The value factory.</param>
'    ''' <returns>A TValue.</returns>
'    <System.Runtime.CompilerServices.Extension> _
'    Public Function FromCache(Of T, TValue)(this As T, cache As MemoryCache, key As String, valueFactory As Expression(Of Func(Of T, TValue))) As TValue
'        Dim lazy = New Lazy(Of TValue)(Function() valueFactory.Compile()(this))
'        Dim item As Lazy(Of TValue) = If(DirectCast(cache.AddOrGetExisting(key, lazy, New CacheItemPolicy()), Lazy(Of TValue)), lazy)
'        Return item.Value
'    End Function

'    ''' <summary>A TKey extension method that from cache.</summary>
'    ''' <typeparam name="T">Generic type parameter.</typeparam>
'    ''' <typeparam name="TValue">Type of the value.</typeparam>
'    ''' <param name="this">The @this to act on.</param>
'    ''' <param name="key">The key.</param>
'    ''' <param name="valueFactory">The value factory.</param>
'    ''' <returns>A TValue.</returns>
'    <System.Runtime.CompilerServices.Extension> _
'    Public Function FromCache(Of T, TValue)(this As T, key As String, valueFactory As Expression(Of Func(Of T, TValue))) As TValue
'        Return this.FromCache(MemoryCache.[Default], key, valueFactory)
'    End Function

'    ''' <summary>A TKey extension method that from cache.</summary>
'    ''' <typeparam name="TKey">Type of the key.</typeparam>
'    ''' <typeparam name="TValue">Type of the value.</typeparam>
'    ''' <param name="this">The @this to act on.</param>
'    ''' <param name="valueFactory">The value factory.</param>
'    ''' <returns>A TValue.</returns>
'    <System.Runtime.CompilerServices.Extension> _
'    Public Function FromCache(Of TKey, TValue)(this As TKey, valueFactory As Expression(Of Func(Of TKey, TValue))) As TValue
'        Dim key As String = String.Concat("Z.Caching.FromCache;", GetType(TKey).FullName, valueFactory.ToString())
'        Return this.FromCache(MemoryCache.[Default], key, valueFactory)
'    End Function

'    ''' <summary>A TKey extension method that from cache.</summary>
'    ''' <typeparam name="TKey">Type of the key.</typeparam>
'    ''' <typeparam name="TValue">Type of the value.</typeparam>
'    ''' <param name="this">The @this to act on.</param>
'    ''' <param name="cache">The cache.</param>
'    ''' <param name="valueFactory">The value factory.</param>
'    ''' <returns>A TValue.</returns>
'    <System.Runtime.CompilerServices.Extension> _
'    Public Function FromCache(Of TKey, TValue)(this As TKey, cache As MemoryCache, valueFactory As Expression(Of Func(Of TKey, TValue))) As TValue
'        Dim key As String = String.Concat("Z.Caching.FromCache;", GetType(TKey).FullName, valueFactory.ToString())
'        Return this.FromCache(cache, key, valueFactory)
'    End Function
'End Module


